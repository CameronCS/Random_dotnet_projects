using System;

namespace CExcept {
    public class InvalidQuantityE : SystemException {
        public InvalidQuantityE(string message) : base(message) { }
    }

    public class InvalidPriceE: SystemException {
        public InvalidPriceE(string message) : base(message) { }
    }

    public class InvalidPositionE : SystemException {
        public InvalidPositionE(string message) : base(message) { }
    }

    public class InvalidNameE : SystemException {
        public InvalidNameE(string message) : base(message) { }
    }
}