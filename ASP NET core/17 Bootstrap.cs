/*
Library Manager-LibMan
Light-Wight,client fide library acquisition tool
Downloads from the file system or from a CDN
Visual Studio 2017 version 15.8 or later required
libman.json is the library manager manifest file
User GUI or libman.json file to manage client side packages
*/

/*
lib-->add-->client side library...-->we can add like twitter bootstrap
under project a new file libman.json
we can edite our import info. from here
*/

//------------------------libman.json-------------------------------------------
{
  "version": "1.0",
  "defaultProvider": "cdnjs",
  "libraries": [
    {
      "library": "twitter-bootstrap@4.3.1",
      "destination": "wwwroot/lib/bootstrap/"
    },
    {
      "library": "jquery@3.3.1",
      "destination": "wwwroot/lib/jquery/"
    }
  ]
}

// then change our cshtml document

//-----------------------------------------_Layout.cshtml----------------------------------
<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <link href="~/lib/bootstrap/css/bootstrap.css" rel="stylesheet" />
    <link href="~/css/site.css" rel="stylesheet" />
    <title>@ViewBag.Title</title>
</head>
<body>
    <div class="container">
        @RenderBody()
    </div>
    @if (IsSectionDefined("Scripts"))
    {
        @RenderSection("Scripts", required: true)
    }

</body>
</html>

//---------------------------------------------Details.cshtml----------------------------------------
@model HomeDetailsViewModel

@{
    ViewBag.Title= "Employee Details";
}

<div class="row justify-content-center m-3">
    <div class="col-sm-8">
        <div class="card">
            <div class="card-header">
                <h1>@Model.Employee.Name</h1>
            </div>

            <div class="card-body text-center">
                <img class="card-img-top" src="~/images/DSC_0459.JPG" />

                <h4>Employee ID : @Model.Employee.Id</h4>
                <h4>Email : @Model.Employee.Email</h4>
                <h4>Department : @Model.Employee.Department</h4>

            </div>
            <div class="card-footer text-center">
                <a href="#" class="btn btn-primary">Back</a>
                <a href="#" class="btn btn-primary">Edit</a>
                <a href="#" class="btn btn-danger">Delete</a>
            </div>
        </div>
    </div>
</div>

@section Scripts{ 
<script src="~/js/CustomScript.js"></script>
}

//------------------------------------------Index.cshtml------------------------------------------------
@model IEnumerable<Employee>

@{ 
    ViewBag.Title= "Employee List";
}

<div class="card-deck">
    @foreach (var employee in Model)
    {
    <div class="card m-3">
        <div class="card-header">
            <h3>@employee.Name</h3>
        </div>
        <img class="card-img-top" src="~/images/DSC_0458.JPG" />
        <div class="card-footer text-center">
            <a href="#" class="btn btn-primary">View</a>
            <a href="#" class="btn btn-primary">Edit</a>
            <a href="#" class="btn btn-danger">Delete</a>
        </div>
    </div>
    }
</div>


//-------------------------------------------------site.css------------------------------------------
//At last we can add our own css
//project/wwwroot/css/site.css
.btn{
    width:75px;
}
