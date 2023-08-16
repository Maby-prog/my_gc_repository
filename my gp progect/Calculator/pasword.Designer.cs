
namespace Calculator
{
    partial class pasword
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
            this.butnokpasword = new System.Windows.Forms.Button();
            this.tetboxpasword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Bisque;
            this.label1.Location = new System.Drawing.Point(58, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Запустите рыбок в строку";
            // 
            // butnokpasword
            // 
            this.butnokpasword.BackColor = System.Drawing.Color.LemonChiffon;
            this.butnokpasword.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butnokpasword.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butnokpasword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.butnokpasword.Location = new System.Drawing.Point(100, 117);
            this.butnokpasword.Name = "butnokpasword";
            this.butnokpasword.Size = new System.Drawing.Size(189, 32);
            this.butnokpasword.TabIndex = 1;
            this.butnokpasword.Text = "Ага, я люблю геншин";
            this.butnokpasword.UseVisualStyleBackColor = false;
            // 
            // tetboxpasword
            // 
            this.tetboxpasword.BackColor = System.Drawing.Color.RosyBrown;
            this.tetboxpasword.Location = new System.Drawing.Point(53, 65);
            this.tetboxpasword.Multiline = true;
            this.tetboxpasword.Name = "tetboxpasword";
            this.tetboxpasword.PasswordChar = '*';
            this.tetboxpasword.Size = new System.Drawing.Size(280, 46);
            this.tetboxpasword.TabIndex = 2;
            // 
            // pasword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.tetboxpasword);
            this.Controls.Add(this.butnokpasword);
            this.Controls.Add(this.label1);
            this.Name = "pasword";
            this.Text = "pasword";
            this.Load += new System.EventHandler(this.pasword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butnokpasword;
        private System.Windows.Forms.TextBox tetboxpasword;
    }
}