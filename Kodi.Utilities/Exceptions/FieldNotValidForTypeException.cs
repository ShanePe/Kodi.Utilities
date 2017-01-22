using Kodi.Utilities.Interfaces;
using Kodi.Utilities.Playlist;
using System;

namespace Kodi.Utilities.Exceptions
{
    /// <summary>
    /// Handles invalid playlist type.
    /// </summary>
    /// <seealso cref="System.Exception" />
    class FieldNotValidForTypeException : Exception
    {
        public FieldNotValidForTypeException(IRule rule, SmartPlayList playlist) :
            base($"Field {rule.FriendlyName} not valid for playlist type {playlist.GetPlayListEnumAsString(typeof(SmartPlayList.Types), playlist.MediaType)}")
        {
        }
    }
}
