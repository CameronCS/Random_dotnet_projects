using System;
using DLL_Space;

namespace MainSpace {
    internal class MainClass {
        public static void Main(string[] args) {
            string s = StaticReader.GetLine("Enter a character: ", true);
            Console.WriteLine(s);
        }
    }
}

namespace Application {
    public class App {
        public App() {

        }
    }
}