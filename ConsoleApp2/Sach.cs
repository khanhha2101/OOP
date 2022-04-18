using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Sach : TaiLieu
    {
        string tacGia;
        int soTrang;

        public Sach(string maTaiLieu, string nXB, int soBanPhatHanh, string tacGia, int soTrang)
            : base (maTaiLieu, nXB, soBanPhatHanh)
        {
            MaTaiLieu = maTaiLieu;
            NXB = nXB;
            SoBanPhatHanh = soBanPhatHanh;

            TacGia = tacGia;
            SoTrang = soTrang;
        }

        public string TacGia { get => tacGia; set => tacGia = value; }
        public int SoTrang { get => soTrang; set => soTrang = value; }

        public override string ToString()
        {
            return "Sach\nMa tai lieu: " + MaTaiLieu + "\nNha xuat ban: " + NXB + "\nSo ban phat hanh: " + SoBanPhatHanh + "\nTac gia: " + TacGia + "\nSo trang: " + SoTrang;
        }
    }
}
