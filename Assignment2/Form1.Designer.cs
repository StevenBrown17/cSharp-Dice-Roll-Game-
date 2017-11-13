namespace Assignment2
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lostLbl = new System.Windows.Forms.Label();
            this.wonLbl = new System.Windows.Forms.Label();
            this.playedLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.rollBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.statsBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.winPercentage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lostLbl);
            this.groupBox1.Controls.Add(this.wonLbl);
            this.groupBox1.Controls.Add(this.playedLbl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Info";
            // 
            // lostLbl
            // 
            this.lostLbl.AutoSize = true;
            this.lostLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lostLbl.Location = new System.Drawing.Point(203, 116);
            this.lostLbl.Name = "lostLbl";
            this.lostLbl.Size = new System.Drawing.Size(17, 17);
            this.lostLbl.TabIndex = 5;
            this.lostLbl.Text = "0";
            // 
            // wonLbl
            // 
            this.wonLbl.AutoSize = true;
            this.wonLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wonLbl.Location = new System.Drawing.Point(203, 78);
            this.wonLbl.Name = "wonLbl";
            this.wonLbl.Size = new System.Drawing.Size(17, 17);
            this.wonLbl.TabIndex = 4;
            this.wonLbl.Text = "0";
            // 
            // playedLbl
            // 
            this.playedLbl.AutoSize = true;
            this.playedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playedLbl.Location = new System.Drawing.Point(203, 40);
            this.playedLbl.Name = "playedLbl";
            this.playedLbl.Size = new System.Drawing.Size(17, 17);
            this.playedLbl.TabIndex = 3;
            this.playedLbl.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of Times Lost:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Times Won:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Times Played:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Enter your guess (1-6):";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(220, 253);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(35, 20);
            this.inputBox.TabIndex = 2;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(81, 321);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(96, 97);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // rollBtn
            // 
            this.rollBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollBtn.Location = new System.Drawing.Point(220, 321);
            this.rollBtn.Name = "rollBtn";
            this.rollBtn.Size = new System.Drawing.Size(75, 23);
            this.rollBtn.TabIndex = 4;
            this.rollBtn.Text = "Roll";
            this.rollBtn.UseVisualStyleBackColor = true;
            this.rollBtn.Click += new System.EventHandler(this.rollBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(220, 394);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 5;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // statsBox
            // 
            this.statsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsBox.Location = new System.Drawing.Point(35, 443);
            this.statsBox.Name = "statsBox";
            this.statsBox.Size = new System.Drawing.Size(439, 157);
            this.statsBox.TabIndex = 6;
            this.statsBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(338, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Win Percentage";
            // 
            // winPercentage
            // 
            this.winPercentage.AutoSize = true;
            this.winPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winPercentage.Location = new System.Drawing.Point(388, 61);
            this.winPercentage.Name = "winPercentage";
            this.winPercentage.Size = new System.Drawing.Size(38, 22);
            this.winPercentage.TabIndex = 8;
            this.winPercentage.Text = "0%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 630);
            this.Controls.Add(this.winPercentage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statsBox);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.rollBtn);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lostLbl;
        private System.Windows.Forms.Label wonLbl;
        private System.Windows.Forms.Label playedLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button rollBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.RichTextBox statsBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label winPercentage;
    }
}

