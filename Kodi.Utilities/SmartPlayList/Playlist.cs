using PCLStorage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.SmartPlayList
{
    public class Playlist
    {
        #region Privates
        #endregion

        #region Properties
        public string Name { get; set; }
        #endregion

        #region Constructors
        public Playlist(string name)
        {
            this.Name = name;
        }
        #endregion

        #region Static Methods
        public static Playlist LoadFromStream(Stream stream)
        {
            return new Playlist("test");
        }

        public static async Task<Playlist> LoadFromFile(string path)
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

    }
}
