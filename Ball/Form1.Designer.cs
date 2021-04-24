
namespace Ball
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
            this.panelY = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Ball = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelY
            // 
            this.panelY.BackColor = System.Drawing.Color.Gray;
            this.panelY.Location = new System.Drawing.Point(1022, 1);
            this.panelY.Name = "panelY";
            this.panelY.Size = new System.Drawing.Size(10, 617);
            this.panelY.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(4, 608);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 13);
            this.panel1.TabIndex = 1;
            // 
            // Ball
            // 
            this.Ball.AutoSize = true;
            this.Ball.BackColor = System.Drawing.Color.Transparent;
            this.Ball.Font = new System.Drawing.Font("Mk_Parz", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ball.Location = new System.Drawing.Point(114, 81);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(27, 22);
            this.Ball.TabIndex = 2;
            this.Ball.Text = "O";
            // 
            // Timer
            // 
            this.Timer.Interval = 20;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(1059, 63);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(141, 58);
            this.start.TabIndex = 3;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Enabled = false;
            this.stop.Location = new System.Drawing.Point(1059, 151);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(141, 58);
            this.stop.TabIndex = 4;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 617);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelY);
            this.Controls.Add(this.Ball);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelY;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Ball;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
    }
}

