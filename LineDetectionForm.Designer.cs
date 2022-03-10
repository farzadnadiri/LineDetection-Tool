namespace LineDetection
{
    partial class LineDetectionForm
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
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.numericUpDownHmin = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownHmax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSmax = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownSmin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownVmax = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownVmin = new System.Windows.Forms.NumericUpDown();
            this.imageBox3 = new Emgu.CV.UI.ImageBox();
            this.imageBox4 = new Emgu.CV.UI.ImageBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownFieldHmin = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownFieldHmax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFieldSmin = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownFieldSmax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFieldVmax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFieldVmin = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFieldHmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFieldHmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFieldSmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFieldSmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFieldVmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFieldVmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.BackColor = System.Drawing.Color.Black;
            this.imageBox1.Location = new System.Drawing.Point(12, 39);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(320, 240);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1147, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(667, 175);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(474, 18);
            this.textBox1.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imageBox2
            // 
            this.imageBox2.BackColor = System.Drawing.Color.Black;
            this.imageBox2.Location = new System.Drawing.Point(341, 39);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(320, 240);
            this.imageBox2.TabIndex = 5;
            this.imageBox2.TabStop = false;
            // 
            // numericUpDownHmin
            // 
            this.numericUpDownHmin.Location = new System.Drawing.Point(54, 19);
            this.numericUpDownHmin.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDownHmin.Name = "numericUpDownHmin";
            this.numericUpDownHmin.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownHmin.TabIndex = 6;
            this.numericUpDownHmin.Value = new decimal(new int[] {
            62,
            0,
            0,
            0});
            this.numericUpDownHmin.ValueChanged += new System.EventHandler(this.numericUpDownHmin_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "H";
            // 
            // numericUpDownHmax
            // 
            this.numericUpDownHmax.Location = new System.Drawing.Point(107, 19);
            this.numericUpDownHmax.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDownHmax.Name = "numericUpDownHmax";
            this.numericUpDownHmax.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownHmax.TabIndex = 8;
            this.numericUpDownHmax.Value = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.numericUpDownHmax.ValueChanged += new System.EventHandler(this.numericUpDownHmin_ValueChanged);
            // 
            // numericUpDownSmax
            // 
            this.numericUpDownSmax.Location = new System.Drawing.Point(107, 45);
            this.numericUpDownSmax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownSmax.Name = "numericUpDownSmax";
            this.numericUpDownSmax.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownSmax.TabIndex = 11;
            this.numericUpDownSmax.Value = new decimal(new int[] {
            196,
            0,
            0,
            0});
            this.numericUpDownSmax.ValueChanged += new System.EventHandler(this.numericUpDownHmin_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "S";
            // 
            // numericUpDownSmin
            // 
            this.numericUpDownSmin.Location = new System.Drawing.Point(54, 45);
            this.numericUpDownSmin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownSmin.Name = "numericUpDownSmin";
            this.numericUpDownSmin.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownSmin.TabIndex = 9;
            this.numericUpDownSmin.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDownSmin.ValueChanged += new System.EventHandler(this.numericUpDownHmin_ValueChanged);
            // 
            // numericUpDownVmax
            // 
            this.numericUpDownVmax.Location = new System.Drawing.Point(106, 71);
            this.numericUpDownVmax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownVmax.Name = "numericUpDownVmax";
            this.numericUpDownVmax.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownVmax.TabIndex = 14;
            this.numericUpDownVmax.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownVmax.ValueChanged += new System.EventHandler(this.numericUpDownHmin_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "V";
            // 
            // numericUpDownVmin
            // 
            this.numericUpDownVmin.Location = new System.Drawing.Point(54, 71);
            this.numericUpDownVmin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownVmin.Name = "numericUpDownVmin";
            this.numericUpDownVmin.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownVmin.TabIndex = 12;
            this.numericUpDownVmin.ValueChanged += new System.EventHandler(this.numericUpDownHmin_ValueChanged);
            // 
            // imageBox3
            // 
            this.imageBox3.BackColor = System.Drawing.Color.Black;
            this.imageBox3.Location = new System.Drawing.Point(12, 308);
            this.imageBox3.Name = "imageBox3";
            this.imageBox3.Size = new System.Drawing.Size(320, 240);
            this.imageBox3.TabIndex = 16;
            this.imageBox3.TabStop = false;
            // 
            // imageBox4
            // 
            this.imageBox4.BackColor = System.Drawing.Color.Black;
            this.imageBox4.Location = new System.Drawing.Point(341, 308);
            this.imageBox4.Name = "imageBox4";
            this.imageBox4.Size = new System.Drawing.Size(320, 240);
            this.imageBox4.TabIndex = 15;
            this.imageBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Real";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Masked";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Transform";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownHmin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDownHmax);
            this.groupBox1.Controls.Add(this.numericUpDownSmin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDownSmax);
            this.groupBox1.Controls.Add(this.numericUpDownVmax);
            this.groupBox1.Controls.Add(this.numericUpDownVmin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(667, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 100);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Line";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDownFieldHmin);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.numericUpDownFieldHmax);
            this.groupBox2.Controls.Add(this.numericUpDownFieldSmin);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.numericUpDownFieldSmax);
            this.groupBox2.Controls.Add(this.numericUpDownFieldVmax);
            this.groupBox2.Controls.Add(this.numericUpDownFieldVmin);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(827, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 100);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Field";
            // 
            // numericUpDownFieldHmin
            // 
            this.numericUpDownFieldHmin.Location = new System.Drawing.Point(59, 16);
            this.numericUpDownFieldHmin.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDownFieldHmin.Name = "numericUpDownFieldHmin";
            this.numericUpDownFieldHmin.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownFieldHmin.TabIndex = 6;
            this.numericUpDownFieldHmin.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.numericUpDownFieldHmin.ValueChanged += new System.EventHandler(this.numericUpDownHmin_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "H";
            // 
            // numericUpDownFieldHmax
            // 
            this.numericUpDownFieldHmax.Location = new System.Drawing.Point(112, 16);
            this.numericUpDownFieldHmax.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDownFieldHmax.Name = "numericUpDownFieldHmax";
            this.numericUpDownFieldHmax.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownFieldHmax.TabIndex = 8;
            this.numericUpDownFieldHmax.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numericUpDownFieldHmax.ValueChanged += new System.EventHandler(this.numericUpDownHmin_ValueChanged);
            // 
            // numericUpDownFieldSmin
            // 
            this.numericUpDownFieldSmin.Location = new System.Drawing.Point(59, 42);
            this.numericUpDownFieldSmin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownFieldSmin.Name = "numericUpDownFieldSmin";
            this.numericUpDownFieldSmin.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownFieldSmin.TabIndex = 9;
            this.numericUpDownFieldSmin.Value = new decimal(new int[] {
            81,
            0,
            0,
            0});
            this.numericUpDownFieldSmin.ValueChanged += new System.EventHandler(this.numericUpDownHmin_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "S";
            // 
            // numericUpDownFieldSmax
            // 
            this.numericUpDownFieldSmax.Location = new System.Drawing.Point(112, 42);
            this.numericUpDownFieldSmax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownFieldSmax.Name = "numericUpDownFieldSmax";
            this.numericUpDownFieldSmax.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownFieldSmax.TabIndex = 11;
            this.numericUpDownFieldSmax.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownFieldSmax.ValueChanged += new System.EventHandler(this.numericUpDownHmin_ValueChanged);
            // 
            // numericUpDownFieldVmax
            // 
            this.numericUpDownFieldVmax.Location = new System.Drawing.Point(111, 68);
            this.numericUpDownFieldVmax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownFieldVmax.Name = "numericUpDownFieldVmax";
            this.numericUpDownFieldVmax.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownFieldVmax.TabIndex = 14;
            this.numericUpDownFieldVmax.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownFieldVmax.ValueChanged += new System.EventHandler(this.numericUpDownHmin_ValueChanged);
            // 
            // numericUpDownFieldVmin
            // 
            this.numericUpDownFieldVmin.Location = new System.Drawing.Point(59, 68);
            this.numericUpDownFieldVmin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownFieldVmin.Name = "numericUpDownFieldVmin";
            this.numericUpDownFieldVmin.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownFieldVmin.TabIndex = 12;
            this.numericUpDownFieldVmin.ValueChanged += new System.EventHandler(this.numericUpDownHmin_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "V";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(339, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Corner Detection";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(712, 39);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 17);
            this.radioButton1.TabIndex = 23;
            this.radioButton1.Text = "Field";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(768, 39);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 17);
            this.radioButton2.TabIndex = 24;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Lines";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Location = new System.Drawing.Point(1124, 9);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown2.TabIndex = 25;
            this.numericUpDown2.Value = new decimal(new int[] {
            8,
            0,
            0,
            131072});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(990, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Y DIRECTION STEP";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1116, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Total:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1154, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(667, 201);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(506, 347);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(990, 97);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(183, 69);
            this.listBox1.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(990, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "LinesWithGroups";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(990, 39);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(119, 13);
            this.label17.TabIndex = 36;
            this.label17.Text = "LINE DISTANCE STEP";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(1124, 36);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown1.TabIndex = 35;
            this.numericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // Column6
            // 
            this.Column6.HeaderText = "#";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 20;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "P1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "P2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Length";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Direction";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 180;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Select";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 40;
            // 
            // LocalizationLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 552);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.imageBox3);
            this.Controls.Add(this.imageBox4);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imageBox1);
            this.Name = "LocalizationLab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFieldHmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFieldHmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFieldSmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFieldSmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFieldVmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFieldVmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.NumericUpDown numericUpDownHmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownHmax;
        private System.Windows.Forms.NumericUpDown numericUpDownSmax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownSmin;
        private System.Windows.Forms.NumericUpDown numericUpDownVmax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownVmin;
        private Emgu.CV.UI.ImageBox imageBox3;
        private Emgu.CV.UI.ImageBox imageBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDownFieldHmin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownFieldHmax;
        private System.Windows.Forms.NumericUpDown numericUpDownFieldSmin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownFieldSmax;
        private System.Windows.Forms.NumericUpDown numericUpDownFieldVmax;
        private System.Windows.Forms.NumericUpDown numericUpDownFieldVmin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewLinkColumn Column5;
    }
}

