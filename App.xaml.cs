namespace ChatApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzE5NDM2OEAzMjM1MmUzMDJlMzBDNGUvQjF4dmQzb0VXeERURU5GSmRXWGJYRjhFQjMxL04zUWdlRG1aRWwwPQ==\r\n");
            MainPage = new AppShell();
        }
    }
}
