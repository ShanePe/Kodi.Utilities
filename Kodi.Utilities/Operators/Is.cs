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
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public override string Name { get { return "Is"; } }
    }
}
