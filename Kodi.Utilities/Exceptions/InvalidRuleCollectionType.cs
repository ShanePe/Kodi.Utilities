using System;

namespace Kodi.Utilities.Exceptions
{
    /// <summary>
    /// Exception for when an invalid type is added to the rule collection.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class InvalidRuleCollectionType : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidRuleCollectionType"/> class.
        /// </summary>
        /// <param name="t">The t.</param>
        public InvalidRuleCollectionType(Type t)
            : base($"Invalid type for rule collection : {t.ToString()}") { }
    }
}
