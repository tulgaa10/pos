using System.Data.SQLite;
using System.IO;

namespace pos
{
    public static class DatabaseInitializer
    {
        public static void InitializeDatabase(string dbPath)
        {
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
            }

            using (var conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                conn.Open();

                CreateUsersTable(conn);
                SeedUsers(conn);
                CreateCategoriesTable(conn);
                CreateProductsTable(conn);
                SeedProducts(conn);
            }
        }
        private static void CreateCategoriesTable(SQLiteConnection conn)
        {
            string query = @"
        CREATE TABLE IF NOT EXISTS Categories (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            NameC TEXT NOT NULL UNIQUE
        );";
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }

        private static void CreateUsersTable(SQLiteConnection conn)
        {
            string query = @"
                CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT NOT NULL,
                    Password TEXT NOT NULL,
                    Role TEXT NOT NULL
                );";
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }

        private static void SeedUsers(SQLiteConnection conn)
        {
            string countQuery = "SELECT COUNT(*) FROM Users;";
            using (var cmd = new SQLiteCommand(countQuery, conn))
            {
                long count = (long)cmd.ExecuteScalar();
                if (count == 0)
                {
                    string[] insertUsers =
                    {
                        "INSERT INTO Users (Username, Password, Role) VALUES ('manager', '1234', 'Manager');",
                        "INSERT INTO Users (Username, Password, Role) VALUES ('cashier1', '1234', 'Cashier');",
                        "INSERT INTO Users (Username, Password, Role) VALUES ('cashier2', '1234', 'Cashier');"
                    };

                    foreach (var user in insertUsers)
                    {
                        using (var cmdInsert = new SQLiteCommand(user, conn))
                        {
                            cmdInsert.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        private static void CreateProductsTable(SQLiteConnection conn)
        {
            string query = @"
                CREATE TABLE IF NOT EXISTS Products (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Price REAL NOT NULL,
                    Discount REAL DEFAULT 0,
                    CategoryId INTEGER NOT NULL,
                    Barcode TEXT,
                    FOREIGN KEY(CategoryId) REFERENCES Categories(Id)
                );";
            using (var cmd = new SQLiteCommand(query, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }

        private static void SeedProducts(SQLiteConnection conn)
        {
            string countQuery = "SELECT COUNT(*) FROM Products;";
            using (var cmd = new SQLiteCommand(countQuery, conn))
            {
                long count = (long)cmd.ExecuteScalar();
                if (count == 0)
                {
                    string[] categories = { "Bakery", "Drinks", "Snacks" };
                    var categoryIds = new Dictionary<string, long>();

                    foreach (var category in categories)
                    {
                        string insertCategory = "INSERT OR IGNORE INTO Categories (NameC) VALUES (@NameC);";
                        using (var cmdInsertCategory = new SQLiteCommand(insertCategory, conn))
                        {
                            cmdInsertCategory.Parameters.AddWithValue("@NameC", category);
                            cmdInsertCategory.ExecuteNonQuery();
                        }

                        string getIdQuery = "SELECT Id FROM Categories WHERE NameC = @NameC;";
                        using (var cmdGetId = new SQLiteCommand(getIdQuery, conn))
                        {
                            cmdGetId.Parameters.AddWithValue("@NameC", category);
                            long id = (long)cmdGetId.ExecuteScalar();
                            categoryIds[category] = id;
                        }
                    }

                    string[] products = new string[]
                    {
                "Croissant", "Bagel", "Donut", "Muffin", "Scone", "Cheesecake", "Brownie", "Cookie",
                "Espresso", "Latte", "Cappuccino", "Mocha", "Tea", "Hot Chocolate", "Iced Coffee",
                "Smoothie", "Juice", "Water", "Sandwich", "Salad"
                    };

                    string[] bakery = { "Croissant", "Bagel", "Donut", "Muffin", "Scone", "Cheesecake", "Brownie", "Cookie" };
                    string[] drinks = { "Espresso", "Latte", "Cappuccino", "Mocha", "Tea", "Hot Chocolate", "Iced Coffee", "Smoothie", "Juice", "Water" };
                    string[] snacks = { "Sandwich", "Salad" };

                    string[] barcode = {
                "1000","1001", "1002", "1003", "1004", "1005", "1006", "1007", "1008", "1009",
                "1010", "1011", "1012", "1013", "1014", "1015", "1016", "1017", "1018", "1019"
            };

                    string GetCategory(string name)
                    {
                        if (bakery.Contains(name)) return "Bakery";
                        if (drinks.Contains(name)) return "Drinks";
                        if (snacks.Contains(name)) return "Snacks";
                        return "Other";
                    }

                    Random rand = new Random();
                    for (int i = 0; i < products.Length; i++)
                    {
                        string name = products[i];
                        double price = Math.Round(1.5 + rand.NextDouble() * 3.5, 2);
                        double discount = rand.Next(0, 3) switch
                        {
                            0 => 0.10,
                            1 => 0.20,
                            _ => 0.0
                        };
                        string category = GetCategory(name);

                        if (!categoryIds.TryGetValue(category, out long categoryId))
                        {
                            continue;
                        }

                        string insert = "INSERT INTO Products (Name, Price, Discount, CategoryId, Barcode) VALUES (@Name, @Price, @Discount, @CategoryId, @Barcode);";
                        using (var cmdInsert = new SQLiteCommand(insert, conn))
                        {
                            cmdInsert.Parameters.AddWithValue("@Name", name);
                            cmdInsert.Parameters.AddWithValue("@Price", price);
                            cmdInsert.Parameters.AddWithValue("@Discount", discount);
                            cmdInsert.Parameters.AddWithValue("@CategoryId", categoryId);
                            cmdInsert.Parameters.AddWithValue("@Barcode", barcode[i]);

                            cmdInsert.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

    }
}
