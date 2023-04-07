2023-03-02
1505
Started Assignment 2 in-class on the lab computer
Setup the ASP.NET MVC w core 1.3(out of support)
HTTPS enabled, individual account authentication ... no Razor...

Create a Repository named as KusumlataBookStore
Reviewed the Areas folder, Controller, Model and Views
AND....
1506.... in startup.cs on the line 33
removed options for default identity
options => options.SignIn.RequireConfirmedAccount = true

1510 Tested the app ... ran it good ....tested links
Action items:
...Modify the Navigation
-Update the copyright from static to dynamic date

Modify the defaul Welcome Page.
Review the route pattern 

*****Stop here my Assignmet 2  ,will continue tomorrow*****

****2023-04-02*****

continue my Assignment 2      0305
Clone my repository for Assignmet 2 with github

1537  Rename my Readme.txt
1540 Rename my Readme.txt to README.txt on Github

Create new README.md       1553
And update README.md

Pause Project  2023-03-03

Start working again my project KusumlataBookStore
Rename bootstrap.css to oldbootstrap.css

Then visit Bootwatch.com and go through with some themes
Then select Flatly theme     0238

Added downloaded bottstrap.css inside wwwroot/lib/bootstap/css/botstrap.css

Make some changes in _Layout.cshtml, fowllowing changes I made in _Layout.cshtml
1. Rename bootstra.min.css to bootstrap.css
2. change the nav class from navbar-light to navbar dark and bg-white to bg-primary
3. remove text dark from line 23
4. Add  @await RenderSectionAsync to the footer class

Remove references to text-dark in _LoginPartial.cshtml

Added additional stylesheet 
 <link rel="stylesheet" href="https://cdn.datatables.net/1.10.16/css/jquery.dataTables.min.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/css/toastr.min.css" />
    and  script

     <script src="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"></script>
    <script src="https://cdn.datatables.net/1.10.16/js/jquery.dataTables.min.js"></script>
    <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/js/toastr.min.js"></script>
    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
    <script src="https://kit.fontawesome.com/e19c476714.js"></script>   

    Pause project at 1600

    Start project again at 1943

    Add dropdown to content managemnet inside _Layout.cshtml

    Add new project by sleceting C#


    Complete pArt 1    1526

    Move data folder inside KusumlataBooks.DataAccess       1950

    Delete Migration folder From KusumlataBooks.DataAccess/Data

    Change namespace KusumlataBookStore.Data to namespace KusumlataBookStore.DataAccess.Data in ApplicationDbContext.cs in Line #7   

    Delete Class1 from KusumlatBooks.DataAccess,  KusumlatBooks.Models,  KusumlatBooks.Utility

    Rename Model folder as ViewModels

    Make some changes in HomeController.cs , Error.cshtml and ErrorViewModel.cs

    Add SD.cs in KusumlataBooks.DataUtility

    Add public statis property in SD.cs file in line #7

    Add customer area into Areas Folder

  *** Add this code in Startup.cs   in line 63****     2025
       endpoints.MapAreaControllerRoute(
        name: "defaultArea",
        areaName: "Customer",
        pattern: "{controller=Home}/{action=Index}/{id?}");

 MoveHomeController.cs inside Areas/Customer/Controllers

 Move Home Folder inside Areas/Customer/Views

 Update HomeController.cs by adding namespace KusumlataBookStore.Area.Customer.Controllers

 Copy and Paste _ViewsImports.cshtml and _Viewstart.cshtml in Customer Areas

 Add  Layout = "~/Views/Shared/_Layout.cshtml"  in _ViewStart.cshtml

  Copy and Paste _ViewsImports.cshtml and _Viewstart.cshtml in Admin Areas

  Delete Controller folder from KusumlataBookStore

  Pause project At   2023-03-23   2045

  ****** Start Assignment Part #2    ***********      2023-03-24     1500
 
 Build project    
 
 Update database name in appsettings.json
Change the Default project name to KusumlataBooks.DataAccess

 Run command in Package Manager console
 **** add-migration AddDefaultIdentityMigration *****
 After complete migrations, Update the Databse by run command in colsole  update-databse

 But got errors while update-database           1600

 Severity	Code	Description	Project	File	Line	Suppression State
1. Error	CS0103	The name 'SqlServerValueGenerationStrategy' does not exist in the current context	KusumlataBooks.DataAccess	C:\Users\W0798437\source\repos\kusuml04\kusuml04\KusumlataBookStore\KusumlataBooks.DataAccess\Migrations\20230324193704_AddDefaultIdentityMigration.Designer.cs	22	Active

2. Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0103	The name 'SqlServerValueGenerationStrategy' does not exist in the current context	KusumlataBooks.DataAccess	C:\Users\W0798437\source\repos\kusuml04\kusuml04\KusumlataBookStore\KusumlataBooks.DataAccess\Migrations\20230324193704_AddDefaultIdentityMigration.Designer.cs	56	Active
3. Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0103	The name 'SqlServerValueGenerationStrategy' does not exist in the current context	KusumlataBooks.DataAccess	C:\Users\W0798437\source\repos\kusuml04\kusuml04\KusumlataBookStore\KusumlataBooks.DataAccess\Migrations\20230324193704_AddDefaultIdentityMigration.Designer.cs	145	Active

4. Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0103	The name 'SqlServerValueGenerationStrategy' does not exist in the current context	KusumlataBooks.DataAccess	C:\Users\W0798437\source\repos\kusuml04\kusuml04\KusumlataBookStore\KusumlataBooks.DataAccess\Migrations\20230324193704_AddDefaultIdentityMigration.Designer.cs	145	Active

5. Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0103	The name 'SqlServerValueGenerationStrategy' does not exist in the current context	KusumlataBooks.DataAccess	C:\Users\W0798437\source\repos\kusuml04\kusuml04\KusumlataBookStore\KusumlataBooks.DataAccess\Migrations\ApplicationDbContextModelSnapshot.cs	54	Active

6. Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0103	The name 'SqlServerValueGenerationStrategy' does not exist in the current context	KusumlataBooks.DataAccess	C:\Users\W0798437\source\repos\kusuml04\kusuml04\KusumlataBookStore\KusumlataBooks.DataAccess\Migrations\ApplicationDbContextModelSnapshot.cs	143	Active

    Try to fix errors but did not succeed today   1657
    
    Pause project at                  2023-03-24  1657  

    Start Project again at           2023-03-30   1500

    After so many tries unable to fix errors 
    Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0103	The name 'SqlServerValueGenerationStrategy' does not exist in the current context	KusumlataBooks.DataAccess	C:\Users\W0798437\source\kusuml04\KusumlataBookStore\kusuml04\KusumlataBookStore\KusumlataBooks.DataAccess\Migrations\20230324193704_AddDefaultIdentityMigration.Designer.cs	58	Active
Error	CS0103	The name 'SqlServerValueGenerationStrategy' does not exist in the current context	KusumlataBooks.DataAccess	C:\Users\W0798437\source\kusuml04\KusumlataBookStore\kusuml04\KusumlataBookStore\KusumlataBooks.DataAccess\Migrations\20230324193704_AddDefaultIdentityMigration.Designer.cs	24	Active
Error	CS0103	The name 'SqlServerValueGenerationStrategy' does not exist in the current context	KusumlataBooks.DataAccess	C:\Users\W0798437\source\kusuml04\KusumlataBookStore\kusuml04\KusumlataBookStore\KusumlataBooks.DataAccess\Migrations\20230324193704_AddDefaultIdentityMigration.Designer.cs	147	Active
Error	CS1061	'object' does not contain a definition for 'IdentityColumn' and no accessible extension method 'IdentityColumn' accepting a first argument of type 'object' could be found (are you missing a using directive or an assembly reference?)	KusumlataBooks.DataAccess	C:\Users\W0798437\source\kusuml04\KusumlataBookStore\kusuml04\KusumlataBookStore\KusumlataBooks.DataAccess\Migrations\ApplicationDbContextModelSnapshot.cs	22	Active
Error	CS1061	'object' does not contain a definition for 'IdentityColumn' and no accessible extension method 'IdentityColumn' accepting a first argument of type 'object' could be found (are you missing a using directive or an assembly reference?)	KusumlataBooks.DataAccess	C:\Users\W0798437\source\kusuml04\KusumlataBookStore\kusuml04\KusumlataBookStore\KusumlataBooks.DataAccess\Migrations\ApplicationDbContextModelSnapshot.cs	56	Active
Error	CS1061	'object' does not contain a definition for 'IdentityColumn' and no accessible extension method 'IdentityColumn' accepting a first argument of type 'object' could be found (are you missing a using directive or an assembly reference?)	KusumlataBooks.DataAccess	C:\Users\W0798437\source\kusuml04\KusumlataBookStore\kusuml04\KusumlataBookStore\KusumlataBooks.DataAccess\Migrations\ApplicationDbContextModelSnapshot.cs	145	Active

After tha ADD  (public object SqlServerValueGenerationStrategy { get; private set; })   in line 14  inside ApplicationDbContextModelSnapshot.cs and 20230324193704 Designer.cs
but still getting error (Value cannot be null)
 Remove the previous changes from ApplicationDbContextModelSnapshot.cs and 20230324193704 Designer.cs
 
 I missed the instruction in which i have to install Microsoft.EntityFrameworkCore.Relation and Core.SQLServer packages then review the slides and install 
 these packages. *****Finally update-database is successfull*******    2023-03-30    2000
 
 Add Category.cs inside KusumlataBooks.Models   2023-03-31   1102
 
 Run Command add-migration AddCategoryToDb

 using KusumlataBooks.Models; in line first inside ApplicationDbContext.cs
  public DbSet<Category> Categories { get; set; }   in line 16

Delete AddCategoryToDb.cs  from migration folder
Add a Repository folder inside KusumlataBooks.DataAccess
Add a IRepository inside Repository folder                 2023-03-31    1151

Add a class Repository.cs inside Repository folder
Add ICategoryRepository.cs interface inside Irepository folder and CategoryRepsotory..cs class inside Repository folder

Modify CategoryRepository.cs and ICategoryRepository.cs    2023-03-31   1225

Add inteface named as ISP_Call.cs  inside IRepository.cs    2023-03-31   1227

Add SP_Call.cs inside Repository folder   2023-03-31      1232

Modify the SP_Call.cs file    2023-03-31   1239

Add I UnitOfWork.cs interface inside Irepository folder     2023-03-31   1242

Forget to add migration file name that is why adding now 
Migration files name :     20230324193704_AddDefaultIdentityMigration
                           20230331153748_AddCategoryToDb.cs

Facing an error in Startup.cs   
services.AddScoped<UnitOfWork, UnitOfWork>();  in line 36 . 
if i am using <IUnitOfWork> in place of UnitOfWork is is showing me an error that is why uanble to complete Part #2 of Assignment #2
pause project part #2 at 2023-03-31    1515  

**********Start again ***************      2023-03-31        1835
Add these two following statements inside UnitOfWork.cs  and this error services.AddScoped<UnitOfWork, UnitOfWork>();   in line 36 is solve.
using KusumlataBooks.DataAccess.Repository.IRepository;
using KusumlataBookStore.DataAccess.Data;                

Error is solved so pause project again  2023-03-31      1841

*************Start Project again remaining part of Part #2**************       2023-04-06   1417

Add CategoryController.cs   inside  Areas/Admin/Controllers folder       2023-04-06     1440

Modify the CategoryController.cs file by adding code

Add Category folder inside Areas/Admin/Views         2023-04-06     1500
Then Add Index.cshtml  inside Category folder

Add <a class="nav-link" asp-area="Admin" asp-controller="Category" asp-action="Index">Category</a> in line 29  in _Layout.cshtml   2023-04-06   1542
Undo the above line 217 in _Layout.cshtml

Replecae <a class="dropdown-item" href="#">Action</a>  with <a class="dropdown-item" asp-area="Admin" asp-controller="Category" asp-action="Index">Category</a>  in line 39

Facing an error When I am trying to run my project  . My index.cshtml data is not displaying when i am clicking on Category Nav.


*****************Start Project Again from starting********************     2023-04-06      1940

Reason of starting project again: because i am unable to see my Index.cshtml data while Clicking on Category Nav


