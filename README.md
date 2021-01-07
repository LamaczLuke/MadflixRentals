# Madflix

Minimalist application built with ASP.NET Core Web Application. Using Project templates for creating ASP.NET applications.

### Live example

https://madflixrental.azurewebsites.net/

### How to start

Just start and enjoy via https://madflixrental.azurewebsites.net/

```

Project has separated database in Azure SQL Database. Check out \Madflix\Web.config

### Example of web.config file

   name="DefaultConnection" 
   connectionString="Data Source=tcp:madflixdbserver.database.windows.net,1433;Initial Catalog=Madflix_db;User Id=*@*;Password=***" 
   providerName="System.Data.SqlClient" 


You can save this project and open .sln file with your Visual Studio.

Project uses this dlls and modules:

"AutoMapper" version="4.1.0"
"bootbox" version="4.3.0"
"bootstrap" version="3.4.1"
"jquery.datatables" version="1.10.11"
"toastr" version="2.1.1"
"Twitter.Typeahead" version="0.11.1"
"toastr" version="2.1.1"


```
### License

This project is licensed under the LLStudio


## Description
Application is used for rental store. There are three areas on a navigation bar: Customers, Movies and Rentals. You can log in as an admin or as a quest, credential details are provided in login page. Difference between admin and guest account is that admin can manage movies database, is able to add, update and delete movies. If you log in as a quest you can only view movies from database.

### Customers
On Customers page, there is a rendered table using jquery.datatables NuGet package with list of all items from customers table in db with their respective subsciption type loaded from referenced MembershipTypes table. You can create, edit or delete a customer from this page. If you choose to delete customer there is a custom bootbox confirmation message. Delete action is performed using AJAX with API call DELETE method. For adding and edditing customer, you are redirected to 'CustomerForm' view. On this view, there is a custom validation rule 'Min18YearsIfAMember' as well as other validations for required fields. This view has enabled server side validation.
 

### Movies
On a Movies page, there is a rendered table using jquery.datatables NuGet package with list of all items from movies table in db with their respective genre loaded from referenced Genres table. As an admin you can create, edit or delete a movie from this page. If you choose to delete movie there is a custom bootbox confirmation message. Delete action is performed using AJAX with API call DELETE method. For adding and edditing movie, you are redirected to 'MovieForm' view. On this view, there are validations for required fields. If you are logged in as a quest, you will be redirected to the 'ReadOnlyView' with listed data, from where you can only preview details of selected movie. This view has enabled server side validation.

   
### Rentals
On New Rental page, there is a view 'New' for creating a new rental. Fields customer and movie have an autocomplete function. This fucntion is provided using Twitter.Typeahead NuGet package and defined usign java script. It helps user to select valid customer and movie. Multiple movies can be selected and after submiting request, availability of particular movie in database is decreased. There is a custom 'toastr' confirmation message. All calls to the server on this view are through API using AJAX.

