namespace Part_8._5___Hangman_Lite
{
    partial class frmHangman
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.imgHang = new System.Windows.Forms.PictureBox();
            this.lblWord = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lstGuessedLetters = new System.Windows.Forms.ListBox();
            this.lblGuessedLetters = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgHang)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(293, 26);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Welcome to Hangman Lite";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(12, 35);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(314, 13);
            this.lblInstructions.TabIndex = 2;
            this.lblInstructions.Text = "Enter a letter to reveal the secret word. 3 Strikes and you are out!";
            // 
            // imgHang
            // 
            this.imgHang.Image = global::Part_8._5___Hangman_Lite.Properties.Resources.hangman_empty;
            this.imgHang.Location = new System.Drawing.Point(12, 51);
            this.imgHang.Name = "imgHang";
            this.imgHang.Size = new System.Drawing.Size(331, 302);
            this.imgHang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHang.TabIndex = 3;
            this.imgHang.TabStop = false;
            // 
            // lblWord
            // 
            this.lblWord.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(23, 379);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(483, 62);
            this.lblWord.TabIndex = 4;
            this.lblWord.Text = "- - - - - - - -";
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(374, 333);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(48, 20);
            this.txtGuess.TabIndex = 5;
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(428, 333);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 20);
            this.btnGuess.TabIndex = 6;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            // 
            // lstGuessedLetters
            // 
            this.lstGuessedLetters.FormattingEnabled = true;
            this.lstGuessedLetters.Location = new System.Drawing.Point(374, 141);
            this.lstGuessedLetters.Name = "lstGuessedLetters";
            this.lstGuessedLetters.Size = new System.Drawing.Size(129, 186);
            this.lstGuessedLetters.TabIndex = 7;
            // 
            // lblGuessedLetters
            // 
            this.lblGuessedLetters.AutoSize = true;
            this.lblGuessedLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessedLetters.Location = new System.Drawing.Point(377, 114);
            this.lblGuessedLetters.Name = "lblGuessedLetters";
            this.lblGuessedLetters.Size = new System.Drawing.Size(126, 24);
            this.lblGuessedLetters.TabIndex = 8;
            this.lblGuessedLetters.Text = "Used Letters";
            // 
            // frmHangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 450);
            this.Controls.Add(this.lblGuessedLetters);
            this.Controls.Add(this.lstGuessedLetters);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.imgHang);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmHangman";
            this.Text = "Hangman";
            ((System.ComponentModel.ISupportInitialize)(this.imgHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.PictureBox imgHang;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.ListBox lstGuessedLetters;
        private System.Windows.Forms.Label lblGuessedLetters;
    }
}

