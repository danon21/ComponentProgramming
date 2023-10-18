namespace WhoWantsToBeAMillionaire
{
    partial class SelectAmount
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
            listBox = new ListBox();
            label1 = new Label();
            selectButton = new Button();
            SuspendLayout();
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(54, 38);
            listBox.Name = "listBox";
            listBox.Size = new Size(186, 349);
            listBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 9);
            label1.Name = "label1";
            label1.Size = new Size(181, 15);
            label1.TabIndex = 1;
            label1.Text = "Выберите несгораемую сумму:";
            // 
            // selectButton
            // 
            selectButton.Location = new Point(54, 396);
            selectButton.Name = "selectButton";
            selectButton.Size = new Size(186, 23);
            selectButton.TabIndex = 2;
            selectButton.Text = "Выбрать";
            selectButton.UseVisualStyleBackColor = true;
            selectButton.Click += selectButton_Click;
            // 
            // SelectAmount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 441);
            Controls.Add(selectButton);
            Controls.Add(label1);
            Controls.Add(listBox);
            Name = "SelectAmount";
            Text = "Несгораемая сумма";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox;
        private Label label1;
        private Button selectButton;
    }
}