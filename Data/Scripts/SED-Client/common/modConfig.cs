using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Sandbox.Definitions;
using Sandbox.Game;
using Sandbox.Game.Entities;
using Sandbox.Game.Entities.Cube;
using Sandbox.ModAPI;
using Sandbox.ModAPI;
using VRageMath;
using VRage;
using VRage.ObjectBuilders;
using VRage.ModAPI;
using VRage.Utils;
using VRage.Game.Components;
using VRage.Game;
using VRage.Game.ModAPI;
using System.Collections.Concurrent;
using Sandbox.Game.EntityComponents;
using VRage.Game.Entity;

using ProtoBuf;


namespace SEDclient {
	
	[ProtoContract]
	public class ModConfig : Payload {
		
		[ProtoMember(1)]
		public PayloadType type = PayloadType.modConfig;
		
		[ProtoMember(2)]
		public string contents;
		
		[ProtoMember(3)]
		public HashSet<string> factions = new HashSet<string>();
		
		[ProtoMember(4)]
		public HashSet<string> friendlyFactions = new HashSet<string>();
		
		[ProtoMember(5)]
		public HashSet<string> aggroShips = new HashSet<string>();
		
		[ProtoMember(6)]
		public HashSet<string> supportWeapons = new HashSet<string>();
		
	}
	
}