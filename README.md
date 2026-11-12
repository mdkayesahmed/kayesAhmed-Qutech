# QuTech Subscription Management System

A C# console-based subscription management application developed as part of **Lab Assessment 1**.

The application allows an administrator to view subscription plans, create customer subscriptions, apply discount codes, calculate monthly subscription fees, and display a summary of all subscriptions created during a session.

## Project Information

* **Project Name:** QuTech Subscription Management System
* **Developer:** Md. Kayes Ahmed
* **Language:** C#
* **Framework:** .NET
* **IDE:** Visual Studio 2022
* **Application Type:** Console Application

## Features

### 1. View Subscription Plans

The application provides four subscription plans:

| Plan       | Price per User/Month |
| ---------- | -------------------: |
| Startup    |               $10.00 |
| Standard   |               $20.00 |
| Premium    |               $30.00 |
| Enterprise |               $40.00 |

### 2. Create New Subscriptions

Administrators can create subscriptions by entering:

* Business name
* Subscription plan (1–4)
* Number of users (1–100)
* Optional discount code

The application automatically calculates the monthly subscription cost.

### 3. Discount System

A **15% discount** is applied when the correct discount code is entered.

**Discount Code:** `KAYE`

**Example:**

Standard Plan: $20 × 5 users = $100

15% Discount: $15

**Final Monthly Price: $85.00**

### 4. Input Validation

The application validates user input to prevent invalid entries.

* Business names cannot be empty.
* Subscription plans must be between 1 and 4.
* The number of users must be between 1 and 100.
* Non-numeric inputs are rejected where numbers are required.

### 5. Subscription Summary

Administrators can view all subscriptions created during the current session.

The summary displays:

* Business name
* Subscription plan
* Number of users
* Total monthly price
* Discount status

## Application Menu

```text
==========================
     Welcome to QuTech
==========================

Logged in as: Kayes Ahmed
Role: Administrator

A. View Subscription Plans
B. Create New Subscription
C. View Subscription Summary
D. Exit

Please select an option:
```

## Project Structure

```text
kayesAhmed-Qutech/
│
├── Program.cs
├── Subscription.cs
├── SubscriptionManager.cs
├── kayesAhmed-Qutech.csproj
└── README.md
```

**Program.cs** — Entry point of the application. Creates a `SubscriptionManager` object and starts the program.

**Subscription.cs** — Defines the `Subscription` class, its properties, and constructor.

**SubscriptionManager.cs** — Handles menu navigation, subscription creation, input validation, discount calculations, and subscription summaries.

## Technologies and Concepts Used

* C# programming
* .NET console applications
* Object-oriented programming (OOP)
* Classes and objects
* Constructors
* Properties
* Methods
* Conditional statements (`if/else`, `switch`)
* Loops (`while`, `foreach`)
* Lists (`List<Subscription>`)
* Input validation (`int.TryParse`)
* String manipulation
* Decimal calculations

## How to Run

1. Clone or download the repository.
2. Open the project in Visual Studio.
3. Open the solution file (`.sln` or `.slnx`) if available, or the `.csproj` file.
4. Build the project using `Ctrl + Shift + B`.
5. Run the application using `Ctrl + F5`.
6. Follow the on-screen menu instructions.

## Example Output

```text
===== SUBSCRIPTION DETAILS =====

Business: ABC Technologies
Plan: Standard
Number of Users: 5
Price per User: $20.00
Discount Applied: Yes
Total Monthly Price: $85.00

Subscription saved successfully!
```

### Subscription Summary

```text
========== SUBSCRIPTION SUMMARY ==========

Business             Plan         Users   Total        Discount
----------------------------------------------------------------------
ABC Technologies     Standard     5       $85.00       Yes
XYZ Company          Premium      10      $300.00      No
```

## Limitations

* The application uses in-memory storage.
* Subscription records are cleared when the application closes.
* The application does not currently use a database.
* The application is designed for a single administrator session.

## Learning Outcomes

This project demonstrates practical understanding of fundamental C# programming concepts, particularly object-oriented programming, input validation, conditional logic, collections, and console-based application development.

It also provides experience in organising code into separate classes and methods to improve readability and maintainability.


