# 🎮 Unity Game Template

![Unity](https://img.shields.io/badge/Unity-2021+-000000?style=for-the-badge&logo=unity&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![Firebase](https://img.shields.io/badge/Firebase-FFCA28?style=for-the-badge&logo=firebase&logoColor=black)
![.NET](https://img.shields.io/badge/.NET_4.x-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![License](https://img.shields.io/badge/License-MIT-green?style=for-the-badge)

A production-ready Unity game template with Firebase integration, featuring authentication, leaderboard system, and save functionality. Perfect for kickstarting your next mobile or desktop game project.

## ✨ Features

- 🔐 **Firebase Authentication** - Anonymous sign-in system
- 🏆 **Leaderboard System** - Real-time score tracking and rankings
- 💾 **Cloud Save System** - Firebase Firestore integration
- 🎯 **Score Management** - Built-in scoring system
- 📱 **Multi-Platform** - Android & Desktop support
- 🎨 **UI Framework** - Pre-built UI scenes and components
- ⚙️ **Environment Config** - Easy configuration management

## 🛠️ Tech Stack

### Game Engine

- **Unity 2021+** - Game development platform
- **C# (.NET 4.x)** - Primary programming language
- **TextMeshPro** - Advanced text rendering

### Backend Services

- **Firebase Authentication** - User authentication
- **Firebase Firestore** - NoSQL cloud database
- **Firebase Storage** - Cloud file storage

### Architecture

- **Singleton Pattern** - GameManager & Firebase managers
- **Scene Management** - Multi-scene workflow
- **Prefab System** - Reusable UI components

## 📁 Project Structure

```
GameProject/
├── Assets/
│   ├── Prefabs/          # Reusable game objects
│   │   └── UI/           # UI prefabs (ScoreRow, etc.)
│   ├── Resources/        # Runtime loadable assets
│   │   └── env.txt       # Environment configuration
│   ├── Scenes/           # Game scenes
│   │   ├── Welcome.unity      # Entry scene
│   │   ├── MainGame.unity     # Main gameplay
│   │   └── LeaderBoard.unity  # Leaderboard display
│   ├── Scripts/
│   │   ├── Core/         # Core game systems
│   │   ├── Firebase/     # Firebase integration
│   │   ├── Player/       # Player-related scripts
│   │   └── UI/           # UI controllers
│   └── UI/               # UI assets and layouts
├── Backend/
│   └── Firebase/         # Firebase configuration
│       ├── firebase.json
│       ├── firebase.rules
│       └── storage.rules
└── Packages/             # Unity package dependencies
```

## 🚀 Getting Started

### Prerequisites

- Unity 2021 or higher
- Firebase account
- .NET 4.x runtime

### Installation

1. **Clone the repository**

   ```bash
   git clone <your-repo-url>
   cd GameProject
   ```

2. **Open in Unity**

   - Launch Unity Hub
   - Click "Add" and select the project folder
   - Open the project

3. **Configure Firebase**

   - Create a Firebase project at [Firebase Console](https://console.firebase.google.com/)
   - Download `google-services.json` (Android) or `GoogleService-Info.plist` (iOS)
   - Place in `Assets/` folder
   - Update `Backend/Firebase/serviceAccountKey.json` with your credentials

4. **Setup Environment**

   - Configure `Assets/Resources/env.txt` with your Firebase settings
   - Update `.env` file in root directory

5. **Build & Run**
   - Open `Assets/Scenes/Welcome.unity`
   - Press Play or build for your target platform

## 🎮 Core Systems

### GameManager

Singleton managing game state, player data, and scoring.

### Firebase Integration

- **FirebaseInitializer** - Initializes Firebase services
- **FirebaseAuthManager** - Handles authentication
- **FirebaseLeaderBoardManager** - Manages leaderboard data
- **FirebaseSaveSystem** - Cloud save functionality

### UI System

- **WelcomeUI** - Entry screen
- **ScoreUI** - In-game score display
- **LeaderBoardUI** - Leaderboard interface

## 🔧 Configuration

### Firebase Rules

Firestore security rules are configured in `Backend/Firebase/firebase.rules`:

- Public read access for leaderboard
- Authenticated write access for user scores

### Build Settings

- Default Resolution: 1080x1920 (Mobile Portrait)
- API Compatibility: .NET 4.x
- Supports: Standalone, Android

## 📦 Dependencies

```json
{
  "com.unity.textmeshpro": "3.0.6",
  "com.unity.analytics": "4.5.0",
  "com.unity.collab-proxy": "2.3.4"
}
```

## 🤝 Contributing

We welcome contributions! Follow these steps:

1. **Fork the repository**

   - Click the "Fork" button at the top right

2. **Clone your fork**

   ```bash
   git clone https://github.com/rodrigomarcelo643/GameProject.git
   cd GameProject
   ```

3. **Create a branch**
   Use this naming convention:

   - `feature/your-feature-name` - For new features
   - `bugfix/issue-description` - For bug fixes
   - `hotfix/critical-fix` - For urgent fixes
   - `docs/documentation-update` - For documentation

   ```bash
   git checkout -b feature/your-feature-name
   ```

4. **Make your changes and commit**

   ```bash
   git add .
   git commit -m "feat: add your feature description"
   ```

5. **Push to your fork**

   ```bash
   git push origin feature/your-feature-name
   ```

6. **Create a Pull Request**
   - Go to the original repository
   - Click "New Pull Request"
   - Select your branch
   - Provide a clear description of your changes

## 📄 License

This project is available as a template for game development.

## 🎯 Use Cases

Perfect for:

- Mobile casual games
- Arcade-style games with scoring
- Multiplayer leaderboard games
- Prototyping game ideas quickly
- Learning Unity + Firebase integration
