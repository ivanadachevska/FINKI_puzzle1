using System;

namespace WindowsFormsApplication1
{
    partial class frmPuzzleGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPuzzleGame));
            this.gbSlozuvalkaBox = new System.Windows.Forms.GroupBox();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.pbx3 = new System.Windows.Forms.PictureBox();
            this.pbx4 = new System.Windows.Forms.PictureBox();
            this.pbx5 = new System.Windows.Forms.PictureBox();
            this.pbx6 = new System.Windows.Forms.PictureBox();
            this.pbx7 = new System.Windows.Forms.PictureBox();
            this.pbx8 = new System.Windows.Forms.PictureBox();
            this.pbx9 = new System.Windows.Forms.PictureBox();
            this.btnPromesaj = new System.Windows.Forms.Button();
            this.btnIzlezi = new System.Windows.Forms.Button();
            this.lblBrPotezi = new System.Windows.Forms.Label();
            this.lblVreme = new System.Windows.Forms.Label();
            this.tmrTimeElapse = new System.Windows.Forms.Timer(this.components);
            this.btnPauza = new System.Windows.Forms.Button();
            this.gbOriginal = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.Finish = new System.Windows.Forms.ToolStripMenuItem();
            this.SledenPoteg = new System.Windows.Forms.ToolStripMenuItem();
            this.gbSlozuvalkaBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSlozuvalkaBox
            // 
            this.gbSlozuvalkaBox.Controls.Add(this.pbx1);
            this.gbSlozuvalkaBox.Controls.Add(this.pbx2);
            this.gbSlozuvalkaBox.Controls.Add(this.pbx3);
            this.gbSlozuvalkaBox.Controls.Add(this.pbx4);
            this.gbSlozuvalkaBox.Controls.Add(this.pbx5);
            this.gbSlozuvalkaBox.Controls.Add(this.pbx6);
            this.gbSlozuvalkaBox.Controls.Add(this.pbx7);
            this.gbSlozuvalkaBox.Controls.Add(this.pbx8);
            this.gbSlozuvalkaBox.Controls.Add(this.pbx9);
            this.gbSlozuvalkaBox.Location = new System.Drawing.Point(33, 60);
            this.gbSlozuvalkaBox.Name = "gbSlozuvalkaBox";
            this.gbSlozuvalkaBox.Size = new System.Drawing.Size(427, 433);
            this.gbSlozuvalkaBox.TabIndex = 0;
            this.gbSlozuvalkaBox.TabStop = false;
            this.gbSlozuvalkaBox.Text = "Сложувалка";
            // 
            // pbx1
            // 
            this.pbx1.Location = new System.Drawing.Point(17, 20);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(130, 130);
            this.pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx1.TabIndex = 0;
            this.pbx1.TabStop = false;
            this.pbx1.Click += new System.EventHandler(this.pbSmeni);
            // 
            // pbx2
            // 
            this.pbx2.Location = new System.Drawing.Point(149, 20);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(130, 130);
            this.pbx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx2.TabIndex = 0;
            this.pbx2.TabStop = false;
            this.pbx2.Click += new System.EventHandler(this.pbSmeni);
            // 
            // pbx3
            // 
            this.pbx3.Location = new System.Drawing.Point(281, 20);
            this.pbx3.Name = "pbx3";
            this.pbx3.Size = new System.Drawing.Size(130, 130);
            this.pbx3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx3.TabIndex = 0;
            this.pbx3.TabStop = false;
            this.pbx3.Click += new System.EventHandler(this.pbSmeni);
            // 
            // pbx4
            // 
            this.pbx4.Location = new System.Drawing.Point(17, 152);
            this.pbx4.Name = "pbx4";
            this.pbx4.Size = new System.Drawing.Size(130, 130);
            this.pbx4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx4.TabIndex = 0;
            this.pbx4.TabStop = false;
            this.pbx4.Click += new System.EventHandler(this.pbSmeni);
            // 
            // pbx5
            // 
            this.pbx5.Location = new System.Drawing.Point(149, 152);
            this.pbx5.Name = "pbx5";
            this.pbx5.Size = new System.Drawing.Size(130, 130);
            this.pbx5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx5.TabIndex = 0;
            this.pbx5.TabStop = false;
            this.pbx5.Click += new System.EventHandler(this.pbSmeni);
            // 
            // pbx6
            // 
            this.pbx6.Location = new System.Drawing.Point(281, 152);
            this.pbx6.Name = "pbx6";
            this.pbx6.Size = new System.Drawing.Size(130, 130);
            this.pbx6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx6.TabIndex = 0;
            this.pbx6.TabStop = false;
            this.pbx6.Click += new System.EventHandler(this.pbSmeni);
            // 
            // pbx7
            // 
            this.pbx7.Location = new System.Drawing.Point(17, 284);
            this.pbx7.Name = "pbx7";
            this.pbx7.Size = new System.Drawing.Size(130, 130);
            this.pbx7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx7.TabIndex = 0;
            this.pbx7.TabStop = false;
            this.pbx7.Click += new System.EventHandler(this.pbSmeni);
            // 
            // pbx8
            // 
            this.pbx8.Location = new System.Drawing.Point(149, 284);
            this.pbx8.Name = "pbx8";
            this.pbx8.Size = new System.Drawing.Size(130, 130);
            this.pbx8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx8.TabIndex = 0;
            this.pbx8.TabStop = false;
            this.pbx8.Click += new System.EventHandler(this.pbSmeni);
            // 
            // pbx9
            // 
            this.pbx9.Location = new System.Drawing.Point(281, 284);
            this.pbx9.Name = "pbx9";
            this.pbx9.Size = new System.Drawing.Size(130, 130);
            this.pbx9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx9.TabIndex = 0;
            this.pbx9.TabStop = false;
            this.pbx9.Click += new System.EventHandler(this.pbSmeni);
            // 
            // btnPromesaj
            // 
            this.btnPromesaj.BackColor = System.Drawing.Color.White;
            this.btnPromesaj.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPromesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPromesaj.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnPromesaj.Location = new System.Drawing.Point(529, 473);
            this.btnPromesaj.Name = "btnPromesaj";
            this.btnPromesaj.Size = new System.Drawing.Size(86, 42);
            this.btnPromesaj.TabIndex = 1;
            this.btnPromesaj.Text = "Промешај";
            this.btnPromesaj.UseVisualStyleBackColor = false;
            this.btnPromesaj.Click += new System.EventHandler(this.btnPromesaj_Click);
            // 
            // btnIzlezi
            // 
            this.btnIzlezi.BackColor = System.Drawing.Color.White;
            this.btnIzlezi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnIzlezi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIzlezi.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnIzlezi.Location = new System.Drawing.Point(776, 473);
            this.btnIzlezi.Name = "btnIzlezi";
            this.btnIzlezi.Size = new System.Drawing.Size(86, 42);
            this.btnIzlezi.TabIndex = 1;
            this.btnIzlezi.Text = "Излези";
            this.btnIzlezi.UseVisualStyleBackColor = false;
            this.btnIzlezi.Click += new System.EventHandler(this.btnIzlezi_Click);
            // 
            // lblBrPotezi
            // 
            this.lblBrPotezi.AutoSize = true;
            this.lblBrPotezi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrPotezi.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBrPotezi.Location = new System.Drawing.Point(62, 510);
            this.lblBrPotezi.Name = "lblBrPotezi";
            this.lblBrPotezi.Size = new System.Drawing.Size(137, 19);
            this.lblBrPotezi.TabIndex = 2;
            this.lblBrPotezi.Text = "Број на потези: ";
            // 
            // lblVreme
            // 
            this.lblVreme.AutoSize = true;
            this.lblVreme.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVreme.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblVreme.Location = new System.Drawing.Point(578, 371);
            this.lblVreme.Name = "lblVreme";
            this.lblVreme.Size = new System.Drawing.Size(264, 80);
            this.lblVreme.TabIndex = 3;
            this.lblVreme.Text = "00:00:00";
            // 
            // tmrTimeElapse
            // 
            this.tmrTimeElapse.Enabled = true;
            this.tmrTimeElapse.Interval = 900;
            this.tmrTimeElapse.Tick += new System.EventHandler(this.UpdateTimer);
            // 
            // btnPauza
            // 
            this.btnPauza.Enabled = false;
            this.btnPauza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPauza.ForeColor = System.Drawing.Color.Black;
            this.btnPauza.Location = new System.Drawing.Point(650, 473);
            this.btnPauza.Name = "btnPauza";
            this.btnPauza.Size = new System.Drawing.Size(86, 42);
            this.btnPauza.TabIndex = 4;
            this.btnPauza.Text = "Пауза";
            this.btnPauza.UseVisualStyleBackColor = true;
            this.btnPauza.Click += new System.EventHandler(this.PausaResume);
            // 
            // gbOriginal
            // 
            this.gbOriginal.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.original;
            this.gbOriginal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbOriginal.ForeColor = System.Drawing.Color.White;
            this.gbOriginal.Location = new System.Drawing.Point(536, 69);
            this.gbOriginal.Name = "gbOriginal";
            this.gbOriginal.Size = new System.Drawing.Size(315, 297);
            this.gbOriginal.TabIndex = 0;
            this.gbOriginal.TabStop = false;
            this.gbOriginal.Text = "Оригинална слика";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Help,
            this.Finish,
            this.SledenPoteg});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(914, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Help
            // 
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(62, 20);
            this.Help.Text = "Помош";
            this.Help.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // Finish
            // 
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(90, 20);
            this.Finish.Text = "Комплетирај";
            this.Finish.Click += new System.EventHandler(this.finishToolStripMenuItem_Click);
            // 
            // SledenPoteg
            // 
            this.SledenPoteg.Name = "SledenPoteg";
            this.SledenPoteg.Size = new System.Drawing.Size(92, 20);
            this.SledenPoteg.Text = "Следен потег";
            this.SledenPoteg.Click += new System.EventHandler(this.nextMoveToolStripMenuItem_Click);
            // 
            // frmPuzzleGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 560);
            this.Controls.Add(this.btnPauza);
            this.Controls.Add(this.lblVreme);
            this.Controls.Add(this.lblBrPotezi);
            this.Controls.Add(this.btnIzlezi);
            this.Controls.Add(this.btnPromesaj);
            this.Controls.Add(this.gbOriginal);
            this.Controls.Add(this.gbSlozuvalkaBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPuzzleGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Финки сложувалка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IzlezPoraka);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSlozuvalkaBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion

        private System.Windows.Forms.GroupBox gbSlozuvalkaBox;
        private System.Windows.Forms.GroupBox gbOriginal;
        private System.Windows.Forms.PictureBox pbx3;
        private System.Windows.Forms.PictureBox pbx9;
        private System.Windows.Forms.PictureBox pbx6;
        private System.Windows.Forms.PictureBox pbx2;
        private System.Windows.Forms.PictureBox pbx8;
        private System.Windows.Forms.PictureBox pbx5;
        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.PictureBox pbx7;
        private System.Windows.Forms.PictureBox pbx4;
        private System.Windows.Forms.Button btnPromesaj;
        private System.Windows.Forms.Button btnIzlezi;
        private System.Windows.Forms.Label lblBrPotezi;
        private System.Windows.Forms.Label lblVreme;
        private System.Windows.Forms.Timer tmrTimeElapse;
        private System.Windows.Forms.Button btnPauza;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Help;
        private System.Windows.Forms.ToolStripMenuItem Finish;
        private System.Windows.Forms.ToolStripMenuItem SledenPoteg;
    }
}

