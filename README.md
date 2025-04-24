# UserRegistrationSystemApp

A console-based user registration system built with **C# and .NET**, featuring file-based persistence, role support, and unit testing using **NUnit and Moq**. The project follows object-oriented principles and dependency injection to make the codebase modular and testable.

---

## Technologies Used

- **Language**: C#
- **Framework**: .NET Console Application
- **Testing**: [NUnit](https://nunit.org/), [Moq](https://github.com/moq/moq4)
- **Persistence**: File-based using `.txt` file
- **IDE**: Visual Studio / VS Code

---

## Features

- Register new users with username, password, and role
- Prevents duplicate usernames with a custom `UserRegistrationException`
- Persists user records in a `users.txt` file using a delimited format
- Dependency Injection used for testability (`IReadCommand`, `IWriteCommand`, `IInstance`)
- Unit tests using **NUnit** and **Moq**

---

## 🧪 Example Test Cases

- Throws exception when registering an existing username
- Registers new users and verifies factory usage
- Verifies user creation returns the correct type

---

## 🚀 Getting Started

1. Clone the repository
2. Open `UserRegistrationSystemApp.sln` in Visual Studio
3. Set `ClientConsoleApp` as the startup project
4. Run the console application
5. Run unit tests via Test Explorer or CLI (`dotnet test`)
