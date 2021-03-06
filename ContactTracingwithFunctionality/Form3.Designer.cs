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
            this.btnSavenSub = new System.Windows.Forms.Button();
            this.lablName = new System.Windows.Forms.Label();
            this.TxtBoxNm1 = new System.Windows.Forms.TextBox();
            this.TxtboxAge2 = new System.Windows.Forms.TextBox();
            this.lablAge = new System.Windows.Forms.Label();
            this.lablSex = new System.Windows.Forms.Label();
            this.cmbboxSex3 = new System.Windows.Forms.ComboBox();
            this.DDateofVisit4 = new System.Windows.Forms.DateTimePicker();
            this.lablVisitDt = new System.Windows.Forms.Label();
            this.TxtboxPhNum5 = new System.Windows.Forms.TextBox();
            this.lablPhNum = new System.Windows.Forms.Label();
            this.lablAddress = new System.Windows.Forms.Label();
            this.TxtboxAdd6 = new System.Windows.Forms.TextBox();
            this.lablQ1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbboxCough7 = new System.Windows.Forms.ComboBox();
            this.lablCough = new System.Windows.Forms.Label();
            this.cmbboxFever8 = new System.Windows.Forms.ComboBox();
            this.lablFever = new System.Windows.Forms.Label();
            this.cmbboxSore9 = new System.Windows.Forms.ComboBox();
            this.lablSore = new System.Windows.Forms.Label();
            this.cmbboxRunny10 = new System.Windows.Forms.ComboBox();
            this.lablNose = new System.Windows.Forms.Label();
            this.cmbboxLoss11 = new System.Windows.Forms.ComboBox();
            this.lablLoss = new System.Windows.Forms.Label();
            this.cmbboxDiff12 = new System.Windows.Forms.ComboBox();
            this.lablDifficulty = new System.Windows.Forms.Label();
            this.cmbboxContact13 = new System.Windows.Forms.ComboBox();
            this.lablQ2 = new System.Windows.Forms.Label();
            this.cmbboxTraveled14 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbboxVaxx15 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lablCam
            // 
            this.lablCam.AutoSize = true;
            this.lablCam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lablCam.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lablCam.Location = new System.Drawing.Point(39, 71);
            this.lablCam.Name = "lablCam";
            this.lablCam.Size = new System.Drawing.Size(65, 19);
            this.lablCam.TabIndex = 0;
            this.lablCam.Text = "Camera";
            // 
            // cmbboxDevice
            // 
            this.cmbboxDevice.FormattingEnabled = true;
            this.cmbboxDevice.Location = new System.Drawing.Point(110, 71);
            this.cmbboxDevice.Name = "cmbboxDevice";
            this.cmbboxDevice.Size = new System.Drawing.Size(232, 23);
            this.cmbboxDevice.TabIndex = 1;
            // 
            // picboxQR
            // 
            this.picboxQR.Location = new System.Drawing.Point(39, 100);
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
            this.btnStart.Location = new System.Drawing.Point(267, 346);
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
            this.btnBack.Location = new System.Drawing.Point(12, 511);
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
            this.labl3rdform.Location = new System.Drawing.Point(418, 18);
            this.labl3rdform.Name = "labl3rdform";
            this.labl3rdform.Size = new System.Drawing.Size(221, 28);
            this.labl3rdform.TabIndex = 7;
            this.labl3rdform.Text = "QR CODE SCANNER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1064, 456);
            this.dataGridView1.TabIndex = 22;
            // 
            // btnSavenSub
            // 
            this.btnSavenSub.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSavenSub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSavenSub.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSavenSub.Location = new System.Drawing.Point(632, 470);
            this.btnSavenSub.Name = "btnSavenSub";
            this.btnSavenSub.Size = new System.Drawing.Size(140, 26);
            this.btnSavenSub.TabIndex = 197;
            this.btnSavenSub.Text = "Save and Submit";
            this.btnSavenSub.UseVisualStyleBackColor = false;
            this.btnSavenSub.Click += new System.EventHandler(this.btnSavenSub_Click);
            // 
            // lablName
            // 
            this.lablName.AutoSize = true;
            this.lablName.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lablName.Location = new System.Drawing.Point(382, 72);
            this.lablName.Name = "lablName";
            this.lablName.Size = new System.Drawing.Size(64, 22);
            this.lablName.TabIndex = 199;
            this.lablName.Text = "Name ";
            // 
            // TxtBoxNm1
            // 
            this.TxtBoxNm1.Location = new System.Drawing.Point(382, 97);
            this.TxtBoxNm1.Multiline = true;
            this.TxtBoxNm1.Name = "TxtBoxNm1";
            this.TxtBoxNm1.Size = new System.Drawing.Size(242, 28);
            this.TxtBoxNm1.TabIndex = 198;
            // 
            // TxtboxAge2
            // 
            this.TxtboxAge2.Location = new System.Drawing.Point(632, 97);
            this.TxtboxAge2.Multiline = true;
            this.TxtboxAge2.Name = "TxtboxAge2";
            this.TxtboxAge2.Size = new System.Drawing.Size(75, 28);
            this.TxtboxAge2.TabIndex = 201;
            // 
            // lablAge
            // 
            this.lablAge.AutoSize = true;
            this.lablAge.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lablAge.Location = new System.Drawing.Point(632, 72);
            this.lablAge.Name = "lablAge";
            this.lablAge.Size = new System.Drawing.Size(46, 22);
            this.lablAge.TabIndex = 200;
            this.lablAge.Text = "Age ";
            // 
            // lablSex
            // 
            this.lablSex.AutoSize = true;
            this.lablSex.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lablSex.Location = new System.Drawing.Point(725, 75);
            this.lablSex.Name = "lablSex";
            this.lablSex.Size = new System.Drawing.Size(40, 22);
            this.lablSex.TabIndex = 203;
            this.lablSex.Text = "Sex";
            // 
            // cmbboxSex3
            // 
            this.cmbboxSex3.FormattingEnabled = true;
            this.cmbboxSex3.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbboxSex3.Location = new System.Drawing.Point(725, 100);
            this.cmbboxSex3.Name = "cmbboxSex3";
            this.cmbboxSex3.Size = new System.Drawing.Size(121, 23);
            this.cmbboxSex3.TabIndex = 202;
            // 
            // DDateofVisit4
            // 
            this.DDateofVisit4.Location = new System.Drawing.Point(861, 100);
            this.DDateofVisit4.Name = "DDateofVisit4";
            this.DDateofVisit4.Size = new System.Drawing.Size(201, 23);
            this.DDateofVisit4.TabIndex = 205;
            // 
            // lablVisitDt
            // 
            this.lablVisitDt.AutoSize = true;
            this.lablVisitDt.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lablVisitDt.Location = new System.Drawing.Point(861, 75);
            this.lablVisitDt.Name = "lablVisitDt";
            this.lablVisitDt.Size = new System.Drawing.Size(115, 22);
            this.lablVisitDt.TabIndex = 204;
            this.lablVisitDt.Text = "Date of Visit";
            // 
            // TxtboxPhNum5
            // 
            this.TxtboxPhNum5.Location = new System.Drawing.Point(382, 173);
            this.TxtboxPhNum5.Multiline = true;
            this.TxtboxPhNum5.Name = "TxtboxPhNum5";
            this.TxtboxPhNum5.Size = new System.Drawing.Size(242, 28);
            this.TxtboxPhNum5.TabIndex = 207;
            // 
            // lablPhNum
            // 
            this.lablPhNum.AutoSize = true;
            this.lablPhNum.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lablPhNum.Location = new System.Drawing.Point(382, 148);
            this.lablPhNum.Name = "lablPhNum";
            this.lablPhNum.Size = new System.Drawing.Size(140, 22);
            this.lablPhNum.TabIndex = 206;
            this.lablPhNum.Text = "Phone Number";
            // 
            // lablAddress
            // 
            this.lablAddress.AutoSize = true;
            this.lablAddress.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lablAddress.Location = new System.Drawing.Point(632, 149);
            this.lablAddress.Name = "lablAddress";
            this.lablAddress.Size = new System.Drawing.Size(85, 22);
            this.lablAddress.TabIndex = 209;
            this.lablAddress.Text = "Address ";
            // 
            // TxtboxAdd6
            // 
            this.TxtboxAdd6.Location = new System.Drawing.Point(632, 174);
            this.TxtboxAdd6.Multiline = true;
            this.TxtboxAdd6.Name = "TxtboxAdd6";
            this.TxtboxAdd6.Size = new System.Drawing.Size(444, 27);
            this.TxtboxAdd6.TabIndex = 208;
            // 
            // lablQ1
            // 
            this.lablQ1.AutoSize = true;
            this.lablQ1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lablQ1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lablQ1.Location = new System.Drawing.Point(400, 244);
            this.lablQ1.Name = "lablQ1";
            this.lablQ1.Size = new System.Drawing.Size(252, 34);
            this.lablQ1.TabIndex = 211;
            this.lablQ1.Text = "Have you been experiencing the following\r\nsymptomps in the past 14 days?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Cambria", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(382, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(479, 40);
            this.label2.TabIndex = 210;
            this.label2.Text = "HEALTH DECLARATION FORM";
            // 
            // cmbboxCough7
            // 
            this.cmbboxCough7.FormattingEnabled = true;
            this.cmbboxCough7.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbboxCough7.Location = new System.Drawing.Point(462, 290);
            this.cmbboxCough7.Name = "cmbboxCough7";
            this.cmbboxCough7.Size = new System.Drawing.Size(121, 23);
            this.cmbboxCough7.TabIndex = 213;
            // 
            // lablCough
            // 
            this.lablCough.AutoSize = true;
            this.lablCough.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lablCough.Location = new System.Drawing.Point(410, 293);
            this.lablCough.Name = "lablCough";
            this.lablCough.Size = new System.Drawing.Size(43, 15);
            this.lablCough.TabIndex = 212;
            this.lablCough.Text = "Cough";
            // 
            // cmbboxFever8
            // 
            this.cmbboxFever8.FormattingEnabled = true;
            this.cmbboxFever8.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbboxFever8.Location = new System.Drawing.Point(462, 319);
            this.cmbboxFever8.Name = "cmbboxFever8";
            this.cmbboxFever8.Size = new System.Drawing.Size(121, 23);
            this.cmbboxFever8.TabIndex = 215;
            // 
            // lablFever
            // 
            this.lablFever.AutoSize = true;
            this.lablFever.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lablFever.Location = new System.Drawing.Point(418, 319);
            this.lablFever.Name = "lablFever";
            this.lablFever.Size = new System.Drawing.Size(35, 15);
            this.lablFever.TabIndex = 214;
            this.lablFever.Text = "Fever";
            // 
            // cmbboxSore9
            // 
            this.cmbboxSore9.FormattingEnabled = true;
            this.cmbboxSore9.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbboxSore9.Location = new System.Drawing.Point(462, 350);
            this.cmbboxSore9.Name = "cmbboxSore9";
            this.cmbboxSore9.Size = new System.Drawing.Size(121, 23);
            this.cmbboxSore9.TabIndex = 217;
            // 
            // lablSore
            // 
            this.lablSore.AutoSize = true;
            this.lablSore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lablSore.Location = new System.Drawing.Point(386, 353);
            this.lablSore.Name = "lablSore";
            this.lablSore.Size = new System.Drawing.Size(67, 15);
            this.lablSore.TabIndex = 216;
            this.lablSore.Text = "Sore Throat";
            // 
            // cmbboxRunny10
            // 
            this.cmbboxRunny10.FormattingEnabled = true;
            this.cmbboxRunny10.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbboxRunny10.Location = new System.Drawing.Point(462, 379);
            this.cmbboxRunny10.Name = "cmbboxRunny10";
            this.cmbboxRunny10.Size = new System.Drawing.Size(121, 23);
            this.cmbboxRunny10.TabIndex = 219;
            // 
            // lablNose
            // 
            this.lablNose.AutoSize = true;
            this.lablNose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lablNose.Location = new System.Drawing.Point(382, 382);
            this.lablNose.Name = "lablNose";
            this.lablNose.Size = new System.Drawing.Size(71, 15);
            this.lablNose.TabIndex = 218;
            this.lablNose.Text = "Runny Nose";
            // 
            // cmbboxLoss11
            // 
            this.cmbboxLoss11.FormattingEnabled = true;
            this.cmbboxLoss11.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbboxLoss11.Location = new System.Drawing.Point(462, 408);
            this.cmbboxLoss11.Name = "cmbboxLoss11";
            this.cmbboxLoss11.Size = new System.Drawing.Size(121, 23);
            this.cmbboxLoss11.TabIndex = 221;
            // 
            // lablLoss
            // 
            this.lablLoss.AutoSize = true;
            this.lablLoss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lablLoss.Location = new System.Drawing.Point(383, 411);
            this.lablLoss.Name = "lablLoss";
            this.lablLoss.Size = new System.Drawing.Size(73, 15);
            this.lablLoss.TabIndex = 220;
            this.lablLoss.Text = "Loss of Taste";
            // 
            // cmbboxDiff12
            // 
            this.cmbboxDiff12.FormattingEnabled = true;
            this.cmbboxDiff12.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbboxDiff12.Location = new System.Drawing.Point(462, 437);
            this.cmbboxDiff12.Name = "cmbboxDiff12";
            this.cmbboxDiff12.Size = new System.Drawing.Size(121, 23);
            this.cmbboxDiff12.TabIndex = 223;
            // 
            // lablDifficulty
            // 
            this.lablDifficulty.AutoSize = true;
            this.lablDifficulty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lablDifficulty.Location = new System.Drawing.Point(396, 437);
            this.lablDifficulty.Name = "lablDifficulty";
            this.lablDifficulty.Size = new System.Drawing.Size(58, 30);
            this.lablDifficulty.TabIndex = 222;
            this.lablDifficulty.Text = "Difficulty \r\nBreathing";
            // 
            // cmbboxContact13
            // 
            this.cmbboxContact13.FormattingEnabled = true;
            this.cmbboxContact13.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbboxContact13.Location = new System.Drawing.Point(811, 296);
            this.cmbboxContact13.Name = "cmbboxContact13";
            this.cmbboxContact13.Size = new System.Drawing.Size(121, 23);
            this.cmbboxContact13.TabIndex = 225;
            // 
            // lablQ2
            // 
            this.lablQ2.AutoSize = true;
            this.lablQ2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lablQ2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lablQ2.Location = new System.Drawing.Point(612, 293);
            this.lablQ2.Name = "lablQ2";
            this.lablQ2.Size = new System.Drawing.Size(193, 34);
            this.lablQ2.TabIndex = 224;
            this.lablQ2.Text = "Have you been in close contact \r\nwith a Covid - 19 case? \r\n";
            // 
            // cmbboxTraveled14
            // 
            this.cmbboxTraveled14.FormattingEnabled = true;
            this.cmbboxTraveled14.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbboxTraveled14.Location = new System.Drawing.Point(811, 344);
            this.cmbboxTraveled14.Name = "cmbboxTraveled14";
            this.cmbboxTraveled14.Size = new System.Drawing.Size(121, 23);
            this.cmbboxTraveled14.TabIndex = 227;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(612, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 34);
            this.label3.TabIndex = 226;
            this.label3.Text = "Have you traveled outside the \r\ncountry in the last 14 days? \r\n";
            // 
            // cmbboxVaxx15
            // 
            this.cmbboxVaxx15.FormattingEnabled = true;
            this.cmbboxVaxx15.Items.AddRange(new object[] {
            "Yes, I\'m Fully Vaccinated",
            "Yes, I\'m Fully Vaccinated with Booster Shot",
            "No"});
            this.cmbboxVaxx15.Location = new System.Drawing.Point(737, 382);
            this.cmbboxVaxx15.Name = "cmbboxVaxx15";
            this.cmbboxVaxx15.Size = new System.Drawing.Size(268, 23);
            this.cmbboxVaxx15.TabIndex = 229;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(612, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 34);
            this.label4.TabIndex = 228;
            this.label4.Text = "Have you received \r\nvaccine doses?";
            // 
            // QRScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 550);
            this.Controls.Add(this.cmbboxVaxx15);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbboxTraveled14);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbboxContact13);
            this.Controls.Add(this.lablQ2);
            this.Controls.Add(this.cmbboxDiff12);
            this.Controls.Add(this.lablDifficulty);
            this.Controls.Add(this.cmbboxLoss11);
            this.Controls.Add(this.lablLoss);
            this.Controls.Add(this.cmbboxRunny10);
            this.Controls.Add(this.lablNose);
            this.Controls.Add(this.cmbboxSore9);
            this.Controls.Add(this.lablSore);
            this.Controls.Add(this.cmbboxFever8);
            this.Controls.Add(this.lablFever);
            this.Controls.Add(this.cmbboxCough7);
            this.Controls.Add(this.lablCough);
            this.Controls.Add(this.lablQ1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lablAddress);
            this.Controls.Add(this.TxtboxAdd6);
            this.Controls.Add(this.TxtboxPhNum5);
            this.Controls.Add(this.lablPhNum);
            this.Controls.Add(this.DDateofVisit4);
            this.Controls.Add(this.lablVisitDt);
            this.Controls.Add(this.lablSex);
            this.Controls.Add(this.cmbboxSex3);
            this.Controls.Add(this.TxtboxAge2);
            this.Controls.Add(this.lablAge);
            this.Controls.Add(this.lablName);
            this.Controls.Add(this.TxtBoxNm1);
            this.Controls.Add(this.btnSavenSub);
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
        private Button btnSavenSub;
        private Label lablName;
        private TextBox TxtBoxNm1;
        private TextBox TxtboxAge2;
        private Label lablAge;
        private Label lablSex;
        private ComboBox cmbboxSex3;
        private DateTimePicker DDateofVisit4;
        private Label lablVisitDt;
        private TextBox TxtboxPhNum5;
        private Label lablPhNum;
        private Label lablAddress;
        private TextBox TxtboxAdd6;
        private Label lablQ1;
        private Label label2;
        private ComboBox cmbboxCough7;
        private Label lablCough;
        private ComboBox cmbboxFever8;
        private Label lablFever;
        private ComboBox cmbboxSore9;
        private Label lablSore;
        private ComboBox cmbboxRunny10;
        private Label lablNose;
        private ComboBox cmbboxLoss11;
        private Label lablLoss;
        private ComboBox cmbboxDiff12;
        private Label lablDifficulty;
        private ComboBox cmbboxContact13;
        private Label lablQ2;
        private ComboBox cmbboxTraveled14;
        private Label label3;
        private ComboBox cmbboxVaxx15;
        private Label label4;
    }
}