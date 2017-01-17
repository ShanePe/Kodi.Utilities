using Kodi.Utilities.Interfaces;

namespace Kodi.Utilities.Operators
{
    /// <summary>
    /// Is operator
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IOperator" />
    public class Is : IOperator
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
                return Name;
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
                return "Is";
            }
        }
        /// <summary>
        /// Gets a value indicating whether the field has no value for this operator (i.e True/False).
        /// </summary>
        /// <value>
        /// <c>true</c> if the field has no value for this operator; otherwise, <c>false</c>.
        /// </value>
        public bool NoValue
        {
            get
            {
                return false;
            }
        }
    }
}
