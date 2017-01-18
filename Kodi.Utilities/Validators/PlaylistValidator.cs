using Kodi.Utilities.Collection;
using Kodi.Utilities.Exceptions;
using Kodi.Utilities.Interfaces;
using Kodi.Utilities.Playlist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Validators
{
    public class PlaylistValidator
    {
        public void Validate(SmartPlayList playList)
        {
            if (CheckForValue(playList.Name))
                throw new MissingValueException(nameof(playList.Name), nameof(SmartPlayList));

            RuleCollection rules = playList.GetAvailableFields();

            foreach (IRule rule in playList.Rules)
            {
                if (CheckForValue(rule.Field))
                    throw new MissingValueException(nameof(rule.Field), nameof(rule));

                if (rule.Values.Count == 0)
                    throw new MissingValueException(nameof(rule.Values), nameof(rule));

                if (rule.Operator == null)
                    throw new MissingValueException(nameof(rule.Operator), nameof(rule));

                if (!rule.IsAllowedForPlaylistType(playList.Type))
                    throw new FieldNotValidForTypeException(rule, playList);
            }
        }

        private bool CheckForValue(string value)
        {
            return (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value));
        }
    }
}
