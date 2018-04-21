using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyFeudPrism
{
    public class GameBoard
    {
        public Database database = new Database();
        public int gameNumber; //represents the current game number
        public string[] topAnswers; //shows #1 and #2 answers for fast money
        #region questionfields
        public int questionNumber = 0; //shows which question the game is currently on
        public int strikeNumber = 0; //shows how many strikes the player has
        public int roundPoints = 0; //shows how many points the player has in current round
        public int totalPoints = 0; //shows how many total points the player has;
        public int perfectGame = 0; //shows value of a perfect game in Fast Money
        public string question = ""; //shows the current question
        public int answersLeft; //shows how many answers are left to be revealed.
        #endregion

        #region answerfields
        public string number1 = "-1-"; //#1 Answer
        public int num1 = 0; //#1 Answer point value
        public int num1Color = 0; //Fast Money answer 1 color
        public string number2 = "-2-"; //#2 Answer
        public int num2 = 0; //#2 Answer point value
        public int num2Color = 0; //Fast Money answer 2 color
        public string number3 = "-3-"; //#3 Answer
        public int num3 = 0; //#3 Answer point value
        public int num3Color = 0; //Fast Money answer 3 color
        public string number4 = "-4-"; //#4 Answer
        public int num4 = 0; //#4 Answer point value
        public int num4Color = 0; //Fast Money answer 4 color
        public string number5 = "-5-"; //#5 Answer
        public int num5 = 0; //#5 Answer point value
        public int num5Color = 0; //Fast Money answer 5 color
        public string number6 = "-6-"; //#6 Answer
        public int num6 = 0; //#6 Answer point value
        public string number7 = "-7-"; //#7 Answer
        public int num7 = 0; //#7 Answer point value
        public string number8 = "-8-"; //#8 Answer
        public int num8 = 0; //#8 Answer point value
        public string number9 = "-9-"; //#9 Answer
        public int num9 = 0; //#9 Answer point value
        #endregion

        public GameBoard()
        {
            Random r = new Random();
            gameNumber = r.Next(20) + 1;
            if (gameNumber == 1) database.generateGame1();
            else if (gameNumber == 2) database.generateGame2();
            else if (gameNumber == 3) database.generateGame3();
            else if (gameNumber == 4) database.generateGame4();
            else if (gameNumber == 5) database.generateGame5();
            else if (gameNumber == 6) database.generateGame6();
            else if (gameNumber == 7) database.generateGame7();
            else if (gameNumber == 8) database.generateGame8();
            else if (gameNumber == 9) database.generateGame9();
            else if (gameNumber == 10) database.generateGame10();
            else if (gameNumber == 11) database.generateGame11();
            else if (gameNumber == 12) database.generateGame12();
            else if (gameNumber == 13) database.generateGame13();
            else if (gameNumber == 14) database.generateGame14();
            else if (gameNumber == 15) database.generateGame15();
            else if (gameNumber == 16) database.generateGame16();
            else if (gameNumber == 17) database.generateGame17();
            //else if (gameNumber == 18) database.generateGame18(); //game not coded yet
            //else if (gameNumber == 19) database.generateGame19(); //game not coded yet
            //else if (gameNumber == 20) database.generateGame20(); //game not coded yet
            else database.generateGame1(); //default game
            topAnswers = database.topAnswers;
        }
        public void question1() //first question, single value
        {
            questionNumber = 1;
            answersLeft = database.answersLeft1;
            question = database.question1;
            number1 = database.question1Number1;
            num1 = database.question1Number1Points;
            number2 = database.question1Number2;
            num2 = database.question1Number2Points;
            number3 = database.question1Number3;
            num3 = database.question1Number3Points;
            number4 = database.question1Number4;
            num4 = database.question1Number4Points;
            number5 = database.question1Number5;
            num5 = database.question1Number5Points;
            number6 = database.question1Number6;
            num6 = database.question1Number6Points;
            number7 = database.question1Number7;
            num7 = database.question1Number7Points;
            number8 = database.question1Number8;
            num8 = database.question1Number8Points;
            number9 = database.question1Number9;
            num9 = database.question1Number9Points;
        }
        public void question2() //second question, single value
        {
            questionNumber = 2;
            answersLeft = database.answersLeft2;
            question = database.question2;
            number1 = database.question2Number1;
            num1 = database.question2Number1Points;
            number2 = database.question2Number2;
            num2 = database.question2Number2Points;
            number3 = database.question2Number3;
            num3 = database.question2Number3Points;
            number4 = database.question2Number4;
            num4 = database.question2Number4Points;
            number5 = database.question2Number5;
            num5 = database.question2Number5Points;
            number6 = database.question2Number6;
            num6 = database.question2Number6Points;
            number7 = database.question2Number7;
            num7 = database.question2Number7Points;
            number8 = database.question2Number8;
            num8 = database.question2Number8Points;
            number9 = database.question2Number9;
            num9 = database.question2Number9Points;
        }
        public void question3() //third question, double value
        {
            questionNumber = 3;
            answersLeft = database.answersLeft3;
            question = database.question3;
            number1 = database.question3Number1;
            num1 = database.question3Number1Points;
            number2 = database.question3Number2;
            num2 = database.question3Number2Points;
            number3 = database.question3Number3;
            num3 = database.question3Number3Points;
            number4 = database.question3Number4;
            num4 = database.question3Number4Points;
            number5 = database.question3Number5;
            num5 = database.question3Number5Points;
            number6 = database.question3Number6;
            num6 = database.question3Number6Points;
            number7 = database.question3Number7;
            num7 = database.question3Number7Points;
            number8 = database.question3Number8;
            num8 = database.question3Number8Points;
        }
        public void question4() //fourth question, double value
        {
            questionNumber = 4;
            answersLeft = database.answersLeft4;
            question = database.question4;
            number1 = database.question4Number1;
            num1 = database.question4Number1Points;
            number2 = database.question4Number2;
            num2 = database.question4Number2Points;
            number3 = database.question4Number3;
            num3 = database.question4Number3Points;
            number4 = database.question4Number4;
            num4 = database.question4Number4Points;
            number5 = database.question4Number5;
            num5 = database.question4Number5Points;
            number6 = database.question4Number6;
            num6 = database.question4Number6Points;
            number7 = database.question4Number7;
            num7 = database.question4Number7Points;
            number8 = database.question4Number8;
            num8 = database.question4Number8Points;
        }
        public void question5() //fifth question, triple value
        {
            questionNumber = 5;
            answersLeft = database.answersLeft5;
            question = database.question5;
            number1 = database.question5Number1;
            num1 = database.question5Number1Points;
            number2 = database.question5Number2;
            num2 = database.question5Number2Points;
            number3 = database.question5Number3;
            num3 = database.question5Number3Points;
            number4 = database.question5Number4;
            num4 = database.question5Number4Points;
            number5 = database.question5Number5;
            num5 = database.question5Number5Points;
        }
        public string[] fastMoneyQuestions()
        {
            string[] FMQuestions = new string[5]; //array of fast money questions
            FMQuestions[0] = database.fastMoneyQuestion1;
            FMQuestions[1] = database.fastMoneyQuestion2;
            FMQuestions[2] = database.fastMoneyQuestion3;
            FMQuestions[3] = database.fastMoneyQuestion4;
            FMQuestions[4] = database.fastMoneyQuestion5;
            return FMQuestions;
        }
        public void fastMoney(string[] input) //fast money
        {
            perfectGame = database.perfectGame;
            Dictionary<string, Tuple<int, int>> temp1 = database.fastMoney1Data;
            Dictionary<string, Tuple<int, int>> temp2 = database.fastMoney2Data;
            Dictionary<string, Tuple<int, int>> temp3 = database.fastMoney3Data;
            Dictionary<string, Tuple<int, int>> temp4 = database.fastMoney4Data;
            Dictionary<string, Tuple<int, int>> temp5 = database.fastMoney5Data;
            Tuple<int, int> value1;
            Tuple<int, int> value2;
            Tuple<int, int> value3;
            Tuple<int, int> value4;
            Tuple<int, int> value5;
            //question 1
            if (input[0] != null)
            {
                if (temp1.TryGetValue(input[0], out value1))
                {
                    number1 = input[0];
                    num1 = value1.Item1;
                    num1Color = value1.Item2;
                }
                else
                {
                    number1 = input[0];
                    num1 = 0;
                    num1Color = 0;
                }
            }
            else
            {
                number1 = "";
                num1 = 0;
                num1Color = 0;
            }
            //end question 1
            //question 2
            if (input[1] != null)
            {
                if (temp2.TryGetValue(input[1], out value2))
                {
                    number2 = input[1];
                    num2 = value2.Item1;
                    num2Color = value2.Item2;
                }
                else
                {
                    number2 = input[1];
                    num2 = 0;
                    num2Color = 0;
                }
            }
            else
            {
                number2 = "";
                num2 = 0;
                num2Color = 0;
            }
            //end question 2
            //question 3
            if (input[2] != null)
            {
                if (temp3.TryGetValue(input[2], out value3))
                {
                    number3 = input[2];
                    num3 = value3.Item1;
                    num3Color = value3.Item2;
                }
                else
                {
                    number3 = input[2];
                    num3 = 0;
                    num3Color = 0;
                }
            }
            else
            {
                number3 = "";
                num3 = 0;
                num3Color = 0;
            }
            //end question 3
            //question 4
            if (input[3] != null)
            {
                if (temp4.TryGetValue(input[3], out value4))
                {
                    number4 = input[3];
                    num4 = value4.Item1;
                    num4Color = value4.Item2;
                }
                else
                {
                    number4 = input[3];
                    num4 = 0;
                    num4Color = 0;
                }
            }
            else
            {
                number4 = "";
                num4 = 0;
                num4Color = 0;
            }
            //end question 4
            //question 5
            if (input[4] != null)
            {
                if (temp5.TryGetValue(input[4], out value5))
                {
                    number5 = input[4];
                    num5 = value5.Item1;
                    num5Color = value5.Item2;
                }
                else
                {
                    number5 = input[4];
                    num5 = 0;
                    num5Color = 0;
                }
            }
            else
            {
                number5 = "";
                num5 = 0;
                num5Color = 0;
            }
            //end question 5
        }
        public void resetForFastMoney2()
        {
            number1 = "";
            number2 = "";
            number3 = "";
            number4 = "";
            number5 = "";
            num1 = 0;
            num2 = 0;
            num3 = 0;
            num4 = 0;
            num5 = 0;
            num1Color = 0;
            num2Color = 0;
            num3Color = 0;
            num4Color = 0;
            num5Color = 0;
        }
    }
}
