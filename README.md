# PI3DV-mini-project
This is my 3rd semester's mini-project in "Programmering af interaktive 3D verdener" (or PI3DV)! 

## The idea behind making the game
I took inspiration from Bendy and the Ink Machine (BATIM), a game made by Joey Drew Studios, when making my game. But the inspiration is not completely taken from BATIM game itself, but instead taken from an April fools YouTube video, also made by Joey Drew Studios themselves (link: https://www.youtube.com/watch?v=ypHMXCDQvaA), that is called Bendy Royale. In the video you only see the different characters from BATIM, but with guns, grenades, missiles, etc.. So, what I wanted to make was my own version of that April fools YouTube video, aka. Bendy Royale.

## About the game
This game is a first-person shooting game, where you can choose between two characters. One that is an inky-looking human with a pair of pants and a mask on, who also holds a pistol ─ that is the director of the Music Department, Sammy Lawrence. The other character looks like an alternative version of “Mickey Mouse”, but just as a cardboard cutout “holding” an automatic rifle ─ that is the little devil, Bendy. When you have chosen your character, your mission is to survive as long as you can, and shooting your enemies ─ the inky creatures, the Searchers. And if you die, you get another chance to beat the Searchers and try out each character. A little hint to survive longer; step on the big inky puddles.
The game does not show a score nor a timer of how much time you either have spent or have left ─ in other words, it is really up to you to decide what is your goal when playing it. It could either be to try out all the characters, to experience the level design, to kill the Searches, or anything that pops on your mind.

## Each part of the game in bullet points
Here is a run-down of each part of my game:
### Scripts
- CharacterSwap ─ keeps track of how many characters there are, switches between them and saves the last used one.
- Enemy ─ controls the health of the Searches and updates their health bar (a GUI slider).
- EnemyDamage ─ checks if the Searchers are colliding with a game object with the “Player” tag, and if yes they cause damage on the “Player”.
- EnemyMovement ─ checks if there are any objects with the “Player” tag, if yes the Searchers look at and hunt that object down.
- SpawnRandomly ─ spawns the Searchers randomly on the floor of the level; this script is activated from the GameManager object in the BattleGround scene.
- GameOverScreen ─ two voids that tells if you either press the Restart or Main Menu button on the GameOverScreen scene, and then loads the pressed button’s specific scene.
- PickUpHealthPack ─ checks if a specific game object has the “HealthPack” tag, if it is colliding with the object that holds the PlayerHealth script it heals and updates the object’s health bar (a GUI slider).
- FloatingHealthBar ─ a GUI slider that visualize how much health the objects that hold this script have left.
- MoveCamera ─ controls where the player’s camera is facing.
- PlayerCam ─ hides the mouse cursor, controls the sensitivity when moving the mouse, and set limits of how much you can look up and down.
- PlayerHealth ─ controls the health of the player, updates their health bar (a GUI slider), and when the player is dead the GameOverScreen scene will be shown.
- PlayerMovement ─ makes sure the player moves the same way as where the camera is pointing and adds force when moving.
- DamageGun ─ makes a raycast that when it hits a Searcher it causes damage, and when shooting on a Searcher it shows a little red dot to visualize you are hitting the enemy.
- Gun ─ switches between automatic and semi-firing shooting that I control with help from Unity’s Events in the Inspector on Unity, and spawn particles from the gun’s spawn point when shooting.
### 3D models
- BendyCutout ─ downloaded from https://sketchfab.com/3d-models/bendy-cutout-bendy-and-the-ink-machine-2daef136ff504a23a1f8c2ef39b53eee and his gun is from https://sketchfab.com/3d-models/batim-tommy-gun-e63801a9675a451ab91071700bb1ee16.
- SammyLawrence ─ downloaded from https://sketchfab.com/3d-models/sammy-lawrence-08f3fb191379437989473fdbefd7eea1 and his gun from https://sketchfab.com/3d-models/gun-bendy-and-the-inkt-machine-a1e4e8eb26dd45dca6c9e9a87f69e738.
- SearcherEnemy ─ downloaded from https://sketchfab.com/3d-models/batim-searcher-87ae00fd8c1a49d4ab530910d0e000c9.
- BendyStatue ─ https://sketchfab.com/3d-models/ch3-bendy-statue-f8995084a6fa4d39b064258fd203957a.
### Materials
- These materials are used for the level, the ink machine, the inky puddles and the particles.
### Prefabs
- Here I have all the pefabs, that are the little red dot, the enemy, the particle for the automatic gun and another for the semi-firing gun.
### Scenes
- There are three scenes, that are BattleGround, CharacterSwap and GameOverScene.
### ProBuilder
- I made the whole level, except for the floor, with ProBuilder. I also 3D modelled the ink machine in ProBuilder.

## How much time did it take me?
Here is a table of how much time it took me to different parts in and outside the game. When a box is empty, it means that it is just a zero.
| **Different parts**                                                | **Hours**    | **Minutes**    |
|--------------------------------------------------------------------|--------------|----------------|
| Making the Unity project                                           |              | 5              |
| Setting it up on Github                                            | 1            |                |
| Working on scripts and coding                                      | 12           |                |
| Making materials                                                   |              | 25             |
| Making prefabs                                                     |              | 30             |
| Making GUI stuff ─ health bar, character swap and game over screen |              | 45             |
| Fixing posture of 3D models in Blender                             | 3.5          |                |
| Level building and Ink Machine building with ProBuilder            | 4            |                |
| Working with particles                                             | 1            |                |
| Working with lightning                                             | 1            |                |
| Writing the report                                                 | 1.5          |                |
| Making the READme                                                  |              | 30             |
| **All in total**                                                   | **26 hours** | **15 minutes** |

## References of project parts
Here is a run-down of each part of my game:
- MODULAR WEAPON SYSTEM in Unity in Under 4 Minutes ─ https://www.youtube.com/watch?v=47ZkulgnadI
- FIRST PERSON MOVEMENT in 10 MINUTES - Unity Tutorial ─ https://www.youtube.com/watch?v=f473C43s8nE&t=201s
- Easy Enemy Health Bars in Unity ─ https://www.youtube.com/watch?v=_lREXfAMUcE
- Unity FPS Tutorial - C# Part 21 - Health Packs ─ https://www.youtube.com/watch?v=WJ_6q7bRSRs
- Character Selection (And changing scene) - Unity 3D[Tutorial][C#] ─ https://www.youtube.com/watch?v=IFTjcPvCZaM
- Spawning enemies in random places on the level ─ https://github.com/IvanNik17/Programming-Interactive-3D-Worlds/blob/main/6.Visualize%20Raycasts/Assets/Scripts/ShootRaycast/SpawnRandom.cs
- Enemy moving script ─ https://github.com/IvanNik17/Programming-Interactive-3D-Worlds/blob/main/6.Visualize%20Raycasts/Assets/Scripts/ShootRaycast/moveTowards.cs 

