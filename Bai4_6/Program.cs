namespace QuanLySinhVien;

{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new FormStudent { StartPosition = FormStartPosition.CenterScreen });
    }
}
