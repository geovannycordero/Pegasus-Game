# The Pegasus Rider 
### by 
## Blind Studio

### Pitch:

The Pegasus Rider is a single-player endless game in which the player controls the Pegasus and its Rider. The idea is that the Rider is a Greek hero that must ride on his Pegasus without being killed. During this ride, the Rider must avoid a series of obstacles like arrows, air currents, and bad air spirits while also collecting thunders to earn points. There will be three different difficulty levels with an increasing amount of obstacles and increasing speed to challenge the player.

### Setting:

The whole game takes place in the sky. It is inspired in Greek Mythology. The background of this game is that the mythological creature, called Pegasus which is a winged horse son of Poseidon, is on a quest to help Greek hero Perseus, who in this game will be referred to as the Pegasus Rider. The goal of the quest is to bring back Zeus’ lost Thunderbolts so the god can regain his power.  
During this game, Perseus will ride on Pegasus’ back at all times and together they will try to collect as many of Zeus’ Thunderbolts as they can while avoiding and fighting different obstacles or threats that come their way.

## Game components:

### Objects:

The Rider & Pegasus
The Rider & Pegasus sword
Thunderbolt
Arrows
Air currents
Anemoi Thuella (bad air spirits)
GUI: Time
GUI: Objects recollected (points)
GUI: Lives
Go up/down buttons
Fight button

### Attributes:

Position for the Rider & Pegasus, air currents, thunderbolt, arrows, Anemoi Thuella
Status of the Rider: Death or Alive
Speed of the Rider & Pegasus
Direction and speed of the air currents, Anemoi Thuella
Accumulated points for the Rider & Pegasus
Ride time for the Rider & Pegasus
Number of lives left for the Rider & Pegasus
Thunderbolts collected
Pressed-status for the buttons
Rider & Pegasus sword IsAttach status.

### Relationships:

When the go up/down button is pressed, the Pegasus continues to move up/down until the button is released or the Pegasus reaches the top/bottom of the screen.
When the Rider & Pegasus hit an air current or arrow the Rider & Pegasus will lose a live. 
When the Rider & Pegasus hit an Anemoi Thuella while the IsAttack status is true, the Anemoi will be killed, points will be obtained and it will disappear from the screen..
When the Rider & Pegasus hit an Anemoi Thuella while the IsAttack status is false, the Rider & Pegasus will lose a live.
If a live is lost, the GUI lives counter will be updated with the number of lives remaining.
If the Fight button is pressed, the Rider & Pegasus sword will be swung, changing the value of the IsAttack attribute to true for a certain amount of time of around a second. After this time, the attribute will go back to false.
When the Rider & Pegasus hit a thunderbolt. points are increased, the thunderbolt number will increase and the thunderbolt disappears from the screen.
When points are obtained, the GUI points counter will be updated with the new amount of total points.
When the player reaches a certain number of thunderbolts there will be a level up that will increase the speed of the game slightly and the number of threats will increase.
The GUI: Time text will be increased with every game step.

## Game mechanics:

### Controls:

Up/down arrows buttons on the keyboard will make the Rider & Pegasus move up or down on the screen.
Space bar will make the Rider & Pegasus attack by swinging the sword.

### Friendly behavior:

The Rider & Pegasus always start on the middle-left part of screen and can be moved up and down up to the limits of the screen.
The screen will be slide scrolling from right to left, making the obstacles moved with it.
When the attack button is used, a sword will be swung, creating an attack that will last a second and that will kill the Anemoi that touch the Pegasus during this time and the player will gain points.
Thunderbolts will appear on the screen and can be collected by the Rider & Pegasus by passing over them. They will move from right to left on a straight line with constant speed. Once collected, they disappear and the player gains points.

### Enemy behavior:

Arrows will move on a straight line starting from the right side of the screen and  moving with a constant speed to the left side of the screen until they disappear by overpassing the screen limit.
Air currents will move from left to right of the screen while also moving from top to bottom and then from bottom to top once the corresponding screen limits are reached, in a zigzag motion .
Anemoi Thuella will move from right to left with a constant speed but will mimic the up and down movements of the Rider & Pegasus, in a way that it seems to be trying to met the Pegasus and its rider.

### Level behavior:

There will be a level up based on the total amount of thunderbolts. Each time there is a level up, the speed will be slightly increased and so will be the number of threats.
Every time the player reaches a certain number of thunderbolts, the speed will be increased by 0.5 making all the rest of the components to move faster from right to left, causing the difficulty to increase.

### Win/loss Condition:

This is an endless game, so there is no win condition.
Loss condition is presented when lives number gets to 0.

### Scoring:

The player can score points by acquiring thunderbolts and by killing Anemoi Thuella. Also, depending on the time reach at the end, the number of seconds will be added to the score.

## Optional features:

Highscore list 
Achievements
Adding more obstacles
Cloud with random prices such as invincibility for a short period of time, bombs to destroy obstacles ahead and more lives. 
Minimum of objects collected to level up.

## Team Members:

### Andrea
+4 years of programming experience. Experience working with C#. No experience on videogames and no artistic talents. Quick learner, responsible and well organized.
### Jose
Programming experience in Java, C, C++. Very organized. No artistic talents.
### Geovanny
Five years of programming experience.  I like video games but I don’t play frequently. I like to work with others.
### Sergio
More than 15 years playing video games and 4 years of experience as a programmer. Motivated and easy going.
### Diego
Programing experience in C,C++,PHP, Javascript, Typescript. A little experience in Phaser.io, Inkscape, Krita, making pixel art. I learn quickly and flexibly. 




## Division of Labor:

Blind Studio: Gameplay, level and obstacles design, player controls, UI, finding appropriate art, assets and testing.

## Prototype Screenshot:

