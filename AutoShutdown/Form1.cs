using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoShutdown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        System.Timers.Timer Timer;
        int m;
        int s = 0;

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Timer = new System.Timers.Timer();
                Timer.Interval = 1000;
                Timer.Elapsed += Timer_Elapsed;
                // 停止控制項接受Enter鍵的默認行為（換行）
                e.Handled = true;

                // 獲取MaskedTextBox中的指令文字
                string numberText = maskedTextBox1.Text.Trim();

                // 檢查使用者輸入是否為合法的數字
                if (int.TryParse(numberText, out int minutes) && minutes > 0)
                {
                    string action;
                    string action_zh;
                    if (autoshutdownbtn.Checked)
                    {
                        action = "s";
                        action_zh = "關機";
                    }
                    else
                    {
                        action = "r";
                        action_zh = "重開機";
                    }
                    string cmdCommand = $"shutdown -{action} -t {minutes * 60}";

                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/c {cmdCommand}",
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    Process cmdProcess = new Process
                    {
                        StartInfo = psi
                    };
                    cmdProcess.Start();

                    m = minutes;
                    countdown.Text = $"{m}:{s:D2}";
                    countdown.Visible = true;
                    actionhint.Visible = true;
                    Timer.Start();

                    cancelaction.Text = $"取消自動{action_zh}";
                    actionhint.Text = $"後自動{action_zh}";
                    maskedTextBox1.Enabled = false;
                    groupBox1.Enabled = false;
                    cancelaction.Visible = true;
                }
                else
                {
                    MessageBox.Show("請輸入有效的數字（正整數）。");
                }
            }
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s = s - 1;
                if (s < 0)
                {
                    m = m - 1;
                    s = 59;
                }
                countdown.Text = $"{m}:{s:D2}";
            }));
        }

        private void cancelaction_Click(object sender, EventArgs e)
        {
            string cmdCommand = $"shutdown -a";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/c {cmdCommand}",
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process cmdProcess = new Process
            {
                StartInfo = psi
            };
            cmdProcess.Start();
            maskedTextBox1.Clear();
            Timer.Stop();
            m = 0;
            s = 0;
            maskedTextBox1.Enabled = true;
            groupBox1.Enabled = true;
            actionhint.Visible = false;
            countdown.Visible = false;
            cancelaction.Visible = false;
        }
    }
}
