namespace ContactTracingwithFunctionality
{
    partial class QRScanner
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
            this.txtboxResult = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lablResult = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.labl3rdform = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picboxQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lablCam
            // 
            this.lablCam.AutoSize = true;
            this.lablCam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lablCam.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lablCam.Location = new System.Drawing.Point(39, 62);
            this.lablCam.Name = "lablCam";
            this.lablCam.Size = new System.Drawing.Size(65, 19);
            this.lablCam.TabIndex = 0;
            this.lablCam.Text = "Camera";
            // 
            // cmbboxDevice
            // 
            this.cmbboxDevice.FormattingEnabled = true;
            this.cmbboxDevice.Location = new System.Drawing.Point(110, 62);
            this.cmbboxDevice.Name = "cmbboxDevice";
            this.cmbboxDevice.Size = new System.Drawing.Size(232, 23);
            this.cmbboxDevice.TabIndex = 1;
            // 
            // picboxQR
            // 
            this.picboxQR.Location = new System.Drawing.Point(39, 91);
            this.picboxQR.Name = "picboxQR";
            this.picboxQR.Size = new System.Drawing.Size(303, 240);
            this.picboxQR.TabIndex = 2;
            this.picboxQR.TabStop = false;
            // 
            // txtboxResult
            // 
            this.txtboxResult.Location = new System.Drawing.Point(365, 91);
            this.txtboxResult.Multiline = true;
            this.txtboxResult.Name = "txtboxResult";
            this.txtboxResult.Size = new System.Drawing.Size(314, 248);
            this.txtboxResult.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(267, 337);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 27);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(12, 390);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lablResult
            // 
            this.lablResult.AutoSize = true;
            this.lablResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lablResult.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lablResult.Location = new System.Drawing.Point(399, 66);
            this.lablResult.Name = "lablResult";
            this.lablResult.Size = new System.Drawing.Size(219, 22);
            this.lablResult.TabIndex = 6;
            this.lablResult.Text = "Scanned QR Code Result";
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // labl3rdform
            // 
            this.labl3rdform.AutoSize = true;
            this.labl3rdform.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labl3rdform.ForeColor = System.Drawing.Color.Maroon;
            this.labl3rdform.Location = new System.Drawing.Point(236, 8);
            this.labl3rdform.Name = "labl3rdform";
            this.labl3rdform.Size = new System.Drawing.Size(221, 28);
            this.labl3rdform.TabIndex = 7;
            this.labl3rdform.Text = "QR CODE SCANNER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(691, 345);
            this.dataGridView1.TabIndex = 22;
            // 
            // QRScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 423);
            this.Controls.Add(this.labl3rdform);
            this.Controls.Add(this.lablResult);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtboxResult);
            this.Controls.Add(this.picboxQR);
            this.Controls.Add(this.cmbboxDevice);
            this.Controls.Add(this.lablCam);
            this.Controls.Add(this.dataGridView1);
            this.Name = "QRScanner";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QRScanner_Closing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.QRScanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lablCam;
        private ComboBox cmbboxDevice;
        private PictureBox picboxQR;
        private TextBox txtboxResult;
        private Button btnStart;
        private Button btnBack;
        private Label lablResult;
        private System.Windows.Forms.Timer Timer;
        private Label labl3rdform;
        private DataGridView dataGridView1;
    }
}