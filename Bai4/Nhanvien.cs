using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public abstract class Nhanvien
    {
        protected string hoTen;
        protected int namSinh;
        protected string bangCap;


        //construcotor
        public Nhanvien(string hoTen, int namSinh, string bangCap)
        {
            this.HoTen = hoTen;
            this.NamSinh = namSinh;
            this.BangCap = bangCap;
        }

        public Nhanvien()
        {
            this.HoTen = "a";
            this.NamSinh = 2000;
            this.BangCap = "dai hoc";
        }

        public Nhanvien(Nhanvien n)
        {
            this.HoTen = n.HoTen;
            this.NamSinh = n.NamSinh;
            this.BangCap = n.BangCap;
        }

        // getter & setter
        public string HoTen { get => hoTen; set => hoTen = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public string BangCap { get => bangCap; set => bangCap = value; }

        //method
        public void Input()
        {
            Console.Write("Ho & Ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nam sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Bang cap: ");
            BangCap = Console.ReadLine();
        }

        public void Output()
        {
            Console.Write(String.Format("{0, -20}|{1, -8}|{2, -20}|", HoTen, NamSinh, BangCap));
        }

        public abstract double tinhLuong();
    }
}
