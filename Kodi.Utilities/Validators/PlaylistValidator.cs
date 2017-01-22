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
    /// <summary>
    /// Validates the playlist
    /// </summary>
    public class PlaylistValidator
    {
        /// <summary>
        /// Validates the specified play list.
        /// </summary>
        /// <param name="playList">The play list.</param>
        /// <exception cref="MissingValueException">
        /// Name - SmartPlayList
        /// or
        /// Field - rule
        /// or
        /// Operator - rule
        /// or
        /// Values - rule
        /// </exception>
        /// <exception cref="NoValueAllowedForRuleException"></exception>
        /// <exception cref="MultiValueViolationException"></exception>
        /// <exception cref="FieldNotValidForTypeException"></exception>
        /// <exception cref="InvalidOrderByException"></exception>
        /// <exception cref="InvalidGroupException"></exception>
        public void Validate(SmartPlayList playList)
        {
            if (CheckForValue(playList.Name))
                throw new MissingValueException(nameof(playList.Name), nameof(SmartPlayList));

            foreach (IRule rule in playList.Rules)
            {
                if (CheckForValue(rule.Field))
                    throw new MissingValueException(nameof(rule.Field), nameof(rule));

                if (rule.Operator == null)
                    throw new MissingValueException(nameof(rule.Operator), nameof(rule));

                if (rule.Operator.NoValue && rule.Values.Count > 0)
                    throw new NoValueAllowedForRuleException(rule);

                if (!rule.Operator.NoValue && rule.Values.Count == 0)
                    throw new MissingValueException(nameof(rule.Values), nameof(rule));

                if (!rule.IsMultipleValuesAllowed && rule.Values.Count > 1)
                    throw new MultiValueViolationException(rule);

                if (!rule.IsFieldForPlaylist(playList.MediaType))
                    throw new FieldNotValidForTypeException(rule, playList);

                if (playList.OrderBy != null)
                    if (!playList.OrderBy.IsOrderByForPlaylist(playList.MediaType))
                        throw new InvalidOrderByException(rule, playList.MediaType);

                if (playList.Group != null)
                    if (!playList.Group.IsGroupForPlaylist(playList.MediaType))
                        throw new InvalidGroupException(playList.Group, playList.MediaType);
            }
        }

        /// <summary>
        /// Checks if the value is valid.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        private bool CheckForValue(string value)
        {
            return (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value));
        }
    }
}
