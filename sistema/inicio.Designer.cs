namespace sistema
{
    partial class inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.subpac = new System.Windows.Forms.Panel();
            this.mantcli = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.subrecord = new System.Windows.Forms.Panel();
            this.crear_r = new System.Windows.Forms.Button();
            this.buscar_r = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.subpac.SuspendLayout();
            this.subrecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.subrecord);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.subpac);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 585);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 15);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 81);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(0, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pacientes";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // subpac
            // 
            this.subpac.BackColor = System.Drawing.Color.DarkGreen;
            this.subpac.Controls.Add(this.mantcli);
            this.subpac.Dock = System.Windows.Forms.DockStyle.Top;
            this.subpac.Location = new System.Drawing.Point(0, 245);
            this.subpac.Name = "subpac";
            this.subpac.Size = new System.Drawing.Size(170, 43);
            this.subpac.TabIndex = 2;
            this.subpac.Visible = false;
            // 
            // mantcli
            // 
            this.mantcli.BackColor = System.Drawing.Color.DarkGreen;
            this.mantcli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mantcli.Dock = System.Windows.Forms.DockStyle.Top;
            this.mantcli.FlatAppearance.BorderSize = 0;
            this.mantcli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.mantcli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mantcli.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mantcli.Location = new System.Drawing.Point(0, 0);
            this.mantcli.Name = "mantcli";
            this.mantcli.Size = new System.Drawing.Size(170, 38);
            this.mantcli.TabIndex = 2;
            this.mantcli.Text = "       Mantenimiento";
            this.mantcli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mantcli.UseVisualStyleBackColor = false;
            this.mantcli.Click += new System.EventHandler(this.mantcli_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Green;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(0, 288);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(170, 37);
            this.button5.TabIndex = 2;
            this.button5.Text = "Records";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // subrecord
            // 
            this.subrecord.BackColor = System.Drawing.Color.DarkGreen;
            this.subrecord.Controls.Add(this.buscar_r);
            this.subrecord.Controls.Add(this.crear_r);
            this.subrecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.subrecord.Location = new System.Drawing.Point(0, 325);
            this.subrecord.Name = "subrecord";
            this.subrecord.Size = new System.Drawing.Size(170, 77);
            this.subrecord.TabIndex = 2;
            this.subrecord.Visible = false;
            // 
            // crear_r
            // 
            this.crear_r.Dock = System.Windows.Forms.DockStyle.Top;
            this.crear_r.FlatAppearance.BorderSize = 0;
            this.crear_r.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.crear_r.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crear_r.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crear_r.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.crear_r.Location = new System.Drawing.Point(0, 0);
            this.crear_r.Name = "crear_r";
            this.crear_r.Size = new System.Drawing.Size(170, 36);
            this.crear_r.TabIndex = 2;
            this.crear_r.Text = "      Crear Nuevo";
            this.crear_r.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.crear_r.UseVisualStyleBackColor = true;
            this.crear_r.Click += new System.EventHandler(this.crear_r_Click);
            // 
            // buscar_r
            // 
            this.buscar_r.Dock = System.Windows.Forms.DockStyle.Top;
            this.buscar_r.FlatAppearance.BorderSize = 0;
            this.buscar_r.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.buscar_r.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscar_r.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_r.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buscar_r.Location = new System.Drawing.Point(0, 36);
            this.buscar_r.Name = "buscar_r";
            this.buscar_r.Size = new System.Drawing.Size(170, 36);
            this.buscar_r.TabIndex = 3;
            this.buscar_r.Text = "      Buscar";
            this.buscar_r.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscar_r.UseVisualStyleBackColor = true;
            this.buscar_r.Click += new System.EventHandler(this.buscar_r_Click);
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(739, 585);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.subpac.ResumeLayout(false);
            this.subrecord.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel subpac;
        private System.Windows.Forms.Button mantcli;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel subrecord;
        private System.Windows.Forms.Button crear_r;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buscar_r;

    }
}