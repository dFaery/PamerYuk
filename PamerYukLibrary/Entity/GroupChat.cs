using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PamerYukLibrary.Entity
{
    public class GroupChat
    {
        private int id;
        private string tipePesan;
        private string pesan;
        private string pengirim;
        private Group grup;
        private DateTime tglTerkirim;

        public GroupChat(int id, string pesan, string pengirim, Group grup, DateTime tglTerkirim, string tipePesan)
        {
            this.Id = id;
            this.Pesan = pesan;
            this.Pengirim = pengirim;
            this.Grup = grup;
            this.TglTerkirim = tglTerkirim;
            this.TipePesan = tipePesan;
        }

        public GroupChat(string pesan, string pengirim, Group grup, string tipePesan) //for new chat
        {
            this.Pesan = pesan;
            this.Pengirim = pengirim;
            this.Grup = grup;
            this.TipePesan = tipePesan;
        }

        public int Id { get => id; set => id = value; }
        public string Pesan { get => pesan; set => pesan = value; }
        public string Pengirim { get => pengirim; set => pengirim = value; }
        public Group Grup { get => grup; set => grup = value; }
        public DateTime TglTerkirim { get => tglTerkirim; set => tglTerkirim = value; }
        public string TipePesan { get => tipePesan; set => tipePesan = value; }

        public override string ToString()
        {
            return "[" + this.TglTerkirim.ToString() + "] " + this.Pengirim + " : " + this.Pesan + "\n";
        }
    }
}
