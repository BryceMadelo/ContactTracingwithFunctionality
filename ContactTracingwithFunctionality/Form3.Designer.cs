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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.labl3rdform = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lablName = new System.Windows.Forms.Label();
            this.TxtBoxNm = new System.Windows.Forms.TextBox();
            this.TxtboxAge = new System.Windows.Forms.TextBox();
            this.lablAge = new System.Windows.Forms.Label();
            this.lablSex = new System.Windows.Forms.Label();
            this.cmbboxSex = new System.Windows.Forms.ComboBox();
            this.DDateofVisit = new System.Windows.Forms.DateTimePicker();
            this.lablVisitDt = new System.Windows.Forms.Label();
            this.TxtboxPhNum = new System.Windows.Forms.TextBox();
            this.lablPhNum = new System.Windows.Forms.Label();
            this.lablAddress = new System.Windows.Forms.Label();
            this.TxtboxAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbboxVaxx = new System.Windows.Forms.ComboBox();
            this.cmbboxContact = new System.Windows.Forms.ComboBox();
            this.cmbboxTraveled = new System.Windows.Forms.ComboBox();
            this.cmbboxDiff = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbboxSore = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lablQ2 = new System.Windows.Forms.Label();
            this.cmbboxRunny = new System.Windows.Forms.ComboBox();
            this.cmbboxLoss = new System.Windows.Forms.ComboBox();
            this.cmbboxFever = new System.Windows.Forms.ComboBox();
            this.cmbboxCough = new System.Windows.Forms.ComboBox();
            this.lablDifficulty = new System.Windows.Forms.Label();
            this.lablLoss = new System.Windows.Forms.Label();
            this.lablNose = new System.Windows.Forms.Label();
            this.lablSore = new System.Windows.Forms.Label();
            this.lablFever = new System.Windows.Forms.Label();
            this.lablCough = new System.Windows.Forms.Label();
            this.lablQ1 = new System.Windows.Forms.Label();
            this.btnSavenSub = new System.Windows.Forms.Button();
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
            this.btnBack.Location = new System.Drawing.Point(12, 502);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.dataGridView1.Size = new System.Drawing.Size(1064, 457);
            this.dataGridView1.TabIndex = 22;
            // 
            // lablName
            // 
            this.lablName.AutoSize = true;
            this.lablName.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lablName.Location = new System.Drawing.Point(367, 59);
            this.lablName.Name = "lablName";
            this.lablName.Size = new System.Drawing.Size(64, 22);
            this.lablName.TabIndex = 140;
            this.lablName.Text = "Name ";
            // 
            // TxtBoxNm
            // 
            this.TxtBoxNm.Location = new System.Drawing.Point(367, 84);
            this.TxtBoxNm.Multiline = true;
            this.TxtBoxNm.Name = "TxtBoxNm";
            this.TxtBoxNm.Size = new System.Drawing.Size(242, 28);
            this.TxtBoxNm.TabIndex = 139;
            // 
            // TxtboxAge
            // 
            this.TxtboxAge.Location = new System.Drawing.Point(632, 84);
            this.TxtboxAge.Multiline = true;
            this.TxtboxAge.Name = "TxtboxAge";
            this.TxtboxAge.Size = new System.Drawing.Size(75, 28);
            this.TxtboxAge.TabIndex = 145;
            // 
            // lablAge
            // 
            this.lablAge.AutoSize = true;
            this.lablAge.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lablAge.Location = new System.Drawing.Point(632, 59);
            this.lablAge.Name = "lablAge";
            this.lablAge.Size = new System.Drawing.Size(46, 22);
            this.lablAge.TabIndex = 144;
            this.lablAge.Text = "Age ";
            // 
            // lablSex
            // 
            this.lablSex.AutoSize = true;
            this.lablSex.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lablSex.Location = new System.Drawing.Point(722, 64);
            this.lablSex.Name = "lablSex";
            this.lablSex.Size = new System.Drawing.Size(40, 22);
            this.lablSex.TabIndex = 170;
            this.lablSex.Text = "Sex";
            // 
            // cmbboxSex
            // 
            this.cmbboxSex.FormattingEnabled = true;
            this.cmbboxSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbboxSex.Location = new System.Drawing.Point(722, 89);
            this.cmbboxSex.Name = "cmbboxSex";
            this.cmbboxSex.Size = new System.Drawing.Size(121, 23);
            this.cmbboxSex.TabIndex = 169;
            // 
            // DDateofVisit
            // 
            this.DDateofVisit.Location = new System.Drawing.Point(859, 89);
            this.DDateofVisit.Name = "DDateofVisit";
            this.DDateofVisit.Size = new System.Drawing.Size(201, 23);
            this.DDateofVisit.TabIndex = 172;
            // 
            // lablVisitDt
            // 
            this.lablVisitDt.AutoSize = true;
            this.lablVisitDt.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lablVisitDt.Location = new System.Drawing.Point(859, 64);
            this.lablVisitDt.Name = "lablVisitDt";
            this.lablVisitDt.Size = new System.Drawing.Size(115, 22);
            this.lablVisitDt.TabIndex = 171;
            this.lablVisitDt.Text = "Date of Visit";
            // 
            // TxtboxPhNum
            // 
            this.TxtboxPhNum.Location = new System.Drawing.Point(359, 139);
            this.TxtboxPhNum.Multiline = true;
            this.TxtboxPhNum.Name = "TxtboxPhNum";
            this.TxtboxPhNum.Size = new System.Drawing.Size(242, 28);
            this.TxtboxPhNum.TabIndex = 176;
            // 
            // lablPhNum
            // 
            this.lablPhNum.AutoSize = true;
            this.lablPhNum.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lablPhNum.Location = new System.Drawing.Point(359, 114);
            this.lablPhNum.Name = "lablPhNum";
            this.lablPhNum.Size = new System.Drawing.Size(140, 22);
            this.lablPhNum.TabIndex = 175;
            this.lablPhNum.Text = "Phone Number";
            // 
            // lablAddress
            // 
            this.lablAddress.AutoSize = true;
            this.lablAddress.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lablAddress.Location = new System.Drawing.Point(632, 115);
            this.lablAddress.Name = "lablAddress";
            this.lablAddress.Size = new System.Drawing.Size(85, 22);
            this.lablAddress.TabIndex = 174;
            this.lablAddress.Text = "Address ";
            // 
            // TxtboxAdd
            // 
            this.TxtboxAdd.Location = new System.Drawing.Point(632, 140);
            this.TxtboxAdd.Multiline = true;
            this.TxtboxAdd.Name = "TxtboxAdd";
            this.TxtboxAdd.Size = new System.Drawing.Size(444, 27);
            this.TxtboxAdd.TabIndex = 173;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Cambria", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(359, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(479, 40);
            this.label2.TabIndex = 177;
            this.label2.Text = "HEALTH DECLARATION FORM";
            // 
            // cmbboxVaxx
            // 
            this.cmbboxVaxx.FormattingEnabled = true;
            this.cmbboxVaxx.Items.AddRange(new object[] {
            "Yes, I\'m Fully Vaccinated",
            "Yes, I\'m Fully Vaccinated with Booster Shot",
            "No"});
            this.cmbboxVaxx.Location = new System.Drawing.Point(804, 385);
            this.cmbboxVaxx.Name = "cmbboxVaxx";
            this.cmbboxVaxx.Size = new System.Drawing.Size(194, 23);
            this.cmbboxVaxx.TabIndex = 196;
            // 
            // cmbboxContact
            // 
            this.cmbboxContact.FormattingEnabled = true;
            this.cmbboxContact.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbboxContact.Location = new System.Drawing.Point(821, 280);
            this.cmbboxContact.Name = "cmbboxContact";
            this.cmbboxContact.Size = new System.Drawing.Size(121, 23);
            this.cmbboxContact.TabIndex = 195;
            // 
            // cmbboxTraveled
            // 
            this.cmbboxTraveled.FormattingEnabled = true;
            this.cmbboxTraveled.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbboxTraveled.Location = new System.Drawing.Point(821, 334);
            this.cmbboxTraveled.Name = "cmbboxTraveled";
            this.cmbboxTraveled.Size = new System.Drawing.Size(121, 23);
            this.cmbboxTraveled.TabIndex = 189;
            // 
            // cmbboxDiff
            // 
            this.cmbboxDiff.FormattingEnabled = true;
            this.cmbboxDiff.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbboxDiff.Location = new System.Drawing.Point(434, 426);
            this.cmbboxDiff.Name = "cmbboxDiff";
            this.cmbboxDiff.Size = new System.Drawing.Size(121, 23);
            this.cmbboxDiff.TabIndex = 194;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(602, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 17);
            this.label4.TabIndex = 184;
            this.label4.Text = "Have you received vaccine doses?";
            // 
            // cmbboxSore
            // 
            this.cmbboxSore.FormattingEnabled = true;
            this.cmbboxSore.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbboxSore.Location = new System.Drawing.Point(435, 339);
            this.cmbboxSore.Name = "cmbboxSore";
            this.cmbboxSore.Size = new System.Drawing.Size(121, 23);
            this.cmbboxSore.TabIndex = 193;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(622, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 34);
            this.label3.TabIndex = 185;
            this.label3.Text = "Have you traveled outside the \r\ncountry in the last 14 days? \r\n";
            // 
            // lablQ2
            // 
            this.lablQ2.AutoSize = true;
            this.lablQ2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lablQ2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lablQ2.Location = new System.Drawing.Point(622, 277);
            this.lablQ2.Name = "lablQ2";
            this.lablQ2.Size = new System.Drawing.Size(193, 34);
            this.lablQ2.TabIndex = 186;
            this.lablQ2.Text = "Have you been in close contact \r\nwith a Covid - 19 case? \r\n";
            // 
            // cmbboxRunny
            // 
            this.cmbboxRunny.FormattingEnabled = true;
            this.cmbboxRunny.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbboxRunny.Location = new System.Drawing.Point(435, 368);
            this.cmbboxRunny.Name = "cmbboxRunny";
            this.cmbboxRunny.Size = new System.Drawing.Size(121, 23);
            this.cmbboxRunny.TabIndex = 192;
            // 
            // cmbboxLoss
            // 
            this.cmbboxLoss.FormattingEnabled = true;
            this.cmbboxLoss.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbboxLoss.Location = new System.Drawing.Point(434, 397);
            this.cmbboxLoss.Name = "cmbboxLoss";
            this.cmbboxLoss.Size = new System.Drawing.Size(121, 23);
            this.cmbboxLoss.TabIndex = 191;
            // 
            // cmbboxFever
            // 
            this.cmbboxFever.FormattingEnabled = true;
            this.cmbboxFever.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbboxFever.Location = new System.Drawing.Point(435, 309);
            this.cmbboxFever.Name = "cmbboxFever";
            this.cmbboxFever.Size = new System.Drawing.Size(121, 23);
            this.cmbboxFever.TabIndex = 190;
            // 
            // cmbboxCough
            // 
            this.cmbboxCough.FormattingEnabled = true;
            this.cmbboxCough.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbboxCough.Location = new System.Drawing.Point(435, 277);
            this.cmbboxCough.Name = "cmbboxCough";
            this.cmbboxCough.Size = new System.Drawing.Size(121, 23);
            this.cmbboxCough.TabIndex = 188;
            // 
            // lablDifficulty
            // 
            this.lablDifficulty.AutoSize = true;
            this.lablDifficulty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lablDifficulty.Location = new System.Drawing.Point(368, 426);
            this.lablDifficulty.Name = "lablDifficulty";
            this.lablDifficulty.Size = new System.Drawing.Size(58, 30);
            this.lablDifficulty.TabIndex = 183;
            this.lablDifficulty.Text = "Difficulty \r\nBreathing";
            // 
            // lablLoss
            // 
            this.lablLoss.AutoSize = true;
            this.lablLoss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lablLoss.Location = new System.Drawing.Point(355, 400);
            this.lablLoss.Name = "lablLoss";
            this.lablLoss.Size = new System.Drawing.Size(73, 15);
            this.lablLoss.TabIndex = 181;
            this.lablLoss.Text = "Loss of Taste";
            // 
            // lablNose
            // 
            this.lablNose.AutoSize = true;
            this.lablNose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lablNose.Location = new System.Drawing.Point(355, 371);
            this.lablNose.Name = "lablNose";
            this.lablNose.Size = new System.Drawing.Size(71, 15);
            this.lablNose.TabIndex = 180;
            this.lablNose.Text = "Runny Nose";
            // 
            // lablSore
            // 
            this.lablSore.AutoSize = true;
            this.lablSore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lablSore.Location = new System.Drawing.Point(359, 342);
            this.lablSore.Name = "lablSore";
            this.lablSore.Size = new System.Drawing.Size(67, 15);
            this.lablSore.TabIndex = 179;
            this.lablSore.Text = "Sore Throat";
            // 
            // lablFever
            // 
            this.lablFever.AutoSize = true;
            this.lablFever.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lablFever.Location = new System.Drawing.Point(391, 309);
            this.lablFever.Name = "lablFever";
            this.lablFever.Size = new System.Drawing.Size(35, 15);
            this.lablFever.TabIndex = 178;
            this.lablFever.Text = "Fever";
            // 
            // lablCough
            // 
            this.lablCough.AutoSize = true;
            this.lablCough.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lablCough.Location = new System.Drawing.Point(383, 280);
            this.lablCough.Name = "lablCough";
            this.lablCough.Size = new System.Drawing.Size(43, 15);
            this.lablCough.TabIndex = 182;
            this.lablCough.Text = "Cough";
            // 
            // lablQ1
            // 
            this.lablQ1.AutoSize = true;
            this.lablQ1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lablQ1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lablQ1.Location = new System.Drawing.Point(364, 235);
            this.lablQ1.Name = "lablQ1";
            this.lablQ1.Size = new System.Drawing.Size(252, 34);
            this.lablQ1.TabIndex = 187;
            this.lablQ1.Text = "Have you been experiencing the following\r\nsymptomps in the past 14 days?";
            // 
            // btnSavenSub
            // 
            this.btnSavenSub.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSavenSub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSavenSub.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSavenSub.Location = new System.Drawing.Point(632, 461);
            this.btnSavenSub.Name = "btnSavenSub";
            this.btnSavenSub.Size = new System.Drawing.Size(140, 26);
            this.btnSavenSub.TabIndex = 197;
            this.btnSavenSub.Text = "Save and Submit";
            this.btnSavenSub.UseVisualStyleBackColor = false;
            this.btnSavenSub.Click += new System.EventHandler(this.btnSavenSub_Click);
            // 
            // QRScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 538);
            this.Controls.Add(this.btnSavenSub);
            this.Controls.Add(this.cmbboxVaxx);
            this.Controls.Add(this.cmbboxContact);
            this.Controls.Add(this.cmbboxTraveled);
            this.Controls.Add(this.cmbboxDiff);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbboxSore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lablQ2);
            this.Controls.Add(this.cmbboxRunny);
            this.Controls.Add(this.cmbboxLoss);
            this.Controls.Add(this.cmbboxFever);
            this.Controls.Add(this.cmbboxCough);
            this.Controls.Add(this.lablDifficulty);
            this.Controls.Add(this.lablLoss);
            this.Controls.Add(this.lablNose);
            this.Controls.Add(this.lablSore);
            this.Controls.Add(this.lablFever);
            this.Controls.Add(this.lablCough);
            this.Controls.Add(this.lablQ1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtboxPhNum);
            this.Controls.Add(this.lablPhNum);
            this.Controls.Add(this.lablAddress);
            this.Controls.Add(this.TxtboxAdd);
            this.Controls.Add(this.DDateofVisit);
            this.Controls.Add(this.lablVisitDt);
            this.Controls.Add(this.lablSex);
            this.Controls.Add(this.cmbboxSex);
            this.Controls.Add(this.TxtboxAge);
            this.Controls.Add(this.lablAge);
            this.Controls.Add(this.lablName);
            this.Controls.Add(this.TxtBoxNm);
            this.Controls.Add(this.labl3rdform);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnStart);
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
        private Button btnStart;
        private Button btnBack;
        private System.Windows.Forms.Timer Timer;
        private Label labl3rdform;
        private DataGridView dataGridView1;
        private Label lablName;
        private TextBox TxtBoxNm;
        private TextBox TxtboxAge;
        private Label lablAge;
        private Label lablSex;
        private ComboBox cmbboxSex;
        private DateTimePicker DDateofVisit;
        private Label lablVisitDt;
        private TextBox TxtboxPhNum;
        private Label lablPhNum;
        private Label lablAddress;
        private TextBox TxtboxAdd;
        private Label label2;
        private ComboBox cmbboxVaxx;
        private ComboBox cmbboxContact;
        private ComboBox cmbboxTraveled;
        private ComboBox cmbboxDiff;
        private Label label4;
        private ComboBox cmbboxSore;
        private Label label3;
        private Label lablQ2;
        private ComboBox cmbboxRunny;
        private ComboBox cmbboxLoss;
        private ComboBox cmbboxFever;
        private ComboBox cmbboxCough;
        private Label lablDifficulty;
        private Label lablLoss;
        private Label lablNose;
        private Label lablSore;
        private Label lablFever;
        private Label lablCough;
        private Label lablQ1;
        private Button btnSavenSub;
    }
}