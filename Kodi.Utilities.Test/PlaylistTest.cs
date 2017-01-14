using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kodi.Utilities.Playlist;
using Kodi.Utilities.Collection;
using Kodi.Utilities.Playlist.Fields;

namespace Kodi.Utilities.Test
{
    [TestClass]
    public class PlaylistTest
    {
        [TestMethod]
        public void TestAlbums()
        {
            RuleCollection rules = GetRulesForType(SmartPlayList.Types.Albums);
            Assert.IsNotNull(rules[typeof(Genre)]);
            Assert.IsNull(rules[typeof(Actor)]);
            Assert.IsNull(rules[typeof(AirDate)]);
            Assert.IsNotNull(rules[typeof(Album)]);
            Assert.IsNotNull(rules[typeof(AlbumArtist)]);
            Assert.IsNotNull(rules[typeof(Artist)]);
            Assert.IsNull(rules[typeof(Title)]);
        }

        [TestMethod]
        public void TestArtist()
        {
            RuleCollection rules = GetRulesForType(SmartPlayList.Types.Artists);
            Assert.IsNotNull(rules[typeof(Genre)]);
            Assert.IsNull(rules[typeof(Actor)]);
            Assert.IsNull(rules[typeof(AirDate)]);
            Assert.IsNull(rules[typeof(Album)]);
            Assert.IsNull(rules[typeof(AlbumArtist)]);
            Assert.IsNotNull(rules[typeof(Artist)]);
            Assert.IsNull(rules[typeof(Title)]);
        }

        [TestMethod]
        public void TestEpisodes()
        {
            RuleCollection rules = GetRulesForType(SmartPlayList.Types.Episodes);
            Assert.IsNotNull(rules[typeof(Genre)]);
            Assert.IsNotNull(rules[typeof(Actor)]);
            Assert.IsNotNull(rules[typeof(AirDate)]);
            Assert.IsNull(rules[typeof(Album)]);
            Assert.IsNull(rules[typeof(AlbumArtist)]);
            Assert.IsNull(rules[typeof(Artist)]);
            Assert.IsNull(rules[typeof(Title)]);
        }

        [TestMethod]
        public void TestMixed()
        {
            RuleCollection rules = GetRulesForType(SmartPlayList.Types.Mixed);
            Assert.IsNotNull(rules[typeof(Genre)]);
            Assert.IsNotNull(rules[typeof(Actor)]);
            Assert.IsNotNull(rules[typeof(AirDate)]);
            Assert.IsNotNull(rules[typeof(Album)]);
            Assert.IsNotNull(rules[typeof(AlbumArtist)]);
            Assert.IsNotNull(rules[typeof(Artist)]);
            Assert.IsNull(rules[typeof(Title)]);
        }

        [TestMethod]
        public void TestMovies()
        {
            RuleCollection rules = GetRulesForType(SmartPlayList.Types.Movies);
            Assert.IsNotNull(rules[typeof(Genre)]);
            Assert.IsNotNull(rules[typeof(Actor)]);
            Assert.IsNull(rules[typeof(AirDate)]);
            Assert.IsNull(rules[typeof(Album)]);
            Assert.IsNull(rules[typeof(AlbumArtist)]);
            Assert.IsNull(rules[typeof(Artist)]);
            Assert.IsNull(rules[typeof(Title)]);
        }

        [TestMethod]
        public void TestMusicVideos()
        {
            RuleCollection rules = GetRulesForType(SmartPlayList.Types.MusicVideos);
            Assert.IsNotNull(rules[typeof(Genre)]);
            Assert.IsNull(rules[typeof(AirDate)]);
            Assert.IsNull(rules[typeof(Actor)]);
            Assert.IsNotNull(rules[typeof(Album)]);
            Assert.IsNotNull(rules[typeof(AlbumArtist)]);
            Assert.IsNotNull(rules[typeof(Artist)]);
            Assert.IsNull(rules[typeof(Title)]);
        }

        [TestMethod]
        public void TestSongs()
        {
            RuleCollection rules = GetRulesForType(SmartPlayList.Types.Songs);
            Assert.IsNotNull(rules[typeof(Genre)]);
            Assert.IsNull(rules[typeof(Actor)]);
            Assert.IsNull(rules[typeof(AirDate)]);
            Assert.IsNotNull(rules[typeof(Album)]);
            Assert.IsNotNull(rules[typeof(AlbumArtist)]);
            Assert.IsNotNull(rules[typeof(Artist)]);
            Assert.IsNotNull(rules[typeof(Title)]);
        }

        [TestMethod]
        public void TestTVShows()
        {
            RuleCollection rules = GetRulesForType(SmartPlayList.Types.TVShows);
            Assert.IsNotNull(rules[typeof(Genre)]);
            Assert.IsNotNull(rules[typeof(Actor)]);
            Assert.IsNull(rules[typeof(AirDate)]);
            Assert.IsNull(rules[typeof(Album)]);
            Assert.IsNull(rules[typeof(AlbumArtist)]);
            Assert.IsNull(rules[typeof(Artist)]);
        }

        private RuleCollection GetRulesForType(SmartPlayList.Types type)
        {
            SmartPlayList playlist = new SmartPlayList("Test")
            {
                Type = type
            };

            return playlist.GetAvailableFields();
        }
    }
}
