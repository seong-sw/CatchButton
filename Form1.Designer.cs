namespace CatchButton
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
            movingButton = new Button();
            restartButton = new Button();
            SuspendLayout();
            // 
            // movingButton
            // 
            movingButton.Font = new Font("Pretendard JP Variable SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 128);
            movingButton.Location = new Point(12, 12);
            movingButton.Name = "movingButton";
            movingButton.Size = new Size(200, 200);
            movingButton.TabIndex = 0;
            movingButton.Text = "나를 잡아줘!";
            movingButton.UseVisualStyleBackColor = true;
            movingButton.MouseClick += movingButton_MouseClick;
            movingButton.MouseEnter += movingButton_MouseEnter;
            // 
            // restartButton
            // 
            restartButton.Location = new Point(1160, 623);
            restartButton.Name = "restartButton";
            restartButton.Size = new Size(86, 34);
            restartButton.TabIndex = 1;
            restartButton.Text = "Restart";
            restartButton.UseVisualStyleBackColor = true;
            restartButton.MouseClick += restartButton_MouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 669);
            Controls.Add(restartButton);
            Controls.Add(movingButton);
            Name = "Form1";
            Text = "Button Location: (12, 12), Score: 1000";
            ResumeLayout(false);
        }

        #endregion

        private Button movingButton;
        private Button restartButton;
    }
}
