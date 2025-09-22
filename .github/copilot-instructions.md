# .NET Hackathon Web API

This is a .NET 9.0 Web API project implementing a simple weather forecast service with OpenAPI documentation. The project follows standard ASP.NET Core minimal API patterns.

Always reference these instructions first and fallback to search or bash commands only when you encounter unexpected information that does not match the info here.

## Working Effectively

### Prerequisites and Setup
- Install .NET 9.0 SDK (Required for this project):
  ```bash
  curl -sSL https://dot.net/v1/dotnet-install.sh | bash /dev/stdin --version 9.0.101
  export PATH="$HOME/.dotnet:$PATH"
  ```
- Verify installation: `dotnet --version` should show 9.0.101 or later
- The project targets .NET 9.0 and will NOT build with earlier versions

### Bootstrap, Build, and Test
- Clean build from scratch:
  ```bash
  cd WebApi
  export PATH="$HOME/.dotnet:$PATH"
  dotnet clean
  dotnet build
  ```
- Build time: ~2 seconds. NEVER CANCEL. Set timeout to 60+ seconds minimum.
- Test the project: `dotnet test` (No tests currently exist - runs in ~1 second)
- Run the application:
  ```bash
  cd WebApi
  export PATH="$HOME/.dotnet:$PATH"
  dotnet run
  ```
- Application startup time: ~2 seconds. NEVER CANCEL.

### Application Details
- Default HTTP URL: `http://localhost:5079`
- Default HTTPS URL: `https://localhost:7228` (also available but HTTP is sufficient for development)
- Main API endpoint: `GET /weatherforecast` - Returns array of weather forecast data
- OpenAPI documentation: `GET /openapi/v1.json` - Returns OpenAPI specification
- Application shuts down with Ctrl+C

## Validation
- Always manually validate changes by testing the API endpoints after making code changes:
  1. Start the application: `cd WebApi && export PATH="$HOME/.dotnet:$PATH" && dotnet run`
  2. Test the weather forecast endpoint: `curl http://localhost:5079/weatherforecast`
  3. Expected response: JSON array with 5 weather forecast objects containing date, temperatureC, temperatureF, and summary fields
  4. Test OpenAPI endpoint: `curl http://localhost:5079/openapi/v1.json`
  5. Expected response: Valid OpenAPI 3.0.1 specification JSON
  6. Stop the application with Ctrl+C
- ALWAYS run through at least one complete end-to-end scenario after making changes.
- No linting tools are currently configured - basic C# compilation errors will be caught by `dotnet build`

## Repository Structure
```
/
├── Readme.md              # Basic project description
├── WebApi/                # Main Web API project
│   ├── Program.cs         # Application entry point with minimal API configuration
│   ├── WebApi.csproj      # Project file (targets .NET 9.0)
│   ├── WebApi.http        # HTTP test file for development
│   ├── Properties/
│   │   └── launchSettings.json  # Development server configuration
│   └── appsettings*.json  # Application configuration files
```

## Common Tasks

### Key Project Information
- **Main project**: WebApi - ASP.NET Core minimal API
- **Target framework**: .NET 9.0
- **Dependencies**: Microsoft.AspNetCore.OpenApi 9.0.8
- **Development environment**: Runs on HTTP (port 5079) and HTTPS (port 7228)

### Making Code Changes
- Primary code file: `WebApi/Program.cs` - Contains all application logic
- Configuration: `WebApi/appsettings.json` and `WebApi/appsettings.Development.json`
- Project configuration: `WebApi/WebApi.csproj`
- Always run `dotnet build` after making changes to verify compilation
- Always test the `/weatherforecast` endpoint after changes to verify functionality

### Frequently Referenced Files
The following are outputs from frequently run commands. Reference them instead of viewing, searching, or running bash commands to save time.

#### Repository Root Contents
```
$ ls -la
total 20
drwxr-xr-x 4 runner runner 4096 Sep 22 06:41 .
drwxr-xr-x 3 runner runner 4096 Sep 22 06:40 ..
drwxrwxr-x 7 runner runner 4096 Sep 22 06:41 .git
-rw-rw-r-- 1 runner runner   14 Sep 22 06:41 Readme.md
drwxrwxr-x 5 runner runner 4096 Sep 22 06:43 WebApi
```

#### WebApi Directory Contents
```
$ ls -la WebApi/
Program.cs                  # Main application file
Properties/                 # Launch settings
WebApi.csproj              # Project configuration
WebApi.http               # HTTP test requests
appsettings.Development.json
appsettings.json
obj/                      # Build artifacts (ignored by git)
bin/                      # Build outputs (ignored by git)
```

#### Sample API Response
```bash
$ curl http://localhost:5079/weatherforecast
[
  {"date":"2025-09-23","temperatureC":27,"summary":"Mild","temperatureF":80},
  {"date":"2025-09-24","temperatureC":-11,"summary":"Bracing","temperatureF":13},
  {"date":"2025-09-25","temperatureC":5,"summary":"Sweltering","temperatureF":40},
  {"date":"2025-09-26","temperatureC":48,"summary":"Warm","temperatureF":118},
  {"date":"2025-09-27","temperatureC":21,"summary":"Hot","temperatureF":69}
]
```

## Build and Timing Expectations
- **Clean build**: 1-2 seconds. Set timeout to 60+ seconds.
- **Incremental build**: < 1 second. Set timeout to 30+ seconds.
- **Application startup**: 1-2 seconds. Set timeout to 30+ seconds.
- **Tests**: < 1 second (no tests exist currently). Set timeout to 30+ seconds.
- NEVER CANCEL any build or run operation - always wait for completion
- If operations appear to hang, wait at least 60 seconds before investigating

## Troubleshooting
- If build fails with "does not support targeting .NET 9.0", verify .NET 9.0 SDK is installed and PATH is set correctly
- If application fails to start, check that ports 5079 and 7228 are available
- If API returns errors, check application logs in the console where `dotnet run` was executed
- Always ensure you're in the WebApi directory when running `dotnet` commands