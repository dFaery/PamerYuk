﻿using MySql.Data.MySqlClient;
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
            string command = "select * from tag inner join user on tag.username = user.username inner join kota on user.kota_id = kota.id where konten_id = '" + konten_id+"';";

            MySqlDataReader dr = KoneksiDatabase.DatabaseQueryCommand(command);
            List<User> listAkun = new List<User>();
            User user;
            while (dr.Read())
            {
                //User
                string usname = dr.GetValue(2).ToString();
                DateTime tgllahir = DateTime.Parse(dr.GetValue(4).ToString());
                string noKTP = dr.GetValue(5).ToString();
                string foto = dr.GetValue(6).ToString(); //Still confuse with this image data format
                int kota_id_fk = int.Parse(dr.GetValue(7).ToString());

                //Kota
                int kota_id = int.Parse(dr.GetValue(8).ToString());
                string nama = dr.GetValue(9).ToString();

                //Create Kota
                Kota newKota = new Kota(kota_id, nama);

                //Create User
                user = new User(usname, tgllahir, noKTP, foto, newKota);
                listAkun.Add(user);
            }
            return listAkun;
        }

        public static void Insert_Tag(int konten_id, string username)
        {
            string command = "INSERT INTO `pameryuk`.`tag` (`Konten_id`, `username`) VALUES ('" + konten_id + "', '" + username + "');";
            KoneksiDatabase.DatabaseDMLCommand(command);
        }
    }
}