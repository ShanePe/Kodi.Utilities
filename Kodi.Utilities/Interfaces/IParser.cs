using Kodi.Utilities.Exceptions;
using Kodi.Utilities.Playlist;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Kodi.Utilities.Interfaces
{
    /// <summary>
    /// Interface for IO parsers
    /// </summary>
    public abstract class IParser
    {
        /// <summary>
        /// Parsers the stream.
        /// </summary>
        /// <param name="stream">The stream.</param>
        /// <returns></returns>
        public abstract SmartPlayList ParserStream(Stream stream);

        /// <summary>
        /// Writes to stream.
        /// </summary>
        /// <param name="stream">The stream.</param>
        /// <param name="playlistToWrite">The playlist to write.</param>
        public abstract void WriteToStream(Stream stream, SmartPlayList playlistToWrite);

        /// <summary>
        /// Sets the playlist type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="playlist">The playlist.</param>
        public virtual void SetPlaylistType(string type, ref SmartPlayList playlist)
        {
            if (playlist == null)
                playlist = new SmartPlayList();

            playlist.MediaType = (SmartPlayList.Types)Enum.Parse(typeof(SmartPlayList.Types), type, true);
        }

        /// <summary>
        /// Sets the playlist name.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="playlist">The playlist.</param>
        public virtual void SetPlaylistName(string value, ref SmartPlayList playlist)
        {
            if (playlist == null)
                playlist = new SmartPlayList();

            playlist.Name = value;
        }

        /// <summary>
        /// Sets the playlist match.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="playlist">The playlist.</param>
        public virtual void SetPlaylistMatch(string value, ref SmartPlayList playlist)
        {
            if (playlist == null)
                playlist = new SmartPlayList();

            playlist.MatchOn = (SmartPlayList.MatchOptions)Enum.Parse(typeof(SmartPlayList.MatchOptions), value, true);
        }

        /// <summary>
        /// Sets the playlist group.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="mixed">The mixed.</param>
        /// <param name="playlist">The playlist.</param>
        /// <exception cref="RuleParseException">Group - Group</exception>
        public virtual void SetPlaylistGroup(string value, string mixed, ref SmartPlayList playlist)
        {
            if (playlist == null)
                playlist = new SmartPlayList();

            IGroup group = playlist.GetAvailableGroups()
                                  .FirstOrDefault(ri => ri.Name.Equals(value, StringComparison.OrdinalIgnoreCase));

            if (group == null)
                throw new RuleParseException("Group", "Group", value);

            bool bMix = false;
            if (bool.TryParse(mixed, out bMix))
                group.Mixed = bMix;

            playlist.Group = group;
        }

        /// <summary>
        /// Sets the playlist limit.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="playlist">The playlist.</param>
        public virtual void SetPlaylistLimit(string value, ref SmartPlayList playlist)
        {
            if (playlist == null)
                playlist = new SmartPlayList();

            int lim = 0;
            if (int.TryParse(value, out lim))
                playlist.Limit = lim;
        }

        /// <summary>
        /// Adds the playlist rule.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="oper">The oper.</param>
        /// <param name="values">The values.</param>
        /// <param name="playlist">The playlist.</param>
        /// <exception cref="RuleParseException">
        /// Field
        /// or
        /// Operator
        /// </exception>
        public virtual void AddPlaylistRule(string name, string oper, List<string> values, ref SmartPlayList playlist)
        {
            if (playlist == null)
                playlist = new SmartPlayList();

            TypeInfo IRuleTInfo = typeof(IRule).GetTypeInfo();
            Assembly assembly = IRuleTInfo.Assembly;

            IRule field = playlist.GetAvailableFields()
                                  .FirstOrDefault(ri => ri.Field.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (field == null)
                throw new RuleParseException("Field", Enum.GetName(typeof(SmartPlayList.Types), playlist.MediaType), name);

            IOperator operatr = field.GetAvailableOperators()
                                      .FirstOrDefault(t => t.Name.Equals(oper, StringComparison.OrdinalIgnoreCase));

            if (operatr == null)
                throw new RuleParseException("Operator", field.FriendlyName, oper);

            if (!operatr.NoValue)
                field.Values.AddRange(values);
            field.Operator = operatr;
            playlist.Rules.Add(field);
        }

        /// <summary>
        /// Sets the play list sort field.
        /// </summary>
        /// <param name="field">The field.</param>
        /// <param name="direction">The direction.</param>
        /// <param name="playlist">The playlist.</param>
        /// <exception cref="RuleParseException">Field - Sort</exception>
        public virtual void SetPlayListSortField(string field, string direction, ref SmartPlayList playlist)
        {
            TypeInfo IRuleTInfo = typeof(IRule).GetTypeInfo();
            Assembly assembly = IRuleTInfo.Assembly;

            IRule sortField = assembly.DefinedTypes.Where(t => IRuleTInfo.IsAssignableFrom(t) && !t.IsAbstract)
                                 .Select(r => (IRule)Activator.CreateInstance(r.AsType()))
                                 .FirstOrDefault(ri => ri.Field.Equals(field, StringComparison.OrdinalIgnoreCase));

            if (sortField == null)
                throw new RuleParseException("Field", "Sort", field);

            sortField.Sort = (IRule.SortOptions)Enum.Parse(typeof(IRule.SortOptions), direction, true);

            playlist.OrderBy = sortField;
        }
    }
}
