using Npgsql;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Database
{
    public class Model
    {
        private NpgsqlConnection _conn;

        public Model(NpgsqlConnection conn)
        {
            _conn = conn;
        }

        public NpgsqlDataReader readDataMitra()
        {
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM \"Data_Mitra\";", _conn);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public void createDataMitra(string nama_mitra, string deskripsi_mitra)
        {
            NpgsqlCommand cmd = new NpgsqlCommand($"INSERT INTO \"Data_Mitra\" (nama_mitra,deskripsi_mitra) VALUES ('{nama_mitra}','{deskripsi_mitra}');", _conn);
            cmd.ExecuteNonQuery();
        }
        public void updateDataMitra(string[] data)
        {
            NpgsqlCommand cmd = new NpgsqlCommand($"SELECT id_mitra FROM \"Data_Mitra\" WHERE nama_mitra = '{data[0]}';", _conn);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            int id_mitra = 0;
            while (reader.Read())
            {
                id_mitra = (int)reader[0];
            }
            reader.Close();
            cmd = new NpgsqlCommand($"UPDATE \"Data_Mitra\" SET nama_mitra = '{data[1]}',deskripsi_mitra = '{data[2]}' WHERE id_mitra = {id_mitra};", _conn);
            cmd.ExecuteNonQuery();
        }
        public void deleteDataMitra(string nama_mitra)
        {
            NpgsqlCommand cmd = new NpgsqlCommand($"DELETE FROM \"Data_Mitra\" WHERE nama_mitra = '{nama_mitra}';", _conn);
            cmd.ExecuteNonQuery();
        }
    }
}
