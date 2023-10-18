using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Timer = System.Windows.Forms.Timer;

namespace WhoWantsToBeAMillionaire
{
    public partial class CustomMessageBox : Form
    {
        private int countdown = 30;
        private Timer timer;

        public CustomMessageBox()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (countdown > 0)
            {
                countdown--;
                labelCountdown.Text = "Обратный отсчет: " + countdown.ToString();
            }
            else
            {
                timer.Stop();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void CustomMessageBox_Load(object sender, EventArgs e)
        {
            labelCountdown.Text = "Обратный отсчет: " + countdown.ToString();
        }
    }
}

