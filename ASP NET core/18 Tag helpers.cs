//============================================how to use tag helper==================================================
/*
>Server side componenets
>Processed on the server to create and render HTML elements
>Similar to HTML helpers
>Built-in tag helpers-Generating links,creating forms,loading assets etc

Importing tag helpers
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
*/

//-----------------------------------Index.cshtml----------------------------------------------------------
/*
4 ways to linke to another link :
<a asp-controller="home" asp-action="details" asp-route-id="@employee.Id" class="btn btn-primary">Display</a>
<a href="@Url.Action("details", "home", new { id=employee.Id})" class="btn btn-primary">show</a>
@Html.ActionLink("View", "detalis", "home", new { id = employee.Id })
<a href="/home/details/@employee.Id" class="btn btn-primary">View</a>
*/
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
            <a asp-controller="home" asp-action="details" asp-route-id="@employee.Id" class="btn btn-primary">Display</a>
            <a href="@Url.Action("details", "home", new { id=employee.Id})" class="btn btn-primary">show</a>
            @Html.ActionLink("View", "detalis", "home", new { id = employee.Id })
            <a href="/home/details/@employee.Id" class="btn btn-primary">View</a>
        </div>
    </div>
    }
</div>


//-----------------------------------Details.cshtml----------------------------------------------------------
//change
<a href="#" class="btn btn-primary">Back</a>
//to
<a asp-controller="Home" asp-action="Index" class="btn btn-primary">Back</a>



//============================================why use tag helpers==================================================
//-------------------------------------Route Template------------------------------------------------------------
app.UseMvc(routes=>{
    routes.MapRoute("default", "{controller=home}/{action=index}/{id?}");
})

//tag helpers:
<a asp-controller="home" asp-action="details" asp-route-id="@employee.Id">Display</a>
<a href="/home/details/1">View</a>

//Manually generating links:
<a href="/home/details/@employee.Id">View</a>
<a href="/home/details/1">View</a>

//-------------------------------------Route Template------------------------------------------------------------
//when finish our project , we want to change our Route Template
app.UseMvc(routes=>{
    routes.MapRoute("default", "book/{controller=home}/{action=index}/{id?}");
})

//tag helpers:
<a asp-controller="home" asp-action="details" asp-route-id="@employee.Id">Display</a>
<a href="/book/home/details/1">View</a>  //this is good

//Manually generating links:
<a href="/home/details/@employee.Id">View</a>
<a href="/home/details/1">View</a> // this is not working


//===============================================Image tag helper============================================================
/*
Image Tag Helper enhances the <img>tag to provide cache-busting behaviour for static image files
<img src="~/images/noimage.jpg" asp-append-version="true" />
Based on the content of the image, a unique hash value is calculated and appended to image URL
<img class="card-img-top" src="/images/noimage.jpg?v=IqNLbsazJ7ijEbbyzWPke-xWxkOFaVcgzpQ4SsQKBqY" />
Eeach time the image on the server changed a new hash value is calculated and cached
*/
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
        <img class="card-img-top" src="~/images/DSC_0458.JPG" asp-append-version="true"/>
        <div class="card-footer text-center">
            <a asp-controller="home" asp-action="details" asp-route-id="@employee.Id" class="btn btn-primary">View</a>
            <a href="#" class="btn btn-primary">Edit</a>
            <a href="#" class="btn btn-danger">Delete</a>
        </div>
    </div>
    }
</div>


//==============================================Environment Tag Helper=========================================================
/*
The application environment name is set using ASPNATCORE_ENVIRONMENT variable
<environment include="Development">
    <link href="~/lib/bootstrap/css/bootstrap.css" rel="stylesheet" />
</environment>

Environment tag helper supports rendering different content depending on the application environment.
*/

//--------------------------include-----exclude-----------------------------------------------
<environment include="Staging,Production">
    <link rel="stylesheet"
            href="~/lib/bootstrap/css/bootstrap.css"
            integrity="sha384-ggOyR0iXCbMQv3Xipma34MD....">
</environment>

<environment exclude="Development">
    <link rel="stylesheet"
            href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"
            integrity="sha384-ggOyR0iXCbMQv3Xipma34D....">
</environment>
/*
The value of"include" and "exclude" attibute can be either a single hosting environment name or a comma-separated
list of hosting environmnet names

The "integrity" attribute on the <link> element is used for Subresource Integrity check
SRI is a security feature that allows a browser to check if the file being retrieved has been maliciously altered

Use asp-fallback-href attibute to specify a fallback source
Use asp-suppress-fallback-integrity attribute to turn off integrity check for files downloaded from fallback source
*/
<environment include="Development">
    <link href="~/lib/bootstrap/css/bootstrap.css" rel="stylesheet" />
</environment>
//if the href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"  is not working
//it shoud be back to "~/lib/bootstrap/css/bootstrap.min.css"
//to avoid page down
<environment exclude="Development">
    <link rel="stylesheet"
            href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" 
            integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" 
            crossorigin="anonymous"
            asp-fallback-href="~/lib/bootstrap/css/bootstrap.min.css"
            asp-fallback-test-class="sr-only" 
            asp-fallback-test-property="position"
            asp-fallback-test-value="absolute"
            asp-suppress-fallback-integrity="true" />
</environment>
//--------------------------------------------_Layout.cshtml-----------------------------------------------------
<!DOCTYPE html>
<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <environment include="Development">
        <link href="~/lib/bootstrap/css/bootstrap.css" rel="stylesheet" />
    </environment>
    <environment exclude=""="Development">
        <link rel="stylesheet" 
              href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" 
              integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" 
              crossorigin="anonymous"
              asp-fallback-href="~/lib/bootstrap/css/bootstrap.min.css"
              asp-fallback-test-class="sr-only" 
              asp-fallback-test-property="position"
              asp-fallback-test-value="absolute"
              asp-suppress-fallback-integrity="true">
    </environment>
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


