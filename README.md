# Bon Sucre Bakery Management System

A Windows Forms desktop application built with C# and .NET for managing bakery operations. This application provides full CRUD (Create, Read, Update, Delete) functionality for managing customers, bakery inventory, and user reviews.

## Features

* **Customer Management:** Add, view, update, and delete customer records. Includes data validation for names, emails, and birthdates.
* **Inventory Management:** Track bakery items, pricing, and categories.
* **Review System:** A relational tracking system for customer ratings on specific desserts, with dynamic UI updates for viewing aggregated data.
* **Data Integrity:** Safely handles complex database relationships, including automated sequential deletions to manage foreign key constraints and prevent orphaned records.
* **Architecture:** Implements the "Fat Model, Skinny Controller" design pattern to centralize business logic and validation rules within the models, keeping the UI layer clean.

## Tech Stack & Architecture

* **Language:** C#
* **Framework:** .NET (Windows Forms)
* **Database:** Microsoft SQL Server
* **Data Access:** ADO.NET (SqlConnection, SqlCommand, SqlDataReader)

### Design Patterns
* **Separation of Concerns (SoC):** Dedicated data access classes (`CustomerDB`, `DessertDB`, `ReviewDB`) isolate SQL queries from the presentation layer.
* **Data Transfer Objects (DTO):** Custom display classes (e.g., `ReviewDisplayItem`) flatten relational database queries for UI binding.
* **Centralized Configuration:** Database connection strings are handled via a single static configuration class (`DBConnection`).

## Setup & Installation

1. Clone the repository to your local machine.
2. Open the solution file (`.sln`) in Visual Studio.
3. Ensure Microsoft SQL Server is running locally.
4. Open `DBAccess/DBConnection.cs` and verify the `Data Source` in the connection string matches your local SQL Server instance name. 
   * *Note: The application expects a database named `BonSucre` to exist with `Customers`, `Desserts`, and `Reviews` tables.*
5. Build the solution to restore necessary packages.
6. Press `F5` or click Start to run the application.

## Author

Zac Kimball
