namespace MapsExample;

public partial class App : Application
{
	public App()
	{
		Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTM4NTcwMEAzMjMwMmUzNDJlMzBLOEJtTTh4NVE0bnN1RWwwbmR1TVBNRWFSd0FjTnkzYU5qM2I0Kys2MEJvPQ==");
		InitializeComponent();

		MainPage = new AppShell();
	}
}
