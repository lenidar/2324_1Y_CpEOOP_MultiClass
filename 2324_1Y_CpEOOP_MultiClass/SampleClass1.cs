using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2324_1Y_CpEOOP_MultiClass
{
    /// <summary>
    /// This is just the sample class
    /// </summary>
    internal class SampleClass1
    {
        public string message = "This is the default public message from this class";
        private string pMessage = "This is the default private message from this class";

        /// <summary>
        /// This is how you get the private message
        /// </summary>
        /// <returns>The private message in string form</returns>
        public string getPMessage()
        {
            return pMessage;
        }

        /// <summary>
        /// Updates the value of the private message
        /// </summary>
        /// <param name="newMessage">The new private message</param>
        public void setPMessage(string newMessage)
        {
            pMessage = newMessage;
        }
    }
}
