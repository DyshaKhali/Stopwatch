namespace Stopwatch
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
            this.StartBut = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StopBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartBut
            // 
            this.StartBut.Location = new System.Drawing.Point(12, 142);
            this.StartBut.Name = "StartBut";
            this.StartBut.Size = new System.Drawing.Size(156, 47);
            this.StartBut.TabIndex = 0;
            this.StartBut.Text = "START";
            this.StartBut.UseVisualStyleBackColor = true;
            this.StartBut.Click += new System.EventHandler(this.Start_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StopBut
            // 
            this.StopBut.Location = new System.Drawing.Point(235, 142);
            this.StopBut.Name = "StopBut";
            this.StopBut.Size = new System.Drawing.Size(156, 47);
            this.StopBut.TabIndex = 1;
            this.StopBut.Text = "STOP";
            this.StopBut.UseVisualStyleBackColor = true;
            this.StopBut.Click += new System.EventHandler(this.StopBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(407, 196);
            this.Controls.Add(this.StopBut);
            this.Controls.Add(this.StartBut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartBut;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button StopBut;
    }
}

