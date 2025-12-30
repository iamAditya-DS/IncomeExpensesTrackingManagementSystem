# 💰 Income & Expenses Tracking Management System

![Build Status](https://github.com/iamAditya-DS/IncomeExpensesTrackingManagementSystem/actions/workflows/main.yml/badge.svg)

Expense Tracker project used to demonstrate CI/CD pipeline implementation.

## 🚀 Overview
The **Income & Expenses Tracking Management System** is a professional financial management tool built with **C#**. It allows users to manage their personal finances by tracking daily income and expenditures while maintaining a high standard of code quality through automated build pipelines.

## ✨ Key Features
* **Comprehensive Tracking**: Manage and categorize daily financial transactions.
* **Automated CI/CD**: A fully integrated GitHub Actions workflow ensures the code builds successfully on every push.
* **Windows Environment Simulation**: Tests are run on a `windows-latest` environment to ensure native compatibility for the .NET application.
* **NuGet Reliability**: The pipeline includes specific steps to restore both modern and legacy NuGet packages for stable builds.

## 🛠️ Tech Stack
* **Language**: C#
* **Framework**: .NET
* **DevOps**: GitHub Actions (Continuous Integration)

## 🛡️ CI/CD Implementation
This project utilizes a custom GitHub Actions workflow (`main.yml`) that automates the verification process:
1.  **Virtualization**: Provisions a Windows-based runner (`windows-latest`).
2.  **SDK Configuration**: Sets up the **.NET 6.0.x** runtime environment.
3.  **Dependency Restoration**: Runs `dotnet restore` and `nuget restore` to prepare the environment.
4.  **Compilation Check**: Executes `dotnet build` to verify that the application is ready for deployment.

## ⚙️ Local Setup

1. **Clone the repository**:
   ```bash
   git clone [https://github.com/iamAditya-DS/IncomeExpensesTrackingManagementSystem.git](https://github.com/iamAditya-DS/IncomeExpensesTrackingManagementSystem.git)

2. **Open the Project**:
    ### Locate and open the 'IncomeExpensesTrackingManagementSystem.sln' file in Visual Studio.

3. **Build and Run**:
    ### Use 'Ctrl + Shift + B' to restore NuGet packages and build.
    ### Press 'F5' to start the application.
