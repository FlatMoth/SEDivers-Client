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

namespace SEDclient {
	
	public class transferInterfaceClient {
		
		private int port = 333;
		
		public void init(){
			MyAPIGateway.Utilities.RegisterMessageHandler(port, OnMsg);
		}
		
		public void close(){
			MyAPIGateway.Utilities.UnregisterMessageHandler(port, OnMsg);
		}
		
		public void sendConfig(ModConfig p){
			MyAPIGateway.Utilities.SendModMessage(port,  MyAPIGateway.Utilities.SerializeToBinary(p as ModConfig));
			
			//MyAPIGateway.Utilities.ShowMessage("Station Framework",  "Found Mod!");
		}
		
		public void OnMsg(object o){
			return;
		}
		
	}
	
}