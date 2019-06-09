using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class DanhSach
    {
        protected ArrayList ds;

        public DanhSach()
        {
            this.ds = new ArrayList();
        }

        public void Input(byte loai)
        {
            if (loai == 1)
            {
                NhaKhoaHoc nkh = new NhaKhoaHoc();
                nkh.Input();
                ds.Add(nkh);
            } else if ( loai == 2)
            {
                NhaQuanLy nql = new NhaQuanLy();
                nql.Input();
                ds.Add(nql);
            } else if ( loai == 3 )
            {
                NhanVienPTN nvptn = new NhanVienPTN();
                nvptn.Input();
                ds.Add(nvptn);
            }
        }

        public void Output(byte loai)
        {
            if (ds.Count == 0)
            {
                Console.WriteLine("Chua co thong tin. Vui long nhap lieu truoc khi xem!");
            } else
            {
                if (loai == 1)
                {
                    Console.Write(String.Format("{0, -20}|{1, -8}|{2, -20}|{3, -20}|{4, -3}|{5, -5}|{6, -10}|{7, -10}", "Ho & Ten", "NamS", "Bang Cap", "Chuc Vu", "So bb", "SoNC", "Bac Luong", "Tong Luong"));
                    Console.Write("\n");
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
                    foreach (Nhanvien nv in ds)
                    {
                        if (nv is NhaKhoaHoc)
                        {
                            ((NhaKhoaHoc) nv).Output();
                        }
                    }
                } else if (loai == 2)
                {
                    Console.Write(String.Format("{0, -20}|{1, -8}|{2, -20}|{3, -20}|{4, -5}|{5, -10}|{6, -10}", "Ho & Ten", "NamS", "Bang Cap", "Chuc Vu", "SoNC", "Bac Luong", "Tong Luong"));
                    Console.Write("\n");
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
                    foreach (Nhanvien nv in ds)
                    {
                        if (nv is NhaQuanLy)
                        {
                            ((NhaQuanLy) nv).Output();
                        }
                    }
                } else if (loai == 3)
                {
                    Console.Write(String.Format("{0, -20}|{1, -8}|{2, -20}|{3, 120}|", "Ho & Ten", "NamS", "Bang Cap", "LuongT"));
                    Console.Write("\n");
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------");
                    foreach (Nhanvien nv in ds)
                    {
                        if (nv is NhanVienPTN)
                        {
                            ((NhanVienPTN) nv).Output();
                        }
                    }
                }
            }
        }

        public double chiTra(byte loai)
        {
            double temp = 0;
            if (loai == 1)
            {
                foreach (Nhanvien nv in ds)
                {
                    if (nv is NhaKhoaHoc)
                    {
                        temp = temp + ((NhaKhoaHoc)nv).tinhLuong();
                    }
                }
            } else if (loai == 2 )
            {
                foreach (Nhanvien nv in ds)
                {
                    if (nv is NhaQuanLy)
                    {
                        temp = temp + ((NhaQuanLy)nv).tinhLuong();
                    }
                }
            } else if (loai == 3)
            {
                foreach (Nhanvien nv in ds)
                {
                    if (nv is NhanVienPTN)
                    {
                        temp = temp + ((NhanVienPTN)nv).tinhLuong();
                    }
                }
            }
            return temp;
        }

    }

}
