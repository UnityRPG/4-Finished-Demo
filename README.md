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
