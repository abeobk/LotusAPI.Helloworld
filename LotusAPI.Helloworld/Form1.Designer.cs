namespace LotusAPI.Helloworld {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.logView1 = new LotusAPI.Controls.LogView();
            this.flatStatusBar1 = new Abeo.Controls.ZeroCode.FlatStatusBar();
            this.flatTitlePanel1 = new Abeo.Controls.ZeroCode.FlatTitlePanel();
            this.flatFormButtonsHorizontal1 = new Abeo.Controls.ZeroCode.FlatFormButtonsHorizontal();
            this.imgview = new LotusAPI.Controls.FastImageView();
            this.btLoad = new Abeo.Controls.FlatButton();
            this.flatTitlePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgview)).BeginInit();
            this.SuspendLayout();
            // 
            // logView1
            // 
            this.logView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.logView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logView1.ColorDateTime = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.logView1.ColorDebug = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.logView1.ColorError = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(59)))), ((int)(((byte)(39)))));
            this.logView1.ColorFatal = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(66)))), ((int)(((byte)(129)))));
            this.logView1.ColorInfo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.logView1.ColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.logView1.ColorTrace = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.logView1.ColorWarning = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.logView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logView1.Font = new System.Drawing.Font("Consolas", 9F);
            this.logView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.logView1.LineBuffer = 1000;
            this.logView1.Location = new System.Drawing.Point(0, 410);
            this.logView1.Name = "logView1";
            this.logView1.ReadOnly = true;
            this.logView1.ShowDateTime = true;
            this.logView1.Size = new System.Drawing.Size(966, 214);
            this.logView1.TabIndex = 0;
            this.logView1.Text = "";
            this.logView1.UpdateInterval = 100;
            // 
            // flatStatusBar1
            // 
            this.flatStatusBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.flatStatusBar1.ClockColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(211)))));
            this.flatStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flatStatusBar1.FixedHeight = 24;
            this.flatStatusBar1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatStatusBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.flatStatusBar1.FreeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.flatStatusBar1.HighUseColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(59)))), ((int)(((byte)(39)))));
            this.flatStatusBar1.Location = new System.Drawing.Point(0, 624);
            this.flatStatusBar1.LowUseColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.flatStatusBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flatStatusBar1.MediumUseColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.flatStatusBar1.Name = "flatStatusBar1";
            this.flatStatusBar1.Size = new System.Drawing.Size(966, 24);
            // 
            // 
            // 
            this.flatStatusBar1.StatusItems.BackColor = System.Drawing.Color.Transparent;
            this.flatStatusBar1.StatusItems.BackColorON = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.flatStatusBar1.StatusItems.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.flatStatusBar1.StatusItems.Dock = System.Windows.Forms.DockStyle.Left;
            this.flatStatusBar1.StatusItems.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatStatusBar1.StatusItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.flatStatusBar1.StatusItems.ForeColorON = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.flatStatusBar1.StatusItems.Items = "";
            this.flatStatusBar1.StatusItems.Location = new System.Drawing.Point(60, 0);
            this.flatStatusBar1.StatusItems.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.flatStatusBar1.StatusItems.Name = "statusItems";
            this.flatStatusBar1.StatusItems.ShowBorder = true;
            this.flatStatusBar1.StatusItems.Size = new System.Drawing.Size(0, 24);
            this.flatStatusBar1.StatusItems.TabIndex = 8;
            this.flatStatusBar1.TabIndex = 2;
            // 
            // flatTitlePanel1
            // 
            this.flatTitlePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.flatTitlePanel1.Controls.Add(this.btLoad);
            this.flatTitlePanel1.Controls.Add(this.flatFormButtonsHorizontal1);
            this.flatTitlePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flatTitlePanel1.FixedHeight = 32;
            this.flatTitlePanel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatTitlePanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.flatTitlePanel1.Location = new System.Drawing.Point(0, 0);
            this.flatTitlePanel1.Name = "flatTitlePanel1";
            this.flatTitlePanel1.Size = new System.Drawing.Size(966, 32);
            this.flatTitlePanel1.TabIndex = 3;
            // 
            // flatFormButtonsHorizontal1
            // 
            this.flatFormButtonsHorizontal1.BackColor = System.Drawing.Color.Transparent;
            this.flatFormButtonsHorizontal1.CloseConfirmType = Abeo.Controls.ZeroCode.FlatCloseButton.CloseConfirmTypeEnum.PasswordBox;
            this.flatFormButtonsHorizontal1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flatFormButtonsHorizontal1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatFormButtonsHorizontal1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.flatFormButtonsHorizontal1.Location = new System.Drawing.Point(840, 0);
            this.flatFormButtonsHorizontal1.Name = "flatFormButtonsHorizontal1";
            this.flatFormButtonsHorizontal1.Size = new System.Drawing.Size(126, 32);
            this.flatFormButtonsHorizontal1.TabIndex = 0;
            // 
            // imgview
            // 
            this.imgview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgview.DrawFPS = false;
            this.imgview.EnablePanZoom = true;
            this.imgview.FrameRate = 60;
            this.imgview.Location = new System.Drawing.Point(0, 32);
            this.imgview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgview.Name = "imgview";
            this.imgview.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.imgview.RenderContextType = SharpGL.RenderContextType.NativeWindow;
            this.imgview.RenderTrigger = SharpGL.RenderTrigger.Manual;
            this.imgview.ShowCrossHair = true;
            this.imgview.ShowDebugInfo = true;
            this.imgview.ShowImageBorder = true;
            this.imgview.ShowPixelInfo = false;
            this.imgview.Size = new System.Drawing.Size(966, 378);
            this.imgview.TabIndex = 4;
            this.imgview.UseCustomMouseEvent = false;
            this.imgview.ZoomPanModifierKey = System.Windows.Forms.Keys.None;
            // 
            // btLoad
            // 
            this.btLoad.BackColor = System.Drawing.Color.Transparent;
            this.btLoad.BorderColor = System.Drawing.Color.Empty;
            this.btLoad.BorderSize = 0;
            this.btLoad.Dock = System.Windows.Forms.DockStyle.Left;
            this.btLoad.FlatAppearance.BorderSize = 0;
            this.btLoad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.btLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.btLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLoad.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.btLoad.Location = new System.Drawing.Point(0, 0);
            this.btLoad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btLoad.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.btLoad.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(65, 32);
            this.btLoad.TabIndex = 1;
            this.btLoad.Text = "Load";
            this.btLoad.UseVisualStyleBackColor = false;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(966, 648);
            this.Controls.Add(this.imgview);
            this.Controls.Add(this.flatTitlePanel1);
            this.Controls.Add(this.logView1);
            this.Controls.Add(this.flatStatusBar1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.flatTitlePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.LogView logView1;
        private Abeo.Controls.ZeroCode.FlatStatusBar flatStatusBar1;
        private Abeo.Controls.ZeroCode.FlatTitlePanel flatTitlePanel1;
        private Abeo.Controls.ZeroCode.FlatFormButtonsHorizontal flatFormButtonsHorizontal1;
        private Abeo.Controls.FlatButton btLoad;
        private Controls.FastImageView imgview;
    }
}

