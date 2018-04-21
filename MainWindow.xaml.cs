using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Timers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Windows.Media.Animation;
//GOALS:
//1 (optional). Animate strikes in maingame & FM answers to reveal left to right
//2. Get timers working properly in both maingame (30 seconds) and FM (First: 35, Second: 30)
//3. Eliminate duplicates in FM (using List) (partially done)
namespace FamilyFeudPrism
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer();
        public int time = 30;
        #region sounds
        public SoundPlayer clang = new SoundPlayer("clang.wav");
        public SoundPlayer buzzer = new SoundPlayer("buzzer.wav");
        public SoundPlayer blip = new SoundPlayer("blip.wav");
        public SoundPlayer bell = new SoundPlayer("bell.wav");
        public SoundPlayer zero = new SoundPlayer("zero.wav");
        public SoundPlayer theme = new SoundPlayer("theme.wav");
        public SoundPlayer question2 = new SoundPlayer("question2.wav");
        public SoundPlayer question3 = new SoundPlayer("question3.wav");
        public SoundPlayer question4 = new SoundPlayer("question4.wav");
        public SoundPlayer question5 = new SoundPlayer("question5.wav");
        public SoundPlayer fastmoneywin = new SoundPlayer("fastmoneywin.wav");
        public SoundPlayer fastmoneydings = new SoundPlayer("fivebells.wav");
        public SoundPlayer fastmoney1 = new SoundPlayer("fm1.wav");
        public SoundPlayer fastmoney2 = new SoundPlayer("fm2.wav");
        #endregion
        public string[] fastMoney = new string[5];
        public string[] fastMoneyQuestions = new string[5];
        public List<string> answersAlreadyUsed = new List<string>(); //#3
        bool isAlreadyUsed = false;
        public GameBoard game = new GameBoard();
        private int i = 0;
        public MainWindow()
        {
            InitializeComponent();
            theme.Play(); 
            uxInfo.Text = "It's time to play Family Feud! Click on the ''Rd. 1'' button to start the game. Game #" + game.gameNumber;
            time = 30;
            _timer.Tick += new EventHandler(timer_Tick);
        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {
            BackgroundWorker bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;
            if (game.questionNumber < 6) //not yet in fast money
            {
                time = 30;
                _timer.Start();
                uxLabel1.Content = time.ToString();
                if (string.Equals(uxInput.Text, game.number1, StringComparison.CurrentCultureIgnoreCase))
                {
                    foreach (string s in answersAlreadyUsed)
                    {
                        if (uxInput.Text == s)
                        {
                            isAlreadyUsed = true;
                        }
                    }
                    if (isAlreadyUsed == true) strike();
                    else
                    {
                        answersAlreadyUsed.Add(uxInput.Text);
                        DoubleAnimation heightAnimation = new DoubleAnimation(77, 0, TimeSpan.FromMilliseconds(100));
                        heightAnimation.AutoReverse = true;
                        uxNumber1Answer.BeginAnimation(Label.HeightProperty, heightAnimation);
                        uxNumber1Points.BeginAnimation(Label.HeightProperty, heightAnimation);
                        uxNumber1Answer.Content = game.number1;
                        uxNumber1Points.Content = game.num1;
                        if (game.questionNumber == 1 || game.questionNumber == 2) game.roundPoints += game.num1;
                        else if (game.questionNumber == 3 || game.questionNumber == 4) game.roundPoints += (game.num1 * 2);
                        else if (game.questionNumber == 5) game.roundPoints += (game.num1 * 3);
                        clang.Play();
                        DoubleAnimation heightAnimation1 = new DoubleAnimation(98, 0, TimeSpan.FromMilliseconds(100));
                        heightAnimation1.AutoReverse = true;
                        uxScore.BeginAnimation(Label.WidthProperty, heightAnimation1);
                        uxScore.Content = game.roundPoints;
                        game.answersLeft--;
                        uxInfo.Text = "That's the #1 Answer! " + game.answersLeft + " answers left to reveal.";
                    }
                }
                else if (string.Equals(uxInput.Text, game.number2, StringComparison.CurrentCultureIgnoreCase))
                {
                    foreach (string s in answersAlreadyUsed)
                    {
                        if (uxInput.Text == s)
                        {
                            isAlreadyUsed = true;
                        }
                    }
                    if (isAlreadyUsed == true) strike();
                    else
                    {
                        answersAlreadyUsed.Add(uxInput.Text);
                        DoubleAnimation heightAnimation2 = new DoubleAnimation(77, 0, TimeSpan.FromMilliseconds(100));
                        heightAnimation2.AutoReverse = true;
                        uxNumber2Answer.BeginAnimation(Label.HeightProperty, heightAnimation2);
                        uxNumber2Points.BeginAnimation(Label.HeightProperty, heightAnimation2);
                        uxNumber2Answer.Content = game.number2;
                        uxNumber2Points.Content = game.num2;
                        if (game.questionNumber == 1 || game.questionNumber == 2)
                        {
                            game.roundPoints += game.num2;
                        }
                        else if (game.questionNumber == 3 || game.questionNumber == 4)
                        {
                            game.roundPoints += (game.num2 * 2);
                        }
                        else if (game.questionNumber == 5)
                        {
                            game.roundPoints += (game.num2 * 3);
                        }
                        clang.Play();
                        DoubleAnimation heightAnimation1 = new DoubleAnimation(98, 0, TimeSpan.FromMilliseconds(100));
                        heightAnimation1.AutoReverse = true;
                        uxScore.BeginAnimation(Label.WidthProperty, heightAnimation1);
                        uxScore.Content = game.roundPoints;
                        game.answersLeft--;
                        uxInfo.Text = "That's the #2 Answer! " + game.answersLeft + " answers left to reveal.";
                    }
                }
                else if (string.Equals(uxInput.Text, game.number3, StringComparison.CurrentCultureIgnoreCase))
                {
                    foreach (string s in answersAlreadyUsed)
                    {
                        if (uxInput.Text == s)
                        {
                            isAlreadyUsed = true;
                        }
                    }
                    if (isAlreadyUsed == true) strike();
                    else
                    {
                        answersAlreadyUsed.Add(uxInput.Text);
                        DoubleAnimation heightAnimation3 = new DoubleAnimation(77, 0, TimeSpan.FromMilliseconds(100));
                        heightAnimation3.AutoReverse = true;
                        uxNumber3Answer.BeginAnimation(Label.HeightProperty, heightAnimation3);
                        uxNumber3Points.BeginAnimation(Label.HeightProperty, heightAnimation3);
                        uxNumber3Answer.Content = game.number3;
                        uxNumber3Points.Content = game.num3;
                        if (game.questionNumber == 1 || game.questionNumber == 2)
                        {
                            game.roundPoints += game.num3;
                        }
                        else if (game.questionNumber == 3 || game.questionNumber == 4)
                        {
                            game.roundPoints += (game.num3 * 2);
                        }
                        else if (game.questionNumber == 5)
                        {
                            game.roundPoints += (game.num3 * 3);
                        }
                        clang.Play();
                        DoubleAnimation heightAnimation1 = new DoubleAnimation(98, 0, TimeSpan.FromMilliseconds(100));
                        heightAnimation1.AutoReverse = true;
                        uxScore.BeginAnimation(Label.WidthProperty, heightAnimation1);
                        uxScore.Content = game.roundPoints;
                        game.answersLeft--;
                        uxInfo.Text = "That's on the board! " + game.answersLeft + " answers left to reveal.";
                    }
                }
                else if (string.Equals(uxInput.Text, game.number4, StringComparison.CurrentCultureIgnoreCase))
                {
                    foreach (string s in answersAlreadyUsed)
                    {
                        if (uxInput.Text == s)
                        {
                            isAlreadyUsed = true;
                        }
                    }
                    if (isAlreadyUsed == true) strike();
                    else
                    {
                        answersAlreadyUsed.Add(uxInput.Text);
                        DoubleAnimation heightAnimation4 = new DoubleAnimation(77, 0, TimeSpan.FromMilliseconds(100));
                        heightAnimation4.AutoReverse = true;
                        uxNumber4Answer.BeginAnimation(Label.HeightProperty, heightAnimation4);
                        uxNumber4Points.BeginAnimation(Label.HeightProperty, heightAnimation4);
                        uxNumber4Answer.Content = game.number4;
                        uxNumber4Points.Content = game.num4;
                        if (game.questionNumber == 1 || game.questionNumber == 2)
                        {
                            game.roundPoints += game.num4;
                        }
                        else if (game.questionNumber == 3 || game.questionNumber == 4)
                        {
                            game.roundPoints += (game.num4 * 2);
                        }
                        else if (game.questionNumber == 5)
                        {
                            game.roundPoints += (game.num4 * 3);
                        }
                        clang.Play();
                        DoubleAnimation heightAnimation1 = new DoubleAnimation(98, 0, TimeSpan.FromMilliseconds(100));
                        heightAnimation1.AutoReverse = true;
                        uxScore.BeginAnimation(Label.WidthProperty, heightAnimation1);
                        uxScore.Content = game.roundPoints;
                        game.answersLeft--;
                        uxInfo.Text = "That's on the board! " + game.answersLeft + " answers left to reveal.";
                    }
                }
                else if (string.Equals(uxInput.Text, game.number5, StringComparison.CurrentCultureIgnoreCase))
                {
                    foreach (string s in answersAlreadyUsed)
                    {
                        if (uxInput.Text == s)
                        {
                            isAlreadyUsed = true;
                        }
                    }
                    if (isAlreadyUsed == true) strike();
                    else
                    {
                        answersAlreadyUsed.Add(uxInput.Text);
                        DoubleAnimation heightAnimation5 = new DoubleAnimation(77, 0, TimeSpan.FromMilliseconds(100));
                        heightAnimation5.AutoReverse = true;
                        uxNumber5Answer.BeginAnimation(Label.HeightProperty, heightAnimation5);
                        uxNumber5Points.BeginAnimation(Label.HeightProperty, heightAnimation5);
                        uxNumber5Answer.Content = game.number5;
                        uxNumber5Points.Content = game.num5;
                        if (game.questionNumber == 1 || game.questionNumber == 2)
                        {
                            game.roundPoints += game.num5;
                        }
                        else if (game.questionNumber == 3 || game.questionNumber == 4)
                        {
                            game.roundPoints += (game.num5 * 2);
                        }
                        else if (game.questionNumber == 5)
                        {
                            game.roundPoints += (game.num5 * 3);
                        }
                        clang.Play();
                        DoubleAnimation heightAnimation1 = new DoubleAnimation(98, 0, TimeSpan.FromMilliseconds(100));
                        heightAnimation1.AutoReverse = true;
                        uxScore.BeginAnimation(Label.WidthProperty, heightAnimation1);
                        uxScore.Content = game.roundPoints;
                        game.answersLeft--;
                        uxInfo.Text = "That's on the board! " + game.answersLeft + " answers left to reveal.";
                    }
                }
                else if (string.Equals(uxInput.Text, game.number6, StringComparison.CurrentCultureIgnoreCase))
                {
                    foreach (string s in answersAlreadyUsed)
                    {
                        if (uxInput.Text == s)
                        {
                            isAlreadyUsed = true;
                        }
                    }
                    if (isAlreadyUsed == true) strike();
                    else
                    {
                        answersAlreadyUsed.Add(uxInput.Text);
                        DoubleAnimation heightAnimation6 = new DoubleAnimation(77, 0, TimeSpan.FromMilliseconds(100));
                        heightAnimation6.AutoReverse = true;
                        uxNumber6Answer.BeginAnimation(Label.HeightProperty, heightAnimation6);
                        uxNumber6Points.BeginAnimation(Label.HeightProperty, heightAnimation6);
                        uxNumber6Answer.Content = game.number6;
                        uxNumber6Points.Content = game.num6;
                        if (game.questionNumber == 1 || game.questionNumber == 2)
                        {
                            game.roundPoints += game.num6;
                        }
                        else if (game.questionNumber == 3 || game.questionNumber == 4)
                        {
                            game.roundPoints += (game.num6 * 2);
                        }
                        clang.Play();
                        DoubleAnimation heightAnimation1 = new DoubleAnimation(98, 0, TimeSpan.FromMilliseconds(100));
                        heightAnimation1.AutoReverse = true;
                        uxScore.BeginAnimation(Label.WidthProperty, heightAnimation1);
                        uxScore.Content = game.roundPoints;
                        game.answersLeft--;
                        uxInfo.Text = "That's on the board! " + game.answersLeft + " answers left to reveal.";
                    }
                }
                else if (string.Equals(uxInput.Text, game.number7, StringComparison.CurrentCultureIgnoreCase))
                {
                    foreach (string s in answersAlreadyUsed)
                    {
                        if (uxInput.Text == s)
                        {
                            isAlreadyUsed = true;
                        }
                    }
                    if (isAlreadyUsed == true) strike();
                    else
                    {
                        answersAlreadyUsed.Add(uxInput.Text);
                        DoubleAnimation heightAnimation7 = new DoubleAnimation(77, 0, TimeSpan.FromMilliseconds(100));
                        heightAnimation7.AutoReverse = true;
                        uxNumber7Answer.BeginAnimation(Label.HeightProperty, heightAnimation7);
                        uxNumber7Points.BeginAnimation(Label.HeightProperty, heightAnimation7);
                        uxNumber7Answer.Content = game.number7;
                        uxNumber7Points.Content = game.num7;
                        if (game.questionNumber == 1 || game.questionNumber == 2)
                        {
                            game.roundPoints += game.num7;
                        }
                        else if (game.questionNumber == 3 || game.questionNumber == 4)
                        {
                            game.roundPoints += (game.num7 * 2);
                        }
                        clang.Play();
                        DoubleAnimation heightAnimation1 = new DoubleAnimation(98, 0, TimeSpan.FromMilliseconds(100));
                        heightAnimation1.AutoReverse = true;
                        uxScore.BeginAnimation(Label.WidthProperty, heightAnimation1);
                        uxScore.Content = game.roundPoints;
                        game.answersLeft--;
                        uxInfo.Text = "That's on the board! " + game.answersLeft + " answers left to reveal.";
                    }
                }
                else if (string.Equals(uxInput.Text, game.number8, StringComparison.CurrentCultureIgnoreCase))
                {
                    foreach (string s in answersAlreadyUsed)
                    {
                        if (uxInput.Text == s)
                        {
                            isAlreadyUsed = true;
                        }
                    }
                    if (isAlreadyUsed == true) strike();
                    else
                    {
                        answersAlreadyUsed.Add(uxInput.Text);
                        DoubleAnimation heightAnimation8 = new DoubleAnimation(77, 0, TimeSpan.FromMilliseconds(100));
                        heightAnimation8.AutoReverse = true;
                        uxNumber8Answer.BeginAnimation(Label.HeightProperty, heightAnimation8);
                        uxNumber8Points.BeginAnimation(Label.HeightProperty, heightAnimation8);
                        uxNumber8Answer.Content = game.number8;
                        uxNumber8Points.Content = game.num8;
                        if (game.questionNumber == 1 || game.questionNumber == 2)
                        {
                            game.roundPoints += game.num8;
                        }
                        else if (game.questionNumber == 3 || game.questionNumber == 4)
                        {
                            game.roundPoints += (game.num8 * 2);
                        }
                        clang.Play();
                        DoubleAnimation heightAnimation1 = new DoubleAnimation(98, 0, TimeSpan.FromMilliseconds(100));
                        heightAnimation1.AutoReverse = true;
                        uxScore.BeginAnimation(Label.WidthProperty, heightAnimation1);
                        uxScore.Content = game.roundPoints;
                        game.answersLeft--;
                        uxInfo.Text = "That's on the board! " + game.answersLeft + " answers left to reveal.";
                    }
                }
                else if (string.Equals(uxInput.Text, game.number9, StringComparison.CurrentCultureIgnoreCase))
                {
                    foreach (string s in answersAlreadyUsed)
                    {
                        if (uxInput.Text == s)
                        {
                            isAlreadyUsed = true;
                        }
                    }
                    if (isAlreadyUsed == true) strike();
                    else
                    {
                        answersAlreadyUsed.Add(uxInput.Text);
                        DoubleAnimation heightAnimation9 = new DoubleAnimation(77, 0, TimeSpan.FromMilliseconds(100));
                        heightAnimation9.AutoReverse = true;
                        uxNumber9Answer.BeginAnimation(Label.HeightProperty, heightAnimation9);
                        uxNumber9Points.BeginAnimation(Label.HeightProperty, heightAnimation9);
                        uxNumber9Answer.Content = game.number9;
                        uxNumber9Points.Content = game.num9;
                        game.roundPoints += game.num9;
                        clang.Play();
                        DoubleAnimation heightAnimation1 = new DoubleAnimation(98, 0, TimeSpan.FromMilliseconds(100));
                        heightAnimation1.AutoReverse = true;
                        uxScore.BeginAnimation(Label.WidthProperty, heightAnimation1);
                        uxScore.Content = game.roundPoints;
                        game.answersLeft--;
                        uxInfo.Text = "That's on the board! " + game.answersLeft + " answers left to reveal.";
                    }
                }
                else
                {
                    strike();
                }
                if (game.answersLeft == 0)
                {
                    uxInfo.Text = "You swept the board! Let's move on to the next question.";
                    _timer.Stop();
                    fastmoneydings.Play();
                    uxInput.IsEnabled = false;
                    uxCheck.IsEnabled = false;
                }
                uxInput.Text = "";
                uxCheck.IsEnabled = false;
            }
            else if (game.questionNumber == 6)
            {
                bw.DoWork += new DoWorkEventHandler(delegate(object o, DoWorkEventArgs args)
                {
                    BackgroundWorker b = o as BackgroundWorker;
                    game.fastMoney(fastMoney);
                    b.ReportProgress(1);
                    Thread.Sleep(1000);
                    b.ReportProgress(10);
                    Thread.Sleep(3000);
                    b.ReportProgress(20);
                    Thread.Sleep(3000);
                    b.ReportProgress(30);
                    Thread.Sleep(3000);
                    b.ReportProgress(40);
                    Thread.Sleep(3000);
                    b.ReportProgress(50);
                    Thread.Sleep(3000);
                    b.ReportProgress(60);
                    Thread.Sleep(3000);
                    b.ReportProgress(70);
                    Thread.Sleep(3000);
                    b.ReportProgress(80);
                    Thread.Sleep(3000);
                    b.ReportProgress(90);
                    Thread.Sleep(3000);
                    b.ReportProgress(100);
                });
                bw.ProgressChanged += new ProgressChangedEventHandler(delegate(object o, ProgressChangedEventArgs args)
                {
                    if (args.ProgressPercentage == 1)
                    {
                        uxTotalScore.Content = game.perfectGame;
                        uxLabel1.Content = "FAMILY FEUD!";
                    }
                    else if (args.ProgressPercentage == 10)
                    {
                        uxQuestion.Text = fastMoneyQuestions[0];
                        uxNumber1Answer.Content = fastMoney[0];
                        blip.Play();
                    }
                    else if (args.ProgressPercentage == 20)
                    {
                        uxQuestion.Text = "Survey Says... " + game.num1.ToString();
                        if (game.num1Color == 1)
                        {
                            uxNumber1Points.Foreground = System.Windows.Media.Brushes.LimeGreen;
                        }
                        else if (game.num1Color == 2)
                        {
                            uxNumber1Points.Foreground = System.Windows.Media.Brushes.Yellow;
                        }
                        else if (game.num1Color == 0)
                        {
                            uxNumber1Points.Foreground = System.Windows.Media.Brushes.Red;
                        }
                        else uxNumber1Points.Foreground = System.Windows.Media.Brushes.Black;
                        uxNumber1Points.Content = game.num1;
                        game.roundPoints += game.num1;
                        uxScore.Content = game.roundPoints;
                        if (game.num1 > 0) bell.Play();
                        else zero.Play();
                    }
                    else if (args.ProgressPercentage == 30)
                    {
                        uxQuestion.Text = fastMoneyQuestions[1];
                        uxNumber2Answer.Content = fastMoney[1];
                        blip.Play();
                    }
                    else if (args.ProgressPercentage == 40)
                    {
                        uxQuestion.Text = "Survey Says... " + game.num2.ToString();
                        if (game.num2Color == 1)
                        {
                            uxNumber2Points.Foreground = System.Windows.Media.Brushes.LimeGreen;
                        }
                        else if (game.num2Color == 2)
                        {
                            uxNumber2Points.Foreground = System.Windows.Media.Brushes.Yellow;
                        }
                        else if (game.num2Color == 0)
                        {
                            uxNumber2Points.Foreground = System.Windows.Media.Brushes.Red;
                        }
                        else uxNumber2Points.Foreground = System.Windows.Media.Brushes.Black;
                        uxNumber2Points.Content = game.num2;
                        game.roundPoints += game.num2;
                        uxScore.Content = game.roundPoints;
                        if (game.num2 > 0) bell.Play();
                        else zero.Play();
                    }
                    else if (args.ProgressPercentage == 50)
                    {
                        uxQuestion.Text = fastMoneyQuestions[2];
                        uxNumber3Answer.Content = fastMoney[2];
                        blip.Play();
                    }
                    else if (args.ProgressPercentage == 60)
                    {
                        uxQuestion.Text = "Survey Says... " + game.num3.ToString();
                        if (game.num3Color == 1)
                        {
                            uxNumber3Points.Foreground = System.Windows.Media.Brushes.LimeGreen;
                        }
                        else if (game.num3Color == 2)
                        {
                            uxNumber3Points.Foreground = System.Windows.Media.Brushes.Yellow;
                        }
                        else if (game.num3Color == 0)
                        {
                            uxNumber3Points.Foreground = System.Windows.Media.Brushes.Red;
                        }
                        else uxNumber3Points.Foreground = System.Windows.Media.Brushes.Black;
                        uxNumber3Points.Content = game.num3;
                        game.roundPoints += game.num3;
                        uxScore.Content = game.roundPoints;
                        if (game.num3 > 0) bell.Play();
                        else zero.Play();
                    }
                    else if (args.ProgressPercentage == 70)
                    {
                        uxQuestion.Text = fastMoneyQuestions[3];
                        uxNumber4Answer.Content = fastMoney[3];
                        blip.Play();
                    }
                    else if (args.ProgressPercentage == 80)
                    {
                        uxQuestion.Text = "Survey Says... " + game.num4.ToString();
                        if (game.num4Color == 1)
                        {
                            uxNumber4Points.Foreground = System.Windows.Media.Brushes.LimeGreen;
                        }
                        else if (game.num4Color == 2)
                        {
                            uxNumber4Points.Foreground = System.Windows.Media.Brushes.Yellow;
                        }
                        else if (game.num4Color == 0)
                        {
                            uxNumber4Points.Foreground = System.Windows.Media.Brushes.Red;
                        }
                        else uxNumber4Points.Foreground = System.Windows.Media.Brushes.Black;
                        uxNumber4Points.Content = game.num4;
                        game.roundPoints += game.num4;
                        uxScore.Content = game.roundPoints;
                        if (game.num4 > 0) bell.Play();
                        else zero.Play();
                    }
                    else if (args.ProgressPercentage == 90)
                    {
                        uxQuestion.Text = fastMoneyQuestions[4];
                        uxNumber5Answer.Content = fastMoney[4];
                        blip.Play();
                    }
                });
                bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(delegate(object o, RunWorkerCompletedEventArgs args)
                {
                    uxQuestion.Text = "Survey Says... " + game.num5.ToString();
                    if (game.num5Color == 1)
                    {
                        uxNumber5Points.Foreground = System.Windows.Media.Brushes.LimeGreen;
                    }
                    else if (game.num5Color == 2)
                    {
                        uxNumber5Points.Foreground = System.Windows.Media.Brushes.Yellow;
                    }
                    else if (game.num5Color == 0)
                    {
                        uxNumber5Points.Foreground = System.Windows.Media.Brushes.Red;
                    }
                    else uxNumber5Points.Foreground = System.Windows.Media.Brushes.Black;
                    uxNumber5Points.Content = game.num5;
                    game.roundPoints += game.num5;
                    uxScore.Content = game.roundPoints;
                    if (game.num5 > 0) bell.Play();
                    else zero.Play();
                    game.questionNumber++;
                    uxInfo.Text = "Maingame: $" + game.totalPoints + "             You need " + (200 - game.roundPoints) + " points to win $20,000. Push CTRL to start the second half.";
                    uxInput.IsEnabled = true;
                });
                bw.RunWorkerAsync();
            }
            else if (game.questionNumber == 7)
            {
                bw.DoWork += new DoWorkEventHandler(delegate(object o, DoWorkEventArgs args)
                {
                    BackgroundWorker b2 = o as BackgroundWorker;
                    game.resetForFastMoney2();
                    game.fastMoney(fastMoney);
                    b2.ReportProgress(1);
                    Thread.Sleep(1000);
                    b2.ReportProgress(10);
                    Thread.Sleep(3000);
                    b2.ReportProgress(20);
                    Thread.Sleep(3000);
                    b2.ReportProgress(30);
                    Thread.Sleep(3000);
                    b2.ReportProgress(40);
                    Thread.Sleep(3000);
                    b2.ReportProgress(50);
                    Thread.Sleep(3000);
                    b2.ReportProgress(60);
                    Thread.Sleep(3000);
                    b2.ReportProgress(70);
                    Thread.Sleep(3000);
                    b2.ReportProgress(80);
                    Thread.Sleep(3000);
                    b2.ReportProgress(90);
                    Thread.Sleep(3000);
                    b2.ReportProgress(99);
                    Thread.Sleep(3000);
                    b2.ReportProgress(100);
                });
                bw.ProgressChanged += new ProgressChangedEventHandler(delegate(object o, ProgressChangedEventArgs args)
                {
                    if (args.ProgressPercentage == 1)
                    {
                        uxTotalScore.Content = game.perfectGame;
                        uxLabel1.Content = "FAMILY FEUD!";
                        uxInfo.Text = "Maingame: $" + game.totalPoints + "                                 You need " + (200 - game.roundPoints) + " points to win $20,000.";
                    }
                    else if (args.ProgressPercentage == 10)
                    {
                        uxQuestion.Text = fastMoneyQuestions[0];
                        uxNumber6Answer.Content = fastMoney[0];
                        blip.Play();
                    }
                    else if (args.ProgressPercentage == 20)
                    {
                        uxQuestion.Text = "Survey Says... " + game.num1.ToString();
                        if (game.num1Color == 1)
                        {
                            uxNumber6Points.Foreground = System.Windows.Media.Brushes.LimeGreen;
                        }
                        else if (game.num1Color == 2)
                        {
                            uxNumber6Points.Foreground = System.Windows.Media.Brushes.Yellow;
                        }
                        else if (game.num1Color == 0)
                        {
                            uxNumber6Points.Foreground = System.Windows.Media.Brushes.Red;
                        }
                        else uxNumber6Points.Foreground = System.Windows.Media.Brushes.Black;
                        foreach (string s in answersAlreadyUsed)
                        {
                            if (fastMoney[0] == s)
                            {
                                uxNumber6Points.Content = 0;
                                //uxNumber6Points.Foreground = System.Windows.Media.Brushes.Red;
                            }
                        }
                        uxNumber6Points.Content = game.num1;
                        game.roundPoints += game.num1;
                        uxScore.Content = game.roundPoints;
                        if (game.num1 > 0) bell.Play();
                        else zero.Play();
                    }
                    else if (args.ProgressPercentage == 30)
                    {
                        uxQuestion.Text = fastMoneyQuestions[1];
                        uxNumber7Answer.Content = fastMoney[1];
                        blip.Play();
                    }
                    else if (args.ProgressPercentage == 40)
                    {
                        uxQuestion.Text = "Survey Says... " + game.num2.ToString();
                        if (game.num2Color == 1)
                        {
                            uxNumber7Points.Foreground = System.Windows.Media.Brushes.LimeGreen;
                        }
                        else if (game.num2Color == 2)
                        {
                            uxNumber7Points.Foreground = System.Windows.Media.Brushes.Yellow;
                        }
                        else if (game.num2Color == 0)
                        {
                            uxNumber7Points.Foreground = System.Windows.Media.Brushes.Red;
                        }
                        else uxNumber7Points.Foreground = System.Windows.Media.Brushes.Black;
                        foreach (string s in answersAlreadyUsed)
                        {
                            if (fastMoney[1] == s)
                            {
                                uxNumber7Points.Content = 0;
                                //uxNumber7Points.Foreground = System.Windows.Media.Brushes.Red;
                            }
                        }
                        uxNumber7Points.Content = game.num2;
                        game.roundPoints += game.num2;
                        uxScore.Content = game.roundPoints.ToString();
                        if (game.num2 > 0) bell.Play();
                        else zero.Play();
                    }
                    else if (args.ProgressPercentage == 50)
                    {
                        uxQuestion.Text = fastMoneyQuestions[2];
                        uxNumber8Answer.Content = fastMoney[2];
                        blip.Play();
                    }
                    else if (args.ProgressPercentage == 60)
                    {
                        uxQuestion.Text = "Survey Says... " + game.num3.ToString();
                        if (game.num3Color == 1)
                        {
                            uxNumber8Points.Foreground = System.Windows.Media.Brushes.LimeGreen;
                        }
                        else if (game.num3Color == 2)
                        {
                            uxNumber8Points.Foreground = System.Windows.Media.Brushes.Yellow;
                        }
                        else if (game.num3Color == 0)
                        {
                            uxNumber8Points.Foreground = System.Windows.Media.Brushes.Red;
                        }
                        else uxNumber8Points.Foreground = System.Windows.Media.Brushes.Black;
                        foreach (string s in answersAlreadyUsed)
                        {
                            if (fastMoney[2] == s)
                            {
                                uxNumber8Points.Content = 0;
                                //uxNumber8Points.Foreground = System.Windows.Media.Brushes.Red;
                            }
                        }
                        uxNumber8Points.Content = game.num3;
                        game.roundPoints += game.num3;
                        uxScore.Content = game.roundPoints;
                        if (game.num3 > 0) bell.Play();
                        else zero.Play();
                    }
                    else if (args.ProgressPercentage == 70)
                    {
                        uxQuestion.Text = fastMoneyQuestions[3];
                        uxNumber9Answer.Content = fastMoney[3];
                        blip.Play();
                    }
                    else if (args.ProgressPercentage == 80)
                    {
                        uxQuestion.Text = "Survey Says... " + game.num4.ToString();
                        if (game.num4Color == 1)
                        {
                            uxNumber9Points.Foreground = System.Windows.Media.Brushes.LimeGreen;
                        }
                        else if (game.num4Color == 2)
                        {
                            uxNumber9Points.Foreground = System.Windows.Media.Brushes.Yellow;
                        }
                        else if (game.num4Color == 0)
                        {
                            uxNumber9Points.Foreground = System.Windows.Media.Brushes.Red;
                        }
                        else uxNumber9Points.Foreground = System.Windows.Media.Brushes.Black;
                        foreach (string s in answersAlreadyUsed)
                        {
                            if (fastMoney[3] == s)
                            {
                                uxNumber9Points.Content = 0;
                                //uxNumber9Points.Foreground = System.Windows.Media.Brushes.Red;
                            }
                        }
                        uxNumber9Points.Content = game.num4;
                        game.roundPoints += game.num4;
                        uxScore.Content = game.roundPoints;
                        if (game.num4 > 0) bell.Play();
                        else zero.Play();
                    }
                    else if (args.ProgressPercentage == 90)
                    {
                        uxStrikes.Foreground = System.Windows.Media.Brushes.White;
                        uxStrikes.Content = fastMoney[4];
                        uxQuestion.Text = fastMoneyQuestions[4];
                        uxStrikes.Content = fastMoney[4];
                        blip.Play();
                    }
                    else if (args.ProgressPercentage == 99)
                    {
                        uxUpdate.Foreground = System.Windows.Media.Brushes.Black;
                        uxQuestion.Text = "Survey Says... " + game.num5.ToString();
                        if (game.num5Color == 1)
                        {
                            uxUpdate.Foreground = System.Windows.Media.Brushes.LimeGreen;
                        }
                        else if (game.num5Color == 2)
                        {
                            uxUpdate.Foreground = System.Windows.Media.Brushes.Yellow;
                        }
                        else if (game.num5Color == 0)
                        {
                            uxUpdate.Foreground = System.Windows.Media.Brushes.Red;
                        }
                        else uxUpdate.Foreground = System.Windows.Media.Brushes.Black;
                        foreach (string s in answersAlreadyUsed)
                        {
                            if (fastMoney[4] == s)
                            {
                                uxUpdate.Content = 0;
                                //uxUpdate.Foreground = System.Windows.Media.Brushes.Red;
                            }
                        }
                        uxUpdate.Content = game.num5.ToString();
                        game.roundPoints += game.num5;
                        uxScore.Content = game.roundPoints.ToString();
                        if (game.roundPoints >= 200) fastmoneywin.Play();
                        else
                        {
                            if (game.num5 > 0) bell.Play();
                            else zero.Play();
                        }
                    }
                });
                bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(delegate(object o, RunWorkerCompletedEventArgs args)
                {
                    if (game.roundPoints == game.perfectGame)
                    {
                        uxInfo.Text = "Maingame: $" + game.totalPoints + ": Fast Money: $1,000,000: Total Winnings: $" + (1000000 + game.totalPoints) + "!!";
                        game.totalPoints += 1000000;
                    }
                    else if (game.roundPoints < game.perfectGame && game.roundPoints >= 200)
                    {
                        uxInfo.Text = "Maingame: $" + game.totalPoints + ": Fast Money: $20,000: Total Winnings: $" + (20000 + game.totalPoints) + "!!";
                        game.totalPoints += 20000;
                    }
                    else if (game.roundPoints >= 100 && game.roundPoints < 200)
                    {
                        uxInfo.Text = "Maingame: $" + game.totalPoints + ": Fast Money: $" + (game.roundPoints * 10) + ": Total Winnings: $" + ((game.roundPoints * 10) + game.totalPoints) + "!!";
                        game.totalPoints += (game.roundPoints * 10);
                    }
                    else
                    {
                        uxInfo.Text = "Maingame: $" + game.totalPoints + ": Fast Money: $" + (game.roundPoints * 5) + ": Total Winnings: $" + ((game.roundPoints * 5) + game.totalPoints) + "!!";
                        game.totalPoints += (game.roundPoints * 5);
                    }
                    uxCheck.IsEnabled = false;
                    postgame();
                    if (game.roundPoints < 200) theme.PlayLooping();
                });
                bw.RunWorkerAsync();
            }
        }
        public void reset()
        {
            uxNumber4Answer.Visibility = Visibility.Visible;
            uxNumber4Points.Visibility = Visibility.Visible;
            uxNumber5Answer.Visibility = Visibility.Visible;
            uxNumber5Points.Visibility = Visibility.Visible;
            uxNumber6Answer.Visibility = Visibility.Visible;
            uxNumber6Points.Visibility = Visibility.Visible;
            uxNumber7Answer.Visibility = Visibility.Visible;
            uxNumber7Points.Visibility = Visibility.Visible;
            uxNumber8Answer.Visibility = Visibility.Visible;
            uxNumber8Points.Visibility = Visibility.Visible;
            uxNumber9Answer.Visibility = Visibility.Visible;
            uxNumber9Points.Visibility = Visibility.Visible;
            game.strikeNumber = 0;
            uxScore.Content = "0";
            uxNumber1Answer.Content = "#1";
            uxNumber1Points.Content = "";
            uxNumber2Answer.Content = "#2";
            uxNumber2Points.Content = "";
            uxNumber3Answer.Content = "#3";
            uxNumber3Points.Content = "";
            uxNumber4Answer.Content = "#4";
            uxNumber4Points.Content = "";
            uxNumber5Answer.Content = "#5";
            uxNumber5Points.Content = "";
            uxNumber6Answer.Content = "#6";
            uxNumber6Points.Content = "";
            uxNumber7Answer.Content = "#7";
            uxNumber7Points.Content = "";
            uxNumber8Answer.Content = "#8";
            uxNumber8Points.Content = "";
            uxNumber9Answer.Content = "#9";
            uxNumber9Points.Content = "";
        }
        public void fastMoneySetup()
        {
            reset();
            uxScore.Content = "0";
            uxCheck.Content = "Submit";
            uxQuestionAndPoints.Content = "Fast Money!      Perfect Game:";
            this.Background = System.Windows.Media.Brushes.Black;
            uxInfo.Background = System.Windows.Media.Brushes.Black;
            uxInfo.Foreground = System.Windows.Media.Brushes.Violet;
            uxNumber1Answer.Content = "";
            uxNumber1Answer.Background = System.Windows.Media.Brushes.DarkBlue;
            uxNumber1Points.Content = "";
            uxNumber1Points.Background = System.Windows.Media.Brushes.DodgerBlue;
            uxNumber2Answer.Content = "";
            uxNumber2Answer.Background = System.Windows.Media.Brushes.DarkBlue;
            uxNumber2Points.Content = "";
            uxNumber2Points.Background = System.Windows.Media.Brushes.DodgerBlue;
            uxNumber3Answer.Content = "";
            uxNumber3Points.Content = "";
            uxNumber4Answer.Content = "";
            uxNumber4Points.Content = "";
            uxNumber5Answer.Content = "";
            uxNumber5Points.Content = "";
            uxNumber6Answer.Content = "";
            uxNumber6Points.Content = "";
            uxNumber7Answer.Content = "";
            uxNumber7Points.Content = "";
            uxNumber8Answer.Content = "";
            uxNumber8Points.Content = "";
            uxNumber9Answer.Content = "";
            uxNumber9Points.Content = "";
            uxStrikes.Content = "";
            uxStrikes.Background = System.Windows.Media.Brushes.DarkBlue;
            uxStrikes.FontFamily = new FontFamily("Segoe UI");
            uxStrikes.FontWeight = FontWeights.Bold;
            uxUpdate.Content = "";
            uxUpdate.FontFamily = new FontFamily("Segoe UI");
            uxUpdate.FontWeight = FontWeights.Bold;
            uxUpdate.FontSize = 48;
            uxUpdate.Background = System.Windows.Media.Brushes.DodgerBlue;
            uxStrikes.Foreground = System.Windows.Media.Brushes.White;
        }
        private void threeStrikes()
        {
            uxInput.IsEnabled = false;
            uxCheck.IsEnabled = false;
            answersAlreadyUsed.Clear();
        }
        private void atNextQuestion()
        {
            uxInput.Text = "";
            uxInput.IsEnabled = true;
            uxCheck.IsEnabled = true;
        }

        private void uxUpdate_Click_1(object sender, RoutedEventArgs e)
        {
            if (game.questionNumber < 6)
            {
                game.questionNumber++;
                time = 30;
                _timer.Start();
                uxLabel1.Content = time.ToString();
            }
            if (game.questionNumber == 6)
            {
                time = 35;
                uxLabel1.Content = time.ToString();
                _timer.Stop();
            }
            if (game.questionNumber == 1) //Top 8 Answers in Game 1
            {
                game.question1();
                uxInfo.Text = "Here's the first question. Top " + game.answersLeft + " answers on the board.";
                if (game.number5 == null)
                {
                    uxNumber5Answer.Visibility = Visibility.Hidden;
                    uxNumber5Points.Visibility = Visibility.Hidden;
                }
                if (game.number6 == null)
                {
                    uxNumber6Answer.Visibility = Visibility.Hidden;
                    uxNumber6Points.Visibility = Visibility.Hidden;
                }
                if (game.number7 == null)
                {
                    uxNumber7Answer.Visibility = Visibility.Hidden;
                    uxNumber7Points.Visibility = Visibility.Hidden;
                }
                if (game.number8 == null)
                {
                    uxNumber8Answer.Visibility = Visibility.Hidden;
                    uxNumber8Points.Visibility = Visibility.Hidden;
                }
                if (game.number9 == null)
                {
                    uxNumber9Answer.Visibility = Visibility.Hidden;
                    uxNumber9Points.Visibility = Visibility.Hidden;
                }
                uxQuestion.Text = game.question;
                uxStrikes.Content = "";
                uxUpdate.Content = "Rd. 2"; //to update next question
            }
            else if (game.questionNumber == 2)
            {
                reset();
                atNextQuestion();
                game.question2();
                question2.Play();
                uxInfo.Text = "This is the second question. Top " + game.answersLeft + " answers on the board.";
                game.totalPoints += game.roundPoints;
                uxTotalScore.Content = game.totalPoints.ToString();
                game.roundPoints = 0;
                uxScore.Content = "0";
                if (game.number5 == null)
                {
                    uxNumber5Answer.Visibility = Visibility.Hidden;
                    uxNumber5Points.Visibility = Visibility.Hidden;
                }
                if (game.number6 == null)
                {
                    uxNumber6Answer.Visibility = Visibility.Hidden;
                    uxNumber6Points.Visibility = Visibility.Hidden;
                }
                if (game.number7 == null)
                {
                    uxNumber7Answer.Visibility = Visibility.Hidden;
                    uxNumber7Points.Visibility = Visibility.Hidden;
                }
                if (game.number8 == null)
                {
                    uxNumber8Answer.Visibility = Visibility.Hidden;
                    uxNumber8Points.Visibility = Visibility.Hidden;
                }
                if (game.number9 == null)
                {
                    uxNumber9Answer.Visibility = Visibility.Hidden;
                    uxNumber9Points.Visibility = Visibility.Hidden;
                }
                uxQuestion.Text = game.question;
                uxStrikes.Content = "";
                uxUpdate.Content = "Rd. 3"; //to update next question
                uxQuestionAndPoints.Content = "Question 2           Total Points:";
            }
            else if (game.questionNumber == 3)
            {
                reset();
                atNextQuestion();
                game.question3();
                question3.Play();
                uxInfo.Text = "This is the third question, point values are doubled. Top " + game.answersLeft + " answers on the board.";
                game.totalPoints += game.roundPoints;
                uxTotalScore.Content = game.totalPoints.ToString();
                game.roundPoints = 0;
                uxScore.Content = "0";
                if (game.number5 == null)
                {
                    uxNumber5Answer.Visibility = Visibility.Hidden;
                    uxNumber5Points.Visibility = Visibility.Hidden;
                }
                if (game.number6 == null)
                {
                    uxNumber6Answer.Visibility = Visibility.Hidden;
                    uxNumber6Points.Visibility = Visibility.Hidden;
                }
                if (game.number7 == null)
                {
                    uxNumber7Answer.Visibility = Visibility.Hidden;
                    uxNumber7Points.Visibility = Visibility.Hidden;
                }
                if (game.number8 == null)
                {
                    uxNumber8Answer.Visibility = Visibility.Hidden;
                    uxNumber8Points.Visibility = Visibility.Hidden;
                }
                uxNumber9Answer.Visibility = Visibility.Hidden; //Maximum 8 Answers in Double Points surveys
                uxNumber9Points.Visibility = Visibility.Hidden; //Maximum 8 Answers in Double Points surveys
                uxQuestion.Text = game.question;
                uxStrikes.Content = "";
                uxUpdate.Content = "Rd. 4"; //to update next question
                uxQuestionAndPoints.Content = "Question 3           Total Points:";
                this.Background = System.Windows.Media.Brushes.Yellow;
                uxInfo.Background = System.Windows.Media.Brushes.Yellow;
            }
            else if (game.questionNumber == 4)
            {
                reset();
                atNextQuestion();
                game.question4();
                question4.Play();
                uxInfo.Text = "Here's the fourth question, point values are doubled. Top " + game.answersLeft + " answers on the board.";
                game.totalPoints += game.roundPoints;
                uxTotalScore.Content = game.totalPoints.ToString();
                game.roundPoints = 0;
                uxScore.Content = "0";
                if (game.number5 == null)
                {
                    uxNumber5Answer.Visibility = Visibility.Hidden;
                    uxNumber5Points.Visibility = Visibility.Hidden;
                }
                if (game.number6 == null)
                {
                    uxNumber6Answer.Visibility = Visibility.Hidden;
                    uxNumber6Points.Visibility = Visibility.Hidden;
                }
                if (game.number7 == null)
                {
                    uxNumber7Answer.Visibility = Visibility.Hidden;
                    uxNumber7Points.Visibility = Visibility.Hidden;
                }
                if (game.number8 == null)
                {
                    uxNumber8Answer.Visibility = Visibility.Hidden;
                    uxNumber8Points.Visibility = Visibility.Hidden;
                }
                uxNumber9Answer.Visibility = Visibility.Hidden; //Maximum 8 Answers in Double Points surveys
                uxNumber9Points.Visibility = Visibility.Hidden; //Maximum 8 Answers in Double Points surveys
                //hide unused answers
                uxQuestion.Text = game.question;
                uxStrikes.Content = "";
                uxUpdate.Content = "Rd. 5"; //to update next question
                uxQuestionAndPoints.Content = "Question 4           Total Points:";
            }
            else if (game.questionNumber == 5)
            {
                reset();
                atNextQuestion();
                game.question5();
                question5.Play();
                uxInfo.Text = "This is the fifth and final question. Point values are tripled. Top " + game.answersLeft + " answers on the board.";
                game.totalPoints += game.roundPoints;
                uxTotalScore.Content = game.totalPoints.ToString();
                game.roundPoints = 0;
                uxScore.Content = "0";
                if (game.number4 == null)
                {
                    uxNumber4Answer.Visibility = Visibility.Hidden;
                    uxNumber4Points.Visibility = Visibility.Hidden;
                }
                if (game.number5 == null)
                {
                    uxNumber5Answer.Visibility = Visibility.Hidden;
                    uxNumber5Points.Visibility = Visibility.Hidden;
                }
                uxNumber6Answer.Visibility = Visibility.Hidden; //Maximum 5 Answers in Triple Points surveys
                uxNumber6Points.Visibility = Visibility.Hidden; //Maximum 5 Answers in Triple Points surveys
                uxNumber7Answer.Visibility = Visibility.Hidden; //Maximum 5 Answers in Triple Points surveys
                uxNumber7Points.Visibility = Visibility.Hidden; //Maximum 5 Answers in Triple Points surveys
                uxNumber8Answer.Visibility = Visibility.Hidden; //Maximum 5 Answers in Triple Points surveys
                uxNumber8Points.Visibility = Visibility.Hidden; //Maximum 5 Answers in Triple Points surveys
                uxNumber9Answer.Visibility = Visibility.Hidden; //Maximum 5 Answers in Triple Points surveys
                uxNumber9Points.Visibility = Visibility.Hidden; //Maximum 5 Answers in Triple Points surveys
                //hide unused answers
                uxQuestion.Text = game.question;
                uxStrikes.Content = "";
                uxUpdate.Content = "FM"; //will go to fast money
                uxQuestionAndPoints.Content = "Question 5           Total Points:";
                this.Background = System.Windows.Media.Brushes.Red;
                uxInfo.Background = System.Windows.Media.Brushes.Red;
            }
            else if (game.questionNumber == 6)
            {
                atNextQuestion();
                game.totalPoints += game.roundPoints;
                uxTotalScore.Content = game.totalPoints.ToString();
                uxQuestion.Text = "Fast Money!";
                uxInfo.Text = "Click on the input box and push CTRL to begin. Push enter to submit your answers and reveal the next question. You must capitalize all answers. When all 5 answers are submitted click Submit to see how you did!";
                fastMoneyQuestions = game.fastMoneyQuestions();
                game.roundPoints = 0;
                fastMoneySetup();
                uxScore.Content = "0";
            }
        }

        private void uxInput_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            uxCheck.IsEnabled = true;
        }

        private void uxInput_KeyDown_1(object sender, KeyEventArgs e)
        {
            Key k = e.Key;
            if (game.questionNumber == 6 || game.questionNumber == 7)
            {
                if (k == Key.LeftCtrl || k == Key.RightCtrl)
                {
                    if (e.IsDown)
                    {
                        if (game.questionNumber == 6)
                        {
                            time = 35;
                            fastmoney1.Play();
                        }
                        else
                        {
                            time = 30;
                            fastmoney2.Play();
                        }
                        _timer.Interval = 1000;
                        _timer.Start();
                        uxLabel1.Content = time.ToString();
                        uxQuestion.Text = fastMoneyQuestions[0];
                        if (time == 0)
                        {
                            buzzer.Play();
                            //lock out text box
                        }
                        else if (uxQuestion.Text == "Please click SUBMIT")
                        {
                           _timer.Stop();
                           fastmoneydings.Play();
                        }
                    }
                }
                uxTotalScore.Content = game.perfectGame.ToString();
                
                    if (k == Key.Enter)
                    {
                        if (e.IsDown)
                        {
                            if (i < 4)
                            {
                            fastMoney[i] = uxInput.Text;
                            answersAlreadyUsed.Add(uxInput.Text);
                            i++;
                            uxInput.Text = "";
                            uxQuestion.Text = fastMoneyQuestions[i];
                            }
                            else
                            {
                                fastMoney[4] = uxInput.Text;
                                answersAlreadyUsed.Add(uxInput.Text);
                                uxInput.Text = "";
                                uxQuestion.Text = "Please click SUBMIT";
                                _timer.Stop();
                                fastmoneydings.Play();
                                i = 0;
                            }
                        }
                    }
            }
        }
        private void postgame()
        {
            uxLabel1.Content = "FAMILY FEUD!";
            string path = "records.txt";
            if (!File.Exists(path)) File.Create(path);
            using (StreamWriter str = File.AppendText(path))
            {
                DateTime d = DateTime.Now;
                string time = d.ToString("M/d/yyyy HH:mm");
                string timenew = time.Replace(' ', ',');
                str.WriteLine(game.totalPoints + " " + game.roundPoints + " " + timenew + " " + game.gameNumber);
            }
            High_Scores highScores = new High_Scores();
            highScores.Show();
            BackgroundWorker bw2 = new BackgroundWorker();
            bw2.WorkerReportsProgress = true;
            bw2.DoWork += new DoWorkEventHandler(delegate(object o, DoWorkEventArgs args)
            {
                BackgroundWorker b3 = o as BackgroundWorker;
                for (int i = 0; i < 100; i++)
                {
                    b3.ReportProgress(10);
                    Thread.Sleep(2000);
                    b3.ReportProgress(20);
                    Thread.Sleep(2000);
                    b3.ReportProgress(30);
                    Thread.Sleep(2000);
                    b3.ReportProgress(40);
                    Thread.Sleep(2000);
                    b3.ReportProgress(50);
                    Thread.Sleep(2000);
                    b3.ReportProgress(60);
                    Thread.Sleep(2000);
                    b3.ReportProgress(70);
                    Thread.Sleep(2000);
                    b3.ReportProgress(80);
                    Thread.Sleep(2000);
                    b3.ReportProgress(90);
                    Thread.Sleep(2000);
                    b3.ReportProgress(99);
                    Thread.Sleep(2000);
                }
                b3.ReportProgress(100);
            });
            bw2.ProgressChanged += new ProgressChangedEventHandler(delegate(object o, ProgressChangedEventArgs args)
            {
                if (args.ProgressPercentage == 10) uxQuestion.Text = "#1 Answers: " + game.topAnswers[0];
                else if (args.ProgressPercentage == 20) uxQuestion.Text = "#1 Answers: " + game.topAnswers[1];
                else if (args.ProgressPercentage == 30) uxQuestion.Text = "#1 Answers: " + game.topAnswers[2];
                else if (args.ProgressPercentage == 40) uxQuestion.Text = "#1 Answers: " + game.topAnswers[3];
                else if (args.ProgressPercentage == 50) uxQuestion.Text = "#1 Answers: " + game.topAnswers[4];
                else if (args.ProgressPercentage == 60) uxQuestion.Text = "#2 Answers: " + game.topAnswers[5];
                else if (args.ProgressPercentage == 70) uxQuestion.Text = "#2 Answers: " + game.topAnswers[6];
                else if (args.ProgressPercentage == 80) uxQuestion.Text = "#2 Answers: " + game.topAnswers[7];
                else if (args.ProgressPercentage == 90) uxQuestion.Text = "#2 Answers: " + game.topAnswers[8];
                else if (args.ProgressPercentage == 99) uxQuestion.Text = "#2 Answers: " + game.topAnswers[9];
            });
            bw2.RunWorkerCompleted += new RunWorkerCompletedEventHandler(delegate(object o, RunWorkerCompletedEventArgs args) { });
            bw2.RunWorkerAsync();
        }
        private void strike()
        {
            uxStrikes.Content = uxStrikes.Content + "X ";
            game.strikeNumber++;
            buzzer.Play();
            uxInfo.Text = "That's not on the board, that's a strike.";
            if (game.strikeNumber == 3)
            {
                uxInfo.Text = "That's three strikes. You scored " + game.roundPoints + " points in this round. Let's move on to the next question.";
                Thread.Sleep(750);
                _timer.Stop();
                if (uxNumber1Answer.Content.Equals("#1")) uxNumber1Answer.Content = game.number1;
                if (uxNumber2Answer.Content.Equals("#2")) uxNumber2Answer.Content = game.number2;
                if (uxNumber3Answer.Content.Equals("#3")) uxNumber3Answer.Content = game.number3;
                if (uxNumber4Answer.Content.Equals("#4")) uxNumber4Answer.Content = game.number4;
                if (uxNumber5Answer.Content.Equals("#5")) uxNumber5Answer.Content = game.number5;
                if (uxNumber6Answer.Content.Equals("#6")) uxNumber6Answer.Content = game.number6;
                if (uxNumber7Answer.Content.Equals("#7")) uxNumber7Answer.Content = game.number7;
                if (uxNumber8Answer.Content.Equals("#8")) uxNumber8Answer.Content = game.number8;
                if (uxNumber9Answer.Content.Equals("#9")) uxNumber9Answer.Content = game.number9;
                threeStrikes();
            }
            isAlreadyUsed = false;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            _timer.Interval = 1000;
            time--;
            if (time == 0)
            {
                _timer.Stop();
                strike();
                time = 30;
                _timer.Start();
            }
            uxLabel1.Content = time.ToString();
        }
    }
}
