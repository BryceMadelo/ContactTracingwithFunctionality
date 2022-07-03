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
            this.btnGenerator = new System.Windows.Forms.Button();
            this.picboxQR = new System.Windows.Forms.PictureBox();
            this.lablScan = new System.Windows.Forms.Label();
            this.txtboxQR = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxQR)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerator
            // 
            this.btnGenerator.Location = new System.Drawing.Point(245, 281);
            this.btnGenerator.Name = "btnGenerator";
            this.btnGenerator.Size = new System.Drawing.Size(121, 23);
            this.btnGenerator.TabIndex = 0;
            this.btnGenerator.Text = "Generate QR Code";
            this.btnGenerator.UseVisualStyleBackColor = true;
            this.btnGenerator.Click += new System.EventHandler(this.btnGenerator_Click);
            // 
            // picboxQR
            // 
            this.picboxQR.Location = new System.Drawing.Point(24, 47);
            this.picboxQR.Name = "picboxQR";
            this.picboxQR.Size = new System.Drawing.Size(342, 199);
            this.picboxQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxQR.TabIndex = 1;
            this.picboxQR.TabStop = false;
            // 
            // lablScan
            // 
            this.lablScan.AutoSize = true;
            this.lablScan.Location = new System.Drawing.Point(24, 29);
            this.lablScan.Name = "lablScan";
            this.lablScan.Size = new System.Drawing.Size(75, 15);
            this.lablScan.TabIndex = 2;
            this.lablScan.Text = "Scan qr code";
            // 
            // txtboxQR
            // 
            this.txtboxQR.Location = new System.Drawing.Point(24, 252);
            this.txtboxQR.Name = "txtboxQR";
            this.txtboxQR.Size = new System.Drawing.Size(342, 23);
            this.txtboxQR.TabIndex = 3;
            // 
            // QRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 418);
            this.Controls.Add(this.txtboxQR);
            this.Controls.Add(this.lablScan);
            this.Controls.Add(this.picboxQR);
            this.Controls.Add(this.btnGenerator);
            this.Name = "QRCode";
            this.Text = "QR CODE GENERATOR";
            ((System.ComponentModel.ISupportInitialize)(this.picboxQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGenerator;
        private PictureBox picboxQR;
        private Label lablScan;
        private TextBox txtboxQR;
    }
}