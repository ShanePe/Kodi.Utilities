namespace Kodi.Utilities.Interfaces
{
    /// <summary>
    /// Interface for validators
    /// </summary>
    public interface IValidator
    {
        /// <summary>
        /// Validates the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        void Validate(object value);
    }
}
