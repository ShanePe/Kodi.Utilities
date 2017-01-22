using Kodi.Utilities.Interfaces;

namespace Kodi.Utilities.Operators
{
    /// <summary>
    /// Before operator
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IOperator" />
    public class Before : IOperator
    {

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public override string Name { get { return "Before"; } }
    }
}
