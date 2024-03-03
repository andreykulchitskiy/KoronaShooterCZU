
namespace KoronaShooterCZU
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtKills = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.timerZmeny = new System.Windows.Forms.Timer(this.components);
            this.timerOmikrona = new System.Windows.Forms.Timer(this.components);
            this.timerpluskorona = new System.Windows.Forms.Timer(this.components);
            this.timerPivka = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            this.txtPilulky = new System.Windows.Forms.Label();
            this.barak = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barak)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKills
            // 
            this.txtKills.AutoSize = true;
            this.txtKills.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKills.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtKills.Location = new System.Drawing.Point(387, 7);
            this.txtKills.Name = "txtKills";
            this.txtKills.Size = new System.Drawing.Size(104, 28);
            this.txtKills.TabIndex = 1;
            this.txtKills.Text = "KILLS:0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(628, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "IMUNITA:";
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(757, 14);
            this.healthBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(141, 23);
            this.healthBar.TabIndex = 3;
            this.healthBar.Value = 100;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // timerZmeny
            // 
            this.timerZmeny.Enabled = true;
            this.timerZmeny.Interval = 300;
            this.timerZmeny.Tick += new System.EventHandler(this.timerZmeny_Tick);
            // 
            // timerOmikrona
            // 
            this.timerOmikrona.Enabled = true;
            this.timerOmikrona.Interval = 8000;
            this.timerOmikrona.Tick += new System.EventHandler(this.timerOmikrona_Tick);
            // 
            // timerpluskorona
            // 
            this.timerpluskorona.Enabled = true;
            this.timerpluskorona.Interval = 40000;
            this.timerpluskorona.Tick += new System.EventHandler(this.timerpluskorona_Tick);
            // 
            // timerPivka
            // 
            this.timerPivka.Enabled = true;
            this.timerPivka.Interval = 10000;
            this.timerPivka.Tick += new System.EventHandler(this.timerPivka_Tick);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("player.BackgroundImage")));
            this.player.Image = global::KoronaShooterCZU.Properties.Resources.hero;
            this.player.Location = new System.Drawing.Point(-1, 228);
            this.player.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(154, 156);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            // 
            // txtPilulky
            // 
            this.txtPilulky.AutoSize = true;
            this.txtPilulky.BackColor = System.Drawing.Color.DarkRed;
            this.txtPilulky.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPilulky.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPilulky.Image = ((System.Drawing.Image)(resources.GetObject("txtPilulky.Image")));
            this.txtPilulky.Location = new System.Drawing.Point(28, 7);
            this.txtPilulky.Name = "txtPilulky";
            this.txtPilulky.Size = new System.Drawing.Size(137, 28);
            this.txtPilulky.TabIndex = 0;
            this.txtPilulky.Text = "PILULKY:0";
            // 
            // barak
            // 
            this.barak.Image = ((System.Drawing.Image)(resources.GetObject("barak.Image")));
            this.barak.Location = new System.Drawing.Point(-1, -1);
            this.barak.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barak.Name = "barak";
            this.barak.Size = new System.Drawing.Size(205, 661);
            this.barak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.barak.TabIndex = 5;
            this.barak.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(923, 658);
            this.Controls.Add(this.player);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKills);
            this.Controls.Add(this.txtPilulky);
            this.Controls.Add(this.barak);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Korona-shooter in CZU";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtPilulky;
        private System.Windows.Forms.Label txtKills;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer timerZmeny;
        private System.Windows.Forms.PictureBox barak;
        private System.Windows.Forms.Timer timerOmikrona;
        private System.Windows.Forms.Timer timerpluskorona;
        private System.Windows.Forms.Timer timerPivka;
    }
}

