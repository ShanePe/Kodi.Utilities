using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kodi.Utilities.Collection;
using Kodi.Utilities.Playlist;
using Kodi.Utilities.Interfaces;

namespace Kodi.Utilities.Test
{
    [TestClass]
    public class GroupTest
    {
        private IGroup[] GetRulesForType(SmartPlayList.Types type)
        {
            SmartPlayList playlist = new SmartPlayList("Test")
            {
                Type = type
            };

            return playlist.GetAvailableGroups();
        }
        [TestMethod]
        public void ActorGroupAllocation()
        {
        }
    }
}
