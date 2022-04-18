using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class TaiLieu
    {
        protected string maTaiLieu;
        protected string nXB;
        protected int soBanPhatHanh;

        public TaiLieu(string maTaiLieu, string nXB, int soBanPhatHanh)
        {
            MaTaiLieu = maTaiLieu;
            NXB = nXB;
            SoBanPhatHanh = soBanPhatHanh;
        }

        public string MaTaiLieu { get => maTaiLieu; set => maTaiLieu = value; }
        public string NXB { get => nXB; set => nXB = value; }
        public int SoBanPhatHanh { get => soBanPhatHanh; set => soBanPhatHanh = value; }
    }
}
