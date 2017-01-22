using Kodi.Utilities.Interfaces;
using System.Collections.Generic;
using Kodi.Utilities.Playlist;
using System.IO;
using System.Xml;
using System;
using System.Text;
using Kodi.Utilities.Exceptions;

namespace Kodi.Utilities.Parsers
{
    /// <summary>
    /// Write and reads the playlist via xml
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IParser" />
    public class XmlParser : IParser
    {
        internal struct XmlFileDefinition
        {
            public const string PlaylistNode = "smartplaylist";
            public const string PlaylistTypeAttr = "type";
            public const string NameNode = "name";
            public const string MatchNode = "match";
            public const string OrderNode = "order";
            public const string GroupNode = "group";
            public const string GroupMixedAttr = "mixed";
            public const string LimitNode = "limit";
            public const string OrderDirectionAttr = "direction";
            public const string RuleNode = "rule";
            public const string RuleOperatorAttr = "operator";
            public const string RuleFieldAttr = "field";
            public const string ValueNode = "value";
        }


        /// <summary>
        /// Handles the specified reader.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <param name="playlist">The playlist.</param>
        public void Handle(XmlReader reader, ref SmartPlayList playlist)
        {
            switch (reader.Name.ToLower())
            {
                case XmlFileDefinition.PlaylistNode:
                    SetPlaylistType(reader.GetAttribute(XmlFileDefinition.PlaylistTypeAttr), ref playlist);
                    break;

                case XmlFileDefinition.NameNode:
                    SetPlaylistName(reader.ReadElementContentAsString(), ref playlist);
                    break;

                case XmlFileDefinition.MatchNode:
                    SetPlaylistMatch(reader.ReadElementContentAsString(), ref playlist);
                    break;

                case XmlFileDefinition.OrderNode:
                    string direction = reader.GetAttribute(XmlFileDefinition.OrderDirectionAttr);
                    string sortField = reader.ReadElementContentAsString();

                    SetPlayListSortField(sortField, direction, ref playlist);
                    break;

                case XmlFileDefinition.GroupNode:
                    string mixed = reader.HasAttributes ?
                                    reader.GetAttribute(XmlFileDefinition.GroupMixedAttr) :
                                    "";
                    SetPlaylistGroup(reader.ReadElementContentAsString(), mixed, ref playlist);
                    break;

                case XmlFileDefinition.LimitNode:
                    SetPlaylistLimit(reader.ReadElementContentAsString(), ref playlist);
                    break;

                case XmlFileDefinition.RuleNode:
                    string field = reader.GetAttribute(XmlFileDefinition.RuleFieldAttr);
                    string op = reader.GetAttribute(XmlFileDefinition.RuleOperatorAttr);
                    List<string> values = new List<string>();

                    while (reader.Read())
                    {
                        if (reader.Name.ToLower() == XmlFileDefinition.RuleNode && reader.NodeType == XmlNodeType.EndElement)
                            break;
                        if (reader.Name.ToLower() == XmlFileDefinition.RuleNode && reader.NodeType == XmlNodeType.Element)
                        {
                            AddPlaylistRule(field, op, values, ref playlist);
                            Handle(reader, ref playlist);
                            break;
                        }
                        if (reader.NodeType == XmlNodeType.Element && reader.Name.ToLower() == XmlFileDefinition.ValueNode)
                            values.Add(reader.ReadElementContentAsString());
                    }

                    if (values.Count != 0)
                        AddPlaylistRule(field, op, values, ref playlist);

                    break;
            }
        }

        /// <summary>
        /// Parsers the stream.
        /// </summary>
        /// <param name="stream">The stream.</param>
        /// <returns></returns>
        /// <exception cref="Kodi.Utilities.Exceptions.InvalidPlayListFileException"></exception>
        public override SmartPlayList ParserStream(Stream stream)
        {
            try
            {
                SmartPlayList playList = null;
                stream.Position = 0;
                XmlReader reader = XmlReader.Create(stream);

                while (reader.Read())
                    if (reader.NodeType == XmlNodeType.Element)
                        Handle(reader, ref playList);

                return playList;
            }
            catch (XmlException)
            {
                throw new InvalidPlayListFileException();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Writes to stream.
        /// </summary>
        /// <param name="stream">The stream.</param>
        /// <param name="playlistToWrite">The playlist to write.</param>
        public override void WriteToStream(Stream stream, SmartPlayList playlistToWrite)
        {
            XmlWriterSettings settings = new XmlWriterSettings()
            {
                Encoding = UTF8Encoding.UTF8
            };

            XmlWriter writer = XmlWriter.Create(stream, settings);
            writer.WriteStartDocument(true);
            writer.WriteStartElement(XmlFileDefinition.PlaylistNode);
            writer.WriteAttributeString(XmlFileDefinition.PlaylistTypeAttr,
                playlistToWrite.GetPlayListEnumAsString(typeof(SmartPlayList.Types), playlistToWrite.MediaType));

            writer.WriteStartElement(XmlFileDefinition.NameNode);
            writer.WriteValue(playlistToWrite.Name);
            writer.WriteEndElement();

            writer.WriteStartElement(XmlFileDefinition.MatchNode);
            writer.WriteValue(playlistToWrite.GetPlayListEnumAsString(typeof(SmartPlayList.MatchOptions), playlistToWrite.MatchOn));
            writer.WriteEndElement();

            foreach (IRule rule in playlistToWrite.Rules)
            {
                writer.WriteStartElement(XmlFileDefinition.RuleNode);
                writer.WriteAttributeString(XmlFileDefinition.RuleFieldAttr, rule.Field);
                writer.WriteAttributeString(XmlFileDefinition.RuleOperatorAttr, rule.Operator.Name.ToLower());

                if (!rule.Operator.NoValue)
                    foreach (object o in rule.Values)
                    {
                        writer.WriteStartElement(XmlFileDefinition.ValueNode);
                        writer.WriteValue(IFormatter.Format(rule.UnderlyingType, o));
                        writer.WriteEndElement();
                    }

                writer.WriteEndElement();
            }

            if (playlistToWrite.Group != null)
            {
                writer.WriteStartElement(XmlFileDefinition.GroupNode);
                if (playlistToWrite.Group.Mixed)
                    writer.WriteAttributeString(XmlFileDefinition.GroupMixedAttr, playlistToWrite.Group.Mixed.ToString().ToLower());

                writer.WriteValue(playlistToWrite.Group.Name);
                writer.WriteEndElement();
            }

            if (playlistToWrite.Limit > 0)
            {
                writer.WriteStartElement(XmlFileDefinition.LimitNode);
                writer.WriteValue(playlistToWrite.Limit.ToString());
                writer.WriteEndElement();
            }

            if (playlistToWrite.OrderBy != null)
            {
                writer.WriteStartElement(XmlFileDefinition.OrderNode);
                writer.WriteAttributeString(XmlFileDefinition.OrderDirectionAttr,
                    playlistToWrite.GetPlayListEnumAsString(typeof(IRule.SortOptions), playlistToWrite.OrderBy.Sort));
                writer.WriteValue(playlistToWrite.OrderBy.Field);
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
            writer.WriteEndDocument();

            writer.Flush();
        }
    }

}
