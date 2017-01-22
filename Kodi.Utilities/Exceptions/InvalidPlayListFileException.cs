using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodi.Utilities.Exceptions
{
    /// <summary>
    /// Handles invalid file.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class InvalidPlayListFileException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidPlayListFileException" /> class.
        /// </summary>
        public InvalidPlayListFileException()
            : base($"Invalid Kodi Smart PlayList.")
        { }
    }
}
