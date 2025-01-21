[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity
Objects:
- Bunny (player)
	- Actions: 
		- Movement through wasd keys
		- Planting 1 seed with space at player’s location, increases plant count and decreases seed count in UI, cannot plant if seeds is 0
		- Able to move through/behind the plants and walk off screen
	- Attributes: Bunny sprite
- Plants
	- Actions:
		- Being planted by the player ^
		- No plants are on the scene when the game starts
	- Attributes: Plant sprite
- seeds planted UI
	- Actions:
		- Starting at 0
		- Increasing by 1 with every space key until it gets to 5
	- Attributes: Text
- seeds remaining UI
	- Actions:
		- Starting at 5 and decreases by 1 with every space key
		- Stops once it gets to 0
	- Attributes: Text

## Devlog
I planned to build HW1 by starting with the player. I inserted the bunny sprite onto the scene and made sure that the script added to the bunny GameObject added action to the bunny by moving with wasd keys with the GetKey method in an if statement. Additionally, I added the GetKeyDown method for the space key so that the plant can be planted. I had to make the plant a prefab before instantiating it at the player's location with _playerTransform.position. I also made sure that there wasn't more than 5 plants being planted. Lastly, I referenced the PlantCountUI script in the Player script so that the remaining seeds and seeds planted UI would be updated with each space key as well. Seeds planted started at 0 and increased by 1 while seeds remaining started at 5 and decreased by 1 until the _numSeeds counter is greater than 0 with the if statement, decreasing from 5 as well, after I dragged the TextMeshPro into the serialized field.

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites

## Prof comments
I'm unfortunately not able to give this Devlog full marks because it doesn't clearly connect the break-down that you wrote to the code. You mentioned a few features that you implemented, but you didn't describe how the code that you wrote connected to the plans you made.

For example, your breakdown did a good job of listing the attributes and actions for each object in the game. For example, when you said:

> I had to make the plant a prefab before instantiating it at the player's location with _playerTransform.position

You could have mentioned that in your plan, you needed a 'plant' object that had a sprite attribute, and the player object had the action of creating the plant. So, you created a Prefab in Unity to represent the 'plant' object, and gave it a SpriteRenderer component to fulfill the sprite attribute. You also implemented the Player.PlantSeed() function to call Instantiate() to make a copy of the plant Prefab at the player's position, which you got with _playerTransform.position. This amount of specificity- especially calling back to the attributes and actions found in your break-down - would earn you full points for this Devlog prompt. This specificity also helps me make sure that you're meeting this class's learning goal of being able to break down projects into plans for how you're going to code them.

Please make sure to read the Devlog prompt and answer it super clearly for HW2! :) I hope this feedback is helpful.

Please also consider formatting your break-down activities with the hyphen '-' symbol as suggested above, and remove the prompts. This will make it a lot easier for me to read. See the [README formatting guide here](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax).
