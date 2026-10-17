using QuanLySinhVien.Data.Entity;

namespace QuanLySinhVien.Data.DAL;

public class LopDAL
{
    private readonly DataList data;
    public LopDAL() : this(DataList.Shared) { }
    public LopDAL(DataList data) => this.data = data;

    public List<LopHoc> GetAllLopHoc() => data.LopHocs.Select(x => x.Copy()).ToList();

    public LopHoc? GetLopHocById(string maLop) =>
        data.LopHocs.FirstOrDefault(x =>
            string.Equals(x.MaLop, maLop, StringComparison.OrdinalIgnoreCase))?.Copy();

    public void AddLopHoc(LopHoc lh) => data.LopHocs.Add(lh.Copy());

    public bool UpdateLopHoc(LopHoc lh)
    {
        var index = data.LopHocs.FindIndex(x =>
            string.Equals(x.MaLop, lh.MaLop, StringComparison.OrdinalIgnoreCase));
        if (index < 0) return false;
        data.LopHocs[index] = lh.Copy();
        return true;
    }

    public bool DeleteLopHoc(string maLop) =>
        data.LopHocs.RemoveAll(x =>
            string.Equals(x.MaLop, maLop, StringComparison.OrdinalIgnoreCase)) > 0;
}
