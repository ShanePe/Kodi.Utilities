namespace Kodi.Utilities.Data
{
    /// <summary>
    /// Resent an ISO 639-2 Language code
    /// </summary>
    public class ISO6392Language
    {
        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        public string Code { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ISO6392Language"/> class.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <param name="name">The name.</param>
        internal ISO6392Language(string code, string name)
        {
            Code = code;
            Name = name;
        }

        private ISO6392Language() { }
    }
}
