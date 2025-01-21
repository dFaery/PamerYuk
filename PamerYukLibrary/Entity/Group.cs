using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamerYukLibrary.Entity
{
    public class Group
    {
        private int id;
        private string nama;
        private List<User> members = new List<User>();
        private string fotoProfil;
        private DateTime tglDibuat;
        private string deskripsi;

        public Group(int id, string nama,string fotoProfil, DateTime tglDibuat, string deskripsi)
        {
            this.Id = id;
            this.Nama = nama;
            //this.Members = DAO_Members.Select_ListMembers(id);
            this.FotoProfil = fotoProfil;
            this.TglDibuat = tglDibuat;
            this.Deskripsi = deskripsi;
        }

        public Group(string nama,  List<User> members, string fotoProfil, string deskripsi) //New Group
        {
            this.Nama = nama;
            this.Members = members;
            this.FotoProfil = fotoProfil;
            this.TglDibuat = DateTime.Now;
            this.Deskripsi = deskripsi;
        }



        public Group() //New Group
        {
            this.Nama = "";
            this.Members = new List<User>();
            this.FotoProfil = "";
            this.TglDibuat = DateTime.Now;
            this.Deskripsi = "null";
        }


        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public List<User> Members { get => members; set => members = value; }
        public string FotoProfil { get => fotoProfil; set => fotoProfil = value; }
        public DateTime TglDibuat { get => tglDibuat; set => tglDibuat = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }
    }
}
