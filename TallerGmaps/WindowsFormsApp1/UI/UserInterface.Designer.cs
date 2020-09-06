namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.cbMuni = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.direc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLp = new System.Windows.Forms.ComboBox();
            this.cbAd = new System.Windows.Forms.ComboBox();
            this.ltest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(13, 13);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(535, 426);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.Load += new System.EventHandler(this.Gmap_Load);
            // 
            // cbMuni
            // 
            this.cbMuni.FormattingEnabled = true;
            this.cbMuni.Location = new System.Drawing.Point(553, 122);
            this.cbMuni.Name = "cbMuni";
            this.cbMuni.Size = new System.Drawing.Size(223, 21);
            this.cbMuni.TabIndex = 1;
            this.cbMuni.SelectedIndexChanged += new System.EventHandler(this.cbMuni_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Load Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // direc
            // 
            this.direc.Location = new System.Drawing.Point(554, 58);
            this.direc.Name = "direc";
            this.direc.Size = new System.Drawing.Size(223, 20);
            this.direc.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(554, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Municipality";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(554, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Location point";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(554, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address";
            // 
            // cbLp
            // 
            this.cbLp.FormattingEnabled = true;
            this.cbLp.Location = new System.Drawing.Point(553, 184);
            this.cbLp.Name = "cbLp";
            this.cbLp.Size = new System.Drawing.Size(223, 21);
            this.cbLp.TabIndex = 7;
            this.cbLp.SelectedIndexChanged += new System.EventHandler(this.cbLp_SelectedIndexChanged);
            // 
            // cbAd
            // 
            this.cbAd.FormattingEnabled = true;
            this.cbAd.Location = new System.Drawing.Point(553, 260);
            this.cbAd.Name = "cbAd";
            this.cbAd.Size = new System.Drawing.Size(223, 21);
            this.cbAd.TabIndex = 8;
            this.cbAd.SelectedIndexChanged += new System.EventHandler(this.cbAd_SelectedIndexChanged);
            // 
            // ltest
            // 
            this.ltest.AutoSize = true;
            this.ltest.Location = new System.Drawing.Point(554, 305);
            this.ltest.Name = "ltest";
            this.ltest.Size = new System.Drawing.Size(74, 13);
            this.ltest.TabIndex = 9;
            this.ltest.Text = "Location point";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ltest);
            this.Controls.Add(this.cbAd);
            this.Controls.Add(this.cbLp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.direc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbMuni);
            this.Controls.Add(this.gMapControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.ComboBox cbMuni;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox direc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLp;
        private System.Windows.Forms.ComboBox cbAd;
        private System.Windows.Forms.Label ltest;
    }
}

