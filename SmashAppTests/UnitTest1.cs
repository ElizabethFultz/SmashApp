using NUnit.Framework;
using SmashApp;
using System.IO;
using System;

namespace SmashAppTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {


        }

       [Test]
        public void Test1()
        {
            string settest = "";

            Set set1 = new();
            set1.p1 = "Aaron";
            set1.p2 = "Jaylon";
            set1.p1char = "Mario";
            set1.p2char = "Cloud";
            set1.stage = "Battlefield";
            set1.gameTotal--;
            set1.p1Win = 1;
            set1.p2Win = 0;

            Assert.Pass(settest, set1);
        }

        [Test]
        public void Test2()
        {
            string playertest = "";

            Player play = new();
            play.userName = "Jaylon";
            play.favCharacter = "Sephiroth";
            play.state = "Kentucky";
            play.city = "Louisville";

            Assert.Pass(playertest, play);
        }
    }
}
