using GazelleLowcay_Final_Portfolio.Interface;
using GazelleLowcay_Final_Portfolio.View.Utility;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GazelleLowcay_Final_Portfolio.View
{
    public partial class BoardGameFrm : Form, ILevelState
    {
        private Panel minotaur;
        private Panel theseus;
        private Panel exit;
        private readonly Controller controller;
        private bool firstMoveMinotaur = true;
        private EndGameBoard optionsBoard;
        private DateTime startTime;
        private TimeSpan currentElapsedTime;
        private TimeSpan totalElapsedTime;
        private bool timerRunning = false;
        protected MainForm parent;

        // Images to use for the game.
        private readonly List<Bitmap> listImage = new List<Bitmap>
                        {
                            Properties.Resources.minotaur,
                            Properties.Resources.theseus,
                            Properties.Resources.exit
                        };

        public BoardGameFrm(Controller newController, Form theParent)
        {
            InitializeComponent();
            controller = newController;
            this.parent = (MainForm)theParent;

            // Will be used for the time lapse feature.
            DateTime startTime = DateTime.MinValue;
            TimeSpan currentElapsedTime = TimeSpan.Zero;
            TimeSpan totalElapsedTime = TimeSpan.Zero;

            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(Timer1_Tick);

        }


        public MainForm TheParent => this.parent;

        public void MoveCount()
        {
            MoveNumber.Text = controller.SetMoveCount();
        }

        public void SetLevel()
        {
            throw new NotImplementedException();
        }

        public void SetLevelName(string levelName)
        {
            LevelName.Text = levelName;
        }

        public void DrawMaze(Controller controller, int height, int width)
        {
            // Clears the default style. 
            maze.Controls.Clear();
            maze.ColumnStyles.Clear();
            maze.RowStyles.Clear();
            // Generate the table, setting up the row and column counts first.
            maze.ColumnCount = width;
            maze.RowCount = height;

            for (int x = 0; x < height; x++)
            {
                // Column style.
                maze.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                for (int y = 0; y < width; y++)
                {
                    // Add row style.
                    if (x == 0)
                    {
                        maze.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    }
                    // Draws the walls and put the game characters in place.
                    CreateCell(controller, maze, x, y);
                }
            }
        }


        public void AdjustThesues(Controller controller, int height, int width)
        {
            WaitMsg.Visible = false;
            // Removing Theseus image from the current position.
            theseus.BackgroundImage = null;
            MoveCount();
            for (int x = 0; x < height; x++)
            {
                for (int y = 0; y < width; y++)
                {
                    // Finding where is Theseus
                    var aSquare = controller.CheckSquare(x, y);
                    Panel panel = (Panel)maze.GetControlFromPosition(y, x);
                    if (aSquare.Theseus)
                    {
                        // Adding theseus image to the destination.
                        panel.BackgroundImage = listImage[1];
                        panel.BackgroundImageLayout = ImageLayout.Stretch;
                        theseus = panel;
                        AdjustMinotaur(controller, controller.LevelHeight, controller.LevelWidth);
                        return;
                    }
                }
            }
        }

        public void AdjustMinotaur(Controller controller, int height, int width)
        {
            // This is so that the exit image will not be removed if ever Minotaur goes in the exit door 
            if (exit.Equals(minotaur))
            {
                minotaur.BackgroundImage = listImage[2];
            }
            else
                minotaur.BackgroundImage = null;
            for (int x = 0; x < height; x++) //
            {                //First add a column
                for (int y = 0; y < width; y++)
                {
                    var aSquare = controller.CheckSquare(x, y);
                    // Find where to add the image of the minotaur
                    Panel panel = (Panel)maze.GetControlFromPosition(y, x);
                    // Must return the equivalent new cellcontainer
                    if (aSquare.Minotaur)
                    {
                        panel.BackgroundImage = listImage[0];
                        panel.BackgroundImageLayout = ImageLayout.Stretch;
                        // Container to keep track where is the image of Minotaur. 
                        minotaur = panel;
                        if (firstMoveMinotaur)
                        {
                            controller.MoveMinotaur();
                            firstMoveMinotaur = false;
                            // I added this to show the path that minotaur goes since he move 2 steps.
                            DateTime timeDelay = DateTime.Now;
                            do
                            {
                                Application.DoEvents();
                            }
                            while (timeDelay.AddMilliseconds(300) > DateTime.Now);
                            AdjustMinotaur(controller, height, width);
                            return;
                        }
                        else
                            firstMoveMinotaur = true;
                        CheckIfGameFinish();
                        return;
                    }

                }

            }
        }

        private void CreateCell(Controller controller, TableLayoutPanel maze, int x, int y)
        { // Draw only for the initial state of the boardgame
            var drawCell = new Cell();

            Panel cellContainer = new Panel
            {
                Height = 80,
                Width = 80,
                BackColor = Color.HotPink,
                Margin = new Padding(0, 0, 0, 0),

            };

            var aSquare = controller.CheckSquare(x, y);
            if (aSquare.Top)
            {
                Label top = drawCell.DrawTop();
                cellContainer.Controls.Add(top);
            }
            if (aSquare.Bottom)
            {
                Label bot = drawCell.DrawBottom();
                cellContainer.Controls.Add(bot);
            }
            if (aSquare.Right)
            {
                Label right = drawCell.DrawRight();
                cellContainer.Controls.Add(right);
            }
            if (aSquare.Left)
            {
                Label left = drawCell.DrawLeft();
                cellContainer.Controls.Add(left);
            }

            if (aSquare.Minotaur)
            {  // Add and remove the image to the panel accordingly
                cellContainer.BackgroundImage = listImage[0];
                cellContainer.BackgroundImageLayout = ImageLayout.Stretch;
                minotaur = cellContainer;
            }
            else if (aSquare.Theseus)
            {
                cellContainer.BackgroundImage = listImage[1];
                cellContainer.BackgroundImageLayout = ImageLayout.Stretch;
                theseus = cellContainer;

            }
            else if (aSquare.Exit)
            {
                cellContainer.BackgroundImage = listImage[2];
                cellContainer.BackgroundImageLayout = ImageLayout.Stretch;
                exit = cellContainer;
            }
            maze.Controls.Add(cellContainer);
        }

        private void BtnWait_Click(object sender, EventArgs e)
        {
            controller.Pause();
            MoveCount();
            WaitMsg.Visible = true;
            AdjustMinotaur(controller, controller.LevelHeight, controller.LevelWidth);
        }

        private void BtnMoveRight_Click(object sender, EventArgs e)
        {
            controller.MoveRight();
            AdjustThesues(controller, controller.LevelHeight, controller.LevelWidth);
        }

        private void BtnMoveUp_Click(object sender, EventArgs e)
        {
            controller.MoveUp();
            AdjustThesues(controller, controller.LevelHeight, controller.LevelWidth);
        }

        private void BtnMoveLeft_Click(object sender, EventArgs e)
        {
            controller.MoveLeft();
            AdjustThesues(controller, controller.LevelHeight, controller.LevelWidth);
        }

        private void BtnMoveDown_Click(object sender, EventArgs e)
        {
            controller.MoveDown();
            AdjustThesues(controller, controller.LevelHeight, controller.LevelWidth);
        }

        private void CheckIfGameFinish()
        {
            Form winner = new Form
            {
                Font = new Font(Font.FontFamily.Name, 14.0F, FontStyle.Bold),
                Size = new Size(350, 100)
            };
            Label label = new Label
            {
                Dock = DockStyle.Fill
            };
            winner.Controls.Add(label);
            var gameEnd = false;
            if (controller.HasTheseusWon())
            {
                PauseTimerNow();
                gameEnd = true;
                winner.Text = "Theseus Won";
                label.Text = "Theseus successfully escaped!!!";
                winner.ShowDialog();
                // create the dialogue win
            }
            else if (controller.HasMinotaurWon())
            {
                PauseTimerNow();
                gameEnd = true;
                winner.Text = "Minotaur Won";
                label.Text = "Minotaur Caught Thesues:'(";
                winner.ShowDialog();
            }
            if (gameEnd)
            {

                optionsBoard = new EndGameBoard(this);
                this.Visible = false;
                if (controller.HasTheseusWon())
                {
                    optionsBoard.MsgWhoWin.Text = $"Congratulations, {winner.Text}";
                    optionsBoard.ShowDialog();
                    return;
                }
                else if (controller.HasMinotaurWon())
                {
                    optionsBoard.MsgWhoWin.Text = $"Sorry, {winner.Text}";
                    optionsBoard.ShowDialog();
                    return;
                }
                return;
            }
        }


        public void ChangeLevel()
        {
            SetLevelName(controller.SetLevelName());
            MoveCount();
            firstMoveMinotaur = true;
            DrawMaze(controller, controller.LevelHeight, controller.LevelWidth);
        }


        private void BoardGameFrm_MouseMove(object sender, MouseEventArgs e)
        {
            WaitMsg.Visible = false;
        }

        public void GameLevels_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedString = (string)GameLevels.SelectedItem;
            // Convert it to lowercase.
            switch (selectedString.ToLower())
            {
                case "level 1":
                    controller.SetLevel("level 1");
                    ChangeLevel();
                    break;
                case "level 2":
                    controller.SetLevel("level 2");
                    ChangeLevel();
                    break;
                case "level 3":
                    controller.SetLevel("level 3");
                    ChangeLevel();
                    break;
                case "level 4":
                    controller.SetLevel("level 4");
                    ChangeLevel();
                    break;
                case "level 5":
                    controller.SetLevel("level 5");
                    ChangeLevel();
                    break;
            }
            Restart();
            StartTimerNow();
        }

        public void NextLevel(string currentLevel)
        {
            switch (currentLevel.ToLower())
            {
                case "level 1":
                    controller.SetLevel("level 2");
                    GameLevels.Text = "Level 2";
                    break;
                case "level 2":
                    controller.SetLevel("level 3");
                    GameLevels.Text = "Level 3";
                    break;
                case "level 3":
                    controller.SetLevel("level 4");
                    GameLevels.Text = "Level 4";
                    break;
                case "level 4":
                    controller.SetLevel("level 5");
                    GameLevels.Text = "Level 5";
                    break;
                case "level 5":
                    Form form = new Form
                    {
                        Size = new Size(400, 50),
                        Text = "Level 5 is the last level of the game"
                    };
                    form.ShowDialog();
                    break;
            }
        }

        public void PreviousLevel(string currentLevel)
        {
            switch (currentLevel.ToLower())
            {
                case "level 1":
                    Form form = new Form
                    {
                        Size = new Size(400, 50),
                        Text = "You are currently at the first level"
                    };
                    form.ShowDialog();
                    break;
                case "level 2":
                    controller.SetLevel("level 1");
                    GameLevels.Text = "Level 1";
                    break;
                case "level 3":
                    controller.SetLevel("level 2");
                    GameLevels.Text = "Level 2";
                    break;
                case "level 4":
                    controller.SetLevel("Level 3");
                    GameLevels.Text = "Level 3";
                    break;
                case "level 5":
                    controller.SetLevel("Level 4");
                    GameLevels.Text = "Level 4";
                    break;
            }

        }



        private void Timer1_Tick(object sender, EventArgs e)
        {
            TriggerStartTimer();
        }

        private void TriggerStartTimer()
        {
            var timeSinceStartTime = DateTime.Now - startTime;
            timeSinceStartTime = new TimeSpan(timeSinceStartTime.Hours,
                                              timeSinceStartTime.Minutes,
                                              timeSinceStartTime.Seconds);
            currentElapsedTime = timeSinceStartTime + totalElapsedTime;
            TimerLapse.Text = currentElapsedTime.ToString();
        }

        private void StartTimer_Click(object sender, EventArgs e)
        {
            if (!timerRunning)
            {
                // Set the start time to Now
                StartTimerNow();
            }
            else // If the timer is already running
            {
                PauseTimerNow();
                maze.Visible = false;
            }
            // Referrence: https://markb.uk/creating-a-simple-stopwatchtimer-application-with-c-windows-forms.html
        }

        public void PauseTimerNow()
        {
            timer1.Stop();
            BtnStartTimer.Text = "Start";
            BtnStartTimer.BackColor = Color.Green;
            BtnStartTimer.ForeColor = Color.White;
            timerRunning = false;

        }

        private void StartTimerNow()
        {
            startTime = DateTime.Now;

            // Store the total elapsed time so far
            totalElapsedTime = currentElapsedTime;
            timer1.Start();
            timerRunning = true;
            BtnStartTimer.Text = "Pause";
            BtnStartTimer.BackColor = Color.Yellow;
            BtnStartTimer.ForeColor = Color.Black;
            maze.Visible = true;
        }

        private void Restart()
        {
            timer1.Stop();
            timerRunning = false;
            // Reset the elapsed time TimeSpan objects
            totalElapsedTime = TimeSpan.Zero;
            currentElapsedTime = TimeSpan.Zero;
            TimerLapse.Text = "00:00:00";
            BtnStartTimer.Text = "Start";
            BtnStartTimer.BackColor = Color.Green;
            BtnStartTimer.ForeColor = Color.White;

        }

        private void BtnResetTimer_Click(object sender, EventArgs e)
        {
            Restart();
            GameLevels_SelectedIndexChanged(sender, e);
        }

        private void BoardGameFrm_Load(object sender, EventArgs e)
        {
            StartTimer_Click(sender, e);
        }

        public void BoardGameFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parent.MinotaurImageHolder.Visible = true;
            this.parent.TheseusImageHolder.Visible = true;
            this.parent.GameTitle.Visible = true;
        }
    }

}
