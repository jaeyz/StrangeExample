using UnityEngine;
using System.Collections;

public class PlayerModel : IPlayer {

	private string playerName;
	private string playerRole;

	public string PlayerName {
		get { 
			return playerName; 
		} 
	}

	public string Role {
		get {
			return playerRole;
		}
	}

	public void SetPlayerName (string name) {
		playerName = name;
	}

	public void SetRole (string role) {
		playerRole = role;
	}


}
