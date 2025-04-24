# GHAS-Experiments

## Overview
GHAS-Experiments is a C# .NET web application designed to demonstrate best practices in web development, including the use of MVC architecture, Razor views, and unit testing with NUnit. This project serves as a learning tool for developers looking to understand the structure and components of a modern web application.

## Features
- MVC Architecture: The application follows the Model-View-Controller pattern, separating concerns for better maintainability.
- Razor Views: Dynamic HTML generation using Razor syntax for rendering views.
- Unit Testing: Comprehensive unit tests using NUnit to ensure code reliability and functionality.
- Integration Testing: Tests that verify the interaction between different components of the application.

## Project Structure
```
GHAS-Experiments
├── GHAS-Experiments
│   ├── Controllers
│   │   └── HomeController.cs
│   ├── Models
│   │   └── SampleModel.cs
│   ├── Views
│   │   ├── Home
│   │   │   └── Index.cshtml
│   │   └── Shared
│   │       └── _Layout.cshtml
│   ├── wwwroot
│   │   ├── css
│   │   │   └── site.css
│   │   ├── js
│   │   │   └── site.js
│   │   └── lib
│   ├── appsettings.json
│   ├── Program.cs
│   └── Startup.cs
├── GHAS-Experiments.Tests
│   ├── UnitTests
│   │   └── HomeControllerTests.cs
│   ├── IntegrationTests
│   │   └── SampleIntegrationTest.cs
│   └── GHAS-Experiments.Tests.csproj
├── GHAS-Experiments.sln
└── README.md
```

## Getting Started

### Prerequisites
- .NET SDK (version 6.0 or later)
- A code editor (e.g., Visual Studio Code)
- NUnit Test Adapter (for running tests)

### Installation
1. Clone the repository:
   ```
   git clone https://github.com/yourusername/GHAS-Experiments.git
   ```
2. Navigate to the project directory:
   ```
   cd GHAS-Experiments/GHAS-Experiments
   ```
3. Restore the dependencies:
   ```
   dotnet restore
   ```

### Running the Application
To run the application, use the following command:
```
dotnet run
```
The application will be available at `http://localhost:5000`.

### Running Tests
To run the unit tests, navigate to the test project directory and execute:
```
dotnet test
```

## Contributing
Contributions are welcome! Please feel free to submit a pull request or open an issue for any suggestions or improvements.

## License
This project is licensed under the MIT License. See the LICENSE file for details.