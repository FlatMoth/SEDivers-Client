README
==========

This Example Mod will show you how to set up a NPC/Weapon mod that supports SEDivers

Below I've laid out some information/instructions to help you get started.

----------------------------------------------------------------------------------

1) copy the /Data/scripts folder into your mod's /Data folder to get started

2) Use the config.cs in /Data/scripts to set up factions, hand weapons, and ships
	- Enemy Factions put in to config.cs will be constrained to their territory
	- Allied Factions put in to config.cs will be constrained to your territory
	- Factions Omitted will be ignored
	- Ships/Stations added will score points towards sector capture when destroyed
		- ships 0-6.5K blocks - 2 pts
		- ships 6.5K+ blocks - 5 pts
		- stations 0-6.5K blocks - 5 pts
		- stations 6.5K+ blocks - 10 pts
	- Ships omitted will not score points
	- Weapons put into config.cs will be available to be received via stratagem
	
3) Mission Complete/Fail sounds can be swapped by overriding the sound subtypes in /Data/Audio_gui.sbc. Alternatively, delete /Data/Audio_gui.sbc to use defaults.
	- Mission Complete sound - ZoneCapped
	- Mission Fail sound - ZoneLost
	
4) This mod comes with all NPC grids/factions packaged inside. However, when setting up config.cs, you can specify 
	factions or grids from another NPC mod IF that mod is present and loaded before config.cs. If you do this, I highly
	recommend making the mod you reference a dependency to avoid bugs.
