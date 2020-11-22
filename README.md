# mCore (core.majdev.net)

Web-based free computer control software. It connects with the database. Asynchronous, tasks run after max 5 seconds.
- Deskop Software Language : C# (.Net Framework 4.5)
- Web Software Language : PHP (7.2++) + CSS(Desing)


Compatible for smart watches.
- Deskop/Mobil Login: index.php
- Smart Watch Login: watch.php [**Tested Apple Watch Series 6 (44mm)**]

Demo: [core.majdev.net](https://core.majdev.net/)
Database: [devices.sql](https://raw.githubusercontent.com/inc-Majdev/mCore/master/mCore%20-%20Web/devices.sql)
Database Config: [core_mysqlcontrols.php](https://raw.githubusercontent.com/inc-Majdev/mCore/master/mCore%20-%20Web/core_mysqlcontrols.php)

## Web Interface
![General Tab](https://raw.githubusercontent.com/inc-Majdev/mCore/master/mCore%20-%20Web/image/Screenshot_1.jpg)
![Device Tab](https://raw.githubusercontent.com/inc-Majdev/mCore/master/mCore%20-%20Web/image/Screenshot_2.jpg)
![Running Applications Tab](https://raw.githubusercontent.com/inc-Majdev/mCore/master/mCore%20-%20Web/image/Screenshot_3.jpg)
![Command Prompt Tab](https://raw.githubusercontent.com/inc-Majdev/mCore/master/mCore%20-%20Web/image/Screenshot_4.jpg)
![Tasks Tab](https://raw.githubusercontent.com/inc-Majdev/mCore/master/mCore%20-%20Web/image/Screenshot_5.jpg)

## Deskop Interface
![First Start](https://raw.githubusercontent.com/inc-Majdev/mCore/master/mCore/image/Screenshot_1.jpg)
![Register](https://raw.githubusercontent.com/inc-Majdev/mCore/master/mCore/image/Screenshot_1.jpg)

Note: Restart after the first installation. It will be automatically added to system startup. It will run in the background after the first boot.
- Uninstall ID: Delete Regedit\HKEY_CURRENT_USER\mCore\ID
- Uninstall Startup: Delete Regedit\HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Run\mCore


## Built With

* [Ample Admin](https://www.wrappixel.com/ampleadmin/) - Free Bootstrap HTML5 admin dashboard template

## Authors

* **Majdev** - *Coding* - [Majdev](https://github.com/inc-Majdev)
