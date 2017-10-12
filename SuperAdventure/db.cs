/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SuperAdventure
{
    public class db
    {
        MySqlConnection kapcs;
        public db()
        {
            string szerver = "localhost";
            int port = 3307;
            string adatbazis = "superadventure";
            string dbnev = "root";
            string dbjelszo = "usbw";
            String connString = "Server=" + szerver + ";Database=" + adatbazis + ";port=" + port + ";User Id=" + dbnev + ";password=" + dbjelszo;
            kapcs = new MySqlConnection(connString);
        }
        public MySqlDataReader lekerdezes()
        {
            kapcs.Open();
            string sql = "SELECT nev,leiras FROM location";
            MySqlCommand parancs = new MySqlCommand(sql, kapcs);
            MySqlDataReader adatok = parancs.ExecuteReader();
            return adatok;

        }
    }
}
*/