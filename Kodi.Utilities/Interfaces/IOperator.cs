namespace Kodi.Utilities.Interfaces
{
    /// <summary>
    /// For rule field operators
    /// </summary>
    public interface IOperator
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        string Name { get; }
        /// <summary>
        /// Gets the user readable name of the operator
        /// </summary>
        /// <value>
        /// Name
        /// </value>
        string FriendlyName { get; }
        /// <summary>
        /// Gets a value indicating whether the field has no value for this operator (i.e True/False).
        /// </summary>
        /// <value>
        ///   <c>true</c> if the field has no value for this operator; otherwise, <c>false</c>.
        /// </value>
        bool NoValue { get; }
    }
}
