
namespace _476_Project_2
{
    partial class Length_Converter
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
            this.label12 = new System.Windows.Forms.Label();
            this.bruhsoundhashtag2 = new System.Windows.Forms.TextBox();
            this.A_LIST = new System.Windows.Forms.ComboBox();
            this.emoji_45 = new System.Windows.Forms.Button();
            this.numbers = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numbers)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(135, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Kilometer";
            // 
            // bruhsoundhashtag2
            // 
            this.bruhsoundhashtag2.Location = new System.Drawing.Point(29, 58);
            this.bruhsoundhashtag2.Name = "bruhsoundhashtag2";
            this.bruhsoundhashtag2.ReadOnly = true;
            this.bruhsoundhashtag2.Size = new System.Drawing.Size(100, 20);
            this.bruhsoundhashtag2.TabIndex = 2;
            this.bruhsoundhashtag2.Text = "NaN";
            // 
            // A_LIST
            // 
            this.A_LIST.FormattingEnabled = true;
            this.A_LIST.Items.AddRange(new object[] {
            "Mile",
            "Yard",
            "Foot"});
            this.A_LIST.Location = new System.Drawing.Point(135, 58);
            this.A_LIST.Name = "A_LIST";
            this.A_LIST.Size = new System.Drawing.Size(121, 21);
            this.A_LIST.TabIndex = 3;
            this.A_LIST.Text = "Mile";
            // 
            // emoji_45
            // 
            this.emoji_45.Location = new System.Drawing.Point(95, 85);
            this.emoji_45.Name = "emoji_45";
            this.emoji_45.Size = new System.Drawing.Size(75, 23);
            this.emoji_45.TabIndex = 4;
            this.emoji_45.Text = "Convert";
            this.emoji_45.UseVisualStyleBackColor = true;
            this.emoji_45.Click += new System.EventHandler(this.emoji_45_Click);
            // 
            // numbers
            // 
            this.numbers.DecimalPlaces = 9;
            this.numbers.Location = new System.Drawing.Point(29, 32);
            this.numbers.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numbers.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numbers.Name = "numbers";
            this.numbers.Size = new System.Drawing.Size(100, 20);
            this.numbers.TabIndex = 5;
            // 
            // Length_Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 126);
            this.Controls.Add(this.numbers);
            this.Controls.Add(this.emoji_45);
            this.Controls.Add(this.A_LIST);
            this.Controls.Add(this.bruhsoundhashtag2);
            this.Controls.Add(this.label12);
            this.Name = "Length_Converter";
            this.Text = "Length Converter";
            ((System.ComponentModel.ISupportInitialize)(this.numbers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox bruhsoundhashtag2;
        private System.Windows.Forms.ComboBox A_LIST;
        private System.Windows.Forms.Button emoji_45;
        private System.Windows.Forms.NumericUpDown numbers;
    }
}

