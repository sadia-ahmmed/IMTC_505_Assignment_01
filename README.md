# IMTC_505_Assignment_01

# Obstacle Dodge — Interactive Unity Scene

---

## Overview
Navigate a player cube through obstacles while hazards react to you. The scene showcases:
- Keyboard movement (physics-aware)
- Timed falling obstacles
- Rotating obstacles
- Collision feedback (color + sound)
- Triggered homing projectiles
- **Bonus:** color-changing sphere trail that auto-cleans + camera follow

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
1. **Keyboard input + movement (physics)**  
   The player moves using a `Rigidbody` (no tunneling through colliders).

2. **Timed event + physics**  
   A **Dropper** appears after a delay and falls using gravity.

3. **Rotation/animation**  
   **Spinner** obstacles continuously rotate on configurable axes.

4. **Collision feedback (visual + audio)**  
   When the player collides with an obstacle, its material turns **red** and a **hit sound** plays.

5. **Trigger-based behavior + motion**  
   Entering a trigger fires **hidden projectiles** that become visible and home toward the player, then self-destruct on proximity.

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






**Video link:** https://youtu.be/8AE3NWc15ow 


