
namespace Calculator
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblLinkCalculator = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pivot Classic", 23F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(74, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро\r\nпожаловать!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLinkCalculator
            // 
            this.lblLinkCalculator.ActiveLinkColor = System.Drawing.Color.MediumSpringGreen;
            this.lblLinkCalculator.AutoSize = true;
            this.lblLinkCalculator.Font = new System.Drawing.Font("PMingLiU-ExtB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLinkCalculator.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblLinkCalculator.Location = new System.Drawing.Point(116, 452);
            this.lblLinkCalculator.Name = "lblLinkCalculator";
            this.lblLinkCalculator.Size = new System.Drawing.Size(151, 27);
            this.lblLinkCalculator.TabIndex = 1;
            this.lblLinkCalculator.TabStop = true;
            this.lblLinkCalculator.Text = "Калькулятор";
            this.lblLinkCalculator.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkCalculator_LinkClicked_1);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(384, 531);
            this.Controls.Add(this.lblLinkCalculator);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblLinkCalculator;
    }
}