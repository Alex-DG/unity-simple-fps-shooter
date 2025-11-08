# Unity: Simple FPS Shooter View – Weapon & Bullet

Prototype first-person shooter built in Unity using the new Input System. The demo showcases a controllable FPS camera, a rifle with a simple recoil animation, and spawning bullet prefabs with optional lifetime cleanup.

<img width="705" height="1073" alt="image" src="https://github.com/user-attachments/assets/e9969419-06ac-428f-847f-f61ee2da0906" />

## Overview
- **Player Input:** Input Actions map movement, look, shooting, shooting release, and reloading. Callbacks drive weapon logic through `Send Messages` (methods named `On<ActionName>`).
- **Weapon Behaviour:** The `Gun` component enforces fire rate, manages magazine ammo, plays a reload sway, and instantiates the `RifleBullet` prefab from a muzzle transform.
- **Projectile Flow:** Spawned bullets can use physics or straight travel; an optional `DestroyAfterTime` script prevents lingering GameObjects.

## Controls
- `WASD` to move
- Mouse to look
- Hold left mouse to fire
- `R` to reload

## Script Breakdown
- `PlayerMovement.cs`: Handles character translation using Unity CharacterController-style physics with gravity application and sprint-ready structure.
- `PlayerLook.cs`: Processes mouse delta to rotate the camera pitch and player yaw, clamping vertical angles for a stable aim.
- `PlayerShooting.cs`: Receives Input System messages, tracks whether the fire button is held, and calls into `Gun.Shoot()` while the action remains pressed.
- `Gun.cs`: Manages ammo count, fire-rate cooldowns, reload coroutine, recoil/reset animation, and spawns bullets from a configured transform.
- `Bullet.cs`: Defines per-bullet behaviour (e.g., forward motion or collision handling—extend as needed for damage or effects).
- `DestroyAfterTime.cs`: Utility that destroys instantiated effects or projectiles after a configurable lifetime to keep the scene clean.

## Extending the Demo
- Add muzzle flash, impact VFX, and audio cues in `Gun.Shoot()`.
- Expand `Bullet` to apply damage, spawn decals, or use raycast hits.
- Layer in camera shake or procedural animation to enhance recoil feedback.
