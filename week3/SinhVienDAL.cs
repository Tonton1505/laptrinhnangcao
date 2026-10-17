using QuanLySinhVien.Data.Entity;

namespace QuanLySinhVien.Data.DAL;

public class SinhVienDAL
{
    private readonly DataList data;
    public SinhVienDAL() : this(DataList.Shared) { }
    public SinhVienDAL(DataList data) => this.data = data;

    public List<SinhVien> GetAllSinhVien() =>
        data.SinhViens.Select(x => x.Copy()).ToList();

    public SinhVien? GetSinhVienById(string maSV) =>
        data.SinhViens.FirstOrDefault(x =>
            string.Equals(x.MaSV, maSV, StringComparison.OrdinalIgnoreCase))?.Copy();

    public List<SinhVien> GetSinhVienByLop(string maLop) =>
        data.SinhViens.Where(x =>
            string.Equals(x.MaLop, maLop, StringComparison.OrdinalIgnoreCase))
            .Select(x => x.Copy()).ToList();

    public void AddSinhVien(SinhVien sv) => data.SinhViens.Add(sv.Copy());

    public bool UpdateSinhVien(SinhVien sv)
    {
        var index = data.SinhViens.FindIndex(x =>
            string.Equals(x.MaSV, sv.MaSV, StringComparison.OrdinalIgnoreCase));
        if (index < 0) return false;
        data.SinhViens[index] = sv.Copy();
        return true;
    }

    public bool DeleteSinhVien(string maSV) =>
        data.SinhViens.RemoveAll(x =>
            string.Equals(x.MaSV, maSV, StringComparison.OrdinalIgnoreCase)) > 0;

    public List<SinhVien> TimKiem(string tuKhoa, string? maLop, double diemTu)
    {
        tuKhoa = (tuKhoa ?? "").Trim();
        return data.SinhViens.Where(sv =>
            (string.IsNullOrEmpty(maLop) ||
             string.Equals(sv.MaLop, maLop, StringComparison.OrdinalIgnoreCase))
            && sv.Diem >= diemTu
            && (tuKhoa.Length == 0
                || sv.MaSV.Contains(tuKhoa, StringComparison.OrdinalIgnoreCase)
                || sv.HoTen.Contains(tuKhoa, StringComparison.OrdinalIgnoreCase)
                || sv.Email.Contains(tuKhoa, StringComparison.OrdinalIgnoreCase)
                || sv.SoDienThoai.Contains(tuKhoa, StringComparison.OrdinalIgnoreCase)))
            .Select(x => x.Copy()).ToList();
    }
}
