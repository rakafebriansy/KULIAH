using Npgsql;

namespace WinFormsApp4
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
            NpgsqlConnection conn = new NpgsqlConnection(connStr); //create connection
            conn.Open();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(conn));
            conn.Close();
        }
    }
}