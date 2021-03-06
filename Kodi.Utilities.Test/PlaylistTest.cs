﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kodi.Utilities.Playlist;
using Kodi.Utilities.Collection;
using Kodi.Utilities.Playlist.Fields;
using Kodi.Utilities.Parsers;
using Kodi.Utilities.Interfaces;
using System.Collections.Generic;
using IO = System.IO;

namespace Kodi.Utilities.Test
{
    public class Holder : Dictionary<Type, IAllocatable>
    {
        public new IAllocatable this[Type t]
        {
            get
            {
                if (this.ContainsKey(t))
                    return base[t];
                else
                    return null;
            }
            set
            {
                base[t] = value;
            }
        }
    }
    [TestClass]
    public class PlaylistTest
    {
        private Holder GetRulesForType(SmartPlayList.Types type)
        {
            SmartPlayList playlist = new SmartPlayList()
            {
                MediaType = type
            };

            Holder rules = new Holder();

            foreach (IRule rule in playlist.GetAvailableFields())
                rules.Add(rule.GetType(), rule);

            return rules;
        }

        [TestMethod]
        public void TestSongs()
        {
            Holder rules = GetRulesForType(SmartPlayList.Types.Songs);

            Assert.IsNotNull(rules[typeof(Genre)]);
            Assert.IsNotNull(rules[typeof(Album)]);
            Assert.IsNotNull(rules[typeof(Artist)]);
            Assert.IsNotNull(rules[typeof(AlbumArtist)]);
            Assert.IsNotNull(rules[typeof(Title)]);
            Assert.IsNotNull(rules[typeof(Year)]);
            Assert.IsNotNull(rules[typeof(Time)]);
            Assert.IsNotNull(rules[typeof(TrackNumber)]);
            Assert.IsNotNull(rules[typeof(Filename)]);
            Assert.IsNotNull(rules[typeof(Path)]);
            Assert.IsNotNull(rules[typeof(PlayCount)]);
            Assert.IsNotNull(rules[typeof(LastPlayed)]);
            Assert.IsNull(rules[typeof(InProgress)]);
            Assert.IsNotNull(rules[typeof(Rating)]);
            Assert.IsNotNull(rules[typeof(Comment)]);
            Assert.IsNull(rules[typeof(DateAdded)]);
            Assert.IsNull(rules[typeof(Plot)]);
            Assert.IsNull(rules[typeof(PlotOutline)]);
            Assert.IsNull(rules[typeof(Tagline)]);
            Assert.IsNull(rules[typeof(MPAARating)]);
            Assert.IsNull(rules[typeof(Top250)]);
            Assert.IsNull(rules[typeof(Status)]);
            Assert.IsNull(rules[typeof(Votes)]);
            Assert.IsNull(rules[typeof(Director)]);
            Assert.IsNull(rules[typeof(Actor)]);
            Assert.IsNull(rules[typeof(Studio)]);
            Assert.IsNull(rules[typeof(Country)]);
            Assert.IsNull(rules[typeof(NumEpisodes)]);
            Assert.IsNull(rules[typeof(NumWatched)]);
            Assert.IsNull(rules[typeof(Writers)]);
            Assert.IsNull(rules[typeof(AirDate)]);
            Assert.IsNull(rules[typeof(Episode)]);
            Assert.IsNull(rules[typeof(Season)]);
            Assert.IsNull(rules[typeof(TVShow)]);
            Assert.IsNull(rules[typeof(EpisodeTitle)]);
            Assert.IsNull(rules[typeof(Review)]);
            Assert.IsNull(rules[typeof(Themes)]);
            Assert.IsNull(rules[typeof(Moods)]);
            Assert.IsNull(rules[typeof(Styles)]);
            Assert.IsNull(rules[typeof(MediaType)]);
            Assert.IsNull(rules[typeof(Label)]);
            Assert.IsNull(rules[typeof(HasTrailer)]);
            Assert.IsNull(rules[typeof(VideoResolution)]);
            Assert.IsNull(rules[typeof(AudioChannels)]);
            Assert.IsNull(rules[typeof(AudioCount)]);
            Assert.IsNull(rules[typeof(SubtitleCount)]);
            Assert.IsNull(rules[typeof(VideoCodec)]);
            Assert.IsNull(rules[typeof(AudioCodec)]);
            Assert.IsNull(rules[typeof(AudioLanguage)]);
            Assert.IsNull(rules[typeof(SubtitleLanguage)]);
            Assert.IsNull(rules[typeof(VideoAspect)]);
            Assert.IsNull(rules[typeof(Set)]);
            Assert.IsNull(rules[typeof(Tag)]);
            Assert.IsNull(rules[typeof(Instruments)]);
            Assert.IsNull(rules[typeof(Biography)]);
            Assert.IsNull(rules[typeof(Born)]);
            Assert.IsNull(rules[typeof(BandFormed)]);
            Assert.IsNull(rules[typeof(Disbanded)]);
            Assert.IsNull(rules[typeof(Died)]);
            Assert.IsNotNull(rules[typeof(PlayList)]);
            Assert.IsNotNull(rules[typeof(VirtualFolder)]);
            Assert.IsNull(rules[typeof(Role)]);
            Assert.IsNull(rules[typeof(Compilation)]);
            Assert.IsNotNull(rules[typeof(UserRating)]);
        }

        [TestMethod]
        public void TestAlbums()
        {
            Holder rules = GetRulesForType(SmartPlayList.Types.Albums);

            Assert.IsNotNull(rules[typeof(Genre)]);
            Assert.IsNotNull(rules[typeof(Album)]);
            Assert.IsNotNull(rules[typeof(Artist)]);
            Assert.IsNotNull(rules[typeof(AlbumArtist)]);
            Assert.IsNull(rules[typeof(Title)]);
            Assert.IsNotNull(rules[typeof(Year)]);
            Assert.IsNull(rules[typeof(Time)]);
            Assert.IsNull(rules[typeof(TrackNumber)]);
            Assert.IsNull(rules[typeof(Filename)]);
            Assert.IsNull(rules[typeof(Path)]);
            Assert.IsNull(rules[typeof(PlayCount)]);
            Assert.IsNull(rules[typeof(LastPlayed)]);
            Assert.IsNull(rules[typeof(InProgress)]);
            Assert.IsNotNull(rules[typeof(Rating)]);
            Assert.IsNull(rules[typeof(Comment)]);
            Assert.IsNull(rules[typeof(DateAdded)]);
            Assert.IsNull(rules[typeof(Plot)]);
            Assert.IsNull(rules[typeof(PlotOutline)]);
            Assert.IsNull(rules[typeof(Tagline)]);
            Assert.IsNull(rules[typeof(MPAARating)]);
            Assert.IsNull(rules[typeof(Top250)]);
            Assert.IsNull(rules[typeof(Status)]);
            Assert.IsNull(rules[typeof(Votes)]);
            Assert.IsNull(rules[typeof(Director)]);
            Assert.IsNull(rules[typeof(Actor)]);
            Assert.IsNull(rules[typeof(Studio)]);
            Assert.IsNull(rules[typeof(Country)]);
            Assert.IsNull(rules[typeof(NumEpisodes)]);
            Assert.IsNull(rules[typeof(NumWatched)]);
            Assert.IsNull(rules[typeof(Writers)]);
            Assert.IsNull(rules[typeof(AirDate)]);
            Assert.IsNull(rules[typeof(Episode)]);
            Assert.IsNull(rules[typeof(Season)]);
            Assert.IsNull(rules[typeof(TVShow)]);
            Assert.IsNull(rules[typeof(EpisodeTitle)]);
            Assert.IsNotNull(rules[typeof(Review)]);
            Assert.IsNotNull(rules[typeof(Themes)]);
            Assert.IsNotNull(rules[typeof(Moods)]);
            Assert.IsNotNull(rules[typeof(Styles)]);
            Assert.IsNotNull(rules[typeof(MediaType)]);
            Assert.IsNotNull(rules[typeof(Label)]);
            Assert.IsNull(rules[typeof(HasTrailer)]);
            Assert.IsNull(rules[typeof(VideoResolution)]);
            Assert.IsNull(rules[typeof(AudioChannels)]);
            Assert.IsNull(rules[typeof(AudioCount)]);
            Assert.IsNull(rules[typeof(SubtitleCount)]);
            Assert.IsNull(rules[typeof(VideoCodec)]);
            Assert.IsNull(rules[typeof(AudioCodec)]);
            Assert.IsNull(rules[typeof(AudioLanguage)]);
            Assert.IsNull(rules[typeof(SubtitleLanguage)]);
            Assert.IsNull(rules[typeof(VideoAspect)]);
            Assert.IsNull(rules[typeof(Set)]);
            Assert.IsNull(rules[typeof(Tag)]);
            Assert.IsNull(rules[typeof(Instruments)]);
            Assert.IsNull(rules[typeof(Biography)]);
            Assert.IsNull(rules[typeof(Born)]);
            Assert.IsNull(rules[typeof(BandFormed)]);
            Assert.IsNull(rules[typeof(Disbanded)]);
            Assert.IsNull(rules[typeof(Died)]);
            Assert.IsNotNull(rules[typeof(PlayList)]);
            Assert.IsNotNull(rules[typeof(VirtualFolder)]);
            Assert.IsNull(rules[typeof(Role)]);
            Assert.IsNotNull(rules[typeof(Compilation)]);
            Assert.IsNotNull(rules[typeof(UserRating)]);
        }

        [TestMethod]
        public void TestArtist()
        {
            Holder rules = GetRulesForType(SmartPlayList.Types.Artists);

            Assert.IsNotNull(rules[typeof(Genre)]);
            Assert.IsNull(rules[typeof(Album)]);
            Assert.IsNotNull(rules[typeof(Artist)]);
            Assert.IsNull(rules[typeof(AlbumArtist)]);
            Assert.IsNull(rules[typeof(Title)]);
            Assert.IsNull(rules[typeof(Year)]);
            Assert.IsNull(rules[typeof(Time)]);
            Assert.IsNull(rules[typeof(TrackNumber)]);
            Assert.IsNull(rules[typeof(Filename)]);
            Assert.IsNull(rules[typeof(Path)]);
            Assert.IsNull(rules[typeof(PlayCount)]);
            Assert.IsNull(rules[typeof(LastPlayed)]);
            Assert.IsNull(rules[typeof(InProgress)]);
            Assert.IsNull(rules[typeof(Rating)]);
            Assert.IsNull(rules[typeof(Comment)]);
            Assert.IsNull(rules[typeof(DateAdded)]);
            Assert.IsNull(rules[typeof(Plot)]);
            Assert.IsNull(rules[typeof(PlotOutline)]);
            Assert.IsNull(rules[typeof(Tagline)]);
            Assert.IsNull(rules[typeof(MPAARating)]);
            Assert.IsNull(rules[typeof(Top250)]);
            Assert.IsNull(rules[typeof(Status)]);
            Assert.IsNull(rules[typeof(Votes)]);
            Assert.IsNull(rules[typeof(Director)]);
            Assert.IsNull(rules[typeof(Actor)]);
            Assert.IsNull(rules[typeof(Studio)]);
            Assert.IsNull(rules[typeof(Country)]);
            Assert.IsNull(rules[typeof(NumEpisodes)]);
            Assert.IsNull(rules[typeof(NumWatched)]);
            Assert.IsNull(rules[typeof(Writers)]);
            Assert.IsNull(rules[typeof(AirDate)]);
            Assert.IsNull(rules[typeof(Episode)]);
            Assert.IsNull(rules[typeof(Season)]);
            Assert.IsNull(rules[typeof(TVShow)]);
            Assert.IsNull(rules[typeof(EpisodeTitle)]);
            Assert.IsNull(rules[typeof(Review)]);
            Assert.IsNull(rules[typeof(Themes)]);
            Assert.IsNotNull(rules[typeof(Moods)]);
            Assert.IsNotNull(rules[typeof(Styles)]);
            Assert.IsNull(rules[typeof(MediaType)]);
            Assert.IsNull(rules[typeof(Label)]);
            Assert.IsNull(rules[typeof(HasTrailer)]);
            Assert.IsNull(rules[typeof(VideoResolution)]);
            Assert.IsNull(rules[typeof(AudioChannels)]);
            Assert.IsNull(rules[typeof(AudioCount)]);
            Assert.IsNull(rules[typeof(SubtitleCount)]);
            Assert.IsNull(rules[typeof(VideoCodec)]);
            Assert.IsNull(rules[typeof(AudioCodec)]);
            Assert.IsNull(rules[typeof(AudioLanguage)]);
            Assert.IsNull(rules[typeof(SubtitleLanguage)]);
            Assert.IsNull(rules[typeof(VideoAspect)]);
            Assert.IsNull(rules[typeof(Set)]);
            Assert.IsNull(rules[typeof(Tag)]);
            Assert.IsNotNull(rules[typeof(Instruments)]);
            Assert.IsNotNull(rules[typeof(Biography)]);
            Assert.IsNotNull(rules[typeof(Born)]);
            Assert.IsNotNull(rules[typeof(BandFormed)]);
            Assert.IsNotNull(rules[typeof(Disbanded)]);
            Assert.IsNotNull(rules[typeof(Died)]);
            Assert.IsNotNull(rules[typeof(PlayList)]);
            Assert.IsNotNull(rules[typeof(VirtualFolder)]);
            Assert.IsNotNull(rules[typeof(Role)]);
            Assert.IsNull(rules[typeof(Compilation)]);
            Assert.IsNull(rules[typeof(UserRating)]);
        }

        [TestMethod]
        public void TestMovies()
        {
            Holder rules = GetRulesForType(SmartPlayList.Types.Movies);

            Assert.IsNotNull(rules[typeof(Genre)]);
            Assert.IsNull(rules[typeof(Album)]);
            Assert.IsNull(rules[typeof(Artist)]);
            Assert.IsNull(rules[typeof(AlbumArtist)]);
            Assert.IsNotNull(rules[typeof(Title)]);
            Assert.IsNotNull(rules[typeof(Year)]);
            Assert.IsNotNull(rules[typeof(Time)]);
            Assert.IsNull(rules[typeof(TrackNumber)]);
            Assert.IsNotNull(rules[typeof(Filename)]);
            Assert.IsNotNull(rules[typeof(Path)]);
            Assert.IsNotNull(rules[typeof(PlayCount)]);
            Assert.IsNotNull(rules[typeof(LastPlayed)]);
            Assert.IsNotNull(rules[typeof(InProgress)]);
            Assert.IsNotNull(rules[typeof(Rating)]);
            Assert.IsNull(rules[typeof(Comment)]);
            Assert.IsNotNull(rules[typeof(DateAdded)]);
            Assert.IsNotNull(rules[typeof(Plot)]);
            Assert.IsNotNull(rules[typeof(PlotOutline)]);
            Assert.IsNotNull(rules[typeof(Tagline)]);
            Assert.IsNotNull(rules[typeof(MPAARating)]);
            Assert.IsNotNull(rules[typeof(Top250)]);
            Assert.IsNull(rules[typeof(Status)]);
            Assert.IsNotNull(rules[typeof(Votes)]);
            Assert.IsNotNull(rules[typeof(Director)]);
            Assert.IsNotNull(rules[typeof(Actor)]);
            Assert.IsNotNull(rules[typeof(Studio)]);
            Assert.IsNotNull(rules[typeof(Country)]);
            Assert.IsNull(rules[typeof(NumEpisodes)]);
            Assert.IsNull(rules[typeof(NumWatched)]);
            Assert.IsNotNull(rules[typeof(Writers)]);
            Assert.IsNull(rules[typeof(AirDate)]);
            Assert.IsNull(rules[typeof(Episode)]);
            Assert.IsNull(rules[typeof(Season)]);
            Assert.IsNull(rules[typeof(TVShow)]);
            Assert.IsNull(rules[typeof(EpisodeTitle)]);
            Assert.IsNull(rules[typeof(Review)]);
            Assert.IsNull(rules[typeof(Themes)]);
            Assert.IsNull(rules[typeof(Moods)]);
            Assert.IsNull(rules[typeof(Styles)]);
            Assert.IsNull(rules[typeof(MediaType)]);
            Assert.IsNull(rules[typeof(Label)]);
            Assert.IsNotNull(rules[typeof(HasTrailer)]);
            Assert.IsNotNull(rules[typeof(VideoResolution)]);
            Assert.IsNotNull(rules[typeof(AudioChannels)]);
            Assert.IsNotNull(rules[typeof(AudioCount)]);
            Assert.IsNotNull(rules[typeof(SubtitleCount)]);
            Assert.IsNotNull(rules[typeof(VideoCodec)]);
            Assert.IsNotNull(rules[typeof(AudioCodec)]);
            Assert.IsNotNull(rules[typeof(AudioLanguage)]);
            Assert.IsNotNull(rules[typeof(SubtitleLanguage)]);
            Assert.IsNotNull(rules[typeof(VideoAspect)]);
            Assert.IsNotNull(rules[typeof(Set)]);
            Assert.IsNotNull(rules[typeof(Tag)]);
            Assert.IsNull(rules[typeof(Instruments)]);
            Assert.IsNull(rules[typeof(Biography)]);
            Assert.IsNull(rules[typeof(Born)]);
            Assert.IsNull(rules[typeof(BandFormed)]);
            Assert.IsNull(rules[typeof(Disbanded)]);
            Assert.IsNull(rules[typeof(Died)]);
            Assert.IsNotNull(rules[typeof(PlayList)]);
            Assert.IsNotNull(rules[typeof(VirtualFolder)]);
            Assert.IsNull(rules[typeof(Role)]);
            Assert.IsNull(rules[typeof(Compilation)]);
            Assert.IsNotNull(rules[typeof(UserRating)]);
        }

        [TestMethod]
        public void TestTVShows()
        {
            Holder rules = GetRulesForType(SmartPlayList.Types.TVShows);

            Assert.IsNotNull(rules[typeof(Genre)]);
            Assert.IsNull(rules[typeof(Album)]);
            Assert.IsNull(rules[typeof(Artist)]);
            Assert.IsNull(rules[typeof(AlbumArtist)]);
            Assert.IsNull(rules[typeof(Title)]);
            Assert.IsNotNull(rules[typeof(Year)]);
            Assert.IsNull(rules[typeof(Time)]);
            Assert.IsNull(rules[typeof(TrackNumber)]);
            Assert.IsNull(rules[typeof(Filename)]);
            Assert.IsNotNull(rules[typeof(Path)]);
            Assert.IsNotNull(rules[typeof(PlayCount)]);
            Assert.IsNull(rules[typeof(LastPlayed)]);
            Assert.IsNull(rules[typeof(InProgress)]);
            Assert.IsNotNull(rules[typeof(Rating)]);
            Assert.IsNull(rules[typeof(Comment)]);
            Assert.IsNull(rules[typeof(DateAdded)]);
            Assert.IsNotNull(rules[typeof(Plot)]);
            Assert.IsNull(rules[typeof(PlotOutline)]);
            Assert.IsNull(rules[typeof(Tagline)]);
            Assert.IsNotNull(rules[typeof(MPAARating)]);
            Assert.IsNull(rules[typeof(Top250)]);
            Assert.IsNotNull(rules[typeof(Status)]);
            Assert.IsNotNull(rules[typeof(Votes)]);
            Assert.IsNotNull(rules[typeof(Director)]);
            Assert.IsNotNull(rules[typeof(Actor)]);
            Assert.IsNotNull(rules[typeof(Studio)]);
            Assert.IsNull(rules[typeof(Country)]);
            Assert.IsNotNull(rules[typeof(NumEpisodes)]);
            Assert.IsNotNull(rules[typeof(NumWatched)]);
            Assert.IsNull(rules[typeof(Writers)]);
            Assert.IsNull(rules[typeof(AirDate)]);
            Assert.IsNull(rules[typeof(Episode)]);
            Assert.IsNull(rules[typeof(Season)]);
            Assert.IsNotNull(rules[typeof(TVShow)]);
            Assert.IsNull(rules[typeof(EpisodeTitle)]);
            Assert.IsNull(rules[typeof(Review)]);
            Assert.IsNull(rules[typeof(Themes)]);
            Assert.IsNull(rules[typeof(Moods)]);
            Assert.IsNull(rules[typeof(Styles)]);
            Assert.IsNull(rules[typeof(MediaType)]);
            Assert.IsNull(rules[typeof(Label)]);
            Assert.IsNull(rules[typeof(HasTrailer)]);
            Assert.IsNull(rules[typeof(VideoResolution)]);
            Assert.IsNull(rules[typeof(AudioChannels)]);
            Assert.IsNull(rules[typeof(AudioCount)]);
            Assert.IsNull(rules[typeof(SubtitleCount)]);
            Assert.IsNull(rules[typeof(VideoCodec)]);
            Assert.IsNull(rules[typeof(AudioCodec)]);
            Assert.IsNull(rules[typeof(AudioLanguage)]);
            Assert.IsNull(rules[typeof(SubtitleLanguage)]);
            Assert.IsNull(rules[typeof(VideoAspect)]);
            Assert.IsNull(rules[typeof(Set)]);
            Assert.IsNotNull(rules[typeof(Tag)]);
            Assert.IsNull(rules[typeof(Instruments)]);
            Assert.IsNull(rules[typeof(Biography)]);
            Assert.IsNull(rules[typeof(Born)]);
            Assert.IsNull(rules[typeof(BandFormed)]);
            Assert.IsNull(rules[typeof(Disbanded)]);
            Assert.IsNull(rules[typeof(Died)]);
            Assert.IsNotNull(rules[typeof(PlayList)]);
            Assert.IsNotNull(rules[typeof(VirtualFolder)]);
            Assert.IsNull(rules[typeof(Role)]);
            Assert.IsNull(rules[typeof(Compilation)]);
            Assert.IsNotNull(rules[typeof(UserRating)]);
        }

        [TestMethod]
        public void TestEpisodes()
        {
            Holder rules = GetRulesForType(SmartPlayList.Types.Episodes);

            Assert.IsNotNull(rules[typeof(Genre)]);
            Assert.IsNull(rules[typeof(Album)]);
            Assert.IsNull(rules[typeof(Artist)]);
            Assert.IsNull(rules[typeof(AlbumArtist)]);
            Assert.IsNull(rules[typeof(Title)]);
            Assert.IsNotNull(rules[typeof(Year)]);
            Assert.IsNotNull(rules[typeof(Time)]);
            Assert.IsNull(rules[typeof(TrackNumber)]);
            Assert.IsNotNull(rules[typeof(Filename)]);
            Assert.IsNotNull(rules[typeof(Path)]);
            Assert.IsNotNull(rules[typeof(PlayCount)]);
            Assert.IsNotNull(rules[typeof(LastPlayed)]);
            Assert.IsNotNull(rules[typeof(InProgress)]);
            Assert.IsNotNull(rules[typeof(Rating)]);
            Assert.IsNull(rules[typeof(Comment)]);
            Assert.IsNull(rules[typeof(DateAdded)]);
            Assert.IsNotNull(rules[typeof(Plot)]);
            Assert.IsNull(rules[typeof(PlotOutline)]);
            Assert.IsNull(rules[typeof(Tagline)]);
            Assert.IsNotNull(rules[typeof(MPAARating)]);
            Assert.IsNull(rules[typeof(Top250)]);
            Assert.IsNull(rules[typeof(Status)]);
            Assert.IsNotNull(rules[typeof(Votes)]);
            Assert.IsNotNull(rules[typeof(Director)]);
            Assert.IsNotNull(rules[typeof(Actor)]);
            Assert.IsNotNull(rules[typeof(Studio)]);
            Assert.IsNull(rules[typeof(Country)]);
            Assert.IsNull(rules[typeof(NumEpisodes)]);
            Assert.IsNull(rules[typeof(NumWatched)]);
            Assert.IsNotNull(rules[typeof(Writers)]);
            Assert.IsNotNull(rules[typeof(AirDate)]);
            Assert.IsNotNull(rules[typeof(Episode)]);
            Assert.IsNotNull(rules[typeof(Season)]);
            Assert.IsNotNull(rules[typeof(TVShow)]);
            Assert.IsNotNull(rules[typeof(EpisodeTitle)]);
            Assert.IsNull(rules[typeof(Review)]);
            Assert.IsNull(rules[typeof(Themes)]);
            Assert.IsNull(rules[typeof(Moods)]);
            Assert.IsNull(rules[typeof(Styles)]);
            Assert.IsNull(rules[typeof(MediaType)]);
            Assert.IsNull(rules[typeof(Label)]);
            Assert.IsNull(rules[typeof(HasTrailer)]);
            Assert.IsNotNull(rules[typeof(VideoResolution)]);
            Assert.IsNotNull(rules[typeof(AudioChannels)]);
            Assert.IsNotNull(rules[typeof(AudioCount)]);
            Assert.IsNotNull(rules[typeof(SubtitleCount)]);
            Assert.IsNotNull(rules[typeof(VideoCodec)]);
            Assert.IsNotNull(rules[typeof(AudioCodec)]);
            Assert.IsNotNull(rules[typeof(AudioLanguage)]);
            Assert.IsNotNull(rules[typeof(SubtitleLanguage)]);
            Assert.IsNotNull(rules[typeof(VideoAspect)]);
            Assert.IsNull(rules[typeof(Set)]);
            Assert.IsNull(rules[typeof(Tag)]);
            Assert.IsNull(rules[typeof(Instruments)]);
            Assert.IsNull(rules[typeof(Biography)]);
            Assert.IsNull(rules[typeof(Born)]);
            Assert.IsNull(rules[typeof(BandFormed)]);
            Assert.IsNull(rules[typeof(Disbanded)]);
            Assert.IsNull(rules[typeof(Died)]);
            Assert.IsNotNull(rules[typeof(PlayList)]);
            Assert.IsNotNull(rules[typeof(VirtualFolder)]);
            Assert.IsNull(rules[typeof(Role)]);
            Assert.IsNull(rules[typeof(Compilation)]);
            Assert.IsNotNull(rules[typeof(UserRating)]);
        }

        [TestMethod]
        public void TestMusicVideos()
        {
            Holder rules = GetRulesForType(SmartPlayList.Types.MusicVideos);

            Assert.IsNotNull(rules[typeof(Genre)]);
            Assert.IsNotNull(rules[typeof(Album)]);
            Assert.IsNotNull(rules[typeof(Artist)]);
            Assert.IsNotNull(rules[typeof(AlbumArtist)]);
            Assert.IsNotNull(rules[typeof(Title)]);
            Assert.IsNotNull(rules[typeof(Year)]);
            Assert.IsNotNull(rules[typeof(Time)]);
            Assert.IsNull(rules[typeof(TrackNumber)]);
            Assert.IsNotNull(rules[typeof(Filename)]);
            Assert.IsNotNull(rules[typeof(Path)]);
            Assert.IsNotNull(rules[typeof(PlayCount)]);
            Assert.IsNotNull(rules[typeof(LastPlayed)]);
            Assert.IsNull(rules[typeof(InProgress)]);
            Assert.IsNull(rules[typeof(Rating)]);
            Assert.IsNull(rules[typeof(Comment)]);
            Assert.IsNull(rules[typeof(DateAdded)]);
            Assert.IsNotNull(rules[typeof(Plot)]);
            Assert.IsNull(rules[typeof(PlotOutline)]);
            Assert.IsNull(rules[typeof(Tagline)]);
            Assert.IsNull(rules[typeof(MPAARating)]);
            Assert.IsNull(rules[typeof(Top250)]);
            Assert.IsNull(rules[typeof(Status)]);
            Assert.IsNull(rules[typeof(Votes)]);
            Assert.IsNotNull(rules[typeof(Director)]);
            Assert.IsNull(rules[typeof(Actor)]);
            Assert.IsNotNull(rules[typeof(Studio)]);
            Assert.IsNull(rules[typeof(Country)]);
            Assert.IsNull(rules[typeof(NumEpisodes)]);
            Assert.IsNull(rules[typeof(NumWatched)]);
            Assert.IsNull(rules[typeof(Writers)]);
            Assert.IsNull(rules[typeof(AirDate)]);
            Assert.IsNull(rules[typeof(Episode)]);
            Assert.IsNull(rules[typeof(Season)]);
            Assert.IsNull(rules[typeof(TVShow)]);
            Assert.IsNull(rules[typeof(EpisodeTitle)]);
            Assert.IsNull(rules[typeof(Review)]);
            Assert.IsNull(rules[typeof(Themes)]);
            Assert.IsNull(rules[typeof(Moods)]);
            Assert.IsNull(rules[typeof(Styles)]);
            Assert.IsNull(rules[typeof(MediaType)]);
            Assert.IsNull(rules[typeof(Label)]);
            Assert.IsNull(rules[typeof(HasTrailer)]);
            Assert.IsNotNull(rules[typeof(VideoResolution)]);
            Assert.IsNotNull(rules[typeof(AudioChannels)]);
            Assert.IsNotNull(rules[typeof(SubtitleCount)]);
            Assert.IsNotNull(rules[typeof(AudioCount)]);
            Assert.IsNotNull(rules[typeof(VideoCodec)]);
            Assert.IsNotNull(rules[typeof(AudioCodec)]);
            Assert.IsNotNull(rules[typeof(AudioLanguage)]);
            Assert.IsNotNull(rules[typeof(SubtitleLanguage)]);
            Assert.IsNotNull(rules[typeof(VideoAspect)]);
            Assert.IsNull(rules[typeof(Set)]);
            Assert.IsNotNull(rules[typeof(Tag)]);
            Assert.IsNull(rules[typeof(Instruments)]);
            Assert.IsNull(rules[typeof(Biography)]);
            Assert.IsNull(rules[typeof(Born)]);
            Assert.IsNull(rules[typeof(BandFormed)]);
            Assert.IsNull(rules[typeof(Disbanded)]);
            Assert.IsNull(rules[typeof(Died)]);
            Assert.IsNotNull(rules[typeof(PlayList)]);
            Assert.IsNotNull(rules[typeof(VirtualFolder)]);
            Assert.IsNull(rules[typeof(Role)]);
            Assert.IsNull(rules[typeof(Compilation)]);
            Assert.IsNotNull(rules[typeof(UserRating)]);
        }

        [TestMethod]
        public void TestMixed()
        {
            Holder rules = GetRulesForType(SmartPlayList.Types.Mixed);

            Assert.IsNotNull(rules[typeof(Genre)]);
            Assert.IsNotNull(rules[typeof(Album)]);
            Assert.IsNotNull(rules[typeof(Artist)]);
            Assert.IsNotNull(rules[typeof(AlbumArtist)]);
            Assert.IsNotNull(rules[typeof(Title)]);
            Assert.IsNotNull(rules[typeof(Year)]);
            Assert.IsNotNull(rules[typeof(Time)]);
            Assert.IsNotNull(rules[typeof(TrackNumber)]);
            Assert.IsNotNull(rules[typeof(Filename)]);
            Assert.IsNotNull(rules[typeof(Path)]);
            Assert.IsNotNull(rules[typeof(PlayCount)]);
            Assert.IsNotNull(rules[typeof(LastPlayed)]);
            Assert.IsNotNull(rules[typeof(InProgress)]);
            Assert.IsNotNull(rules[typeof(Rating)]);
            Assert.IsNotNull(rules[typeof(Comment)]);
            Assert.IsNull(rules[typeof(DateAdded)]);
            Assert.IsNotNull(rules[typeof(Plot)]);
            Assert.IsNotNull(rules[typeof(PlotOutline)]);
            Assert.IsNotNull(rules[typeof(Tagline)]);
            Assert.IsNotNull(rules[typeof(MPAARating)]);
            Assert.IsNotNull(rules[typeof(Top250)]);
            Assert.IsNotNull(rules[typeof(Status)]);
            Assert.IsNotNull(rules[typeof(Votes)]);
            Assert.IsNotNull(rules[typeof(Director)]);
            Assert.IsNotNull(rules[typeof(Actor)]);
            Assert.IsNotNull(rules[typeof(Studio)]);
            Assert.IsNotNull(rules[typeof(Country)]);
            Assert.IsNotNull(rules[typeof(NumEpisodes)]);
            Assert.IsNotNull(rules[typeof(NumWatched)]);
            Assert.IsNotNull(rules[typeof(Writers)]);
            Assert.IsNotNull(rules[typeof(AirDate)]);
            Assert.IsNotNull(rules[typeof(Episode)]);
            Assert.IsNotNull(rules[typeof(Season)]);
            Assert.IsNotNull(rules[typeof(TVShow)]);
            Assert.IsNotNull(rules[typeof(EpisodeTitle)]);
            Assert.IsNotNull(rules[typeof(Review)]);
            Assert.IsNotNull(rules[typeof(Themes)]);
            Assert.IsNotNull(rules[typeof(Moods)]);
            Assert.IsNotNull(rules[typeof(Styles)]);
            Assert.IsNotNull(rules[typeof(MediaType)]);
            Assert.IsNotNull(rules[typeof(Label)]);
            Assert.IsNotNull(rules[typeof(HasTrailer)]);
            Assert.IsNotNull(rules[typeof(VideoResolution)]);
            Assert.IsNotNull(rules[typeof(AudioChannels)]);
            Assert.IsNotNull(rules[typeof(AudioCount)]);
            Assert.IsNotNull(rules[typeof(SubtitleCount)]);
            Assert.IsNotNull(rules[typeof(VideoCodec)]);
            Assert.IsNotNull(rules[typeof(AudioCodec)]);
            Assert.IsNotNull(rules[typeof(AudioLanguage)]);
            Assert.IsNotNull(rules[typeof(SubtitleLanguage)]);
            Assert.IsNotNull(rules[typeof(VideoAspect)]);
            Assert.IsNotNull(rules[typeof(Set)]);
            Assert.IsNotNull(rules[typeof(Tag)]);
            Assert.IsNull(rules[typeof(Instruments)]);
            Assert.IsNull(rules[typeof(Biography)]);
            Assert.IsNull(rules[typeof(Born)]);
            Assert.IsNull(rules[typeof(BandFormed)]);
            Assert.IsNull(rules[typeof(Disbanded)]);
            Assert.IsNull(rules[typeof(Died)]);
            Assert.IsNotNull(rules[typeof(PlayList)]);
            Assert.IsNotNull(rules[typeof(VirtualFolder)]);
            Assert.IsNull(rules[typeof(Role)]);
            Assert.IsNull(rules[typeof(Compilation)]);
            Assert.IsNull(rules[typeof(UserRating)]);
        }

        [TestMethod]
        public void ParseXmlPlaylist()
        {
            SmartPlayList playlist = null;
            using (IO.FileStream fs = IO.File.Open(AppDomain.CurrentDomain.BaseDirectory + "\\Samples\\Random.xsp", IO.FileMode.Open))
            {
                playlist = SmartPlayList.LoadFromStream(fs);
                fs.Close();
            }
            if (IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\Samples\\Test.xsp"))
                IO.File.Delete(AppDomain.CurrentDomain.BaseDirectory + "\\Samples\\Test.xsp");

            using (IO.FileStream fs = IO.File.Create(AppDomain.CurrentDomain.BaseDirectory + "\\Samples\\Test.xsp"))
            {
                playlist.Save(fs);
                fs.Close();
            }
        }
    }
}
