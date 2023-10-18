namespace WhoWantsToBeAMillionaire
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnHalf = new Button();
            btnHelpAudience = new Button();
            btnCallFriend = new Button();
            btnTakeMoney = new Button();
            picBox = new PictureBox();
            btnAnswer1 = new Button();
            btnAnswer2 = new Button();
            btnAnswer3 = new Button();
            btnAnswer4 = new Button();
            lblQuestionText = new Label();
            lstLevel = new ListBox();
            btnChangeQuestion = new Button();
            btnRightToMakeMistake = new Button();
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            SuspendLayout();
            // 
            // btnHalf
            // 
            btnHalf.Location = new Point(12, 12);
            btnHalf.Name = "btnHalf";
            btnHalf.Size = new Size(128, 23);
            btnHalf.TabIndex = 0;
            btnHalf.Text = "50/50";
            btnHalf.UseVisualStyleBackColor = true;
            btnHalf.Click += btnHalf_Click;
            // 
            // btnHelpAudience
            // 
            btnHelpAudience.Location = new Point(12, 41);
            btnHelpAudience.Name = "btnHelpAudience";
            btnHelpAudience.Size = new Size(128, 23);
            btnHelpAudience.TabIndex = 1;
            btnHelpAudience.Text = "Помощь зала";
            btnHelpAudience.UseVisualStyleBackColor = true;
            btnHelpAudience.Click += btnHelpAudience_Click;
            // 
            // btnCallFriend
            // 
            btnCallFriend.Location = new Point(12, 70);
            btnCallFriend.Name = "btnCallFriend";
            btnCallFriend.Size = new Size(128, 23);
            btnCallFriend.TabIndex = 2;
            btnCallFriend.Text = "Звонок другу";
            btnCallFriend.UseVisualStyleBackColor = true;
            btnCallFriend.Click += btnCallFriend_Click;
            // 
            // btnTakeMoney
            // 
            btnTakeMoney.Location = new Point(12, 177);
            btnTakeMoney.Name = "btnTakeMoney";
            btnTakeMoney.Size = new Size(128, 23);
            btnTakeMoney.TabIndex = 3;
            btnTakeMoney.Text = "Забрать деньги";
            btnTakeMoney.UseVisualStyleBackColor = true;
            btnTakeMoney.Click += btnTakeMoney_Click;
            // 
            // picBox
            // 
            picBox.Image = Properties.Resources.picture;
            picBox.Location = new Point(188, 12);
            picBox.Name = "picBox";
            picBox.Size = new Size(449, 277);
            picBox.TabIndex = 4;
            picBox.TabStop = false;
            // 
            // btnAnswer1
            // 
            btnAnswer1.Location = new Point(12, 463);
            btnAnswer1.Name = "btnAnswer1";
            btnAnswer1.Size = new Size(377, 23);
            btnAnswer1.TabIndex = 5;
            btnAnswer1.Tag = "1";
            btnAnswer1.Text = "btnAnswer1";
            btnAnswer1.UseVisualStyleBackColor = true;
            btnAnswer1.Click += btnAnswer1_Click;
            // 
            // btnAnswer2
            // 
            btnAnswer2.Location = new Point(12, 492);
            btnAnswer2.Name = "btnAnswer2";
            btnAnswer2.Size = new Size(377, 23);
            btnAnswer2.TabIndex = 6;
            btnAnswer2.Tag = "2";
            btnAnswer2.Text = "btnAnswer2";
            btnAnswer2.UseVisualStyleBackColor = true;
            btnAnswer2.Click += btnAnswer2_Click;
            // 
            // btnAnswer3
            // 
            btnAnswer3.Location = new Point(395, 463);
            btnAnswer3.Name = "btnAnswer3";
            btnAnswer3.Size = new Size(416, 23);
            btnAnswer3.TabIndex = 7;
            btnAnswer3.Tag = "3";
            btnAnswer3.Text = "btnAnswer3";
            btnAnswer3.UseVisualStyleBackColor = true;
            btnAnswer3.Click += btnAnswer3_Click;
            // 
            // btnAnswer4
            // 
            btnAnswer4.Location = new Point(395, 492);
            btnAnswer4.Name = "btnAnswer4";
            btnAnswer4.Size = new Size(416, 23);
            btnAnswer4.TabIndex = 8;
            btnAnswer4.Tag = "4";
            btnAnswer4.Text = "btnAnswer4";
            btnAnswer4.UseVisualStyleBackColor = true;
            btnAnswer4.Click += btnAnswer4_Click;
            // 
            // lblQuestionText
            // 
            lblQuestionText.AutoEllipsis = true;
            lblQuestionText.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuestionText.Location = new Point(112, 303);
            lblQuestionText.MaximumSize = new Size(800, 200);
            lblQuestionText.MinimumSize = new Size(200, 10);
            lblQuestionText.Name = "lblQuestionText";
            lblQuestionText.Size = new Size(552, 146);
            lblQuestionText.TabIndex = 9;
            lblQuestionText.Text = "lblQuestionText";
            lblQuestionText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lstLevel
            // 
            lstLevel.DrawMode = DrawMode.OwnerDrawFixed;
            lstLevel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstLevel.FormattingEnabled = true;
            lstLevel.ItemHeight = 25;
            lstLevel.Items.AddRange(new object[] { "3 000 000", "1 500 000", "   800 000", "   400 000", "   200 000", "   100 000", "     50 000", "     25 000", "     15 000", "     10 000", "       5 000", "       3 000", "       2 000", "       1 000", "          500" });
            lstLevel.Location = new Point(670, 12);
            lstLevel.Name = "lstLevel";
            lstLevel.Size = new Size(117, 379);
            lstLevel.TabIndex = 10;
            lstLevel.DrawItem += lstLevel_DrawItem;
            // 
            // btnChangeQuestion
            // 
            btnChangeQuestion.Location = new Point(12, 100);
            btnChangeQuestion.Name = "btnChangeQuestion";
            btnChangeQuestion.Size = new Size(128, 23);
            btnChangeQuestion.TabIndex = 11;
            btnChangeQuestion.Text = "Замена вопроса";
            btnChangeQuestion.UseVisualStyleBackColor = true;
            btnChangeQuestion.Click += btnChangeQuestion_Click;
            // 
            // btnRightToMakeMistake
            // 
            btnRightToMakeMistake.Location = new Point(12, 129);
            btnRightToMakeMistake.Name = "btnRightToMakeMistake";
            btnRightToMakeMistake.Size = new Size(128, 23);
            btnRightToMakeMistake.TabIndex = 12;
            btnRightToMakeMistake.Text = "Право на ошибку";
            btnRightToMakeMistake.UseVisualStyleBackColor = true;
            btnRightToMakeMistake.Click += btnRightToMakeMistake_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 549);
            Controls.Add(btnRightToMakeMistake);
            Controls.Add(btnChangeQuestion);
            Controls.Add(lstLevel);
            Controls.Add(lblQuestionText);
            Controls.Add(btnAnswer4);
            Controls.Add(btnAnswer3);
            Controls.Add(btnAnswer2);
            Controls.Add(btnAnswer1);
            Controls.Add(picBox);
            Controls.Add(btnTakeMoney);
            Controls.Add(btnCallFriend);
            Controls.Add(btnHelpAudience);
            Controls.Add(btnHalf);
            Name = "Form1";
            Text = "Кто хочет стать миллионером";
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnHalf;
        private Button btnHelpAudience;
        private Button btnCallFriend;
        private Button btnTakeMoney;
        private PictureBox picBox;
        private Button btnAnswer1;
        private Button btnAnswer2;
        private Button btnAnswer3;
        private Button btnAnswer4;
        private Label lblQuestionText;
        private ListBox lstLevel;
        private Button btnChangeQuestion;
        private Button btnRightToMakeMistake;
    }
}