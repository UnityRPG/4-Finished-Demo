# Unity RPG Course - Section 4 - Finished Demo

The toughest, and most rewarding section of the course. Here you learn to finish strong, with clean code, few bugs, and great features. This is real game dev right here. The full course is [on Udemy here](https://www.udemy.com/unityrpg).

You're welcome to download, fork or do whatever else legal with all the files!

## How To Build / Compile
This is a Unity project. If you're familiar with source control, then "clone this repo". Otherwise download the contents, and navigate to `Assets > Levels` then open any `.unity` file.

This branch is the course branch, each commit corresponds to a lecture in the course. The current state is our latest progress.

## Lecture List
Here are the lectures of the course for this section...

### 1 Section 4 Introduction
1. What we're going to cover in this section.
2. Why this material is SO important.
3. Ben will start, Rick will finish.
4. A few new features but a LOT of polish.

### 2 From Interface To Inheritance
1. Don't Repeat Yourself (DRY) Principle.
2. Inheritance can help us centralise.
3. It's often easy to change an interface to inheritance.
4. Create the new parent class, then delete the interface.
5. Getting code running again may require `abstract` and `override`.

### 3 Less Lines Of Code Is Better
1. Move all `PlayParticleEffect()` code to parent class.
2. Use "down-casting" with caution for configs.
3. Setup prefab based idiom for world vs local particle space.

### 4 Centralise And Improve Audio Clips
1. Move special ability audio to `AbilityBehaviour.cs`.
2. Use the `PlayOneShot()` method to play clips at the same time.
3. Import Rick's special ability sound effects.

### 5 Making Abstract Methods Concrete
1. Move `AttachComponentTo()` method to parent class.
2. Refactor to simplify code as practice.

### 6 Weapon Pickup Points
1. Creating what's effectively nested prefabs!
2. How to use `[ExecuteInEditMode]` annotation.
3. Detecting play mode with `Application.isPlaying`
4. Trigger a sound effect when weapon is collected.

### 7 Weapon Change Mechanics
1. Destroy previous weapon by keeping member variable.
2. The `Player` class is becoming a "god object" (see Resource links).
3. Change runtime animation on weapon swap.

### 8 Eliminate AICharacterControl
1. Remove Unity's `AICharacterControl.cs` class.
2. Make `PlayerMovement` more general `CharacterMovement`.
3. Overall reduce our code base by 68 lines.

### 9 Simplify Unity's ThirdPersonCharacter Class
1. Remove jump and crouch arguments.
2. Remove all un-necessary methods.
3. Remove un-used member variables.

### 10 Introducing Unity 2017
1. Upgrade our project to Unity 2017.
2. Fix anything that isn't working.
3. Overview the new features in Unity 2017.

### 11 Caution With Callbacks In Refactors
1. About the `OnAnimatorMove()` callback.
2. Using this to adjust root motion speed.
3. How call-backs can catch you out in refactors.

### 12 Eliminating ThirdPersonCharacter.cs
1. Refactor our code in place to get an understanding.
2. Bring Unity's code in line with our code standards.
3. Move all code from `ThirdPersonCharacter` to `CharacterMovement`.

### 13 Extracting a DamageSystem Component
1. With special abilities we turned an interface into inheritance.
2. Now we turn the `IDamageable` interface into a component.
3. Extract all damage, healing and health bar code.

### 14 Getting To Compilation With Focus
1. Don't be distracted when not compiling.
2. Just solve the errors, get running & commit.
3. Complete extraction of `HealthSystem`.

### 15 Centralising Special Ability Code
1. Drawing a comparison with Health System.
2. Using the "Pomodoro Technique" for 20-min chunks.
3. Make energy and special abilities self contained.
4. How to write an alternative getter format in C#.

### 16 Eliminate A Struct And Interface
1. Remove the `AbilityUseParams` struct.
2. Eliminate the `IDamageable` interface.

### 17 Using Optional Parameters In C#
1. Review our code to ensure we "own" it.
2. Get special abilities working again.
3. Use an optional parameter in C#.
4. Setup an out of energy SFX.

### 18 Having Characters Build Themselves
1. Using the `[SelectionBase]` attribute.
2. Making characters add their own component on `Awake()`.

### 19 Completing Character Self-Setup
1. Finish the work we started in the last lecture as a challenge.

### 20 A SetDestination() Movement API
1. Both `PlayerControl` and `EnemyAI` set world space destinations.
2. This will work for mouse, but would need to be modified for gamepad.
3. Take all input listening out of the character.
4. Start to really focus `PlayerControl` on it's sole function.

### 21 A Strong Character Basis
1. Review how the character part of the player works.
2. Create a dedicated animator override controller per enemy.
3. Build a character from scratch as the basis of an enemy.
4. Demonstrate our architecture by possessing as player.

### 22 Slowly Extracting WeaponSystem
1. Extract a few member variables at a time.
2. Keep your code close to compilation.
3. Provide new getter methods as needed.
4. Know when to stop and commit your work!

### 23 Recap And Review When Tired
1. Beeminder is a useful tool for accountability.
2. When you're tired you can still move forward.
3. How to recover Scriptable Objects that you can't inspect.
4. A strategy for handling `todo` tags in code.

### 24 Simplifying Enemy To EnemyAI
1. What makes an enemy an enemy?
2. Remove member variables relating to `WeaponSystem`.
3. Use `RequireComponent` appropriately.
4. Make enemy attack radius depend on weapon.
5. Is `GetComponent()` slow? OK to call in `Update()`?

### 25 AI Behaviour Tree In Unity
1. Outline our required enemy behaviour in pseudocode.
2. Use an `enum` to track the enemy's state
3. Use co-routines to patrol, attack, chase, etc.
4. Use the inspector debug mode to see it working.

### 26 Waypoint Paths With Editor Gizmos
1. A simple scheme for defining patrol paths.
2. A new `WaypointContainer` class.
3. Setup a couple of test paths.

### 27 Patrolling Using Coroutines
1. How `yield break;` works
2. Care of infinite loops with `while (true)`
3. Pseudocode to help you keep a consistent level of abstraction.

### 28 Automatic Repeat Attacking
1. How to use `Debug.Break()` to pause on error.
2. Using a co-routine for repeat attacks.
