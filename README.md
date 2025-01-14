[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

Put your notes from the W1L2 (Thurs, Jan 9) in-class activity here.

Objects:
Bunny (player)
	Actions: 
	Movement through wasd keys
	Planting 1 seed with space at player’s location, increases plant count and decreases seed count in UI, cannot plant if seeds is 0
	Able to move through/behind the plants and walk off screen
	Attributes: Bunny sprite
Plants
	Actions:
	Being planted by the player ^
	No plants are on the scene when the game starts
	Attributes: Plant sprite
seeds planted UI
	Actions:
	Starting at 0
	Increasing by 1 with every space key until it gets to 5
	Attributes: Text
seeds remaining UI
	Actions:
	Starting at 5 and decreases by 1 with every space key
	Stops once it gets to 0
	Attributes: Text


## Devlog
Prompt: Include the HW1 break-down exercise you wrote during the Week 1 - Lecture 2 (Jan 9) in-class activity (above). If you did not attend and perform this activity, review the lecture slides and write your own plan for how you believe HW1 should be built. If your initially proposed plan turned out significantly different than the activity answers given by Prof Reid, you may want to note what was different. Then, write about how the plan you wrote in the break-down connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.


Write your Devlog here!

I planned to build HW1 by starting with the player. I inserted the bunny sprite onto the scene and made sure that the script added to the bunny GameObject added action to the bunny by moving with wasd keys with the GetKey method in an if statement. Additionally, I added the GetKeyDown method for the space key so that the plant can be planted. I had to make the plant a prefab before instantiating it at the player's location with _playerTransform.position. I also made sure that there wasn't more than 5 plants being planted. Lastly, I referenced the PlantCountUI script in the Player script so that the remaining seeds and seeds planted UI would be updated with each space key as well. Seeds planted started at 0 and increased by 1 while seeds remaining started at 5 and decreased by 1 until the _numSeeds counter is greater than 0 with the if statement, decreasing from 5 as well, after I dragged the TextMeshPro into the serialized field.



## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
