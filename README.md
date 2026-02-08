# Space Shooter

A 2D space shooter game built with Unity.

## Project Overview

This is a space-themed shooter game where players control a spacecraft and battle enemies in an action-packed environment. The project includes player movement mechanics, combat systems, and visual effects.

## Project Structure

```
Assets/
├── Animations/          # Animation clips (currently empty)
├── EnemyHealth.cs       # Enemy health script (root level)
├── Prefabs/             # Game prefabs
│   ├── Bullet.prefab            # Bullet projectile prefab
│   ├── Enemy Explosion.prefab   # Explosion visual effect
│   ├── Enemy_01.prefab          # Enemy spaceship prefab
│   └── Player Explosion.prefab  # Player death explosion effect
├── Scenes/              # Game scenes
│   └── Battle.unity     # Main battle scene
├── Scripts/             # C# game scripts
│   ├── Blinking.cs          # Blinking sprite effect
│   ├── Bullet.cs            # Bullet movement behavior
│   ├── EnemyAttack.cs        # Enemy damage to player on trigger
│   ├── EnemyHealth.cs       # Enemy health and death
│   ├── Health.cs             # Base health and death handling
│   ├── PlayerMovement.cs    # Mouse-based player control
│   ├── PlayerHealth.cs       # Player health and death
│   ├── PlayerShooting1.cs   # Player shooting system
│   └── ShowLog.cs           # Debug logging utility
└── Space Shooter Template FREE/
    ├── Animation/       # Template animation assets
    ├── Documentation/   # Template documentation and guides
    ├── Prefabs/         # Template prefab objects
    ├── Scenes/          # Template example scenes
    ├── Scripts/         # Template scripts
    └── Sprites/         # Sprite assets and textures
```

## Requirements

- **Unity**: 2022.3.62f3 or later
- **.NET Framework**: Compatible with the Unity installation

## Getting Started

1. **Clone or download** this repository
2. **Open the project** in Unity Hub
3. **Load the Battle scene** from Assets/Scenes/Battle.unity
4. **Press Play** to run the game

## Controls

- **Mouse Movement**: Control player spaceship position (follows cursor)
- **Mouse Left Click (Hold)**: Shoot bullets at enemies

## Features

- **Mouse-based player control**: Player spaceship follows mouse cursor within camera bounds
- **Customizable movement boundaries**: Configure allowed movement area per side
- **Player shooting system**: Continuous fire with customizable fire rate
- **Bullet projectiles**: Configurable speed with automatic cleanup
- **Health system**: Shared base health with damage handling and explosion on death
- **Enemy attacks**: Enemies damage the player on trigger contact
- **Visual effects**: Blinking sprite animations and explosion prefabs

## Scripts

### Blinking.cs
Controls sprite blinking visual effect by toggling sprite renderer visibility each frame. Used for creating attention-grabbing visual effects on game objects.

### PlayerMovement.cs
Handles player spaceship movement based on mouse position. Features include:
- Mouse cursor following within camera bounds
- Configurable movement limits for each side (left, right, top, bottom)
- Smooth position clamping to keep player within allowed area
- Works with orthographic camera setup

**Public Variables:**
- `leftLimitFactor`: Fraction of camera width allowed toward left (0-1)
- `rightLimitFactor`: Fraction of camera width allowed toward right (0-1)
- `topLimitFactor`: Fraction of camera height allowed toward top (0-1)
- `bottomLimitFactor`: Fraction of camera height allowed toward bottom (0-1)

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

### Health.cs
Base health system for player and enemies. Features include:
- Configurable starting health
- Damage handling and death triggering
- Spawns explosion effect on death

**Public Variables:**
- `explosionPrefab`: Reference to explosion visual effect prefab
- `defaultHealthPoint`: Starting health amount

### EnemyHealth.cs
Enemy-specific health behavior. Inherits from `Health` and logs when the enemy dies.

### PlayerHealth.cs
Player-specific health behavior. Inherits from `Health` and logs when the player dies.

### EnemyAttack.cs
Handles enemy damage to the player on 2D trigger contact. Also forces the enemy to die after dealing damage.

**Public Variables:**
- `health`: Reference to the enemy `EnemyHealth` component
- `damage`: Damage dealt to the player

### ShowLog.cs
Debug utility for displaying logs in-game. Outputs "Hello World!" on start and frame count updates each frame.

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
