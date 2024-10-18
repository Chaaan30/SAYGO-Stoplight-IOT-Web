namespace IT152P_SAYGO_PROJECT
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.trafficlight = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pedlight = new Guna.UI2.WinForms.Guna2PictureBox();
            this.resetbutton = new Guna.UI2.WinForms.Guna2Button();
            this.morningbutton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.serial_port = new System.IO.Ports.SerialPort(this.components);
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trafficlight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedlight)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Bisque;
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Controls.Add(this.trafficlight);
            this.guna2Panel1.Controls.Add(this.pedlight);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(264, 356);
            this.guna2Panel1.TabIndex = 6;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.IndianRed;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(46, 273);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(170, 23);
            this.guna2HtmlLabel2.TabIndex = 3;
            this.guna2HtmlLabel2.Text = "Traffic and Pedestrian";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.IndianRed;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(83, 292);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(93, 23);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Light Status";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // trafficlight
            // 
            this.trafficlight.FillColor = System.Drawing.Color.Transparent;
            this.trafficlight.Image = global::IT128_SAYGO_PROJECT.Properties.Resources.Green_traf_light;
            this.trafficlight.ImageRotate = 0F;
            this.trafficlight.Location = new System.Drawing.Point(46, 41);
            this.trafficlight.Name = "trafficlight";
            this.trafficlight.Size = new System.Drawing.Size(88, 208);
            this.trafficlight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.trafficlight.TabIndex = 1;
            this.trafficlight.TabStop = false;
            // 
            // pedlight
            // 
            this.pedlight.BackColor = System.Drawing.Color.Transparent;
            this.pedlight.Image = global::IT128_SAYGO_PROJECT.Properties.Resources.Green_ped_light;
            this.pedlight.ImageRotate = 0F;
            this.pedlight.Location = new System.Drawing.Point(140, 75);
            this.pedlight.Name = "pedlight";
            this.pedlight.Size = new System.Drawing.Size(80, 132);
            this.pedlight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pedlight.TabIndex = 0;
            this.pedlight.TabStop = false;
            // 
            // resetbutton
            // 
            this.resetbutton.Animated = true;
            this.resetbutton.BorderRadius = 10;
            this.resetbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.resetbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.resetbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.resetbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.resetbutton.FillColor = System.Drawing.Color.IndianRed;
            this.resetbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.resetbutton.ForeColor = System.Drawing.Color.White;
            this.resetbutton.Location = new System.Drawing.Point(339, 144);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(175, 48);
            this.resetbutton.TabIndex = 7;
            this.resetbutton.Text = "Reset Sequence";
            this.guna2HtmlToolTip1.SetToolTip(this.resetbutton, "Starts the Traffic Light sequence \r\nwhen Morning Sequence is Selected.");
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // morningbutton
            // 
            this.morningbutton.Animated = true;
            this.morningbutton.BackColor = System.Drawing.Color.Transparent;
            this.morningbutton.BorderRadius = 10;
            this.morningbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.morningbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.morningbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.morningbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.morningbutton.FillColor = System.Drawing.Color.IndianRed;
            this.morningbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.morningbutton.ForeColor = System.Drawing.Color.White;
            this.morningbutton.Location = new System.Drawing.Point(339, 198);
            this.morningbutton.Name = "morningbutton";
            this.morningbutton.Size = new System.Drawing.Size(175, 48);
            this.morningbutton.TabIndex = 8;
            this.morningbutton.Text = "Night Sequence";
            this.guna2HtmlToolTip1.SetToolTip(this.morningbutton, "Starts the Night Sequence which blinks the Traffic Light and Pedestrian Light.");
            this.morningbutton.Click += new System.EventHandler(this.morningbutton_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.BorderColor = System.Drawing.Color.IndianRed;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.IndianRed;
            this.guna2ControlBox1.Location = new System.Drawing.Point(561, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(22, 22);
            this.guna2ControlBox1.TabIndex = 9;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.IndianRed;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(368, 75);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(113, 27);
            this.guna2HtmlLabel3.TabIndex = 4;
            this.guna2HtmlLabel3.Text = "Lights Menu";
            this.guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.guna2Panel1;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // serial_port
            // 
            this.serial_port.PortName = "COM4";
            // 
            // guna2HtmlToolTip1
            // 
            this.guna2HtmlToolTip1.AllowLinksHandling = true;
            this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(595, 356);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.morningbutton);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trafficlight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedlight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox pedlight;
        private Guna.UI2.WinForms.Guna2PictureBox trafficlight;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button morningbutton;
        private Guna.UI2.WinForms.Guna2Button resetbutton;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private System.IO.Ports.SerialPort serial_port;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private System.Windows.Forms.Timer timer1;
    }
}

