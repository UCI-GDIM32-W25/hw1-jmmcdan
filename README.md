[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

The player
  Movement
    WASD
  Creates plants
    Space
  Go behind the plants
  Go behind the UI
UI
  Seeds planted UI
    Text
    Starts at 0
    Counts up when player creates a plant
    Stops at 5
  Seeds remaining UI
    Text
    Starts at 5
    Counts down when player creates a plant
    Stops at 0
    Goes in front of player and plants
Plants
  No actions
  5 max
  Go in front of the player
  Go behind the UI
  They can overlap
  None in scene at the start


## Devlog
Prompt: Include the HW1 break-down exercise you wrote during the Week 1 - Lecture 2 (Jan 9) in-class activity (above). If you did not attend and perform this activity, review the lecture slides and write your own plan for how you believe HW1 should be built. If your initially proposed plan turned out significantly different than the activity answers given by Prof Reid, you may want to note what was different. Then, write about how the plan you wrote in the break-down connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.

My break-down of this assignment helped me quite a bit in executing my code and having it work properly. I basically just went through the sections of player, plants and UI to see each nessary method or chacteristic and then implement them. For example, one of the first things I did was to make it so the player could move, specfically using WASD, as I had stated in my breakdown. Since I had laid this out before hand I just knew I had the assign the four keys to four directions, which I did with the Input.GetKey method and Translate in Private Void Update(). Having the code check every frame if the player is pressing one of the four keys and if so moving the players position in the correlating direction. Another moment where my break down influenced my code was with the UI elements. As I noted its only action is to tick up or down as the player plants seeds. Due to noting this instead of having the UpdateSeeds put the _plantedText to "Seeds Planted:" + seedsPlanted, I just had it display seedsPlanted. This was helpful as putting my first idea probably would've interfered with the text that already exisited in the scene, and while not a huge deal is still a time saver.
Altogether this homework was pretty simple, and the break-down wasn't super needed. However, it still did help me understand how the break-down could be pretty helpful in more complex cases, saving me a lot of time and annoyance. So I am absolutely going to keep using this method in my future projects to assist me in my coding.


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
