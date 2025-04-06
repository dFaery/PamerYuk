﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using PamerYukLibrary.Database;
using PamerYukLibrary.Entity;

namespace PamerYukLibrary.DAO
{
    public class DAO_Group
    {
        public static List<Group> Select_ListGroup(string username)
        {
            string perintah = "select * from groups g inner join member m  on m.group_id = g.id where user_username ='" + username +"';";
            MySqlDataReader dr = KoneksiDatabase.DatabaseQueryCommand(perintah);
            List<Group> listGroup = new List<Group>();
            while (dr.Read())
            {
                int id = int.Parse(dr.GetValue(0).ToString());
                string nama = dr.GetValue(1).ToString();
                string fotoProfil = dr.GetValue(2).ToString();
                DateTime tglDibuat = DateTime.Parse(dr.GetValue(3).ToString());
                string deskripsi = dr.GetValue(4).ToString();
                Group newGroup = new Group(id, nama, fotoProfil, tglDibuat, deskripsi);
                listGroup.Add(newGroup);
            }
            return listGroup;
        }


        public static Group Select_Group(int groupId)
        {
            string perintah = "select * from groups where id ='" + groupId + "';";
            MySqlDataReader dr = KoneksiDatabase.DatabaseQueryCommand(perintah);
            Group grup;
            if (dr.Read())
            {
                int id = int.Parse(dr.GetValue(0).ToString());
                string nama = dr.GetValue(1).ToString();
                string fotoProfil = dr.GetValue(2).ToString();
                DateTime tglDibuat = DateTime.Parse(dr.GetValue(3).ToString());
                string deskripsi = dr.GetValue(4).ToString();
                grup = new Group(id, nama, fotoProfil, tglDibuat, deskripsi);
                return grup;
            }
            else return null;
        }

        public static void Insert_New_Group(Group newGroup)
        {
            string command = "INSERT INTO `pameryuk`.`groups` (`id`, `nama`, `fotoProfil`, `tglDibuat`, `deskripsi`) VALUES ('" + Get_NewGroup_Id() + "', '" + newGroup.Nama + "', '" + newGroup.FotoProfil + "', '" + newGroup.TglDibuat.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + newGroup.Deskripsi + "');";
            KoneksiDatabase.DatabaseDMLCommand(command);
        }

        public static int Get_NewGroup_Id()
        {
            int result = 0;//for sementara
            string perintah = "SELECT id FROM groups ORDER BY id DESC LIMIT 1;";
            MySqlDataReader dr = KoneksiDatabase.DatabaseQueryCommand(perintah);
            if (dr.Read())
            {
                result = int.Parse(dr.GetValue(0).ToString());
            }
            return (result + 1);
        }
    }
}
