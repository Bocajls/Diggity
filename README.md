# Diggity

```
TODO

[OK] Fix NAS remote access on router
Install Docker on NAS
Install MSSQL 2019 on Docker with highest compatibility level (140-150), cost threshold for parallelism (50)
[OK] Install MonoGame for solution
Implement EntityFramework with LINQ
Implement GameEngine

REMEMBER TO HAVE A LOT OF SMALL TEST PROJECTS
DOESNT NEED TO BE PERFECT FIRST TIME!!

FIGURE OUT SCHEDULER!
	Lots of events that need scheduleing, for example smelting ores, player mining, player movement, statistics, thermal dissipation, crafting.
	Automatic saving!

Figure out ship velocity AFTER TIMER (hard)
Figure out inventory window GRID and COMPONENTS (hard)
Figure out how to make items draggable (hard)
Implement sounds (intermediate)
Implement breaking texture (easy)

Other ideas
	Crafting Recipes (
		[IType,IType,IType]
		[IType,IType,IType]
		[IType,IType,IType]
	)

	Smeltery ([ore],[ore],[ore]) for ores into ingots.
	Multiple ores smelted into new special ingots.
	Ingots and minerals into components for ship.
	^ Important its made modularly to easily add new recipes and ingots.

	Being able to drag items from inventory into building slots and Storage-building.
	When moving away from buildings, the items must stay in the building, but building-window must close!
	^ Items placed in buildings must be saved! - otherwise they will disappear when game is reopened or when player moves away.

Buildings:
	Smeltery (maybe)
	Mineral Store (Sell only)
	Storage
	Crafting Station
	Quest Board
	Utilities Store (Buy only)
	Recipe Store
	Save Station

Blocks:
	Air
	Grass (0)
	Dirt (0)
	Gravel (1)
	Stone (0)
	Granite (5)
	Iron (10)
	Lead (25)
	Aluminum (30)
	Zinc (35)
	Copper (95)
	Nickel (250)
	Tin (450)
	Silver (7.500)
	Gold (58.000)
	Mythril (?)
	Adamant (?)

	Small Jade (100)
	Small Amethyst (1.000)
	Small Aquamarine (2.500)
	Small Black Opal (9.500)
	Small Red Beryl (10.000)
	Small Emerald (30.000)
	Small Musgravite (35.000)
	Small Alexandrite (70.000)
	Small Sapphire (150.000)
	Small Ruby (1.180.000)
	Small Pink Diamond (1.190.000)
	Small Jadeite (3.000.000)
	Small Blue Diamond (3.930.000) 

	(From previous game):
		Black Hole
		Rainbow
		SuperNova
		Uranium
		WingOfDeath
		WingOfLife
```
