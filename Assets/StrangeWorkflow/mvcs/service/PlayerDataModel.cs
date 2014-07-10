using UnityEngine;
using System.Collections;

public class PlayerDataModel : IPlayerModel
{
		private string _playerName;
		public string playerName {
				get {
						return _playerName;
				}
				set {
						if (_playerName != value) {
							_playerName = value;
							Debug.Log("Updated player name");
							playerDataUpdatedSignal.Dispatch();
						}
				}


		}
			
//		[Inject]
//		public GameListUpdatedSignal gameListUpdatedSignal {set;get;}
		[Inject]
		public PlayerDataUpdatedSignal playerDataUpdatedSignal { set; get; }

		public PlayerDataModel( )
		{
			//Debug.Log ("CustomModel.constructor()");

		}
			
		public void doClearAllData ()
		{
			//Debug.Log ("doClearAllData: ");
		}		
			
		[PostConstruct]
		public void postConstruct( )
		{
			//Debug.Log ("CustomModel.PostConstruct()");

			doClearAllData();

		}
			
}