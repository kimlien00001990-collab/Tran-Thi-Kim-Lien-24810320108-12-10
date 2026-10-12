namespace QuanLySinhVien;

public static class DataService
{
    public static List<Student> GetStudents() => new()
    {
        new Student { StudentId = "SV001", FullName = "Nguyễn Văn An", Age = 20, Gender = "Nam" },
        new Student { StudentId = "SV002", FullName = "Trần Thị Bình", Age = 19, Gender = "Nữ" },
        new Student { StudentId = "SV003", FullName = "Lê Minh Châu", Age = 21, Gender = "Nữ" },
        new Student { StudentId = "SV004", FullName = "Phạm Quốc Dũng", Age = 22, Gender = "Nam" },
        new Student { StudentId = "SV005", FullName = "Hoàng Thị Hà", Age = 20, Gender = "Nữ" },
    };
}
