using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        class CanBo
        {
            protected string hoten;
            protected int tuoi;
            protected string gtinh;
            protected string diachi;

            public CanBo(string hoten, int tuoi, string gtinh, string diachi)
            {
                Hoten = hoten;
                Tuoi = tuoi;
                Gtinh = gtinh;
                Diachi = diachi;
            }

            // Ctr + .


            // Ctr + R + E
            public string Hoten { get => hoten; set => hoten = value; }
            public int Tuoi { get => tuoi; set => tuoi = value; }
            public string Gtinh { get => gtinh; set => gtinh = value; }
            public string Diachi { get => diachi; set => diachi = value; }
        }

        class CongNhan : CanBo
        {
            protected int bac;

            public CongNhan(string hoten, int tuoi, string gtinh, string diachi, int bac)
                : base (hoten, tuoi, gtinh, diachi)
            {
                Hoten = hoten;
                Tuoi = tuoi;

                Gtinh = gtinh;
                Diachi = diachi;

                Bac = bac;
            }

            public int Bac { get => bac; set => bac = value; }

            public override string ToString()
            {
                return "Cong nhan\nHo ten: " + hoten + "\nTuoi: " + tuoi + "\nGioi tinh: " + gtinh + "\nDia chi: " + diachi + "\nBac: " + bac;
            }
        }
        class KySu : CanBo
        {
            protected string nganh;

            public KySu(string hoten, int tuoi, string gtinh, string diachi, string nganh)
                : base(hoten, tuoi, gtinh, diachi)
            {
                Hoten = hoten;
                Tuoi = tuoi;

                Gtinh = gtinh;
                Diachi = diachi;

                Nganh = nganh;
            }
            
            public string Nganh { get => nganh; set => nganh = value; }

            public override string ToString()
            {
                return "Ky su\nHo ten: " + hoten + "\nTuoi: " + tuoi + "\nGioi tinh: " + gtinh + "\nDia chi: " + diachi + "\nNganh: " + nganh; ;
            }
        }
        class NhanVien : CanBo
        {
            protected string congviec;

            public NhanVien(string hoten, int tuoi, string gtinh, string diachi,  string congviec)
                : base(hoten, tuoi, gtinh, diachi)
            {
                Hoten = hoten;
                Tuoi = tuoi;

                Gtinh = gtinh;
                Diachi = diachi;

                Congviec = congviec;
            }

            public string Congviec { get => congviec; set => congviec = value; }

            public override string ToString()
            {
                return "Nhan vien\nHo ten: " + hoten + "\nTuoi: " + tuoi + "\nGioi tinh: " + gtinh + "\nDia chi: " + diachi + "\nCong viec: " + congviec; ;
            }
        }

        class QLCB
        {
            public List<CanBo> danhsach;

            public QLCB(List<CanBo> danhsach)
            {
                Danhsach = danhsach;
            }

            public List<CanBo> Danhsach { get => danhsach; set => danhsach = value; }

            // thêm 1 cán bộ vào danh sách
            public void addCanBo(CanBo canbo)
            {
                danhsach.Add(canbo);
            }

            public void findCanBo(string hoten)
            {
                int kt = 0;
                foreach(CanBo cb in danhsach)
                {
                    if(cb.Hoten == hoten)
                    {
                        kt = 1;
                        Console.WriteLine();
                        Console.WriteLine(cb.ToString());
                    }
                        
                }
                if (kt == 0)
                    Console.WriteLine("Khong co can bo co ten " + hoten);
            }

            public void showDanhSach()
            {
                int i = 1;
                Console.WriteLine("\n*****DANH SACH CAN BO******");
                foreach (CanBo cb in danhsach)
                {
                    Console.Write(i + ". ");
                    Console.WriteLine(cb.ToString() + "\n");
                    i++;
                }
                Console.WriteLine("\n");
            }
        }

        static void Main(string[] args)
        {
            List<CanBo> danhsachs = new List<CanBo>();
            QLCB qlcb = new QLCB(danhsachs);

            int choose = 0;
            do
            {
                Console.WriteLine("QUAN LY CAN BO");
                Console.WriteLine("1. Them can bo.");
                Console.WriteLine("2. Tim kiem can bo.");
                Console.WriteLine("3. Hien thi danh sach can bo.");
                Console.WriteLine("4. Thoat.");
                Console.Write("Lua chon cua ban: ");
                choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        #region
                        Console.Write("Nhap so can bo: ");
                        int n = int.Parse(Console.ReadLine());
                        for(int i=1; i<=n; i++)
                        {
                            Console.WriteLine("\n=================");
                            Console.WriteLine("1. Cong nhan.");
                            Console.WriteLine("2. Ky su.");
                            Console.WriteLine("3. Nhan vien.");

                            Console.Write("Lua chon cua ban: ");
                            int kt = int.Parse(Console.ReadLine());
                            Console.Write("Ho ten: ");
                            string ht = Console.ReadLine();
                            Console.Write("Tuoi: ");
                            int tuoi = int.Parse(Console.ReadLine());
                            Console.WriteLine("Gioi tinh: [1]: Nam  [2]: Nu  [3]: Khac");
                            Console.Write("Lua chon cua ban: ");
                            int gt = int.Parse(Console.ReadLine());
                            Console.Write("Dia chi: ");
                            string dc = Console.ReadLine();

                            string gioitinh;
                            if (gt == 1)
                                gioitinh = "Nam";
                            else if (gt == 2)
                                gioitinh = "Nu";
                            else
                                gioitinh = "Khac";

                            if (kt == 1)
                            {
                                Console.Write("Bac: ");
                                int bac = int.Parse(Console.ReadLine());
                                CanBo cb = new CongNhan(ht, tuoi, gioitinh, dc, bac);
                                qlcb.addCanBo(cb);
                            }
                            else if (kt == 2)
                            {
                                Console.Write("Nganh dao tao: ");
                                string nganh = Console.ReadLine();
                                CanBo cb = new KySu(ht, tuoi, gioitinh, dc, nganh);
                                qlcb.addCanBo(cb);
                            }
                            else
                            {
                                Console.Write("Cong viec: ");
                                string cv = Console.ReadLine();
                                CanBo cb = new NhanVien(ht, tuoi, gioitinh, dc, cv);
                                qlcb.addCanBo(cb);
                            }
                        }

                        Console.WriteLine("\n");
                        #endregion

                        break;
                    case 2:
                        #region
                        Console.WriteLine("\n\n=================");
                        Console.Write("Nhan ten can bo: ");
                        string name = Console.ReadLine();
                        qlcb.findCanBo(name);

                        Console.WriteLine("\n");
                        #endregion
                        break;
                    case 3:
                        #region
                        qlcb.showDanhSach();

                        Console.WriteLine("\n");
                        #endregion
                        break;
                    case 4:
                        break;
                }
            } while (choose >= 1 && choose < 4);

        }
    }
}
