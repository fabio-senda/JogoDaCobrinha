using JogoDaCobrinha;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace JogoDaCobrinha
{
    public partial class Form1 : Form
    {
        readonly Size normal = new Size(473, 565);
        readonly Size opcoes = new Size(473, 618);
        Game Game;

        public Form1()
        {
            InitializeComponent();
            Game = new Game(ref Frame, ref LbPontos, ref PnTela, ref CbAtravessarParedes, ref nFrutas);
        }

        private void Pressionado(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                Game.Arrow = e.KeyCode;
            }
            else if (!Frame.Enabled && e.KeyCode == Keys.Space) Game.StartGame();
        }

        private void Frame_Tick(object sender, EventArgs e)
        {
            Game.Tick();
        }

        private void iniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = normal;
            CbAtravessarParedes.Enabled = false;
            CbAtravessarParedes.Visible = false;
            nFrutas.Enabled = false;
            nFrutas.Visible = false;
            LbFrutas.Visible = false;
            Game.StartGame();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void opçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Frame.Enabled)
            {
                this.Size = opcoes;
                CbAtravessarParedes.Enabled = true;
                CbAtravessarParedes.Visible = true;
                nFrutas.Enabled = true;
                nFrutas.Visible = true;
            }
        }
    }
}
        