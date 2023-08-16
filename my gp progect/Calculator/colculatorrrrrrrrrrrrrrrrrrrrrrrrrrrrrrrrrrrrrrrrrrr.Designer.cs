
namespace Calculator
{
    partial class colculatorrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(colculatorrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNm1 = new System.Windows.Forms.TextBox();
            this.txtNm2 = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.bynMultiplay = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.lblResault = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU-ExtB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Первое число:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MingLiU-ExtB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Второе число:";
            // 
            // txtNm1
            // 
            this.txtNm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNm1.Location = new System.Drawing.Point(183, 55);
            this.txtNm1.Name = "txtNm1";
            this.txtNm1.Size = new System.Drawing.Size(127, 29);
            this.txtNm1.TabIndex = 2;
            this.txtNm1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtNm1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txtNm2
            // 
            this.txtNm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNm2.Location = new System.Drawing.Point(183, 100);
            this.txtNm2.Name = "txtNm2";
            this.txtNm2.Size = new System.Drawing.Size(127, 29);
            this.txtNm2.TabIndex = 3;
            this.txtNm2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtNm2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.Aquamarine;
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Miriam Libre", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnPlus.Location = new System.Drawing.Point(16, 196);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(60, 60);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(30, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Результат >>";
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.Aquamarine;
            this.btnMinus.FlatAppearance.BorderSize = 0;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Miriam Libre", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnMinus.Location = new System.Drawing.Point(95, 196);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(60, 60);
            this.btnMinus.TabIndex = 10;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btn_Click);
            // 
            // bynMultiplay
            // 
            this.bynMultiplay.BackColor = System.Drawing.Color.Aquamarine;
            this.bynMultiplay.FlatAppearance.BorderSize = 0;
            this.bynMultiplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bynMultiplay.Font = new System.Drawing.Font("Miriam Libre", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bynMultiplay.Location = new System.Drawing.Point(183, 196);
            this.bynMultiplay.Name = "bynMultiplay";
            this.bynMultiplay.Padding = new System.Windows.Forms.Padding(3, 12, 0, 0);
            this.bynMultiplay.Size = new System.Drawing.Size(60, 60);
            this.bynMultiplay.TabIndex = 11;
            this.bynMultiplay.Text = "*";
            this.bynMultiplay.UseVisualStyleBackColor = false;
            this.bynMultiplay.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.Aquamarine;
            this.btnDivide.FlatAppearance.BorderSize = 0;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("Miriam Libre", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDivide.Location = new System.Drawing.Point(262, 196);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(60, 60);
            this.btnDivide.TabIndex = 12;
            this.btnDivide.Text = ":";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btn_Click);
            // 
            // lblResault
            // 
            this.lblResault.AutoSize = true;
            this.lblResault.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResault.Location = new System.Drawing.Point(218, 339);
            this.lblResault.Name = "lblResault";
            this.lblResault.Size = new System.Drawing.Size(46, 31);
            this.lblResault.TabIndex = 13;
            this.lblResault.Text = "♣";
            // 
            // colculatorrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.lblResault);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.bynMultiplay);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtNm2);
            this.Controls.Add(this.txtNm1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "colculatorrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "colculatorrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNm1;
        private System.Windows.Forms.TextBox txtNm2;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button bynMultiplay;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Label lblResault;
    }
}