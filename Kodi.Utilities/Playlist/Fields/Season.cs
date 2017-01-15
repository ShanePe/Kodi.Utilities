using Kodi.Utilities.Attributes;
using Kodi.Utilities.Interfaces;
using Kodi.Utilities.Validators;

namespace Kodi.Utilities.Playlist.Fields
{
    /// <summary>
    /// Season Field
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IRule" />
    [FieldAllocation("season",
        typeof(int),
        SmartPlayList.Types.Episodes,
        SmartPlayList.Types.Mixed)]
    public class Season : IRule
    {

        public override IValidator Validator
        {
            get
            {
                return new PositiveIntValidator();
            }
        }
    }
}