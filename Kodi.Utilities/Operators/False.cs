﻿using Kodi.Utilities.Interfaces;

namespace Kodi.Utilities.Operators
{
    /// <summary>
    /// False operator
    /// </summary>
    /// <seealso cref="Kodi.Utilities.Interfaces.IOperator" />
    public class False : IOperator
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public override string Name { get { return "False"; } }

        /// <summary>
        /// Gets a value indicating whether the field has no value for this operator (i.e True/False).
        /// </summary>
        /// <value>
        /// <c>true</c> if the field has no value for this operator; otherwise, <c>false</c>.
        /// </value>
        public override bool NoValue { get { return true; } }
    }
}
