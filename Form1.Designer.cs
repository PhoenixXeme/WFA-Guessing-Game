namespace WFA_GuessingGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_hl = new System.Windows.Forms.Label();
            this.tb_guess = new System.Windows.Forms.TextBox();
            this.btn_guess = new System.Windows.Forms.Button();
            this.lbl_attempts = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to my guessing game";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "A random number has been generated";
            // 
            // lbl_hl
            // 
            this.lbl_hl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_hl.AutoSize = true;
            this.lbl_hl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hl.Location = new System.Drawing.Point(154, 218);
            this.lbl_hl.MinimumSize = new System.Drawing.Size(238, 37);
            this.lbl_hl.Name = "lbl_hl";
            this.lbl_hl.Size = new System.Drawing.Size(238, 37);
            this.lbl_hl.TabIndex = 2;
            this.lbl_hl.Text = "Enter a number";
            this.lbl_hl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_guess
            // 
            this.tb_guess.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tb_guess.Location = new System.Drawing.Point(186, 310);
            this.tb_guess.Name = "tb_guess";
            this.tb_guess.Size = new System.Drawing.Size(164, 20);
            this.tb_guess.TabIndex = 3;
            // 
            // btn_guess
            // 
            this.btn_guess.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guess.Location = new System.Drawing.Point(216, 336);
            this.btn_guess.Name = "btn_guess";
            this.btn_guess.Size = new System.Drawing.Size(108, 40);
            this.btn_guess.TabIndex = 4;
            this.btn_guess.Text = "Enter";
            this.btn_guess.UseVisualStyleBackColor = true;
            this.btn_guess.Click += new System.EventHandler(this.btn_guess_Click);
            // 
            // lbl_attempts
            // 
            this.lbl_attempts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_attempts.AutoSize = true;
            this.lbl_attempts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_attempts.Location = new System.Drawing.Point(36, 416);
            this.lbl_attempts.Name = "lbl_attempts";
            this.lbl_attempts.Size = new System.Drawing.Size(35, 24);
            this.lbl_attempts.TabIndex = 5;
            this.lbl_attempts.Text = "0/6";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Attempts";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(553, 449);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_attempts);
            this.Controls.Add(this.btn_guess);
            this.Controls.Add(this.tb_guess);
            this.Controls.Add(this.lbl_hl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Guessing Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_hl;
        private System.Windows.Forms.TextBox tb_guess;
        private System.Windows.Forms.Button btn_guess;
        private System.Windows.Forms.Label lbl_attempts;
        private System.Windows.Forms.Label label3;
    }
}

