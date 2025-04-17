# FreelancerDirectory
@GET, @POST, @PUT, @DELETE


# Freelancer Directory
A simple web-based directory for managing freelancers using **ASP.NET Core Web API** with an **HTML + JavaScript frontend**. This project allows users to register, update, list, and delete freelancer profiles.

## 📦 Features
- Register a new freelancer
- Edit existing freelancer details
- View all registered freelancers
- Delete freelancers
- Backend: ASP.NET Core Web API + In-Memory Database
- Frontend: HTML + JavaScript

## 🛠️ Tech Stack
- ASP.NET Core 7 Web API
- Entity Framework Core (In-Memory)
- HTML, JavaScript 
- Swagger (API Testing)

## 🚀 Getting Started
### 1. Clone the repo

2. Run the API
In Visual Studio or via terminal:
dotnet run

The backend will start at:
https://localhost:5001
Make sure HTTPS is enabled.
3. Open the Frontend
After running the backend, open:
https://localhost:44370/index.html

Method	Endpoint	Description
GET	/api/freelancerdirectory/all	Get all users
GET	/api/freelancerdirectory/{id}	Get user by ID
POST	/api/freelancerdirectory	Create or update user
DELETE	/api/freelancerdirectory/{id}	Delete user by ID

Test the API in Swagger:
https://localhost:44370/swagger/index.html

💡 Notes
•	The project uses an in-memory database, so all data is lost when the app stops.
•	To simulate a real database, switch to SQL Server or SQLite in Program.cs.

