# IMTC_505_Assignment_01

# Obstacle Dodge — Interactive Unity Scene

---

## Overview
Navigate a player cube through obstacles while hazards react to you. The scene showcases:
- Keyboard movement (physics-aware)
- Timed falling obstacles
- Rotating obstacles
- Collision feedback color change 
- Collision feedback: audio
- **Bonus:** color-changing sphere trail that auto-cleans + camera follow
- 
**Video link:** https://youtu.be/8AE3NWc15ow
  
---

## Quick Start
1. **Unity:** 2021.3 LTS or newer.
2. **Clone** this repo and open the folder with `Assets/`, `Packages/`, `ProjectSettings/`.
3. Open the main scene (e.g., `Scenes/ObstacleDodge.unity`).
4. Press **Play**.

---

## Controls
- **WASD / Arrow Keys** — Move the player.

---


### Required 5 Interactions

- **Something that changes position, rotation, or scale**  
  → **Player movement** (WASD/Arrow keys) and **Spinner** obstacles that rotate continuously.

- **Something that changes colors, visuals, or animations**  
  → **Color-changing sphere trail** behind the player and **obstacles/walls turn red on hit**.

- **Something happens when you press a key on the keyboard**  
  → **Player moves with WASD/Arrow keys** (keyboard input driving motion).

- **Something physics-related**  
  → **Dropper** element **falls with gravity after a delay**.

- **Something audio related**  
  → **Hit sound** plays when the player collides with an obstacle.

### Bonus Objective
- **Trail of spheres:** While moving, the player spawns small spheres that **change color** and **auto-destroy after ~5s**.  
- **Follow camera:** The camera follows the player using Cinemachine.



## How It Works (Scripts)

- **`Mover.cs`**  
  Reads input each frame and moves via `Rigidbody.MovePosition` for proper collisions. When the player is moving, it spawns small colored spheres that are destroyed after 5 seconds (fulfills the **bonus trail**).

- **`Dropper.cs`**  
  Waits for a configurable time, then enables its renderer and turns on gravity to drop.

- **`Spinner.cs`**  
  Applies per-axis rotation every frame to create moving hazards.

- **`ObjectHit.cs`**  
  On collision with the Player: changes the material color to **red**, tags the object as `Hit`, and plays an attached **AudioSource**.







