namespace Lift_System
{
    partial class Lift
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lift));
            panel1 = new Panel();
            panel2 = new Panel();
            floorDisplayLabel = new Label();
            Door_close = new Button();
            Door_open = new Button();
            Down_Button = new Button();
            Up_button = new Button();
            Main_lift = new PictureBox();
            Lift_timer = new System.Windows.Forms.Timer(components);
            Door_timer = new System.Windows.Forms.Timer(components);
            DownLeft_door = new PictureBox();
            DownRight_door = new PictureBox();
            UpRight_door = new PictureBox();
            UpLeft_door = new PictureBox();
            DataTable = new DataGridView();
            DeleteButton = new Button();
            panel5 = new Panel();
            button1 = new Button();
            button2 = new Button();
            doorCloseTimer = new System.Windows.Forms.Timer(components);
            AutoCloseTimer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Main_lift).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DownLeft_door).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DownRight_door).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpRight_door).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpLeft_door).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataTable).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(Door_close);
            panel1.Controls.Add(Door_open);
            panel1.Controls.Add(Down_Button);
            panel1.Controls.Add(Up_button);
            panel1.Location = new Point(451, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 391);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(floorDisplayLabel);
            panel2.ForeColor = Color.Transparent;
            panel2.Location = new Point(50, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(130, 76);
            panel2.TabIndex = 5;
            // 
            // floorDisplayLabel
            // 
            floorDisplayLabel.AutoSize = true;
            floorDisplayLabel.BackColor = Color.Black;
            floorDisplayLabel.Font = new Font("Franklin Gothic Medium", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            floorDisplayLabel.ForeColor = Color.Red;
            floorDisplayLabel.Location = new Point(22, 0);
            floorDisplayLabel.Name = "floorDisplayLabel";
            floorDisplayLabel.Padding = new Padding(5, 0, 5, 0);
            floorDisplayLabel.Size = new Size(77, 75);
            floorDisplayLabel.TabIndex = 4;
            floorDisplayLabel.Text = "0";
            // 
            // Door_close
            // 
            Door_close.BackgroundImage = (Image)resources.GetObject("Door_close.BackgroundImage");
            Door_close.BackgroundImageLayout = ImageLayout.Stretch;
            Door_close.Location = new Point(122, 328);
            Door_close.Name = "Door_close";
            Door_close.Size = new Size(50, 54);
            Door_close.TabIndex = 3;
            Door_close.UseVisualStyleBackColor = true;
            Door_close.Click += Door_close_Click;
            // 
            // Door_open
            // 
            Door_open.BackColor = Color.Transparent;
            Door_open.BackgroundImage = (Image)resources.GetObject("Door_open.BackgroundImage");
            Door_open.BackgroundImageLayout = ImageLayout.Stretch;
            Door_open.Location = new Point(52, 328);
            Door_open.Name = "Door_open";
            Door_open.Size = new Size(50, 54);
            Door_open.TabIndex = 2;
            Door_open.UseVisualStyleBackColor = false;
            Door_open.Click += Door_open_Click;
            // 
            // Down_Button
            // 
            Down_Button.BackColor = Color.Transparent;
            Down_Button.BackgroundImage = (Image)resources.GetObject("Down_Button.BackgroundImage");
            Down_Button.BackgroundImageLayout = ImageLayout.Stretch;
            Down_Button.Font = new Font("Segoe UI", 20F);
            Down_Button.ForeColor = Color.Transparent;
            Down_Button.Location = new Point(87, 254);
            Down_Button.Name = "Down_Button";
            Down_Button.Size = new Size(50, 54);
            Down_Button.TabIndex = 1;
            Down_Button.Text = "G";
            Down_Button.UseVisualStyleBackColor = false;
            Down_Button.Click += Down_Button_Click;
            // 
            // Up_button
            // 
            Up_button.BackColor = Color.Transparent;
            Up_button.BackgroundImage = (Image)resources.GetObject("Up_button.BackgroundImage");
            Up_button.BackgroundImageLayout = ImageLayout.Stretch;
            Up_button.Font = new Font("Segoe UI", 20F);
            Up_button.ForeColor = Color.Transparent;
            Up_button.Location = new Point(87, 185);
            Up_button.Name = "Up_button";
            Up_button.Size = new Size(50, 54);
            Up_button.TabIndex = 0;
            Up_button.Text = "1";
            Up_button.UseVisualStyleBackColor = false;
            Up_button.Click += Up_button_Click;
            // 
            // Main_lift
            // 
            Main_lift.Image = (Image)resources.GetObject("Main_lift.Image");
            Main_lift.Location = new Point(80, 404);
            Main_lift.Name = "Main_lift";
            Main_lift.Size = new Size(142, 169);
            Main_lift.SizeMode = PictureBoxSizeMode.StretchImage;
            Main_lift.TabIndex = 6;
            Main_lift.TabStop = false;
            // 
            // Lift_timer
            // 
            Lift_timer.Tick += Lift_timer_Tick;
            // 
            // Door_timer
            // 
            Door_timer.Tick += Door_timer_Tick;
            // 
            // DownLeft_door
            // 
            DownLeft_door.Image = (Image)resources.GetObject("DownLeft_door.Image");
            DownLeft_door.Location = new Point(66, 404);
            DownLeft_door.Name = "DownLeft_door";
            DownLeft_door.Size = new Size(87, 169);
            DownLeft_door.SizeMode = PictureBoxSizeMode.StretchImage;
            DownLeft_door.TabIndex = 7;
            DownLeft_door.TabStop = false;
            // 
            // DownRight_door
            // 
            DownRight_door.Image = (Image)resources.GetObject("DownRight_door.Image");
            DownRight_door.Location = new Point(150, 404);
            DownRight_door.Name = "DownRight_door";
            DownRight_door.Size = new Size(87, 169);
            DownRight_door.SizeMode = PictureBoxSizeMode.StretchImage;
            DownRight_door.TabIndex = 8;
            DownRight_door.TabStop = false;
            // 
            // UpRight_door
            // 
            UpRight_door.Image = (Image)resources.GetObject("UpRight_door.Image");
            UpRight_door.Location = new Point(150, 0);
            UpRight_door.Name = "UpRight_door";
            UpRight_door.Size = new Size(87, 169);
            UpRight_door.SizeMode = PictureBoxSizeMode.StretchImage;
            UpRight_door.TabIndex = 10;
            UpRight_door.TabStop = false;
            // 
            // UpLeft_door
            // 
            UpLeft_door.Image = (Image)resources.GetObject("UpLeft_door.Image");
            UpLeft_door.Location = new Point(66, 0);
            UpLeft_door.Name = "UpLeft_door";
            UpLeft_door.Size = new Size(87, 169);
            UpLeft_door.SizeMode = PictureBoxSizeMode.StretchImage;
            UpLeft_door.TabIndex = 9;
            UpLeft_door.TabStop = false;
            // 
            // DataTable
            // 
            DataTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataTable.Location = new Point(799, 35);
            DataTable.Name = "DataTable";
            DataTable.RowHeadersWidth = 51;
            DataTable.Size = new Size(338, 501);
            DataTable.TabIndex = 11;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.Tomato;
            DeleteButton.ForeColor = SystemColors.ButtonFace;
            DeleteButton.Location = new Point(699, 464);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(94, 37);
            DeleteButton.TabIndex = 12;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaptionText;
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Location = new Point(333, 76);
            panel5.Name = "panel5";
            panel5.Size = new Size(0, 0);
            panel5.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(333, 111);
            button1.Name = "button1";
            button1.Size = new Size(38, 41);
            button1.TabIndex = 19;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(333, 459);
            button2.Name = "button2";
            button2.Size = new Size(38, 41);
            button2.TabIndex = 20;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Lift
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1162, 573);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel5);
            Controls.Add(DeleteButton);
            Controls.Add(DataTable);
            Controls.Add(UpRight_door);
            Controls.Add(UpLeft_door);
            Controls.Add(DownRight_door);
            Controls.Add(DownLeft_door);
            Controls.Add(Main_lift);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Lift";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lift System";
            Load += Lift_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Main_lift).EndInit();
            ((System.ComponentModel.ISupportInitialize)DownLeft_door).EndInit();
            ((System.ComponentModel.ISupportInitialize)DownRight_door).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpRight_door).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpLeft_door).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Door_close;
        private Button Door_open;
        private Button Down_Button;
        private Button Up_button;
        private PictureBox Main_lift;
        private System.Windows.Forms.Timer Lift_timer;
        private System.Windows.Forms.Timer Door_timer;
        private PictureBox DownLeft_door;
        private PictureBox DownRight_door;
        private PictureBox UpRight_door;
        private PictureBox UpLeft_door;
        private DataGridView DataTable;
        private Button DeleteButton;
        private Panel panel5;
        private Button button1;
        private Button button2;
        private Label floorDisplayLabel;
        private Panel panel2;
        private System.Windows.Forms.Timer doorCloseTimer;
        private System.Windows.Forms.Timer AutoCloseTimer;
    }
}
