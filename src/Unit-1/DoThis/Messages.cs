using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinTail
{
    class Messages
    {
        #region Neutral/system messages
        
        /// <summary>
        /// Marker Class to continue processing
        /// </summary>
        public class ContinueProcessing { }

        #endregion

        #region Success messages
        
        /// <summary>
        /// Base class for signalling that user input was valid
        /// </summary>
        public class InputSuccess 
        {
            public InputSuccess(string reason)
            {
                Reason = reason;
            }

            public string Reason { get; private set; }
        }
        #endregion

        #region Error messages
        
        /// <summary>
        /// Base class for signalling that user input was not valid
        /// </summary>
        public class InputError 
        {
            public InputError(string reason)
            {
                Reason = reason;
            }

            public string Reason { get; private set; }
        }

        /// <summary>
        /// User provided blank reason
        /// </summary>
        public class NullInputError : InputError
        {
            public NullInputError(string reason) : base(reason) { }
        }

        /// <summary>
        /// User provided invalid input (currently, input with odd number of chararcters)
        /// </summary>
        public class ValidationError : InputError
        {
            public ValidationError(string reason) : base(reason) { }
        }

        #endregion
    }
}
