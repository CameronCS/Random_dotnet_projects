using System;

namespace DLL_Space {
    partial class StaticOnlyClassException : Exception {
        public StaticOnlyClassException(string message) : base(message) { }
    }
    
    public class Terminal {
#pragma warning disable IDE0060
        public Terminal(Object o) {
#pragma warning restore IDE0060
            throw new StaticOnlyClassException("This class can only be static");
        }
    }
}