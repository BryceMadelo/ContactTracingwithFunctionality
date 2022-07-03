namespace ContactTracingwithFunctionality
{
    partial class QRCode
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
            this.lablCam = new System.Windows.Forms.Label();
            this.cmbboxDevice = new System.Windows.Forms.ComboBox();
            this.picboxQR = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtboxResult = new System.Windows.Forms.TextBox();
            this.lablresult = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lablCam
            // 
            this.lablCam.AutoSize = true;
            this.lablCam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lablCam.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lablCam.Location = new System.Drawing.Point(35, 57);
            this.lablCam.Name = "lablCam";
            this.lablCam.Size = new System.Drawing.Size(65, 19);
            this.lablCam.TabIndex = 0;
            this.lablCam.Text = "Camera";
            // 
            // cmbboxDevice
            // 
            this.cmbboxDevice.FormattingEnabled = true;
            this.cmbboxDevice.Location = new System.Drawing.Point(103, 57);
            this.cmbboxDevice.Name = "cmbboxDevice";
            this.cmbboxDevice.Size = new System.Drawing.Size(244, 23);
            this.cmbboxDevice.TabIndex = 1;
            // 
            // picboxQR
            // 
            this.picboxQR.Location = new System.Drawing.Point(35, 86);
            this.picboxQR.Name = "picboxQR";
            this.picboxQR.Size = new System.Drawing.Size(312, 270);
            this.picboxQR.TabIndex = 2;
            this.picboxQR.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(272, 362);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 26);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtboxResult
            // 
            this.txtboxResult.Location = new System.Drawing.Point(377, 95);
            this.txtboxResult.Multiline = true;
            this.txtboxResult.Name = "txtboxResult";
            this.txtboxResult.Size = new System.Drawing.Size(257, 270);
            this.txtboxResult.TabIndex = 4;
            // 
            // lablresult
            // 
            this.lablresult.AutoSize = true;
            this.lablresult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lablresult.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lablresult.Location = new System.Drawing.Point(410, 57);
            this.lablresult.Name = "lablresult";
            this.lablresult.Size = new System.Drawing.Size(192, 25);
            this.lablresult.TabIndex = 5;
            this.lablresult.Text = "Scanned Information";
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(657, 345);
            this.dataGridView1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(214, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "QR Code Scanner";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(591, 401);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 26);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // QRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 433);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lablresult);
            this.Controls.Add(this.txtboxResult);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.picboxQR);
            this.Controls.Add(this.cmbboxDevice);
            this.Controls.Add(this.lablCam);
            this.Controls.Add(this.dataGridView1);
            this.Name = "QRCode";
            this.Text = "QR CODE GENERATOR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QRCode_Closing);
            this.Load += new System.EventHandler(this.QRCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lablCam;
        private ComboBox cmbboxDevice;
        private PictureBox picboxQR;
        private Button btnStart;
        private TextBox txtboxResult;
        private Label lablresult;
        private System.Windows.Forms.Timer Timer;
        private DataGridView dataGridView1;
        private Label label1;
        private Button btnExit;
    }
}