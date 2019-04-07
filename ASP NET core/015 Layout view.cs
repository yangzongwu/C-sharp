//========================================Layout view================================================================
/*
Layout view in asp.net core mvc
>Consistent look an behaviour for all the views in a web application
>similar to master page in ASP.NET Web Forms
>File on the file system with .cshtml extension
>Default name is _Layout.cshtml
>Usually placed in Views/Shared folder
>An application can have multiple layout views

Creating a Layout View 
Right click on "Views" folder and add "Shared" folder.
Right click on "Shared" folder and select "Add" - "New Item"
In the "Add New Item" window search for Layout 
Select "Razor Layout" and click the "Add" button
A file with name _Layout.cshtml will be added to the "Shared" folder
*/

//-------------------------project/Views/Shared/_Layout.cshtml----------------------
<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>@ViewBag.Title</title>
</head>
<body>
    <div>
        @RenderBody()
    </div>
</body>
</html>



//-------------------------project/Views/Home/Details.cshtml----------------------
@model EmployeeManagement.ViewModels.HomeDetailsViewModel

@{
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.Title= "Employee Details";
}

<h3>@Model.PageTitle</h3>

<div>
    Name: @Model.Employee.Name
</div>
<div>
    Email: @Model.Employee.Email
</div>
<div>
    Department: @Model.Employee.Department
</div>


//-------------------------project/Views/Home/Index.cshtml----------------------
@model IEnumerable<EmployeeManagement.Models.Employee>

@{ 
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.Title= "Employee List";
}

<table>
    <thead>
        <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Department</th>
        </tr>
    </thead>
    <tbody>
        @foreach (var employee in Model)
        {
            <tr>
                <td>@employee.Id</td>
                <td>@employee.Name</td>
                <td>@employee.Department</td>
            </tr>
        }
    </tbody>
</table>



//=========================Sections in layout page================================================================
/*
>A section in a Layout View provides a way to organize where certain page elements should be placed
>A section can be optional or mandatory
>A section in the layout view is rendered at the location where RenderSection() method is called
*/

//add project/wwwroot/js/CustomScript.js
// we only want to add js to details.html
//-------------------------project/Views/Shared/_Layout.cshtml----------------------
<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>@ViewBag.Title</title>
</head>
<body>
    <div>
        @RenderBody()
    </div>
    @if (IsSectionDefined("Scripts"))
    {
        @RenderSection("Scripts", required: true)
    }

</body>
</html>

//-------------------------project/Views/Home/Details.cshtml----------------------
@model EmployeeManagement.ViewModels.HomeDetailsViewModel

@{
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.Title= "Employee Details";
}

<h3>@Model.PageTitle</h3>

<div>
    Name: @Model.Employee.Name
</div>
<div>
    Email: @Model.Employee.Email
</div>
<div>
    Department: @Model.Employee.Department
</div>

@section Scripts{ 
<script src="~/js/CustomScript.js"></script>
}


//-------------------------project/Views/Home/Index.cshtml----------------------
@model IEnumerable<EmployeeManagement.Models.Employee>

@{ 
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.Title= "Employee List";
}

<table>
    <thead>
        <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Department</th>
        </tr>
    </thead>
    <tbody>
        @foreach (var employee in Model)
        {
            <tr>
                <td>@employee.Id</td>
                <td>@employee.Name</td>
                <td>@employee.Department</td>
            </tr>
        }
    </tbody>
</table>

//===================================================ViewStart cshtml=================================================
/*
The above each html have import _Layout, so if we want to change _Layout, we need to change every html?

_ViewStart
>Code in ViewStart is executed before the code in an individual view
>Move the common code such as setting the Layout property to ViewStart
>ViewStart reduces code redundancy and improves maintainability
>ViewStart file is hierarchical
*/


//under views we create _ViewStart.cshtml
//------------------------------------prject/views/_ViewStart.cshtml-----------------------------------------
@{
    Layout = "_Layout";
}

// or we also can do some logic as the following
@{
    if (User.IsInRole("Admin"))
    {
        Layout = "_AdminLayout";
    }
    else
    {
        Layout = "_NonAdminLayout";
    }
}
//-------------------------project/Views/Home/Details.cshtml----------------------
@model EmployeeManagement.ViewModels.HomeDetailsViewModel

@{
    <!--Layout = "~/Views/Shared/_Layout.cshtml";-->  // no need here
    ViewBag.Title= "Employee Details";
}

<h3>@Model.PageTitle</h3>

<div>
    Name: @Model.Employee.Name
</div>
<div>
    Email: @Model.Employee.Email
</div>
<div>
    Department: @Model.Employee.Department
</div>

@section Scripts{ 
<script src="~/js/CustomScript.js"></script>
}


//-------------------------project/Views/Home/Index.cshtml----------------------
@model IEnumerable<EmployeeManagement.Models.Employee>

@{ 
    <!--Layout = "~/Views/Shared/_Layout.cshtml";-->  // no need here
    Layout = "_Layout2"; // or Layout = "null";   this will overwrite the Layout under  prject/views/_ViewStart.cshtml
    ViewBag.Title= "Employee List";
}

<table>
    <thead>
        <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Department</th>
        </tr>
    </thead>
    <tbody>
        @foreach (var employee in Model)
        {
            <tr>
                <td>@employee.Id</td>
                <td>@employee.Name</td>
                <td>@employee.Department</td>
            </tr>
        }
    </tbody>
</table>

//--------prject/views/Home/_ViewStart.cshtml----------------
//this will overwrite the prject/views/_ViewStart.cshtml



//=========================================ViewImports cshtml=======================================================
/*
>_ViewImports file is placed in teh Views folder
>Used to include the common namespaces
>To include the common namespaces use @using directive
>other supported directives
  @addTagHelper
  @removeTagHelper
  @tagHelperPrefix
  @model
  @inherits
  @inject
>_ViewImports file is hierarchical(分级 that means can be overwrite)
*/



//------------------------------------prject/views/_ViewImports.cshtml-----------------------------------------
@using EmployeeManagement.ViewModels;
@using EmployeeManagement.Models;


//-------------------------project/Views/Home/Details.cshtml----------------------
//@model EmployeeManagement.ViewModels.HomeDetailsViewModel
@model HomeDetailsViewModel

@{
    <!--Layout = "~/Views/Shared/_Layout.cshtml";-->  // no need here
    ViewBag.Title= "Employee Details";
}

<h3>@Model.PageTitle</h3>

<div>
    Name: @Model.Employee.Name
</div>
<div>
    Email: @Model.Employee.Email
</div>
<div>
    Department: @Model.Employee.Department
</div>

@section Scripts{ 
<script src="~/js/CustomScript.js"></script>
}


//-------------------------project/Views/Home/Index.cshtml----------------------
//@model IEnumerable<EmployeeManagement.Models.Employee>
@model IEnumerable<Employee>

@{ 
    <!--Layout = "~/Views/Shared/_Layout.cshtml";-->  // no need here
    Layout = "_Layout2"; // or Layout = "null";   this will overwrite the Layout under  prject/views/_ViewStart.cshtml
    ViewBag.Title= "Employee List";
}

<table>
    <thead>
        <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Department</th>
        </tr>
    </thead>
    <tbody>
        @foreach (var employee in Model)
        {
            <tr>
                <td>@employee.Id</td>
                <td>@employee.Name</td>
                <td>@employee.Department</td>
            </tr>
        }
    </tbody>
</table>
