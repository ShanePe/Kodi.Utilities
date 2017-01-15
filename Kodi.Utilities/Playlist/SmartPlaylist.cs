using Kodi.Utilities.Collection;
using Kodi.Utilities.Interfaces;
using PCLStorage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Kodi.Utilities.Playlist
{
    /// <summary>
    /// Smart kodi playlist.
    /// </summary>
    public class SmartPlayList
    {
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
        public Types Type { get; set; } = Types.Songs;
        /// <summary>
        /// Gets or sets the rules.
        /// </summary>
        /// <value>
        /// The rules.
        /// </value>
        public RuleCollection Rules { get; set; } = new RuleCollection();
        /// <summary>
        /// Gets or sets the match.
        /// </summary>
        /// <value>
        /// The match.
        /// </value>
        public MatchOptions Match { get; set; } = MatchOptions.All;
        /// <summary>
        /// Gets or sets the limit.
        /// </summary>
        /// <value>
        /// The limit.
        /// </value>
        public int Limit { get; set; } = 50;
        /// <summary>
        /// Gets the sort field.
        /// </summary>
        /// <value>
        /// The sort field.
        /// </value>
        public IRule SortField { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="SmartPlayList"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public SmartPlayList(string name)
        {
            this.Name = name;
        }

        internal SmartPlayList() { }
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
        /// Loads from file.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="parser">The parser.</param>
        /// <returns></returns>
        public static SmartPlayList LoadFromFile(string path, IParser parser)
        {
            Task<SmartPlayList> playlistTask = LoadFromFileSystem(path, parser);

            playlistTask.Wait();

            if (playlistTask.IsFaulted)
                throw playlistTask.Exception;

            return playlistTask.Result;

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
        public RuleCollection GetAvailableFields()
        {
            RuleCollection available = new RuleCollection();

            TypeInfo IRuleTInfo = typeof(IRule).GetTypeInfo();
            Assembly assembly = IRuleTInfo.Assembly;

            available.AddRange(assembly.DefinedTypes.Where(t => IRuleTInfo.IsAssignableFrom(t) && !t.IsAbstract)
                                 .Select(r => (IRule)Activator.CreateInstance(r.AsType()))
                                 .Where(ri => ri.IsAllowedForPlaylistType(Type)));

            return available;
        }
        #endregion
    }
}
