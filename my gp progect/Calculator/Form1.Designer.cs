
namespace Calculator
{
    partial class Калькулятор
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.LbName1 = new System.Windows.Forms.Label();
            this.btnName1 = new System.Windows.Forms.Button();
            this.LbName2 = new System.Windows.Forms.Label();
            this.LbName3 = new System.Windows.Forms.Label();
            this.btnName2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Serif Pro Light", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(132, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 28);
            this.label1.TabIndex = 0;
            // 
            // LbName1
            // 
            this.LbName1.AutoSize = true;
            this.LbName1.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbName1.Location = new System.Drawing.Point(12, 9);
            this.LbName1.Name = "LbName1";
            this.LbName1.Size = new System.Drawing.Size(117, 40);
            this.LbName1.TabIndex = 1;
            this.LbName1.Text = "Hello :3";
            // 
            // btnName1
            // 
            this.btnName1.BackColor = System.Drawing.Color.Pink;
            this.btnName1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnName1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnName1.Location = new System.Drawing.Point(117, 115);
            this.btnName1.Name = "btnName1";
            this.btnName1.Size = new System.Drawing.Size(86, 43);
            this.btnName1.TabIndex = 3;
            this.btnName1.Text = "Пат";
            this.btnName1.UseVisualStyleBackColor = false;
            this.btnName1.Click += new System.EventHandler(this.btnName1_Click);
            // 
            // LbName2
            // 
            this.LbName2.AutoSize = true;
            this.LbName2.Font = new System.Drawing.Font("Source Serif Pro Light", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbName2.Location = new System.Drawing.Point(144, 174);
            this.LbName2.Name = "LbName2";
            this.LbName2.Size = new System.Drawing.Size(23, 28);
            this.LbName2.TabIndex = 5;
            this.LbName2.Text = "0";
            // 
            // LbName3
            // 
            this.LbName3.AutoSize = true;
            this.LbName3.Font = new System.Drawing.Font("Source Serif Pro Light", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbName3.Location = new System.Drawing.Point(352, 174);
            this.LbName3.Name = "LbName3";
            this.LbName3.Size = new System.Drawing.Size(23, 28);
            this.LbName3.TabIndex = 6;
            this.LbName3.Text = "0";
            // 
            // btnName2
            // 
            this.btnName2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnName2.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnName2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnName2.Location = new System.Drawing.Point(313, 115);
            this.btnName2.Name = "btnName2";
            this.btnName2.Size = new System.Drawing.Size(86, 43);
            this.btnName2.TabIndex = 7;
            this.btnName2.Text = "Пат";
            this.btnName2.UseVisualStyleBackColor = false;
            this.btnName2.Click += new System.EventHandler(this.btnName2_Click);
            // 
            // Калькулятор
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(514, 211);
            this.Controls.Add(this.btnName2);
            this.Controls.Add(this.LbName3);
            this.Controls.Add(this.LbName2);
            this.Controls.Add(this.btnName1);
            this.Controls.Add(this.LbName1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Калькулятор";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbName1;
        private System.Windows.Forms.Button btnName1;
        private System.Windows.Forms.Label LbName2;
        private System.Windows.Forms.Label LbName3;
        private System.Windows.Forms.Button btnName2;
    }
}

