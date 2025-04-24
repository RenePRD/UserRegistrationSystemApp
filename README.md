# UserRegistrationSystemApp

A modular console-based user registration system built in **C#** using **.NET**. This project demonstrates clean architectural separation, file-based persistence, custom exception handling, and test-driven development using **NUnit** and **Moq**.

---

##  Technologies Used

- **Language**: C#
- **Framework**: .NET Console App
- **Testing**: [NUnit](https://nunit.org/), [Moq](https://github.com/moq/moq4)
- **Storage**: File-based (`users.txt`)
- **Design**: Interface-based modular architecture
- **IDE**: Visual Studio or Visual Studio Code

---

##  Features

- Console-driven user registration
- Prevents duplicate usernames with a custom `UserRegistrationException`
- Role-based registration (`ADMIN`, `USER`, `NONE`)
- File-based read/write using delimited text
- Interface-driven design (`IReadCommand`, `IWriteCommand`, `IInstance`, `IUser`)
- Unit tested with mocked dependencies

---

##  Solution Structure
UserRegistrationSystemApp.sln # Visual Studio solution file

├── ClientConsoleApp # Console entry point for running the app │ ├── ClientConsoleApp.csproj │ └── Program.cs

├── UserRegistrationSystem # Core business logic and models │ ├── Data/ │ │ └── users.txt # File-based storage for registered users │ ├── FileReadRegisteredUser.cs # Reads user data from text file │ ├── FileWriteRegisteredUser.cs # Writes user data to text file │ ├── IInstance.cs # Interface for factory pattern │ ├── IReadCommand.cs # Interface for read operations │ ├── IUser.cs # Interface for user abstraction │ ├── IWriteCommand.cs # Interface for write operations │ ├── RegisteredUsersFileUtility.cs │ ├── Role.cs # Enum for user roles (ADMIN, USER, NONE) │ ├── User.cs # User model │ ├── UserFactory.cs # Factory for creating user instances │ ├── UserRegistrationController.cs # Main controller for registration flow │ ├── UserRegistrationException.cs # Custom exception for registration errors │ └── UserRegistrationSystem.csproj

├── UserRegistrationSystem.UnitTests # NUnit and Moq test project │ ├── UserFactoryTest.cs │ ├── UserRegistrationControllerTest.cs │ └── UserRegistrationSystem.UnitTests.csproj

├── UserRegistrationSystemApp # Optional wrapper or launcher project │ ├── Program.cs │ └── UserRegistrationSystemApp.csproj

├── .gitignore ├── .gitattributes └── README.md


---

##  How to Run

1. Clone the repository
2. Open `UserRegistrationSystemApp.sln` in Visual Studio
3. Set `ClientConsoleApp` or `UserRegistrationSystemApp` as the startup project
4. Run the app — registered users will be written to `users.txt`

---

##  Running Tests

You can run tests through:
- Visual Studio Test Explorer
- CLI: `dotnet test UserRegistrationSystem.UnitTests/UserRegistrationSystem.UnitTests.csproj`








