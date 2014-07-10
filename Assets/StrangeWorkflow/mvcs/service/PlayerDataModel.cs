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
							playerDataUpdatedSignal.Dispatch();
						}
				}


		}

		private int _playerLevel;
		public int playerLevel {
				get {
						return _playerLevel;
				}
				set {
						if (_playerLevel != value) {
							_playerLevel = value;
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