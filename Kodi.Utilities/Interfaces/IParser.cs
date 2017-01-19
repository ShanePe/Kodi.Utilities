using Kodi.Utilities.Exceptions;
using Kodi.Utilities.Playlist;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Kodi.Utilities.Interfaces
{
    public abstract class IParser
    {
        public abstract SmartPlayList ParserStream(Stream stream);
        public abstract void WriteToStream(Stream stream, SmartPlayList playlistToWrite);

        public virtual void SetPlaylistType(string type, ref SmartPlayList playlist)
        {
            if (playlist == null)
                playlist = new SmartPlayList();

            playlist.Type = (SmartPlayList.Types)Enum.Parse(typeof(SmartPlayList.Types), type, true);
        }

        public virtual void SetPlaylistName(string value, ref SmartPlayList playlist)
        {
            if (playlist == null)
                playlist = new SmartPlayList();

            playlist.Name = value;
        }

        public virtual void SetPlaylistMatch(string value, ref SmartPlayList playlist)
        {
            if (playlist == null)
                playlist = new SmartPlayList();

            playlist.Match = (SmartPlayList.MatchOptions)Enum.Parse(typeof(SmartPlayList.MatchOptions), value, true);
        }

        public virtual void SetPlaylistLimit(string value, ref SmartPlayList playlist)
        {
            if (playlist == null)
                playlist = new SmartPlayList();

            playlist.Limit = int.Parse(value);
        }

        public virtual void AddPlaylistRule(string name, string oper, List<string> values, ref SmartPlayList playlist)
        {
            if (playlist == null)
                playlist = new SmartPlayList();

            TypeInfo IRuleTInfo = typeof(IRule).GetTypeInfo();
            Assembly assembly = IRuleTInfo.Assembly;

            IRule field = playlist.GetAvailableFields()
                                  .FirstOrDefault(ri => ri.Field.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (field == null)
                throw new RuleParseException("Field", Enum.GetName(typeof(SmartPlayList.Types), playlist.Type), name);

            IOperator operatr = field.GetAvailableOperators()
                                      .FirstOrDefault(t => t.Name.Equals(oper, StringComparison.OrdinalIgnoreCase));

            if (oper == null)
                throw new RuleParseException("Operator", field.FriendlyName, oper);

            field.Values.AddRange(values);
            field.Operator = operatr;
            playlist.Rules.Add(field);
        }

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
