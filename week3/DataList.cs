using QuanLySinhVien.Data.Entity;

namespace QuanLySinhVien.Data.DAL;

public sealed class DataList
{
    internal List<LopHoc> LopHocs { get; } = new();
    internal List<SinhVien> SinhViens { get; } = new();
    public static DataList Shared { get; } = new();

    public DataList(bool seed = true)
    {
        if (!seed) return;
        LopHocs.AddRange(new[]
        {
            new LopHoc { MaLop = "CSE0001", TenLop = "Khoa học máy tính 01" },
            new LopHoc { MaLop = "CSE0002", TenLop = "Khoa học máy tính 02" },
            new LopHoc { MaLop = "CSE0003", TenLop = "Khoa học máy tính 03" }
        });
        SinhViens.AddRange(new[]
        {
            new SinhVien { MaSV = "SV000123", HoTen = "Nguyễn Văn An",
                NgaySinh = new DateTime(2006, 8, 15), GioiTinh = "Nam",
                Email = "an.nv@vju.ac.vn", SoDienThoai = "0912345678",
                MaLop = "CSE0001", Diem = 8.5 },
            new SinhVien { MaSV = "SV000124", HoTen = "Trần Minh Anh",
                NgaySinh = new DateTime(2006, 1, 22), GioiTinh = "Nữ",
                Email = "anh.tm@vju.ac.vn", SoDienThoai = "0987654321",
                MaLop = "CSE0002", Diem = 9.0 },
            new SinhVien { MaSV = "SV000125", HoTen = "Lê Hoàng Bình",
                NgaySinh = new DateTime(2006, 5, 9), GioiTinh = "Nam",
                Email = "binh.lh@vju.ac.vn", SoDienThoai = "0355556677",
                MaLop = "CSE0001", Diem = 7.4 },
            new SinhVien { MaSV = "SV000126", HoTen = "Đỗ Thị Hồng",
                NgaySinh = new DateTime(2006, 11, 30), GioiTinh = "Nữ",
                Email = "hong.dt@vju.ac.vn", SoDienThoai = "0777888999",
                MaLop = "CSE0003", Diem = 8.1 }
        });
    }
}
