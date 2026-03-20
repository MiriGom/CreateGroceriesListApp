# Create Groceries List App

A full-stack application for managing user accounts in a groceries list application. Users can register accounts via a simple HTML frontend, with all data securely stored in a MySQL database. The backend is built with Spring Boot, providing RESTful APIs, and the frontend communicates with the backend using plain JavaScript `fetch()` calls.

---

## Table of Contents

- [Technologies](#technologies)  
- [Features](#features)  
- [Project Structure](#project-structure)  
- [Setup & Usage](#setup--usage)  
- [Future Improvements](#future-improvements)  
- [Author](#author)  

---

## Technologies

- **Backend:** Java, Spring Boot, Spring Web, JDBC  
- **Database:** MySQL  
- **Frontend:** HTML, CSS, JavaScript (no frameworks)  
- **Development Tools:** Maven, Postman, Visual Studio  

---

## Features

- RESTful API endpoints for user registration (`POST /users/register`)  
- Retrieve users (`GET /users/all`) for backend testing  
- Simple HTML + JS frontend form integrated with backend  
- Data stored securely in MySQL  
- Same-origin setup eliminates CORS issues by serving frontend via Spring Boot  

---

## Project Structure
creategrocerieslistapp-backend/
├─ src/main/java/com/groceries/creategrocerieslistapp_backend/
│ ├─ controller/ # REST controllers
│ ├─ model/ # User model
│ ├─ repository/ # Database access
│ └─ service/ # Business logic
├─ src/main/resources/static/
│ └─ index.html # Frontend registration form
└─ pom.xml # Maven dependencies and build


---

## Setup & Usage

1. **Start MySQL** and make sure your `users` table exists:

```sql
CREATE DATABASE IF NOT EXISTS groceries_app;
USE groceries_app;

CREATE TABLE IF NOT EXISTS users (
    id BIGINT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50) NOT NULL,
    email VARCHAR(100) NOT NULL,
    password VARCHAR(100) NOT NULL,
    role VARCHAR(20) DEFAULT 'USER',
    is_active BOOLEAN DEFAULT TRUE,
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP
);

Configure Spring Boot application.properties with your MySQL credentials:

spring.datasource.url=jdbc:mysql://localhost:3306/groceries_app
spring.datasource.username=root
spring.datasource.password=yourpassword
spring.datasource.driver-class-name=com.mysql.cj.jdbc.Driver
spring.jpa.hibernate.ddl-auto=update

Run Spring Boot Backend

mvn spring-boot:run

Backend runs on http://localhost:8080

Open Frontend in Browser

http://localhost:8080/index.html

Fill out the registration form to add a new user

Messages appear for success or errors

Verify new users in the MySQL users table

Future Improvements

Implement user authentication with login and JWT

Add a secure dashboard for users

Full CRUD functionality for grocery lists

Upgrade frontend to a modern framework (React, Angular, Vue)

Add unit and integration tests for backend APIs

Author

Miriam Gomez