using System.Collections.Generic;
using ProtoBuf;
using VRageMath;

namespace SEDclient {

	public static class Config {

		public static ModConfig setupConfig(){

			ModConfig config = new ModConfig();

			//Add custom SEDivers enemy Factions below
			//multiple entries may cause crashes
			//
			//Factions added will be constrained to their territory by SEDivers
			//
			//Format: {FACTION_TAG}
			//
			config.factions = new HashSet<string>{
				("SPRT")
			};

			//Add custom SEDivers allied Factions below
			//multiple entries may cause crashes
			//
			//Factions added will be constrained to your territory by SEDivers
			//
			//Format: {FACTION_TAG}
			//
			config.friendlyFactions = new HashSet<string>();


			//Add scoring grids down below
			//entries in here when destroyed will score capture progress on a sector (provided their faction owns the sector)
			//Duplicates may cause crash!
			//
			//Format: {GRID_NAME}
			//
			config.aggroShips = new HashSet<string>();


			//IN PROGRESS
			//Add support weapons (Or any item) available by stratagem below
			//duplicates may cause a crash
			//
			//Format: {WEAPON_SUBTYPEID}
			//
			config.supportWeapons = new HashSet<string>();

			return config;

		}

	}
}