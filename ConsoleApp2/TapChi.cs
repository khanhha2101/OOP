using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class TapChi : TaiLieu
    {
        int soPhatHanh;
        string thangPhatHanh;

        public TapChi(string maTaiLieu, string nXB, int soBanPhatHanh, int soPhatHanh, string thangPhatHanh)
            : base(maTaiLieu, nXB, soBanPhatHanh)
        {
            MaTaiLieu = maTaiLieu;
            NXB = nXB;
            SoBanPhatHanh = soBanPhatHanh;

            SoPhatHanh = soPhatHanh;
            ThangPhatHanh = thangPhatHanh;
        }

        public int SoPhatHanh { get => soPhatHanh; set => soPhatHanh = value; }
        public string ThangPhatHanh { get => thangPhatHanh; set => thangPhatHanh = value; }

        public override string ToString()
        {
            return "Tap chi\nMa tai lieu: " + MaTaiLieu + "\nNha xuat ban: " + NXB + "\nSo ban phat hanh: " + SoBanPhatHanh + "\nSo phat hanh: " + SoPhatHanh + "\nThang phat hanh: " + ThangPhatHanh;
        }
    }
}
