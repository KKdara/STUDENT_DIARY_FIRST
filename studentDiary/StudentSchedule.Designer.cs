namespace studentDiary
{
    partial class StudentScheduleWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentScheduleWindow));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BackButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.ScheduleForm = new System.Windows.Forms.TableLayoutPanel();
            this.ScheduleForm7 = new System.Windows.Forms.TableLayoutPanel();
            this.Saturday = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.ScheduleForm4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Wednesday = new System.Windows.Forms.Label();
            this.ScheduleForm6 = new System.Windows.Forms.TableLayoutPanel();
            this.Friday = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.ScheduleForm3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Tuesday = new System.Windows.Forms.Label();
            this.ScheduleForm5 = new System.Windows.Forms.TableLayoutPanel();
            this.Thursday = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.ScheduleForm2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Monday = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.ScheduleForm.SuspendLayout();
            this.ScheduleForm7.SuspendLayout();
            this.ScheduleForm4.SuspendLayout();
            this.ScheduleForm6.SuspendLayout();
            this.ScheduleForm3.SuspendLayout();
            this.ScheduleForm5.SuspendLayout();
            this.ScheduleForm2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackButton,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1021, 28);
            this.toolStrip1.TabIndex = 0;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BackButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(62, 25);
            this.BackButton.Text = "Назад";
            this.BackButton.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.SlateBlue;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(68, 25);
            this.toolStripLabel1.Text = "Неделя";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            // 
            // ScheduleForm
            // 
            this.ScheduleForm.ColumnCount = 2;
            this.ScheduleForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ScheduleForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ScheduleForm.Controls.Add(this.ScheduleForm7, 1, 2);
            this.ScheduleForm.Controls.Add(this.ScheduleForm4, 0, 2);
            this.ScheduleForm.Controls.Add(this.ScheduleForm6, 1, 1);
            this.ScheduleForm.Controls.Add(this.ScheduleForm3, 0, 1);
            this.ScheduleForm.Controls.Add(this.ScheduleForm5, 1, 0);
            this.ScheduleForm.Controls.Add(this.ScheduleForm2, 0, 0);
            this.ScheduleForm.Location = new System.Drawing.Point(0, 29);
            this.ScheduleForm.Name = "ScheduleForm";
            this.ScheduleForm.RowCount = 3;
            this.ScheduleForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ScheduleForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ScheduleForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ScheduleForm.Size = new System.Drawing.Size(1021, 689);
            this.ScheduleForm.TabIndex = 1;
            // 
            // ScheduleForm7
            // 
            this.ScheduleForm7.ColumnCount = 2;
            this.ScheduleForm7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ScheduleForm7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.ScheduleForm7.Controls.Add(this.Saturday, 0, 0);
            this.ScheduleForm7.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.ScheduleForm7.Location = new System.Drawing.Point(513, 461);
            this.ScheduleForm7.Name = "ScheduleForm7";
            this.ScheduleForm7.RowCount = 1;
            this.ScheduleForm7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ScheduleForm7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 223F));
            this.ScheduleForm7.Size = new System.Drawing.Size(504, 223);
            this.ScheduleForm7.TabIndex = 5;
            // 
            // Saturday
            // 
            this.Saturday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Saturday.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Saturday.ForeColor = System.Drawing.Color.SlateBlue;
            this.Saturday.Location = new System.Drawing.Point(38, 33);
            this.Saturday.Name = "Saturday";
            this.Saturday.Size = new System.Drawing.Size(23, 156);
            this.Saturday.TabIndex = 5;
            this.Saturday.Text = "Суббота";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Location = new System.Drawing.Point(103, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 6;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(398, 217);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // ScheduleForm4
            // 
            this.ScheduleForm4.BackColor = System.Drawing.Color.SlateBlue;
            this.ScheduleForm4.ColumnCount = 2;
            this.ScheduleForm4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ScheduleForm4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.ScheduleForm4.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.ScheduleForm4.Controls.Add(this.Wednesday, 0, 0);
            this.ScheduleForm4.Location = new System.Drawing.Point(3, 461);
            this.ScheduleForm4.Name = "ScheduleForm4";
            this.ScheduleForm4.RowCount = 1;
            this.ScheduleForm4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ScheduleForm4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 223F));
            this.ScheduleForm4.Size = new System.Drawing.Size(504, 223);
            this.ScheduleForm4.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(103, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(398, 217);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // Wednesday
            // 
            this.Wednesday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Wednesday.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Wednesday.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Wednesday.Location = new System.Drawing.Point(38, 55);
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.Size = new System.Drawing.Size(23, 112);
            this.Wednesday.TabIndex = 3;
            this.Wednesday.Text = "Среда";
            // 
            // ScheduleForm6
            // 
            this.ScheduleForm6.BackColor = System.Drawing.Color.SlateBlue;
            this.ScheduleForm6.ColumnCount = 2;
            this.ScheduleForm6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ScheduleForm6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.ScheduleForm6.Controls.Add(this.Friday, 0, 0);
            this.ScheduleForm6.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.ScheduleForm6.Location = new System.Drawing.Point(513, 232);
            this.ScheduleForm6.Name = "ScheduleForm6";
            this.ScheduleForm6.RowCount = 1;
            this.ScheduleForm6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ScheduleForm6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 223F));
            this.ScheduleForm6.Size = new System.Drawing.Size(504, 223);
            this.ScheduleForm6.TabIndex = 3;
            // 
            // Friday
            // 
            this.Friday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Friday.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Friday.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Friday.Location = new System.Drawing.Point(38, 38);
            this.Friday.Name = "Friday";
            this.Friday.Size = new System.Drawing.Size(23, 147);
            this.Friday.TabIndex = 3;
            this.Friday.Text = "Пятница";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Location = new System.Drawing.Point(103, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 6;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(398, 217);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // ScheduleForm3
            // 
            this.ScheduleForm3.ColumnCount = 2;
            this.ScheduleForm3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ScheduleForm3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.ScheduleForm3.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.ScheduleForm3.Controls.Add(this.Tuesday, 0, 0);
            this.ScheduleForm3.Location = new System.Drawing.Point(3, 232);
            this.ScheduleForm3.Name = "ScheduleForm3";
            this.ScheduleForm3.RowCount = 1;
            this.ScheduleForm3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ScheduleForm3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 223F));
            this.ScheduleForm3.Size = new System.Drawing.Size(504, 223);
            this.ScheduleForm3.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(103, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(398, 217);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // Tuesday
            // 
            this.Tuesday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tuesday.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tuesday.ForeColor = System.Drawing.Color.SlateBlue;
            this.Tuesday.Location = new System.Drawing.Point(38, 33);
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.Size = new System.Drawing.Size(23, 156);
            this.Tuesday.TabIndex = 3;
            this.Tuesday.Text = "Вторник";
            // 
            // ScheduleForm5
            // 
            this.ScheduleForm5.ColumnCount = 2;
            this.ScheduleForm5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ScheduleForm5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.ScheduleForm5.Controls.Add(this.Thursday, 0, 0);
            this.ScheduleForm5.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.ScheduleForm5.Location = new System.Drawing.Point(513, 3);
            this.ScheduleForm5.Name = "ScheduleForm5";
            this.ScheduleForm5.RowCount = 1;
            this.ScheduleForm5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ScheduleForm5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 223F));
            this.ScheduleForm5.Size = new System.Drawing.Size(504, 223);
            this.ScheduleForm5.TabIndex = 1;
            // 
            // Thursday
            // 
            this.Thursday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Thursday.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Thursday.ForeColor = System.Drawing.Color.SlateBlue;
            this.Thursday.Location = new System.Drawing.Point(38, 33);
            this.Thursday.Name = "Thursday";
            this.Thursday.Size = new System.Drawing.Size(23, 156);
            this.Thursday.TabIndex = 4;
            this.Thursday.Text = "Четверг";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Location = new System.Drawing.Point(103, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(398, 217);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // ScheduleForm2
            // 
            this.ScheduleForm2.BackColor = System.Drawing.Color.SlateBlue;
            this.ScheduleForm2.ColumnCount = 2;
            this.ScheduleForm2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ScheduleForm2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.ScheduleForm2.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.ScheduleForm2.Controls.Add(this.Monday, 0, 0);
            this.ScheduleForm2.Location = new System.Drawing.Point(3, 3);
            this.ScheduleForm2.Name = "ScheduleForm2";
            this.ScheduleForm2.RowCount = 1;
            this.ScheduleForm2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ScheduleForm2.Size = new System.Drawing.Size(504, 223);
            this.ScheduleForm2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(103, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(398, 217);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Monday
            // 
            this.Monday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Monday.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Monday.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Monday.Location = new System.Drawing.Point(38, 3);
            this.Monday.Name = "Monday";
            this.Monday.Size = new System.Drawing.Size(23, 216);
            this.Monday.TabIndex = 1;
            this.Monday.Text = "Понедельник";
            // 
            // StudentScheduleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 717);
            this.Controls.Add(this.ScheduleForm);
            this.Controls.Add(this.toolStrip1);
            this.Name = "StudentScheduleWindow";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ScheduleForm.ResumeLayout(false);
            this.ScheduleForm7.ResumeLayout(false);
            this.ScheduleForm4.ResumeLayout(false);
            this.ScheduleForm6.ResumeLayout(false);
            this.ScheduleForm3.ResumeLayout(false);
            this.ScheduleForm5.ResumeLayout(false);
            this.ScheduleForm2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BackButton;
        private System.Windows.Forms.TableLayoutPanel ScheduleForm;
        private System.Windows.Forms.TableLayoutPanel ScheduleForm2;
        private System.Windows.Forms.TableLayoutPanel ScheduleForm7;
        private System.Windows.Forms.TableLayoutPanel ScheduleForm4;
        private System.Windows.Forms.TableLayoutPanel ScheduleForm6;
        private System.Windows.Forms.TableLayoutPanel ScheduleForm3;
        private System.Windows.Forms.TableLayoutPanel ScheduleForm5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label Monday;
        private System.Windows.Forms.Label Tuesday;
        private System.Windows.Forms.Label Wednesday;
        private System.Windows.Forms.Label Saturday;
        private System.Windows.Forms.Label Friday;
        private System.Windows.Forms.Label Thursday;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
    }
}