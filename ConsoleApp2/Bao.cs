using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Bao : TaiLieu
    {
        string ngayPhatHanh;

        public Bao(string maTaiLieu, string nXB, int soBanPhatHanh, string ngayPhatHanh)
            : base(maTaiLieu, nXB, soBanPhatHanh)
        {
            MaTaiLieu = maTaiLieu;
            NXB = nXB;
            SoBanPhatHanh = soBanPhatHanh;

            NgayPhatHanh = ngayPhatHanh;
        }

        public string NgayPhatHanh { get => ngayPhatHanh; set => ngayPhatHanh = value; }

        public override string ToString()
        {
            return "Bao\nMa tai lieu: " + MaTaiLieu + "\nNha xuat ban: " + NXB + "\nSo ban phat hanh: " + SoBanPhatHanh + "\nNgay phat hanh: " + NgayPhatHanh ;
        }
    }
}
