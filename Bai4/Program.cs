using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {

        private static int menu()
        {
            int n;
            Console.WriteLine("");
            Console.WriteLine("___________MENU___________");
            Console.WriteLine("1. Them thong tin nhan vien");
            Console.WriteLine("2. Xuat danh sach thong tin");
            Console.WriteLine("3. Tinh tong luong can chi tra theo tung doi tuong");
            Console.WriteLine("0. Thoat!!!");
            Console.Write(">> ");
            n = int.Parse(Console.ReadLine());
            return n;
        }

        static void Main(string[] args)
        {
            DanhSach ds = new DanhSach();
            byte loai;
            while(true)
            {
                switch(menu())
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("1: Nha Khoa Hoc | 2: Nha Quan Ly | 3: Nhan vien PTN");
                            Console.Write(">> ");
                            loai = byte.Parse(Console.ReadLine());
                            if (loai > 3 || loai < 1) {
                                Console.WriteLine("Vui long lua chon lai!");
                            }
                        } while (loai > 3 || loai < 1);
                        ds.Input(loai);
                        break;
                    case 2:
                        do
                        {
                            Console.WriteLine("1: Nha Khoa Hoc | 2: Nha Quan Ly | 3: Nhan vien PTN");
                            Console.Write(">> ");
                            loai = byte.Parse(Console.ReadLine());
                            if (loai > 3 || loai < 1)
                            {
                                Console.WriteLine("Vui long lua chon lai!");
                            }
                        } while (loai > 3 || loai < 1);
                        ds.Output(loai);
                        break;
                    case 3:
                        do
                        {
                            Console.WriteLine("1: Nha Khoa Hoc | 2: Nha Quan Ly | 3: Nhan vien PTN");
                            Console.Write(">> ");
                            loai = byte.Parse(Console.ReadLine());
                            if (loai > 3 || loai < 1)
                            {
                                Console.WriteLine("Vui long lua chon lai!");
                            }
                        } while (loai > 3 || loai < 1);
                        if (loai == 1)
                        {
                            Console.Write("Tong luong can chi tra cho cac Nha Khoa Hoc: ");
                            Console.WriteLine(ds.chiTra(1));
                        } else if (loai == 2)
                        {
                            Console.Write("Tong luong can chi tra cho cac Nha Quan Ly: ");
                            Console.WriteLine(ds.chiTra(2));
                        } else
                        {
                            Console.Write("Tong luong can chi tra cho cac Nhan Vien PTN: ");
                            Console.WriteLine(ds.chiTra(3));
                        }

                        break;
                    default:
                        Console.WriteLine("THOAT...");
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
