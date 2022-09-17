# Free Remote Control (Windows)

Web-based free computer control software. It connects with the database. Asynchronous, tasks run after max 5 seconds.
- Deskop Software Language : C# (.Net Framework 4.8)
- Web Software Language : PHP (7.4++)


Compatible for smart watches.
- Deskop/Mobil Login: index.php
- Smart Watch Login: watch.php [**Tested Apple Watch Series 6 (44mm)**]

Database: [devices.sql](https://github.com/furkankadirguzeloglu/FreeRemoteControl/blob/master/WebApp/devices.sql)
Database Config: [core_mysqlcontrols.php](https://github.com/furkankadirguzeloglu/FreeRemoteControl/blob/master/WebApp/core_mysqlcontrols.php)

## Web Interface
![Screenshot](https://raw.githubusercontent.com/furkankadirguzeloglu/FreeRemoteControl/master/Images/Web-Screenshot_1.png)

![Screenshot](https://raw.githubusercontent.com/furkankadirguzeloglu/FreeRemoteControl/master/Images/Web-Screenshot_2.png)

![Screenshot](https://raw.githubusercontent.com/furkankadirguzeloglu/FreeRemoteControl/master/Images/Web-Screenshot_3.png)

![Screenshot](https://raw.githubusercontent.com/furkankadirguzeloglu/FreeRemoteControl/master/Images/Web-Screenshot_4.png)

![Screenshot](https://raw.githubusercontent.com/furkankadirguzeloglu/FreeRemoteControl/master/Images/Web-Screenshot_5.png)

![Screenshot](https://raw.githubusercontent.com/furkankadirguzeloglu/FreeRemoteControl/master/Images/Web-Screenshot_6.png)

## Deskop Interface
![Screenshot](https://raw.githubusercontent.com/furkankadirguzeloglu/FreeRemoteControl/master/Images/App-Screenshot_1.png)

![Screenshot](https://raw.githubusercontent.com/furkankadirguzeloglu/FreeRemoteControl/master/Images/App-Screenshot_2.png)

Note: Restart after the first installation. It will be automatically added to system startup. It will run in the background after the first boot.
- Uninstall ID: Delete Regedit\HKEY_CURRENT_USER\FreeRemoteControl\ID
- Uninstall Startup: Delete Regedit\HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Run\FreeRemoteControl

## Built With
* [Ample Admin](https://www.wrappixel.com/ampleadmin/) - Free Bootstrap HTML5 admin dashboard template
