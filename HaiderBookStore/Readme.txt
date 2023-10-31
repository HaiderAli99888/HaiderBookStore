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