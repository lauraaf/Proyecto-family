﻿
namespace CLIENTE
{
    partial class Partida
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
            this.tablero = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tablero
            // 
            this.tablero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablero.Location = new System.Drawing.Point(0, 0);
            this.tablero.Name = "tablero";
            this.tablero.Size = new System.Drawing.Size(800, 450);
            this.tablero.TabIndex = 0;
            this.tablero.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Partida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tablero);
            this.Name = "Partida";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Partida_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tablero;
    }
}