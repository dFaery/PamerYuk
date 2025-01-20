using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using PamerYukLibrary.Database;
using PamerYukLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamerYukLibrary.DAO
{
    public class DAO_Chat
    {
        public static List<Chat> Select_Chat(string friend, string user)
        {
            //usn2 is current user
            string perintah = "SELECT * FROM chat  WHERE pengirim = '" + friend + "' and penerima ='" + user + "' UNION SELECT * FROM chat  WHERE pengirim = '" + user + "' and penerima ='" + friend + "' order by id asc;";
            MySqlDataReader dr = KoneksiDatabase.DatabaseQueryCommand(perintah);
            List<Chat> listChat = new List<Chat>();
            while (dr.Read())
            {
                int id = int.Parse(dr.GetValue(0).ToString());
                string pesan = dr.GetValue(1).ToString();
                DateTime tglTerkirim = DateTime.Parse(dr.GetValue(2).ToString());
                string tipePesan = dr.GetValue(3).ToString();
                string pengirim = dr.GetValue(4).ToString();
                string penerima = dr.GetValue(5).ToString();
                Chat newChat = new Chat(id,pesan,pengirim,penerima,tglTerkirim,tipePesan);
                listChat.Add(newChat);
            }
            return listChat;
        }

        public static List<int> Select_Chat_ByPesan(string friend, string user,string pesan)
        {
            //usn2 is current user
            string perintah = "SELECT id FROM chat  WHERE pengirim = '" + friend + "' and penerima ='" + user + "' and pesan like '%"+pesan+"%' UNION SELECT id FROM chat  WHERE pengirim = '" + user + "' and penerima ='" + friend + "' and pesan like '%"+pesan+"%' order by id asc;";
            MySqlDataReader dr = KoneksiDatabase.DatabaseQueryCommand(perintah);
            List<int> listChatId = new List<int>();
            while (dr.Read())
            {
                int id = int.Parse(dr.GetValue(0).ToString());
                listChatId.Add(id);
            }
            return listChatId;
        }
        public static void Insert_Chat(Chat chat)
        {
            string command = "INSERT INTO `pameryuk`.`chat` (`id`, `pesan`,`tglTerkirim`, `pengirim`,`penerima`,`tipePesan`) VALUES ('" + Get_NewChat_Id() + "', '" + chat.Pesan + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + chat.Pengirim + "','" + chat.Penerima +"','" + chat.TipePesan + "');";
            KoneksiDatabase.DatabaseDMLCommand(command);
        }

        private static int Get_NewChat_Id()
        {
            int result=0;//for sementara
            string perintah = "SELECT id FROM chat ORDER BY id DESC LIMIT 1;";
            MySqlDataReader dr = KoneksiDatabase.DatabaseQueryCommand(perintah);
            if (dr.Read())
            {
                result = int.Parse(dr.GetValue(0).ToString());
            }
            return (result+1);
        }
    }
}
