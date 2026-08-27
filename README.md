# Unity 2D Platformer Game

Unity 2D Platformer Game is a side-scrolling action project developed in Unity. The project incorporates robust physics interactions, boundary management, dynamic enemy behaviors, and comprehensive character animation systems.

## Project Overview

The core gameplay centers around a fully configured Player GameObject equipped with a Rigidbody2D, a SpriteRenderer, BoxColliders for collision and trigger interactions, and a custom player script managing speed, jump force, and health. The player's visual states are driven by an Animator component linked to a dedicated Player Animator Controller, which seamlessly transitions between Idle, Walking, Jump, and Dead states. Additional animation assets, such as an Attack animation clip, expand the character's interactive capabilities.

The environment utilizes an OutOfBounds system consisting of designated game objects with trigger BoxColliders covering the top, bottom, left, and right parameters of the play area. These boundaries help manage level limits and handle gameplay events when the player navigates outside the intended space. Hazards and moving obstacles are powered by custom scripts like the SawController, which commands objects to move dynamically across the screen and automatically reverse their direction and horizontal scale when encountering designated enemy area boundaries.

## Getting Started

To explore or run the project locally, open Unity Hub and select the option to add a project from disk by choosing the repository folder. Ensure you open the project using a compatible Unity editor version. Once the project loads successfully, navigate to the scenes directory within the assets folder to open the main game scene and begin testing the platformer mechanics.

Please note that these files represent **just the individual assets and components** (from the asset package `II-BSSD5150-Final-Assets`) rather than a complete, standalone Unity project repository.

The collection consists of modular game pieces and building blocks, including the `OutOfBounds` prefab for level boundary management, the `Player` controller and prefab for handling character animations and physics, the `SawController` script for managing moving obstacle hazards, and the `Attack` animation clip. These individual elements serve as development assets that can be integrated into a larger Unity project workspace.
