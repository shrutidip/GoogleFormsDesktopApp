# GoogleFormsDesktopApp
Creating a Windows Desktop Application with Visual Basic (.NET) to simulate a simplified version of Google Form.

# Windows Desktop Application - Submission Manager

This Windows Desktop Application simulates basic functionalities of Google Forms, allowing users to view and create submissions. It includes navigation through submissions, creation of new submissions with a stopwatch feature, and integrates with a backend for data storage.

## Features

1. **View Submissions**
   - Navigate through submitted forms using "Previous" and "Next" buttons.
   - Displays Name, Email, Phone Number, GitHub repo link, and stopwatch time.

2. **Create New Submission**
   - Form for entering Name, Email, Phone Number, GitHub repo link.
   - Stopwatch functionality to track time.
   - Submit button to save data to the backend.

3. **Keyboard Shortcuts**
   - `Ctrl + P`: Previous submission navigation.
   - `Ctrl + N`: Next submission navigation.
   - `Ctrl + V`: View submissions.
   - `Ctrl + T`: Toggle stopwatch.
   - `Ctrl + S`: Submit new submission form.

4. **Backend Integration**
   - Communicates with a backend Express.js server using API calls.
   - Endpoints include saving submissions and retrieving saved submissions.

5. **Additional Features**
   - Option for deletion and editing of submitted forms.
   - Search functionality by email ID.

## Prerequisites

- Visual Studio (preferably latest version).
- .NET Framework (version compatible with your Visual Studio).
- Backend server (Express.js with TypeScript and JSON file database).

## Setup

1. **Clone Repository**
   ```bash
   git clone <repository-url>
   cd <project-directory>

