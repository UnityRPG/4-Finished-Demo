# Unity RPG Course - Section 4 - Finished Demo

The toughest, and most rewarding section of the course. Here you learn to finish strong, with clean code, few bugs, and great features. This is real game dev right here. The full course is [on Udemy here](https://www.udemy.com/unityrpg).

You're welcome to download, fork or do whatever else legal with all the files!

## How To Build / Compile
This is a Unity project. If you're familiar with source control, then "clone this repo". Otherwise download the contents, and navigate to `Assets > Levels` then open any `.unity` file.

This branch is the course branch, each commit corresponds to a lecture in the course. The current state is our latest progress.

## Lecture List
Here are the lectures of the course for this section...

### 1 Section 4 Introduction
1. What we're going to cover in this section
2. Why this material is SO important
3. Ben will start, Rick will finish
4. A few new features but a LOT of polish.

### 2 From Interface To Inheritance
1. Don't Repeat Yourself (DRY) Principle
2. Inheritance can help us centralise
3. It's often easy to change an interface to inheritance
4. Create the new parent class, then delete the interface
5. Getting code running again may require `abstract` and `override`

### 3 Less Lines Of Code Is Better
1. Move all `PlayParticleEffect()` code to parent class
2. Use "down-casting" with caution for configs
3. Setup prefab based idiom for world vs local particle space.

### 4 Centralise And Improve Audio Clips
1. Move special ability audio to `AbilityBehaviour.cs`
2. Use the `PlayOneShot()` method to play clips at the same time
3. Import Rick's special ability sound effects.

### 5 Making Abstract Methods Concrete
1. Move `AttachComponentTo()` method to parent class
2. Refactor to simplify code as practice.

### 6 Weapon Pickup Points
1. Creating what's effectively nested prefabs!
2. How to use `[ExecuteInEditMode]` annotation
3. Detecting play mode with `Application.isPlaying`
4. Trigger a sound effect when weapon is collected.


### 7 Weapon Change Mechanics
1. Destroy previous weapon by keeping member variable
2. The `Player` class is becoming a "god object" (see Resource links)
3. Change runtime animation on weapon swap.

### 8 Eliminate AICharacterControl
1. Remove Unity's `AICharacterControl.cs` class
2. Make `PlayerMovement` more general `CharacterMovement`
3. Overall reduce our code base by 68 lines.


### 9 Simplify Unity's ThirdPersonCharacter Class
1. Remove jump and crouch arguments
2. Remove all un-necessary methods
3. Remove un-used member variables.


### 10 Introducing Unity 2017
1. Upgrade our project to Unity 2017
2. Fix anything that isn't working
3. Overview the new features in Unity 2017.

### 11 Caution With Callbacks In Refactors
1. About the `OnAnimatorMove()` callback
2. Using this to adjust root motion speed
3. How call-backs can catch you out in refactors.


### 12 Eliminating ThirdPersonCharacter.cs
1. Refactor our code in place to get an understanding
2. Bring Unity's code in line with our code standards
3. Move all code from `ThirdPersonCharacter` to `CharacterMovement`


### 13 Extracting a DamageSystem Component
1. With special abilities we turned an interface into inheritance
2. Now we turn the `IDamageable` interface into a component
3. Extract all damage, healing and health bar code.


### 14 Getting To Compilation With Focus
1. Don't be distracted when not compiling
2. Just solve the errors, get running & commit
3. Complete extraction of `HealthSystem`
