using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Media;

namespace Alarm_Clock
{
    public partial class Form1 : Form
    {
        SoundPlayer player = new SoundPlayer();       
        int min, hr, sec,millisec;
        public Form1()
        {
            InitializeComponent();
            min = hr = sec = millisec = 0;                 
        }

        private void timerForTime_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();
            timerForTime.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bunifuiOSSwitch1.Value = false;
            btnStop.Enabled = false;
            btnTimerPause.Enabled = false;
            btnTimerReset.Enabled = false;
            timerAlarm.Stop();
            timerStopwatch.Stop();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {            
            DateTime CurrentTime = DateTime.Now;
            DateTime AlarmTime = dateTimePicker.Value;            
            if (CurrentTime.Year<=AlarmTime.Year&&CurrentTime.Month<=AlarmTime.Month&&CurrentTime.Day<=AlarmTime.Day)
            {                
                labelStatus.Text = "Alarm is set on "+dateTimePicker.Value+"";
                timerAlarm.Start();
                btnStart.Enabled = false;
                btnStop.Enabled = true;
                dateTimePicker.Enabled = false;
            }
            else
            {
                MessageBox.Show("You have choosed past day.", "Day Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timerAlarm.Stop();
            player.Stop();
            labelStatus.Text = "Alarm is not set.";            
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            dateTimePicker.Enabled = true;
        }

        private void timerAlarm_Tick(object sender, EventArgs e)
        {
            DateTime CurrentTime = DateTime.Now;
            DateTime AlarmTime = dateTimePicker.Value;
            if (CurrentTime.Year==AlarmTime.Year && CurrentTime.Month==AlarmTime.Month && CurrentTime.Day==AlarmTime.Day && CurrentTime.Hour == AlarmTime.Hour && CurrentTime.Minute == AlarmTime.Minute && CurrentTime.Second == AlarmTime.Second)
            {
                //SpeechSynthesizer speaks = new SpeechSynthesizer();
                //speaks.SetOutputToDefaultAudioDevice();
                //speaks.Speak("Fuck you guys");

                //player.SoundLocation = @"alarmsound.wav";
                //player.PlayLooping(); 
                SoundPlayer audio = new SoundPlayer(Alarm_Clock.Properties.Resources.alarmsound); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
                audio.Play();
                audio.PlayLooping();                               
            }
        }

        private void btnTimerReset_Click(object sender, EventArgs e)
        {
            timerStopwatch.Stop();
            min = hr = sec = millisec = 0;
            labelHour.Text = labelMinute.Text = labelSecond.Text = labelMillisecond.Text = "00";
            btnTimerStart.Text = "Start";
            btnTimerReset.Enabled = false;
            btnTimerStart.Enabled = true;
            btnTimerPause.Enabled = false;
        }

        private void BunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch1.Value==true)
            {
                this.BackColor = Color.FromArgb(48, 48, 48);
                this.ForeColor = Color.FromArgb(106, 123, 132);
                btnStart.ForeColor = Color.White;
            }
            else if (bunifuiOSSwitch1.Value==false)
            {
                this.BackColor = Color.FromArgb(240, 240, 240);
                this.ForeColor = Color.Black;
            }
        }

        private void btnTimerStart_Click(object sender, EventArgs e)
        {
            timerStopwatch.Start();
            btnTimerStart.Enabled = false;
            btnTimerReset.Enabled = true;
            btnTimerPause.Enabled = true;
        }

        private void btnTimerPause_Click(object sender, EventArgs e)
        {
            timerStopwatch.Stop();
            btnTimerStart.Text = "Resume";
            btnTimerStart.Enabled = true;
            btnTimerPause.Enabled = false;
        }

        private void timerStopwatch_Tick(object sender, EventArgs e)
        {
            millisec++;
            labelMillisecond.Text = millisec.ToString();
            if (millisec>59)
            {
                sec++;
                millisec = 0;                          
                labelSecond.Text = sec.ToString();
                if (sec>59)
                {
                    min++;
                    sec = 0;
                    labelMinute.Text = min.ToString();
                    if (min>60)
                    {
                        hr++;
                        min = 0;
                        labelHour.Text = hr.ToString();
                    }
                }
            }
        }
    }
}
