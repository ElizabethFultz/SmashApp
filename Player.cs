using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmashApp
{
    class Player
    {
        string userName;
        string favCharacter;
        string state;
        string city;

        public Player()
        {
            userName = "no entry";
            favCharacter = "no entry";
            state = "no entry";
            city = "no entry";
        }//end player default constructor
        
        public Player(string userN, string favChar, string stat, string c)
        {
            userName = userN;
            favCharacter = favChar;
            state = stat;
            city = c;
        }//end Player pref constructor

    }//end Player Class
}//end namespace
