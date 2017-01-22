using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Exceptions
{
    /// <summary>
    /// Handles non ISO 639-2 Languages
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class InvalidLanguageException : Exception
    {
        public InvalidLanguageException(string value)
            : base($"{value} is not a valid ISO639-2 language code or name. (Normally first 3 characters of the language name in English)")
        { }
    }
}
