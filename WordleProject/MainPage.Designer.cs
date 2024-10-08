namespace WordleProject
{
    partial class MainPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SinglePButton = new System.Windows.Forms.Button();
            this.VSButton = new System.Windows.Forms.Button();
            this.CustomBox = new System.Windows.Forms.TextBox();
            this.CustomLabel = new System.Windows.Forms.Label();
            this.VsStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(435, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Wordle!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(697, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose How You Want to Play!";
            // 
            // SinglePButton
            // 
            this.SinglePButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SinglePButton.Location = new System.Drawing.Point(76, 272);
            this.SinglePButton.Name = "SinglePButton";
            this.SinglePButton.Size = new System.Drawing.Size(344, 91);
            this.SinglePButton.TabIndex = 2;
            this.SinglePButton.Text = "Single Player";
            this.SinglePButton.UseVisualStyleBackColor = true;
            this.SinglePButton.Click += new System.EventHandler(this.SinglePButton_Click);
            // 
            // VSButton
            // 
            this.VSButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VSButton.Location = new System.Drawing.Point(867, 272);
            this.VSButton.Name = "VSButton";
            this.VSButton.Size = new System.Drawing.Size(359, 91);
            this.VSButton.TabIndex = 3;
            this.VSButton.Text = "VS Mode";
            this.VSButton.UseVisualStyleBackColor = true;
            this.VSButton.Click += new System.EventHandler(this.VSButton_Click);
            // 
            // CustomBox
            // 
            this.CustomBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomBox.Location = new System.Drawing.Point(431, 523);
            this.CustomBox.Name = "CustomBox";
            this.CustomBox.Size = new System.Drawing.Size(462, 62);
            this.CustomBox.TabIndex = 4;
            this.CustomBox.Visible = false;
            // 
            // CustomLabel
            // 
            this.CustomLabel.AutoSize = true;
            this.CustomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomLabel.Location = new System.Drawing.Point(249, 367);
            this.CustomLabel.Name = "CustomLabel";
            this.CustomLabel.Size = new System.Drawing.Size(817, 110);
            this.CustomLabel.TabIndex = 5;
            this.CustomLabel.Text = "Enter the Word to be Guessed Below\r\n           (Enter a 5 letter Word)\r\n";
            this.CustomLabel.Visible = false;
            // 
            // VsStart
            // 
            this.VsStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VsStart.Location = new System.Drawing.Point(540, 606);
            this.VsStart.Name = "VsStart";
            this.VsStart.Size = new System.Drawing.Size(237, 58);
            this.VsStart.TabIndex = 6;
            this.VsStart.Text = "Enter";
            this.VsStart.UseVisualStyleBackColor = true;
            this.VsStart.Visible = false;
            this.VsStart.Click += new System.EventHandler(this.VsStart_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 731);
            this.Controls.Add(this.VsStart);
            this.Controls.Add(this.CustomLabel);
            this.Controls.Add(this.CustomBox);
            this.Controls.Add(this.VSButton);
            this.Controls.Add(this.SinglePButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SinglePButton;
        private System.Windows.Forms.Button VSButton;
        private System.Windows.Forms.TextBox CustomBox;
        private System.Windows.Forms.Label CustomLabel;
        private System.Windows.Forms.Button VsStart;
    }
}