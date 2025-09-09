# Hacker Idle Game

A mobile incremental/idle game made with **Godot Engine** (C#).  
The player takes the role of a hacker building their virtual empire, unlocking upgrades, and automating tasks to earn more resources.

---

## 📂 Project Structure
```
.
├── assets/          # Raw source files (Aseprite, PSD, WAV, design docs, etc.)
├── docs/            # Project documentation
├── game/            # Godot project
│   ├── assets/      # Optimized assets used by Godot (PNG, OGG, TTF...)
│   ├── scenes/      # Game scenes (menus, gameplay, UI)
│   ├── scripts/     # C# scripts
│   ├── ui/          # UI components (panels, buttons, labels)
│   └── main.tscn    # Root scene
└── README.md
```

---

## 🚀 How to Run
1. Install [Godot Engine](https://godotengine.org/download) (version 4.x, .NET edition).  
2. Open the `game/` folder as a project.  
3. Run the project with **F5** (default scene: `main.tscn`).  

---

## 📱 Mobile Deployment
- Android/iOS builds will be handled via **Godot export templates**.  
- Ads integration planned (AdMob).  

---

## 🛠 Tech Stack
- **Engine**: Godot 4.4.1 (.NET / C#)  
- **Graphics**: Pixel Art (Libreseprite)  
- **Version Control**: Git + GitHub  

---

## 🎯 MVP Features
- Idle resource generation (money, CPU power)  
- Upgrades & automation  
- Simple cyberpunk pixel-art UI  
- Save/Load system  

---

## 📌 Notes
This is an **MVP (Minimum Viable Product)** version – focused on core gameplay loop before adding polish, ads, or advanced features.
