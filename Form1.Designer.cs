namespace RockPaperScissor
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
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.btnPlayer1Rock = new System.Windows.Forms.Button();
            this.btnPlayer1Paper = new System.Windows.Forms.Button();
            this.btnPlayer1Scissor = new System.Windows.Forms.Button();
            this.btnPlayer2Scissor = new System.Windows.Forms.Button();
            this.btnPlayer2Paper = new System.Windows.Forms.Button();
            this.btnPlayer2Rock = new System.Windows.Forms.Button();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkComputer = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(125, 101);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(217, 140);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // btnPlayer1Rock
            // 
            this.btnPlayer1Rock.Location = new System.Drawing.Point(22, 284);
            this.btnPlayer1Rock.Name = "btnPlayer1Rock";
            this.btnPlayer1Rock.Size = new System.Drawing.Size(111, 62);
            this.btnPlayer1Rock.TabIndex = 2;
            this.btnPlayer1Rock.Tag = "0";
            this.btnPlayer1Rock.Text = "Rock";
            this.btnPlayer1Rock.UseVisualStyleBackColor = true;
            this.btnPlayer1Rock.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPlayer1Paper
            // 
            this.btnPlayer1Paper.Location = new System.Drawing.Point(174, 284);
            this.btnPlayer1Paper.Name = "btnPlayer1Paper";
            this.btnPlayer1Paper.Size = new System.Drawing.Size(111, 62);
            this.btnPlayer1Paper.TabIndex = 3;
            this.btnPlayer1Paper.Tag = "1";
            this.btnPlayer1Paper.Text = "Paper";
            this.btnPlayer1Paper.UseVisualStyleBackColor = true;
            this.btnPlayer1Paper.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPlayer1Scissor
            // 
            this.btnPlayer1Scissor.Location = new System.Drawing.Point(331, 284);
            this.btnPlayer1Scissor.Name = "btnPlayer1Scissor";
            this.btnPlayer1Scissor.Size = new System.Drawing.Size(111, 62);
            this.btnPlayer1Scissor.TabIndex = 4;
            this.btnPlayer1Scissor.Tag = "2";
            this.btnPlayer1Scissor.Text = "Scissor";
            this.btnPlayer1Scissor.UseVisualStyleBackColor = true;
            this.btnPlayer1Scissor.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPlayer2Scissor
            // 
            this.btnPlayer2Scissor.Location = new System.Drawing.Point(1069, 284);
            this.btnPlayer2Scissor.Name = "btnPlayer2Scissor";
            this.btnPlayer2Scissor.Size = new System.Drawing.Size(111, 62);
            this.btnPlayer2Scissor.TabIndex = 8;
            this.btnPlayer2Scissor.Tag = "2";
            this.btnPlayer2Scissor.Text = "Scissor";
            this.btnPlayer2Scissor.UseVisualStyleBackColor = true;
            this.btnPlayer2Scissor.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPlayer2Paper
            // 
            this.btnPlayer2Paper.Location = new System.Drawing.Point(912, 284);
            this.btnPlayer2Paper.Name = "btnPlayer2Paper";
            this.btnPlayer2Paper.Size = new System.Drawing.Size(111, 62);
            this.btnPlayer2Paper.TabIndex = 7;
            this.btnPlayer2Paper.Tag = "1";
            this.btnPlayer2Paper.Text = "Paper";
            this.btnPlayer2Paper.UseVisualStyleBackColor = true;
            this.btnPlayer2Paper.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPlayer2Rock
            // 
            this.btnPlayer2Rock.Location = new System.Drawing.Point(760, 284);
            this.btnPlayer2Rock.Name = "btnPlayer2Rock";
            this.btnPlayer2Rock.Size = new System.Drawing.Size(111, 62);
            this.btnPlayer2Rock.TabIndex = 6;
            this.btnPlayer2Rock.Tag = "0";
            this.btnPlayer2Rock.Text = "Rock";
            this.btnPlayer2Rock.UseVisualStyleBackColor = true;
            this.btnPlayer2Rock.Click += new System.EventHandler(this.button2_Click);
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(863, 101);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(217, 140);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 5;
            this.pb2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "P1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(943, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 35);
            this.label2.TabIndex = 10;
            this.label2.Text = "P2";
            // 
            // chkComputer
            // 
            this.chkComputer.AutoSize = true;
            this.chkComputer.Checked = true;
            this.chkComputer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkComputer.Location = new System.Drawing.Point(928, 409);
            this.chkComputer.Name = "chkComputer";
            this.chkComputer.Size = new System.Drawing.Size(87, 20);
            this.chkComputer.TabIndex = 11;
            this.chkComputer.Text = "Computer";
            this.chkComputer.UseVisualStyleBackColor = true;
            this.chkComputer.CheckedChanged += new System.EventHandler(this.chkComputer_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 580);
            this.Controls.Add(this.chkComputer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlayer2Scissor);
            this.Controls.Add(this.btnPlayer2Paper);
            this.Controls.Add(this.btnPlayer2Rock);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.btnPlayer1Scissor);
            this.Controls.Add(this.btnPlayer1Paper);
            this.Controls.Add(this.btnPlayer1Rock);
            this.Controls.Add(this.pb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Button btnPlayer1Rock;
        private System.Windows.Forms.Button btnPlayer1Paper;
        private System.Windows.Forms.Button btnPlayer1Scissor;
        private System.Windows.Forms.Button btnPlayer2Scissor;
        private System.Windows.Forms.Button btnPlayer2Paper;
        private System.Windows.Forms.Button btnPlayer2Rock;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkComputer;
    }
}

