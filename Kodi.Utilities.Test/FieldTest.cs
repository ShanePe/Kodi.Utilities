using Kodi.Utilities.Data;
using Kodi.Utilities.Interfaces;
using Kodi.Utilities.Playlist;
using Kodi.Utilities.Playlist.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Kodi.Utilities.Test
{
    [TestClass]
    public class FieldTest
    {
        [TestMethod]
        public void ActorFieldAllocation()
        {
            Actor field = new Actor();
            Assert.AreEqual("actor", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void AirDateFieldAllocation()
        {
            AirDate field = new AirDate();
            Assert.AreEqual("airdate", field.Field);
            Assert.AreEqual(typeof(DateTime), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void AlbumFieldAllocation()
        {
            Album field = new Album();
            Assert.AreEqual("album", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void AlbumArtistFieldAllocation()
        {
            AlbumArtist field = new AlbumArtist();
            Assert.AreEqual("albumartist", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void ArtistFieldAllocation()
        {
            Artist field = new Artist();
            Assert.AreEqual("artist", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void AudioChannelsFieldAllocation()
        {
            AudioChannels field = new AudioChannels();
            Assert.AreEqual("audiochannels", field.Field);
            Assert.AreEqual(typeof(int), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void AudioCodecFieldAllocation()
        {
            AudioCodec field = new AudioCodec();
            Assert.AreEqual("audiocodec", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void AudioCountFieldAllocation()
        {
            AudioCount field = new AudioCount();
            Assert.AreEqual("audiocount", field.Field);
            Assert.AreEqual(typeof(int), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void AudioLanguageFieldAllocation()
        {
            AudioLanguage field = new AudioLanguage();
            Assert.AreEqual("audiolanguage", field.Field);
            Assert.AreEqual(typeof(ISO6392Language), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void BandFormedFieldAllocation()
        {
            BandFormed field = new BandFormed();
            Assert.AreEqual("bandformed", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void BiographyFieldAllocation()
        {
            Biography field = new Biography();
            Assert.AreEqual("biography", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void BornFieldAllocation()
        {
            Born field = new Born();
            Assert.AreEqual("born", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void CommentFieldAllocation()
        {
            Comment field = new Comment();
            Assert.AreEqual("comment", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void CompilationFieldAllocation()
        {
            Compilation field = new Compilation();
            Assert.AreEqual("compilation", field.Field);
            Assert.AreEqual(typeof(bool), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void CountryFieldAllocation()
        {
            Country field = new Country();
            Assert.AreEqual("country", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void DateAddedFieldAllocation()
        {
            DateAdded field = new DateAdded();
            Assert.AreEqual("dateadded", field.Field);
            Assert.AreEqual(typeof(DateTime), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void DiedFieldAllocation()
        {
            Died field = new Died();
            Assert.AreEqual("died", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void DirectorFieldAllocation()
        {
            Director field = new Director();
            Assert.AreEqual("director", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void DisbandedFieldAllocation()
        {
            Disbanded field = new Disbanded();
            Assert.AreEqual("disbanded", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void EpisodeFieldAllocation()
        {
            Episode field = new Episode();
            Assert.AreEqual("episode", field.Field);
            Assert.AreEqual(typeof(int), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void EpisodeTitleFieldAllocation()
        {
            EpisodeTitle field = new EpisodeTitle();
            Assert.AreEqual("episodetitle", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void FilenameFieldAllocation()
        {
            Filename field = new Filename();
            Assert.AreEqual("filename", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void GenreFieldAllocation()
        {
            Genre field = new Genre();
            Assert.AreEqual("genre", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void HasTrailerFieldAllocation()
        {
            HasTrailer field = new HasTrailer();
            Assert.AreEqual("hastrailer", field.Field);
            Assert.AreEqual(typeof(bool), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void InProgressFieldAllocation()
        {
            InProgress field = new InProgress();
            Assert.AreEqual("inprogress", field.Field);
            Assert.AreEqual(typeof(bool), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void InstrumentsFieldAllocation()
        {
            Instruments field = new Instruments();
            Assert.AreEqual("instruments", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void LabelFieldAllocation()
        {
            Label field = new Label();
            Assert.AreEqual("label", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void LastPlayedFieldAllocation()
        {
            LastPlayed field = new LastPlayed();
            Assert.AreEqual("lastplayed", field.Field);
            Assert.AreEqual(typeof(Duration), field.UnderlyingType);
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void MediaTypeFieldAllocation()
        {
            MediaType field = new MediaType();
            Assert.AreEqual("mediatype", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void MoodsFieldAllocation()
        {
            Moods field = new Moods();
            Assert.AreEqual("moods", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void MPAARatingFieldAllocation()
        {
            MPAARating field = new MPAARating();
            Assert.AreEqual("mpaarating", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void NumEpisodesFieldAllocation()
        {
            NumEpisodes field = new NumEpisodes();
            Assert.AreEqual("numepisodes", field.Field);
            Assert.AreEqual(typeof(int), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void NumWatchedFieldAllocation()
        {
            NumWatched field = new NumWatched();
            Assert.AreEqual("numwatched", field.Field);
            Assert.AreEqual(typeof(int), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void PathFieldAllocation()
        {
            Path field = new Path();
            Assert.AreEqual("path", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void PlayCountFieldAllocation()
        {
            PlayCount field = new PlayCount();
            Assert.AreEqual("playcount", field.Field);
            Assert.AreEqual(typeof(int), field.UnderlyingType);
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void PlayListFieldAllocation()
        {
            PlayList field = new PlayList();
            Assert.AreEqual("playlist", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void PlotFieldAllocation()
        {
            Plot field = new Plot();
            Assert.AreEqual("plot", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void PlotOutlineFieldAllocation()
        {
            PlotOutline field = new PlotOutline();
            Assert.AreEqual("plotoutline", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void RandomFieldAllocation()
        {
            Playlist.Fields.Random field = new Playlist.Fields.Random();
            Assert.AreEqual("random", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void RatingFieldAllocation()
        {
            Rating field = new Rating();
            Assert.AreEqual("rating", field.Field);
            Assert.AreEqual(typeof(int), field.UnderlyingType);
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void ReviewFieldAllocation()
        {
            Review field = new Review();
            Assert.AreEqual("review", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void RoleFieldAllocation()
        {
            Role field = new Role();
            Assert.AreEqual("role", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void SeasonFieldAllocation()
        {
            Season field = new Season();
            Assert.AreEqual("season", field.Field);
            Assert.AreEqual(typeof(int), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void SetFieldAllocation()
        {
            Set field = new Set();
            Assert.AreEqual("set", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void StatusFieldAllocation()
        {
            Status field = new Status();
            Assert.AreEqual("status", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void StudioFieldAllocation()
        {
            Studio field = new Studio();
            Assert.AreEqual("studio", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void StylesFieldAllocation()
        {
            Styles field = new Styles();
            Assert.AreEqual("styles", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void SubtitleCountFieldAllocation()
        {
            SubtitleCount field = new SubtitleCount();
            Assert.AreEqual("subtitlecount", field.Field);
            Assert.AreEqual(typeof(int), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void SubtitleLanguageFieldAllocation()
        {
            SubtitleLanguage field = new SubtitleLanguage();
            Assert.AreEqual("subtitlelanguage", field.Field);
            Assert.AreEqual(typeof(ISO6392Language), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void TagFieldAllocation()
        {
            Tag field = new Tag();
            Assert.AreEqual("tag", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void TaglineFieldAllocation()
        {
            Tagline field = new Tagline();
            Assert.AreEqual("tagline", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void ThemesFieldAllocation()
        {
            Themes field = new Themes();
            Assert.AreEqual("themes", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void TimeFieldAllocation()
        {
            Time field = new Time();
            Assert.AreEqual("time", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void TitleFieldAllocation()
        {
            Title field = new Title();
            Assert.AreEqual("title", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void Top250FieldAllocation()
        {
            Top250 field = new Top250();
            Assert.AreEqual("top250", field.Field);
            Assert.AreEqual(typeof(int), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void TrackNumberFieldAllocation()
        {
            TrackNumber field = new TrackNumber();
            Assert.AreEqual("tracknumber", field.Field);
            Assert.AreEqual(typeof(int), field.UnderlyingType);
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void TVShowFieldAllocation()
        {
            TVShow field = new TVShow();
            Assert.AreEqual("tvshow", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void UserRatingFieldAllocation()
        {
            UserRating field = new UserRating();
            Assert.AreEqual("userrating", field.Field);
            Assert.AreEqual(typeof(double), field.UnderlyingType);
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void VideoAspectFieldAllocation()
        {
            VideoAspect field = new VideoAspect();
            Assert.AreEqual("videoaspect", field.Field);
            Assert.AreEqual(typeof(int), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void VideoCodecFieldAllocation()
        {
            VideoCodec field = new VideoCodec();
            Assert.AreEqual("videocodec", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void VideoResolutionFieldAllocation()
        {
            VideoResolution field = new VideoResolution();
            Assert.AreEqual("videoresolution", field.Field);
            Assert.AreEqual(typeof(int), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void VirtualFolderFieldAllocation()
        {
            VirtualFolder field = new VirtualFolder();
            Assert.AreEqual("virtualfolder", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void VotesFieldAllocation()
        {
            Votes field = new Votes();
            Assert.AreEqual("votes", field.Field);
            Assert.AreEqual(typeof(int), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void WritersFieldAllocation()
        {
            Writers field = new Writers();
            Assert.AreEqual("writers", field.Field);
            Assert.AreEqual(typeof(string), field.UnderlyingType);
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }

        [TestMethod]
        public void YearFieldAllocation()
        {
            Year field = new Year();
            Assert.AreEqual("year", field.Field);
            Assert.AreEqual(typeof(int), field.UnderlyingType);
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsFieldForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsFieldForPlaylist(SmartPlayList.Types.Mixed));

            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsOrderByForPlaylist(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsOrderByForPlaylist(SmartPlayList.Types.Mixed));
        }


        [TestMethod]
        public void TestMultiValues()
        {
            foreach (IRule rule in SmartPlayList.GetAll<IRule>()
                                        .Where(r => r.IsMultipleValuesAllowed))
            {
                object[] o = GetTestValue(rule.UnderlyingType);
                rule.Values.Add(o[0]);
                rule.Values.Add(o[1]);

                Assert.AreEqual(rule.Values.Count, 2);
            }

            foreach (IRule rule in SmartPlayList.GetAll<IRule>()
                                        .Where(r => !r.IsMultipleValuesAllowed && !r.Operator.NoValue))
            {
                object[] o = GetTestValue(rule.UnderlyingType);
                rule.Values.Add(o[0]);
                rule.Values.Add(o[1]);

                Assert.AreEqual(rule.Values.Count, 1);
            }

        }

        private object[] GetTestValue(Type t)
        {
            if (t == typeof(string))
                return new string[] { "12:00:00", "13:00:00" };
            else if (t == typeof(int))
                return new object[] { 1, 2 };
            else if (t == typeof(double))
                return new object[] { 0.0, 1.0 };
            else if (t == typeof(Duration))
                return new object[] { new Duration(1, Duration.Periods.Days), new Duration(DateTime.Now) };
            else if (t == typeof(ISO6392Language))
                return new object[] { ISO6392LanguageFactory.GetByCode("eng"), ISO6392LanguageFactory.GetByCode("afr") };
            else if (t == typeof(bool))
                return new object[] { true, false };
            else if (t == typeof(DateTime))
                return new object[] { DateTime.Now, DateTime.Now.AddYears(1) };
            else
                Assert.Fail($"Invalid type {t.ToString()}");

            return null;
        }
    }
}
