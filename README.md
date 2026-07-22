<div align="center">

# 🛒 Trendora - E-Commerce Platform

### Production-Oriented Full Stack E-Commerce System

Built with **ASP.NET Core Web API**, **Angular**, **SQL Server**, **Redis**, and **Clean Architecture**

[![.NET](https://img.shields.io/badge/.NET-9-512BD4?style=for-the-badge&logo=dotnet)]()
[![Angular](https://img.shields.io/badge/Angular-20-DD0031?style=for-the-badge&logo=angular)]()
[![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge&logo=microsoftsqlserver)]()
[![Redis](https://img.shields.io/badge/Redis-D92C20?style=for-the-badge&logo=redis)]()
[![JWT](https://img.shields.io/badge/JWT-Authentication-success?style=for-the-badge)]()
[![Clean Architecture](https://img.shields.io/badge/Clean-Architecture-blue?style=for-the-badge)]()

</div>

---

# 🌐 Live Demo

### Frontend

👉 https://e-commerce-trendora.vercel.app/home

---

# 📂 Repositories

### Backend

https://github.com/ahmed-khalid2004/E-Commerce_API

### Frontend

https://github.com/Mostafa-Elabsawy/E-commerce_Trendora

---

# 📖 About

Trendora is a complete **Full Stack E-Commerce Platform** developed as a graduation project.

Although the DEPI track focused on **Angular Front-End Development**, our team decided to build an entire production-oriented system including both frontend and backend.

The backend is developed using **ASP.NET Core Web API** following **Clean Architecture**, while the frontend is built using **Angular**.

The project demonstrates how a real-world E-Commerce platform can be designed with scalable architecture, secure authentication, efficient database design, caching, and dashboard analytics.

---

# ✨ Features

## 🔐 Authentication

- User Registration
- Login
- JWT Authentication
- Bearer Authorization
- Role-Based Authorization
- Forgot Password
- OTP Verification
- Reset Password
- User Profile
- Address Management

---

## 🛍 Products

- Browse Products
- Product Details
- Search
- Filtering
- Sorting
- Pagination
- Product Reviews
- Product Ratings

---

## 📂 Categories

- Categories
- SubCategories
- Product Brands

Database Structure

```
Category
    │
    └──── SubCategory
              │
              └──── Products
```

---

## ⭐ Reviews

- Product Reviews
- Threaded Replies
- Ratings
- Nested Comments

---

## 🛒 Shopping Cart

Implemented using **Redis (Upstash)**

Supports

- Add Item
- Remove Item
- Update Quantity
- Basket Persistence

---

## 📦 Orders

- Checkout
- Delivery Methods
- Shipping Address
- Order History
- Order Details
- Payment Integration Ready

Uses the **Snapshot Pattern** to preserve product information after purchase.

---

## 📊 Admin Dashboard

Includes

- Dashboard KPIs
- Recent Orders
- Top Products
- Customer Statistics
- Revenue Overview
- Product Management
- Order Management

---

# 🏗 Architecture

The project follows **Clean Architecture**.

```
Presentation Layer

        │

ASP.NET Core API

        │

──────────────────────────

Application Layer

Domain Layer

Infrastructure Layer

Persistence Layer

        │

SQL Server        Redis
```

Benefits

- Separation of Concerns
- Maintainability
- Testability
- Scalability
- Dependency Injection

---

# 🗄 Database Design

The application uses **two SQL Server schemas** inside the same database.

## dbo

Contains business data

- Products
- Categories
- SubCategories
- Brands
- Orders
- OrderItems
- Reviews
- Delivery Methods

---

## identity

Contains authentication data

- Users
- Roles
- UserRoles
- Addresses

This separation keeps authentication isolated from business logic while still sharing the same SQL Server database.

---

# 🔑 Authentication Flow

```
Register

↓

Login

↓

JWT Token

↓

Bearer Authentication

↓

Protected APIs

↓

Admin / Customer
```

Current Token Lifetime

```
24 Hours
```

---

# ⚡ Redis Usage

Redis is used for

- Shopping Basket
- OTP Verification
- Password Reset Sessions
- API Response Caching

---

# 📦 API Modules

| Module | Status |
|----------|--------|
| Authentication | ✅ |
| Products | ✅ |
| Categories | ✅ |
| Brands | ✅ |
| Reviews | ✅ |
| Basket | ✅ |
| Orders | ✅ |
| Dashboard | ✅ |
| Delivery Methods | ✅ |

---

# 🛠 Tech Stack

### Backend

- ASP.NET Core Web API
- C#
- Entity Framework Core
- SQL Server
- ASP.NET Identity
- JWT
- AutoMapper
- Redis (Upstash)
- Swagger

### Architecture

- Clean Architecture
- Repository Pattern
- Specification Pattern
- Dependency Injection

### Frontend

- Angular
- TypeScript
- RxJS
- Tailwind CSS
- Angular Router

---

# 📂 Project Structure

```
src

│

├── API

├── Domain

├── Persistence

├── Service

├── ServiceAbstraction

├── Shared
```

---

# 🚀 Running the Project

Clone repository

```bash
git clone https://github.com/ahmed-khalid2004/E-Commerce_API.git
```

Restore packages

```bash
dotnet restore
```

Apply migrations

```bash
Update-Database
```

or

```bash
dotnet ef database update
```

Run

```bash
dotnet run
```

Swagger

```
https://localhost:{PORT}/swagger
```

---

# ⚙ Configuration

Configure

- SQL Server Connection String
- JWT Settings
- Redis
- Email Settings
- Allowed Origins

inside

```
appsettings.Development.json
```

---

# 📸 Screenshots

You can add

- Home Page
- Products
- Product Details
- Shopping Cart
- Checkout
- Dashboard
- Swagger
- Database ERD

---

# 👨‍💻 Team

- **Mostafa Ehab Abd Elhakim** *(Team Leader)*
- **Ahmed Khaled Ahmed**
- **Mahmoud Gamal Farouk**
- **Mohamed Ahmed Ali**
- **Mohammed Magdy Abdelkareem**

---

# 🙏 Acknowledgments

Special thanks to

- **Digital Egypt Pioneers Initiative (DEPI)**
- **YAT Learning Solutions**
- **Eng. Hesham Mohamed**
- **Eng. Ahmed Ashraf**

for their continuous support and guidance throughout this journey.

---

# ⭐ Support

If you found this project useful,

please consider giving the repository a **Star ⭐**.

It helps support the project and motivates further improvements.
