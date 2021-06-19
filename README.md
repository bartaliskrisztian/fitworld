# University project: Fitworld - web application for gym admins and clients

This is a web application written in C# (Blazor) where gym admins can manage gyms/memberships/clients/entries and clients can track their memberships and entries.

## About the project

* The UI is built on Blazor components
* The application uses a local mssql database
* There are two types of users: admins and clients

## Pages:

### Login page

Here the users can log in to their account, this page is the same for the admin and the client.

<img src="readme_images/login.png" alt="login page" height="400" width="900"/>

### Client entry page

Here the admin can entry the client with the client's barcode. First the admin have to choose between one of the client's memberships. If there is none, the admin can create one.

<img src="readme_images/client_entry.png" alt="client entry page" height="400" width="900"/>
