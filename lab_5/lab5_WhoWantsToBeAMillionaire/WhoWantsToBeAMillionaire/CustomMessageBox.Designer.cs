namespace WhoWantsToBeAMillionaire
{
    partial class CustomMessageBox
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
            labelCountdown = new Label();
            SuspendLayout();
            // 
            // labelCountdown
            // 
            labelCountdown.AutoSize = true;
            labelCountdown.Location = new Point(87, 42);
            labelCountdown.Name = "labelCountdown";
            labelCountdown.Size = new Size(106, 15);
            labelCountdown.TabIndex = 0;
            labelCountdown.Text = "Обратный отсчет:";
            // 
            // CustomMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 102);
            Controls.Add(labelCountdown);
            Name = "CustomMessageBox";
            Text = "Звонок другу";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCountdown;
    }
}