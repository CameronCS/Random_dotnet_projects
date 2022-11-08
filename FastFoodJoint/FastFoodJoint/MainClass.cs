using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace MainApp {
    internal class MainClass {
        public static void Main() {
            Application app = new Application();
            app.MainLoop();
        }
    }
}
