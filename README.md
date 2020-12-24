# Games-Engines-Assignment

**Name:** Ivan Garcia

**Student Number:** C17463744

**Class Group:** DT228-4

**Project Name:** Rythm Fighter

**Proposal:** I will implement a 3D third person fighting game, which will use music and have a scoring system. The score is determined by how many objects you destroy, using punche, kicks or abilities. There will be music being played and on the screen you will be able to see an audio visualizer. If you attack during the high notes in the song, you will deal more damage, meaning you destroy more objects, thus getting a higher score. The aim is to match your attacks to the rythm of the song and deal as much damage as possible every attack. I will simply have the damage value be increased accordingly to the music being played.

I will be using the class notes but I have also looked into some videos to guide myself with.

**Videos/Tutorials**

https://www.youtube.com/watch?v=1wn5Ur1_vKg


**Submission Report**

**Description**

Concept was to have the player attack damage scale with the music, due to time constraints this was avoided and instead have the speed of the player be scaled to the Audio. Concept remains as the player will go up hills easier during beatdrops.

**Instructions**

Simply move around with  WASD. World generates infititely.
AudioAnalyzer clip may be missing when project is opened. MP3 was included, just drag and drop onto AudioVisializer's clip.
Unity Version used for this project: 2019.4.8f1

***Features:***
Only assets used weere RigidBodies, MeshRenderers and Colliders.
- Infinite landscape generation: Using vectors to generate each tile, I followed the guide provided in the lecture notes, and adapted it to be used with my tiles, which were implemented differently from the video. https://www.youtube.com/watch?v=dycHQFEz8VI
- Used ****PerlinNoise**** to generate bumps on each tile, and used position variables to have seemless transistions between tiles. This was adapted from the video.
- Camera follows player's object. Used class code.
- Generated a circle of orbs that follows the player's object. Had to implement myself, calculating the displacement from the beginning and keeping all orbs paralleland in a circle around the object.
- Used AudiAnalyzer provided in class.
- Implemented AudioVisualizers on all objects. Including land tiles, player's object, and orbs surrounding player, and camera.

***Proud***

Honestly I wasn't too fond of audio visualizing but it turned out super fun and the effects I implemented look very cool to me. I look forward to making it look much better.

***Youtube Video***
[![YouTube](http://img.youtube.com/vi/5WL2VmtU35I/0.jpg)](https://www.youtube.com/watch?v=5WL2VmtU35I)

