add-appxpackage -path Microsoft.DesktopAppConverter_2.1.4.0_x64__8wekyb3d8bbwe.Appx 
DesktopAppConverter.exe -Installer MyApplication.msi -Destination Appx05 -PackageName "MyCompany.MyApplication"  -Publisher "CN=12345678-1234-1234-1234-123456789012" -PackagePublisherDisplayName "FileStar AB" -PackageDisplayName  "FileStar" -Version 1.0.14.0 -MakeAppx -Verbose
