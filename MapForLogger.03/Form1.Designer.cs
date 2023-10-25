namespace MapForLogger._03
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
            this.mapControl = new System.Windows.Forms.MapControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_file = new System.Windows.Forms.TextBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapControl
            // 
            this.mapControl.Cursor = System.Windows.Forms.Cursors.Cross;
            this.mapControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.mapControl.ErrorColor = System.Drawing.Color.Red;
            this.mapControl.FitToBounds = true;
            this.mapControl.Location = new System.Drawing.Point(0, 0);
            this.mapControl.Name = "mapControl";
            this.mapControl.ShowThumbnails = true;
            this.mapControl.Size = new System.Drawing.Size(952, 601);
            this.mapControl.TabIndex = 0;
            this.mapControl.Text = "mapControl1";
            this.mapControl.ThumbnailBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mapControl.ThumbnailForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.mapControl.ThumbnailText = "Downloading...";
            this.mapControl.TileImageAttributes = null;
            this.mapControl.ZoomLevel = 0;
            this.mapControl.Click += new System.EventHandler(this.mapControl_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_show);
            this.panel1.Controls.Add(this.tb_file);
            this.panel1.Controls.Add(this.btn_load);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(958, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 601);
            this.panel1.TabIndex = 1;
            // 
            // tb_file
            // 
            this.tb_file.Location = new System.Drawing.Point(19, 94);
            this.tb_file.Name = "tb_file";
            this.tb_file.Size = new System.Drawing.Size(153, 22);
            this.tb_file.TabIndex = 1;
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(19, 30);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(153, 34);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "Load File";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(19, 154);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(153, 33);
            this.btn_show.TabIndex = 2;
            this.btn_show.Text = "Show Track";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1158, 601);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mapControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MapControl mapControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.TextBox tb_file;
        private System.Windows.Forms.Button btn_show;
    }
}

