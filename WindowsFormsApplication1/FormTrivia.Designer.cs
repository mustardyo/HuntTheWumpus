namespace WindowsFormsApplication1
{
    partial class FormTrivia
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
            this.components = new System.ComponentModel.Container();
            this.Answer2 = new System.Windows.Forms.Button();
            this.Answer1 = new System.Windows.Forms.Button();
            this.Answer3 = new System.Windows.Forms.Button();
            this.Answer4 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.qLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.questionDisplay = new System.Windows.Forms.Label();
            this.ScoreDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Answer2
            // 
            this.Answer2.Location = new System.Drawing.Point(610, 376);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(415, 75);
            this.Answer2.TabIndex = 1;
            this.Answer2.Text = "Answer 2";
            this.Answer2.UseVisualStyleBackColor = true;
            this.Answer2.Click += new System.EventHandler(this.button1_Click);
            // 
            // Answer1
            // 
            this.Answer1.Location = new System.Drawing.Point(59, 376);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(415, 75);
            this.Answer1.TabIndex = 2;
            this.Answer1.Text = "Answer 1";
            this.Answer1.UseVisualStyleBackColor = true;
            this.Answer1.Click += new System.EventHandler(this.Answer1_Click);
            // 
            // Answer3
            // 
            this.Answer3.Location = new System.Drawing.Point(59, 524);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(415, 75);
            this.Answer3.TabIndex = 3;
            this.Answer3.Text = "Answer 3";
            this.Answer3.UseVisualStyleBackColor = true;
            this.Answer3.Click += new System.EventHandler(this.Answer3_Click);
            // 
            // Answer4
            // 
            this.Answer4.Location = new System.Drawing.Point(610, 524);
            this.Answer4.Name = "Answer4";
            this.Answer4.Size = new System.Drawing.Size(415, 75);
            this.Answer4.TabIndex = 4;
            this.Answer4.Text = "Answer 4";
            this.Answer4.UseVisualStyleBackColor = true;
            this.Answer4.Click += new System.EventHandler(this.Answer4_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(98, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(98, 4);
            // 
            // qLabel
            // 
            this.qLabel.AutoSize = true;
            this.qLabel.Location = new System.Drawing.Point(29, 126);
            this.qLabel.Name = "qLabel";
            this.qLabel.Size = new System.Drawing.Size(130, 32);
            this.qLabel.TabIndex = 5;
            this.qLabel.Text = "Question";
            this.qLabel.Click += new System.EventHandler(this.qLabel_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(823, 65);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(89, 32);
            this.scoreLabel.TabIndex = 8;
            this.scoreLabel.Text = "Score";
            // 
            // questionDisplay
            // 
            this.questionDisplay.AutoSize = true;
            this.questionDisplay.Location = new System.Drawing.Point(29, 219);
            this.questionDisplay.Name = "questionDisplay";
            this.questionDisplay.Size = new System.Drawing.Size(199, 32);
            this.questionDisplay.TabIndex = 9;
            this.questionDisplay.Text = "loadQuestions";
            this.questionDisplay.Click += new System.EventHandler(this.label1_Click);
            // 
            // ScoreDisplay
            // 
            this.ScoreDisplay.AutoSize = true;
            this.ScoreDisplay.Location = new System.Drawing.Point(918, 65);
            this.ScoreDisplay.Name = "ScoreDisplay";
            this.ScoreDisplay.Size = new System.Drawing.Size(31, 32);
            this.ScoreDisplay.TabIndex = 10;
            this.ScoreDisplay.Text = "0";
            this.ScoreDisplay.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // FormTrivia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1671, 753);
            this.Controls.Add(this.ScoreDisplay);
            this.Controls.Add(this.questionDisplay);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.qLabel);
            this.Controls.Add(this.Answer4);
            this.Controls.Add(this.Answer3);
            this.Controls.Add(this.Answer1);
            this.Controls.Add(this.Answer2);
            this.Name = "FormTrivia";
            this.Text = "ScoreDisplay";
            this.Load += new System.EventHandler(this.FormTrivia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Answer2;
        private System.Windows.Forms.Button Answer1;
        private System.Windows.Forms.Button Answer3;
        private System.Windows.Forms.Button Answer4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label qLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label questionDisplay;
        private System.Windows.Forms.Label ScoreDisplay;
    }
}

