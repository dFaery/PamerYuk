using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PamerYukLibrary.Entity
{
    public class Chat
    {
        private int id;
        private string tipePesan;
        private string pesan;
        private string pengirim;
        private string penerima;
        private DateTime tglTerkirim;

        public Chat(int id, string pesan, string pengirim, string penerima, DateTime tglTerkirim,string tipePesan)
        {
            this.Id = id;
            this.Pesan = pesan;
            this.Pengirim = pengirim;
            this.Penerima = penerima;
            this.TglTerkirim = tglTerkirim;
            this.TipePesan = tipePesan;
        }

        public Chat(string pesan, string pengirim, string penerima,string tipePesan) //for new chat
        {
            this.Pesan = pesan;
            this.Pengirim = pengirim;
            this.Penerima = penerima;
            this.TipePesan = tipePesan;
        }

        public int Id { get => id; set => id = value; }
        public string Pesan { get => pesan; set => pesan = value; }
        public string Pengirim { get => pengirim; set => pengirim = value; }
        public string Penerima { get => penerima; set => penerima = value; }
        public DateTime TglTerkirim { get => tglTerkirim; set => tglTerkirim = value; }
        public string TipePesan { get => tipePesan; set => tipePesan = value; }

        public override string ToString()
        {
            return "[" + this.TglTerkirim.ToString() + "] " + this.Pengirim + " : " + this.Pesan + "\n";
        }
    }
}
