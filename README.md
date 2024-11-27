# INFR 1350U – Game Engine Design & Implementation
Intro to Comptuer Graphics Project M forked version

**Group and Contributions**

Alejandro *(Alex)* Mejia Moysen - 100862130

Ethan Gibson - 100862130

Venus Poon - 100861849

![Video](https://drive.google.com/file/d/1FDrMU7xphL2NtYLNjQMafXdLSs9_giqg/view?usp=sharing)

*if link broken*
https://drive.google.com/file/d/1FDrMU7xphL2NtYLNjQMafXdLSs9_giqg/view?usp=sharing

*For code explanations:*
https://docs.google.com/document/d/1szqNrgIhF085QIHHwLa5YBssufRFD-E9BiUDgDFfSik/edit?usp=sharing

***Alex:***

*Assignment 1*

Fireball Shader

Shield Shader

Outline Shader

HealthBar Shader

Zone LUT

*Final Assignment*

Backend Code

Black Hole Explosion VFX

Fireball VFX

Fireball Imapct VFX

Jump VFX

Body Slam VFX

Poisonous Cloud VFX

Paintball impact VFX upgrades

Paintball impact VFX textures

***Ethan:***

*Assignment 1*

Unlit

Ambient

Specular

Ambient + Specular

Ambient + Specular + Toon

Ambient + Specular + Breathing

*Final Assignment*
Background code to meet deliverables

Paintball impact VFX

Updates to practice range

***Venus:***

*Assignment 1*

Reports

*Final Assignment*

Dummy Statue + Textures

Modular Map Model + Textures

Dummy Model + Textures

**Acknowledgements**


The playable character is from Mixamo.
However, the movement code that makes the character model move is made by our group.
The current scene map is the practice range which is blocked out using Probuilder.

**Assignment 1:**

**Part 1: Base**


The scene consists of a practice range for players to try out different core game mechanics.
Here, players can see the effects of different barrels to dummies.
They are also able to try utilising abilities in this range in order to get a grasp of what everything does.
The model of the dummy was made by Venus, the scene made and populated by Ethan, and the code for movement and shooting were done by Alex.


**Part 2: Illumination**


In Intro to Computer Graphics, the professor introduced illumination and the different types.
In this project, the code from those classes were used and implemented into materials.
These materials were then applied to primitive spheres. There were also two more additional effects implemented.

These are: toon shader and a dynamic specular powered shader. These were done by Ethan.


**Part 3: Colour Grading**


To start off with colour grading, a screenshot was taken of the game. A neutral LUT image file was downloaded from the Intro to Computer Graphics class, as well as other neutral LUTs were taken from the internet, specifically from OBS.  From here, they were taken into Photoshop and the filters for Protanopia-type and Deuteranopia-type colour blindness filters were applied. A screenshot of the LUTs with the filter applied were screenshotted as Photoshop only applies the colour blindness filter for the app but not the actual image. The Purple LUT was made by Alex for a game mechanic, while the Protanopia LUT and Deuteranopia LUT were made by Venus for accessibility.


The following are the LUTs used:


**Purple LUT**

![Purple Lut](https://github.com/alex-memo/ProjectM-CG/blob/main/ZoneLUT.png?raw=true)


**Protanope LUT**

![Protanope Lut](https://github.com/alex-memo/ProjectM-CG/blob/main/Protanope.png?raw=true)


**Deuteranope LUT**

![Deuteranope Lut](https://github.com/alex-memo/ProjectM-CG/blob/main/Deuteranope.png?raw=true)

With these LUTs, the colour grading shaders were made. Purple LUT was made into a colour grading screen effect shader using shadergraph. The colour blindness colour grading screen effects makes use of code from Intro to Computer Graphics. This is implemented by Ethan using Canvas and Images.

**Part 4: Shaders and Effects**


There are a total of four shaders implemented in this scene. They are: the fireball shader, the outline shader, the shield shader, and the health bar shader. The themes for these were sci fi, comic, and fantasy. The fireball shader was created by Alex. It uses a scrolling texture with a gradient. The top part is covered in order to avoid distortion and then the vertex offset was added to give life to the fireball. The outline shader compares the normals of the screen, if the difference between normals are big enough, then a line is added between the different two normals. The same is done to colours. If colours are too different, an outline is overlaid onto the screen colour. The shield texture has a rim light, scroll effect, and an inner glow effect. Finally the health bar shader is made using the ben day effect. It compares if the pixel colour is greater than 0.3f, that gives us the circles. Both the health and shield bars have gradient effects. The color fades out (0.05) before the end of each bar, creating a fade-out gradient on the last portion of the bar. A smooth step function is applied across a gradient range (from -0.5 to 0.5), then multiplied by a Voronoi effect to add texture. This is applied to both health and shield. The current shield value is subtracted from the health value to create a mask, ensuring that the shield appears on top of the health bar. Colors are multiplied for both health and shield with their respective effects. This creates the intended color and blend effect. Both shield and health bars undergo a max operation for color values, with the shield overlaid on top of the health. To create the alpha mask, we maximize the premultiplied colour texture with their respective ben day effect of the shield and health bar. Then, we saturate it and the alpha mask is the result. After masking, a premultiplied alpha is calculated by saturating values to ensure no alpha exceeds 1, finalizing the transparency effect.

Final Assignment:
=
**Improvements**

There are newly added textures for the map compared to the previous assignment submission. Camera has been updated to use new features added to Cinemachine as well as implementing a zoom for the weapons that need it.

**Texturing**

Texture images are created and finalized by the group. The textures used specifically for the map and dummy statue are both of Marble to create a sophisticated look and feel. This also minimizes player distraction to the environment while they are playing around in the practice tool.

(Talk about texture sampling here in the shaders and how are things being toggled on and off)

**VFX**

(Type here)

Paintball Impact VFX Textures were made in substance designer.

Streaks were reused for the fireball and bodyslam vfx, they were made by hand procreate.

Black Hole Explosion VFX was created with a sphere and a torus with distortion, with 4 sprites for the explosion

Fireball Imapct VFX uses a flare, glow, streaks and camera rotation to ensure that the streaks are always on top where teh camera is facing.

Body Slam VFX was created with 2 glow effects, a cone with a hole in the center, squash and stretch, and streaks.

Jump VFX is reusing a modular ring vfx, modular smoke vfx and core concepts from body slam

Poisonous Cloud VFX is a sphere with a shader to make the illussion of volumetric smoke, with modular smoke particles to make it look like smoke is coming out of the sphere.

This was not the repository that is being worked on, this is a forked repo from Project M, which is private
=
***Project M***

*Description*

Project M is a 3v3 competitive team deathmatch, with modular loadouts, that combines a comic style and fantasy world together in a city setting.
This project contains a forked practice range that is being developed for project M for players to be able to test their abilities and tools, and learn interactions between different game elements.

![Jira Timeline](https://github.com/alex-memo/ProjectM-Assignment1/blob/main/JiraTimeline.png?raw=true)

***External Resources***

3D character from Mixamo.com *A private model for Project M is on the original repository but will not be made available in any public repo*

***Notice:*** Distribution, copying, or cloning of this repository or code is strictly prohibited as it is not allowed.
