using UnityEngine;
using Facepunch;
using System.Collections.Generic;


namespace Tub
{
	public class Carry : Tub.BaseCarry, INetworkObserved, INetworkTakeover
	{
	   public string DisplayName;
	}
}
