using System;
using Kodi.Utilities.Interfaces;

namespace Kodi.Utilities.Operators
{
    /// <summary>
    /// After operator
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IOperator" />
    public class After : IOperator
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public override string Name { get { return "After"; } }

    }
}
