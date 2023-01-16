namespace JogoDaCobrinha
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PnTela = new System.Windows.Forms.Panel();
            this.LbPontos = new System.Windows.Forms.Label();
            this.Frame = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CbAtravessarParedes = new System.Windows.Forms.CheckBox();
            this.nFrutas = new System.Windows.Forms.NumericUpDown();
            this.LbFrutas = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFrutas)).BeginInit();
            this.SuspendLayout();
            // 
            // PnTela
            // 
            this.PnTela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnTela.Location = new System.Drawing.Point(12, 80);
            this.PnTela.Name = "PnTela";
            this.PnTela.Size = new System.Drawing.Size(426, 426);
            this.PnTela.TabIndex = 0;
            // 
            // LbPontos
            // 
            this.LbPontos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbPontos.Location = new System.Drawing.Point(12, 42);
            this.LbPontos.Name = "LbPontos";
            this.LbPontos.Size = new System.Drawing.Size(428, 21);
            this.LbPontos.TabIndex = 1;
            this.LbPontos.Text = "Pontos: 0";
            // 
            // Frame
            // 
            this.Frame.Tick += new System.EventHandler(this.Frame_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarToolStripMenuItem,
            this.opçõesToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(457, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iniciarToolStripMenuItem
            // 
            this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.iniciarToolStripMenuItem.Text = "Iniciar";
            this.iniciarToolStripMenuItem.Click += new System.EventHandler(this.iniciarToolStripMenuItem_Click);
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            this.opçõesToolStripMenuItem.Click += new System.EventHandler(this.opçõesToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // CbAtravessarParedes
            // 
            this.CbAtravessarParedes.AllowDrop = true;
            this.CbAtravessarParedes.AutoSize = true;
            this.CbAtravessarParedes.Checked = true;
            this.CbAtravessarParedes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbAtravessarParedes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbAtravessarParedes.Location = new System.Drawing.Point(12, 546);
            this.CbAtravessarParedes.Name = "CbAtravessarParedes";
            this.CbAtravessarParedes.Size = new System.Drawing.Size(144, 23);
            this.CbAtravessarParedes.TabIndex = 5;
            this.CbAtravessarParedes.Text = "Atravessar Paredes";
            this.CbAtravessarParedes.UseVisualStyleBackColor = true;
            // 
            // nFrutas
            // 
            this.nFrutas.BackColor = System.Drawing.Color.DimGray;
            this.nFrutas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nFrutas.ForeColor = System.Drawing.Color.LightGray;
            this.nFrutas.Location = new System.Drawing.Point(318, 548);
            this.nFrutas.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nFrutas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nFrutas.Name = "nFrutas";
            this.nFrutas.Size = new System.Drawing.Size(52, 23);
            this.nFrutas.TabIndex = 6;
            this.nFrutas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nFrutas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LbFrutas
            // 
            this.LbFrutas.AutoSize = true;
            this.LbFrutas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbFrutas.Location = new System.Drawing.Point(262, 548);
            this.LbFrutas.Name = "LbFrutas";
            this.LbFrutas.Size = new System.Drawing.Size(50, 19);
            this.LbFrutas.TabIndex = 7;
            this.LbFrutas.Text = "Frutas:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(457, 579);
            this.Controls.Add(this.LbFrutas);
            this.Controls.Add(this.nFrutas);
            this.Controls.Add(this.CbAtravessarParedes);
            this.Controls.Add(this.LbPontos);
            this.Controls.Add(this.PnTela);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Cobrinha";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pressionado);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFrutas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel PnTela;
        private Label LbPontos;
        private System.Windows.Forms.Timer Frame;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem iniciarToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem opçõesToolStripMenuItem;
        private CheckBox CbAtravessarParedes;
        private NumericUpDown nFrutas;
        private Label LbFrutas;
    }
}