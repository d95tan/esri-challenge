# File Upload/Download API

This is a basic .NET Core API for uploading and downloading files using async/await and dependency injection.

## Setup

1. Clone the repo and navigate to question_3:

   ```bash
   cd question_3
   ```

2. Install dependencies:
   ```bash
   dotnet restore
   ```
3. Run the project:
   ```bash
   dotnet run
   ```
4. The app will be available at [http://localhost:5073]().

## Endpoints

- **Upload a file:**
  POST http://localhost:5073/File/upload
  (Send a multipart/form-data request with a file)
- **Download a file:**
  GET http://localhost:5073/File/download/{fileName}

## Testing with Swagger

Visit [http://localhost:5073/swagger]() to test the endpoints.

## Dev Notes:

#### `IFileService.cs` (Interface)

This interface defines the methods for uploading and downloading files


#### `FileService.cs` (Service Implementation)

This class handles the actual file operations


#### `FileController.cs` (Controller)

This controller exposes the API endpoints for file upload and download


#### `Program.cs` (Setting Up the App)

This is where everything gets registered and the app is set up
