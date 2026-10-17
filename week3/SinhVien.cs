using System.ComponentModel.DataAnnotations;

namespace QuanLySinhVien.Data.Entity;

public class SinhVien : IValidatableObject
{
    [Required(ErrorMessage = "Mã sinh viên không được để trống.")]
    [RegularExpression(@"^[A-Za-z0-9_-]{2,20}$",
        ErrorMessage = "Mã sinh viên gồm 2–20 ký tự chữ, số, dấu _ hoặc -.")]
    public string MaSV { get; set; } = "";

    [Required(ErrorMessage = "Họ tên không được để trống.")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "Họ tên phải có 2–100 ký tự.")]
    public string HoTen { get; set; } = "";

    public DateTime NgaySinh { get; set; } = DateTime.Today;

    [Required(ErrorMessage = "Vui lòng chọn giới tính.")]
    [RegularExpression("^(Nam|Nữ)$", ErrorMessage = "Giới tính phải là Nam hoặc Nữ.")]
    public string GioiTinh { get; set; } = "Nam";

    [Required(ErrorMessage = "Email không được để trống.")]
    [EmailAddress(ErrorMessage = "Email không đúng định dạng.")]
    [StringLength(254, ErrorMessage = "Email không được quá 254 ký tự.")]
    public string Email { get; set; } = "";

    [Required(ErrorMessage = "Điện thoại không được để trống.")]
    [RegularExpression(@"^0[0-9]{9}$",
        ErrorMessage = "Điện thoại phải có 10 chữ số và bắt đầu bằng 0.")]
    public string SoDienThoai { get; set; } = "";

    [Required(ErrorMessage = "Vui lòng chọn lớp học.")]
    public string MaLop { get; set; } = "";

    [Range(0.0, 10.0, ErrorMessage = "Điểm phải nằm trong khoảng 0–10.")]
    public double Diem { get; set; }

    [Required(ErrorMessage = "Vui lòng chọn trạng thái.")]
    [RegularExpression("^(Đang học|Bảo lưu|Đã tốt nghiệp)$",
        ErrorMessage = "Trạng thái không hợp lệ.")]
    public string TrangThai { get; set; } = "Đang học";

    public List<ValidationResult> IsInValid()
    {
        var errors = new List<ValidationResult>();
        Validator.TryValidateObject(this, new ValidationContext(this), errors, true);
        foreach (var error in Validate(new ValidationContext(this)))
            if (!errors.Any(e => e.ErrorMessage == error.ErrorMessage
                                && e.MemberNames.SequenceEqual(error.MemberNames)))
                errors.Add(error);
        return errors;
    }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (NgaySinh.Date > DateTime.Today)
            yield return new ValidationResult("Ngày sinh không được ở tương lai.",
                new[] { nameof(NgaySinh) });
        if (NgaySinh.Date < new DateTime(1900, 1, 1))
            yield return new ValidationResult("Ngày sinh phải từ năm 1900 trở đi.",
                new[] { nameof(NgaySinh) });
        if (double.IsNaN(Diem) || double.IsInfinity(Diem))
            yield return new ValidationResult("Điểm phải là số hữu hạn.",
                new[] { nameof(Diem) });
    }

    public SinhVien Copy() => (SinhVien)MemberwiseClone();
}
