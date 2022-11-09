using System;
using System.Runtime.InteropServices;

namespace DLL_Space {
    
    public class StaticReader {
        public StaticReader() {  }
        [DllImport("CS_DLL", CallingConvention = CallingConvention.StdCall, EntryPoint = "getStr")]
        private static extern string getStr(string prompt, bool newLine);
        public static string GetLine(string prompt = null, bool newLine = true) {
            string returns = "";
            try {
                string _prompt = "";
                bool _newl = true;
                if (prompt != null) {
                    _prompt = prompt;
                }
                _newl = newLine;
                returns = StaticReader.getStr(_prompt, _newl);
            } catch (Exception e) {
                Console.WriteLine($"Exception: {e.GetType()}\nMessage: {e.Message}\nStack Trace = {e.StackTrace}");
            } finally {
                returns = null;
            }
            return returns;
        }
    }
}