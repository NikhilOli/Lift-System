
namespace Lift_System
{
    partial class WelcomePage
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
            loading = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            progressBar = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(loading);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-4, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(888, 410);
            panel1.TabIndex = 0;
            // 
            // loading
            // 
            loading.AutoSize = true;
            loading.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loading.ForeColor = Color.Lime;
            loading.Location = new Point(454, 258);
            loading.Name = "loading";
            loading.Size = new Size(49, 35);
            loading.TabIndex = 3;
            loading.Text = "0%";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(328, 258);
            label3.Name = "label3";
            label3.Size = new Size(120, 37);
            label3.TabIndex = 2;
            label3.Text = "Loading:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(309, 121);
            label2.Name = "label2";
            label2.Size = new Size(267, 48);
            label2.TabIndex = 1;
            label2.Text = "Welcome To";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 30F, FontStyle.Bold);
            label1.Location = new Point(172, 191);
            label1.Name = "label1";
            label1.Size = new Size(516, 50);
            label1.TabIndex = 0;
            label1.Text = "Lift Control System";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(-4, 409);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(888, 46);
            progressBar.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // WelcomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 453);
            Controls.Add(progressBar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "WelcomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome Page";
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
