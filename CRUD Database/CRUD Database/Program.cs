using CRUD_Database;
using Npgsql;
using System.Drawing;

using System.Windows.Forms;

namespace CRUD_Database
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string connStr = "Host=localhost;Username=postgres;Password=123;Database=postgres";
            NpgsqlConnection conn = new NpgsqlConnection(connStr);
            conn.Open();
            Model model = new Model(conn);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(model));
            conn.Close();
        }
    }
}