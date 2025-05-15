namespace Rock_Paper_Scissor
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
            lblComputer = new Label();
            lblUser = new Label();
            btnRock = new Button();
            btnPaper = new Button();
            btnScissor = new Button();
            lblUserWin = new Label();
            lblComputerWin = new Label();
            SuspendLayout();
            // 
            // lblComputer
            // 
            lblComputer.AutoSize = true;
            lblComputer.Location = new Point(204, 54);
            lblComputer.Name = "lblComputer";
            lblComputer.Size = new Size(0, 15);
            lblComputer.TabIndex = 0;
            lblComputer.Click += lblComputer_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(196, 250);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(0, 15);
            lblUser.TabIndex = 1;
            // 
            // btnRock
            // 
            btnRock.Location = new Point(62, 374);
            btnRock.Name = "btnRock";
            btnRock.Size = new Size(75, 64);
            btnRock.TabIndex = 2;
            btnRock.Text = "Rock";
            btnRock.UseVisualStyleBackColor = true;
            btnRock.Click += User_Click;
            // 
            // btnPaper
            // 
            btnPaper.Location = new Point(204, 374);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(75, 64);
            btnPaper.TabIndex = 3;
            btnPaper.Text = "Paper";
            btnPaper.UseVisualStyleBackColor = true;
            btnPaper.Click += User_Click;
            // 
            // btnScissor
            // 
            btnScissor.Location = new Point(342, 374);
            btnScissor.Name = "btnScissor";
            btnScissor.Size = new Size(75, 64);
            btnScissor.TabIndex = 4;
            btnScissor.Text = "Scissor";
            btnScissor.UseVisualStyleBackColor = true;
            btnScissor.Click += User_Click;
            // 
            // lblUserWin
            // 
            lblUserWin.AutoSize = true;
            lblUserWin.Location = new Point(507, 472);
            lblUserWin.Name = "lblUserWin";
            lblUserWin.Size = new Size(0, 15);
            lblUserWin.TabIndex = 5;
            // 
            // lblComputerWin
            // 
            lblComputerWin.AutoSize = true;
            lblComputerWin.Location = new Point(507, 54);
            lblComputerWin.Name = "lblComputerWin";
            lblComputerWin.Size = new Size(0, 15);
            lblComputerWin.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 548);
            Controls.Add(lblComputerWin);
            Controls.Add(lblUserWin);
            Controls.Add(btnScissor);
            Controls.Add(btnPaper);
            Controls.Add(btnRock);
            Controls.Add(lblUser);
            Controls.Add(lblComputer);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblComputer;
        private Label lblUser;
        private Button btnRock;
        private Button btnPaper;
        private Button btnScissor;
        private Label lblUserWin;
        private Label lblComputerWin;
    }
}
