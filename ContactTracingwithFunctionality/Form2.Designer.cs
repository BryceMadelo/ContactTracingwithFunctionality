namespace ContactTracingwithFunctionality
{
    partial class Form2
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
            this.lablDataVisit = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ColumnName = new System.Windows.Forms.ColumnHeader();
            this.ColumnDate = new System.Windows.Forms.ColumnHeader();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.SelectedDate = new System.Windows.Forms.DateTimePicker();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.lablTitle2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lablDataVisit
            // 
            this.lablDataVisit.AutoSize = true;
            this.lablDataVisit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lablDataVisit.Location = new System.Drawing.Point(527, 141);
            this.lablDataVisit.Name = "lablDataVisit";
            this.lablDataVisit.Size = new System.Drawing.Size(122, 19);
            this.lablDataVisit.TabIndex = 18;
            this.lablDataVisit.Text = "Data of Visitors";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnName,
            this.ColumnDate});
            this.listView1.Location = new System.Drawing.Point(488, 163);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(198, 224);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ColumnName
            // 
            this.ColumnName.Text = "Name";
            this.ColumnName.Width = 65;
            // 
            // ColumnDate
            // 
            this.ColumnDate.Text = "Date of Visitor";
            this.ColumnDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnDate.Width = 100;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(41, 146);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(417, 259);
            this.listBox1.TabIndex = 16;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(227, 411);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(63, 23);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // SelectedDate
            // 
            this.SelectedDate.Location = new System.Drawing.Point(110, 117);
            this.SelectedDate.Name = "SelectedDate";
            this.SelectedDate.Size = new System.Drawing.Size(200, 23);
            this.SelectedDate.TabIndex = 14;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(41, 117);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(63, 23);
            this.btnFilter.TabIndex = 13;
            this.btnFilter.Text = "Filter\r\n";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(331, 119);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(110, 23);
            this.btnView.TabIndex = 12;
            this.btnView.Text = "View All the Data";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lablTitle2
            // 
            this.lablTitle2.AutoSize = true;
            this.lablTitle2.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lablTitle2.Location = new System.Drawing.Point(87, 39);
            this.lablTitle2.Name = "lablTitle2";
            this.lablTitle2.Size = new System.Drawing.Size(547, 37);
            this.lablTitle2.TabIndex = 11;
            this.lablTitle2.Text = "CONTACT TRACING FORM DATABASE";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 461);
            this.Controls.Add(this.lablDataVisit);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.SelectedDate);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lablTitle2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lablDataVisit;
        private ListView listView1;
        private ColumnHeader ColumnName;
        private ColumnHeader ColumnDate;
        private ListBox listBox1;
        private Button btnReset;
        private DateTimePicker SelectedDate;
        private Button btnFilter;
        private Button btnView;
        private Label lablTitle2;
    }
}