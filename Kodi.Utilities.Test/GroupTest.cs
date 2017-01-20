using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kodi.Utilities.Collection;
using Kodi.Utilities.Playlist;
using Kodi.Utilities.Interfaces;
using Kodi.Utilities.Playlist.Groups;

namespace Kodi.Utilities.Test
{
    [TestClass]
    public class GroupTest
    {
        private Holder GetGroupForType(SmartPlayList.Types type)
        {
            SmartPlayList playlist = new SmartPlayList("Test")
            {
                Type = type
            };

            Holder groups = new Holder();

            foreach (IGroup group in playlist.GetAvailableGroups())
                groups.Add(group.GetType(), group);

            return groups;
        }

        [TestMethod]
        public void AlbumsGroupAllocation()
        {
            Holder groups = GetGroupForType(SmartPlayList.Types.Albums);
            Assert.IsNull(groups[typeof(Actors)]);
            Assert.IsNull(groups[typeof(Albums)]);
            Assert.IsNull(groups[typeof(Artists)]);
            Assert.IsNull(groups[typeof(Countries)]);
            Assert.IsNull(groups[typeof(Directors)]);
            Assert.IsNull(groups[typeof(Genres)]);
            Assert.IsNull(groups[typeof(None)]);
            Assert.IsNull(groups[typeof(Sets)]);
            Assert.IsNull(groups[typeof(Studios)]);
            Assert.IsNull(groups[typeof(Tags)]);
            Assert.IsNull(groups[typeof(Writers)]);
            Assert.IsNotNull(groups[typeof(Years)]);
        }

        [TestMethod]
        public void ArtistGroupAllocation()
        {
            Holder groups = GetGroupForType(SmartPlayList.Types.Artists);
            Assert.IsNull(groups[typeof(Actors)]);
            Assert.IsNull(groups[typeof(Albums)]);
            Assert.IsNull(groups[typeof(Artists)]);
            Assert.IsNull(groups[typeof(Countries)]);
            Assert.IsNull(groups[typeof(Directors)]);
            Assert.IsNotNull(groups[typeof(Genres)]);
            Assert.IsNull(groups[typeof(None)]);
            Assert.IsNull(groups[typeof(Sets)]);
            Assert.IsNull(groups[typeof(Studios)]);
            Assert.IsNull(groups[typeof(Tags)]);
            Assert.IsNull(groups[typeof(Writers)]);
            Assert.IsNull(groups[typeof(Years)]);
        }

        [TestMethod]
        public void EpisodesGroupAllocation()
        {
            Holder groups = GetGroupForType(SmartPlayList.Types.Episodes);
            Assert.IsNull(groups[typeof(Actors)]);
            Assert.IsNull(groups[typeof(Albums)]);
            Assert.IsNull(groups[typeof(Artists)]);
            Assert.IsNull(groups[typeof(Countries)]);
            Assert.IsNull(groups[typeof(Directors)]);
            Assert.IsNull(groups[typeof(Genres)]);
            Assert.IsNull(groups[typeof(None)]);
            Assert.IsNull(groups[typeof(Sets)]);
            Assert.IsNull(groups[typeof(Studios)]);
            Assert.IsNull(groups[typeof(Tags)]);
            Assert.IsNull(groups[typeof(Writers)]);
            Assert.IsNull(groups[typeof(Years)]);
        }

        [TestMethod]
        public void MixedGroupAllocation()
        {
            Holder groups = GetGroupForType(SmartPlayList.Types.Mixed);
            Assert.IsNull(groups[typeof(Actors)]);
            Assert.IsNull(groups[typeof(Albums)]);
            Assert.IsNull(groups[typeof(Artists)]);
            Assert.IsNull(groups[typeof(Countries)]);
            Assert.IsNull(groups[typeof(Directors)]);
            Assert.IsNull(groups[typeof(Genres)]);
            Assert.IsNull(groups[typeof(None)]);
            Assert.IsNull(groups[typeof(Sets)]);
            Assert.IsNull(groups[typeof(Studios)]);
            Assert.IsNull(groups[typeof(Tags)]);
            Assert.IsNull(groups[typeof(Writers)]);
            Assert.IsNull(groups[typeof(Years)]);
        }

        [TestMethod]
        public void MoviesGroupAllocation()
        {
            Holder groups = GetGroupForType(SmartPlayList.Types.Movies);
            Assert.IsNotNull(groups[typeof(Actors)]);
            Assert.IsNull(groups[typeof(Albums)]);
            Assert.IsNull(groups[typeof(Artists)]);
            Assert.IsNotNull(groups[typeof(Countries)]);
            Assert.IsNotNull(groups[typeof(Directors)]);
            Assert.IsNotNull(groups[typeof(Genres)]);
            Assert.IsNotNull(groups[typeof(None)]);
            Assert.IsNotNull(groups[typeof(Sets)]);
            Assert.IsNotNull(groups[typeof(Studios)]);
            Assert.IsNotNull(groups[typeof(Tags)]);
            Assert.IsNotNull(groups[typeof(Writers)]);
            Assert.IsNotNull(groups[typeof(Years)]);
        }

        [TestMethod]
        public void MusicVideoGroupAllocation()
        {
            Holder groups = GetGroupForType(SmartPlayList.Types.MusicVideos);
            Assert.IsNull(groups[typeof(Actors)]);
            Assert.IsNotNull(groups[typeof(Albums)]);
            Assert.IsNotNull(groups[typeof(Artists)]);
            Assert.IsNull(groups[typeof(Countries)]);
            Assert.IsNotNull(groups[typeof(Directors)]);
            Assert.IsNotNull(groups[typeof(Genres)]);
            Assert.IsNull(groups[typeof(None)]);
            Assert.IsNull(groups[typeof(Sets)]);
            Assert.IsNotNull(groups[typeof(Studios)]);
            Assert.IsNotNull(groups[typeof(Tags)]);
            Assert.IsNull(groups[typeof(Writers)]);
            Assert.IsNotNull(groups[typeof(Years)]);
        }

        [TestMethod]
        public void SongsGroupAllocation()
        {
            Holder groups = GetGroupForType(SmartPlayList.Types.Songs);
            Assert.IsNull(groups[typeof(Actors)]);
            Assert.IsNull(groups[typeof(Albums)]);
            Assert.IsNull(groups[typeof(Artists)]);
            Assert.IsNull(groups[typeof(Countries)]);
            Assert.IsNull(groups[typeof(Directors)]);
            Assert.IsNull(groups[typeof(Genres)]);
            Assert.IsNull(groups[typeof(None)]);
            Assert.IsNull(groups[typeof(Sets)]);
            Assert.IsNull(groups[typeof(Studios)]);
            Assert.IsNull(groups[typeof(Tags)]);
            Assert.IsNull(groups[typeof(Writers)]);
            Assert.IsNull(groups[typeof(Years)]);
        }

        [TestMethod]
        public void TVShowsGroupAllocation()
        {
            Holder groups = GetGroupForType(SmartPlayList.Types.TVShows);
            Assert.IsNotNull(groups[typeof(Actors)]);
            Assert.IsNull(groups[typeof(Albums)]);
            Assert.IsNull(groups[typeof(Artists)]);
            Assert.IsNull(groups[typeof(Countries)]);
            Assert.IsNotNull(groups[typeof(Directors)]);
            Assert.IsNotNull(groups[typeof(Genres)]);
            Assert.IsNull(groups[typeof(None)]);
            Assert.IsNull(groups[typeof(Sets)]);
            Assert.IsNotNull(groups[typeof(Studios)]);
            Assert.IsNotNull(groups[typeof(Tags)]);
            Assert.IsNull(groups[typeof(Writers)]);
            Assert.IsNotNull(groups[typeof(Years)]);
        }
    }
}
