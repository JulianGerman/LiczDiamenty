﻿namespace diamenty0
{
    partial class Level1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Minutnik = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.wynik = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.znak = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1024, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "graj";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(0, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // Minutnik
            // 
            this.Minutnik.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold);
            this.Minutnik.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Minutnik.Location = new System.Drawing.Point(402, 9);
            this.Minutnik.Name = "Minutnik";
            this.Minutnik.Size = new System.Drawing.Size(200, 150);
            this.Minutnik.TabIndex = 2;
            this.Minutnik.Text = "00:45";
            this.Minutnik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(60, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 72);
            this.label4.TabIndex = 3;
            this.label4.Text = "MASZ : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(742, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 150);
            this.label5.TabIndex = 4;
            this.label5.Text = "MUSISZ UZYSKAĆ : 20";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wynik
            // 
            this.wynik.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold);
            this.wynik.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.wynik.Location = new System.Drawing.Point(211, 15);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(124, 72);
            this.wynik.TabIndex = 5;
            this.wynik.Text = "0";
            this.wynik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wynik.TextChanged += new System.EventHandler(this.wynik_TextChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(43, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 113);
            this.label6.TabIndex = 6;
            this.label6.Text = "AKTUALNY ZNAK :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // znak
            // 
            this.znak.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold);
            this.znak.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.znak.Location = new System.Drawing.Point(224, 87);
            this.znak.Name = "znak";
            this.znak.Size = new System.Drawing.Size(124, 72);
            this.znak.TabIndex = 7;
            this.znak.Text = "+";
            this.znak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.znak);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Minutnik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Level1";
            this.Text = "Level1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Level1_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Level1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Level1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Minutnik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label wynik;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label znak;
    }
}