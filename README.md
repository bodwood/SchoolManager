# School Manager
| ![Pencil](https://github.com/bodwood/SchoolManager/blob/master/wwwroot/images/pencil.png) | ![School](https://github.com/bodwood/SchoolManager/blob/master/wwwroot/images/school.png) | ![School Bus](https://github.com/bodwood/SchoolManager/blob/master/wwwroot/images/school-bus.png)
| --- | --- | --- |

#### By Bodie Wood 👨🏼‍💻

## Technologies Used 

- C# 
- .NET 6
- ASP.NET Core MVC
- Entity Framework Core 6
- SQL
- Entity
- Identity
- LINQ
- MYSQL Workbench
- MySQL
- HTML
- CSS

## Description 🔎

A web application for ordering movie tickets and managing movie related content. Users can browse and purchase movie tickets, while managers have full CRUD access to manage Orders, Cinema, Movie, Actor, and Producer data. Users can choose to register for an account if they would like to order movie tickets. 

## Setup/Installation Requirements 🛠️

* Clone repository to your desktop:
  1. GIT must be installed to clone repository. If GIT is needed, click here: [Install Git](https://docs.github.com/en/get-started/quickstart/set-up-git)
  2. Once GIT is installed, open your terminal and navigate to the desired landing folder
  3. In the terminal run:
    - ```git clone https://github.com/bodwood/SchoolManager.git ```
    - ```cd SchoolManagerProject```
* Install .NET 6 SDK. If .NET 6 SDK is needed, click here: [Install .NET 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
* Install necessary packages for EF Core and a tool to database updates:
    - ```dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0```
    - ```dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0```
    - ```dotnet tool install --global dotnet-ef --version 6.0.1```
    - ```dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore -v 6.0.0```
* Create .gitignore file:
  - ```touch .gitignore```
  - ```echo "*/obj/ */bin/ */appsettings.json" > .gitignore ```

* Create a new file called ```appsettings.json``` within the SchoolManagerProject directory by running the following:
  - ```cd SchoolManagerProject```
  - ```touch appsettings.json```
  - ```
    echo '{
      "ConnectionStrings": {
       "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DATABASE-HERE];uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
          }
          }' > appsettings.json
    ```
* _Make sure to set uid and pwd_

* Update Database by running the following:
  - ```dotnet ef database update --project SchoolManagerProject```

* Install dependencies:
  - ```npm install```

* Build project:
  - ```dotnet build SchoolManagerProject/```

* Run project:
  - ```dotnet run --project SchoolManagerProject/```

- Navigate to [http://localhost:5000](http://localhost:5000) to try application

## Known Bugs 🪲

* _No known bugs_

## Entity Relationship Schema
![ER Schema](https://github.com/bodwood/SchoolManager/blob/master/wwwroot/images/ER-Schema.png)

## License ✅

**MIT License**

Copyright (c) 2023 Bodie Wood

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.