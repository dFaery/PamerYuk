using MySql.Data.MySqlClient;
using PamerYukLibrary.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamerYukLibrary.DAO
{
    public class DAO_Tag
    {
        public static List<User> Select_Tag(int konten_id)
        {
            string command = "select * from tag where konten_id = '" + konten_id+"';";

            MySqlDataReader dr = KoneksiDatabase.DatabaseQueryCommand(command);
            List<User> listAkun = new List<User>();
            User user;
            while (dr.Read())
            {
                int kid = int.Parse(dr.GetValue(0).ToString());
                string username = dr.GetValue(1).ToString();
                user = DAO_Users.Select_User(username);
                listAkun.Add(user);
            }
            return listAkun;
        }
        public static List<Konten> Select_TaggedKonten(string username)
        {
            string command = "select * from tag where username = '" + username + "';";

            MySqlDataReader dr = KoneksiDatabase.DatabaseQueryCommand(command);
            List<Konten> listKonten = new List<Konten>();
            User user;
            while (dr.Read())
            {
                int kid = int.Parse(dr.GetValue(0).ToString());
                string usn = dr.GetValue(1).ToString();
                Konten newKonten = DAO_Konten.Select_Konten(kid);
                listKonten.Add(newKonten);
            }
            return listKonten;
        }

        public static void Insert_Tag(int konten_id, string username)
        {
            string command = "INSERT INTO `pameryuk`.`tag` (`Konten_id`, `username`) VALUES ('" + konten_id + "', '" + username + "');";
            KoneksiDatabase.DatabaseDMLCommand(command);
        }
    }
}
