using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kodi.Utilities.Playlist.Fields;
using Kodi.Utilities.Playlist;
using System.Globalization;
using Kodi.Utilities.Data;

namespace Kodi.Utilities.Test
{
    [TestClass]
    public class FieldTest
    {
        [TestMethod]
        public void GenreFieldAllocation()
        {
            Genre field = new Genre();
            Assert.AreEqual("genre", field.Name);
            Assert.AreEqual(typeof(string), field.UnderlyingType);

            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void AlbumFieldAllocation()
        {
            Album field = new Album();
            Assert.AreEqual("album", field.Name);
            Assert.AreEqual(typeof(string), field.UnderlyingType);

            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void ArtistFieldAllocation()
        {
            Artist field = new Artist();
            Assert.AreEqual("artist", field.Name);
            Assert.AreEqual(typeof(string), field.UnderlyingType);

            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void AlbumartistFieldAllocation()
        {
            AlbumArtist field = new AlbumArtist();
            Assert.AreEqual("albumartist", field.Name);
            Assert.AreEqual(typeof(string), field.UnderlyingType);

            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void TitleFieldAllocation()
        {
            Title field = new Title();
            Assert.AreEqual("title", field.Name);
            Assert.AreEqual(typeof(string), field.UnderlyingType);

            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void YearFieldAllocation()
        {
            Year field = new Year();
            Assert.AreEqual("year", field.Name);
            Assert.AreEqual(typeof(int), field.UnderlyingType);

            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void TimeFieldAllocation()
        {
            Time field = new Time();
            Assert.AreEqual("time", field.Name);
            Assert.AreEqual(typeof(int), field.UnderlyingType);

            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void TrackintFieldAllocation()
        {
            TrackNumber field = new TrackNumber();
            Assert.AreEqual("tracknumber", field.Name);
            Assert.AreEqual(typeof(int), field.UnderlyingType);

            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void FilenameFieldAllocation()
        {
            Filename field = new Filename();
            Assert.AreEqual("filename", field.Name);
            Assert.AreEqual(typeof(string), field.UnderlyingType);

            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void PathFieldAllocation()
        {
            Path field = new Path();
            Assert.AreEqual("path", field.Name);
            Assert.AreEqual(typeof(string), field.UnderlyingType);

            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void PlaycountFieldAllocation()
        {
            PlayCount field = new PlayCount();
            Assert.AreEqual("playcount", field.Name);
            Assert.AreEqual(typeof(int), field.UnderlyingType);

            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void LastplayedFieldAllocation()
        {
            LastPlayed field = new LastPlayed();
            Assert.AreEqual("lastplayed", field.Name);
            Assert.AreEqual(typeof(Duration), field.UnderlyingType);

            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void InprogressFieldAllocation()
        {
            InProgress field = new InProgress();
            Assert.AreEqual("inprogress", field.Name);
            Assert.AreEqual(typeof(bool), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void RatingFieldAllocation()
        {
            Rating field = new Rating();
            Assert.AreEqual("rating", field.Name);
            Assert.AreEqual(typeof(int), field.UnderlyingType);

            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void CommentFieldAllocation()
        {
            Comment field = new Comment();
            Assert.AreEqual("comment", field.Name);
            Assert.AreEqual(typeof(string), field.UnderlyingType);

            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void DateTimeaddedFieldAllocation()
        {
            DateTimeAdded field = new DateTimeAdded();
            Assert.AreEqual("datetimeadded", field.Name);
            Assert.AreEqual(typeof(DateTime), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void PlotFieldAllocation()
        {
            Plot field = new Plot();
            Assert.AreEqual("plot", field.Name);
            Assert.AreEqual(typeof(string), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void PlotoutlineFieldAllocation()
        {
            PlotOutline field = new PlotOutline();
            Assert.AreEqual("plotoutline", field.Name);
            Assert.AreEqual(typeof(string), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void TaglineFieldAllocation()
        {
            Tagline field = new Tagline();
            Assert.AreEqual("tagline", field.Name);
            Assert.AreEqual(typeof(string), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void MpaaratingFieldAllocation()
        {
            MPAARating field = new MPAARating();
            Assert.AreEqual("mpaarating", field.Name);
            Assert.AreEqual(typeof(string), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void Top250FieldAllocation()
        {
            Top250 field = new Top250();
            Assert.AreEqual("top250", field.Name);
            Assert.AreEqual(typeof(int), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void StatusFieldAllocation()
        {
            Status field = new Status();
            Assert.AreEqual("status", field.Name);
            Assert.AreEqual(typeof(string), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void VotesFieldAllocation()
        {
            Votes field = new Votes();
            Assert.AreEqual("votes", field.Name);
            Assert.AreEqual(typeof(int), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void DirectorFieldAllocation()
        {
            Director field = new Director();
            Assert.AreEqual("director", field.Name);
            Assert.AreEqual(typeof(string), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void ActorFieldAllocation()
        {
            Actor field = new Actor();
            Assert.AreEqual("actor", field.Name);
            Assert.AreEqual(typeof(string), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void StudioFieldAllocation()
        {
            Studio field = new Studio();
            Assert.AreEqual("studio", field.Name);
            Assert.AreEqual(typeof(string), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void CountryFieldAllocation()
        {
            Country field = new Country();
            Assert.AreEqual("country", field.Name);
            Assert.AreEqual(typeof(string), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void NumepisodesFieldAllocation()
        {
            NumEpisodes field = new NumEpisodes();
            Assert.AreEqual("numepisodes", field.Name);
            Assert.AreEqual(typeof(int), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void NumwatchedFieldAllocation()
        {
            NumWatched field = new NumWatched();
            Assert.AreEqual("numwatched", field.Name);
            Assert.AreEqual(typeof(int), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void WritersFieldAllocation()
        {
            Writers field = new Writers();
            Assert.AreEqual("writers", field.Name);
            Assert.AreEqual(typeof(string), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void AirDateTimeFieldAllocation()
        {
            AirDateTime field = new AirDateTime();
            Assert.AreEqual("airdatetime", field.Name);
            Assert.AreEqual(typeof(DateTime), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void EpisodeFieldAllocation()
        {
            Episode field = new Episode();
            Assert.AreEqual("episode", field.Name);
            Assert.AreEqual(typeof(int), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void SeasonFieldAllocation()
        {
            Season field = new Season();
            Assert.AreEqual("season", field.Name);
            Assert.AreEqual(typeof(int), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void TvshowFieldAllocation()
        {
            TVShow field = new TVShow();
            Assert.AreEqual("tvshow", field.Name);
            Assert.AreEqual(typeof(string), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void EpisodetitleFieldAllocation()
        {
            EpisodeTitle field = new EpisodeTitle();
            Assert.AreEqual("episodetitle", field.Name);
            Assert.AreEqual(typeof(string), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void ReviewFieldAllocation()
        {
            Review field = new Review();
            Assert.AreEqual("review", field.Name);
            Assert.AreEqual(typeof(string), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void ThemesFieldAllocation()
        {
            Themes field = new Themes();
            Assert.AreEqual("themes", field.Name);
            Assert.AreEqual(typeof(string), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void MoodsFieldAllocation()
        {
            Moods field = new Moods();
            Assert.AreEqual("moods", field.Name);
            Assert.AreEqual(typeof(string), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void StylesFieldAllocation()
        {
            Styles field = new Styles();
            Assert.AreEqual("styles", field.Name);
            Assert.AreEqual(typeof(string), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void TypeFieldAllocation()
        {
            MediaType field = new MediaType();
            Assert.AreEqual("type", field.Name);
            Assert.AreEqual(typeof(string), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void LabelFieldAllocation()
        {
            Label field = new Label();
            Assert.AreEqual("label", field.Name);
            Assert.AreEqual(typeof(string), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void HastrailerFieldAllocation()
        {
            HasTrailer field = new HasTrailer();
            Assert.AreEqual("hastrailer", field.Name);
            Assert.AreEqual(typeof(bool), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void VideoresolutionFieldAllocation()
        {
            VideoResolution field = new VideoResolution();
            Assert.AreEqual("videoresolution", field.Name);
            Assert.AreEqual(typeof(int), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void AudiochannelsFieldAllocation()
        {
            AudioChannels field = new AudioChannels();
            Assert.AreEqual("audiochannels", field.Name);
            Assert.AreEqual(typeof(int), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void VideocodecFieldAllocation()
        {
            VideoCodec field = new VideoCodec();
            Assert.AreEqual("videocodec", field.Name);
            Assert.AreEqual(typeof(string), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void AudiocodecFieldAllocation()
        {
            AudioCodec field = new AudioCodec();
            Assert.AreEqual("audiocodec", field.Name);
            Assert.AreEqual(typeof(string), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void AudiolanguageFieldAllocation()
        {
            AudioLanguage field = new AudioLanguage();
            
            Assert.AreEqual("audiolanguage", field.Name);
            Assert.AreEqual(typeof(ISO6392Language), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void SubtitlelanguageFieldAllocation()
        {
            SubtitleLanguage field = new SubtitleLanguage();
            Assert.AreEqual("subtitlelanguage", field.Name);
            Assert.AreEqual(typeof(ISO6392Language), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void VideoaspectFieldAllocation()
        {
            VideoAspect field = new VideoAspect();
            Assert.AreEqual("videoaspect", field.Name);
            Assert.AreEqual(typeof(int), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void SetFieldAllocation()
        {
            Set field = new Set();
            Assert.AreEqual("set", field.Name);
            Assert.AreEqual(typeof(string), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void TagFieldAllocation()
        {
            Tag field = new Tag();
            Assert.AreEqual("tag", field.Name);
            Assert.AreEqual(typeof(string), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void InstrumentsFieldAllocation()
        {
            Instruments field = new Instruments();
            Assert.AreEqual("instruments", field.Name);
            Assert.AreEqual(typeof(string), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void BiographyFieldAllocation()
        {
            Biography field = new Biography();
            Assert.AreEqual("biography", field.Name);
            Assert.AreEqual(typeof(string), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void BornFieldAllocation()
        {
            Born field = new Born();
            Assert.AreEqual("born", field.Name);
            Assert.AreEqual(typeof(string), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void BandformedFieldAllocation()
        {
            BandFormed field = new BandFormed();
            Assert.AreEqual("bandformed", field.Name);
            Assert.AreEqual(typeof(string), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void DisbandedFieldAllocation()
        {
            Disbanded field = new Disbanded();
            Assert.AreEqual("disbanded", field.Name);
            Assert.AreEqual(typeof(string), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void DiedFieldAllocation()
        {
            Died field = new Died();
            Assert.AreEqual("died", field.Name);
            Assert.AreEqual(typeof(string), field.UnderlyingType);

            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsFalse(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }

        [TestMethod]
        public void PlaylistFieldAllocation()
        {
            PlayList field = new PlayList();
            Assert.AreEqual("playlist", field.Name);
            Assert.AreEqual(typeof(string), field.UnderlyingType);

            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Songs));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Albums));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Artists));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Movies));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.TVShows));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Episodes));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.MusicVideos));
            Assert.IsTrue(field.IsAllowedForPlaylistType(SmartPlayList.Types.Mixed));

        }


    }
}
