<p align="center">
	<a href="https://github.com/muskan12388/IOT1026-Project/actions/workflows/ci.yml">
    <img src="https://github.com/muskan12388/IOT1026-Project/actions/workflows/ci.yml/badge.svg"/>
    </a>
	<a href="https://github.com/muskan12388/IOT1026-Project/actions/workflows/formatting.yml">
    <img src="https://github.com/muskan12388/IOT1026-Project/actions/workflows/formatting.yml/badge.svg"/>
	<br/>
    <a href="https://codecov.io/gh/muskan12388/IOT1026-Project" > 
    <img src="https://codecov.io/gh/muskan12388/IOT1026-Project/branch/main/graph/badge.svg?token=JS0857X5JD"/> 
	<img title="MIT License" alt="license" src="https://img.shields.io/badge/license-MIT-informational?style=flat-square">	
    </a>
</p>

# IOT1026-Project
Write a description of your `Room` and `Monster` class here

[Assignment Instructions](docs/instructions.md)  
[How to start coding](docs/how-to-use.md)  
[How to update status badges](docs/how-to-update-badges.md)
 
 updates summary:
 The Monster class has been modified, and the IActivatable interface has been included in the new code. Here is a list of the modifications:

The Monster class is still used as an abstract base class in the game for many monster varieties. By offering an implementation for the Activate function, it now implements the IActivatable interface.
The Monster class has abstract methods for attacking the hero (Attack), moving the monster to a new room (MoveToRoom), and determining whether the monster is within the hero's attacking range (IsWithinAttackRange). It also has abstract methods for displaying sensory information about the monster (DisplaySense), showing the monster's current state (Display), and displaying sensory information about the monster.

A mechanism for activating game components is represented by the IActivatable interface. It just declares the function Activate, which accepts two parameters: a Hero and a GameMap.

Summary
 list of the code changes is provided below:

Within the MyMonster category:


The constructor is changed to set the monster's characteristics for HealthPoints, AttackStrength, and Speed.
The exact behaviour for the monster's movement, attack, and special ability is provided by overriding the Move(), Attack(), and SpecialAbility() functions.
Three private methods are introduced as stand-ins for the implementation of the monster's movement, attack, and special ability logic: MoveTowardsHero(), ShootFireballs(), and IncreaseAttackStrength().

In the class LabyrinthCreator:

Instead of adding the previous Minotaur monster to the room in the map, the InitializeMonsters function is altered to create an instance of MyMonster.
By adding an instance of MyMonster to the map during startup, these adjustments make sure that the MyMonster class has the appropriate characteristics and behaviour.





