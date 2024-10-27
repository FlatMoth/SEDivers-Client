using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Sandbox.ModAPI;
using Sandbox.ModAPI.Interfaces;
using Sandbox.Game;
using Sandbox.Common;
using Sandbox.Common.ObjectBuilders;
using Sandbox.Common.Components;
using Sandbox.Common.ObjectBuilders.Definitions;
using Sandbox.Definitions;
using VRage.Game;


namespace SEDclient {

	[MySessionComponentDescriptor(MyUpdateOrder.Simulation, 999)]
	public class Client : MySessionComponentBase {
		
		private bool sent = true;
		
		
		transferInterfaceClient TIC = new transferInterfaceClient();
		
		public override void Init(MyObjectBuilder_SessionComponent sessionComponent){
			TIC.init();
			sent = false;
		}
		
		public override void Simulate(){
			
			if(!sent){
				TIC.sendConfig(Config.setupConfig());
				sent = true;
			}
		}
		
		protected override void UnloadData(){
			TIC.close();
		}
	
	}
		
		
}