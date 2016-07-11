namespace SystemMonitor
{
    partial class FrSMServer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrSMServer));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dgList = new SystemMonitor.Dgv();
            this.Pilih = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._IPAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MacAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRestartSelected = new System.Windows.Forms.Button();
            this.btnRestartAll = new System.Windows.Forms.Button();
            this.btnShutdownSelected = new System.Windows.Forms.Button();
            this.btnShutdownAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dgList
            // 
            this.dgList.AllowUserToAddRows = false;
            this.dgList.AllowUserToDeleteRows = false;
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pilih,
            this.PC,
            this._IPAddress,
            this.MacAddress,
            this.State,
            this.Desc});
            this.dgList.Location = new System.Drawing.Point(23, 130);
            this.dgList.Name = "dgList";
            this.dgList.Size = new System.Drawing.Size(747, 369);
            this.dgList.TabIndex = 0;
            this.dgList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgList_CellClick);
            // 
            // Pilih
            // 
            this.Pilih.FalseValue = "False";
            this.Pilih.HeaderText = "";
            this.Pilih.Name = "Pilih";
            this.Pilih.TrueValue = "True";
            this.Pilih.Width = 40;
            // 
            // PC
            // 
            this.PC.HeaderText = "PC";
            this.PC.Name = "PC";
            this.PC.Width = 50;
            // 
            // _IPAddress
            // 
            this._IPAddress.HeaderText = "IP Address";
            this._IPAddress.Name = "_IPAddress";
            // 
            // MacAddress
            // 
            this.MacAddress.HeaderText = "Mac Address";
            this.MacAddress.Name = "MacAddress";
            this.MacAddress.Width = 150;
            // 
            // State
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.State.DefaultCellStyle = dataGridViewCellStyle1;
            this.State.HeaderText = "State";
            this.State.Name = "State";
            this.State.Width = 50;
            // 
            // Desc
            // 
            this.Desc.HeaderText = "Description";
            this.Desc.Name = "Desc";
            this.Desc.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(309, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "SYSTEM MONITOR";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "System Monitor © 2015";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::SystemMonitor.Properties.Resources.minus;
            this.btnMinimize.Location = new System.Drawing.Point(863, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(17, 19);
            this.btnMinimize.TabIndex = 12;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(23, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(112, 118);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(679, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::SystemMonitor.Properties.Resources.closes;
            this.btnClose.Location = new System.Drawing.Point(886, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(17, 19);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SystemMonitor.Properties.Resources.preloader;
            this.pictureBox1.Location = new System.Drawing.Point(314, 501);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::SystemMonitor.Properties.Resources.exit1;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(776, 458);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 41);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRestartSelected
            // 
            this.btnRestartSelected.BackColor = System.Drawing.Color.Transparent;
            this.btnRestartSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestartSelected.Image = global::SystemMonitor.Properties.Resources.restart_selected;
            this.btnRestartSelected.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestartSelected.Location = new System.Drawing.Point(776, 271);
            this.btnRestartSelected.Name = "btnRestartSelected";
            this.btnRestartSelected.Size = new System.Drawing.Size(112, 41);
            this.btnRestartSelected.TabIndex = 4;
            this.btnRestartSelected.Text = "Restart\n Selected";
            this.btnRestartSelected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestartSelected.UseVisualStyleBackColor = false;
            this.btnRestartSelected.Click += new System.EventHandler(this.btnRestartSelected_Click);
            // 
            // btnRestartAll
            // 
            this.btnRestartAll.BackColor = System.Drawing.Color.Transparent;
            this.btnRestartAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestartAll.Image = global::SystemMonitor.Properties.Resources.restart;
            this.btnRestartAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestartAll.Location = new System.Drawing.Point(776, 224);
            this.btnRestartAll.Name = "btnRestartAll";
            this.btnRestartAll.Size = new System.Drawing.Size(112, 41);
            this.btnRestartAll.TabIndex = 3;
            this.btnRestartAll.Text = "Restart All";
            this.btnRestartAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestartAll.UseVisualStyleBackColor = false;
            this.btnRestartAll.Click += new System.EventHandler(this.btnRestartAll_Click);
            // 
            // btnShutdownSelected
            // 
            this.btnShutdownSelected.BackColor = System.Drawing.Color.Transparent;
            this.btnShutdownSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutdownSelected.Image = global::SystemMonitor.Properties.Resources.shutdown_selected1;
            this.btnShutdownSelected.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShutdownSelected.Location = new System.Drawing.Point(776, 177);
            this.btnShutdownSelected.Name = "btnShutdownSelected";
            this.btnShutdownSelected.Size = new System.Drawing.Size(112, 41);
            this.btnShutdownSelected.TabIndex = 2;
            this.btnShutdownSelected.Text = "Shutdown\n Selected";
            this.btnShutdownSelected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShutdownSelected.UseVisualStyleBackColor = false;
            this.btnShutdownSelected.Click += new System.EventHandler(this.btnShutdownSelected_Click);
            // 
            // btnShutdownAll
            // 
            this.btnShutdownAll.BackColor = System.Drawing.Color.Transparent;
            this.btnShutdownAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutdownAll.Image = global::SystemMonitor.Properties.Resources.shutdown;
            this.btnShutdownAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShutdownAll.Location = new System.Drawing.Point(776, 130);
            this.btnShutdownAll.Name = "btnShutdownAll";
            this.btnShutdownAll.Size = new System.Drawing.Size(112, 41);
            this.btnShutdownAll.TabIndex = 1;
            this.btnShutdownAll.Text = "Shutdown All";
            this.btnShutdownAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShutdownAll.UseVisualStyleBackColor = false;
            this.btnShutdownAll.Click += new System.EventHandler(this.btnShutdownAll_Click);
            // 
            // FrSMServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::SystemMonitor.Properties.Resources.ipc_logo_bw;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(905, 523);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRestartSelected);
            this.Controls.Add(this.btnRestartAll);
            this.Controls.Add(this.btnShutdownSelected);
            this.Controls.Add(this.btnShutdownAll);
            this.Controls.Add(this.dgList);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrSMServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SM Server";
            this.Load += new System.EventHandler(this.FrSMServer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnShutdownAll;
        private System.Windows.Forms.Button btnShutdownSelected;
        private System.Windows.Forms.Button btnRestartAll;
        private System.Windows.Forms.Button btnRestartSelected;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Pilih;
        private System.Windows.Forms.DataGridViewTextBoxColumn PC;
        private System.Windows.Forms.DataGridViewTextBoxColumn _IPAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn MacAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMinimize;
        private Dgv dgList;
    }
}

