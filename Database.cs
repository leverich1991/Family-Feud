using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyFeudPrism
{
    public class Database
    {
        #region question1
        public int answersLeft1;
        public string question1;
        public string question1Number1;
        public int question1Number1Points;
        public string question1Number2;
        public int question1Number2Points;
        public string question1Number3;
        public int question1Number3Points;
        public string question1Number4;
        public int question1Number4Points;
        public string question1Number5;
        public int question1Number5Points;
        public string question1Number6;
        public int question1Number6Points;
        public string question1Number7;
        public int question1Number7Points;
        public string question1Number8;
        public int question1Number8Points;
        public string question1Number9;
        public int question1Number9Points;
        #endregion

        #region question2
        public int answersLeft2;
        public string question2;
        public string question2Number1;
        public int question2Number1Points;
        public string question2Number2;
        public int question2Number2Points;
        public string question2Number3;
        public int question2Number3Points;
        public string question2Number4;
        public int question2Number4Points;
        public string question2Number5;
        public int question2Number5Points;
        public string question2Number6;
        public int question2Number6Points;
        public string question2Number7;
        public int question2Number7Points;
        public string question2Number8;
        public int question2Number8Points;
        public string question2Number9;
        public int question2Number9Points;
        #endregion

        #region question3Double
        public int answersLeft3;
        public string question3;
        public string question3Number1;
        public int question3Number1Points;
        public string question3Number2;
        public int question3Number2Points;
        public string question3Number3;
        public int question3Number3Points;
        public string question3Number4;
        public int question3Number4Points;
        public string question3Number5;
        public int question3Number5Points;
        public string question3Number6;
        public int question3Number6Points;
        public string question3Number7;
        public int question3Number7Points;
        public string question3Number8;
        public int question3Number8Points;
        #endregion

        #region question4Double
        public int answersLeft4;
        public string question4;
        public string question4Number1;
        public int question4Number1Points;
        public string question4Number2;
        public int question4Number2Points;
        public string question4Number3;
        public int question4Number3Points;
        public string question4Number4;
        public int question4Number4Points;
        public string question4Number5;
        public int question4Number5Points;
        public string question4Number6;
        public int question4Number6Points;
        public string question4Number7;
        public int question4Number7Points;
        public string question4Number8;
        public int question4Number8Points;
        #endregion

        #region question5Triple
        public int answersLeft5;
        public string question5;
        public string question5Number1;
        public int question5Number1Points;
        public string question5Number2;
        public int question5Number2Points;
        public string question5Number3;
        public int question5Number3Points;
        public string question5Number4;
        public int question5Number4Points;
        public string question5Number5;
        public int question5Number5Points;
        #endregion

        #region fastmoney
        public string fastMoneyQuestion1;
        public Dictionary<string, Tuple<int, int>> fastMoney1Data = new Dictionary<string, Tuple<int, int>>();
        public string fastMoneyQuestion2;
        public Dictionary<string, Tuple<int, int>> fastMoney2Data = new Dictionary<string, Tuple<int, int>>();
        public string fastMoneyQuestion3;
        public Dictionary<string, Tuple<int, int>> fastMoney3Data = new Dictionary<string, Tuple<int, int>>();
        public string fastMoneyQuestion4;
        public Dictionary<string, Tuple<int, int>> fastMoney4Data = new Dictionary<string, Tuple<int, int>>();
        public string fastMoneyQuestion5;
        public Dictionary<string, Tuple<int, int>> fastMoney5Data = new Dictionary<string, Tuple<int, int>>();
        public int perfectGame;
        public string[] topAnswers = new string[10];
        #endregion
        //game 1
        public void generateGame1()
        {
            //question1
            answersLeft1 = 8;
            question1 = "Name a poker hand.";
            question1Number1 = "Royal Flush";
            question1Number1Points = 27;
            question1Number2 = "Full House";
            question1Number2Points = 23;
            question1Number3 = "Flush";
            question1Number3Points = 14;
            question1Number4 = "Straight";
            question1Number4Points = 7;
            question1Number5 = "4 Of A Kind";
            question1Number5Points = 6;
            question1Number6 = "Pair";
            question1Number6Points = 6;
            question1Number7 = "Straight Flush";
            question1Number7Points = 5;
            question1Number8 = "3 Of A Kind";
            question1Number8Points = 4; //TOTAL: 92
            //end question 1

            //question2
            answersLeft2 = 6;
            question2 = "Name a brand of potato chips."; //second question
            question2Number1 = "Lays";
            question2Number1Points = 43;
            question2Number2 = "Doritos";
            question2Number2Points = 31;
            question2Number3 = "Pringles";
            question2Number3Points = 10;
            question2Number4 = "Ruffles";
            question2Number4Points = 7;
            question2Number5 = "Kettle";
            question2Number5Points = 2;
            question2Number6 = "Sun Chips";
            question2Number6Points = 2; //TOTAL: 95
            //end question 2

            //question3
            answersLeft3 = 5;
            question3 = "Name something tired people do.";
            question3Number1 = "Yawn";
            question3Number1Points = 52;
            question3Number2 = "Sleep";
            question3Number2Points = 23;
            question3Number3 = "Drink Coffee";
            question3Number3Points = 15;
            question3Number4 = "Forget";
            question3Number4Points = 2;
            question3Number5 = "Move Slowly";
            question3Number5Points = 2; //TOTAL: 94 DOUBLED: 188
            //end question3

            //question4
            answersLeft4 = 7;
            question4 = "Name a Canadian rock band.";
            question4Number1 = "Nickelback";
            question4Number1Points = 19;
            question4Number2 = "Rush";
            question4Number2Points = 19;
            question4Number3 = "Bachman-Turner Overdrive";
            question4Number3Points = 17;
            question4Number4 = "Loverboy";
            question4Number4Points = 13;
            question4Number5 = "Three Days Grace";
            question4Number5Points = 9;
            question4Number6 = "Arcade Fire";
            question4Number6Points = 6;
            question4Number7 = "Sum 41";
            question4Number7Points = 5; //TOTAL: 88 DOUBLED: 176
            //end question4

            //question5
            answersLeft5 = 4;
            question5 = "Name an informal slang name for a male.";
            question5Number1 = "Dude";
            question5Number1Points = 56;
            question5Number2 = "Guy";
            question5Number2Points = 29;
            question5Number3 = "Bro";
            question5Number3Points = 6;
            question5Number4 = "Man";
            question5Number4Points = 3; //Total: 94 TRIPLED: 282
            //end question5

            //fastmoney question 1
            fastMoneyQuestion1 = "Name a Canadian province.";
            fastMoney1Data.Add("Quebec", new Tuple<int, int>(29, 1));
            fastMoney1Data.Add("Ontario", new Tuple<int, int>(24, 2));
            fastMoney1Data.Add("British Columbia", new Tuple<int, int>(15, 3));
            fastMoney1Data.Add("Alberta", new Tuple<int, int>(8, 3));
            fastMoney1Data.Add("Manitoba", new Tuple<int, int>(8, 3));
            fastMoney1Data.Add("Saskatchewan", new Tuple<int, int>(6, 3));
            fastMoney1Data.Add("New Brunswick", new Tuple<int, int>(3, 3));
            fastMoney1Data.Add("Newfoundland", new Tuple<int, int>(3, 3));
            //end fastmoney question 1

            //fastmoney question 2
            fastMoneyQuestion2 = "The age a person graduates college.";
            fastMoney2Data.Add("22", new Tuple<int, int>(35, 1));
            fastMoney2Data.Add("23", new Tuple<int, int>(23, 2));
            fastMoney2Data.Add("21", new Tuple<int, int>(14, 3));
            fastMoney2Data.Add("24", new Tuple<int, int>(9, 3));
            fastMoney2Data.Add("25", new Tuple<int, int>(8, 3));
            fastMoney2Data.Add("20", new Tuple<int, int>(2, 3));
            fastMoney2Data.Add("26", new Tuple<int, int>(2, 3));
            //end fastmoney question 2

            //fastmoney question 3
            fastMoneyQuestion3 = "An instrument in a country band.";
            fastMoney3Data.Add("Violin", new Tuple<int, int>(28, 1));
            fastMoney3Data.Add("Banjo", new Tuple<int, int>(26, 2));
            fastMoney3Data.Add("Guitar", new Tuple<int, int>(19, 3));
            fastMoney3Data.Add("Piano", new Tuple<int, int>(13, 3));
            fastMoney3Data.Add("Singer", new Tuple<int, int>(5, 3));
            fastMoney3Data.Add("Drums", new Tuple<int, int>(2, 3));
            //end fastmoney question 3

            //fastmoney question 4
            fastMoneyQuestion4 = "A sport more popular in Europe than in the US.";
            fastMoney4Data.Add("Soccer", new Tuple<int, int>(53, 1));
            fastMoney4Data.Add("Cricket", new Tuple<int, int>(21, 2));
            fastMoney4Data.Add("Rugby", new Tuple<int, int>(7, 3));
            fastMoney4Data.Add("Tennis", new Tuple<int, int>(4, 3));
            fastMoney4Data.Add("Golf", new Tuple<int, int>(2, 3));
            fastMoney4Data.Add("Racing", new Tuple<int, int>(2, 3));
            //end fastmoney question 4

            //fastmoney question 5
            fastMoneyQuestion5 = "Something that can be marketed as sugar-free.";
            fastMoney5Data.Add("Soft Drinks", new Tuple<int, int>(50, 1));
            fastMoney5Data.Add("Gum", new Tuple<int, int>(16, 2));
            fastMoney5Data.Add("Candy", new Tuple<int, int>(9, 3));
            fastMoney5Data.Add("Coffee", new Tuple<int, int>(5, 3));
            fastMoney5Data.Add("Jello", new Tuple<int, int>(3, 3));
            fastMoney5Data.Add("Kool-Aid", new Tuple<int, int>(3, 3));
            fastMoney5Data.Add("Cake", new Tuple<int, int>(2, 3));
            fastMoney5Data.Add("Splenda", new Tuple<int, int>(2, 3));
            //endfastmoney question 5

            //topAnswers
            topAnswers[0] = "Quebec";
            topAnswers[1] = "22";
            topAnswers[2] = "Violin";
            topAnswers[3] = "Soccer";
            topAnswers[4] = "Soft Drinks";
            topAnswers[5] = "Ontario";
            topAnswers[6] = "23";
            topAnswers[7] = "Banjo";
            topAnswers[8] = "Cricket";
            topAnswers[9] = "Gum";
            //end topAnswers
            perfectGame = 305;
        }
        //game 2
        public void generateGame2()
        {
            //question1
            answersLeft1 = 7;
            question1 = "Name any Peanuts character.";
            question1Number1 = "Charlie Brown";
            question1Number1Points = 62;
            question1Number2 = "Lucy";
            question1Number2Points = 8;
            question1Number3 = "Snoopy";
            question1Number3Points = 8;
            question1Number4 = "Linus";
            question1Number4Points = 4;
            question1Number5 = "Woodstock";
            question1Number5Points = 4;
            question1Number6 = "Peppermint Patty";
            question1Number6Points = 3;
            question1Number7 = "Schroeder";
            question1Number7Points = 3; //TOTAL: 92
            //end question1

            //question2
            answersLeft2 = 9;
            question2 = "Name a major city in South America.";
            question2Number1 = "Rio De Janeiro";
            question2Number1Points = 19;
            question2Number2 = "Lima";
            question2Number2Points = 16;
            question2Number3 = "Sao Paulo";
            question2Number3Points = 13;
            question2Number4 = "Buenos Aires";
            question2Number4Points = 12;
            question2Number5 = "Santiago";
            question2Number5Points = 8;
            question2Number6 = "Bogota";
            question2Number6Points = 5;
            question2Number7 = "Brasilia";
            question2Number7Points = 5;
            question2Number8 = "Caracas";
            question2Number8Points = 5;
            question2Number9 = "Quito";
            question2Number9Points = 4; //TOTAL: 87
            //end question2

            //question3
            answersLeft3 = 6;
            question3 = "Besides .com, name a common internet suffix.";
            question3Number1 = ".org";
            question3Number1Points = 38;
            question3Number2 = ".edu";
            question3Number2Points = 23;
            question3Number3 = ".gov";
            question3Number3Points = 17;
            question3Number4 = ".net";
            question3Number4Points = 9;
            question3Number5 = ".tv";
            question3Number5Points = 2;
            question3Number6 = ".us";
            question3Number6Points = 2; //Total: 91... Doubled: 182
            //end question3

            //question4
            answersLeft4 = 5;
            question4 = "Give me a nickname used for a woman's breasts.";
            question4Number1 = "Boobs";
            question4Number1Points = 58;
            question4Number2 = "Hooters";
            question4Number2Points = 16;
            question4Number3 = "Titties";
            question4Number3Points = 11;
            question4Number4 = "Melons";
            question4Number4Points = 3;
            question4Number5 = "Tatas";
            question4Number5Points = 3; //TOTAL: 91... DOUBLED: 182
            //endquestion4

            //question5
            answersLeft5 = 3;
            question5 = "Name a city in Louisiana.";
            question5Number1 = "New Orleans";
            question5Number1Points = 83;
            question5Number2 = "Baton Rouge";
            question5Number2Points = 8;
            question5Number3 = "Lafayette";
            question5Number3Points = 3; //Total: 94... Tripled: 282
            //endquestion5

            //fast money question 1
            fastMoneyQuestion1 = "Tell me how much you usually spend at Wal-Mart.";
            fastMoney1Data.Add("$100", new Tuple<int, int>(34, 1));
            fastMoney1Data.Add("$50", new Tuple<int, int>(29, 2));
            fastMoney1Data.Add("$200", new Tuple<int, int>(10, 3));
            fastMoney1Data.Add("$150", new Tuple<int, int>(6, 3));
            fastMoney1Data.Add("$75", new Tuple<int, int>(3, 3));
            fastMoney1Data.Add("$250", new Tuple<int, int>(3, 3));
            fastMoney1Data.Add("$20", new Tuple<int, int>(2, 3));
            fastMoney1Data.Add("$80", new Tuple<int, int>(2, 3));
            //end question 1

            //fast money question 2
            fastMoneyQuestion2 = "Name any meat.";
            fastMoney2Data.Add("Beef", new Tuple<int, int>(25, 1));
            fastMoney2Data.Add("Chicken", new Tuple<int, int>(23, 2));
            fastMoney2Data.Add("Pork", new Tuple<int, int>(15, 3));
            fastMoney2Data.Add("Turkey", new Tuple<int, int>(10, 3));
            fastMoney2Data.Add("Fish", new Tuple<int, int>(9, 3));
            fastMoney2Data.Add("Bacon", new Tuple<int, int>(3, 3));
            fastMoney2Data.Add("Ham", new Tuple<int, int>(3, 3));
            fastMoney2Data.Add("Crab", new Tuple<int, int>(2, 3));
            fastMoney2Data.Add("Deer", new Tuple<int, int>(2, 3));
            fastMoney2Data.Add("Lamb", new Tuple<int, int>(2, 3));
            fastMoney2Data.Add("Lobster", new Tuple<int, int>(2, 3));
            fastMoney2Data.Add("Steak", new Tuple<int, int>(2, 3));
            //end question 2

            //fast money question 3
            fastMoneyQuestion3 = "A city that has hosted the Summer Olympics.";
            fastMoney3Data.Add("Athens", new Tuple<int, int>(43, 1));
            fastMoney3Data.Add("London", new Tuple<int, int>(18, 2));
            fastMoney3Data.Add("Sydney", new Tuple<int, int>(12, 3));
            fastMoney3Data.Add("Beijing", new Tuple<int, int>(5, 3));
            fastMoney3Data.Add("Tokyo", new Tuple<int, int>(5, 3));
            fastMoney3Data.Add("Atlanta", new Tuple<int, int>(4, 3));
            fastMoney3Data.Add("Rome", new Tuple<int, int>(3, 3));
            fastMoney3Data.Add("Los Angeles", new Tuple<int, int>(2, 3));
            fastMoney3Data.Add("Paris", new Tuple<int, int>(2, 3));
            //end question 3

            //fast money question 4
            fastMoneyQuestion4 = "Any British Prime Minister (last name only).";
            fastMoney4Data.Add("Thatcher", new Tuple<int, int>(23, 1));
            fastMoney4Data.Add("Cameron", new Tuple<int, int>(17, 2));
            fastMoney4Data.Add("Disraeli", new Tuple<int, int>(16, 3));
            fastMoney4Data.Add("Blair", new Tuple<int, int>(11, 3));
            fastMoney4Data.Add("Churchill", new Tuple<int, int>(11, 3));
            fastMoney4Data.Add("Brown", new Tuple<int, int>(4, 3));
            fastMoney4Data.Add("Major", new Tuple<int, int>(4, 3));
            fastMoney4Data.Add("Heath", new Tuple<int, int>(2, 3));
            fastMoney4Data.Add("Macmillan", new Tuple<int, int>(2, 3));
            //end question 4

            //fast money question 5
            fastMoneyQuestion5 = "A good color to paint a baby girl's room.";
            fastMoney5Data.Add("Pink", new Tuple<int, int>(64, 1));
            fastMoney5Data.Add("Red", new Tuple<int, int>(15, 2));
            fastMoney5Data.Add("Purple", new Tuple<int, int>(9, 3));
            fastMoney5Data.Add("Blue", new Tuple<int, int>(3, 3));
            fastMoney5Data.Add("White", new Tuple<int, int>(3, 3));
            fastMoney5Data.Add("Magenta", new Tuple<int, int>(2, 3));
            //end question 5

            //topAnswers
            topAnswers[0] = "$100";
            topAnswers[1] = "Beef";
            topAnswers[2] = "Athens";
            topAnswers[3] = "Thatcher";
            topAnswers[4] = "Pink";
            topAnswers[5] = "$50";
            topAnswers[6] = "Chicken";
            topAnswers[7] = "London";
            topAnswers[8] = "Cameron";
            topAnswers[9] = "Red";
            //end topAnswers
            perfectGame = 291;
        }
        //game 3
        public void generateGame3()
        {
            //question 1
            answersLeft1 = 8;
            question1 = "Name a year that was also the first year of a war.";
            question1Number1 = "1941";
            question1Number1Points = 27;
            question1Number2 = "1861";
            question1Number2Points = 22;
            question1Number3 = "1914";
            question1Number3Points = 19;
            question1Number4 = "1775";
            question1Number4Points = 16;
            question1Number5 = "1950";
            question1Number5Points = 3;
            question1Number6 = "1955";
            question1Number6Points = 3;
            question1Number7 = "1939";
            question1Number7Points = 2;
            question1Number8 = "2001";
            question1Number8Points = 2; //TOTAL: 94
            //end question 1

            //question 2
            answersLeft2 = 6;
            question2 = "Name a famous ''Al.''";
            question2Number1 = "Al Gore";
            question2Number1Points = 32;
            question2Number2 = "Al Pacino";
            question2Number2Points = 30;
            question2Number3 = "Al Roker";
            question2Number3Points = 14;
            question2Number4 = "Al Sharpton";
            question2Number4Points = 8;
            question2Number5 = "Al Capone";
            question2Number5Points = 6;
            question2Number6 = "Al Jolson";
            question2Number6Points = 3; //TOTAL: 93
            //end question2

            //question3
            answersLeft3 = 6;
            question3 = "Name a city that has an NBA team but not an NFL team.";
            question3Number1 = "Toronto";
            question3Number1Points = 41;
            question3Number2 = "San Antonio";
            question3Number2Points = 22;
            question3Number3 = "Salt Lake City";
            question3Number3Points = 15;
            question3Number4 = "Portland";
            question3Number4Points = 8;
            question3Number5 = "Orlando";
            question3Number5Points = 6;
            question3Number6 = "Oklahoma City";
            question3Number6Points = 3; //TOTAL: 95... Doubled: 190
            //end question3

            //question4
            answersLeft4 = 7;
            question4 = "Name a winter resort city.";
            question4Number1 = "Aspen";
            question4Number1Points = 48;
            question4Number2 = "Park City";
            question4Number2Points = 30;
            question4Number3 = "Whistler";
            question4Number3Points = 4;
            question4Number4 = "Banff";
            question4Number4Points = 3;
            question4Number5 = "Cortina D'Ampezzo";
            question4Number5Points = 3;
            question4Number6 = "Steamboat Springs";
            question4Number6Points = 2;
            question4Number7 = "Telluride";
            question4Number7Points = 2; //Total: 92... Doubled: 184
            //end question4

            //question5
            answersLeft5 = 3;
            question5 = "Name one of the Four Horsemen of the Apocalypse.";
            question5Number1 = "Death";
            question5Number1Points = 46;
            question5Number2 = "War";
            question5Number2Points = 30;
            question5Number3 = "Famine";
            question5Number3Points = 22; //Total: 98... Tripled: 294
            //end question5

            //fast money question 1
            fastMoneyQuestion1 = "Name something a woman might put on to please her man.";
            fastMoney1Data.Add("Lingerie", new Tuple<int, int>(36, 1));
            fastMoney1Data.Add("Perfume", new Tuple<int, int>(20, 2));
            fastMoney1Data.Add("High Heels", new Tuple<int, int>(15, 3));
            fastMoney1Data.Add("Makeup", new Tuple<int, int>(9, 3));
            fastMoney1Data.Add("Lipstick", new Tuple<int, int>(7, 3));
            fastMoney1Data.Add("Music", new Tuple<int, int>(3, 3));
            fastMoney1Data.Add("Nothing", new Tuple<int, int>(2, 3));
            fastMoney1Data.Add("Underwear", new Tuple<int, int>(2, 3));
            //end question1

            //fast money question 2
            fastMoneyQuestion2 = "Your least favorite day of the week.";
            fastMoney2Data.Add("Monday", new Tuple<int, int>(47, 1));
            fastMoney2Data.Add("Tuesday", new Tuple<int, int>(27, 2));
            fastMoney2Data.Add("Wednesday", new Tuple<int, int>(18, 3));
            fastMoney2Data.Add("Thursday", new Tuple<int, int>(5, 3));
            fastMoney2Data.Add("Sunday", new Tuple<int, int>(2, 3));
            //end question 2

            //fast money question 3
            fastMoneyQuestion3 = "A breed of horse.";
            fastMoney3Data.Add("Thoroughbred", new Tuple<int, int>(31, 1));
            fastMoney3Data.Add("Mustang", new Tuple<int, int>(25, 2));
            fastMoney3Data.Add("Appaloosa", new Tuple<int, int>(14, 3));
            fastMoney3Data.Add("Paint", new Tuple<int, int>(9, 3));
            fastMoney3Data.Add("Arabian", new Tuple<int, int>(3, 3));
            fastMoney3Data.Add("Quarter", new Tuple<int, int>(3, 3));
            fastMoney3Data.Add("Andalusian", new Tuple<int, int>(2, 3));
            fastMoney3Data.Add("Miniature", new Tuple<int, int>(2, 3));
            fastMoney3Data.Add("Morgan", new Tuple<int, int>(2, 3));
            //end question 3

            //fast money question 4
            fastMoneyQuestion4 = "A sporting game that takes a long time to play.";
            fastMoney4Data.Add("Golf", new Tuple<int, int>(32, 1));
            fastMoney4Data.Add("Baseball", new Tuple<int, int>(31, 2));
            fastMoney4Data.Add("Football", new Tuple<int, int>(16, 3));
            fastMoney4Data.Add("Cricket", new Tuple<int, int>(7, 3));
            fastMoney4Data.Add("Tennis", new Tuple<int, int>(5, 3));
            fastMoney4Data.Add("Basketball", new Tuple<int, int>(2, 3));
            fastMoney4Data.Add("Hockey", new Tuple<int, int>(2, 3));
            fastMoney4Data.Add("Soccer", new Tuple<int, int>(2, 3));
            //end question4

            //fast money question 5
            fastMoneyQuestion5 = "Another way of saying ''Mother''.";
            fastMoney5Data.Add("Mom", new Tuple<int, int>(51, 1));
            fastMoney5Data.Add("Mama", new Tuple<int, int>(27, 2));
            fastMoney5Data.Add("Ma", new Tuple<int, int>(11, 3));
            fastMoney5Data.Add("Mommy", new Tuple<int, int>(5, 3));
            fastMoney5Data.Add("Madre", new Tuple<int, int>(2, 3));
            fastMoney5Data.Add("Mum", new Tuple<int, int>(2, 3));

            //topAnswers
            topAnswers[0] = "Lingerie";
            topAnswers[1] = "Monday";
            topAnswers[2] = "Thoroughbred";
            topAnswers[3] = "Golf";
            topAnswers[4] = "Mom";
            topAnswers[5] = "Perfume";
            topAnswers[6] = "Tuesday";
            topAnswers[7] = "Mustang";
            topAnswers[8] = "Baseball";
            topAnswers[9] = "Mama";
            //end topAnswers
            perfectGame = 327;
        }
        //game 4
        public void generateGame4()
        {
            //question1
            answersLeft1 = 7;
            question1 = "Name a bird that cannot fly.";
            question1Number1 = "Ostrich";
            question1Number1Points = 22;
            question1Number2 = "Penguin";
            question1Number2Points = 20;
            question1Number3 = "Chicken";
            question1Number3Points = 14;
            question1Number4 = "Emu";
            question1Number4Points = 14;
            question1Number5 = "Kiwi";
            question1Number5Points = 9;
            question1Number6 = "Turkey";
            question1Number6Points = 7;
            question1Number7 = "Cassowary";
            question1Number7Points = 3; //TOTAL: 89
            //end question 1

            //question2
            answersLeft2 = 6;
            question2 = "Name something you hope doesn't come with a rainstorm.";
            question2Number1 = "Hail";
            question2Number1Points = 28;
            question2Number2 = "Tornado";
            question2Number2Points = 27;
            question2Number3 = "Lightning";
            question2Number3Points = 21;
            question2Number4 = "Flooding";
            question2Number4Points = 14;
            question2Number5 = "Wind";
            question2Number5Points = 8;
            question2Number6 = "Thunder";
            question2Number6Points = 2; //TOTAL: 100
            //end question2

            //question3
            answersLeft3 = 8;
            question3 = "Past or present, name a famous late-night talk show host.";
            question3Number1 = "Johnny Carson";
            question3Number1Points = 25;
            question3Number2 = "Jay Leno";
            question3Number2Points = 17;
            question3Number3 = "David Letterman";
            question3Number3Points = 15;
            question3Number4 = "Jimmy Fallon";
            question3Number4Points = 14;
            question3Number5 = "Conan O'Brien";
            question3Number5Points = 8;
            question3Number6 = "Jimmy Kimmel";
            question3Number6Points = 5;
            question3Number7 = "Craig Ferguson";
            question3Number7Points = 4;
            question3Number8 = "Seth Meyers";
            question3Number8Points = 4; //Total: 92... Doubled: 184
            //end question3

            //question4
            answersLeft4 = 5;
            question4 = "Name a political ''George''.";
            question4Number1 = "George Washington";
            question4Number1Points = 58;
            question4Number2 = "George W. Bush";
            question4Number2Points = 17;
            question4Number3 = "George Mason";
            question4Number3Points = 10;
            question4Number4 = "George H. W. Bush";
            question4Number4Points = 3;
            question4Number5 = "George Wallace";
            question4Number5Points = 2; //Total: 90... Doubled: 180
            //end question4

            //question5
            answersLeft5 = 4;
            question5 = "Name a subatomic particle.";
            question5Number1 = "Electron";
            question5Number1Points = 39;
            question5Number2 = "Proton";
            question5Number2Points = 30;
            question5Number3 = "Neutron";
            question5Number3Points = 26;
            question5Number4 = "Quark";
            question5Number4Points = 4; //Total: 99... Tripled: 297
            //end question5

            //fast money question1
            fastMoneyQuestion1 = "Tell me how many boyfriends a girl goes through before finding a husband.";
            fastMoney1Data.Add("3", new Tuple<int, int>(38, 1));
            fastMoney1Data.Add("5", new Tuple<int, int>(24, 2));
            fastMoney1Data.Add("4", new Tuple<int, int>(22, 3));
            fastMoney1Data.Add("2", new Tuple<int, int>(7, 3));
            fastMoney1Data.Add("7", new Tuple<int, int>(3, 3));
            fastMoney1Data.Add("6", new Tuple<int, int>(3, 3));
            fastMoney1Data.Add("1", new Tuple<int, int>(2, 3));
            //end question 1

            //fast money question2
            fastMoneyQuestion2 = "Name a Gulf.";
            fastMoney2Data.Add("Mexico", new Tuple<int, int>(49, 1));
            fastMoney2Data.Add("Persian", new Tuple<int, int>(30, 2));
            fastMoney2Data.Add("Tonkin", new Tuple<int, int>(7, 3));
            fastMoney2Data.Add("Alaska", new Tuple<int, int>(2, 3));
            fastMoney2Data.Add("California", new Tuple<int, int>(2, 3));
            fastMoney2Data.Add("Saint Lawrence", new Tuple<int, int>(2, 3));
            //end question 2

            //fast money question 3
            fastMoneyQuestion3 = "A common flavor of popsicle.";
            fastMoney3Data.Add("Cherry", new Tuple<int, int>(24, 1));
            fastMoney3Data.Add("Chocolate", new Tuple<int, int>(21, 2));
            fastMoney3Data.Add("Strawberry", new Tuple<int, int>(17, 3));
            fastMoney3Data.Add("Watermelon", new Tuple<int, int>(15, 3));
            fastMoney3Data.Add("Orange", new Tuple<int, int>(13, 3));
            fastMoney3Data.Add("Lime", new Tuple<int, int>(3, 3));
            fastMoney3Data.Add("Banana", new Tuple<int, int>(2, 3));
            fastMoney3Data.Add("Lemon", new Tuple<int, int>(2, 3));
            //end question3

            //fast money question 4
            fastMoneyQuestion4 = "Name a punctuation symbol found on a keyboard.";
            fastMoney4Data.Add("?", new Tuple<int, int>(17, 1));
            fastMoney4Data.Add("!", new Tuple<int, int>(16, 2));
            fastMoney4Data.Add(".", new Tuple<int, int>(9, 3));
            fastMoney4Data.Add("&", new Tuple<int, int>(6, 3));
            fastMoney4Data.Add("@", new Tuple<int, int>(6, 3));
            fastMoney4Data.Add(",", new Tuple<int, int>(5, 3));
            fastMoney4Data.Add("'", new Tuple<int, int>(5, 3));
            fastMoney4Data.Add("#", new Tuple<int, int>(5, 3));
            fastMoney4Data.Add("(", new Tuple<int, int>(4, 3));
            fastMoney4Data.Add(")", new Tuple<int, int>(3, 3));
            fastMoney4Data.Add("+", new Tuple<int, int>(3, 3));
            fastMoney4Data.Add(":", new Tuple<int, int>(2, 3));
            fastMoney4Data.Add(";", new Tuple<int, int>(2, 3));
            fastMoney4Data.Add("$", new Tuple<int, int>(2, 3));
            fastMoney4Data.Add("*", new Tuple<int, int>(2, 3));
            //end question 4

            //fast money question 5
            fastMoneyQuestion5 = "Name a small state.";
            fastMoney5Data.Add("Rhode Island", new Tuple<int, int>(47, 1));
            fastMoney5Data.Add("Delaware", new Tuple<int, int>(22, 2));
            fastMoney5Data.Add("Connecticut", new Tuple<int, int>(11, 3));
            fastMoney5Data.Add("Massachusetts", new Tuple<int, int>(6, 3));
            fastMoney5Data.Add("New Hampshire", new Tuple<int, int>(4, 3));
            fastMoney5Data.Add("Vermont", new Tuple<int, int>(4, 3));
            fastMoney5Data.Add("New Jersey", new Tuple<int, int>(3, 3));
            fastMoney5Data.Add("Hawaii", new Tuple<int, int>(2, 3));
            //end question 5

            //topAnswers
            topAnswers[0] = "3";
            topAnswers[1] = "Mexico";
            topAnswers[2] = "Cherry";
            topAnswers[3] = "?";
            topAnswers[4] = "Rhode Island";
            topAnswers[5] = "5";
            topAnswers[6] = "Persian";
            topAnswers[7] = "Chocolate";
            topAnswers[8] = "!";
            topAnswers[9] = "Delaware";
            //end topAnswers
            perfectGame = 288;
        }
        //game 5
        public void generateGame5()
        {
            //question1
            answersLeft1 = 6;
            question1 = "Name a state with a large African-American population.";
            question1Number1 = "Louisiana";
            question1Number1Points = 33;
            question1Number2 = "New York";
            question1Number2Points = 31;
            question1Number3 = "Alabama";
            question1Number3Points = 15;
            question1Number4 = "Georgia";
            question1Number4Points = 9;
            question1Number5 = "Mississippi";
            question1Number5Points = 4;
            question1Number6 = "California";
            question1Number6Points = 2; //TOTAL: 94 
            //end question 1

            //question2
            answersLeft2 = 8;
            question2 = "Name a state with a lot of space but not a lot of people."; //second question
            question2Number1 = "Alaska";
            question2Number1Points = 55;
            question2Number2 = "Montana";
            question2Number2Points = 11;
            question2Number3 = "North Dakota";
            question2Number3Points = 10;
            question2Number4 = "Idaho";
            question2Number4Points = 6;
            question2Number5 = "Wyoming";
            question2Number5Points = 6;
            question2Number6 = "South Dakota";
            question2Number6Points = 3;
            question2Number7 = "Nebraska";
            question2Number7Points = 2;
            question2Number8 = "New Mexico";
            question2Number8Points = 2; //TOTAL: 95
            //end question 2

            //question3
            answersLeft3 = 7;
            question3 = "Name someone who appeared in the movie ''Rat Race''.";
            question3Number1 = "Whoopi Goldberg";
            question3Number1Points = 42;
            question3Number2 = "John Cleese";
            question3Number2Points = 12;
            question3Number3 = "Seth Green";
            question3Number3Points = 12;
            question3Number4 = "Rowan Atkinson";
            question3Number4Points = 10;
            question3Number5 = "Amy Smart";
            question3Number5Points = 7;
            question3Number6 = "Jon Lovitz";
            question3Number6Points = 6;
            question3Number7 = "Cuba Gooding Jr.";
            question3Number7Points = 4; //TOTAL: 93... Doubled: 186
            //end question3

            //question4
            answersLeft4 = 7;
            question4 = "Name something often forgotten by people when they go to work in the morning."; //longest possible
            question4Number1 = "Wallet";
            question4Number1Points = 34;
            question4Number2 = "Phone";
            question4Number2Points = 25;
            question4Number3 = "Lunch";
            question4Number3Points = 23;
            question4Number4 = "Breakfast";
            question4Number4Points = 3;
            question4Number5 = "Deodorant";
            question4Number5Points = 3;
            question4Number6 = "Coffee";
            question4Number6Points = 2;
            question4Number7 = "Glasses";
            question4Number7Points = 2; //TOTAL: 92... Doubled: 184
            //end question4

            //question5
            answersLeft5 = 4;
            question5 = "Name something people dip tortilla chips in.";
            question5Number1 = "Salsa";
            question5Number1Points = 81;
            question5Number2 = "Queso";
            question5Number2Points = 13;
            question5Number3 = "Bean Dip";
            question5Number3Points = 2;
            question5Number4 = "Guacamole";
            question5Number4Points = 2; //Total: 98... Tripled: 294
            //end question5

            //fastmoney question 1
            fastMoneyQuestion1 = "Name an insect people run away from upon seeing it.";
            fastMoney1Data.Add("Spider", new Tuple<int, int>(36, 1));
            fastMoney1Data.Add("Bee", new Tuple<int, int>(24, 2));
            fastMoney1Data.Add("Cockroach", new Tuple<int, int>(13, 3));
            fastMoney1Data.Add("Wasp", new Tuple<int, int>(10, 3));
            fastMoney1Data.Add("Mosquito", new Tuple<int, int>(6, 3));
            fastMoney1Data.Add("Ant", new Tuple<int, int>(2, 3));
            fastMoney1Data.Add("Dragonfly", new Tuple<int, int>(2, 3));
            fastMoney1Data.Add("Scorpion", new Tuple<int, int>(2, 3));
            //end fastmoney question 1

            //fastmoney question 2
            fastMoneyQuestion2 = "An illness that can keep your kid home from school for a week."; //longest possible
            fastMoney2Data.Add("Flu", new Tuple<int, int>(38, 1));
            fastMoney2Data.Add("Strep Throat", new Tuple<int, int>(20, 2));
            fastMoney2Data.Add("Chicken Pox", new Tuple<int, int>(14, 3));
            fastMoney2Data.Add("Bronchitis", new Tuple<int, int>(12, 3));
            fastMoney2Data.Add("Pneumonia", new Tuple<int, int>(9, 3));
            fastMoney2Data.Add("Cold", new Tuple<int, int>(2, 3));
            fastMoney2Data.Add("Lice", new Tuple<int, int>(2, 3));
            //end fastmoney question 2

            //fastmoney question 3
            fastMoneyQuestion3 = "The month with the best temperatures.";
            fastMoney3Data.Add("April", new Tuple<int, int>(27, 1));
            fastMoney3Data.Add("October", new Tuple<int, int>(23, 2));
            fastMoney3Data.Add("May", new Tuple<int, int>(22, 3));
            fastMoney3Data.Add("June", new Tuple<int, int>(13, 3));
            fastMoney3Data.Add("September", new Tuple<int, int>(6, 3));
            fastMoney3Data.Add("November", new Tuple<int, int>(3, 3));
            fastMoney3Data.Add("March", new Tuple<int, int>(2, 3));
            fastMoney3Data.Add("July", new Tuple<int, int>(2, 3));
            //end fastmoney question 3

            //fastmoney question 4
            fastMoneyQuestion4 = "The time of day most people take a nap.";
            fastMoney4Data.Add("2 PM", new Tuple<int, int>(25, 1));
            fastMoney4Data.Add("3 PM", new Tuple<int, int>(23, 2));
            fastMoney4Data.Add("4 PM", new Tuple<int, int>(19, 3));
            fastMoney4Data.Add("1 PM", new Tuple<int, int>(18, 3));
            fastMoney4Data.Add("7 PM", new Tuple<int, int>(7, 3));
            fastMoney4Data.Add("5 PM", new Tuple<int, int>(2, 3));
            fastMoney4Data.Add("6 PM", new Tuple<int, int>(2, 3));
            //end fastmoney question 4

            //fastmoney question 5
            fastMoneyQuestion5 = "A slang term for television.";
            fastMoney5Data.Add("TV", new Tuple<int, int>(65, 1));
            fastMoney5Data.Add("Tube", new Tuple<int, int>(13, 2));
            fastMoney5Data.Add("Telly", new Tuple<int, int>(8, 3));
            fastMoney5Data.Add("Boob Tube", new Tuple<int, int>(2, 3));
            fastMoney5Data.Add("Box", new Tuple<int, int>(2, 3));
            fastMoney5Data.Add("Small Screen", new Tuple<int, int>(2, 3));
            //endfastmoney question 5

            //topAnswers
            topAnswers[0] = "Spider";
            topAnswers[1] = "Flu";
            topAnswers[2] = "April";
            topAnswers[3] = "2 PM";
            topAnswers[4] = "TV";
            topAnswers[5] = "Bee";
            topAnswers[6] = "Strep Throat";
            topAnswers[7] = "October";
            topAnswers[8] = "3 PM";
            topAnswers[9] = "Tube";
            //end topAnswers
            perfectGame = 294;
        }
        //game 6
        public void generateGame6()
        {
            //question1
            answersLeft1 = 9;
            question1 = "Name a well-known movie series.";
            question1Number1 = "Star Wars";
            question1Number1Points = 29;
            question1Number2 = "The Lord of the Rings";
            question1Number2Points = 16;
            question1Number3 = "Harry Potter";
            question1Number3Points = 12;
            question1Number4 = "James Bond";
            question1Number4Points = 10;
            question1Number5 = "Pirates of the Caribbean";
            question1Number5Points = 6;
            question1Number6 = "The Fast and The Furious";
            question1Number6Points = 4;
            question1Number7 = "Spiderman";
            question1Number7Points = 3;
            question1Number8 = "Indiana Jones";
            question1Number8Points = 2;
            question1Number9 = "The Matrix";
            question1Number9Points = 2; //TOTAL: 84
            //end question1

            //question2
            answersLeft2 = 6;
            question2 = "Name a slang term for coffee.";
            question2Number1 = "Joe";
            question2Number1Points = 29;
            question2Number2 = "Java";
            question2Number2Points = 28;
            question2Number3 = "Brew";
            question2Number3Points = 26;
            question2Number4 = "Mud";
            question2Number4Points = 3;
            question2Number5 = "Caffeine Fix";
            question2Number5Points = 2;
            question2Number6 = "Mocha";
            question2Number6Points = 2; //TOTAL: 90
            //end question2

            //question3
            answersLeft3 = 6;
            question3 = "Name something illegal most people do anyways.";
            question3Number1 = "Speeding";
            question3Number1Points = 37;
            question3Number2 = "Smoking Marijuana";
            question3Number2Points = 33;
            question3Number3 = "Underage Drinking";
            question3Number3Points = 9;
            question3Number4 = "No Seat Belt";
            question3Number4Points = 8;
            question3Number5 = "Texting While Driving";
            question3Number5Points = 6;
            question3Number6 = "Trespassing";
            question3Number6Points = 2;  //Total: 95... Doubled: 190
            //end question3

            //question 4
            answersLeft4 = 4;
            question4 = "Name a pro sports team name that's used in more than one sport.";
            question4Number1 = "Giants";
            question4Number1Points = 47;
            question4Number2 = "Cardinals";
            question4Number2Points = 25;
            question4Number3 = "Rangers";
            question4Number3Points = 13;
            question4Number4 = "Jets";
            question4Number4Points = 8; //Total: 93... Doubled: 186
            //end question4

            //question5
            answersLeft5 = 5;
            question5 = "Name a bad guy in The Lord of the Rings.";
            question5Number1 = "Saruman";
            question5Number1Points = 38;
            question5Number2 = "Sauron";
            question5Number2Points = 37;
            question5Number3 = "Witch-King";
            question5Number3Points = 12;
            question5Number4 = "Gollum";
            question5Number4Points = 5;
            question5Number5 = "Nazgul";
            question5Number5Points = 2; //Total: 94... Tripled: 288
            //end question5

            //fast money question 1
            fastMoneyQuestion1 = "Tell me how long a car ride must be before it starts getting boring.";
            fastMoney1Data.Add("2 Hours", new Tuple<int, int>(24, 1));
            fastMoney1Data.Add("1 Hour", new Tuple<int, int>(22, 2));
            fastMoney1Data.Add("30 Minutes", new Tuple<int, int>(18, 3));
            fastMoney1Data.Add("3 Hours", new Tuple<int, int>(17, 3));
            fastMoney1Data.Add("1.5 Hours", new Tuple<int, int>(11, 3));
            fastMoney1Data.Add("45 Minutes", new Tuple<int, int>(3, 3));
            fastMoney1Data.Add("2.5 Hours", new Tuple<int, int>(2, 3));
            //end question1

            //fastmoney question 2
            fastMoneyQuestion2 = "Other than gold, name any precious metal.";
            fastMoney2Data.Add("Silver", new Tuple<int, int>(47, 1));
            fastMoney2Data.Add("Diamond", new Tuple<int, int>(27, 2));
            fastMoney2Data.Add("Platinum", new Tuple<int, int>(13, 3));
            fastMoney2Data.Add("Copper", new Tuple<int, int>(4, 3));
            fastMoney2Data.Add("Bronze", new Tuple<int, int>(2, 3));
            fastMoney2Data.Add("Iron", new Tuple<int, int>(2, 3));
            //end fastmoney question 2

            //fastmoney question 3
            fastMoneyQuestion3 = "Something policemen always carry on them.";
            fastMoney3Data.Add("Gun", new Tuple<int, int>(41, 1));
            fastMoney3Data.Add("Handcuffs", new Tuple<int, int>(28, 2));
            fastMoney3Data.Add("Taser", new Tuple<int, int>(8, 3));
            fastMoney3Data.Add("Flashlight", new Tuple<int, int>(5, 3));
            fastMoney3Data.Add("Pepper Spray", new Tuple<int, int>(5, 3));
            fastMoney3Data.Add("Badge", new Tuple<int, int>(4, 3));
            fastMoney3Data.Add("Pad", new Tuple<int, int>(2, 3));
            fastMoney3Data.Add("Radio", new Tuple<int, int>(2, 3));
            //end fastmoney question 3

            //fastmoney question 4
            fastMoneyQuestion4 = "Any square number.";
            fastMoney4Data.Add("4", new Tuple<int, int>(21, 1));
            fastMoney4Data.Add("25", new Tuple<int, int>(17, 2));
            fastMoney4Data.Add("9", new Tuple<int, int>(16, 3));
            fastMoney4Data.Add("16", new Tuple<int, int>(12, 3));
            fastMoney4Data.Add("100", new Tuple<int, int>(11, 3));
            fastMoney4Data.Add("64", new Tuple<int, int>(5, 3));
            fastMoney4Data.Add("36", new Tuple<int, int>(3, 3));
            fastMoney4Data.Add("49", new Tuple<int, int>(3, 3));
            fastMoney4Data.Add("49", new Tuple<int, int>(3, 3));
            fastMoney4Data.Add("81", new Tuple<int, int>(2, 3));
            fastMoney4Data.Add("144", new Tuple<int, int>(2, 3));
            //end fastmoney question 4

            //fastmoney question 5
            fastMoneyQuestion5 = "A red fruit.";
            fastMoney5Data.Add("Apple", new Tuple<int, int>(55, 1));
            fastMoney5Data.Add("Strawberry", new Tuple<int, int>(23, 2));
            fastMoney5Data.Add("Cherry", new Tuple<int, int>(11, 3));
            fastMoney5Data.Add("Cranberry", new Tuple<int, int>(4, 3));
            fastMoney5Data.Add("Raspberry", new Tuple<int, int>(2, 3));
            fastMoney5Data.Add("Watermelon", new Tuple<int, int>(2, 3));
            //endfastmoney question 5

            //topAnswers
            topAnswers[0] = "2 Hours";
            topAnswers[1] = "Silver";
            topAnswers[2] = "Gun";
            topAnswers[3] = "4";
            topAnswers[4] = "Apple";
            topAnswers[5] = "1 Hour";
            topAnswers[6] = "Diamond";
            topAnswers[7] = "Handcuffs";
            topAnswers[8] = "25";
            topAnswers[9] = "Strawberry";
            //end topAnswers
            perfectGame = 305;
        }
        //game 7
        public void generateGame7()
        {
            //question1
            answersLeft1 = 8;
            question1 = "Besides Mario, name a well-known Nintendo character.";
            question1Number1 = "Luigi";
            question1Number1Points = 19;
            question1Number2 = "Donkey Kong";
            question1Number2Points = 16;
            question1Number3 = "Zelda";
            question1Number3Points = 12;
            question1Number4 = "Peach";
            question1Number4Points = 11;
            question1Number5 = "Samus";
            question1Number5Points = 9;
            question1Number6 = "Link";
            question1Number6Points = 8;
            question1Number7 = "Kirby";
            question1Number7Points = 5;
            question1Number8 = "Wario";
            question1Number8Points = 5; //TOTAL: 85
            //end question 1

            //question2
            answersLeft2 = 7;
            question2 = "Name a language that someone who only knows English could not read at all.";
            question2Number1 = "Chinese";
            question2Number1Points = 29;
            question2Number2 = "Japanese";
            question2Number2Points = 26;
            question2Number3 = "Arabic";
            question2Number3Points = 15;
            question2Number4 = "Russian";
            question2Number4Points = 13;
            question2Number5 = "Korean";
            question2Number5Points = 7;
            question2Number6 = "Hebrew";
            question2Number6Points = 2;
            question2Number7 = "Hindi";
            question2Number7Points = 2; //TOTAL: 94
            //end question 2

            //question3
            answersLeft3 = 5;
            question3 = "Name someone involved in the French Revolution.";
            question3Number1 = "Marie Antoinette";
            question3Number1Points = 41;
            question3Number2 = "Louis XVI";
            question3Number2Points = 20;
            question3Number3 = "Napoleon";
            question3Number3Points = 19;
            question3Number4 = "Lafayette";
            question3Number4Points = 7;
            question3Number5 = "Robespierre";
            question3Number5Points = 4; //TOTAL: 91... Doubled: 182
            //end question3

            //question4
            answersLeft4 = 6;
            question4 = "Name a big expense in a teenage boy's life.";
            question4Number1 = "College";
            question4Number1Points = 37;
            question4Number2 = "Car";
            question4Number2Points = 34;
            question4Number3 = "Girlfriend";
            question4Number3Points = 17;
            question4Number4 = "Prom";
            question4Number4Points = 3;
            question4Number5 = "Alcohol";
            question4Number5Points = 2;
            question4Number6 = "Video Games";
            question4Number6Points = 2; //TOTAL: 95... Doubled: 190
            //end question4

            //question5
            answersLeft5 = 3;
            question5 = "Name a non-vulgar word used to refer to African-Americans.";
            question5Number1 = "Black";
            question5Number1Points = 89;
            question5Number2 = "Negro";
            question5Number2Points = 6;
            question5Number3 = "Colored";
            question5Number3Points = 2; //TOTAL: 97... Tripled: 291
            //end question5

            //fastmoney question 1
            fastMoneyQuestion1 = "Tell me how many people a city must have before it's considered a big city.";
            fastMoney1Data.Add("100,000", new Tuple<int, int>(28, 1));
            fastMoney1Data.Add("250,000", new Tuple<int, int>(23, 2));
            fastMoney1Data.Add("50,000", new Tuple<int, int>(16, 3));
            fastMoney1Data.Add("500,000", new Tuple<int, int>(8, 3));
            fastMoney1Data.Add("1,000,000", new Tuple<int, int>(6, 3));
            fastMoney1Data.Add("10,000", new Tuple<int, int>(3, 3));
            fastMoney1Data.Add("150,000", new Tuple<int, int>(2, 3));
            fastMoney1Data.Add("300,000", new Tuple<int, int>(2, 3));
            fastMoney1Data.Add("750,000", new Tuple<int, int>(2, 3));
            //end fastmoney question 1

            //fastmoney question 2
            fastMoneyQuestion2 = "A brand of perfume.";
            fastMoney2Data.Add("Chanel", new Tuple<int, int>(30, 1));
            fastMoney2Data.Add("Ralph Lauren", new Tuple<int, int>(16, 2));
            fastMoney2Data.Add("Gucci", new Tuple<int, int>(12, 3));
            fastMoney2Data.Add("Versace", new Tuple<int, int>(10, 3));
            fastMoney2Data.Add("Dior", new Tuple<int, int>(8, 3));
            fastMoney2Data.Add("Givenchy", new Tuple<int, int>(5, 3));
            fastMoney2Data.Add("Victoria's Secret", new Tuple<int, int>(5, 3));
            fastMoney2Data.Add("Vera Wang", new Tuple<int, int>(3, 3));
            fastMoney2Data.Add("Calvin Klein", new Tuple<int, int>(2, 3));
            fastMoney2Data.Add("Estee Lauder", new Tuple<int, int>(2, 3));
            //end fastmoney question 2

            //fastmoney question 3
            fastMoneyQuestion3 = "Something you find at a road intersection.";
            fastMoney3Data.Add("Stoplight", new Tuple<int, int>(35, 1));
            fastMoney3Data.Add("Stop Sign", new Tuple<int, int>(27, 2));
            fastMoney3Data.Add("Crosswalk", new Tuple<int, int>(20, 3));
            fastMoney3Data.Add("Cars", new Tuple<int, int>(5, 3));
            fastMoney3Data.Add("Pedestrians", new Tuple<int, int>(3, 3));
            fastMoney3Data.Add("Car Wreck", new Tuple<int, int>(2, 3));
            fastMoney3Data.Add("Motorcycle", new Tuple<int, int>(2, 3));
            //end fastmoney question 3

            //fastmoney question 4
            fastMoneyQuestion4 = "Something you do to grass.";
            fastMoney4Data.Add("Mow It", new Tuple<int, int>(41, 1));
            fastMoney4Data.Add("Water It", new Tuple<int, int>(36, 2));
            fastMoney4Data.Add("Smoke It", new Tuple<int, int>(6, 3));
            fastMoney4Data.Add("Plant It", new Tuple<int, int>(5, 3));
            fastMoney4Data.Add("Burn It", new Tuple<int, int>(2, 3));
            fastMoney4Data.Add("Cut It", new Tuple<int, int>(2, 3));
            fastMoney4Data.Add("Kill It", new Tuple<int, int>(2, 3));
            //end fastmoney question 4

            //fastmoney question 5
            fastMoneyQuestion5 = "A kind of bed that would be weird for a married couple to sleep in.";
            fastMoney5Data.Add("Bunk", new Tuple<int, int>(48, 1));
            fastMoney5Data.Add("Twin", new Tuple<int, int>(40, 2));
            fastMoney5Data.Add("Futon", new Tuple<int, int>(3, 3));
            fastMoney5Data.Add("Air Mattress", new Tuple<int, int>(2, 3));
            fastMoney5Data.Add("Couch", new Tuple<int, int>(2, 3));
            //endfastmoney question 5

            //topAnswers
            topAnswers[0] = "100,000";
            topAnswers[1] = "Chanel";
            topAnswers[2] = "Stoplight";
            topAnswers[3] = "Cut It";
            topAnswers[4] = "Bunk";
            topAnswers[5] = "250,000";
            topAnswers[6] = "Ralph Lauren";
            topAnswers[7] = "Stop Sign";
            topAnswers[8] = "Water It";
            topAnswers[9] = "Twin";
            //end topAnswers
            perfectGame = 324;
        }
        //game 8
        public void generateGame8()
        {
            //question1
            answersLeft1 = 7;
            question1 = "Name a famous golfer.";
            question1Number1 = "Tiger Woods";
            question1Number1Points = 42;
            question1Number2 = "Jack Nicklaus";
            question1Number2Points = 18;
            question1Number3 = "Arnold Palmer";
            question1Number3Points = 15;
            question1Number4 = "Phil Mickelson";
            question1Number4Points = 8;
            question1Number5 = "Rory McIlroy";
            question1Number5Points = 5;
            question1Number6 = "Tom Watson";
            question1Number6Points = 3;
            question1Number7 = "Jordan Spieth";
            question1Number7Points = 2; //TOTAL: 93
            //end question1

            //question2
            answersLeft2 = 8;
            question2 = "Name a common flavor of salad dressing.";
            question2Number1 = "Ranch";
            question2Number1Points = 50;
            question2Number2 = "Italian";
            question2Number2Points = 14;
            question2Number3 = "Caesar";
            question2Number3Points = 10;
            question2Number4 = "Vinaigrette";
            question2Number4Points = 4;
            question2Number5 = "Blue Cheese";
            question2Number5Points = 3;
            question2Number6 = "Honey Mustard";
            question2Number6Points = 3;
            question2Number7 = "Thousand Island";
            question2Number7Points = 3;
            question2Number8 = "French";
            question2Number8Points = 2; //TOTAL: 91
            //end question2

            //question3
            answersLeft3 = 7;
            question3 = "Name a popular R&B singer or group from the 90s.";
            question3Number1 = "Mariah Carey";
            question3Number1Points = 47;
            question3Number2 = "Brandy";
            question3Number2Points = 14;
            question3Number3 = "En Vogue";
            question3Number3Points = 8;
            question3Number4 = "Boyz II Men";
            question3Number4Points = 5;
            question3Number5 = "Janet Jackson";
            question3Number5Points = 5;
            question3Number6 = "R. Kelly";
            question3Number6Points = 5;
            question3Number7 = "TLC";
            question3Number7Points = 5; //TOTAL: 89... Doubled: 178
            //end question3

            //question4
            answersLeft4 = 5;
            question4 = "Name a major city that starts with the letter ''W''.";
            question4Number1 = "Washington, DC";
            question4Number1Points = 36;
            question4Number2 = "Winnipeg";
            question4Number2Points = 19;
            question4Number3 = "Wellington";
            question4Number3Points = 16;
            question4Number4 = "Wichita";
            question4Number4Points = 11;
            question4Number5 = "Warsaw";
            question4Number5Points = 4; //Total: 86... Doubled: 172
            //end question4

            //question5
            answersLeft5 = 4;
            question5 = "Name a good place to showcase music videos.";
            question5Number1 = "YouTube";
            question5Number1Points = 65;
            question5Number2 = "MTV";
            question5Number2Points = 22;
            question5Number3 = "Vevo";
            question5Number3Points = 5;
            question5Number4 = "VH1";
            question5Number4Points = 4; //TOTAL: 96... Tripled: 288
            //end question5
            //fast money question 1
            fastMoneyQuestion1 = "Name a phrase that begins with ''Top''.";
            fastMoney1Data.Add("Top Secret", new Tuple<int, int>(25, 1));
            fastMoney1Data.Add("Top Gun", new Tuple<int, int>(19, 2));
            fastMoney1Data.Add("Top Gear", new Tuple<int, int>(15, 3));
            fastMoney1Data.Add("Top Hat", new Tuple<int, int>(10, 3));
            fastMoney1Data.Add("Top Notch", new Tuple<int, int>(7, 3));
            fastMoney1Data.Add("Top Chef", new Tuple<int, int>(4, 3));
            fastMoney1Data.Add("Top of the Line", new Tuple<int, int>(4, 3));
            fastMoney1Data.Add("Top Dog", new Tuple<int, int>(2, 3));
            fastMoney1Data.Add("Top Heavy", new Tuple<int, int>(2, 3));
            fastMoney1Data.Add("Top Story", new Tuple<int, int>(2, 3));
            //end fastmoney question 1

            //fastmoney question 2
            fastMoneyQuestion2 = "A famous racetrack.";
            fastMoney2Data.Add("Daytona", new Tuple<int, int>(31, 1));
            fastMoney2Data.Add("Indianapolis", new Tuple<int, int>(29, 2));
            fastMoney2Data.Add("Talladega", new Tuple<int, int>(16, 3));
            fastMoney2Data.Add("Le Mans", new Tuple<int, int>(5, 3));
            fastMoney2Data.Add("Monaco", new Tuple<int, int>(5, 3));
            fastMoney2Data.Add("Nurgburgring", new Tuple<int, int>(3, 3));
            fastMoney2Data.Add("Bristol", new Tuple<int, int>(2, 3));
            fastMoney2Data.Add("Las Vegas", new Tuple<int, int>(2, 3));
            //end fastmoney question 2

            //fastmoney question 3
            fastMoneyQuestion3 = "The price of a big-screen TV.";
            fastMoney3Data.Add("$1,000", new Tuple<int, int>(27, 1));
            fastMoney3Data.Add("$1,500", new Tuple<int, int>(20, 2));
            fastMoney3Data.Add("$750", new Tuple<int, int>(14, 3));
            fastMoney3Data.Add("$2,000", new Tuple<int, int>(9, 3));
            fastMoney3Data.Add("$800", new Tuple<int, int>(6, 3));
            fastMoney3Data.Add("$500", new Tuple<int, int>(6, 3));
            fastMoney3Data.Add("$1,200", new Tuple<int, int>(5, 3));
            fastMoney3Data.Add("$900", new Tuple<int, int>(2, 3));
            fastMoney3Data.Add("$700", new Tuple<int, int>(2, 3));
            fastMoney3Data.Add("$1,300", new Tuple<int, int>(2, 3));
            //end fastmoney question 3

            //fastmoney question 4
            fastMoneyQuestion4 = "The longest you've ever gone without sleep.";
            fastMoney4Data.Add("1 Day", new Tuple<int, int>(41, 1));
            fastMoney4Data.Add("2 Days", new Tuple<int, int>(38, 2));
            fastMoney4Data.Add("3 Days", new Tuple<int, int>(10, 3));
            fastMoney4Data.Add("18 Hours", new Tuple<int, int>(3, 3));
            fastMoney4Data.Add("1 Week", new Tuple<int, int>(2, 3));
            fastMoney4Data.Add("4 Days", new Tuple<int, int>(2, 3));
            //end fastmoney question 4

            //fastmoney question 5
            fastMoneyQuestion5 = "An infamous nuclear disaster.";
            fastMoney5Data.Add("Chernobyl", new Tuple<int, int>(50, 1));
            fastMoney5Data.Add("Fukushima", new Tuple<int, int>(32, 2));
            fastMoney5Data.Add("Three Mile Island", new Tuple<int, int>(9, 3));
            fastMoney5Data.Add("Kyshtym", new Tuple<int, int>(2, 3));
            fastMoney5Data.Add("Windscale", new Tuple<int, int>(2, 3));
            //endfastmoney question 5

            //topAnswers
            topAnswers[0] = "Top Secret";
            topAnswers[1] = "Daytona";
            topAnswers[2] = "$1,000";
            topAnswers[3] = "1 day";
            topAnswers[4] = "Chernobyl";
            topAnswers[5] = "Top Gun";
            topAnswers[6] = "Indianapolis";
            topAnswers[7] = "$1,500";
            topAnswers[8] = "2 days";
            topAnswers[9] = "Fukushima";
            //end topAnswers
            perfectGame = 312;
        }
        //game 9
        public void generateGame9()
        {
            //question1
            answersLeft1 = 8;
            question1 = "Name a movie with a day of the week in its title.";
            question1Number1 = "Saturday Night Fever";
            question1Number1Points = 42;
            question1Number2 = "Friday The 13th";
            question1Number2Points = 16;
            question1Number3 = "Any Given Sunday";
            question1Number3Points = 14;
            question1Number4 = "Freaky Friday";
            question1Number4Points = 8;
            question1Number5 = "Friday Night Lights";
            question1Number5Points = 7;
            question1Number6 = "Big Wednesday";
            question1Number6Points = 3;
            question1Number7 = "Friday";
            question1Number7Points = 3;
            question1Number8 = "First Monday in October";
            question1Number8Points = 2; //Total: 91
            //end question1

            //question2
            answersLeft2 = 6;
            question2 = "Name a program in Microsoft Office.";
            question2Number1 = "Word";
            question2Number1Points = 63;
            question2Number2 = "Excel";
            question2Number2Points = 13;
            question2Number3 = "PowerPoint";
            question2Number3Points = 12;
            question2Number4 = "Outlook";
            question2Number4Points = 5;
            question2Number5 = "Access";
            question2Number5Points = 2;
            question2Number6 = "OneNote";
            question2Number6Points = 2; //TOTAL: 97
            //end question2

            //question3
            answersLeft3 = 8;
            question3 = "Name a forgotten president.";
            question3Number1 = "Millard Fillmore";
            question3Number1Points = 16;
            question3Number2 = "Franklin Pierce";
            question3Number2Points = 12;
            question3Number3 = "Warren G. Harding";
            question3Number3Points = 10;
            question3Number4 = "Zachary Taylor";
            question3Number4Points = 8;
            question3Number5 = "Chester Arthur";
            question3Number5Points = 6;
            question3Number6 = "John Tyler";
            question3Number6Points = 6;
            question3Number7 = "Rutherford B. Hayes";
            question3Number7Points = 6;
            question3Number8 = "William Henry Harrison";
            question3Number8Points = 6; //TOTAL: 70 DOUBLED: 140
            //end question3

            //question4
            answersLeft4 = 7;
            question4 = "Name a Will Smith movie.";
            question4Number1 = "Independence Day";
            question4Number1Points = 28;
            question4Number2 = "Men In Black";
            question4Number2Points = 25;
            question4Number3 = "I Am Legend";
            question4Number3Points = 18;
            question4Number4 = "The Pursuit of Happyness";
            question4Number4Points = 11;
            question4Number5 = "Wild Wild West";
            question4Number5Points = 4;
            question4Number6 = "Hancock";
            question4Number6Points = 3;
            question4Number7 = "I, Robot";
            question4Number7Points = 3; //TOTAL: 92 DOUBLED: 184
            //end question4

            //question5
            answersLeft5 = 4;
            question5 = "Name a word that rhymes with ''powder''";
            question5Number1 = "Louder";
            question5Number1Points = 45;
            question5Number2 = "Chowder";
            question5Number2Points = 44;
            question5Number3 = "Prouder";
            question5Number3Points = 4;
            question5Number4 = "Outer";
            question5Number4Points = 2; //TOTAL: 95 TRIPLED: 285
            //end question5

            //fast money question 1
            fastMoneyQuestion1 = "Name a heavy metal band.";
            fastMoney1Data.Add("Metallica", new Tuple<int, int>(22, 1));
            fastMoney1Data.Add("Black Sabbath", new Tuple<int, int>(16, 2));
            fastMoney1Data.Add("AC/DC", new Tuple<int, int>(13, 3));
            fastMoney1Data.Add("Judas Priest", new Tuple<int, int>(6, 3));
            fastMoney1Data.Add("Megadeth", new Tuple<int, int>(6, 3));
            fastMoney1Data.Add("Guns N' Roses", new Tuple<int, int>(5, 3));
            fastMoney1Data.Add("Van Halen", new Tuple<int, int>(5, 3));
            fastMoney1Data.Add("Disturbed", new Tuple<int, int>(4, 3));
            fastMoney1Data.Add("Iron Maiden", new Tuple<int, int>(4, 3));
            fastMoney1Data.Add("Slayer", new Tuple<int, int>(4, 3));
            fastMoney1Data.Add("Motorhead", new Tuple<int, int>(3, 3));
            fastMoney1Data.Add("Anthrax", new Tuple<int, int>(2, 3));
            fastMoney1Data.Add("Korn", new Tuple<int, int>(2, 3));
            fastMoney1Data.Add("Quiet Riot", new Tuple<int, int>(2, 3));
            //end fastMoneyQuestion1

            //fast money question 2
            fastMoneyQuestion2 = "A masculine vehicle.";
            fastMoney2Data.Add("Truck", new Tuple<int, int>(49, 1));
            fastMoney2Data.Add("Motorcycle", new Tuple<int, int>(34, 2));
            fastMoney2Data.Add("Sports Car", new Tuple<int, int>(12, 3));
            fastMoney2Data.Add("ATV", new Tuple<int, int>(3, 3));
            //end FM question 2

            //fast money question 3
            fastMoneyQuestion3 = "A country that begins with the letter ''P''";
            fastMoney3Data.Add("Portugal", new Tuple<int, int>(28, 1));
            fastMoney3Data.Add("Poland", new Tuple<int, int>(23, 2));
            fastMoney3Data.Add("Peru", new Tuple<int, int>(13, 3));
            fastMoney3Data.Add("Pakistan", new Tuple<int, int>(8, 3));
            fastMoney3Data.Add("Panama", new Tuple<int, int>(8, 3));
            fastMoney3Data.Add("Phillipines", new Tuple<int, int>(8, 3));
            fastMoney3Data.Add("Paraguay", new Tuple<int, int>(5, 3));
            fastMoney3Data.Add("Papua New Guinea", new Tuple<int, int>(2, 3));
            //end FM question 3

            //fast money question 4
            fastMoneyQuestion4 = "An actor or actress in The Hunger Games movies.";
            fastMoney4Data.Add("Jennifer Lawrence", new Tuple<int, int>(38, 1));
            fastMoney4Data.Add("Josh Hutcherson", new Tuple<int, int>(31, 2));
            fastMoney4Data.Add("Liam Hemsworth", new Tuple<int, int>(12, 3));
            fastMoney4Data.Add("Elizabeth Banks", new Tuple<int, int>(5, 3));
            fastMoney4Data.Add("Woody Harrelson", new Tuple<int, int>(5, 3));
            fastMoney4Data.Add("Donald Sutherland", new Tuple<int, int>(2, 3));
            fastMoney4Data.Add("Willow Shields", new Tuple<int, int>(2, 3));
            //end FM question 4

            //fast money question 5
            fastMoneyQuestion5 = "The month of pregnancy where a woman first feels her baby kick.";
            fastMoney5Data.Add("5th Month", new Tuple<int, int>(55, 1));
            fastMoney5Data.Add("4th Month", new Tuple<int, int>(26, 2));
            fastMoney5Data.Add("6th Month", new Tuple<int, int>(12, 3));
            fastMoney5Data.Add("7th Month", new Tuple<int, int>(3, 3));
            fastMoney5Data.Add("3rd Month", new Tuple<int, int>(2, 3));
            //end FM question 5

            //topAnswers
            topAnswers[0] = "Metallica";
            topAnswers[1] = "Truck";
            topAnswers[2] = "Portugal";
            topAnswers[3] = "Jennifer Lawrence";
            topAnswers[4] = "5th Month";
            topAnswers[5] = "Black Sabbath";
            topAnswers[6] = "Motorcycle";
            topAnswers[7] = "Poland";
            topAnswers[8] = "Josh Hutcherson";
            topAnswers[9] = "4th Month";
            //end topAnswers
            perfectGame = 322;
        }
        //game 10
        public void generateGame10()
        {
            //question 1
            answersLeft1 = 7;
            question1 = "Name a common decoration seen outside houses on Halloween.";
            question1Number1 = "Pumpkin";
            question1Number1Points = 47;
            question1Number2 = "Scarecrow";
            question1Number2Points = 26;
            question1Number3 = "Ghost";
            question1Number3Points = 5;
            question1Number4 = "Witch";
            question1Number4Points = 5;
            question1Number5 = "Black Cat";
            question1Number5Points = 4;
            question1Number6 = "Skeleton";
            question1Number6Points = 3;
            question1Number7 = "Spiderweb";
            question1Number7Points = 3; //TOTAL: 93
            //end question 1

            //question 2
            answersLeft2 = 8;
            question2 = "Name a famous person with a color for a last name.";
            question2Number1 = "James Brown";
            question2Number1Points = 17;
            question2Number2 = "Betty White";
            question2Number2Points = 16;
            question2Number3 = "Chris Brown";
            question2Number3Points = 11;
            question2Number4 = "Barry White";
            question2Number4Points = 10;
            question2Number5 = "Jack Black";
            question2Number5Points = 10;
            question2Number6 = "Bobby Brown";
            question2Number6Points = 6;
            question2Number7 = "Vanna White";
            question2Number7Points = 6;
            question2Number8 = "Seth Green";
            question2Number8Points = 5; //TOTAL: 81
            //end question 2

            //question 3
            answersLeft3 = 7;
            question3 = "Name a holiday you'd be surprised to receive presents for.";
            question3Number1 = "Memorial Day";
            question3Number1Points = 27;
            question3Number2 = "Labor Day";
            question3Number2Points = 25;
            question3Number3 = "Veteran's Day";
            question3Number3Points = 12;
            question3Number4 = "Thanksgiving";
            question3Number4Points = 11;
            question3Number5 = "Columbus Day";
            question3Number5Points = 7;
            question3Number6 = "Flag Day";
            question3Number6Points = 4;
            question3Number7 = "President's Day";
            question3Number7Points = 4; //TOTAL: 90 Doubled 180
            //end question 3

            //question 4
            answersLeft4 = 5;
            question4 = "Tell me what would you like to pay for a gallon of gas.";
            question4Number1 = "1 Dollar";
            question4Number1Points = 48;
            question4Number2 = "Nothing";
            question4Number2Points = 39;
            question4Number3 = "10 Cents";
            question4Number3Points = 3;
            question4Number4 = "50 Cents";
            question4Number4Points = 3;
            question4Number5 = "25 Cents";
            question4Number5Points = 2; //TOTAL: 95 Doubled 190
            //end question 4

            //question 5
            answersLeft5 = 4;
            question5 = "Give me a name used for the championship round in a professional sport.";
            question5Number1 = "Super Bowl";
            question5Number1Points = 66;
            question5Number2 = "World Series";
            question5Number2Points = 14;
            question5Number3 = "Stanley Cup";
            question5Number3Points = 11;
            question5Number4 = "The Finals";
            question5Number4Points = 8; //TOTAL: 99... Tripled 297
            //end question 5

            //Fast Money Question 1
            fastMoneyQuestion1 = "Name a liquid you use every day but do not drink.";
            fastMoney1Data.Add("Gasoline", new Tuple<int, int>(41, 1));
            fastMoney1Data.Add("Oil", new Tuple<int, int>(26, 2));
            fastMoney1Data.Add("Soap", new Tuple<int, int>(15, 3));
            fastMoney1Data.Add("Cleaner", new Tuple<int, int>(7, 3));
            fastMoney1Data.Add("Vegetable Oil", new Tuple<int, int>(3, 3));
            fastMoney1Data.Add("Antifreeze", new Tuple<int, int>(2, 3));
            fastMoney1Data.Add("Laundry Detergent", new Tuple<int, int>(2, 3));
            //end fast money question 1

            //Fast Money Question 2
            fastMoneyQuestion2 = "A noisy machine in your home.";
            fastMoney2Data.Add("Washing Machine", new Tuple<int, int>(28, 1));
            fastMoney2Data.Add("Air Conditioner", new Tuple<int, int>(22, 2));
            fastMoney2Data.Add("Dishwasher", new Tuple<int, int>(17, 3));
            fastMoney2Data.Add("Dryer", new Tuple<int, int>(8, 3));
            fastMoney2Data.Add("Vacuum Cleaner", new Tuple<int, int>(6, 3));
            fastMoney2Data.Add("Furnace", new Tuple<int, int>(3, 3));
            fastMoney2Data.Add("Garbage Disposal", new Tuple<int, int>(3, 3));
            fastMoney2Data.Add("Microwave", new Tuple<int, int>(3, 3));
            fastMoney2Data.Add("Lawnmower", new Tuple<int, int>(2, 3));
            fastMoney2Data.Add("Television", new Tuple<int, int>(2, 3));
            //end fast money question 2

            //Fast Money Question 3
            fastMoneyQuestion3 = "A murdered president.";
            fastMoney3Data.Add("Abraham Lincoln", new Tuple<int, int>(49, 1));
            fastMoney3Data.Add("John F. Kennedy", new Tuple<int, int>(40, 2));
            fastMoney3Data.Add("William McKinley", new Tuple<int, int>(7, 3));
            fastMoney3Data.Add("James Garfield", new Tuple<int, int>(5, 3));
            //end fast money question 3

            //Fast Money Question 4
            fastMoneyQuestion4 = "Other than milk, name a dairy product.";
            fastMoney4Data.Add("Yogurt", new Tuple<int, int>(41, 1));
            fastMoney4Data.Add("Cheese", new Tuple<int, int>(38, 2));
            fastMoney4Data.Add("Ice Cream", new Tuple<int, int>(10, 3));
            fastMoney4Data.Add("Sour Cream", new Tuple<int, int>(3, 3));
            fastMoney4Data.Add("Buttermilk", new Tuple<int, int>(2, 3));
            fastMoney4Data.Add("Custard", new Tuple<int, int>(2, 3));
            //end fast money question 4

            //Fast Money Question5
            fastMoneyQuestion5 = "Any holiday in spring.";
            fastMoney5Data.Add("Easter", new Tuple<int, int>(39, 1));
            fastMoney5Data.Add("Memorial Day", new Tuple<int, int>(35, 2));
            fastMoney5Data.Add("Passover", new Tuple<int, int>(9, 3));
            fastMoney5Data.Add("Cinco De Mayo", new Tuple<int, int>(8, 3));
            fastMoney5Data.Add("Arbor Day", new Tuple<int, int>(2, 3));
            fastMoney5Data.Add("Flag Day", new Tuple<int, int>(2, 3));
            fastMoney5Data.Add("May Day", new Tuple<int, int>(2, 3));
            //end Fast Money Question 5

            //topAnswers
            topAnswers[0] = "Gasoline";
            topAnswers[1] = "Washing Machine";
            topAnswers[2] = "Abraham Lincoln";
            topAnswers[3] = "Yogurt";
            topAnswers[4] = "Easter";
            topAnswers[5] = "Oil";
            topAnswers[6] = "Furnace/Air Conditioner";
            topAnswers[7] = "John F. Kennedy";
            topAnswers[8] = "Cheese";
            topAnswers[9] = "Memorial Day";
            //end topAnswers
            perfectGame = 359;
        }
        //game 11
        public void generateGame11()
        {
            //question 1
            answersLeft1 = 8;
            question1 = "Name a rock band that's been performing longer than you've been alive.";
            question1Number1 = "The Rolling Stones";
            question1Number1Points = 41;
            question1Number2 = "The Who";
            question1Number2Points = 13;
            question1Number3 = "Kiss";
            question1Number3Points = 9;
            question1Number4 = "The Eagles";
            question1Number4Points = 8;
            question1Number5 = "Aerosmith";
            question1Number5Points = 5;
            question1Number6 = "ZZ Top";
            question1Number6Points = 5;
            question1Number7 = "AC/DC";
            question1Number7Points = 4;
            question1Number8 = "Rush";
            question1Number8Points = 3; //TOTAL: 88
            //end question 1

            //question 2
            answersLeft2 = 7;
            question2 = "Name a US city notorious for having a high murder rate.";
            question2Number1 = "Chicago";
            question2Number1Points = 39;
            question2Number2 = "Detroit";
            question2Number2Points = 31;
            question2Number3 = "New York";
            question2Number3Points = 7;
            question2Number4 = "New Orleans";
            question2Number4Points = 4;
            question2Number5 = "St. Louis";
            question2Number5Points = 4;
            question2Number6 = "Cleveland";
            question2Number6Points = 3;
            question2Number7 = "Los Angeles";
            question2Number7Points = 3;
            question2Number8 = "Baltimore";
            question2Number8Points = 2; //TOTAL: 93
            //end question 2

            //question 3
            answersLeft3 = 7;
            question3 = "Name an Apple product whose name starts with their trademark ''i''.";
            question3Number1 = "iPod";
            question3Number1Points = 29;
            question3Number2 = "iPhone";
            question3Number2Points = 28;
            question3Number3 = "iMac";
            question3Number3Points = 13;
            question3Number4 = "iPad";
            question3Number4Points = 7;
            question3Number5 = "iTunes";
            question3Number5Points = 6;
            question3Number6 = "iWatch";
            question3Number6Points = 4;
            question3Number7 = "iOS";
            question3Number7Points = 4; //TOTAL: 91... Doubled: 182
            //end question 3

            //question 4
            answersLeft4 = 5;
            question4 = "Name a word that follows ''On Your''.";
            question4Number1 = "Mark";
            question4Number1Points = 52;
            question4Number2 = "Own";
            question4Number2Points = 17;
            question4Number3 = "Toes";
            question4Number3Points = 13;
            question4Number4 = "Way";
            question4Number4Points = 4;
            question4Number5 = "Behalf";
            question4Number5Points = 3; //TOTAL: 89... Doubled: 178
            //end question 4

            //question 5
            answersLeft5 = 4;
            question5 = "Other than Michael, name a famous member of the Jackson family.";
            question5Number1 = "Janet";
            question5Number1Points = 62;
            question5Number2 = "LaToya";
            question5Number2Points = 15;
            question5Number3 = "Tito";
            question5Number3Points = 11;
            question5Number4 = "Jermaine";
            question5Number4Points = 3;
            //end question 5


            //Fast Money Question 1
            fastMoneyQuestion1 = "How many years does a car last?";
            fastMoney1Data.Add("20", new Tuple<int, int>(32, 1));
            fastMoney1Data.Add("15", new Tuple<int, int>(19, 2));
            fastMoney1Data.Add("10", new Tuple<int, int>(12, 3));
            fastMoney1Data.Add("25", new Tuple<int, int>(9, 3));
            fastMoney1Data.Add("12", new Tuple<int, int>(4, 3));
            fastMoney1Data.Add("13", new Tuple<int, int>(4, 3));
            fastMoney1Data.Add("5", new Tuple<int, int>(3, 3));
            fastMoney1Data.Add("30", new Tuple<int, int>(3, 3));
            fastMoney1Data.Add("18", new Tuple<int, int>(2, 3));
            fastMoney1Data.Add("17", new Tuple<int, int>(2, 3));
            fastMoney1Data.Add("50", new Tuple<int, int>(2, 3));
            //end FM question 1

            //Fast Money question 2
            fastMoneyQuestion2 = "Name a Shakespeare comedy.";
            fastMoney2Data.Add("A Midsummer Night's Dream", new Tuple<int, int>(27, 1));
            fastMoney2Data.Add("Much Ado About Nothing", new Tuple<int, int>(24, 2));
            fastMoney2Data.Add("As You Like It", new Tuple<int, int>(13, 3));
            fastMoney2Data.Add("The Merchant Of Venice", new Tuple<int, int>(9, 3));
            fastMoney2Data.Add("The Tempest", new Tuple<int, int>(9, 3));
            fastMoney2Data.Add("Two Gentlemen Of Verona", new Tuple<int, int>(4, 3));
            fastMoney2Data.Add("Measure For Measure", new Tuple<int, int>(3, 3));
            fastMoney2Data.Add("The Taming Of The Shrew", new Tuple<int, int>(3, 3));
            fastMoney2Data.Add("Comedy Of Errors", new Tuple<int, int>(2, 3));
            fastMoney2Data.Add("The Winter's Tale", new Tuple<int, int>(2, 3));
            //end FM question 2

            //Fast Money question 3
            fastMoneyQuestion3 = "Name an animal that weighs about the same as a human.";
            fastMoney3Data.Add("Chimpanzee", new Tuple<int, int>(18, 1));
            fastMoney3Data.Add("Kangaroo", new Tuple<int, int>(15, 2));
            fastMoney3Data.Add("Leopard", new Tuple<int, int>(9, 3));
            fastMoney3Data.Add("Deer", new Tuple<int, int>(7, 3));
            fastMoney3Data.Add("Sheep", new Tuple<int, int>(7, 3));
            fastMoney3Data.Add("Orangutan", new Tuple<int, int>(6, 3));
            fastMoney3Data.Add("Cougar", new Tuple<int, int>(5, 3));
            fastMoney3Data.Add("Ostrich", new Tuple<int, int>(5, 3));
            fastMoney3Data.Add("Tortoise", new Tuple<int, int>(5, 3));
            fastMoney3Data.Add("Gazelle", new Tuple<int, int>(4, 3));
            fastMoney3Data.Add("Goat", new Tuple<int, int>(4, 3));
            fastMoney3Data.Add("Ape", new Tuple<int,int>(3, 3));
            fastMoney3Data.Add("Warthog", new Tuple<int, int>(3, 3));
            fastMoney3Data.Add("Dog", new Tuple<int, int>(2, 3));
            fastMoney3Data.Add("Seal", new Tuple<int, int>(2, 3));
            //end FM question 2

            //Fast Money question 4
            fastMoneyQuestion4 = "Name a word that starts with ''SQU''";
            fastMoney4Data.Add("Square", new Tuple<int, int>(21, 1));
            fastMoney4Data.Add("Squid", new Tuple<int, int>(14, 2));
            fastMoney4Data.Add("Squirrel", new Tuple<int, int>(13, 3));
            fastMoney4Data.Add("Squat", new Tuple<int, int>(11, 3));
            fastMoney4Data.Add("Squeeze", new Tuple<int, int>(10, 3));
            fastMoney4Data.Add("Squish", new Tuple<int, int>(6, 3));
            fastMoney4Data.Add("Squad", new Tuple<int, int>(3, 3));
            fastMoney4Data.Add("Squeal", new Tuple<int, int>(3, 3));
            fastMoney4Data.Add("Squirt", new Tuple<int, int>(3, 3));
            fastMoney4Data.Add("Squirm", new Tuple<int, int>(3, 3));
            fastMoney4Data.Add("Squint", new Tuple<int, int>(2, 3));
            fastMoney4Data.Add("Squib", new Tuple<int, int>(2, 3));
            //end FM question 4

            //Fast Money question 5
            fastMoneyQuestion5 = "Name the hottest temperature you feel comfortable in.";
            fastMoney5Data.Add("80", new Tuple<int, int>(43, 1));
            fastMoney5Data.Add("90", new Tuple<int, int>(28, 2));
            fastMoney5Data.Add("85", new Tuple<int, int>(10, 3));
            fastMoney5Data.Add("100", new Tuple<int, int>(6, 3));
            fastMoney5Data.Add("75", new Tuple<int, int>(5, 3));
            fastMoney5Data.Add("95", new Tuple<int, int>(2, 3));
            fastMoney5Data.Add("82", new Tuple<int, int>(2, 3));
            //end FM question 5

            //Top answers
            topAnswers[0] = "20";
            topAnswers[1] = "A Midsummer Night's Dream";
            topAnswers[2] = "Chimpanzee";
            topAnswers[3] = "Square";
            topAnswers[4] = "80";
            topAnswers[5] = "15";
            topAnswers[6] = "Much Ado About Nothing";
            topAnswers[7] = "Kangaroo";
            topAnswers[8] = "Squid";
            topAnswers[9] = "90";
            //end top answers
            perfectGame = 241;


        }
        //game 12
        public void generateGame12()
        {
            //question 1
            answersLeft1 = 7;
            question1 = "Name something usually worn only by women.";
            question1Number1 = "Makeup";
            question1Number1Points = 35;
            question1Number2 = "Lipstick";
            question1Number2Points = 21;
            question1Number3 = "Dress";
            question1Number3Points = 13;
            question1Number4 = "Lingerie";
            question1Number4Points = 9;
            question1Number5 = "Pantyhose";
            question1Number5Points = 4;
            question1Number6 = "Girdle";
            question1Number6Points = 3;
            question1Number7 = "High Heels";
            question1Number7Points = 3; //TOTAL: 90
            //end question 1

            //question 2
            answersLeft2 = 5;
            question2 = "Name a sport people watch quietly.";
            question2Number1 = "Golf";
            question2Number1Points = 41;
            question2Number2 = "Tennis";
            question2Number2Points = 39;
            question2Number3 = "Pool";
            question2Number3Points = 5;
            question2Number4 = "Chess";
            question2Number4Points = 4;
            question2Number5 = "Baseball";
            question2Number5Points = 2; //TOTAL: 91
            //end question 2

            //question 3 (Double)
            answersLeft3 = 5;
            question3 = "Name something that comes in bunches.";
            question3Number1 = "Bananas";
            question3Number1Points = 50;
            question3Number2 = "Grapes";
            question3Number2Points = 40;
            question3Number3 = "Eggs";
            question3Number3Points = 2;
            question3Number4 = "Flowers";
            question3Number4Points = 2;
            question3Number5 = "Malarkey";
            question3Number5Points = 2; //TOTAL: 96... Doubled: 192
            //end question 3

            //question 4 (Double)
            answersLeft4 = 7;
            question4 = "Name someone who might be up on your roof.";
            question4Number1 = "Santa Claus";
            question4Number1Points = 36;
            question4Number2 = "Roofer";
            question4Number2Points = 27;
            question4Number3 = "Burglar";
            question4Number3Points = 14;
            question4Number4 = "Me";
            question4Number4Points = 10;
            question4Number5 = "Gutter Cleaner";
            question4Number5Points = 4;
            question4Number6 = "Chimney Sweep";
            question4Number6Points = 2;
            question4Number7 = "Fiddler";
            question4Number7Points = 2; //TOTAL: 95... Doubled: 190
            //end question 4

            //question 5 (Triple)
            answersLeft5 = 5;
            question5 = "Name an actor who has played James Bond.";
            question5Number1 = "Sean Connery";
            question5Number1Points = 37;
            question5Number2 = "Daniel Craig";
            question5Number2Points = 29;
            question5Number3 = "Roger Moore";
            question5Number3Points = 19;
            question5Number4 = "Pierce Brosnan";
            question5Number4Points = 8;
            question5Number5 = "Timothy Dalton";
            question5Number5Points = 4; //TOTAL: 97... Tripled: 291
            //end question 5

            //fast money question 1
            fastMoneyQuestion1 = "How old is too old for a professional football player?";
            fastMoney1Data.Add("40", new Tuple<int, int>(42, 1));
            fastMoney1Data.Add("45", new Tuple<int, int>(23, 2));
            fastMoney1Data.Add("35", new Tuple<int, int>(8, 3));
            fastMoney1Data.Add("50", new Tuple<int, int>(8, 3));
            fastMoney1Data.Add("42", new Tuple<int, int>(3, 3));
            fastMoney1Data.Add("38", new Tuple<int, int>(2, 3));
            fastMoney1Data.Add("43", new Tuple<int, int>(2, 3));
            fastMoney1Data.Add("44", new Tuple<int, int>(2, 3));
            fastMoney1Data.Add("47", new Tuple<int, int>(2, 3));
            //end question 1

            //fast money question 2
            fastMoneyQuestion2 = "Name any Catholic holiday.";
            fastMoney2Data.Add("Mardi Gras", new Tuple<int, int>(35, 1));
            fastMoney2Data.Add("Palm Sunday", new Tuple<int, int>(18, 2));
            fastMoney2Data.Add("Ash Wednesday", new Tuple<int, int>(17, 3));
            fastMoney2Data.Add("Good Friday", new Tuple<int, int>(11, 3));
            fastMoney2Data.Add("Pentecost", new Tuple<int, int>(5, 3));
            fastMoney2Data.Add("Epiphany", new Tuple<int, int>(4, 3));
            fastMoney2Data.Add("Christmas", new Tuple<int, int>(2, 3));
            fastMoney2Data.Add("Easter", new Tuple<int, int>(2, 3));
            //end fast money question 2

            //fast money question 3
            fastMoneyQuestion3 = "Name a famous supervillain.";
            fastMoney3Data.Add("The Joker", new Tuple<int, int>(22, 1));
            fastMoney3Data.Add("Lex Luthor", new Tuple<int, int>(20, 2));
            fastMoney3Data.Add("Dr. Doom", new Tuple<int, int>(14, 3));
            fastMoney3Data.Add("Penguin", new Tuple<int, int>(8, 3));
            fastMoney3Data.Add("Loki", new Tuple<int, int>(5, 3));
            fastMoney3Data.Add("Ultron", new Tuple<int, int>(5, 3));
            fastMoney3Data.Add("Dr. Octopus", new Tuple<int, int>(4, 3));
            fastMoney3Data.Add("Riddler", new Tuple<int, int>(4, 3));
            fastMoney3Data.Add("Green Goblin", new Tuple<int, int>(3, 3));
            fastMoney3Data.Add("Catwoman", new Tuple<int, int>(2, 3));
            fastMoney3Data.Add("Harley Quinn", new Tuple<int, int>(2, 3));
            fastMoney3Data.Add("Magneto", new Tuple<int, int>(2, 3));
            //end fm question 3

            //fast money question 4
            fastMoneyQuestion4 = "Generation X is one type of recent generation of people. Name another.";
            fastMoney4Data.Add("Baby Boomers", new Tuple<int, int>(37, 1));
            fastMoney4Data.Add("Generation Y", new Tuple<int, int>(22, 2));
            fastMoney4Data.Add("Greatest Generation", new Tuple<int, int>(14, 3));
            fastMoney4Data.Add("Millennials", new Tuple<int, int>(6, 3));
            fastMoney4Data.Add("Silent Generation", new Tuple<int, int>(6, 3));
            fastMoney4Data.Add("Beat Generation", new Tuple<int, int>(2, 3));
            fastMoney4Data.Add("Generation Z", new Tuple<int, int>(2, 3));
            fastMoney4Data.Add("MTV Generation", new Tuple<int, int>(2, 3));
            //end FM question 4

            //fast money question 5
            fastMoneyQuestion5 = "Name a vehicle you do not need a license to operate.";
            fastMoney5Data.Add("Bicycle", new Tuple<int, int>(54, 1));
            fastMoney5Data.Add("Go-Kart", new Tuple<int, int>(15, 2));
            fastMoney5Data.Add("Scooter", new Tuple<int, int>(10, 3));
            fastMoney5Data.Add("Horse", new Tuple<int, int>(4, 3));
            fastMoney5Data.Add("Canoe", new Tuple<int, int>(2, 3));
            fastMoney5Data.Add("Tricycle", new Tuple<int, int>(2, 3));
            fastMoney5Data.Add("Wheelchair", new Tuple<int, int>(2, 3));
            //end FM question 5

            //top answers
            topAnswers[0] = "40";
            topAnswers[1] = "Mardi Gras";
            topAnswers[2] = "The Joker";
            topAnswers[3] = "Baby Boomers";
            topAnswers[4] = "Bicycle";
            topAnswers[5] = "45";
            topAnswers[6] = "Palm Sunday";
            topAnswers[7] = "Lex Luthor";
            topAnswers[8] = "Generation Y";
            topAnswers[9] = "Go-Kart";
            //end topAnswers
            perfectGame = 288;
        }
        //game 13
        public void generateGame13()
        {
            //question 1
            answersLeft1 = 8;
            question1 = "Name a Led Zeppelin song.";
            question1Number1 = "Stairway To Heaven";
            question1Number1Points = 48;
            question1Number2 = "Whole Lotta Love";
            question1Number2Points = 13;
            question1Number3 = "Black Dog";
            question1Number3Points = 11;
            question1Number4 = "Good Times Bad Times";
            question1Number4Points = 6;
            question1Number5 = "Rock And Roll";
            question1Number5Points = 6;
            question1Number6 = "Kashmir";
            question1Number6Points = 3;
            question1Number7 = "Dazed And Confused";
            question1Number7Points = 2;
            question1Number8 = "Immigrant Song";
            question1Number8Points = 2; //TOTAL: 91
            //end question 1

            //question 2
            answersLeft2 = 6;
            question2 = "Besides driving, name a way people get to work.";
            question2Number1 = "Bus";
            question2Number1Points = 39;
            question2Number2 = "Subway";
            question2Number2Points = 31;
            question2Number3 = "Biking";
            question2Number3Points = 10;
            question2Number4 = "Walking";
            question2Number4Points = 10;
            question2Number5 = "Segway";
            question2Number5Points = 3;
            question2Number6 = "Carpooling";
            question2Number6Points = 2; //TOTAL: 95
            //end question 2

            //question 3 (DOUBLE)
            answersLeft3 = 6;
            question3 = "Name a word that starts with ''appa''.";
            question3Number1 = "Appalachian";
            question3Number1Points = 29;
            question3Number2 = "Apparatus";
            question3Number2Points = 21;
            question3Number3 = "Appanoose";
            question3Number3Points = 20;
            question3Number4 = "Apparent";
            question3Number4Points = 12;
            question3Number5 = "Apparel";
            question3Number5Points = 5;
            question3Number6 = "Apparition";
            question3Number6Points = 2; //TOTAL: 89... Doubled: 178
            //end question 3

            //question 4 (DOUBLE)
            answersLeft4 = 8;
            question4 = "Name any American celebrity family.";
            question4Number1 = "Kardashians";
            question4Number1Points = 30;
            question4Number2 = "Jacksons";
            question4Number2Points = 16;
            question4Number3 = "Smiths";
            question4Number3Points = 12;
            question4Number4 = "Osmonds";
            question4Number4Points = 8;
            question4Number5 = "Baldwins";
            question4Number5Points = 6;
            question4Number6 = "Sheens";
            question4Number6Points = 6;
            question4Number7 = "Simpsons";
            question4Number7Points = 5;
            question4Number8 = "Braxtons";
            question4Number8Points = 3; //TOTAL: 86... Doubled: 172
            //end question 4

            //question 5 (TRIPLE)
            answersLeft5 = 4;
            question5 = "Give me a common name for a British king.";
            question5Number1 = "George";
            question5Number1Points = 41;
            question5Number2 = "Edward";
            question5Number2Points = 33;
            question5Number3 = "James";
            question5Number3Points = 14;
            question5Number4 = "Henry";
            question5Number4Points = 5; //TOTAL: 93... Tripled... 279
            //end question 5

            //fast money question 1
            fastMoneyQuestion1 = "At what age do men start getting gray hair?";
            fastMoney1Data.Add("35", new Tuple<int, int>(32, 1));
            fastMoney1Data.Add("40", new Tuple<int, int>(24, 2));
            fastMoney1Data.Add("30", new Tuple<int, int>(17, 3));
            fastMoney1Data.Add("25", new Tuple<int, int>(8, 3));
            fastMoney1Data.Add("45", new Tuple<int, int>(4, 3));
            fastMoney1Data.Add("32", new Tuple<int, int>(3, 3));
            fastMoney1Data.Add("33", new Tuple<int, int>(3, 3));
            fastMoney1Data.Add("28", new Tuple<int, int>(2, 3));
            fastMoney1Data.Add("36", new Tuple<int, int>(2, 3));
            fastMoney1Data.Add("38", new Tuple<int, int>(2, 3));
            //end fast money question 1

            //fast money question 2
            fastMoneyQuestion2 = "Name a famous horse.";
            fastMoney2Data.Add("Secretariat", new Tuple<int, int>(28, 1));
            fastMoney2Data.Add("Trigger", new Tuple<int, int>(19, 2));
            fastMoney2Data.Add("Silver", new Tuple<int, int>(16, 3));
            fastMoney2Data.Add("Mr. Ed", new Tuple<int, int>(10, 3));
            fastMoney2Data.Add("American Pharoah", new Tuple<int, int>(7, 3));
            fastMoney2Data.Add("Champion", new Tuple<int, int>(4, 3));
            fastMoney2Data.Add("Burmese", new Tuple<int, int>(2, 3));
            fastMoney2Data.Add("California Chrome", new Tuple<int, int>(2, 3));
            fastMoney2Data.Add("Man O' War", new Tuple<int, int>(2, 3));
            fastMoney2Data.Add("Thunder", new Tuple<int, int>(2, 3));
            //end fast money question 2

            //fast money question 3
            fastMoneyQuestion3 = "A food or drink whose name starts with ''Orange''.";
            fastMoney3Data.Add("Orange Juice", new Tuple<int, int>(40, 1));
            fastMoney3Data.Add("Orange Chicken", new Tuple<int, int>(23, 2));
            fastMoney3Data.Add("Orange Soda", new Tuple<int, int>(15, 3));
            fastMoney3Data.Add("Orange Sherbet", new Tuple<int, int>(8, 3));
            fastMoney3Data.Add("Orange Pepper", new Tuple<int, int>(2, 3));
            fastMoney3Data.Add("Orange Smoothie", new Tuple<int, int>(2, 3));
            //end fast money question 3

            //fast money question 4
            fastMoneyQuestion4 = "A country known for its mountains.";
            fastMoney4Data.Add("Switzerland", new Tuple<int, int>(30, 1));
            fastMoney4Data.Add("Nepal", new Tuple<int, int>(25, 2));
            fastMoney4Data.Add("United States", new Tuple<int, int>(14, 3));
            fastMoney4Data.Add("China", new Tuple<int, int>(10, 3));
            fastMoney4Data.Add("Chile", new Tuple<int, int>(4, 3));
            fastMoney4Data.Add("Peru", new Tuple<int, int>(4, 3));
            fastMoney4Data.Add("France", new Tuple<int, int>(3, 3));
            fastMoney4Data.Add("Canada", new Tuple<int, int>(2, 3));
            fastMoney4Data.Add("Japan", new Tuple<int, int>(2, 3));
            //end fast money question 4

            //fast money question 5
            fastMoneyQuestion5 = "Something undesirable you may find on your face.";
            fastMoney5Data.Add("Pimples", new Tuple<int, int>(39, 1));
            fastMoney5Data.Add("Wrinkles", new Tuple<int, int>(36, 2));
            fastMoney5Data.Add("Food", new Tuple<int, int>(10, 3));
            fastMoney5Data.Add("Gray Hair", new Tuple<int, int>(6, 3));
            fastMoney5Data.Add("Boogers", new Tuple<int, int>(2, 3));
            fastMoney5Data.Add("Dirt", new Tuple<int, int>(2, 3));
            //end fm question 5

            //top answers
            topAnswers[0] = "35";
            topAnswers[1] = "Secretariat";
            topAnswers[2] = "Orange Juice";
            topAnswers[3] = "Switzerland";
            topAnswers[4] = "Pimples";
            topAnswers[5] = "40";
            topAnswers[6] = "Trigger";
            topAnswers[7] = "Orange Chicken";
            topAnswers[8] = "Nepal";
            topAnswers[9] = "Wrinkles";
            perfectGame = 296;
            //end top answers
        }
        //game 14
        public void generateGame14()
        {
            //question 1
            answersLeft1 = 7;
            question1 = "Name a television network that shows sports.";
            question1Number1 = "ESPN";
            question1Number1Points = 71;
            question1Number2 = "CBS";
            question1Number2Points = 7;
            question1Number3 = "FOX";
            question1Number3Points = 6;
            question1Number4 = "ABC";
            question1Number4Points = 4;
            question1Number5 = "NBC";
            question1Number5Points = 4;
            question1Number6 = "ESPN2";
            question1Number6Points = 2;
            question1Number7 = "Fox Sports 1";
            question1Number7Points = 2;  //TOTAL: 96
            //end question 1

            //question 2
            answersLeft2 = 8;
            question2 = "Where are you at 10 AM on a Sunday?";
            question2Number1 = "Church";
            question2Number1Points = 59;
            question2Number2 = "Restaurant";
            question2Number2Points = 11;
            question2Number3 = "Bed";
            question2Number3Points = 9;
            question2Number4 = "Gym";
            question2Number4Points = 4;
            question2Number5 = "Work";
            question2Number5Points = 4;
            question2Number6 = "Home";
            question2Number6Points = 3;
            question2Number7 = "Fishing";
            question2Number7Points = 2;
            question2Number8 = "Golf Course";
            question2Number8Points = 2; //TOTAL: 94
            //end question 2

            //question 3 (Double)
            answersLeft3 = 6;
            question3 = "Name a movie with a year in its title.";
            question3Number1 = "2001: A Space Odyssey";
            question3Number1Points = 47;
            question3Number2 = "2012";
            question3Number2Points = 22;
            question3Number3 = "10,000 BC";
            question3Number3Points = 12;
            question3Number4 = "Fantasia 2000";
            question3Number4Points = 5;
            question3Number5 = "1941";
            question3Number5Points = 3;
            question3Number6 = "Dracula 2000";
            question3Number6Points = 2; //TOTAL: 91... Doubled: 182
            //end question 3

            //question 4 (Double)
            answersLeft4 = 7;
            question4 = "Name something illegal many people think should be legal.";
            question4Number1 = "Marijuana";
            question4Number1Points = 47;
            question4Number2 = "Switchblades";
            question4Number2Points = 9;
            question4Number3 = "Underage Drinking";
            question4Number3Points = 9;
            question4Number4 = "Gambling";
            question4Number4Points = 8;
            question4Number5 = "Automatic Rifles";
            question4Number5Points = 4;
            question4Number6 = "Prostitution";
            question4Number6Points = 4;
            question4Number7 = "Open Containers";
            question4Number7Points = 3; //TOTAL: 84... Doubled: 168
            //end question 4

            //question 5 (Triple)
            answersLeft5 = 4;
            question5 = "Besides Spanish, name an easy foreign language to learn for Americans.";
            question5Number1 = "French";
            question5Number1Points = 58;
            question5Number2 = "German";
            question5Number2Points = 20;
            question5Number3 = "Portuguese";
            question5Number3Points = 11;
            question5Number4 = "Italian";
            question5Number4Points = 4; //TOTAL: 93... Tripled: 279
            //end question 5

            //Fast money question 1
            fastMoneyQuestion1 = "Besides United States, name a country that starts with the letter ''U''";
            fastMoney1Data.Add("United Kingdom", new Tuple<int, int>(42, 1));
            fastMoney1Data.Add("Ukraine", new Tuple<int, int>(20, 2));
            fastMoney1Data.Add("United Arab Emirates", new Tuple<int, int>(16, 3));
            fastMoney1Data.Add("Uzbekistan", new Tuple<int, int>(11, 3));
            fastMoney1Data.Add("Uganda", new Tuple<int, int>(5, 3));
            fastMoney1Data.Add("Uruguay", new Tuple<int, int>(5, 3));
            //end FM question 1

            //Fast money question 2
            fastMoneyQuestion2 = "How long before his/her birthday do you buy your spouse a present?";
            fastMoney2Data.Add("1 Day", new Tuple<int, int>(32, 1));
            fastMoney2Data.Add("2 Days", new Tuple<int, int>(24, 2));
            fastMoney2Data.Add("The Day Of", new Tuple<int, int>(14, 3));
            fastMoney2Data.Add("1 Week", new Tuple<int, int>(9, 3));
            fastMoney2Data.Add("3 Days", new Tuple<int, int>(7, 3));
            fastMoney2Data.Add("4 Days", new Tuple<int, int>(4, 3));
            fastMoney2Data.Add("2 Weeks", new Tuple<int, int>(2, 3));
            fastMoney2Data.Add("5 Days", new Tuple<int, int>(2, 3));
            //end FM question 2

            //Fast money question 3
            fastMoneyQuestion3 = "A color of soda pop.";
            fastMoney3Data.Add("Brown", new Tuple<int, int>(36, 1));
            fastMoney3Data.Add("Clear", new Tuple<int, int>(29, 2));
            fastMoney3Data.Add("Black", new Tuple<int, int>(12, 3));
            fastMoney3Data.Add("Green", new Tuple<int, int>(6, 3));
            fastMoney3Data.Add("Orange", new Tuple<int, int>(6, 3));
            fastMoney3Data.Add("Yellow", new Tuple<int, int>(3, 3));
            fastMoney3Data.Add("Blue", new Tuple<int, int>(2, 3));
            fastMoney3Data.Add("Red", new Tuple<int, int>(2, 3));
            //end FM question 3

            //Fast money question 4
            fastMoneyQuestion4 = "A city that borders a Great Lake.";
            fastMoney4Data.Add("Chicago", new Tuple<int, int>(42, 1));
            fastMoney4Data.Add("Cleveland", new Tuple<int, int>(23, 2));
            fastMoney4Data.Add("Milwaukee", new Tuple<int, int>(11, 3));
            fastMoney4Data.Add("Buffalo", new Tuple<int, int>(6, 3));
            fastMoney4Data.Add("Green Bay", new Tuple<int, int>(6, 3));
            fastMoney4Data.Add("Toronto", new Tuple<int, int>(5, 3));
            fastMoney4Data.Add("Detroit", new Tuple<int, int>(2, 3));
            fastMoney4Data.Add("Toledo", new Tuple<int, int>(2, 3));
            //end FM question 4

            //Fast Money question 5
            fastMoneyQuestion5 = "An element that is a gas.";
            fastMoney5Data.Add("Oxygen", new Tuple<int, int>(34, 1));
            fastMoney5Data.Add("Helium", new Tuple<int, int>(28, 2));
            fastMoney5Data.Add("Hydrogen", new Tuple<int, int>(18, 3));
            fastMoney5Data.Add("Nitrogen", new Tuple<int, int>(6, 3));
            fastMoney5Data.Add("Argon", new Tuple<int, int>(3, 3));
            fastMoney5Data.Add("Neon", new Tuple<int, int>(3, 3));
            fastMoney5Data.Add("Radon", new Tuple<int, int>(2, 3));
            fastMoney5Data.Add("Xenon", new Tuple<int, int>(2, 3));
            //end fm question 5

            //top answers
            topAnswers[0] = "United Kingdom";
            topAnswers[1] = "1 Day";
            topAnswers[2] = "Brown";
            topAnswers[3] = "Chicago";
            topAnswers[4] = "Oxygen";
            topAnswers[5] = "Ukraine";
            topAnswers[6] = "2 Days";
            topAnswers[7] = "Clear";
            topAnswers[8] = "Cleveland";
            topAnswers[9] = "Helium";
            perfectGame = 310;
            //end top answers

        }
        //game 15
        public void generateGame15()
        {
            //question 1
            answersLeft1 = 9;
            question1 = "Besides the United States, name the country you believe is the best in the world.";
            question1Number1 = "Canada";
            question1Number1Points = 15;
            question1Number2 = "Australia";
            question1Number2Points = 13;
            question1Number3 = "United Kingdom";
            question1Number3Points = 13;
            question1Number4 = "China";
            question1Number4Points = 9;
            question1Number5 = "Japan";
            question1Number5Points = 9;
            question1Number6 = "France";
            question1Number6Points = 8;
            question1Number7 = "Sweden";
            question1Number7Points = 6;
            question1Number8 = "Switzerland";
            question1Number8Points = 6;
            question1Number9 = "Germany";
            question1Number9Points = 5; //TOTAL: 84
            //end question 1

            //question 2
            answersLeft2 = 7;
            question2 = "Name a three-letter abbreviation commonly used when texting.";
            question2Number1 = "LOL";
            question2Number1Points = 51;
            question2Number2 = "OMG";
            question2Number2Points = 20;
            question2Number3 = "IDK";
            question2Number3Points = 8;
            question2Number4 = "BRB";
            question2Number4Points = 5;
            question2Number5 = "BTW";
            question2Number5Points = 4;
            question2Number6 = "WTF";
            question2Number6Points = 4;
            question2Number7 = "IMO";
            question2Number7Points = 2; //TOTAL: 94
            //end question 2

            //question 3 (Double)
            answersLeft3 = 7;
            question3 = "Name a service building even a town of only 1,000 people should have.";
            question3Number1 = "City Hall";
            question3Number1Points = 28;
            question3Number2 = "School";
            question3Number2Points = 23;
            question3Number3 = "Police Station";
            question3Number3Points = 15;
            question3Number4 = "Library";
            question3Number4Points = 8;
            question3Number5 = "Fire Station";
            question3Number5Points = 7;
            question3Number6 = "Grocery Store";
            question3Number6Points = 4;
            question3Number7 = "Post Office";
            question3Number7Points = 2;
            //end question 3

            //question 4 (Double)
            answersLeft4 = 5;
            question4 = "A magazine you feel would be better used as fire tinder than as something to read.";
            question4Number1 = "National Enquirer";
            question4Number1Points = 37;
            question4Number2 = "Playboy";
            question4Number2Points = 35;
            question4Number3 = "Esquire";
            question4Number3Points = 9;
            question4Number4 = "Cosmopolitan";
            question4Number4Points = 6;
            question4Number5 = "Globe";
            question4Number5Points = 4; //TOTAL: 91
            //end question 4

            //question 5 (Triple)
            answersLeft5 = 4;
            question5 = "Name a place where you would see a pharmacy.";
            question5Number1 = "Grocery Store";
            question5Number1Points = 47;
            question5Number2 = "Clinic";
            question5Number2Points = 21;
            question5Number3 = "Drugstore";
            question5Number3Points = 19;
            question5Number4 = "Hospital";
            question5Number4Points = 12;  //TOTAL: 99... Tripled: 297
            //end question 5

            //Fast money question 1
            fastMoneyQuestion1 = "Name one of the six food groups on the food pyramid.";
            fastMoney1Data.Add("Fruits", new Tuple<int, int>(31, 1));
            fastMoney1Data.Add("Grains", new Tuple<int, int>(26, 2));
            fastMoney1Data.Add("Vegetables", new Tuple<int, int>(21, 3));
            fastMoney1Data.Add("Meat", new Tuple<int, int>(12, 3));
            fastMoney1Data.Add("Dairy", new Tuple<int, int>(8, 3));
            fastMoney1Data.Add("Fats, Oils And Sweets", new Tuple<int, int>(2, 3));
            //end fm question 1

            //Fast money question 2
            fastMoneyQuestion2 = "Name a phrase that includes the word ''fortune''.";
            fastMoney2Data.Add("Wheel Of Fortune", new Tuple<int, int>(39, 1));
            fastMoney2Data.Add("Fortune Cookie", new Tuple<int, int>(27, 2));
            fastMoney2Data.Add("Fortune Teller", new Tuple<int, int>(16, 3));
            fastMoney2Data.Add("Small Fortune", new Tuple<int, int>(5, 3));
            fastMoney2Data.Add("Good Fortune", new Tuple<int, int>(2, 3));
            fastMoney2Data.Add("Soldiers Of Fortune", new Tuple<int, int>(2, 3));
            fastMoney2Data.Add("Stroke Of Fortune", new Tuple<int, int>(2, 3));
            //end fm question 2

            //Fast Money question 3
            fastMoneyQuestion3 = "How many miles does the average car last?";
            fastMoney3Data.Add("100,000", new Tuple<int, int>(45, 1));
            fastMoney3Data.Add("150,000", new Tuple<int, int>(18, 2));
            fastMoney3Data.Add("200,000", new Tuple<int, int>(11, 3));
            fastMoney3Data.Add("125,000", new Tuple<int, int>(7, 3));
            fastMoney3Data.Add("250,000", new Tuple<int, int>(3, 3));
            fastMoney3Data.Add("110,000", new Tuple<int, int>(2, 3));
            fastMoney3Data.Add("120,000", new Tuple<int, int>(2, 3));
            fastMoney3Data.Add("175,000", new Tuple<int, int>(2, 3));
            fastMoney3Data.Add("180,000", new Tuple<int, int>(2, 3));
            //end fm question 3

            //Fast Money question 4
            fastMoneyQuestion4 = "A food that includes cherries or cherry flavor.";
            fastMoney4Data.Add("Pie", new Tuple<int, int>(33, 1));
            fastMoney4Data.Add("Candy", new Tuple<int, int>(28, 2));
            fastMoney4Data.Add("Popsicle", new Tuple<int, int>(14, 3));
            fastMoney4Data.Add("Yogurt", new Tuple<int, int>(14, 3));
            fastMoney4Data.Add("Ice Cream", new Tuple<int, int>(4, 3));
            fastMoney4Data.Add("Juice", new Tuple<int, int>(2, 3));
            fastMoney4Data.Add("Soda", new Tuple<int, int>(2, 3));
            //end FM question 4

            //Fast money question 5
            fastMoneyQuestion5 = "What might happen to you after you die?";
            fastMoney5Data.Add("Go To Heaven", new Tuple<int, int>(51, 1));
            fastMoney5Data.Add("Nothing", new Tuple<int, int>(17, 2));
            fastMoney5Data.Add("Become A Ghost", new Tuple<int, int>(14, 3));
            fastMoney5Data.Add("Go To Hell", new Tuple<int, int>(12, 3));
            fastMoney5Data.Add("Reincarnation", new Tuple<int, int>(5, 3));
            //end fm question 5

            //top answers
            topAnswers[0] = "Fruits";
            topAnswers[1] = "Wheel Of Fortune";
            topAnswers[2] = "100,000";
            topAnswers[3] = "Pie";
            topAnswers[4] = "Go To Heaven";
            topAnswers[5] = "Grains";
            topAnswers[6] = "Fortune Cookie";
            topAnswers[7] = "150,000";
            topAnswers[8] = "Candy";
            topAnswers[9] = "Nothing";
            perfectGame = 315;
            //end top answers

        }
        //game 16
        public void generateGame16()
        {
            //question 1
            answersLeft1 = 9;
            question1 = "Name a rock star who died in the past couple years (as of 2017).";
            question1Number1 = "Prince";
            question1Number1Points = 16;
            question1Number2 = "David Bowie";
            question1Number2Points = 15;
            question1Number3 = "Chuck Berry";
            question1Number3Points = 10;
            question1Number4 = "Lemmy";
            question1Number4Points = 8;
            question1Number5 = "Glenn Frey";
            question1Number5Points = 8;
            question1Number6 = "Keith Emerson";
            question1Number6Points = 7;
            question1Number7 = "J. Geils";
            question1Number7Points = 6;
            question1Number8 = "George Michael";
            question1Number8Points = 6;
            question1Number9 = "Chris Cornell";
            question1Number9Points = 5; //TOTAL: 81
            //end question 1

            //question 2
            answersLeft2 = 7;
            question2 = "Name a quickly broken New Year's Resolution.";
            question2Number1 = "Lose Weight";
            question2Number1Points = 49;
            question2Number2 = "Stop Smoking";
            question2Number2Points = 17;
            question2Number3 = "Stop Drinking";
            question2Number3Points = 9;
            question2Number4 = "Get Out Of Debt";
            question2Number4Points = 8;
            question2Number5 = "Travel";
            question2Number5Points = 4;
            question2Number6 = "Try Something New";
            question2Number6Points = 4;
            question2Number7 = "Exercise";
            question2Number7Points = 3; //TOTAL: 94
            //end question 2

            //question 3
            answersLeft3 = 5;
            question3 = "Name a musical artist that was big in 2015.";
            question3Number1 = "Adele";
            question3Number1Points = 34;
            question3Number2 = "Taylor Swift";
            question3Number2Points = 32;
            question3Number3 = "Ed Sheeran";
            question3Number3Points = 11;
            question3Number4 = "Drake";
            question3Number4Points = 7;
            question3Number5 = "The Weeknd";
            question3Number5Points = 6; //TOTAL: 90... Doubled: 180
            //end question 3

            //question 4
            answersLeft4 = 6;
            question4 = "Name a blockbuster movie released in 2015.";
            question4Number1 = "Star Wars Episode VII";
            question4Number1Points = 32;
            question4Number2 = "Jurassic World";
            question4Number2Points = 31;
            question4Number3 = "Inside Out";
            question4Number3Points = 13;
            question4Number4 = "Furious 7";
            question4Number4Points = 6;
            question4Number5 = "The Avengers Age Of Ultron";
            question4Number5Points = 4;
            question4Number6 = "Minions";
            question4Number6Points = 3; //TOTAL: 89... Doubled: 178
            //end question 4

            //question 5
            answersLeft5 = 3;
            question5 = "Name a city famous for hosting a big New Year's celebration.";
            question5Number1 = "New York";
            question5Number1Points = 95;
            question5Number2 = "Las Vegas";
            question5Number2Points = 2;
            question5Number3 = "Sydney";
            question5Number3Points = 2; //TOTAL: 99... Tripled: 297
            //end question 5

            //fast money question 1
            fastMoneyQuestion1 = "Name the hour you go to bed on New Year's.";
            fastMoney1Data.Add("1 AM", new Tuple<int, int>(38, 1));
            fastMoney1Data.Add("2 AM", new Tuple<int, int>(25, 2));
            fastMoney1Data.Add("12 AM", new Tuple<int, int>(18, 3));
            fastMoney1Data.Add("3 AM", new Tuple<int, int>(11, 3));
            fastMoney1Data.Add("4 AM", new Tuple<int, int>(5, 3));
            //end FM question 1

            //fast money question 2
            fastMoneyQuestion2 = "A brand of champagne.";
            fastMoney2Data.Add("Perrier", new Tuple<int, int>(33, 1));
            fastMoney2Data.Add("Moet & Chandon", new Tuple<int, int>(27, 2));
            fastMoney2Data.Add("Veuve Cliquot", new Tuple<int, int>(12, 3));
            fastMoney2Data.Add("Taittinger", new Tuple<int, int>(7, 3));
            fastMoney2Data.Add("Feuillate", new Tuple<int, int>(5, 3));
            fastMoney2Data.Add("Dom Perignon", new Tuple<int, int>(2, 3));
            fastMoney2Data.Add("G. H. Mumm", new Tuple<int, int>(2, 3));
            fastMoney2Data.Add("Lanson", new Tuple<int, int>(2, 3));
            fastMoney2Data.Add("Pommery", new Tuple<int, int>(2, 3));
            //end FM question 2

            //fast money question 3
            fastMoneyQuestion3 = "A common cola brand seen on soda pop machines.";
            fastMoney3Data.Add("Coca-Cola", new Tuple<int, int>(37, 1));
            fastMoney3Data.Add("Pepsi", new Tuple<int, int>(35, 2));
            fastMoney3Data.Add("Dr. Pepper", new Tuple<int, int>(9, 3));
            fastMoney3Data.Add("Sprite", new Tuple<int, int>(8, 3));
            fastMoney3Data.Add("Mountain Dew", new Tuple<int, int>(3, 3));
            fastMoney3Data.Add("Diet Coke", new Tuple<int, int>(2, 3));
            fastMoney3Data.Add("Diet Pepsi", new Tuple<int, int>(2, 3));
            fastMoney3Data.Add("Diet Dr. Pepper", new Tuple<int, int>(2, 3));
            //end FM question 2

            //fast money question 4
            fastMoneyQuestion4 = "Something associated with New Year's that starts with the letter ''B''.";
            fastMoney4Data.Add("Ball", new Tuple<int, int>(31, 1));
            fastMoney4Data.Add("Beer", new Tuple<int, int>(26, 2));
            fastMoney4Data.Add("Babies", new Tuple<int, int>(20, 3));
            fastMoney4Data.Add("Balloons", new Tuple<int, int>(12, 3));
            fastMoney4Data.Add("Bubbly", new Tuple<int, int>(3, 3));
            fastMoney4Data.Add("Butterflies", new Tuple<int, int>(2, 3));
            //end FM question 4

            //fast money question 5
            fastMoneyQuestion5 = "Name any time zone.";
            fastMoney5Data.Add("Eastern", new Tuple<int, int>(40, 1));
            fastMoney5Data.Add("Pacific", new Tuple<int, int>(24, 2));
            fastMoney5Data.Add("Central", new Tuple<int, int>(21, 3));
            fastMoney5Data.Add("Mountain", new Tuple<int, int>(12, 3));
            fastMoney5Data.Add("Atlantic", new Tuple<int, int>(2, 3));
            //end FM question 5

            //top answers
            topAnswers[0] = "1 AM";
            topAnswers[1] = "Perrier";
            topAnswers[2] = "Coca-Cola";
            topAnswers[3] = "Ball";
            topAnswers[4] = "Eastern";
            topAnswers[5] = "2 AM";
            topAnswers[6] = "Moet & Chandon";
            topAnswers[7] = "Pepsi";
            topAnswers[8] = "Beer";
            topAnswers[9] = "Pacific";
            //end top Answers
            perfectGame = 316;
        }
        //game 17
        public void generateGame17()
        {
            //question 1
            answersLeft1 = 6;
            question1 = "Name a word that rhymes with ''task''.";
            question1Number1 = "Mask";
            question1Number1Points = 52;
            question1Number2 = "Bask";
            question1Number2Points = 16;
            question1Number3 = "Flask";
            question1Number3Points = 9;
            question1Number4 = "Ask";
            question1Number4Points = 8;
            question1Number5 = "Cask";
            question1Number5Points = 2;
            question1Number6 = "Unmask";
            question1Number6Points = 2; //TOTAL: 89
            //end question 1

            //question 2
            answersLeft2 = 6;
            question2 = "Name something that could happen if you get punched in the face.";
            question2Number1 = "Black Eye";
            question2Number1Points = 35;
            question2Number2 = "Broken Nose";
            question2Number2Points = 23;
            question2Number3 = "Teeth Knocked Out";
            question2Number3Points = 15;
            question2Number4 = "Knocked Out";
            question2Number4Points = 13;
            question2Number5 = "Broken Jaw";
            question2Number5Points = 4;
            question2Number6 = "Die";
            question2Number6Points = 2; //TOTAL: 92
            //end question 2

            //question 3 (Double)
            answersLeft3 = 7;
            question3 = "Name a TV show popular in 1990.";
            question3Number1 = "Full House";
            question3Number1Points = 28;
            question3Number2 = "Seinfeld";
            question3Number2Points = 17;
            question3Number3 = "The Cosby Show";
            question3Number3Points = 12;
            question3Number4 = "Cheers";
            question3Number4Points = 10;
            question3Number5 = "Saved By The Bell";
            question3Number5Points = 8;
            question3Number6 = "Murder, She Wrote";
            question3Number6Points = 6;
            question3Number7 = "Coach";
            question3Number7Points = 5; //TOTAL: 86... Doubled: 172
            //end question 3

            //question 4 (Double)
            answersLeft4 = 8;
            question4 = "Name any English County.";
            question4Number1 = "Surrey";
            question4Number1Points = 13;
            question4Number2 = "Buckinghamshire";
            question4Number2Points = 10;
            question4Number3 = "Greater London";
            question4Number3Points = 10;
            question4Number4 = "Hampshire";
            question4Number4Points = 8;
            question4Number5 = "Devon";
            question4Number5Points = 6;
            question4Number6 = "Essex";
            question4Number6Points = 6;
            question4Number7 = "Cheshire";
            question4Number7Points = 5;
            question4Number8 = "Norfolk";
            question4Number8Points = 5; //TOTAL: 63... Doubled: 126

            //question 5 (Triple)
            answersLeft5 = 5;
            question5 = "What do you think is the most important city in the United States?";
            question5Number1 = "Washington DC";
            question5Number1Points = 61;
            question5Number2 = "New York";
            question5Number2Points = 19;
            question5Number3 = "Los Angeles";
            question5Number3Points = 11;
            question5Number4 = "Chicago";
            question5Number4Points = 2;
            question5Number5 = "Philadelphia";
            question5Number5Points = 2; //TOTAL: 95... Tripled: 275
            //end question 5

            //Fast money question 1
            fastMoneyQuestion1 = "Name a term used in algebra.";
            fastMoney1Data.Add("X", new Tuple<int, int>(21, 1));
            fastMoney1Data.Add("Integer", new Tuple<int, int>(17, 2));
            fastMoney1Data.Add("Variable", new Tuple<int, int>(9, 3));
            fastMoney1Data.Add("Coefficient", new Tuple<int, int>(7, 3));
            fastMoney1Data.Add("Exponent", new Tuple<int, int>(7, 3));
            fastMoney1Data.Add("Quadratic", new Tuple<int, int>(6, 3));
            fastMoney1Data.Add("Root", new Tuple<int, int>(6, 3));
            fastMoney1Data.Add("Polynomial", new Tuple<int, int>(4, 3));
            fastMoney1Data.Add("Radical", new Tuple<int, int>(4, 3));
            fastMoney1Data.Add("Y", new Tuple<int, int>(4, 3));
            fastMoney1Data.Add("Rational", new Tuple<int, int>(3, 3));
            fastMoney1Data.Add("Degree", new Tuple<int, int>(2, 3));
            fastMoney1Data.Add("Function", new Tuple<int, int>(2, 3));
            fastMoney1Data.Add("Ratio", new Tuple<int, int>(2, 3));
            //end FM question 1

            //Fast money question 2
            fastMoneyQuestion2 = "Which of the seven deadly sins do you commit the most?";
            fastMoney2Data.Add("Gluttony", new Tuple<int, int>(28, 1));
            fastMoney2Data.Add("Lust", new Tuple<int, int>(24, 2));
            fastMoney2Data.Add("Sloth", new Tuple<int, int>(16, 3));
            fastMoney2Data.Add("Greed", new Tuple<int, int>(13, 3));
            fastMoney2Data.Add("Pride", new Tuple<int, int>(10, 3));
            fastMoney2Data.Add("Wrath", new Tuple<int, int>(5, 3));
            fastMoney2Data.Add("Envy", new Tuple<int, int>(4, 3));
            //end FM question 2

            //Fast money question 3
            fastMoneyQuestion3 = "A TV network that talks about politics.";
            fastMoney3Data.Add("C-SPAN", new Tuple<int, int>(37, 1));
            fastMoney3Data.Add("CNN", new Tuple<int, int>(16, 2));
            fastMoney3Data.Add("Fox News", new Tuple<int, int>(13, 3));
            fastMoney3Data.Add("MSNBC", new Tuple<int, int>(7, 3));
            fastMoney3Data.Add("C-SPAN 2", new Tuple<int, int>(4, 3));
            fastMoney3Data.Add("HLN", new Tuple<int, int>(4, 3));
            fastMoney3Data.Add("PBS", new Tuple<int, int>(4, 3));
            fastMoney3Data.Add("Bloomberg", new Tuple<int, int>(3, 3));
            fastMoney3Data.Add("CBS", new Tuple<int, int>(3, 3));
            fastMoney3Data.Add("ABC", new Tuple<int, int>(2, 3));
            fastMoney3Data.Add("CNBC", new Tuple<int, int>(2, 3));
            fastMoney3Data.Add("NBC", new Tuple<int, int>(2, 3));
            //end FM question 3

            //Fast money question 4
            fastMoneyQuestion4 = "How much a combo at Arby's costs.";
            fastMoney4Data.Add("$8", new Tuple<int, int>(35, 1));
            fastMoney4Data.Add("$7", new Tuple<int, int>(27, 2));
            fastMoney4Data.Add("$9", new Tuple<int, int>(16, 3));
            fastMoney4Data.Add("$10", new Tuple<int, int>(8, 3));
            fastMoney4Data.Add("$7.50", new Tuple<int, int>(4, 3));
            fastMoney4Data.Add("$6", new Tuple<int, int>(3, 3));
            fastMoney4Data.Add("$8.50", new Tuple<int, int>(2, 3));
            //end FM question 4

            //Fast money question 5
            fastMoneyQuestion5 = "A game that uses dice.";
            fastMoney5Data.Add("Monopoly", new Tuple<int, int>(48, 1));
            fastMoney5Data.Add("Craps", new Tuple<int, int>(23, 2));
            fastMoney5Data.Add("Yahtzee", new Tuple<int, int>(13, 3));
            fastMoney5Data.Add("Boggle", new Tuple<int, int>(7, 3));
            fastMoney5Data.Add("Backgammon", new Tuple<int, int>(2, 3));
            fastMoney5Data.Add("Farkle", new Tuple<int, int>(2, 3));
            fastMoney5Data.Add("Trivial Pursuit", new Tuple<int, int>(2, 3));
            //end question 5

            //top answers
            topAnswers[0] = "X";
            topAnswers[1] = "Gluttony";
            topAnswers[2] = "C-SPAN";
            topAnswers[3] = "$8";
            topAnswers[4] = "Monopoly";
            topAnswers[5] = "Integer";
            topAnswers[6] = "Lust";
            topAnswers[7] = "CNN";
            topAnswers[8] = "$7";
            topAnswers[9] = "Craps";
            //end top Answers
            perfectGame = 276;

        }
        //game 18
        public void generateGame18()
        {
            //question 1
            answersLeft1 = 7;
            question1 = "Name something old people do slower than young people.";
            question1Number1 = "Drive";
            question1Number1Points = 24;
            question1Number2 = "Walk";
            question1Number2Points = 20;
            //tba
        }
    }
}
