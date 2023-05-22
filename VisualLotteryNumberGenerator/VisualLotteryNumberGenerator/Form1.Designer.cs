namespace VisualLotteryNumberGenerator
{
    partial class VisualLotteryNumberGenerator
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
            this.title = new System.Windows.Forms.Label();
            this.lottoMaxBtn = new System.Windows.Forms.Button();
            this.lotto649Btn = new System.Windows.Forms.Button();
            this.numbersLabel = new System.Windows.Forms.Label();
            this.regenerateBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.randomNumbers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(268, 46);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(284, 24);
            this.title.TabIndex = 0;
            this.title.Text = "Visual Lottery Number Generator";
            // 
            // lottoMaxBtn
            // 
            this.lottoMaxBtn.Location = new System.Drawing.Point(109, 148);
            this.lottoMaxBtn.Name = "lottoMaxBtn";
            this.lottoMaxBtn.Size = new System.Drawing.Size(198, 93);
            this.lottoMaxBtn.TabIndex = 1;
            this.lottoMaxBtn.Text = "Lotto Max";
            this.lottoMaxBtn.UseVisualStyleBackColor = true;
            this.lottoMaxBtn.Click += new System.EventHandler(this.lottoMaxBtn_Click);
            // 
            // lotto649Btn
            // 
            this.lotto649Btn.Location = new System.Drawing.Point(421, 148);
            this.lotto649Btn.Name = "lotto649Btn";
            this.lotto649Btn.Size = new System.Drawing.Size(198, 93);
            this.lotto649Btn.TabIndex = 2;
            this.lotto649Btn.Text = "Lotto 6/49";
            this.lotto649Btn.UseVisualStyleBackColor = true;
            this.lotto649Btn.Click += new System.EventHandler(this.lotto649Btn_Click);
            // 
            // numbersLabel
            // 
            this.numbersLabel.AutoSize = true;
            this.numbersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbersLabel.Location = new System.Drawing.Point(361, 83);
            this.numbersLabel.Name = "numbersLabel";
            this.numbersLabel.Size = new System.Drawing.Size(73, 20);
            this.numbersLabel.TabIndex = 4;
            this.numbersLabel.Text = "Numbers";
            this.numbersLabel.Visible = false;
            // 
            // regenerateBtn
            // 
            this.regenerateBtn.Location = new System.Drawing.Point(282, 170);
            this.regenerateBtn.Name = "regenerateBtn";
            this.regenerateBtn.Size = new System.Drawing.Size(201, 44);
            this.regenerateBtn.TabIndex = 5;
            this.regenerateBtn.Text = "Generate New Numbers";
            this.regenerateBtn.UseVisualStyleBackColor = true;
            this.regenerateBtn.Visible = false;
            this.regenerateBtn.Click += new System.EventHandler(this.regenerateBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(282, 260);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(201, 44);
            this.backBtn.TabIndex = 6;
            this.backBtn.Text = "Return to Lotto Selection";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Visible = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // randomNumbers
            // 
            this.randomNumbers.AutoSize = true;
            this.randomNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomNumbers.Location = new System.Drawing.Point(329, 103);
            this.randomNumbers.Name = "randomNumbers";
            this.randomNumbers.Size = new System.Drawing.Size(143, 18);
            this.randomNumbers.TabIndex = 7;
            this.randomNumbers.Text = "Lotto Numbers Here";
            this.randomNumbers.Visible = false;
            // 
            // VisualLotteryNumberGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.randomNumbers);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.regenerateBtn);
            this.Controls.Add(this.numbersLabel);
            this.Controls.Add(this.lotto649Btn);
            this.Controls.Add(this.lottoMaxBtn);
            this.Controls.Add(this.title);
            this.Name = "VisualLotteryNumberGenerator";
            this.Text = "Visual Lottery Number Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button lottoMaxBtn;
        private System.Windows.Forms.Button lotto649Btn;
        private System.Windows.Forms.Label numbersLabel;
        private System.Windows.Forms.Button regenerateBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label randomNumbers;
    }
}

