using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class NhaQuanLy : Nhanvien
    {
        protected string chucVu;
        protected int soNgayCong;
        protected float bacLuong;

        public NhaQuanLy(string hoTen, int namSinh, string bangCap, string chucVu, int soNgayCong, float bacLuong) : base(hoTen, namSinh, bangCap)
        {
            this.chucVu = chucVu;
            this.soNgayCong = soNgayCong;
            this.bacLuong = bacLuong;
        }

        public NhaQuanLy() : base()
        {
            this.chucVu = "boss";
            this.soNgayCong = 10;
            this.bacLuong = 1000;
        }

        public void Input()
        {
            base.Input();
            Console.Write("Chuc vu: ");
            chucVu = Console.ReadLine();
            Console.Write("So ngay cong: ");
            soNgayCong = int.Parse(Console.ReadLine());
            Console.Write("Bac luong: ");
            bacLuong = float.Parse(Console.ReadLine());
        }

        public void Output()
        {
            base.Output();
            Console.Write(String.Format("{0, -20}|{1, -5}|{2, -10}|{3, -10}", chucVu, soNgayCong, bacLuong, tinhLuong()));
        }

        public override double tinhLuong()
        {
            return soNgayCong * bacLuong;
        }
    }
}
