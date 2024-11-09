using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lift_System
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < 100)
            {
                progressBar.Value += 1;
                loading.Text = progressBar.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                loading.Text = "100%"; // Ensure text is updated
                Task.Delay(800).ContinueWith(_ => // Small delay for UI to update
                {
                    this.Invoke((MethodInvoker)(() =>
                    {
                        Lift lift = new Lift();
                        lift.Show();
                        this.Hide();
                    }));
                });
            }
        }


        private void WelcomePage_Load(object sender, EventArgs e)
        {
            timer1.Interval = 20;
            timer1.Start();
        }
    }
}
