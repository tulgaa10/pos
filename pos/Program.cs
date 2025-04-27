using System;
using System.Windows.Forms;
using System.Data.SQLite;
using pos;

namespace pos
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            string dbPath = Path.Combine(Application.StartupPath, "pos.db");
            MessageBox.Show("Database path: " + dbPath);

            DatabaseInitializer.InitializeDatabase(dbPath);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new LoginForm());
        }
    }
}
