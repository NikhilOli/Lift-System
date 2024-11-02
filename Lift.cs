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
            AutoCloseTimer.Interval = 3000; // Auto-close doors after 3 seconds (adjust as needed)
            AutoCloseTimer.Tick += AutoCloseTimer_Tick;
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

        private void AutoCloseTimer_Tick(object sender, EventArgs e)
        {
            AutoCloseTimer.Stop();
            DoorClose(); // Automatically close the doors
        }

        private void OpenDoorsAfterArrival()
        {
            // Log the event and open the doors when the lift arrives
            if (current_floor == 0)
            {
                dbManager.logEvents("Lift arrived at ground floor, opening doors.", dt, DataTable);
            }
            else
            {
                dbManager.logEvents("Lift arrived at first floor, opening doors.", dt, DataTable);
            }

            DoorOpen();
            AutoCloseTimer.Start();
        }


        private void Lift_Load(object sender, EventArgs e)
        {
            //dbManager.loadLogsFromDB(dt, DataTable);
            dbManager.LoadLogsAsync(dt, DataTable);
        }




        // This is for button cick functions 


        private void LiftUp()
        {
            if (isOpening)
            {
                DoorClose(); // Use the existing method to close the doors   
                isOpening = false;
                // Set up a timer to delay lift movement until doors have closed
                Door_timer.Tick += (s, e) =>
                {
                    if (!isClosing)
                    {
                        Door_timer.Stop();
                        isMovingUp = true;
                        Lift_timer.Start();
                        Down_Button.Enabled = false;
                        OnLiftEvent?.Invoke("Lift Going Up");
                    }
                };
            }
            else
            {
                DoorClose();
                isMovingUp = true;
                isMovingDown = false;
                Lift_timer.Start();
                Down_Button.Enabled = false;
                OnLiftEvent?.Invoke("Lift Going Up");
            }
        }


        private void LiftDown()
        {
            if (isOpening)
            {
                DoorClose();
                isOpening = false;

                Door_timer.Tick += (s, e) =>
                {
                    if (!isClosing)
                    {
                        Door_timer.Stop();
                        isMovingDown = true;
                        Lift_timer.Start();
                        Up_button.Enabled = false;
                        OnLiftEvent?.Invoke("Lift Going Down");
                    }
                };
            }
            else
            {
                DoorClose();
                isMovingDown = true;
                isMovingUp = false;
                Lift_timer.Start();
                Up_button.Enabled = false;
                OnLiftEvent?.Invoke("Lift Going Down");
            }

        }

        private void DoorClose()
        {
            if (!isClosing) // Check to prevent duplicate logs and operations
            {
                isClosing = true;
                isOpening = false;
                Door_timer.Start();
                Door_open.Enabled = false;
                OnLiftEvent?.Invoke("Lift Door Closing");
            }

        }

        private void DoorOpen()
        {
            isOpening = true;
            isClosing = false;
            Door_timer.Start();
            Door_close.Enabled = false;
            OnLiftEvent?.Invoke("Lift Door Opening");
        }


        private void Up_button_Click(object sender, EventArgs e)
        {
            LiftUp();
        }

        private void Down_Button_Click(object sender, EventArgs e)
        {
            LiftDown();
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
                    floorDisplayLabel.Text = "⬆️⬆️";

                }
                else
                {
                    Lift_timer.Stop();
                    Down_Button.Enabled = true;
                    current_floor = 1;
                    floorDisplayLabel.Text = "1";
                    Up_button.BackColor = Color.White;
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
                    floorDisplayLabel.Text = "⬇️⬇️";
                }
                else
                {
                    Lift_timer.Stop();
                    Up_button.Enabled = true;
                    current_floor = 0;
                    floorDisplayLabel.Text = "0";
                    Down_Button.BackColor = Color.White; // Reset color when lift stops
                    OpenDoorsAfterArrival();
                }
            }
        }

        private void Door_open_Click(object sender, EventArgs e)
        {
            DoorOpen();
            AutoCloseTimer.Start();

        }

        private void Door_close_Click(object sender, EventArgs e)
        {
            DoorClose();

        }
        private void Door_timer_Tick(object sender, EventArgs e)
        {
            if (current_floor == 0)
            {
                // Ground floor doors
                if (isOpening)
                {
                    // Open the doors DownLeft_door.Left > doorMaxOpenWidth / 2
                    if (DownLeft_door.Left > Main_lift.Left - DownLeft_door.Width / 2 - 30)
                    {
                        DownLeft_door.Left -= doorspeed;
                        DownRight_door.Left += doorspeed;
                        //Task.Delay(5000).ContinueWith(_ => // Small delay for UI to update
                        //{
                        //    this.Invoke((MethodInvoker)(() =>
                        //    {
                        //        if (this.IsHandleCreated)
                        //        {
                        //            DoorClose(); // Call the function safely
                        //        }
                        //        else
                        //        {
                        //            // Optionally, use BeginInvoke or handle this case differently
                        //            this.BeginInvoke((MethodInvoker)(() => DoorClose()));
                        //        }
                        //    }));

                        //});
                    }
                    else
                    {
                        Door_timer.Stop();
                        Door_close.Enabled = true;
                        isOpening = false;
                    }
                }
                else if (isClosing)
                {
                    // Close the doors
                    if (DownLeft_door.Right < Main_lift.Width + doorMaxOpenWidth / 2 - 5)
                    {
                        DownLeft_door.Left += doorspeed;
                        DownRight_door.Left -= doorspeed;
                    }
                    else
                    {
                        Door_timer.Stop();
                        Door_open.Enabled = true;
                        isClosing = false;
                    }
                }
            }
            else
            {
                // First floor doors
                if (isOpening)
                {
                    // Open the doors
                    if (UpLeft_door.Left > Main_lift.Left - UpLeft_door.Width / 2 - 30)
                    {
                        UpLeft_door.Left -= doorspeed;
                        UpRight_door.Left += doorspeed;
                        //Task.Delay(5000).ContinueWith(_ => // Small delay for UI to update
                        //{
                        //    this.Invoke((MethodInvoker)(() =>
                        //    {
                        //        if (this.IsHandleCreated)
                        //        {
                        //            DoorClose(); // Call the function safely
                        //        }
                        //        else
                        //        {
                        //            // Optionally, use BeginInvoke or handle this case differently
                        //            this.BeginInvoke((MethodInvoker)(() => DoorClose()));
                        //        }
                        //    }));
                        //});
                    }
                    else
                    {
                        Door_timer.Stop();
                        Door_close.Enabled = true;
                        isOpening = false;
                    }
                }
                else if (isClosing)
                {
                    // Close the doors
                    if (UpLeft_door.Right < Main_lift.Width + doorMaxOpenWidth / 2 - 5)
                    {
                        UpLeft_door.Left += doorspeed;
                        UpRight_door.Left -= doorspeed;
                    }
                    else
                    {
                        Door_timer.Stop();
                        Door_open.Enabled = true;
                        isClosing = false;
                    }
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            dbManager.DeleteLogsFromDB(dt);
            DataTable.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LiftDown();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LiftUp();
        }
    }
}
