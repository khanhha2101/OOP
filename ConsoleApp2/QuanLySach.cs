using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class QuanLySach
    {
        List<TaiLieu> thuvien;

        public QuanLySach(List<TaiLieu> thuvien)
        {
            Thuvien = thuvien;
        }

        public List<TaiLieu> Thuvien { get => thuvien; set => thuvien = value; }

        public void themTaiLieu(TaiLieu taiLieu)
        {
            thuvien.Add(taiLieu);
            Console.WriteLine("Them thanh cong!");
        }
        public void xoaTaiLieu(string maTL)
        {
            int kt = 0;
            for(int i =0; i<thuvien.Count(); i++)
                if (thuvien[i].MaTaiLieu == maTL)
                {
                    thuvien.RemoveAt(i);
                    Console.WriteLine("Xoa thanh cong!");
                    kt = 1;
                }
            if (kt == 0)
                Console.WriteLine("Khong co tai lieu tuong ung.");
        }
        public void hienThiTaiLieu()
        {
            Console.WriteLine("\n==============");
            foreach (TaiLieu tl in thuvien)
            {
                Console.WriteLine(tl.ToString());
            }
        }
        public void timKiemTaiLieu(string phanloai)
        {
            int i = 1;
            Console.WriteLine("\n==============");
            foreach (TaiLieu tl in thuvien)
            {
                string st = tl.GetType().ToString();
                if (st.Contains(phanloai))
                {
                    Console.Write(i + ": ");
                    Console.WriteLine(tl.ToString() + "\n");
                    i++;
                }
            }
        }
    }
}
