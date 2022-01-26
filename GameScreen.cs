using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Xml;
using System.IO;
using System.Threading;

namespace BadIceCreamFinal
{
    public partial class GameScreen : UserControl
    {
        //creates list for walls and inner obstacles 
        List<Rectangle> walls = new List<Rectangle>();
        List<Rectangle> walking = new List<Rectangle>();
        List<Block> blocks = new List<Block>();

        List<Points> points = new List<Points>();
        List<Player> players = new List<Player>();

        //creates players and enemies 
        Player player1;
        Player player2;
        Enemy enemy1;
        Enemy enemy2;
        SolidBrush enemyBrush = new SolidBrush(Color.Black);

        public static Boolean leftArrowDown, rightArrowDown, upArrowDown, downArrowDown, aKeyDown, wKeyDown, dKeyDown, sKeyDown, spaceDown, pDown;

        Image up, down, left, right, current;
        Image pup, pdown, pleft, pright, pcurrent;

        //image arrays for moving characters
        Image[] p1Images = { Properties.Resources.whiteUp, Properties.Resources.whiteDown, Properties.Resources.whiteLeft, Properties.Resources.whiteRight };
        Image[] p2Images = { Properties.Resources.pinkUp, Properties.Resources.pinkDown, Properties.Resources.pinkLeft, Properties.Resources.pinkRight };

        Rectangle player1rec;
        Rectangle player2rec;

        //starts game at level 1
        public static int level = 1;
        public static int levelUnlock = 1;
        int fruitType = 1;

        System.Windows.Media.MediaPlayer backMedia = new System.Windows.Media.MediaPlayer();

        public GameScreen()
        {
            InitializeComponent();
            backMedia.Open(new Uri(Application.StartupPath + "/Resources/gameMusic.wav"));
            backMedia.MediaEnded += new EventHandler(backMedia_MediaEnded);

            OnStart();
            ReadXml();
            ReadXmlFruit();
        }

        public void OnStart()
        {
            //starts music
            backMedia.Play();

            //set all button presses to false
            leftArrowDown = rightArrowDown = false;

            //sets images for player directions 
            current = up = p1Images[0];
            down = p1Images[1];
            left = p1Images[2];
            right = p1Images[3];

            pcurrent = pup = p2Images[0];
            pdown = p2Images[1];
            pleft = p2Images[2];
            pright = p2Images[3];

            //sets player values
            int player1X = 270;
            int player1Y = 451;
            int player2X = 420;
            int player2Y = 451;
            int playerWidth = 35;
            int playerHeight = 40;
            int playerSpeed = 10;

            //sets enemy values 
            int enemy1X = 40;
            int enemy1Y = 100;
            int enemy2X = 648;
            int enemy2Y = 100;
            int enemySpeed = 5;

            //adds values to players and enemies 
            player1 = new Player(player1X, player1Y, playerWidth, playerHeight, playerSpeed, Color.Black);
            players.Add(player1);
            player2 = new Player(player2X, player2Y, playerWidth, playerHeight, playerSpeed, Color.Black);
            players.Add(player2);
            enemy1 = new Enemy(enemy1X, enemy1Y, playerWidth, playerHeight, enemySpeed, Color.Blue);
            enemy2 = new Enemy(enemy2X, enemy2Y, playerWidth, playerHeight, enemySpeed, Color.Blue);

            //sets player 2 null if a 1 player game
            if (PlayerScreen.pNumber == 1)
            {
                player2 = null;
            }

            gameTimer.Enabled = true;
            this.Focus();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //allows bots to move if they aren't dead(null)
            if (player1 != null)
            {
                player1.Move(aKeyDown, dKeyDown, wKeyDown, sKeyDown, walls);
                player1rec = new Rectangle(player1.x, player1.y, player1.width, player1.height);
            }

            if (player2 != null)
            {
                player2.Move(leftArrowDown, rightArrowDown, upArrowDown, downArrowDown, walls);
                player2rec = new Rectangle(player2.x, player2.y, player2.width, player2.height);
            }

            enemy1.Move(walls);
            enemy2.Move(walls);

            //creates enemy rectangles for collisions 
            Rectangle enemy1rec = new Rectangle(enemy1.x, enemy1.y, enemy1.width, enemy1.height);
            Rectangle enemy2rec = new Rectangle(enemy2.x, enemy2.y, enemy2.width, enemy2.height);

            //hides players if they touch an enemy 
            if (player1rec.IntersectsWith(enemy1rec) || player1rec.IntersectsWith(enemy2rec))
            {
                player1 = null;
            }
            else if (player2rec.IntersectsWith(enemy1rec) || player2rec.IntersectsWith(enemy2rec))
            {
                player2 = null;
            }
            else if (player1 == null && player2 == null)
            {
                //opens lose screen if both players are dead 
                Lose();
            }

            foreach (Player p in players)
            {
                for (int i = 0; i < points.Count(); i++)
                {
                    p.PointCollision(points[i]);

                    if (p.PointCollision(points[i]))
                    {
                        var blipSound = new System.Windows.Media.MediaPlayer();
                        blipSound.Open(new Uri(Application.StartupPath + "/Resources/beep.wav"));
                        blipSound.Play();
                        //removes points after collision 
                        points.Remove(points[i]);

                        //draws more points if a certain colour is cleared
                        if (points.Count == 0)
                        {
                            fruitType++;
                            ReadXmlFruit();
                        }
                    }
                }
            }

            if (fruitType == 3)
            {
                if (level <= 3)
                {
                    level++;
                }

                //allows the next level to 'unlock'
                if (level > levelUnlock)
                {
                    levelUnlock++;
                }
                fruitType = 1;

                //opens win screen
                Win();
            }
            Refresh();
        }

        private void ReadXml()
        {
            XmlReader reader = XmlReader.Create($"Resources/lvl{level}.xml");
            while (reader.Read())
            {
                //reads XML values and adds to block class
                Block b = new Block();
                reader.ReadToFollowing("brick");
                string type = (reader.GetAttribute("type"));
                b.x = Convert.ToInt32(reader.GetAttribute("x"));
                b.y = Convert.ToInt32(reader.GetAttribute("y"));
                b.width = Convert.ToInt32(reader.GetAttribute("width"));
                b.height = Convert.ToInt32(reader.GetAttribute("height"));
                string colour = reader.GetAttribute("colour");

                //adds values to walls list 
                if (type == "error")
                {
                    walls.Add(new Rectangle(b.x, b.y, b.width, b.height));
                }
                else if (type == "walk")
                {
                    walking.Add(new Rectangle(b.x, b.y, b.width, b.height));
                }

                if (colour != null)
                {
                    //sets colour brush and border brush 
                    b.brush = new SolidBrush(Color.FromName(colour));
                    b.borderPen = new Pen(Color.Black);
                    blocks.Add(b);
                }
            }
            reader.Close();
        }

        private void ReadXmlFruit()
        {
            XmlReader reader = XmlReader.Create($"Resources/lvl{level}Fruit.xml");
            while (reader.Read())
            {
                //gets XML values and adds it to points class 
                Points p = new Points();
                reader.ReadToFollowing("brick");
                p.x = Convert.ToInt32(reader.GetAttribute("x"));
                p.y = Convert.ToInt32(reader.GetAttribute("y"));
                p.width = Convert.ToInt32(reader.GetAttribute("width"));
                p.height = Convert.ToInt32(reader.GetAttribute("height"));
                string colour = reader.GetAttribute("colour");

                if (colour != null)
                {
                    if (fruitType == 1 && colour == "MediumSlateBlue")
                    {
                        //draws first 
                        p.brush = new SolidBrush(Color.FromName(colour));
                        points.Add(p);
                    }
                    else if (fruitType == 2 && colour == "Yellow")
                    {
                        //draws after all MediumSlateBlue are cleared
                        p.brush = new SolidBrush(Color.FromName(colour));
                        points.Add(p);
                    }
                }
            }
            reader.Close();
        }

        private void Win()
        {
            gameTimer.Enabled = false;
            //opens WinScreen
            WinScreen ws = new WinScreen();
            Form form = this.FindForm();

            form.Controls.Add(ws);
            form.Controls.Remove(this);

            ws.Location = new Point((form.Width - ws.Width) / 2, (form.Height - ws.Height) / 2);
        }

        private void Lose()
        {
            gameTimer.Enabled = false;
            //opens LoseScreen 
            LoseScreen ls = new LoseScreen();
            Form form = this.FindForm();

            form.Controls.Add(ls);
            form.Controls.Remove(this);

            ls.Location = new Point((form.Width - ls.Width) / 2, (form.Height - ls.Height) / 2);
        }

        public void ShowMessageBox()
        {
            //sets message box text 
            string text = "Ignore to Continue \nRetry to Restart Level \nAbort for Main Menu";
            string title = "Bad Ice Cream";

            MessageBoxButtons buttons = MessageBoxButtons.AbortRetryIgnore;

            // Display message box 
            DialogResult result = MessageBox.Show(text, title, buttons);


            if (result == DialogResult.Retry)
            {
                //restarts level with retry 
                if (fruitType == 2)
                {
                    points.Clear();
                    Refresh();
                    fruitType = 1;
                }
                OnStart();
                ReadXml();
                ReadXmlFruit();
            }
            else if (result == DialogResult.Abort)
            {
                //opens menu screen for abort button 
                MenuScreen ms = new MenuScreen();
                Form form = this.FindForm();

                form.Controls.Add(ms);
                form.Controls.Remove(this);

                ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);
            }
            else if (result == DialogResult.Ignore)
            {
                //continue game with ignore 
                gameTimer.Enabled = true;
            }
        }

        #region keys
        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;

                case Keys.A:
                    aKeyDown = false;
                    break;
                case Keys.W:
                    wKeyDown = false;
                    break;
                case Keys.D:
                    dKeyDown = false;
                    break;
                case Keys.S:
                    sKeyDown = false;
                    break;

                case Keys.Space:
                    spaceDown = false;
                    if (gameTimer.Enabled)
                    {
                        //pause game with space click 
                        gameTimer.Enabled = false;
                        ShowMessageBox();
                    }
                    break;
            }
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    pcurrent = pleft;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    pcurrent = pright;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    pcurrent = pup;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    pcurrent = pdown;
                    break;

                case Keys.A:
                    aKeyDown = true;
                    current = left;
                    break;
                case Keys.W:
                    wKeyDown = true;
                    current = up;
                    break;
                case Keys.D:
                    dKeyDown = true;
                    current = right;
                    break;
                case Keys.S:
                    sKeyDown = true;
                    current = down;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
            }
        }
        #endregion

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            foreach (Points p in points)
            {
                e.Graphics.FillRectangle(p.brush, p.x, p.y, p.width, p.height);
            }

            //draws players if they aren't dead
            if (player1 != null)
            {
                e.Graphics.DrawImage(current, player1.x, player1.y, player1.width, player1.height);
            }
            //draws if two player game
            if (player2 != null)
            {
                e.Graphics.DrawImage(pcurrent, player2.x, player2.y, player2.width, player2.height);
            }

            //draws enemies 
            e.Graphics.FillRectangle(enemyBrush, enemy1.x, enemy1.y, enemy1.width, enemy1.height);
            e.Graphics.FillRectangle(enemyBrush, enemy2.x, enemy2.y, enemy2.width, enemy2.height);

            //draw blocks
            foreach (Block b in blocks)
            {
                e.Graphics.FillRectangle(b.brush, b.x, b.y, b.width, b.height);
                e.Graphics.DrawRectangle(b.borderPen, b.x, b.y, b.width, b.height);
            }
        }

        private void backMedia_MediaEnded(object sender, EventArgs e)
        {
            backMedia.Stop();
            backMedia.Play();
        }
    }
}

