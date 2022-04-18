using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaiLieu> thuvien = new List<TaiLieu>();
            QuanLySach QLS = new QuanLySach(thuvien);
            int choose = 0;
            do
            {
                Console.WriteLine("QUAN LY THU VIEN");
                Console.WriteLine("1. Them moi tai lieu.");
                Console.WriteLine("2. Xoa tai lieu.");
                Console.WriteLine("3. Hien thi danh sach tai lieu.");
                Console.WriteLine("4. Tim kiem theo danh muc.");
                Console.WriteLine("5. Thoat.");
                Console.Write("Lua chon cua ban: ");
                choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        Console.Write("Nhap so tai lieu: ");
                        int n = int.Parse(Console.ReadLine());
                        for (int i = 1; i <= n; i++)
                        {
                            Console.WriteLine("\nTai lieu thu " + i);
                            Console.WriteLine("1. Sach.");
                            Console.WriteLine("2. Tap chi.");
                            Console.WriteLine("3. Bao.");
                            Console.Write("Lua chon cua ban: ");
                            int kt = int.Parse(Console.ReadLine());

                            Console.Write("Ma tai lieu: ");
                            string mtl = Console.ReadLine();
                            Console.Write("Nha xuat ban: ");
                            string nxb = Console.ReadLine();
                            Console.Write("So ban phat hanh: ");
                            int sbph = int.Parse(Console.ReadLine());

                            if (kt == 1)
                            {
                                Console.Write("Tac gia: ");
                                string tg = Console.ReadLine();
                                Console.Write("So trang: ");
                                int st = int.Parse(Console.ReadLine());

                                TaiLieu tl = new Sach(mtl, nxb, sbph, tg, st);
                                QLS.themTaiLieu(tl);
                            } else if(kt == 2)
                            {
                                Console.Write("So phat hanh: ");
                                int sph = int.Parse(Console.ReadLine());
                                Console.Write("Thang phat hanh: ");
                                string tph = Console.ReadLine();

                                TaiLieu tl = new TapChi(mtl, nxb, sbph, sph, tph);
                                QLS.themTaiLieu(tl);
                            } else if(kt==3)
                            {
                                Console.Write("Ngay phat hanh: ");
                                string nph = Console.ReadLine();

                                TaiLieu tl = new Bao(mtl, nxb, sbph, nph);
                                QLS.themTaiLieu(tl);
                            }
                            else
                            {
                                Console.WriteLine("Lựa chọn không hợp lệ!");
                            }
                        }
                        Console.WriteLine("\n\n");
                        break;
                    case 2:
                        Console.Write("Nhap ma tai lieu can xoa: ");
                        string ma = Console.ReadLine();
                        QLS.xoaTaiLieu(ma);
                        Console.WriteLine("\n\n");
                        break;
                    case 3:
                        QLS.hienThiTaiLieu();
                        Console.WriteLine("\n\n");
                        break;
                    case 4:
                        Console.WriteLine("\nChon phan loai");
                        Console.WriteLine("1. Sach.");
                        Console.WriteLine("2. Tap chi.");
                        Console.WriteLine("3. Bao.");
                        Console.Write("Lua chon cua ban: ");
                        int pl = int.Parse(Console.ReadLine());

                        if (pl == 1)
                            QLS.timKiemTaiLieu("Sach");
                        else if (pl == 2)
                            QLS.timKiemTaiLieu("TapChi");
                        else if (pl == 3)
                            QLS.timKiemTaiLieu("Bao");
                        else
                            Console.WriteLine("Lựa chọn không hợp lệ!");

                        Console.WriteLine("\n\n");
                        break;
                }
            } while (choose < 5 && choose > 0);
        }
    }
}
