using PamerYukLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PamerYukLibrary;
using PamerYukLibrary.DAO;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using PamerYukLibrary.Entity;
using PamerYukLibrary.Database;

namespace PamerYukFormsApp
{
    public class Service //On Load
    {
        #region VARIABLES
        private User current_user;
        private List<Kota> listKota;
        private List<Organisasi> listOrganisasi;
        private List<Teman> listTeman;
        private string MediafilePath = @"C:\PamerYuk\";
        private string MediafilePathDB = @"C:\\PamerYuk\\";
        #endregion

        #region CONSTRUCTOR
        public Service()
        {
            this.ListOrganisasi = DAO_Organisasi.Select_Organisasi();
            this.ListKota = DAO_Kota.Select_ListKota();
            CreateDirectory();
        }
        #endregion

        #region PROPERTIES

        public User Current_user { get => current_user; set => current_user = value; }
        public List<Kota> ListKota { get => listKota; set => listKota = value; }
        public List<Organisasi> ListOrganisasi { get => listOrganisasi; set => listOrganisasi = value; }
        public List<Teman> ListTeman { get => listTeman; set => listTeman = value; }
        #endregion

        #region ONLOAD
        public void OnLoad()
        {
            this.ListTeman = DAO_Teman.Select_ListTeman(this.Current_user.Username);       
        }
        #endregion

        #region METHOD (USER) 
        //For User
        public void LogIn(string username, string password)
        {
            this.Current_user = DAO_Users.User_Log_In(username, password);
        }

        public void Daftar(string username, string password, string namaLengkap, DateTime tglLahir, string noKTP, string fotoDiri, string fotoProfil, string email, Kota kota)
        {
            string newFotoDiriPath = New_ProfileDiriPictureFileName(username);
            string newFotoProfilPath = New_ProfilePictureFileName(username);
            File.Copy(fotoDiri, Path.Combine(this.MediafilePath, newFotoDiriPath));
            File.Copy(fotoProfil, Path.Combine(this.MediafilePath, newFotoProfilPath));
            User new_user = new User(username, password, namaLengkap, tglLahir, noKTP, Path.Combine(this.MediafilePath, newFotoDiriPath), Path.Combine(this.MediafilePath, newFotoProfilPath), email, kota);
            DAO_Users.User_Daftar(username, password, namaLengkap, tglLahir, noKTP, Path.Combine(this.MediafilePathDB, newFotoDiriPath), Path.Combine(this.MediafilePathDB, newFotoProfilPath), email, kota);
            this.Current_user = new_user;
        }
        public void UpdateUser(string new_usn, string new_nama, DateTime new_date, string new_ktp, string new_fd, string new_fp, string new_email, Kota new_kota)
        {
            string newFotoDiriPath = New_ProfileDiriPictureFileName(new_usn);
            string newFotoProfilPath = New_ProfilePictureFileName(new_usn);
            File.Copy(new_fd, Path.Combine(this.MediafilePath, newFotoDiriPath));
            File.Copy(new_fp, Path.Combine(this.MediafilePath, newFotoProfilPath));
            DAO_Users.Update_User(this.Current_user.Username, new_usn, new_nama, new_date, new_ktp, Path.Combine(this.MediafilePathDB, newFotoDiriPath), Path.Combine(this.MediafilePathDB, newFotoProfilPath), new_email, new_kota);
            this.Current_user.Username = new_usn;
            this.Current_user.NamaLengkap = new_nama;
            this.Current_user.TglLahir = new_date;
            this.Current_user.NoKTP = new_ktp;
            this.Current_user.FotoDiri = Path.Combine(this.MediafilePath, newFotoDiriPath);
            this.Current_user.FotoProfil = Path.Combine(this.MediafilePath, newFotoProfilPath);
            this.Current_user.Email = new_email;
            this.Current_user.Kota = new_kota;

        }
        #endregion

        #region METHOD (KISAH HIDUP)
        //For Kisah Hidup
        public void Tambah_KisahHidup(Organisasi organisasi, int thawal, int thakhir, string deskripsi)
        {
            KisahHidup newKisahHidup = new KisahHidup(organisasi, thawal, thakhir, deskripsi);
            DAO_KisahHidup.Insert_KisahHidup(newKisahHidup, this.Current_user);
            this.current_user.ListKisahHidup = DAO_KisahHidup.Select_ListKisahHidup(this.Current_user.Username);
        }

        #endregion

        #region METHOD (ORGANISASI)
        public void Tambah_Organisasi(Organisasi newOrganisasi)
        {
            DAO_Organisasi.Insert_Organisasi(newOrganisasi);
            this.ListOrganisasi = DAO_Organisasi.Select_Organisasi(); //Re-New the list
        }

        public List<Organisasi> Lihat_Organisasi_User()
        {
            List<Organisasi> result = new List<Organisasi>();
            foreach (KisahHidup kh in this.Current_user.ListKisahHidup)
            {
                result.Add(kh.Organisasi);
            }
            return result;
        }
        #endregion

        #region METHOD (TEMAN)
        public List<User> Cari_Teman(Organisasi organisasi)
        {
            return DAO_Users.Select_ListUser_ByOrganisasi(organisasi, this.Current_user);
        }

        public List<User> Cari_Teman(string username)
        {
            return DAO_Users.Select_ListUser_ByUSN(username);
        }

        public User Cari_AkunTeman(string username)
        {
            return DAO_Users.Select_User(username);
        }

        public void Request_Pertemanan(string username)
        {
            DAO_Teman.Insert_RequestPertemanan(this.Current_user.Username, username);
        }

        public void Terima_Pertemanan(string username)
        {
            DAO_Teman.Update_RequestPertemanan(username, this.Current_user.Username, "Berteman");
            this.ListTeman = DAO_Teman.Select_ListTeman(this.Current_user.Username);
        }

        public void Tolak_Pertemanan(string username)
        {
            DAO_Teman.Update_RequestPertemanan(username, this.Current_user.Username, "Ditolak");
        }
        public void KirimUlang_Pertemanan(string username)
        {
            DAO_Teman.Update_RequestPertemanan(this.Current_user.Username, username, "Menunggu");
        }

        public List<Teman> Request_Pertemanan(bool jenis)
        {
            //true = sender, false = receiver
            return DAO_Teman.Select_RequestPertemanan(this.Current_user.Username, jenis);
        }
        #endregion

        #region METHOD (KONTEN)
        public Konten Tambah_Komen(Komen komen, Konten newKonten)
        {
            DAO_Komen.Insert_Komen(komen,newKonten.Id);
            newKonten.Comment = DAO_Komen.Select_Komen(newKonten.Id);
            return newKonten;
        }
        

        public Konten Lihat_Konten(int id)
        {
            return DAO_Konten.Select_Konten(id);
        }

        public void Tambah_Konten(Konten newKonten)
        {
            string newPath = "";
            if (Path.GetExtension(newKonten.Foto) == ".jpg")
            {
                newPath = New_FileName(true);
                File.Copy(newKonten.Foto, Path.Combine(this.MediafilePath, newPath));
                newKonten.Foto = Path.Combine(this.MediafilePathDB,newPath);
            }
            else
            {
                newPath = New_FileName(false);
                File.Copy(newKonten.Video, Path.Combine(this.MediafilePath, newPath));
                newKonten.Video = Path.Combine(this.MediafilePathDB, newPath);
            }
            newKonten.TglUpload = DateTime.Now;
            DAO_Konten.Insert_Konten(newKonten, this.Current_user.Username);
            this.Current_user.ListKonten = DAO_Konten.Select_ListKonten(this.current_user.Username);
            int konten_id = this.Current_user.ListKonten[(this.Current_user.ListKonten.Count - 1)].Id;
            foreach(User us in newKonten.Tag)
            {
                DAO_Tag.Insert_Tag(konten_id, us.Username);
            }
            this.Current_user.ListKonten = DAO_Konten.Select_ListKonten(this.current_user.Username);
        }

        public User Tambah_Tag(string username)
        {
            return DAO_Users.Select_Tag_ByUSN(username);
        }

        public bool Check_Like(int konten_id)
        {
            return DAO_Like.CheckLike(konten_id,this.Current_user.Username);
        }

        public Konten Tambah_Like(int konten_id)
        {
            DAO_Like.Insert_Like(konten_id , this.Current_user.Username);
            return DAO_Konten.Select_Konten(konten_id);
        }

        public Konten Delete_Like(int konten_id)
        {
            DAO_Like.DELETE_Like(konten_id, this.Current_user.Username);
            return DAO_Konten.Select_Konten(konten_id);
        }
        #endregion

        #region METHOD
        //File Handling
        private string New_FileName(bool type)
        {

            string path = this.current_user.Username + "x" + DateTime.Now.ToString("yyyyMMddHHmmss") + "x" + DAO_Konten.Get_NewKonten_Id();
            if (type)
            {
                path += ".jpg";
            }
            else
            {
                path += ".mp4";
            }
            return path;
        }

        private string New_ProfilePictureFileName(string username)
        {
            return username + "xPFPx" + DateTime.Now.ToString("yyyyMMddHHmmss")+".jpg";
        }
        private string New_ProfileDiriPictureFileName(string username)
        {
            return username + "xPFDx" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";
        }

        private void CreateDirectory()
        {
            if (!Directory.Exists(MediafilePath))
            {
                Directory.CreateDirectory(MediafilePath);
            }
        }

        #endregion

        #region CHAT

        public List<Chat> Buka_Chat(string username)
        {
            return DAO_Chat.Select_Chat(username, this.Current_user.Username);
        }

        public void Kirim_Chat(Chat chat)
        {
            DAO_Chat.Insert_Chat(chat);
        }

        public List<int> Cari_Chat(List<Chat> chat, string username, string pesan)
        {
            List<int> idChat =  DAO_Chat.Select_Chat_ByPesan(username, this.Current_user.Username,pesan);
            List<int> indexList=new List<int>();
            int index = 0;
            for(int i=0;i<chat.Count;i++)
            {
                if(idChat.Count == 0)
                {
                    return idChat;
                }
                if (chat[i].Id == idChat[index])
                {
                    indexList.Add(i);
                    if(index < (idChat.Count-1))
                    {
                        index++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return indexList;
        }

        public List<int> Cari_Chat_ByTanggal(List<Chat>chat, DateTime Date)
        {
            List<int> idCari = new List<int>();

            if (Date > DateTime.Now)
            {
                idCari.Add((chat.Count-1));
                return idCari;
            }
            for(int i=0;i<chat.Count;i++)
            {
                if (chat[i].TglTerkirim.Date == Date.Date)
                {
                    idCari.Add(i);
                }
            }
            return idCari;
        }
        #endregion

        #region FITUR BARU

        //Group

        public List<Group> Buka_Group(string username)
        {
            return DAO_Group.Select_ListGroup(username);
        }

        public void Buat_Group(Group group)
        {
            DAO_Group.Insert_New_Group(group);
        }

        //Members

        public List<User> Akses_Member_Group(string group_id)
        {
            return DAO_Members.Select_ListMember(group_id);
        }

        public void Tambah_Member_Group(string group_id, List<User> members)
        {
            DAO_Members.Insert_ListMember(group_id, members);
        }
        #endregion
    }
}
