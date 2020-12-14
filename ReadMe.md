1. Database First Approach
	- Created project and implemented Microsoft's famous database 'Northwind' to our ecosystem.
	- Created simple UI with windows forms for access, execute and retrieve query examples.
	- Added some queries and updated winform

2. Code First Approach
	- Created layers as folders
	- Added Entity Framework 6.2.0 to the project's references
	- Implement DbContext and build connection string with using windows authenticaton
	- Created entity classes
	- Designed simple winform for run add/modify/delete processes.
	- Enabled migrations
	- Enabled automatic migrations
	- Created database with update-database command in package manager console
	- Created CRUD operations in Form1.cs because this project is just to explain how Code First Approach is works. Normally we use design patterns with n-tier architecture.
3. Code First Lab
	- Created layers as folders
	- Implemented Entity Framework 6.2.0 to the project
	- Created entity classes
	- Created repository classes
	- In this example I implemented a better repository pattern to the project. All CRUD operations are managed with repository clases. UI and Database seperated with Repository pattern.
	- Created an instance of DbContext class and implemented local Sql server connection string.
	- Added DbSet objects to the project context to convert entity classes to database tables.
	- Started to desigh ui layer with windows form, not yet finished.
	- Created a test AppUser to debug operations.