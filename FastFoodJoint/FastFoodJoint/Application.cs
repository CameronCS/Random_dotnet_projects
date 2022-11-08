using System;
using System.IO;
using System.Data;
using System.Threading;
using ApplicationClasses;
using System.Data.SQLite;
using System.Runtime.InteropServices;

namespace MainApp {
    enum OrderType {
        EatIn, 
        TakeAway
    }

    internal class Application {
        private bool appfinished;
        private CSArray<Product> stock;
        private CSArray<Product> cart;
        private SQLite db;

        public Application() {
            this.db = new SQLite("ffj.sqlite3");
            this.appfinished = false;
            this.stock = db.GetAll();
        }

        public void MainLoop() {
            Console.WriteLine("Welcome to \"Cams\"!");
            do {
                this.DisplayMenu();
                int choice = InputManager.GetInt();
                switch (choice) {
                    case (1): this.Browse(); break;
                    case (2): this.appfinished = true; break;
                    case (11): this.AdminLogin(); break;
                    default:
                        Console.Write("Your option was invalid");
                        Thread.Sleep(1000);
                        InputManager.Clear();
                        break;
                }
            } while (!this.appfinished);
        }

        private void DisplayMenu() {
            Console.WriteLine("1) Enter App\n2) Exit App");
        }

        private void Browse() {
            bool order_type_bool;
            InputManager.Clear();
            int option;
            do {
                order_type_bool = true;
                Console.WriteLine("1) Eat in\n2) Take Away");
                option = InputManager.GetInt();
                if (!(option > 0 && option < 3)) {
                    order_type_bool = false;
                    InputManager.Clear();
                }
            } while (!order_type_bool);
            OrderType orderType = (OrderType)(option - 1);
            FoodMenu();
        }

        private void FoodMenu() {
            int total_cat = this.stock.Length;
            for (int i = 0; i < total_cat; i++) {

            }
        }

        private void AdminLogin() {

        }
    }

    partial class InputManager {
        [DllImport("clidll.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void Clear();

        public static string GetLine(string prompt, bool? newLine) {
            Console.Write($"{prompt}: ");
            if (newLine == null || newLine.Value == true) {
                Console.Write("\n");
            }
            return Console.ReadLine();
        }

        public static int GetInt(string prompt = null, bool? newLine = null) { 
            if (prompt != null) {
                Console.Write(prompt);
            }
            if (newLine == null || newLine.Value == true) {
                Console.Write("\n");
            }
            try {
                return int.Parse(Console.ReadLine());
            } catch (ArgumentNullException) {
                Console.WriteLine("You need to enter something!");
                Thread.Sleep(1000);
                return -1;
            } catch (OverflowException) {
                Console.WriteLine("Woah! That number is massive, its definitly not on our menu!");
                return -1;
            } catch (FormatException) {
                Console.WriteLine("Excuse me, do you know what a number is?\nBecause its not that -.-");
                return -1;
            }
        }

        public static void Pause() {
            Console.WriteLine("Press any key to exit . . .");
            Console.Read();
        }
    }

    sealed class SQLite {
        private readonly string con_str;
        private SQLiteConnection _con;

        private readonly string ITEM_NUM = "ItemNumber";
        private readonly string ITEM_NAME = "ItemName";
        private readonly string PRICE = "Price";
        private readonly string QUANTITY = "Quantity";

        public SQLite(string dbName) {
            this.con_str = $"Data source = {Path.Combine(Environment.CurrentDirectory, dbName)}";
        }

        private void Connect() {
            this._con = new SQLiteConnection(this.con_str);
            this._con.Open();
        }

        private void Close() {
            this._con.Close();
        }

        public CSArray<Product> GetAll() {
            this.Connect();
            CSArray<Product> result = new CSArray<Product>();

            SQLiteCommand sCmd = this._con.CreateCommand();
            sCmd.CommandText = @"SELECT * from tblProducts";
            sCmd.CommandType = CommandType.Text;

            SQLiteDataReader data_reader = sCmd.ExecuteReader();
            while (data_reader.Read()) {
                result.Append(
                    new Product(
                        Convert.ToString(data_reader[this.ITEM_NAME]),
                        Convert.ToDouble(data_reader[this.PRICE])
                    ) {
                        Quantity = Convert.ToInt32(data_reader[this.QUANTITY]),
                        ItemNumber = Convert.ToInt32(data_reader[this.ITEM_NUM])
                    }
                );
            }
            this.Close();

            return result;
        }
    }
}