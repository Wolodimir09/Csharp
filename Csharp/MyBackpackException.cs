using System;
using System.Runtime.Serialization;

namespace Csharp
{
    [Serializable]
    internal class MyBackpackException : Exception
    {
        public MyBackpackException()
        {
        }

        public MyBackpackException(string message) : base(message)
        {
            
        }

        
    }
}