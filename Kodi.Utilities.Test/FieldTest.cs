using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kodi.Utilities.Playlist.Fields;
using static Kodi.Utilities.Playlist.SmartPlayList;

namespace Kodi.Utilities.Test
{
    [TestClass]
    public class FieldTest
    {
        [TestMethod]
        public void GenreFieldAllocation()
        {
            Genre g = new Genre();
            Assert.AreEqual("genre", g.Name);
            Assert.AreEqual(typeof(string), g.UnderlyingType);
            Assert.IsTrue(g.IsAllowedForPlaylistType(Types.Albums));
            Assert.IsTrue(g.IsAllowedForPlaylistType(Types.Artists));
            Assert.IsTrue(g.IsAllowedForPlaylistType(Types.Episodes));
            Assert.IsTrue(g.IsAllowedForPlaylistType(Types.Mixed));
            Assert.IsTrue(g.IsAllowedForPlaylistType(Types.Movies));
            Assert.IsTrue(g.IsAllowedForPlaylistType(Types.MusicVideos));
            Assert.IsTrue(g.IsAllowedForPlaylistType(Types.Songs));
            Assert.IsTrue(g.IsAllowedForPlaylistType(Types.TVShows));
            
        }

        [TestMethod]
        public void ActorFieldAllocation()
        {
            Actor g = new Actor();
            Assert.AreEqual("actor", g.Name);
            Assert.AreEqual(typeof(string), g.UnderlyingType);
            Assert.IsFalse(g.IsAllowedForPlaylistType(Types.Albums));
            Assert.IsFalse(g.IsAllowedForPlaylistType(Types.Artists));
            Assert.IsTrue(g.IsAllowedForPlaylistType(Types.Episodes));
            Assert.IsTrue(g.IsAllowedForPlaylistType(Types.Mixed));
            Assert.IsTrue(g.IsAllowedForPlaylistType(Types.Movies));
            Assert.IsFalse(g.IsAllowedForPlaylistType(Types.MusicVideos));
            Assert.IsFalse(g.IsAllowedForPlaylistType(Types.Songs));
            Assert.IsTrue(g.IsAllowedForPlaylistType(Types.TVShows));
        }

        [TestMethod]
        public void AirDateFieldAllocation()
        {
            AirDate g = new AirDate();
            Assert.AreEqual("airdate", g.Name);
            Assert.AreEqual(typeof(DateTime), g.UnderlyingType);
            Assert.IsFalse(g.IsAllowedForPlaylistType(Types.Albums));
            Assert.IsFalse(g.IsAllowedForPlaylistType(Types.Artists));
            Assert.IsFalse(g.IsAllowedForPlaylistType(Types.Episodes));
            Assert.IsTrue(g.IsAllowedForPlaylistType(Types.Mixed));
            Assert.IsFalse(g.IsAllowedForPlaylistType(Types.Movies));
            Assert.IsFalse(g.IsAllowedForPlaylistType(Types.MusicVideos));
            Assert.IsFalse(g.IsAllowedForPlaylistType(Types.Songs));
            Assert.IsTrue(g.IsAllowedForPlaylistType(Types.TVShows));
        }

        [TestMethod]
        public void AlbumFieldAllocation()
        {
            Album g = new Album();
            Assert.AreEqual("album", g.Name);
            Assert.AreEqual(typeof(DateTime), g.UnderlyingType);
            Assert.IsTrue(g.IsAllowedForPlaylistType(Types.Albums));
            Assert.IsTrue(g.IsAllowedForPlaylistType(Types.Artists));
            Assert.IsFalse(g.IsAllowedForPlaylistType(Types.Episodes));
            Assert.IsTrue(g.IsAllowedForPlaylistType(Types.Mixed));
            Assert.IsFalse(g.IsAllowedForPlaylistType(Types.Movies));
            Assert.IsTrue(g.IsAllowedForPlaylistType(Types.MusicVideos));
            Assert.IsTrue(g.IsAllowedForPlaylistType(Types.Songs));
            Assert.IsFalse(g.IsAllowedForPlaylistType(Types.TVShows));
        }

        [TestMethod]
        public void AlbumArtistFieldAllocation()
        {
            AlbumArtist g = new AlbumArtist();
            Assert.AreEqual("albumartist", g.Name);
            Assert.AreEqual(typeof(string), g.UnderlyingType);
            Assert.IsTrue(g.IsAllowedForPlaylistType(Types.Albums));
            Assert.IsTrue(g.IsAllowedForPlaylistType(Types.Artists));
            Assert.IsFalse(g.IsAllowedForPlaylistType(Types.Episodes));
            Assert.IsTrue(g.IsAllowedForPlaylistType(Types.Mixed));
            Assert.IsFalse(g.IsAllowedForPlaylistType(Types.Movies));
            Assert.IsTrue(g.IsAllowedForPlaylistType(Types.MusicVideos));
            Assert.IsTrue(g.IsAllowedForPlaylistType(Types.Songs));
            Assert.IsFalse(g.IsAllowedForPlaylistType(Types.TVShows));
        }

        [TestMethod]
        public void ArtistFieldAllocation()
        {
            Artist g = new Artist();
            Assert.AreEqual("artist", g.Name);
            Assert.AreEqual(typeof(string), g.UnderlyingType);
            Assert.IsTrue(g.IsAllowedForPlaylistType(Types.Albums));
            Assert.IsFalse(g.IsAllowedForPlaylistType(Types.Artists));
            Assert.IsFalse(g.IsAllowedForPlaylistType(Types.Episodes));
            Assert.IsTrue(g.IsAllowedForPlaylistType(Types.Mixed));
            Assert.IsFalse(g.IsAllowedForPlaylistType(Types.Movies));
            Assert.IsTrue(g.IsAllowedForPlaylistType(Types.MusicVideos));
            Assert.IsTrue(g.IsAllowedForPlaylistType(Types.Songs));
            Assert.IsFalse(g.IsAllowedForPlaylistType(Types.TVShows));
        }

        [TestMethod]
        public void TitleFieldAllocation()
        {
            Title g = new Title();
            Assert.AreEqual("title", g.Name);
            Assert.AreEqual(typeof(string), g.UnderlyingType);
            Assert.IsFalse(g.IsAllowedForPlaylistType(Types.Albums));
            Assert.IsFalse(g.IsAllowedForPlaylistType(Types.Artists));
            Assert.IsFalse(g.IsAllowedForPlaylistType(Types.Episodes));
            Assert.IsTrue(g.IsAllowedForPlaylistType(Types.Mixed));
            Assert.IsTrue(g.IsAllowedForPlaylistType(Types.Movies));
            Assert.IsTrue(g.IsAllowedForPlaylistType(Types.MusicVideos));
            Assert.IsTrue(g.IsAllowedForPlaylistType(Types.Songs));
            Assert.IsFalse(g.IsAllowedForPlaylistType(Types.TVShows));
        }
    }
}
