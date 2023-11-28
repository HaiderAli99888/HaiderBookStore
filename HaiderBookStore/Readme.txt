// Name: BookStoreApp
// Purpose: Creating a BookStore app.
// Author: Haider Ali
// Date Created:  2023-10-29 8020 PM

// Modifications

// 2023-10-29 8025 PM Created new project selecting the template of ASP.Net core web application and named it as HaidersBookStore. Authentication type changed to individual user.
// 2023-10-29 8035 PM Removed a piece of code from Startup.cs as per given instructions.
// 2023-10-29 8045 PM Created a new github repository.
// 2023-10-29 9000 PM Created two breakpoints and run the project afterward(it didn't run).
// 2023-10-30 3015 PM Installed simplex bootstrap theme from bootwatch and replaced it with the existing bootstrap. And also replaced the existing css with the already given css in blackboard. Changes the bootstrap link from bootstrapmin.css to bootstrap.css.
// 2023-10-30 3045 PM Made changes in the layout.cshtml to ajdust appearance and also made changes to loginpartial.cshtml and debugged the program afterwards.
// 2023-10-30 3050 PM Added additional stylesheets and scripts that are given on blackboard.
// 2023-10-30 4050 PM Added dropdown menu in layout.cshtml and named it content management.
    <li class="nav-item dropdown">
           <a class="nav-link dropdown-toggle" href="#" id="navbarDropdownMenuLink" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
            Content Management
          </a>
          <div class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
             <a class="dropdown-item" href="#">Action</a>
             <a class="dropdown-item" href="#">Another action</a>
             <a class="dropdown-item" href="#">Something else here</a>
         </div>
    </li>
// 2023-10-30 5015 PM Created 3 new class libraries HaidersBooks.DataAccess, HaidersBooks.Models and HaidersBooks.Utilty.
// 2023-10-30 5020 PM Moved the data folder from main project to HaidersBooks.DataAccess project.
// 2023-10-30 5030 PM Installed Microsoft.Entityframeworkcore ad core.sqlserver from nuget package manager.
// 2023-10-30 5032 PM Remove migration folder from HaidersBooks.DataAccess project.
// 2023-10-30 5040 PM Installentityframeworkcore from nuget package manager.
// 2023-10-30 6000 PM Updated namespace in ApplicationDBcontext.
// 2023-10-30 6010 PM Removed Class1.cs from HaidersBooks.DataAccess, HaidersBooks.Models and HaidersBooks.Utilty.
// 2023-10-30 6015 PM Cut model folder from main project to HaidersBooks.Models.
// 2023-10-30 6030 PM Modified Error.cshtml to remove errors and added .Models.ViewModels in namespace.
// 2023-10-30 6035 PM Added project references in main project.
// 2023-10-30 6040 PM Rename Model folder to ViewModels.
// 2023-10-30 6045 PM Removed using HaiderBookStore.Data from Startup.cs.
// 2023-10-30 6055 PM Updated reference in Error.cshtml.
// 2023-10-30 7010 PM SD.cs class created in HaidersBooks.Utilty and property changed to public static.
// 2023-10-30 7020 PM Added the only reamaning HaidersBooks.Utilty project reference to main project.
// 2023-10-30 7027 PM Added reference of HaidersBooks.Models and HaidersBooks.Utilty in HaidersBooks.DataAccess project.
// 2023-10-30 7048 PM Created new area named 'Customers' and updated the route in Startup.cs.
// 2023-10-30 8000 PM Move HomeController and copy viewimport and viewstart to 'Customers' area.
// 2023-10-30 8035 PM Modify Controller and modify viewstart file to the correct path.
// 2023-10-30 9025 PM Create a new area named 'Admin' and also paste the viewimport and viewstart. Update the path in viewstart.
// 2023-10-30 9035 PM Delete the conrtroller from new Area 'Admin'.




// Part 2
// 2023-11-03 6035 PM Added a new migration in HaidersBooks.DataAccess
// 2023-11-03 6050 PM Built the application to confirm no errors.
// 2023-11-03 7030 PM Reviewed and modified appsettings.json as needed.
// 2023-11-03 8000 PM Created migrations for database changes and ensured the correct project was set as default.
// 2023-11-03 8005 PM Added migration name that is 20231103223243_AddDefaultIdentityMigration and 20231103225514_AddCategoryToDb to README.
// 2023-11-03 8030 PM Reviewed SQL syntax in migration files and noted tables related to ASP.NET Identity.
// 2023-11-03 8045 PM Updated the database using the Package Manager console and reviewed it in SQL Server Object Explorer.
// 2023-11-07 5005 PM Added new Category model, created a migration for it, and updated ApplicationDbContext.
// 2023-11-07 5035 PM Implemented a repository pattern in .DataAccess project for common CRUD operations.
// 2023-11-07 6009 PM Added IRepository and IRepository.cs interface for CRUD operations on Category class.
// 2023-11-07 6025 PM Implemented CategoryRepository and ICategoryRepository.
// 2023-11-07 6050 PM Resolved errors and modified the CategoryRepository implementation.
// 2023-11-08 3015 PM Built the project, fixed errors, and pushed commits to GitHub.
// 2023-11-08 3035 PM Implemented stored procedure repository and mapped multiple repositories in a Unit of Work.
// 2023-11-10 1051 PM Added new interface ISP_Call.cs and implemented it in a new class.
// 2023-11-10 2038 PM Updated database connection and implemented ISP_Call interface.
// 2023-11-10 2055 PM Implemented Unit of Work pattern, added IUnitOfWork interface, and updated Startup.cs.
// 2023-11-12 6000 PM Added Category CRUD functionality in new MVC Controller within Admin area.
// 2023-11-12 6017 PM Modified Index.cshtml for Category, adding JavaScript and confirming functionality.
// 2023-11-13 6035 PM Implemented Upsert POST action method in CategoryController and resolved errors.
// 2023-11-13 9010 PM Added API call for HTTPDelete in CategoryController and implemented deletion functionality.
// 2023-11-13 9030 PM Checked application for errors, tested functionality, updated README, and pushed to GitHub.



// Part 3 - Section 1
// 2023-11-20 7030 AM Created Cover Type CRUD with methods used for Category CRUD.
// 2023-11-20 7045 AM Added CoverType.cs in the Model’s folder with ID and Name properties.
// 2023-11-20 8015 AM Added CoverType to the Repository including CoverTypeRepository Class and ICoverTypeRepository Interface.
// 2023-11-20 8030 AM Included CoverType in UnitOfWork and IUnitOfWork.
// 2023-11-20 8049 AM Pushed CoverType to the Database Created migration 20231120084913_addCoverTypeToDb and updated the DB.
// 2023-11-20 8052 AM Added Cover Type to NavBar.
// 2023-11-20 9000 AM Created CoverType Controller with all required Action Methods.
// 2023-11-20 6005 PM Implemented Cover Type Index View to use DataTables.
// 2023-11-20 6010 PM Created Cover Type Upsert View for creating and updating CoverType.
// 2023-11-20 6013 PM Implemented delete CoverType functionality using API Call.
// 2023-11-20 6018 PM Added a new class Product in the .Models project.
// 2023-11-20 7024 PM Built the blueprint of Product class, making it public and resolving errors.
// 2023-11-20 7030 PM Updated ApplicationDbContext.cs file with reference to the new Products.
// 2023-11-20 7035 PM Ran add-migration command for 'addProductToDb' migration which created 20231120193505_addProductToDb and updated database.
// 2023-11-20 7037 PM Reviewed the newly created Products table in SQL Server Object Explorer.
// 2023-11-20 7039 PM Updated Product class, added [Required] to Title, ISBN, and Author, created new migration addValidationToProduct which
                      created 20231120193940_addValidationToProduct and updated the database.
// 2023-11-20 8030 PM Added Product to the Repository including IProductRepository Interface and ProductRepository Class.
// 2023-11-20 8035 PM Included Product in UnitOfWork and IUnitOfWork.
// 2023-11-20 9003 PM Built the project, checked for errors, resolved them, and pushed to GitHub.

// Part 3 - Section 2
// 2023-11-20 9004 PM Added Product Controller in Areas > Admin > Controllers to perform CRUD operations.
// 2023-11-20 9010 PM Included IWebHostEnvironment call and its using statement to the Microsoft.AspNetCore.Hosting in the ProductController method.
// 2023-11-20 9015 PM Created a ViewModel in the Models project to hold the Product object and select list for Category and CoverType.
// 2023-11-20 9019 PM Modified the ProductVM class to be public and installed the Microsoft.AspNetCore.Mvc.ViewFeatures package.
// 2023-11-20 9025 PM Modified the ProductController so the IActionResult Upsert calls to the ProductVM view model include the using statements to the ViewModels folder and Microsoft.AspNetCore.Mvc.Rendering.
// 2023-11-20 9030 PM Modified the API call to include the Category and CoverType properties.
// 2023-11-20 9040 PM Added an Index view for Product, copying the Index.cshtml code from Views/Category and modifying it for the Product List. Added properties like Title, ISBN, Price, Author, Category, and referenced a new product.js file.
// 2023-11-20 9050 PM Copied and pasted category.js, renamed it to product.js (modified the URL to point to Product).
// 2023-11-20 1000 PM Modified the _Layout.cshtml to add a new link to Product. Ran the application and continued through any exceptions.

// Part 4
// 2023-11-27 8028 PM Removed the unnecessary spacing in product controller that was existing between CoverType and Category Getall method.
// 2023-11-27 8049 PM Return view for product added for getting the required results from the product VM that was created as a part to return CoverType and Category for Product.
// 2023-11-27 9025 PM ProductVM updated with Ctaegory and CoveraType to retun views to back to the upsert that would the Admin Category and CoverType.
// 2023-11-27 9049 PM Updated the API Calls to make that GetAll pulls the the right functions to Edit and Delete the enteries from database.
// 2023-11-27 1005 PM Made the changes to the javascript file of product and added the reamaning required refereneces.
// 2023-11-27 1018 PM Added the right actions in index.cshtml of product and made the external files excessable to it to get the right view on admins index page.
// 2023-11-27 1018 PM Changed the CategoryId to CoverTypeId to make the CoverType easily accessable by the product upsert for Admin.
// 2023-11-27 1026 PM Added the first entry to the product database and added the image in product folder as well for the home page.
// 2023-11-27 1037 PM Completed the requirered three enteries to the database for the homepage, so the user can see the populated database.
// 2023-11-27 1106 PM Edited the index page for the customer to make the final appearance different than that of the bulkybook the store provided by professor.