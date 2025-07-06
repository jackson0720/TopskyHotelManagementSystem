<h1 align="center"><img src="https://foruda.gitee.com/avatar/1677165732744604624/7158691_java-and-net_1677165732.png!avatar100" alt="Organization Logo.png" /></h1>
<h1 align="center">TopskyHotelManagementSystem</h1>
<p align="center">
	<a href='https://gitee.com/java-and-net/TopskyHotelManagementSystem/stargazers'><img src='https://gitee.com/java-and-net/TopskyHotelManagementSystem/badge/star.svg?theme=white' alt='star'></img></a>
        <a href='https://gitee.com/java-and-net/TopskyHotelManagementSystem/members'><img src='https://gitee.com/java-and-net/TopskyHotelManagementSystem/badge/fork.svg?theme=white' alt='fork'></img></a>
        <a href='https://img.shields.io/badge/license-MIT-000000.svg'><img src="https://img.shields.io/badge/license-MIT-000000.svg" alt=""></img></a>
        <a href='https://img.shields.io/badge/language-C#-red.svg'><img src="https://img.shields.io/badge/language-CSharp-red.svg" alt=""></img></a>
</p>
<div align="center">
	<p><a href="./README.md">中文文档</a> | English Document</p>
</div>

# :exclamation: Important Notice:

**Note: The master branch changes with the v2.x version, which significantly differs from the v1.x version. Those interested in the v1.x version can move to the v1.x branch address**: https://gitee.com/java-and-net/TopskyHotelManagerSystem/tree/v1.x/

**Effective immediately, version numbers will follow the format x.x.x.x. First digit: program version, second: framework version, third: major updates, fourth: bug fixes. For example, version 2.0 on .NET 8 is 2.8.0.0. On .NET 9, it will be 2.9.0.0, and so on.**

**Effective immediately, this project officially enters the maintenance phase and will no longer incorporate any new features. Simultaneously, we are pleased to announce the commencement of mobile development for the TopSkyHotelManagementSystem. The repository address is: [TopSkyHotelManagementSystem-MAUI](https://gitee.com/java-and-net/topsky-hotel-management-system-maui). This project is being developed using .NET 8's MAUI framework, with initial development focused exclusively on the Android platform. Expansion to other platforms is not currently feasible.**

# :pray: Open Source Projects Referenced:

1. ##### Fody—Packs all dlls into an exe application. [Fody, MIT License](https://github.com/Fody/Fody)

2. ##### SQLSugar, the most popular ORM framework in China. [SQLSugar, Apache-2.0 License](https://gitee.com/dotnetchina/SqlSugar)

3. ##### SunnyUI—SunnyUI.Net, based on C# .Net WinForm open-source control library, tool library, extension library, and multi-page development framework. [SunnyUI.Net, GPL3.0 License](https://gitee.com/yhuse/SunnyUI)

4. ##### RestSharp——Simple REST and HTTP API Client for .NET。[RestSharp,Apache-2.0 License](https://github.com/restsharp/RestSharp)

5. ##### AntdUI——基于 Ant Design 设计语言的 Winform 界面库. AntdUI。[AntdUI,Apache-2.0 License](https://gitee.com/antdui/AntdUI)

# :exclamation: Project Description:

1. When conducting secondary development of this project, please comply with the MIT open source license. All referenced open source projects adopt their respective open source licenses. When using these open source projects, be sure to include the appropriate declarations in the project description and conduct any open source actions in accordance with their respective licenses.

2. Bugs and comments are welcome!

3. This system’s 95% of the pages are created based on the SunnyUI.Net control library, hereby specially declared!

4. Regarding the database script issue, please first go to the database script folder, choose either the MySQL version or PostgreSQL version folder to download the Data and Table files. In the database, execute the Table.sql first, then the Data.sql!

5. This project has implemented multi-database support (mainstream) based on the SQL Sugar framework. Below is the list of currently tested and verified database compatibility tables:

    | Database   | Version          | Support Create  Table(Y/N) | Pass(Y/N)                                                    |
    | ---------- | ---------------- | -------------------------- | ------------------------------------------------------------ |
    | MariaDB    | 10.11.10-MariaDB | Y                          | Y                                                            |
    | PostgreSQL | 130020           | Y                          | Y                                                            |
    | MySQL      | 5.7+             | Y                          | Y                                                            |
    | SQL Server | 2022             | Y                          | Y                                                            |
    | Oracle     | Unknown          | N                          | Reference SQLSugar Document([SQLSugar](https://www.donet5.com)) |

# :thought_balloon: Development Purpose:

In today's rapidly developing hotel industry, with the increase in daily hotel work, it has become difficult to handle with manpower alone. Some cumbersome data may also cause some losses to the hotel due to human errors, hence the need for a management software that can assist in the internal management of the hotel.

# :mag_right: System Development Environment:

Operating System: Windows 11(x64)

Development Tools: Microsoft Visual Studio 2022 (latest version of the system)

Database: MariaDB (highly recommended!)

Database Management Tools: DbGate

Programming Languages: C# language, T-SQL language

Development Platform: .Net

Development Framework: .Net 8

Development Technology: .NET 8 WinForm

# :open_file_folder: System Structure:

```tree
EOM.Client.TopSkyHotelManagerSystem
├─ .git
├─ .gitignore
├─ EOM.Client.TopSkyHotelManagerSystem.sln
├─ FodyWeavers.xml
├─ LICENSE
├─ README.md
├─ EOM.TSHotelManager.Common
├─ EOM.TSHotelManager.FormUI
│    ├─ .gitignore
│    ├─ App.config
│    ├─ AppFunction
│    ├─ AppInterface
│    ├─ AppMain
│    ├─ AppUserControls
│    ├─ FodyWeavers.xml
│    ├─ FodyWeavers.xsd
│    ├─ Logo
│    ├─ Program.cs
│    ├─ Properties
│    ├─ Resources
├─ SYS.Library
├─ Database Scripts
├─ Project Screenshots
└─ Project Related Documents
```

# :chart_with_upwards_trend: System Database Relationship Diagram (Generated by PDMAN Software) :loudspeaker:

[Database Relationship Diagram](https://oscode.top/project/tshotel/db_design.html)

# :books: Summary of System Function Modules:

| Function Summary                 |                       |                      |                     |                  |                    |                    |
| -------------------------------- | --------------------- | -------------------- | ------------------- | ---------------- | ------------------ | ------------------ |
| (Front Desk) Room Management     | Reserve Room          | Check-in Room        | Checkout Room       | Switch Room      | View Customer Info | Modify Room Status |
| (Front Desk) Customer Management | Display Customer Info | Search Customer Info | Add Customer        |                  |                    |                    |
| (Front Desk) Product Consumption | Product List          | Search Product Info  | Product Consumption | Consumption Info |                    |                    |

# :books: Summary of Multi-Platform Code Repositories:
| Platform | Repository URL                                                        | Repository Description                                                                                                   | License     | Dependency |
|----------|-----------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------------------|-------------|------------|
| PC       | https://gitee.com/java-and-net/TopskyHotelManagementSystem            | .NET 8 WinForm-based solution (UI layer without business logic) designed for small/medium-sized hotel management systems | [MIT License](https://gitee.com/java-and-net/TopskyHotelManagementSystem/blob/master/LICENSE) | [WebApi](https://gitee.com/java-and-net/topsky-hotel-management-system-web-api)     |
| Web      | https://gitee.com/java-and-net/topsky-hotel-management-system-vue3    | Vue 3-based frontend designed for small/medium-sized hotel management systems                                            | [MIT License](https://gitee.com/java-and-net/topsky-hotel-management-system-vue3/blob/Main/LICENSE) | [WebApi](https://gitee.com/java-and-net/topsky-hotel-management-system-web-api)     |
| Android  | https://gitee.com/java-and-net/topsky-hotel-management-system-maui    | .NET 8 MAUI-based mobile application project                                                                             | [MIT License](https://gitee.com/java-and-net/topsky-hotel-management-system-maui/blob/Main/LICENSE) | [WebApi](https://gitee.com/java-and-net/topsky-hotel-management-system-web-api)     |
| Backend  | https://gitee.com/java-and-net/topsky-hotel-management-system-web-api | .NET 8 backend API project for TS Hotel Management System built with SQLSugar ORM, serving PC/Web/Android clients        | [MIT License](https://gitee.com/java-and-net/topsky-hotel-management-system-web-api/blob/master/LICENSE) |            |

# :family: Project Authors:

**Original Team: Jackson, Benjamin, Bin, Jonathan**

**Later Maintenance Team: Easy Open Meta (易开元)**

# :computer: Project Setup and Deployment:

**Download and install .NET SDK version 8 or above.**
**Download and install Microsoft Visual Studio Professional 2022 or above, unzip the downloaded Zip package, and run the .sln file.**

# :inbox_tray: Database Setup and Deployment (Local):

**Omitted. This project does not include backend business logic. For details, please refer to: [Business Logic Project](https://gitee.com/java-and-net/topsky-hotel-management-system-web-api/blob/master/README.en.md)**

[![java-and-net/TopskyHotelManagementSystem](https://gitee.com/java-and-net/TopskyHotelManagementSystem/widgets/widget_card.svg?colors=4183c4,ffffff,ffffff,e3e9ed,666666,9b9b9b)](https://gitee.com/java-and-net/TopskyHotelManagerSystem)
