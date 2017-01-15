using Kodi.Utilities.Interfaces;
using Kodi.Utilities.Extensions;

namespace Kodi.Utilities.Operators
{
    /// <summary>
    /// In the last operator
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IOperator" />
    public class InTheLast : IOperator
    {
        /// <summary>
        /// Gets the user readable name of the operator
        /// </summary>
        /// <value>
        /// Name
        /// </value>
        public string FriendlyName
        {
            get
            {
                return Name.SplitCamel().ToTitleCase();
            }
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {

            get
            {
                return "InTheLast";
            }
        }
    }
}
