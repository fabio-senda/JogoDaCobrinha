using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace JogoDaCobrinha
{
    class Game
    {
        public Keys Direction { get; set; }

        public Keys Arrow { get; set; }

        private Timer Frame { get; set; }
        private Label LbPontos { get; set; }
        private Panel PnTela { get; set; }
        private NumericUpDown nFrutas { get; set; }

        private int pontos = 0;

        private List<Food> Foods;
        private Snake Snake;

        private Bitmap offScreenBitmap;

        private Graphics bitmapGraph;
        private Graphics screenGraph;

        public Game(ref Timer timer, ref Label label, ref Panel panel, ref CheckBox cbAtravessar, ref NumericUpDown frutinhas)
        {
            PnTela = panel;
            Frame = timer;
            LbPontos = label;
            nFrutas = frutinhas;
            offScreenBitmap = new Bitmap(428, 428);
            Snake = new Snake(cbAtravessar);
            Foods = new List<Food>();
            Direction = Keys.Left;
            Arrow = Direction;
            pontos = 0;
        }

        public void StartGame()
        {
            Snake.Reset();
            for (int i = 0; i < nFrutas.Value; i++) { 
                Foods.Add(new Food());
                Foods[i].CreateFood();
            }
            Direction = Keys.Left;
            bitmapGraph = Graphics.FromImage(offScreenBitmap);
            screenGraph = PnTela.CreateGraphics();
            Frame.Enabled = true;
            pontos = 0;
        }

        public void Tick()
        {
            if (((Arrow == Keys.Left) && (Direction != Keys.Right)) ||
               ((Arrow == Keys.Right) && (Direction != Keys.Left)) ||
               ((Arrow == Keys.Up) && (Direction != Keys.Down)) ||
               ((Arrow == Keys.Down) && (Direction != Keys.Up)))
            {
                Direction = Arrow;
            }
            switch (Direction)
            {
                case Keys.Right:
                    Snake.Right();
                    break;
                case Keys.Left:
                    Snake.Left();
                    break;
                case Keys.Up:
                    Snake.Up();
                    break;
                case Keys.Down:
                    Snake.Down();
                    break;
            }
            bitmapGraph.Clear(Color.DarkGray);
            for (int i = 0; i < nFrutas.Value; i++)
            {
                bitmapGraph.FillEllipse(new SolidBrush(Color.Red), (Foods[i].Location.X * 15), (Foods[i].Location.Y * 15), 15, 15);
            }
            //bitmapGraph.DrawImage(Properties.Resoures.Food,(Food.Location.X*15),(Food.Location.Y*15),15,15);
            bool gameOver = false;

            for (int i = 0; i < Snake.Length; i++)
            {
                if (i == 0)
                {
                    bitmapGraph.FillEllipse(new SolidBrush(ColorTranslator.FromHtml("#006600")), (Snake.Location[i].X * 15), (Snake.Location[i].Y * 15), 15, 15);
                }
                else
                {
                    bitmapGraph.FillEllipse(new SolidBrush(ColorTranslator.FromHtml("#008000")), (Snake.Location[i].X * 15), (Snake.Location[i].Y * 15), 15, 15);
                }
                if ((Snake.Location[i] == Snake.Location[0]) && (i > 0))
                {
                    gameOver = true;
                }
            }
            if (Snake.Location[0].X < 0 || Snake.Location[0].Y < 0 || Snake.Location[0].X > 27 || Snake.Location[0].Y > 27)
            {
                gameOver = true;
            }
            CheckCollision();
            if (gameOver) GameOver();
            else screenGraph.DrawImage(offScreenBitmap, 0, 0);
        }

        public void CheckCollision()
        {
            for (int i = 0; i < nFrutas.Value; i++)
            {
                if (Snake.Location[0] == Foods[i].Location)
                {
                    Snake.Eat();
                    Foods[i].CreateFood();
                    pontos += 9;
                    LbPontos.Text = "PONTOS: " + pontos;
                }
            }
        }

        public void GameOver()
        {
            Frame.Enabled = false;
            bitmapGraph.Dispose();
            screenGraph.Dispose();
            LbPontos.Text = "PONTOS: 0";
            MessageBox.Show("Game Over!");
        }
    }
}
