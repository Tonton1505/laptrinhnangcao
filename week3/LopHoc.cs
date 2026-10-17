using System.ComponentModel.DataAnnotations;

namespace QuanLySinhVien.Data.Entity;

public class LopHoc
{
    [Required(ErrorMessage = "Mã lớp không được để trống.")]
    [RegularExpression(@"^[A-Za-z0-9_-]{2,20}$",
        ErrorMessage = "Mã lớp gồm 2–20 ký tự chữ, số, dấu _ hoặc -.")]
    public string MaLop { get; set; } = "";

    [Required(ErrorMessage = "Tên lớp không được để trống.")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "Tên lớp phải có 2–100 ký tự.")]
    public string TenLop { get; set; } = "";

    public List<ValidationResult> IsInValid()
    {
        var errors = new List<ValidationResult>();
        Validator.TryValidateObject(this, new ValidationContext(this), errors, true);
        return errors;
    }

    public LopHoc Copy() => (LopHoc)MemberwiseClone();
}
