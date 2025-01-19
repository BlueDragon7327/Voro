namespace Vøro
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Editor = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.Attach = new Guna.UI2.WinForms.Guna2Button();
            this.Execute = new Guna.UI2.WinForms.Guna2Button();
            this.Clear = new Guna.UI2.WinForms.Guna2Button();
            this.WindowBorder = new System.Windows.Forms.Panel();
            this.settingsclose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.topmostcheckbox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Editor)).BeginInit();
            this.WindowBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Editor
            // 
            this.Editor.AllowExternalDrop = true;
            this.Editor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Editor.CreationProperties = null;
            this.Editor.DefaultBackgroundColor = System.Drawing.Color.White;
            this.Editor.Location = new System.Drawing.Point(2, 67);
            this.Editor.Name = "Editor";
            this.Editor.Size = new System.Drawing.Size(800, 322);
            this.Editor.TabIndex = 0;
            this.Editor.ZoomFactor = 1D;
            this.Editor.Click += new System.EventHandler(this.Editor_Click);
            // 
            // Attach
            // 
            this.Attach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Attach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Attach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Attach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Attach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Attach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Attach.ForeColor = System.Drawing.Color.White;
            this.Attach.Image = ((System.Drawing.Image)(resources.GetObject("Attach.Image")));
            this.Attach.Location = new System.Drawing.Point(706, 395);
            this.Attach.Name = "Attach";
            this.Attach.Size = new System.Drawing.Size(82, 45);
            this.Attach.TabIndex = 1;
            this.Attach.Text = "Attach";
            this.Attach.Click += new System.EventHandler(this.Attach_Click);
            // 
            // Execute
            // 
            this.Execute.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Execute.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Execute.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Execute.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Execute.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Execute.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Execute.ForeColor = System.Drawing.Color.White;
            this.Execute.Image = ((System.Drawing.Image)(resources.GetObject("Execute.Image")));
            this.Execute.Location = new System.Drawing.Point(12, 395);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(82, 45);
            this.Execute.TabIndex = 2;
            this.Execute.Text = "Run";
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // Clear
            // 
            this.Clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Clear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Clear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.Image = ((System.Drawing.Image)(resources.GetObject("Clear.Image")));
            this.Clear.Location = new System.Drawing.Point(100, 395);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(82, 45);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear";
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // WindowBorder
            // 
            this.WindowBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.WindowBorder.Controls.Add(this.settingsclose);
            this.WindowBorder.Controls.Add(this.guna2ImageButton1);
            this.WindowBorder.Controls.Add(this.label2);
            this.WindowBorder.Controls.Add(this.label1);
            this.WindowBorder.Controls.Add(this.Logo);
            this.WindowBorder.Location = new System.Drawing.Point(-1, 0);
            this.WindowBorder.Name = "WindowBorder";
            this.WindowBorder.Size = new System.Drawing.Size(803, 61);
            this.WindowBorder.TabIndex = 4;
            this.WindowBorder.Paint += new System.Windows.Forms.PaintEventHandler(this.WindowBorder_Paint);
            this.WindowBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.WindowBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            // 
            // settingsclose
            // 
            this.settingsclose.BackColor = System.Drawing.Color.Transparent;
            this.settingsclose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.settingsclose.HoverState.ImageSize = new System.Drawing.Size(0, 0);
            this.settingsclose.Image = ((System.Drawing.Image)(resources.GetObject("settingsclose.Image")));
            this.settingsclose.ImageOffset = new System.Drawing.Point(0, 0);
            this.settingsclose.ImageRotate = 0F;
            this.settingsclose.ImageSize = new System.Drawing.Size(45, 45);
            this.settingsclose.IndicateFocus = true;
            this.settingsclose.Location = new System.Drawing.Point(744, 3);
            this.settingsclose.Name = "settingsclose";
            this.settingsclose.PressedState.ImageSize = new System.Drawing.Size(0, 0);
            this.settingsclose.Size = new System.Drawing.Size(56, 55);
            this.settingsclose.TabIndex = 7;
            this.settingsclose.UseTransparentBackground = true;
            this.settingsclose.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(0, 0);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(44, 44);
            this.guna2ImageButton1.IndicateFocus = true;
            this.guna2ImageButton1.Location = new System.Drawing.Point(707, 9);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(0, 0);
            this.guna2ImageButton1.Size = new System.Drawing.Size(49, 26);
            this.guna2ImageButton1.TabIndex = 8;
            this.guna2ImageButton1.UseTransparentBackground = true;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(77, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "v0.5.0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label1.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vøro Lite";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Logo
            // 
            this.Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(3, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(63, 61);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 2;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // topmostcheckbox
            // 
            this.topmostcheckbox.AutoSize = true;
            this.topmostcheckbox.BackColor = System.Drawing.Color.Black;
            this.topmostcheckbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.topmostcheckbox.CheckedState.BorderRadius = 2;
            this.topmostcheckbox.CheckedState.BorderThickness = 1;
            this.topmostcheckbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.topmostcheckbox.CheckMarkColor = System.Drawing.Color.ForestGreen;
            this.topmostcheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.topmostcheckbox.ForeColor = System.Drawing.Color.White;
            this.topmostcheckbox.Location = new System.Drawing.Point(12, 363);
            this.topmostcheckbox.Name = "topmostcheckbox";
            this.topmostcheckbox.Size = new System.Drawing.Size(68, 17);
            this.topmostcheckbox.TabIndex = 9;
            this.topmostcheckbox.Text = "TopMost";
            this.topmostcheckbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.topmostcheckbox.UncheckedState.BorderRadius = 2;
            this.topmostcheckbox.UncheckedState.BorderThickness = 1;
            this.topmostcheckbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.topmostcheckbox.UseVisualStyleBackColor = false;
            this.topmostcheckbox.CheckedChanged += new System.EventHandler(this.TopMost_CheckedChanged);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.Location = new System.Drawing.Point(188, 395);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(82, 45);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "Settings";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.topmostcheckbox);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.WindowBorder);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.Attach);
            this.Controls.Add(this.Editor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Editor)).EndInit();
            this.WindowBorder.ResumeLayout(false);
            this.WindowBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 Editor;
        private Guna.UI2.WinForms.Guna2Button Attach;
        private Guna.UI2.WinForms.Guna2Button Execute;
        private Guna.UI2.WinForms.Guna2Button Clear;
        private System.Windows.Forms.Panel WindowBorder;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2ImageButton settingsclose;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2CheckBox topmostcheckbox;
    }
}

