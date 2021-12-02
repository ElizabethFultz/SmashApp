using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmashApp
{
	public class Set
    {
		//int totalGames;
		public string p1;
		public string p2;
		public string p1char;
		public string p2char;
		public string stage;
		public int gameTotal;
		public int p1Win;
		public int p2Win;

		public Set()
		{
			p1 = "no input";
			p2 = "no input";
			p1char = "no input";
			p2char = "no inuput";
			gameTotal = 4;
			stage = "no input";
			p1Win = 0;
			p2Win = 0;
		}//default constuctor

		public Set(string player1username, string player2username, string player1char, string player2char, int totalG)
		{
			p1 = player1username;
			p2 = player2username;
			p1char = player1char;
			p2char = player2char;
			gameTotal = totalG;
			p1Win = 0;
			p2Win = 0;
		}//end constructor
	}//end class
}//end namespace
