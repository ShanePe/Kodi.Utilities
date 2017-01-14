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
    public class SmartPlayList
    {
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

        #region Privates
        #endregion

        #region Properties
        public string Name { get; set; }
        public Types Type { get; set; } = Types.Songs;
        public RuleCollection Rules { get; set; } = new RuleCollection();
        #endregion

        #region Constructors
        public SmartPlayList(string name)
        {
            this.Name = name;
        }
        #endregion

        #region Static Methods
        public static SmartPlayList LoadFromStream(Stream stream)
        {
            SmartPlayList playlist = new SmartPlayList("test");
            return playlist;
        }

        public static SmartPlayList LoadFromFile(string path)
        {
            Task<SmartPlayList> playlistTask = LoadFromFileSystem(path);
            playlistTask.Start();
            playlistTask.Wait();

            if (playlistTask.IsFaulted)
                throw playlistTask.Exception;

            return playlistTask.Result;

        }

        internal static async Task<SmartPlayList> LoadFromFileSystem(string path)
        {
            IFile file = await FileSystem.Current.GetFileFromPathAsync(path);
            if (file == null)
                throw new FileNotFoundException("Could not load file", path);

            using (Stream filestream = await file.OpenAsync(FileAccess.Read))
            {
                return LoadFromStream(filestream);
            }
        }
        #endregion

        #region Methods
        public RuleCollection GetAvailableFields()
        {
            RuleCollection available = new RuleCollection();

            Assembly assembly = this.GetType().GetTypeInfo().Assembly;
            TypeInfo IRuleTInfo = typeof(IRule).GetTypeInfo();

            available.AddRange(assembly.DefinedTypes.Where(t => IRuleTInfo.IsAssignableFrom(t) && !t.IsAbstract)
                                 .Select(r => (IRule)Activator.CreateInstance(r.AsType()))
                                 .Where(ri => ri.IsAllowedForPlaylistType(Type)));

            return available;
        }
        #endregion
    }
}
