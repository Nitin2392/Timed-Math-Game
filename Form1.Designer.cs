namespace DXBall_Game
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblCalc = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblEquals = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.lblTimerInfo = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblSorF = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(142, 370);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(242, 63);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Game!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(565, 370);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(232, 63);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Go!";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(525, 155);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(177, 53);
            this.txtInput.TabIndex = 2;
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst.Location = new System.Drawing.Point(138, 155);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(42, 46);
            this.lblFirst.TabIndex = 3;
            this.lblFirst.Text = "0";
            // 
            // lblCalc
            // 
            this.lblCalc.AutoSize = true;
            this.lblCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalc.Location = new System.Drawing.Point(245, 155);
            this.lblCalc.Name = "lblCalc";
            this.lblCalc.Size = new System.Drawing.Size(47, 46);
            this.lblCalc.TabIndex = 4;
            this.lblCalc.Text = "X";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecond.Location = new System.Drawing.Point(371, 155);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(42, 46);
            this.lblSecond.TabIndex = 5;
            this.lblSecond.Text = "0";
            // 
            // lblEquals
            // 
            this.lblEquals.AutoSize = true;
            this.lblEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquals.Location = new System.Drawing.Point(442, 155);
            this.lblEquals.Name = "lblEquals";
            this.lblEquals.Size = new System.Drawing.Size(43, 46);
            this.lblEquals.TabIndex = 6;
            this.lblEquals.Text = "=";
            // 
            // timerClock
            // 
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // lblTimerInfo
            // 
            this.lblTimerInfo.AutoSize = true;
            this.lblTimerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerInfo.Location = new System.Drawing.Point(537, 40);
            this.lblTimerInfo.Name = "lblTimerInfo";
            this.lblTimerInfo.Size = new System.Drawing.Size(207, 46);
            this.lblTimerInfo.TabIndex = 7;
            this.lblTimerInfo.Text = "Time Left: ";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(750, 40);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 46);
            this.lblTimer.TabIndex = 8;
            // 
            // lblSorF
            // 
            this.lblSorF.AutoSize = true;
            this.lblSorF.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSorF.Location = new System.Drawing.Point(245, 277);
            this.lblSorF.Name = "lblSorF";
            this.lblSorF.Size = new System.Drawing.Size(0, 46);
            this.lblSorF.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(975, 548);
            this.Controls.Add(this.lblSorF);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblTimerInfo);
            this.Controls.Add(this.lblEquals);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblCalc);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblCalc;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblEquals;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Label lblTimerInfo;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblSorF;
    }
}

