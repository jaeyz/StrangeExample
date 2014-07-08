using System;

public interface IPlayer  {

	string PlayerName { get; }
	string Role { get; }

	void SetPlayerName(string name);
	void SetRole(string role);

}
