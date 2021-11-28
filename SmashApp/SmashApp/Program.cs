using System;
using System.Collections.Generic;

namespace SmashApp
{
    class Program
    {
        static void Main(string[] args)
        {
           //Buidling Character/Stage Obj
              /*  string[] characters = { "Banjo & Kazooie",
                                        "Bayonetta",
                                        "Bowser",
                                        "Bowser Jr",
                                        "Byleth",
                                        "Captain Falcon",
                                        "Chrom",
                                        "Cloud",
                                        "Corrin",
                                        "Daisy",
                                        "Dark Pit",
                                        "Dark Samus",
                                        "Diddy Kong",
                                        "Donkey Kong",
                                        "Dr. Mario",
                                        "Duck Hunt",
                                        "Falco",
                                        "Fox",
                                        "Ganondorf",
                                        "Greninja",
                                        "Hero",
                                        "Ice Climbers",
                                        "Ike",
                                        "Incineroar",
                                        "Inkling",
                                        "Isabelle",
                                        "Jigglypuff",
                                        "Joker",
                                        "Kazuya",
                                        "Ken",
                                        "King Dedede",
                                        "King K. Rool",
                                        "Kirby",
                                        "Link",
                                        "Little Mac",
                                        "Lucario",
                                        "Lucas",
                                        "Lucina",
                                        "Luigi",
                                        "Mario",
                                        "Marth",
                                        "Mega Man",
                                        "Meta Knight",
                                        "Mewtwo",
                                        "Mii Brawler",
                                        "Mii Gunner",
                                        "Mii Swordfighter",
                                        "Min Min",
                                        "Mr. Game & Watch",
                                        "Mythra",
                                        "Ness",
                                        "Olimar",
                                        "Pac-Man",
                                        "Palutena",
                                        "Peach",
                                        "Pichu",
                                        "Pikachu",
                                        "Piranha Plant",
                                        "Pit",
                                        "Pokemon Trainer",
                                        "Pyra",
                                        "Richter",
                                        "Ridley",
                                        "R.O.B.",
                                        "Robin",
                                        "Rosalina & Luma",
                                        "Roy",
                                        "Ryu",
                                        "Samus",
                                        "Sephiroth",
                                        "Sheik",
                                        "Shulk",
                                        "Simon",
                                        "Snake",
                                        "Sonic",
                                        "Sora",
                                        "Steve",
                                        "Terry",
                                        "Toon Link",
                                        "Villager",
                                        "Wario",
                                        "Wii Fit Trainer",
                                        "Wolf",
                                        "Yoshi",
                                        "Young Link",
                                        "Zelda",
                                        "Zero Suit Samus"};*/
                //string[] starterStages = { "Battlefield", "Small Battlefield", "Pokemon Stadium 2", "Smashville", "Town and City" }; //starter stages
                //string[] counterpickStages = { "Kalos Pokemon League", "Final Destination", "Yoshi's Story" }; //counterpick stages

           //Starters objs
            Stage Battlefield = new Stage();
            Stage SmallBattlefield = new Stage();
            Stage PokemonStadium2 = new Stage();
            Stage Smashville = new Stage();
            Stage TownAndCity = new Stage();
           //CP objs
            Stage KalosPokemonLeague = new Stage();
            Stage FinalDestination = new Stage();
            Stage YoshisStory = new Stage();

            //Stage obj arrays
            Stage[] starters = {Battlefield, SmallBattlefield, PokemonStadium2, Smashville, TownAndCity};
            Stage[] allStages = {KalosPokemonLeague, FinalDestination, YoshisStory};
/*
            var allS = new List<string>(); //List of all stages
                allS.AddRange(starterStages);
                allS.AddRange(counterpickStages);

                string[] allStages = allS.ToArray();
                foreach (string res in allStages)
                {
                    Console.WriteLine(res);
                }//end foreach

 *  */
            //Variables
            
            //Flaggers to Advance Slides (temp)
                Boolean flagger = true;
                Boolean slide2 = false;
                Boolean slide3 = false;
                Boolean slide4 = false;
            //Setting up W/L Matrix 
                int p1 = 0;
                int p2 = 0;
                int[,] matchReport = new int[1, 2] {
                        {p1, p2}
                    };
                int totalGames = 5;

            do
            {
                Program.Slide1();
                if(slide2 == true) { //Advancement to slide 2: Game 1 Stage select
                    Program.Slide2();
                }//end slide2 if

                if (slide3 == true) {
                    Program.Slide3();
                }//end slide3 if

                if (slide4 == true){
                    Program.Slide4();
                }//end slide4 if
            }//end while
            while (flagger == true);
        }//end main

        private static void Slide1()
        {
            Console.WriteLine("Player 1 Name: ");
            String player1 = Console.ReadLine();

            Console.WriteLine("Player 2 Name: ");
            String player2 = Console.ReadLine();

            //Console.WriteLine("Is this a Best of 3 or Best of 5?");
            int totalGames = 5;

            //Plater 1 Character Selection
                //dropdown
            //Player 2 Character Selection
                //dropdown

            //Advance Button
                //Change Slide2 boolean
        } //end Slide1: Username and Character Selection

        private static void Slide2() {
        //clicks stage:
            //swap image --> grey image
        //Once there is one stage 
        }//end Slide2

        private static void Slide3(){

        }//end Slides3

        private static void Slide4(){

        }//Slide4
       
    }
    class Stage {
        Boolean banned = false;
        //source jpeg file?
    }//end stage
}
