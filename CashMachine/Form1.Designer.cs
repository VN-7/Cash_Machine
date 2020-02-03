namespace Task_6
{
    partial class FrmCashMachine
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
            this.cmdBalance = new System.Windows.Forms.Button();
            this.cmdWithdraw = new System.Windows.Forms.Button();
            this.cmdReceipt = new System.Windows.Forms.Button();
            this.cmdConfirm = new System.Windows.Forms.Button();
            this.cmdDeny = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbloutput = new System.Windows.Forms.Label();
            this.cmd7 = new System.Windows.Forms.Button();
            this.cmd8 = new System.Windows.Forms.Button();
            this.cmd9 = new System.Windows.Forms.Button();
            this.cmd4 = new System.Windows.Forms.Button();
            this.cmd5 = new System.Windows.Forms.Button();
            this.cmd6 = new System.Windows.Forms.Button();
            this.cmd1 = new System.Windows.Forms.Button();
            this.cmd2 = new System.Windows.Forms.Button();
            this.cmd3 = new System.Windows.Forms.Button();
            this.cmdA = new System.Windows.Forms.Button();
            this.cmd0 = new System.Windows.Forms.Button();
            this.cmdC = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdBalance
            // 
            this.cmdBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBalance.Location = new System.Drawing.Point(12, 29);
            this.cmdBalance.Name = "cmdBalance";
            this.cmdBalance.Size = new System.Drawing.Size(93, 25);
            this.cmdBalance.TabIndex = 0;
            this.cmdBalance.Text = "Balance";
            this.cmdBalance.UseVisualStyleBackColor = true;
            this.cmdBalance.Click += new System.EventHandler(this.cmdBalance_Click);
            // 
            // cmdWithdraw
            // 
            this.cmdWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdWithdraw.Location = new System.Drawing.Point(12, 80);
            this.cmdWithdraw.Name = "cmdWithdraw";
            this.cmdWithdraw.Size = new System.Drawing.Size(93, 23);
            this.cmdWithdraw.TabIndex = 1;
            this.cmdWithdraw.Text = "Withdraw";
            this.cmdWithdraw.UseVisualStyleBackColor = true;
            this.cmdWithdraw.Click += new System.EventHandler(this.cmdWithdraw_Click);
            // 
            // cmdReceipt
            // 
            this.cmdReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReceipt.Location = new System.Drawing.Point(12, 128);
            this.cmdReceipt.Name = "cmdReceipt";
            this.cmdReceipt.Size = new System.Drawing.Size(93, 67);
            this.cmdReceipt.TabIndex = 2;
            this.cmdReceipt.Text = "Withdraw with Receipt";
            this.cmdReceipt.UseVisualStyleBackColor = true;
            this.cmdReceipt.Click += new System.EventHandler(this.cmdReceipt_Click);
            // 
            // cmdConfirm
            // 
            this.cmdConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConfirm.Location = new System.Drawing.Point(12, 218);
            this.cmdConfirm.Name = "cmdConfirm";
            this.cmdConfirm.Size = new System.Drawing.Size(93, 23);
            this.cmdConfirm.TabIndex = 3;
            this.cmdConfirm.Text = "Confirm";
            this.cmdConfirm.UseVisualStyleBackColor = true;
            this.cmdConfirm.Click += new System.EventHandler(this.cmdConfirm_Click);
            // 
            // cmdDeny
            // 
            this.cmdDeny.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDeny.Location = new System.Drawing.Point(12, 274);
            this.cmdDeny.Name = "cmdDeny";
            this.cmdDeny.Size = new System.Drawing.Size(93, 23);
            this.cmdDeny.TabIndex = 4;
            this.cmdDeny.Text = "Deny";
            this.cmdDeny.UseVisualStyleBackColor = true;
            this.cmdDeny.Click += new System.EventHandler(this.cmdDeny_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(111, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 242);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Your Pin Number to login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Money MarketPlace";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.lbloutput);
            this.panel2.Location = new System.Drawing.Point(345, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 125);
            this.panel2.TabIndex = 0;
            // 
            // lbloutput
            // 
            this.lbloutput.ForeColor = System.Drawing.Color.White;
            this.lbloutput.Location = new System.Drawing.Point(3, 0);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(244, 128);
            this.lbloutput.TabIndex = 18;
            this.lbloutput.Text = "0000";
            // 
            // cmd7
            // 
            this.cmd7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd7.Location = new System.Drawing.Point(351, 160);
            this.cmd7.Name = "cmd7";
            this.cmd7.Size = new System.Drawing.Size(64, 23);
            this.cmd7.TabIndex = 6;
            this.cmd7.Text = "7";
            this.cmd7.UseVisualStyleBackColor = true;
            this.cmd7.Click += new System.EventHandler(this.cmd7_Click);
            // 
            // cmd8
            // 
            this.cmd8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd8.Location = new System.Drawing.Point(448, 160);
            this.cmd8.Name = "cmd8";
            this.cmd8.Size = new System.Drawing.Size(63, 23);
            this.cmd8.TabIndex = 7;
            this.cmd8.Text = "8";
            this.cmd8.UseVisualStyleBackColor = true;
            this.cmd8.Click += new System.EventHandler(this.cmd8_Click);
            // 
            // cmd9
            // 
            this.cmd9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd9.Location = new System.Drawing.Point(541, 160);
            this.cmd9.Name = "cmd9";
            this.cmd9.Size = new System.Drawing.Size(63, 23);
            this.cmd9.TabIndex = 8;
            this.cmd9.Text = "9";
            this.cmd9.UseVisualStyleBackColor = true;
            this.cmd9.Click += new System.EventHandler(this.cmd9_Click);
            // 
            // cmd4
            // 
            this.cmd4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd4.Location = new System.Drawing.Point(351, 198);
            this.cmd4.Name = "cmd4";
            this.cmd4.Size = new System.Drawing.Size(64, 23);
            this.cmd4.TabIndex = 9;
            this.cmd4.Text = "4";
            this.cmd4.UseVisualStyleBackColor = true;
            this.cmd4.Click += new System.EventHandler(this.cmd4_Click);
            // 
            // cmd5
            // 
            this.cmd5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd5.Location = new System.Drawing.Point(448, 198);
            this.cmd5.Name = "cmd5";
            this.cmd5.Size = new System.Drawing.Size(63, 23);
            this.cmd5.TabIndex = 10;
            this.cmd5.Text = "5";
            this.cmd5.UseVisualStyleBackColor = true;
            this.cmd5.Click += new System.EventHandler(this.cmd5_Click);
            // 
            // cmd6
            // 
            this.cmd6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd6.Location = new System.Drawing.Point(541, 198);
            this.cmd6.Name = "cmd6";
            this.cmd6.Size = new System.Drawing.Size(63, 23);
            this.cmd6.TabIndex = 11;
            this.cmd6.Text = "6";
            this.cmd6.UseVisualStyleBackColor = true;
            this.cmd6.Click += new System.EventHandler(this.cmd6_Click);
            // 
            // cmd1
            // 
            this.cmd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd1.Location = new System.Drawing.Point(351, 236);
            this.cmd1.Name = "cmd1";
            this.cmd1.Size = new System.Drawing.Size(64, 23);
            this.cmd1.TabIndex = 12;
            this.cmd1.Text = "1";
            this.cmd1.UseVisualStyleBackColor = true;
            this.cmd1.Click += new System.EventHandler(this.cmd1_Click);
            // 
            // cmd2
            // 
            this.cmd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd2.Location = new System.Drawing.Point(448, 236);
            this.cmd2.Name = "cmd2";
            this.cmd2.Size = new System.Drawing.Size(63, 23);
            this.cmd2.TabIndex = 13;
            this.cmd2.Text = "2";
            this.cmd2.UseVisualStyleBackColor = true;
            this.cmd2.Click += new System.EventHandler(this.cmd2_Click);
            // 
            // cmd3
            // 
            this.cmd3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd3.Location = new System.Drawing.Point(541, 236);
            this.cmd3.Name = "cmd3";
            this.cmd3.Size = new System.Drawing.Size(65, 23);
            this.cmd3.TabIndex = 14;
            this.cmd3.Text = "3";
            this.cmd3.UseVisualStyleBackColor = true;
            this.cmd3.Click += new System.EventHandler(this.cmd3_Click);
            // 
            // cmdA
            // 
            this.cmdA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdA.Location = new System.Drawing.Point(351, 273);
            this.cmdA.Name = "cmdA";
            this.cmdA.Size = new System.Drawing.Size(64, 23);
            this.cmdA.TabIndex = 15;
            this.cmdA.Text = "A";
            this.cmdA.UseVisualStyleBackColor = true;
            // 
            // cmd0
            // 
            this.cmd0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd0.Location = new System.Drawing.Point(448, 274);
            this.cmd0.Name = "cmd0";
            this.cmd0.Size = new System.Drawing.Size(63, 23);
            this.cmd0.TabIndex = 16;
            this.cmd0.Text = "0";
            this.cmd0.UseVisualStyleBackColor = true;
            this.cmd0.Click += new System.EventHandler(this.cmd0_Click);
            // 
            // cmdC
            // 
            this.cmdC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdC.Location = new System.Drawing.Point(541, 273);
            this.cmdC.Name = "cmdC";
            this.cmdC.Size = new System.Drawing.Size(65, 23);
            this.cmdC.TabIndex = 17;
            this.cmdC.Text = "C";
            this.cmdC.UseVisualStyleBackColor = true;
            this.cmdC.Click += new System.EventHandler(this.cmdC_Click);
            // 
            // FrmCashMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 308);
            this.Controls.Add(this.cmdC);
            this.Controls.Add(this.cmd0);
            this.Controls.Add(this.cmdA);
            this.Controls.Add(this.cmd3);
            this.Controls.Add(this.cmd2);
            this.Controls.Add(this.cmd1);
            this.Controls.Add(this.cmd6);
            this.Controls.Add(this.cmd5);
            this.Controls.Add(this.cmd4);
            this.Controls.Add(this.cmd9);
            this.Controls.Add(this.cmd8);
            this.Controls.Add(this.cmd7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdDeny);
            this.Controls.Add(this.cmdConfirm);
            this.Controls.Add(this.cmdReceipt);
            this.Controls.Add(this.cmdWithdraw);
            this.Controls.Add(this.cmdBalance);
            this.Name = "FrmCashMachine";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmCashMachine_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdBalance;
        private System.Windows.Forms.Button cmdWithdraw;
        private System.Windows.Forms.Button cmdReceipt;
        private System.Windows.Forms.Button cmdConfirm;
        private System.Windows.Forms.Button cmdDeny;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Button cmd7;
        private System.Windows.Forms.Button cmd8;
        private System.Windows.Forms.Button cmd9;
        private System.Windows.Forms.Button cmd4;
        private System.Windows.Forms.Button cmd5;
        private System.Windows.Forms.Button cmd6;
        private System.Windows.Forms.Button cmd1;
        private System.Windows.Forms.Button cmd2;
        private System.Windows.Forms.Button cmd3;
        private System.Windows.Forms.Button cmdA;
        private System.Windows.Forms.Button cmd0;
        private System.Windows.Forms.Button cmdC;
    }
}

