# [1. Database First Approach](https://github.com/ilovepilav/EF-Approaches/tree/master/DbFirst)
- [x]  Created project and implemented Microsoft's famous database **'Northwind'** to our ecosystem.
- [x]  Created simple UI with windows forms for access, execute and retrieve query examples.
- [x]  Added some queries and updated winform

# [2. Code First Approach](https://github.com/ilovepilav/EF-Approaches/tree/master/2-CodeFirst)
- [x]  Created layers as folders
- [x]  Added **Entity Framework 6.2.0** to the project's references
- [x]  Implement DbContext and build connection string with using windows authenticaton
- [x]  Created entity classes
- [x]  Designed simple winform for run add/modify/delete processes.
- [x]  Enabled migrations
- [x]  Enabled automatic migrations
- [x]  Created database with update-database command in package manager console
- [x]  Created **CRUD** operations in Form1.cs because this project is just to explain how Code First Approach is works. Normally we use design patterns with n-tier architecture.
# [3. Code First Lab](https://github.com/ilovepilav/EF-Approaches/tree/master/3-CodeFirst_Lab-PhoneBook)
- [x]  This project is a simple PhoneBook applet.
- [x]  Created layers as folders
- [x]  Implemented Entity Framework 6.2.0 to the project
- [x]  Created entity classes
- [x]  Created [repository classes](https://github.com/ilovepilav/EF-Approaches/tree/master/3-CodeFirst_Lab-PhoneBook/DataAccessLayer/Repositories)
- [x]  In this example I implemented a better repository pattern to the project. All **CRUD** operations are managed with repository clases. UI and Database seperated with **Repository pattern**.
- [x]  Created an instance of DbContext class and implemented local Sql server connection string.
- [x]  Added DbSet objects to the project context to convert entity classes to database tables.
- [x]  Started to desigh ui layer with windows form, not yet finished.
- [x]  Created a test AppUser to debug operations.