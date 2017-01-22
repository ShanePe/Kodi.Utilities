using System;
using Kodi.Utilities.Extensions;

namespace Kodi.Utilities.Interfaces
{
    /// <summary>
    /// For rule field operators
    /// </summary>
    public abstract class IOperator : IComparable<IOperator>
    {

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public abstract string Name { get; }
        /// <summary>
        /// Gets the user readable name of the operator
        /// </summary>
        /// <value>
        /// Name
        /// </value>
        public virtual string FriendlyName { get { return Name.SplitCamel().ToTitleCase(); } }
        /// <summary>
        /// Gets a value indicating whether the field has no value for this operator (i.e True/False).
        /// </summary>
        /// <value>
        ///   <c>true</c> if the field has no value for this operator; otherwise, <c>false</c>.
        /// </value>
        public virtual bool NoValue { get { return false; } }
        /// <summary>
        /// Compares the current object with another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other" /> parameter.Zero This object is equal to <paramref name="other" />. Greater than zero This object is greater than <paramref name="other" />.
        /// </returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public int CompareTo(IOperator other)
        {
            return this.Name.CompareTo(other.Name);
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return Name.SplitCamel().ToLower();
        }
    }
}
