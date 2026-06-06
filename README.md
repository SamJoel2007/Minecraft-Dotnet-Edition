\# 🎮 Minecraft DotNet Edition



<p align="center">

&#x20; <img src="https://img.shields.io/badge/.NET-10.0-purple?style=for-the-badge\&logo=dotnet"/>

&#x20; <img src="https://img.shields.io/badge/C%23-WinForms-blue?style=for-the-badge\&logo=csharp"/>

&#x20; <img src="https://img.shields.io/badge/Database-SQLite-green?style=for-the-badge\&logo=sqlite"/>

&#x20; <img src="https://img.shields.io/badge/Platform-Windows-lightgrey?style=for-the-badge\&logo=windows"/>

</p>



<p align="center">

&#x20; <b>A Minecraft-inspired desktop launcher built with C# WinForms and .NET</b><br/>

&#x20; <i>by Joker</i>

</p>



\---



\## 📸 Preview



> A beautiful Minecraft-themed desktop application featuring a launcher, shop, and realms system.



\---



\## ✨ Features



\- 🚀 \*\*Play\*\* — Launch into the Minecraft world

\- 🛒 \*\*Shop\*\* — Browse and purchase Minecoins and items

\- 🌍 \*\*Realms\*\* — Join multiplayer Minecraft realms

\- 💰 \*\*Minecoin System\*\* — Track and manage your in-game currency

\- 💾 \*\*SQLite Database\*\* — Persistent data storage

\- 🎨 \*\*Custom UI\*\* — Themed Minecraft-style interface



\---



\## 🏗️ Project Structure



```

Minecraft/

├── Form1.cs              # Main launcher window

├── play.cs               # Play page

├── shop.cs               # Shop page

├── mcData.cs             # Global data class (Minecoins etc)

├── Form1.Designer.cs     # Auto-generated UI code

└── Minecraft.csproj      # Project file

```



\---



\## 🛠️ Built With



| Technology | Purpose |

|---|---|

| \*\*C#\*\* | Primary programming language |

| \*\*.NET 10\*\* | Runtime framework |

| \*\*WinForms\*\* | Desktop UI framework |

| \*\*SQLite\*\* | Local database |

| \*\*Microsoft.Data.Sqlite\*\* | SQLite NuGet package |



\---



\## 🚀 Getting Started



\### Prerequisites

\- Windows 10/11

\- \[.NET 10 Runtime](https://dotnet.microsoft.com/download)

\- Visual Studio 2022



\### Installation



1\. Clone the repository:

```bash

git clone https://github.com/yourusername/minecraft-dotnet-edition.git

```



2\. Open in Visual Studio 2022:

```

File → Open → Project/Solution → Minecraft.sln

```



3\. Restore NuGet packages:

```bash

dotnet restore

```



4\. Run the project:

```bash

dotnet run

```



Or press \*\*F5\*\* in Visual Studio!



\---



\## 🎮 How to Use



1\. \*\*Launch the app\*\* — The main Minecraft launcher appears

2\. \*\*Click PLAY\*\* — Enter your username to join the world

3\. \*\*Click SHOP\*\* — Buy Minecoins and items

4\. \*\*Click REALMNS\*\* — Join or create a realm



\---



\## 💰 Minecoin System



| Package | Coins | Price |

|---|---|---|

| Starter | 20 coins | Free |

| Basic | 50 coins | ₹99 |

| Premium | 100 coins | ₹199 |



\---



\## 🗄️ Database Schema



```sql

CREATE TABLE player (

&#x20;   id       INTEGER PRIMARY KEY AUTOINCREMENT,

&#x20;   name     TEXT,

&#x20;   minecoins INTEGER

);

```



\---



\## 📁 Pages



\### 🏠 Main Launcher (Form1)

The main entry point with Play, Shop and Realmns buttons.



\### ▶️ Play Page

\- Enter your username

\- Join the SMP world

\- Game settings (PvP, Friendly Fire, etc.)



\### 🛒 Shop Page

\- View Minecoin balance

\- Purchase Minecoins

\- Buy in-game items



\### 🌍 Realmns Page

\- Join existing realms

\- New user registration



\---



\## 🤝 Contributing



This is a personal learning project. Feel free to fork and experiment!



1\. Fork the project

2\. Create your feature branch (`git checkout -b feature/AmazingFeature`)

3\. Commit your changes (`git commit -m 'Add AmazingFeature'`)

4\. Push to the branch (`git push origin feature/AmazingFeature`)

5\. Open a Pull Request



\---



\## 📝 License



This project is for \*\*educational purposes only\*\*.



Minecraft is a trademark of \*\*Mojang/Microsoft\*\*. This project is not affiliated with or endorsed by Mojang or Microsoft.



\---



\## 👨‍💻 Developer



\*\*Joker\*\*

\- Built with ❤️ using C# and .NET

\- Learning journey: Console Apps → WinForms → ASP.NET



\---



<p align="center">

&#x20; @Sam ALL COPY RIGHTS RESERVED

</p>

```

