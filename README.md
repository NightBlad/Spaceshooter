# Space Shooter

A 2D space shooter game built with Unity.

## Project Overview

This is a space-themed shooter game where players control a spacecraft and battle enemies in an action-packed environment. The project includes player movement mechanics, combat systems, and visual effects.

## Project Structure

```
Assets/
├── Prefabs/             # Game prefabs
│   └── Bullet.prefab    # Bullet prefab for shooting
├── Scenes/              # Game scenes
│   └── Battle.unity     # Main battle scene
├── Scripts/             # C# game scripts
│   ├── Bullet.cs        # Bullet movement and behavior
│   └── PlayerShooting1.cs # Player shooting system
└── Space Shooter Template FREE/
    ├── Animation/       # Animation assets
    ├── Documentation/   # Template documentation
    ├── Prefabs/        # Reusable prefab objects
    ├── Scenes/         # Additional template scenes
    ├── Scripts/        # Template scripts
    └── Sprites/        # Sprite assets
```

## Requirements

- **Unity**: 2021.3 or later (or version specified in ProjectSettings/ProjectVersion.txt)
- **.NET Framework**: Compatible with the Unity installation

## Getting Started

1. **Clone or download** this repository
2. **Open the project** in Unity Hub
3. **Load the Battle scene** from Assets/Scenes/Battle.unity
4. **Press Play** to run the game

## Controls

- **Mouse Left Click (Hold)**: Shoot bullets at enemies

## Features

- Player shooting system with customizable fire rate
- Bullet projectiles with configurable speed
- Automatic bullet cleanup when off-screen
- Object pooling through Unity's Instantiate system

## Scripts

### PlayerShooting1.cs
Handles player shooting mechanics with mouse input detection. Features include:
- Mouse button hold detection for continuous shooting
- Configurable shooting interval to control fire rate
- Instantiates bullet prefabs at player position

**Public Variables:**
- `bulletPrefabs`: Reference to the Bullet prefab
- `shootingInterval`: Time delay between shots (in seconds)

### Bullet.cs
Controls bullet movement behavior. Features include:
- Upward movement with configurable speed
- Uses Time.deltaTime for frame-rate independent movement

**Public Variables:**
- `flySpeed`: Speed of bullet movement (units per second)

## Building

To build a standalone executable:
1. Go to **File → Build Settings**
2. Select your target platform
3. Click **Build** and choose an output directory

## License

This project uses the Space Shooter Template FREE from the Unity Asset Store.

## Contributing

Feel free to fork, modify, and improve this project!

## Notes

- The project includes a free template from Unity Asset Store
- Review the Documentation folder in the Space Shooter Template for additional resources
- Configuration files are stored in ProjectSettings/

## Troubleshooting

If you encounter issues:
- Ensure Unity version matches or is compatible with ProjectVersion.txt
- Check the Logs/ directory for error messages
- Verify all assets are properly imported (no broken references)
