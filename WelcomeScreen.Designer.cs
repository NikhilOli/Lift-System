
namespace Lift_System
{
    partial class WelcomeScreen
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
            panel1 = new Panel();
            progressBar = new ProgressBar();
            loading = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(progressBar);
            panel1.Controls.Add(loading);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-4, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(888, 410);
            panel1.TabIndex = 0;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(227, 298);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(400, 10);
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.TabIndex = 1;
            // 
            // loading
            // 
            loading.AutoSize = true;
            loading.Font = new Font("Segoe UI", 12F);
            loading.ForeColor = Color.White;
            loading.Location = new Point(448, 332);
            loading.Name = "loading";
            loading.Size = new Size(39, 28);
            loading.TabIndex = 3;
            loading.Text = "0%";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(322, 332);
            label3.Name = "label3";
            label3.Size = new Size(87, 28);
            label3.TabIndex = 2;
            label3.Text = "Loading:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 31.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(294, 69);
            label2.Name = "label2";
            label2.Size = new Size(304, 72);
            label2.TabIndex = 1;
            label2.Text = "Welcome To";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(129, 150);
            label1.Name = "label1";
            label1.Size = new Size(641, 89);
            label1.TabIndex = 0;
            label1.Text = "Lift Control System";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // WelcomeScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(882, 453);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WelcomeScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome Screen";
            Load += WelcomePage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label loading;
        private Label label3;
        private ProgressBar progressBar;
        private System.Windows.Forms.Timer timer1;
    }
}
