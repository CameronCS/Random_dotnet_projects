using System;

namespace IO {
    public class Terminal {
        private const char TERM = '\n';
        private static void Write(string prompt = null) {
            if (prompt != null) {
                Console.Write(prompt);
            }
        }
        private static void Write(string prompt, params object[] args) {
            Console.Write(prompt, args);
        }
        private static void Newl(bool newLine = false) {
            if (newLine == true) {
                Console.Write(TERM);
            }
        }
        public static string GetLine(string prompt = null, bool newLine = true) {
            Write(prompt);
            Newl(newLine);
            return Console.ReadLine();
        }
        public static char GetChar(string prompt = null, bool newLine = true) {
            Write(prompt);
            Newl(newLine);
            return Console.ReadKey().KeyChar;
        }
        public static byte GetByte(string prompt = null, bool newLine = true) {
            Write(prompt);
            Newl(newLine);
            byte user_in = 0;
            string byte_as_str = Console.ReadLine();
            try {
                user_in = byte.Parse(byte_as_str);
            } 
            catch (OverflowException) { } catch (FormatException) { }
            return user_in;
        }
        public static short GetShort(string prompt = null, bool newLine = true) {
            Write(prompt);
            Newl(newLine);
            short user_in = -1;
            string short_as_str = Console.ReadLine();
            try {
                user_in = short.Parse(short_as_str);
            } 
            catch (OverflowException) { } catch (FormatException) { }
            return user_in;
        }
        public static int GetInt(string prompt = null, bool newLine = true) {
            Write(prompt);
            Newl(newLine);
            int user_in = -1;
            string int_as_str = Console.ReadLine();
            try {
                user_in = int.Parse(int_as_str);
            } 
            catch (OverflowException) { } catch (FormatException) { }
            return user_in;
        }
        public static long GetLong(string prompt = null, bool newLine = true) {
            Write(prompt);
            Newl(newLine);
            long user_in = -1;
            string long_as_str = Console.ReadLine();
            try {
                user_in = long.Parse(long_as_str);
            } 
            catch (OverflowException) { } catch (FormatException) { }
            return user_in;
        }
        public static float GetFloat(string prompt = null, bool newLine = true) {
            Write(prompt);
            Newl(newLine);
            float user_in = -1;
            string float_as_str = Console.ReadLine();
            try {
                user_in = float.Parse(float_as_str);
            } 
            catch (OverflowException) { } catch (FormatException) { }
            return user_in;
        }
    }
}
