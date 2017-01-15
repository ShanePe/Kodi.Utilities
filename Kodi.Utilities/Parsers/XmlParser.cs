using Kodi.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kodi.Utilities.Playlist;
using System.IO;
using System.Xml;
using System.Collections.Specialized;

namespace Kodi.Utilities.Parsers
{
    public class XmlParser : IParser
    {
        public void Handle(XmlReader reader, ref SmartPlayList playlist)
        {
            switch (reader.Name.ToLower())
            {
                case "smartplaylist":
                    SetPlaylistType(reader.GetAttribute("type"), ref playlist);
                    break;

                case "name":
                    SetPlaylistName(reader.ReadElementContentAsString(), ref playlist);
                    break;

                case "match":
                    SetPlaylistMatch(reader.ReadElementContentAsString(), ref playlist);
                    break;

                case "order":
                    string direction = reader.GetAttribute("direction");
                    string sortField = reader.ReadElementContentAsString();

                    SetPlayListSortField(sortField, direction, ref playlist);

                    break;

                case "rule":
                    string field = reader.GetAttribute("field");
                    string op = reader.GetAttribute("operator");
                    StringBuilder values = new StringBuilder();

                    while (reader.Read())
                    {
                        if (reader.Name.ToLower() == "rule" && reader.NodeType == XmlNodeType.EndElement)
                            break;
                        if (reader.NodeType == XmlNodeType.Element && reader.Name.ToLower() == "value")
                        {
                            if (values.Length != 0)
                                values.Append("¿");
                            values.Append(reader.ReadElementContentAsString());
                        }
                    }

                    if (values.Length != 0)
                        AddPlaylistRule(field, op, values.ToString(), ref playlist);

                    break;

            }
        }

        public override SmartPlayList ParserStream(Stream stream)
        {
            SmartPlayList playList = null;
            stream.Position = 0;
            XmlReader reader = XmlReader.Create(stream);

            while (reader.Read())
                if (reader.NodeType == XmlNodeType.Element)
                    Handle(reader, ref playList);

            return playList;
        }
    }
}
