using MySql.Data.MySqlClient;
using PamerYukLibrary.DAO;
using PamerYukLibrary.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamerYukLibrary.Entity
{
    public class DAO_Members
    {
        public static List<User> Select_ListMember(string group_id)
        {
            string perintah = "SELECT * FROM member where group_id ='" + group_id + "';";
            MySqlDataReader dr = KoneksiDatabase.DatabaseQueryCommand(perintah);
            List<User> listUser = new List<User>();
            while (dr.Read())
            {
                string username = dr.GetValue(1).ToString();
                User newUser = DAO_Users.Select_User(username);
                listUser.Add(newUser);
            }
            return listUser;
        }

        public static void Insert_ListMember(int group_id, List<User> members)
        {
            foreach(User user in members)
            {
                string command = "INSERT INTO `pameryuk`.`member` (`Group_id`, `User_username`) VALUES ('"+group_id+"', '"+user.Username+"');";
                KoneksiDatabase.DatabaseDMLCommand(command);
            }
        }
    }
}
