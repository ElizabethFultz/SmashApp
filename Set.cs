using System;

public class Set
{
	//int totalGames;
	string p1;
	string p2;
	string p1char;
	string p2char;
	string[] stageList;
	string stage;

	public Set()
    {
		p1 = "no input";
		p2 = "no input";
		p1char = "no input";
		p2char = "no inuput";
		stageList = new string[4];
		stage = "no input";
    }//default constuctor

	public Set(string player1username, string player2username, string player1char, string player2char, int totalG)
	{
		p1 = player1username;
		p2 = player2username;
		p1char = player1char;
		p2char = player2char;
		stageList = new string[totalG];
	}//end constructor
}
