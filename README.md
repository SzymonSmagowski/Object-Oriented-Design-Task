# Object-Oriented-Design-Task
The task for learning basics of object oriented design.
# The scope of a game
The game will simulate tower defence basics. The purpose is every created enemy walks nearby every defender. Defender is hitting him exactly once. There is proper message displayed on hit and if the monster is alive or not. The solution is: for each enemy in enemies we use attack function. Then inside attack function we call Demage method for each enemy that takes damage. Type checking of classes is not required.
# Enemies
They have: name, alive status, hp.
Types:
1. Giant.
2. Ogre - has armour parameter. Every time an ogre has to lose X health points it loses X-armor (but always at least 1 point).
3. Rat; It has an additional "speed" parameter. With every loss health points, the rat panics, increasing its speed by 1.
# Defenders
1. Warrior - The most basic of the defenders. He damages every enemy by amount of his "strength" parameter. Hes chance to miss his attack against Rat based on speed of rat. Miss chance formula: if (rng.NextDouble () <rat.speed / 100) {...}
2. Archer - A subclass of the Warrior class. He only has a certain number of arrows. He uses 1 arrow for each attack. When he attacks a giant, he shoots him twice.
3. Mage - attacks enemies by casting spells on them. It takes a certain amount of energy tocast a spell. When he can't cast a spell on his opponent, he regenerates energy instead of attacking him. Has additional parameters:
  - Mana - information about the amount of magical energy he has stored;
  - SpellPower - information on how many health points it takes from the enemy, it is equal
    to amount of mana spent on casting a spell;
  - ManaRegen - information on how much energy is regenerated when unable to cast spells.
4. FireMage - A wizard specializing in fire magic. His spells have an extra chance of killing an enemy immediately. Instant kill formula:
  if (rng.NextDouble () < killChanse) {...}
5. RatCatcher - the most specialized of defenders. If he meets a rat, he catches andkills it and keeps its body. When he has a rat's body and meets an ogre, he throws that body on ogre. Ogre is terryfied and runs away (which can be simulated by killing an ogre immediately). When a ratcatcher has a rat's body, it ignores anything that is not an ogre.
