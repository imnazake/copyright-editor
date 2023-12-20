#Copyright Editor

## Description

This repository contains a simple .NET Framework 4.8 WinForms application designed to update and manage copyright notices in source code files. The program allows users to:

1. **Find and Remove Existing Notices:**
   - Locate the first single-line or multi-line comment at the beginning of each file and remove it if it matches an existing copyright notice.

2. **Add New Copyright Notice:**
   - Optionally add a new copyright notice to the beginning of each file if no existing notice is found.

## Features

- **Regex-based Comment Detection:** Utilizes regular expressions to identify and manipulate comments in C# source code files.
- **Interactive User Interface:** Implemented using .NET WinForms, providing a straightforward and user-friendly interface.

## How to Use

1. Clone the repository to your local machine.
2. Open the solution in Visual Studio.
3. Build and run the application.
4. Enter the path to the target source code file.
5. Configure options such as finding existing notices and adding new notices.
6. Click the "Update Copyright Notice" button.

## Requirements

- .NET Framework 4.8 or later.
- Visual Studio (for development and testing).
