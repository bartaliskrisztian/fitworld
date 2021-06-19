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

### Entries page

Here the admin can see all client's entries, and the client user can see his/her recent entries.

<table>
  <tr>
    <td>Admin</td>
     <td>Client</td>
  </tr>
  <tr>
    <td><img src="readme_images/entries_admin.png" alt="entries page of admin" height="200" width="450"/></td>
    <td><img src="readme_images/my_entries.png" alt="entries page of client" height="200" width="450"/></td>
  </tr>
 </table>
 
 ### Gyms page
 
 Here the admin and the clients can see the gyms, the admin can add and delete gyms.
 
 <table>
  <tr>
    <td>Admin</td>
     <td>Client</td>
  </tr>
  <tr>
    <td><img src="readme_images/gym_admin.png" alt="gyms page of admin" height="200" width="450"/></td>
    <td><img src="readme_images/gym_client.png" alt="gyms page of client" height="200" width="450"/></td>
  </tr>
 </table>
