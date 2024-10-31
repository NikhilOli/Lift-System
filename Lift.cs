using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lift_System
{
    public partial class Lift : Form
    {

        // Define a delegate for logging events
        public delegate void LiftEventHandler(string message);

        // Create an instance of the delegate
        public LiftEventHandler OnLiftEvent;

        bool isMovingUp = false;
        bool isMovingDown = false;
        int liftspeed = 10;

        bool isOpening = false;
        bool isClosing = false;
        int doorspeed = 5;
        int current_floor = 0;

        int doorMaxOpenWidth;
        
        DatabaseManager dbManager = new DatabaseManager();
        DataTable dt = new DataTable();
        public Lift()
        {
            InitializeComponent();
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            doorMaxOpenWidth = Main_lift.Width / 2 - 40;

            DataTable.ColumnCount = 2;
            DataTable.Columns[0].Name = "Time";
            DataTable.Columns[1].Name = "Events";
            dt.Columns.Add("Time");
            dt.Columns.Add("EventDescription");

            // Assign the delegate to the DatabaseManager logEvents method
            OnLiftEvent = (message) => dbManager.logEvents(message, dt, DataTable);

        }
        private async void OpenDoorsAfterArrival()
        {
            //ResetControlsAfterLiftMovement();

            // Automatically open the doors when the lift arrives
            if (current_floor == 0)
            {
                dbManager.logEvents("Lift arrived at ground floor, opening doors.", dt, DataTable);
            }
            else
            {
                dbManager.logEvents("Lift arrived at first floor, opening doors.", dt, DataTable);
            }

            Door_open_Click(null, null);

            //await Task.Delay(3000);

            //Door_close_Click(null, null);
        }

        private void Lift_Load(object sender, EventArgs e)
        {
            dbManager.loadLogsFromDB(dt, DataTable);
        }

        private void Up_button_Click(object sender, EventArgs e)
        {
            Door_close_Click(null, null);
            isMovingUp = true;
            isMovingDown = false;
            Lift_timer.Start();
            Down_Button.Enabled = false;
            //dbManager.logEvents("Lift Going Up", dt, DataTable);
            OnLiftEvent?.Invoke("Lift Going Up");
        }

        private void Down_Button_Click(object sender, EventArgs e)
        {
            Door_close_Click(null, null);
            isMovingDown = true;
            isMovingUp = false;
            Lift_timer.Start();
            Up_button.Enabled = false;
            //dbManager.logEvents("Lift Going Down", dt, DataTable);
            OnLiftEvent?.Invoke("Lift Going Down");

        }

        private void Lift_timer_Tick(object sender, EventArgs e)
        {
            if (isMovingUp)
            {
                Up_button.BackColor = Color.Red;
                Down_Button.BackColor = Color.White;
                if (Main_lift.Top > 0)
                {
                    Main_lift.Top -= liftspeed;
                    floorDisplayLabel.Text = "1";

                }
                else
                {
                    Lift_timer.Stop();
                    Down_Button.Enabled = true;
                    current_floor = 1;
                    floorDisplayLabel.Text = "1";
                    OpenDoorsAfterArrival();

                }
            }
            if (isMovingDown)
            {
                Down_Button.BackColor = Color.Red;
                Up_button.BackColor = Color.White;
                if (Main_lift.Bottom < this.ClientSize.Height)
                {
                    Main_lift.Top += liftspeed;
                    floorDisplayLabel.Text = "0";
                }
                else
                {
                    Lift_timer.Stop();
                    Up_button.Enabled = true;
                    current_floor = 0;
                    floorDisplayLabel.Text = "0";
                    OpenDoorsAfterArrival();
                }
            }
        }

        private void Door_open_Click(object sender, EventArgs e)
        {
            isOpening = true;
            isClosing = false;
            Door_timer.Start();
            Door_close.Enabled = false;
            //dbManager.logEvents("Lift Door Opening", dt, DataTable);
            OnLiftEvent?.Invoke("Lift Door Opening");

        }

        private void Door_close_Click(object sender, EventArgs e)
        {
            isClosing = true;
            isOpening = false;
            Door_timer.Start();
            Door_open.Enabled = false;
            //dbManager.logEvents("Lift Door Closing", dt, DataTable);
            OnLiftEvent?.Invoke("Lift Door Closing");


        }
        private void Door_timer_Tick(object sender, EventArgs e)
        {
            if (current_floor == 0)
            {
                // Ground floor doors
                if (isOpening)
                {
                    // Open the doors
                    if (DownLeft_door.Left > doorMaxOpenWidth / 2)
                    {
                        DownLeft_door.Left -= doorspeed;
                        DownRight_door.Left += doorspeed;
                    }
                    else
                    {
                        Door_timer.Stop();
                        Door_close.Enabled = true;
                    }
                }
                else if (isClosing)
                {
                    // Close the doors
                    if (DownLeft_door.Right < Main_lift.Width + doorMaxOpenWidth / 2 + 5)
                    {
                        DownLeft_door.Left += doorspeed;
                        DownRight_door.Left -= doorspeed;
                    }
                    else
                    {
                        Door_timer.Stop();
                        Door_open.Enabled = true;
                    }
                }
            }
            else
            {
                // First floor doors
                if (isOpening)
                {
                    // Open the doors
                    if (UpLeft_door.Left > doorMaxOpenWidth / 2)
                    {
                        UpLeft_door.Left -= doorspeed;
                        UpRight_door.Left += doorspeed;
                    }
                    else
                    {
                        Door_timer.Stop();
                        Door_close.Enabled = true;
                    }
                }
                else if (isClosing)
                {
                    // Close the doors
                    if (UpLeft_door.Right < Main_lift.Width + doorMaxOpenWidth / 2 + 5)
                    {
                        UpLeft_door.Left += doorspeed;
                        UpRight_door.Left -= doorspeed;
                    }
                    else
                    {
                        Door_timer.Stop();
                        Door_open.Enabled = true;
                    }
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            dbManager.DeleteLogsFromDB(dt);
            DataTable.Rows.Clear();
        }
    }
}
