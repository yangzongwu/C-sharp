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
