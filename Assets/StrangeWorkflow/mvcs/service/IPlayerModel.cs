using UnityEngine;
using System.Collections;

public interface IPlayerModel {

		string playerName { get; set; }
		PlayerDataUpdatedSignal playerDataUpdatedSignal {set;get;}

		void doClearAllData();

}
