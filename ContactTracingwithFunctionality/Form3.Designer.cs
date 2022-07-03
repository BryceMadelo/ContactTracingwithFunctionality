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
            ((System.ComponentModel.ISupportInitialize)(this.picboxQR)).BeginInit();
            this.SuspendLayout();
            // 
            // lablCam
            // 
            this.lablCam.AutoSize = true;
            this.lablCam.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lablCam.Location = new System.Drawing.Point(79, 53);
            this.lablCam.Name = "lablCam";
            this.lablCam.Size = new System.Drawing.Size(65, 19);
            this.lablCam.TabIndex = 0;
            this.lablCam.Text = "Camera";
            // 
            // cmbboxDevice
            // 
            this.cmbboxDevice.FormattingEnabled = true;
            this.cmbboxDevice.Location = new System.Drawing.Point(150, 53);
            this.cmbboxDevice.Name = "cmbboxDevice";
            this.cmbboxDevice.Size = new System.Drawing.Size(244, 23);
            this.cmbboxDevice.TabIndex = 1;
            // 
            // picboxQR
            // 
            this.picboxQR.Location = new System.Drawing.Point(82, 82);
            this.picboxQR.Name = "picboxQR";
            this.picboxQR.Size = new System.Drawing.Size(312, 270);
            this.picboxQR.TabIndex = 2;
            this.picboxQR.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(319, 358);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 26);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtboxResult
            // 
            this.txtboxResult.Location = new System.Drawing.Point(424, 82);
            this.txtboxResult.Multiline = true;
            this.txtboxResult.Name = "txtboxResult";
            this.txtboxResult.Size = new System.Drawing.Size(257, 270);
            this.txtboxResult.TabIndex = 4;
            // 
            // lablresult
            // 
            this.lablresult.AutoSize = true;
            this.lablresult.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lablresult.Location = new System.Drawing.Point(456, 54);
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
            // QRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 418);
            this.Controls.Add(this.lablresult);
            this.Controls.Add(this.txtboxResult);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.picboxQR);
            this.Controls.Add(this.cmbboxDevice);
            this.Controls.Add(this.lablCam);
            this.Name = "QRCode";
            this.Text = "QR CODE GENERATOR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QRCode_Closing);
            this.Load += new System.EventHandler(this.QRCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxQR)).EndInit();
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
    }
}