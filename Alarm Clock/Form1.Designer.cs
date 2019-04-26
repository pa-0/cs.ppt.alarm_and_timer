namespace Alarm_Clock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerForTime = new System.Windows.Forms.Timer(this.components);
            this.timerAlarm = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.groupBoxAlarm = new System.Windows.Forms.GroupBox();
            this.groupBoxStopwatch = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMillisecond = new System.Windows.Forms.Label();
            this.labelSecond = new System.Windows.Forms.Label();
            this.labelMinute = new System.Windows.Forms.Label();
            this.labelHour = new System.Windows.Forms.Label();
            this.btnTimerStart = new System.Windows.Forms.Button();
            this.btnTimerPause = new System.Windows.Forms.Button();
            this.btnTimerReset = new System.Windows.Forms.Button();
            this.timerStopwatch = new System.Windows.Forms.Timer(this.components);
            this.groupBoxAlarm.SuspendLayout();
            this.groupBoxStopwatch.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerForTime
            // 
            this.timerForTime.Enabled = true;
            this.timerForTime.Tick += new System.EventHandler(this.timerForTime_Tick);
            // 
            // timerAlarm
            // 
            this.timerAlarm.Enabled = true;
            this.timerAlarm.Interval = 1000;
            this.timerAlarm.Tick += new System.EventHandler(this.timerAlarm_Tick);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(23, 74);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(210, 30);
            this.dateTimePicker.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(41, 178);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(90, 32);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(135, 178);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(90, 32);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(104, 28);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(69, 29);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(12, 127);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(109, 17);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "Alarm is not set.";
            // 
            // groupBoxAlarm
            // 
            this.groupBoxAlarm.Controls.Add(this.label1);
            this.groupBoxAlarm.Controls.Add(this.labelStatus);
            this.groupBoxAlarm.Controls.Add(this.dateTimePicker);
            this.groupBoxAlarm.Controls.Add(this.btnStart);
            this.groupBoxAlarm.Controls.Add(this.labelTime);
            this.groupBoxAlarm.Controls.Add(this.btnStop);
            this.groupBoxAlarm.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAlarm.Name = "groupBoxAlarm";
            this.groupBoxAlarm.Size = new System.Drawing.Size(270, 228);
            this.groupBoxAlarm.TabIndex = 4;
            this.groupBoxAlarm.TabStop = false;
            this.groupBoxAlarm.Text = "Alarm";
            // 
            // groupBoxStopwatch
            // 
            this.groupBoxStopwatch.Controls.Add(this.label4);
            this.groupBoxStopwatch.Controls.Add(this.label3);
            this.groupBoxStopwatch.Controls.Add(this.label2);
            this.groupBoxStopwatch.Controls.Add(this.labelMillisecond);
            this.groupBoxStopwatch.Controls.Add(this.labelSecond);
            this.groupBoxStopwatch.Controls.Add(this.labelMinute);
            this.groupBoxStopwatch.Controls.Add(this.labelHour);
            this.groupBoxStopwatch.Controls.Add(this.btnTimerStart);
            this.groupBoxStopwatch.Controls.Add(this.btnTimerPause);
            this.groupBoxStopwatch.Controls.Add(this.btnTimerReset);
            this.groupBoxStopwatch.Location = new System.Drawing.Point(303, 12);
            this.groupBoxStopwatch.Name = "groupBoxStopwatch";
            this.groupBoxStopwatch.Size = new System.Drawing.Size(289, 228);
            this.groupBoxStopwatch.TabIndex = 5;
            this.groupBoxStopwatch.TabStop = false;
            this.groupBoxStopwatch.Text = "Stopwatch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(190, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = ":";
            // 
            // labelMillisecond
            // 
            this.labelMillisecond.AutoSize = true;
            this.labelMillisecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMillisecond.Location = new System.Drawing.Point(208, 94);
            this.labelMillisecond.Name = "labelMillisecond";
            this.labelMillisecond.Size = new System.Drawing.Size(47, 32);
            this.labelMillisecond.TabIndex = 2;
            this.labelMillisecond.Text = "00";
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecond.Location = new System.Drawing.Point(151, 94);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(47, 32);
            this.labelSecond.TabIndex = 2;
            this.labelSecond.Text = "00";
            // 
            // labelMinute
            // 
            this.labelMinute.AutoSize = true;
            this.labelMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinute.Location = new System.Drawing.Point(92, 94);
            this.labelMinute.Name = "labelMinute";
            this.labelMinute.Size = new System.Drawing.Size(47, 32);
            this.labelMinute.TabIndex = 2;
            this.labelMinute.Text = "00";
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHour.Location = new System.Drawing.Point(33, 94);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(47, 32);
            this.labelHour.TabIndex = 2;
            this.labelHour.Text = "00";
            // 
            // btnTimerStart
            // 
            this.btnTimerStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimerStart.Location = new System.Drawing.Point(9, 178);
            this.btnTimerStart.Name = "btnTimerStart";
            this.btnTimerStart.Size = new System.Drawing.Size(90, 32);
            this.btnTimerStart.TabIndex = 0;
            this.btnTimerStart.Text = "Start";
            this.btnTimerStart.UseVisualStyleBackColor = true;
            this.btnTimerStart.Click += new System.EventHandler(this.btnTimerStart_Click);
            // 
            // btnTimerPause
            // 
            this.btnTimerPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimerPause.Location = new System.Drawing.Point(102, 178);
            this.btnTimerPause.Name = "btnTimerPause";
            this.btnTimerPause.Size = new System.Drawing.Size(90, 32);
            this.btnTimerPause.TabIndex = 1;
            this.btnTimerPause.Text = "Pause";
            this.btnTimerPause.UseVisualStyleBackColor = true;
            this.btnTimerPause.Click += new System.EventHandler(this.btnTimerPause_Click);
            // 
            // btnTimerReset
            // 
            this.btnTimerReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimerReset.Location = new System.Drawing.Point(194, 178);
            this.btnTimerReset.Name = "btnTimerReset";
            this.btnTimerReset.Size = new System.Drawing.Size(90, 32);
            this.btnTimerReset.TabIndex = 2;
            this.btnTimerReset.Text = "Reset";
            this.btnTimerReset.UseVisualStyleBackColor = true;
            this.btnTimerReset.Click += new System.EventHandler(this.btnTimerReset_Click);
            // 
            // timerStopwatch
            // 
            this.timerStopwatch.Enabled = true;
            this.timerStopwatch.Interval = 10;
            this.timerStopwatch.Tick += new System.EventHandler(this.timerStopwatch_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 252);
            this.Controls.Add(this.groupBoxStopwatch);
            this.Controls.Add(this.groupBoxAlarm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm & Stopwatch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxAlarm.ResumeLayout(false);
            this.groupBoxAlarm.PerformLayout();
            this.groupBoxStopwatch.ResumeLayout(false);
            this.groupBoxStopwatch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerForTime;
        private System.Windows.Forms.Timer timerAlarm;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.GroupBox groupBoxAlarm;
        private System.Windows.Forms.GroupBox groupBoxStopwatch;
        private System.Windows.Forms.Label labelSecond;
        private System.Windows.Forms.Label labelMinute;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Button btnTimerStart;
        private System.Windows.Forms.Button btnTimerReset;
        private System.Windows.Forms.Button btnTimerPause;
        private System.Windows.Forms.Timer timerStopwatch;
        private System.Windows.Forms.Label labelMillisecond;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}

