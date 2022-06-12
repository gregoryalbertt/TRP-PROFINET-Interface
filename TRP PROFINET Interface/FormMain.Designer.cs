namespace PROFINET_STEP_7
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.cboxPLCs = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIPaddress = new System.Windows.Forms.TextBox();
            this.btnConnection = new System.Windows.Forms.Button();
            this.btnDisconnection = new System.Windows.Forms.Button();
            this.groupBoxConnection = new System.Windows.Forms.GroupBox();
            this.status = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.watchdog_time = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownSlot = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRack = new System.Windows.Forms.NumericUpDown();
            this.btnWriteReal = new System.Windows.Forms.Button();
            this.btnReadReal = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.debug_read = new System.Windows.Forms.TextBox();
            this.debug_value = new System.Windows.Forms.TextBox();
            this.groupBoxConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRack)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLC Model";
            // 
            // cboxPLCs
            // 
            this.cboxPLCs.FormattingEnabled = true;
            this.cboxPLCs.Items.AddRange(new object[] {
            "S7-200",
            "S7-300",
            "S7-400",
            "S7-1200",
            "S7-1500"});
            this.cboxPLCs.Location = new System.Drawing.Point(98, 26);
            this.cboxPLCs.Name = "cboxPLCs";
            this.cboxPLCs.Size = new System.Drawing.Size(175, 28);
            this.cboxPLCs.TabIndex = 1;
            this.cboxPLCs.SelectedIndexChanged += new System.EventHandler(this.cboxPLCs_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "IP Address";
            // 
            // txtIPaddress
            // 
            this.txtIPaddress.Location = new System.Drawing.Point(98, 61);
            this.txtIPaddress.Name = "txtIPaddress";
            this.txtIPaddress.Size = new System.Drawing.Size(175, 26);
            this.txtIPaddress.TabIndex = 2;
            this.txtIPaddress.Text = "192.168.0.1";
            this.txtIPaddress.TextChanged += new System.EventHandler(this.txtIPaddress_TextChanged);
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(279, 22);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(115, 33);
            this.btnConnection.TabIndex = 3;
            this.btnConnection.Text = "Connect";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // btnDisconnection
            // 
            this.btnDisconnection.Location = new System.Drawing.Point(279, 62);
            this.btnDisconnection.Name = "btnDisconnection";
            this.btnDisconnection.Size = new System.Drawing.Size(115, 33);
            this.btnDisconnection.TabIndex = 3;
            this.btnDisconnection.Text = "Disconnect";
            this.btnDisconnection.UseVisualStyleBackColor = true;
            this.btnDisconnection.Click += new System.EventHandler(this.btnDisconnection_Click);
            // 
            // groupBoxConnection
            // 
            this.groupBoxConnection.Controls.Add(this.status);
            this.groupBoxConnection.Controls.Add(this.label4);
            this.groupBoxConnection.Controls.Add(this.label3);
            this.groupBoxConnection.Controls.Add(this.watchdog_time);
            this.groupBoxConnection.Controls.Add(this.label9);
            this.groupBoxConnection.Controls.Add(this.numericUpDownSlot);
            this.groupBoxConnection.Controls.Add(this.numericUpDownRack);
            this.groupBoxConnection.Controls.Add(this.btnWriteReal);
            this.groupBoxConnection.Controls.Add(this.btnReadReal);
            this.groupBoxConnection.Controls.Add(this.txtIPaddress);
            this.groupBoxConnection.Controls.Add(this.btnDisconnection);
            this.groupBoxConnection.Controls.Add(this.label1);
            this.groupBoxConnection.Controls.Add(this.label8);
            this.groupBoxConnection.Controls.Add(this.btnConnection);
            this.groupBoxConnection.Controls.Add(this.label7);
            this.groupBoxConnection.Controls.Add(this.label2);
            this.groupBoxConnection.Controls.Add(this.cboxPLCs);
            this.groupBoxConnection.Location = new System.Drawing.Point(12, 12);
            this.groupBoxConnection.Name = "groupBoxConnection";
            this.groupBoxConnection.Size = new System.Drawing.Size(408, 222);
            this.groupBoxConnection.TabIndex = 4;
            this.groupBoxConnection.TabStop = false;
            this.groupBoxConnection.Text = "Connection";
            this.groupBoxConnection.Enter += new System.EventHandler(this.groupBoxConnection_Enter);
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(82, 190);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(190, 26);
            this.status.TabIndex = 17;
            this.status.Text = "1";
            this.status.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Trigger";
            // 
            // watchdog_time
            // 
            this.watchdog_time.Location = new System.Drawing.Point(171, 162);
            this.watchdog_time.Name = "watchdog_time";
            this.watchdog_time.Size = new System.Drawing.Size(102, 26);
            this.watchdog_time.TabIndex = 6;
            this.watchdog_time.Text = "1";
            this.watchdog_time.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Watchdog time: (ms)";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // numericUpDownSlot
            // 
            this.numericUpDownSlot.Location = new System.Drawing.Point(82, 130);
            this.numericUpDownSlot.Name = "numericUpDownSlot";
            this.numericUpDownSlot.Size = new System.Drawing.Size(190, 26);
            this.numericUpDownSlot.TabIndex = 4;
            this.numericUpDownSlot.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownRack
            // 
            this.numericUpDownRack.Location = new System.Drawing.Point(82, 96);
            this.numericUpDownRack.Name = "numericUpDownRack";
            this.numericUpDownRack.Size = new System.Drawing.Size(190, 26);
            this.numericUpDownRack.TabIndex = 4;
            // 
            // btnWriteReal
            // 
            this.btnWriteReal.Location = new System.Drawing.Point(282, 187);
            this.btnWriteReal.Name = "btnWriteReal";
            this.btnWriteReal.Size = new System.Drawing.Size(112, 31);
            this.btnWriteReal.TabIndex = 14;
            this.btnWriteReal.Text = "Write data ";
            this.btnWriteReal.UseVisualStyleBackColor = true;
            this.btnWriteReal.Click += new System.EventHandler(this.btnWriteReal_Click);
            // 
            // btnReadReal
            // 
            this.btnReadReal.Location = new System.Drawing.Point(282, 151);
            this.btnReadReal.Name = "btnReadReal";
            this.btnReadReal.Size = new System.Drawing.Size(112, 31);
            this.btnReadReal.TabIndex = 12;
            this.btnReadReal.Text = "Read data";
            this.btnReadReal.UseVisualStyleBackColor = true;
            this.btnReadReal.Click += new System.EventHandler(this.btnReadReal_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Slot:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Rack:";
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(294, 237);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(112, 38);
            this.btnAbout.TabIndex = 9;
            this.btnAbout.Text = "ABOUT";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // debug_read
            // 
            this.debug_read.Location = new System.Drawing.Point(12, 240);
            this.debug_read.Name = "debug_read";
            this.debug_read.Size = new System.Drawing.Size(129, 26);
            this.debug_read.TabIndex = 18;
            this.debug_read.Text = "DB4809.DBW16";
            this.debug_read.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // debug_value
            // 
            this.debug_value.Location = new System.Drawing.Point(182, 240);
            this.debug_value.Name = "debug_value";
            this.debug_value.Size = new System.Drawing.Size(102, 26);
            this.debug_value.TabIndex = 19;
            this.debug_value.Text = "0";
            this.debug_value.TextChanged += new System.EventHandler(this.debug_value_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 277);
            this.Controls.Add(this.debug_value);
            this.Controls.Add(this.debug_read);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.groupBoxConnection);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 324);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 324);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRP PROFINET Interface";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxConnection.ResumeLayout(false);
            this.groupBoxConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxPLCs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIPaddress;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Button btnDisconnection;
        private System.Windows.Forms.GroupBox groupBoxConnection;
        private System.Windows.Forms.Button btnReadReal;
        private System.Windows.Forms.Button btnWriteReal;
        private System.Windows.Forms.NumericUpDown numericUpDownSlot;
        private System.Windows.Forms.NumericUpDown numericUpDownRack;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox watchdog_time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox debug_read;
        private System.Windows.Forms.TextBox debug_value;
    }
}