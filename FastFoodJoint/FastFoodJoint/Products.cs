using System;
using CExcept;

namespace ApplicationClasses {
    public class CSArray<T> {
        private T[] _this;
        private int _length;

        public CSArray() {
            this._length = 0;
            this._this = new T[this._length];
        }

        public void Append(T item) {
            T[] temp = this._this;
            this._this = new T[++this._length];
            for (int i = 0; i < temp.Length; i++) {
                this._this[i] = temp[i];
            }
            this._this[this._length - 1] = item;
        }

        public T Get(int index) {
            if (index >= this._length) {
                throw new IndexOutOfRangeException($"Index {index} is out of range {this._length - 1}");
            }
            return this._this[index];
        }

        public void Remove(int index) {
            if (index >= this.Length) {
                throw new IndexOutOfRangeException($"Index <{index}> is out of range for length <{this.Length}>");
            }
            T[] temp = this._this;
            this._this = new T[--this._length];
            for (int i = 0, j = 0; i < temp.Length; i++) {
                if (i != index) {
                    this._this[j] = temp[i];
                }
            }
        }

        public T Pop(int index) {
            if (index >= this.Length) {
                throw new IndexOutOfRangeException($"Index <{index}> is out of range for lenght <{this.Length}>");
            }
            T[] temp = this._this;
            this._this = new T[--this._length];
            T popped_value = default;
            for (int i = 0, j = 0; i < temp.Length; i++) {
                if (i != index) {
                    this._this[j] = temp[i];
                } else {
                    popped_value = temp[i];
                }
            }
            return popped_value;
        }

        #region Properties
        public int Length {
            get {
                return this._length;
            }
        }

        public T GetFirst {
            get {
                return this._this[0];
            }
        }

        public T GetLast {
            get {
                return this._this[this.Length - 1];
            }
        }
        #endregion
    }

    public class Product {
        private int itemNumber;
        private string name;
        private double price;
        private int qty;
        
        public Product(string name, double price) {
            this.name = name;
            this.price = price;
        }

        public int ItemNumber {
            get {
                return this.itemNumber;
            }
            set {
                if (value < 0) {
                    throw new InvalidPositionE("The Position on the table can not be negative");
                }
                this.itemNumber = value;
            }
        }

        public string Name {
            get {
                return this.name;

            }
            set {
                if (value == null || value == "") {
                    throw new InvalidNameE("Name can not null or Empty");
                }
                this.name = value;
            }
        }

        public double Price {
            get {
                return this.price;
            }
            set {
                if (value < 0) {
                    throw new InvalidPriceE("Price can not be negative");
                }
                this.price = value;
            }
        }

        public int Quantity {
            get {
                return this.qty;
            }
            set {
                if (value < 0) {
                    throw new InvalidQuantityE("A Quantity can not be less than 0");
                }
                this.qty = value;
            }
        }

    }
}