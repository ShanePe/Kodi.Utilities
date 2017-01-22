using Kodi.Utilities.Collection;
using Kodi.Utilities.Exceptions;
using Kodi.Utilities.Interfaces;
using Kodi.Utilities.Parsers;
using Kodi.Utilities.Validators;
using PCLStorage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml;
using lta = Kodi.Utilities.Attributes.ListTypeAllocationAttribute;

namespace Kodi.Utilities.Playlist
{
    /// <summary>
    /// Smart kodi playlist.
    /// </summary>
    public class SmartPlayList
    {
        private Dictionary<lta.AppliesTos, Array> _available = new Dictionary<lta.AppliesTos, Array>();
        private Types _type = Types.Songs;
        private IRule _orderBy = null;
        private IGroup _group = null;

        /// <summary>
        /// Playlist types
        /// </summary>
        public enum Types
        {
            Songs,
            Albums,
            Artists,
            Movies,
            TVShows,
            Episodes,
            MusicVideos,
            Mixed
        };

        /// <summary>
        /// Match on
        /// </summary>
        public enum MatchOptions
        {
            /// <summary>
            /// All rules must match
            /// </summary>
            All,
            /// <summary>
            /// Only one rule needs to match
            /// </summary>
            One
        }

        #region Privates
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public Types MediaType
        {
            get { return _type; }
            set
            {
                if (_type != value)
                    Reset();
                _type = value;
            }
        }
        /// <summary>
        /// Gets or sets the rules.
        /// </summary>
        /// <value>
        /// The rules.
        /// </value>
        public RuleCollection Rules { get; set; }
        /// <summary>
        /// Gets or sets the match.
        /// </summary>
        /// <value>
        /// The match.
        /// </value>
        public MatchOptions MatchOn { get; set; } = MatchOptions.All;
        /// <summary>
        /// Gets or sets the limit.
        /// </summary>
        /// <value>
        /// The limit.
        /// </value>
        public int Limit { get; set; }
        /// <summary>
        /// Gets the sort field.
        /// </summary>
        /// <value>
        /// The sort field.
        /// </value>
        public IRule OrderBy
        {
            get { return _orderBy; }
            set
            {
                if (value != null)
                    if (!value.IsOrderByForPlaylist(this.MediaType))
                        throw new InvalidOrderByException(value, this.MediaType);
                _orderBy = value;
            }
        }
        /// <summary>
        /// Gets or sets the group.
        /// </summary>
        /// <value>
        /// The group.
        /// </value>
        public IGroup Group
        {
            get { return _group; }
            set
            {
                if (value != null)
                    if (!value.IsGroupForPlaylist(this.MediaType))
                        throw new InvalidGroupException(value, this.MediaType);
                _group = value;
            }
        }

        #endregion

        #region Constructors
        public SmartPlayList()
        {
            Rules = new RuleCollection(this);
        }
        #endregion

        #region Static Methods
        /// <summary>
        /// Loads from stream.
        /// </summary>
        /// <param name="stream">The stream.</param>
        /// <param name="parser">The parser.</param>
        /// <returns></returns>
        public static SmartPlayList LoadFromStream(Stream stream, IParser parser)
        {
            return parser.ParserStream(stream);
        }

        /// <summary>
        /// Loads from stream.
        /// </summary>
        /// <param name="stream">The stream.</param>
        /// <returns></returns>
        public static SmartPlayList LoadFromStream(Stream stream)
        {
            return LoadFromStream(stream, new XmlParser());
        }

        /// <summary>
        /// Loads from file.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="parser">The parser.</param>
        /// <returns></returns>
        public static SmartPlayList LoadFromFile(string path, IParser parser)
        {
            try
            {
                Task<SmartPlayList> runTask = Task.Run<SmartPlayList>(() => { return LoadFromFileSystem(path, parser); });
                runTask.Wait();

                if (runTask.IsFaulted)
                    throw runTask.Exception;

                return runTask.Result;
            }
            catch (AggregateException aggEX)
            {
                throw aggEX.GetBaseException();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Loads from file.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        public static SmartPlayList LoadFromFile(string path)
        {
            return LoadFromFile(path, new XmlParser());
        }

        /// <summary>
        /// Loads from file system.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="parser">The parser.</param>
        /// <returns></returns>
        /// <exception cref="System.IO.FileNotFoundException">Could not load file</exception>
        internal static async Task<SmartPlayList> LoadFromFileSystem(string path, IParser parser)
        {
            IFile file = await FileSystem.Current.GetFileFromPathAsync(path);
            if (file == null)
                throw new FileNotFoundException("Could not load file", path);

            using (Stream filestream = await file.OpenAsync(FileAccess.Read))
            {
                return LoadFromStream(filestream, parser);
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Gets the available fields.
        /// </summary>
        /// <returns></returns>
        public IRule[] GetAvailableFields()
        {
            if (!_available.ContainsKey(lta.AppliesTos.SmartPlaylist))
            {
                IRule[] col = SmartPlayList.GetAll<IRule>()
                    .Where(ri => ri.IsFieldForPlaylist(MediaType)).ToArray();

                _available.Add(lta.AppliesTos.SmartPlaylist, col);
            }
            return (IRule[])_available[lta.AppliesTos.SmartPlaylist];
        }

        /// <summary>
        /// Gets the available order by.
        /// </summary>
        /// <returns></returns>
        public IRule[] GetAvailableOrderBy()
        {
            if (!_available.ContainsKey(lta.AppliesTos.OrderBy))
            {
                IRule[] col = SmartPlayList.GetAll<IRule>()
                    .Where(ri => ri.IsOrderByForPlaylist(MediaType)).ToArray();

                _available.Add(lta.AppliesTos.OrderBy, col);
            }
            return (IRule[])_available[lta.AppliesTos.OrderBy];
        }

        /// <summary>
        /// Gets the available groups.
        /// </summary>
        /// <returns></returns>
        public IGroup[] GetAvailableGroups()
        {
            if (!_available.ContainsKey(lta.AppliesTos.Group))
            {
                IGroup[] col = SmartPlayList.GetAll<IGroup>()
                    .Where(ri => ri.IsGroupForPlaylist(MediaType)).ToArray();

                _available.Add(lta.AppliesTos.Group, col);
            }
            return (IGroup[])_available[lta.AppliesTos.Group];
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<T> GetAll<T>() where T : IAllocatable
        {
            TypeInfo tInfo = typeof(T).GetTypeInfo();
            Assembly assembly = tInfo.Assembly;

            foreach (T item in assembly.DefinedTypes.Where(t => tInfo.IsAssignableFrom(t) && !t.IsAbstract)
                   .Select(r => (T)Activator.CreateInstance(r.AsType())))
                yield return item;
        }

        /// <summary>
        /// Writes to stream.
        /// </summary>
        /// <param name="stream">The stream.</param>
        /// <param name="parser">The parser.</param>
        public void Save(Stream stream, IParser parser)
        {
            PlaylistValidator validator = new PlaylistValidator();
            validator.Validate(this);

            parser.WriteToStream(stream, this);
        }

        /// <summary>
        /// Saves the specified stream.
        /// </summary>
        /// <param name="stream">The stream.</param>
        public void Save(Stream stream)
        {
            Save(stream, new XmlParser());
        }

        /// <summary>
        /// Writes to file.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="overwrite">if set to <c>true</c> [overwrite].</param>
        /// <param name="parser">The parser.</param>
        public void Save(string path, bool overwrite, IParser parser)
        {
            PlaylistValidator validator = new PlaylistValidator();
            validator.Validate(this);
            SaveAsync(path, overwrite, new XmlParser());
        }

        /// <summary>
        /// Saves the specified path.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="overwrite">if set to <c>true</c> [overwrite].</param>
        public void Save(string path, bool overwrite)
        {
            Save(path, overwrite, new XmlParser());
        }

        /// <summary>
        /// Saves the specified path.
        /// </summary>
        /// <param name="path">The path.</param>
        public void Save(string path)
        {
            Save(path, false);
        }

        /// <summary>
        /// Writes to file stream.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="overwrite">if set to <c>true</c> [overwrite].</param>
        /// <param name="parser">The parser.</param>
        /// <exception cref="System.IO.IOException"></exception>
        internal async void SaveAsync(string path, bool overwrite, IParser parser)
        {
            IFile file = await FileSystem.Current.GetFileFromPathAsync(path);
            if (file != null && !overwrite)
                throw new IOException($"{path} already exists.");
            else if (file != null && overwrite)
                await file.DeleteAsync();

            file = await FileSystem.Current.LocalStorage.CreateFileAsync(path, CreationCollisionOption.ReplaceExisting);

            using (Stream stream = await file.OpenAsync(FileAccess.ReadAndWrite))
            {
                Save(stream, parser);
            }
            file = null;
        }

        internal string GetPlayListEnumAsString(Type enumType, object value)
        {
            return Enum.GetName(enumType, value).ToLower();
        }

        /// <summary>
        /// Resets this instance.
        /// </summary>
        public void Reset()
        {
            _available.Clear();
            _orderBy = null;
            _group = null;
            Limit = 0;
            Rules.Clear();
            MatchOn = MatchOptions.All;
        }

        #endregion
    }
}
