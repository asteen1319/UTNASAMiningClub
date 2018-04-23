namespace NasaRobot
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnForward = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.cmbMotorSelect = new System.Windows.Forms.ComboBox();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnMotorStop = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.rbMotorFull = new System.Windows.Forms.RadioButton();
            this.rbMotorSevenEighths = new System.Windows.Forms.RadioButton();
            this.rbMotorThreeQuarters = new System.Windows.Forms.RadioButton();
            this.rbMotorFiveEighths = new System.Windows.Forms.RadioButton();
            this.rbMotorHalf = new System.Windows.Forms.RadioButton();
            this.rbMotorThreeEighths = new System.Windows.Forms.RadioButton();
            this.rbMotorQuarter = new System.Windows.Forms.RadioButton();
            this.rbMotorEighth = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.rbActFull = new System.Windows.Forms.RadioButton();
            this.rbSevenEighths = new System.Windows.Forms.RadioButton();
            this.rbThreeQuarters = new System.Windows.Forms.RadioButton();
            this.rbActFiveEighths = new System.Windows.Forms.RadioButton();
            this.rbActHalf = new System.Windows.Forms.RadioButton();
            this.rbActThreeEighths = new System.Windows.Forms.RadioButton();
            this.rbActQuarter = new System.Windows.Forms.RadioButton();
            this.rbActEighth = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnActuatorStop = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.cmbActuatorSelect = new System.Windows.Forms.ComboBox();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.pnlCompControl = new System.Windows.Forms.Panel();
            this.pnlXboxControl = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSelectedDevice = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblDirection = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblCurrentDevice = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCurrentCommand = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSwapControls = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlCompControl.SuspendLayout();
            this.pnlXboxControl.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(177, 122);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(75, 23);
            this.btnForward.TabIndex = 0;
            this.btnForward.Text = "Forward";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(85, 165);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(177, 208);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(75, 23);
            this.btnReverse.TabIndex = 2;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // cmbMotorSelect
            // 
            this.cmbMotorSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotorSelect.FormattingEnabled = true;
            this.cmbMotorSelect.Items.AddRange(new object[] {
            "DriveMotor"});
            this.cmbMotorSelect.Location = new System.Drawing.Point(15, 33);
            this.cmbMotorSelect.Name = "cmbMotorSelect";
            this.cmbMotorSelect.Size = new System.Drawing.Size(121, 21);
            this.cmbMotorSelect.TabIndex = 3;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(269, 165);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 4;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnMotorStop
            // 
            this.btnMotorStop.Location = new System.Drawing.Point(177, 165);
            this.btnMotorStop.Name = "btnMotorStop";
            this.btnMotorStop.Size = new System.Drawing.Size(75, 23);
            this.btnMotorStop.TabIndex = 5;
            this.btnMotorStop.Text = "Stop";
            this.btnMotorStop.UseVisualStyleBackColor = true;
            this.btnMotorStop.Click += new System.EventHandler(this.btnMotorStop_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRight);
            this.panel1.Controls.Add(this.btnMotorStop);
            this.panel1.Controls.Add(this.btnReverse);
            this.panel1.Controls.Add(this.btnLeft);
            this.panel1.Controls.Add(this.btnForward);
            this.panel1.Controls.Add(this.cmbMotorSelect);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 379);
            this.panel1.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(15, 289);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(399, 1);
            this.panel4.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Motor Controls";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.rbMotorFull);
            this.panel3.Controls.Add(this.rbMotorSevenEighths);
            this.panel3.Controls.Add(this.rbMotorThreeQuarters);
            this.panel3.Controls.Add(this.rbMotorFiveEighths);
            this.panel3.Controls.Add(this.rbMotorHalf);
            this.panel3.Controls.Add(this.rbMotorThreeEighths);
            this.panel3.Controls.Add(this.rbMotorQuarter);
            this.panel3.Controls.Add(this.rbMotorEighth);
            this.panel3.Location = new System.Drawing.Point(15, 264);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(399, 100);
            this.panel3.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Speed Selection";
            // 
            // rbMotorFull
            // 
            this.rbMotorFull.AutoSize = true;
            this.rbMotorFull.Location = new System.Drawing.Point(337, 68);
            this.rbMotorFull.Name = "rbMotorFull";
            this.rbMotorFull.Size = new System.Drawing.Size(41, 17);
            this.rbMotorFull.TabIndex = 7;
            this.rbMotorFull.Text = "Full";
            this.rbMotorFull.UseVisualStyleBackColor = true;
            this.rbMotorFull.CheckedChanged += new System.EventHandler(this.rbMotorFull_CheckedChanged);
            // 
            // rbMotorSevenEighths
            // 
            this.rbMotorSevenEighths.AutoSize = true;
            this.rbMotorSevenEighths.Location = new System.Drawing.Point(221, 68);
            this.rbMotorSevenEighths.Name = "rbMotorSevenEighths";
            this.rbMotorSevenEighths.Size = new System.Drawing.Size(94, 17);
            this.rbMotorSevenEighths.TabIndex = 6;
            this.rbMotorSevenEighths.Text = "Seven Eighths";
            this.rbMotorSevenEighths.UseVisualStyleBackColor = true;
            this.rbMotorSevenEighths.CheckedChanged += new System.EventHandler(this.rbMotorSevenEighths_CheckedChanged);
            // 
            // rbMotorThreeQuarters
            // 
            this.rbMotorThreeQuarters.AutoSize = true;
            this.rbMotorThreeQuarters.Location = new System.Drawing.Point(109, 68);
            this.rbMotorThreeQuarters.Name = "rbMotorThreeQuarters";
            this.rbMotorThreeQuarters.Size = new System.Drawing.Size(96, 17);
            this.rbMotorThreeQuarters.TabIndex = 5;
            this.rbMotorThreeQuarters.Text = "Three Quarters";
            this.rbMotorThreeQuarters.UseVisualStyleBackColor = true;
            this.rbMotorThreeQuarters.CheckedChanged += new System.EventHandler(this.rbMotorThreeQuarters_CheckedChanged);
            // 
            // rbMotorFiveEighths
            // 
            this.rbMotorFiveEighths.AutoSize = true;
            this.rbMotorFiveEighths.Location = new System.Drawing.Point(16, 68);
            this.rbMotorFiveEighths.Name = "rbMotorFiveEighths";
            this.rbMotorFiveEighths.Size = new System.Drawing.Size(83, 17);
            this.rbMotorFiveEighths.TabIndex = 4;
            this.rbMotorFiveEighths.Text = "Five Eighths";
            this.rbMotorFiveEighths.UseVisualStyleBackColor = true;
            this.rbMotorFiveEighths.CheckedChanged += new System.EventHandler(this.rbMotorFiveEighths_CheckedChanged);
            // 
            // rbMotorHalf
            // 
            this.rbMotorHalf.AutoSize = true;
            this.rbMotorHalf.Location = new System.Drawing.Point(337, 40);
            this.rbMotorHalf.Name = "rbMotorHalf";
            this.rbMotorHalf.Size = new System.Drawing.Size(44, 17);
            this.rbMotorHalf.TabIndex = 3;
            this.rbMotorHalf.Text = "Half";
            this.rbMotorHalf.UseVisualStyleBackColor = true;
            this.rbMotorHalf.CheckedChanged += new System.EventHandler(this.rbMotorHalf_CheckedChanged);
            // 
            // rbMotorThreeEighths
            // 
            this.rbMotorThreeEighths.AutoSize = true;
            this.rbMotorThreeEighths.Location = new System.Drawing.Point(221, 40);
            this.rbMotorThreeEighths.Name = "rbMotorThreeEighths";
            this.rbMotorThreeEighths.Size = new System.Drawing.Size(91, 17);
            this.rbMotorThreeEighths.TabIndex = 2;
            this.rbMotorThreeEighths.Text = "Three Eighths";
            this.rbMotorThreeEighths.UseVisualStyleBackColor = true;
            this.rbMotorThreeEighths.CheckedChanged += new System.EventHandler(this.rbMotorThreeEighths_CheckedChanged);
            // 
            // rbMotorQuarter
            // 
            this.rbMotorQuarter.AutoSize = true;
            this.rbMotorQuarter.Location = new System.Drawing.Point(109, 40);
            this.rbMotorQuarter.Name = "rbMotorQuarter";
            this.rbMotorQuarter.Size = new System.Drawing.Size(83, 17);
            this.rbMotorQuarter.TabIndex = 1;
            this.rbMotorQuarter.Text = "One Quarter";
            this.rbMotorQuarter.UseVisualStyleBackColor = true;
            this.rbMotorQuarter.CheckedChanged += new System.EventHandler(this.rbMotorQuarter_CheckedChanged);
            // 
            // rbMotorEighth
            // 
            this.rbMotorEighth.AutoSize = true;
            this.rbMotorEighth.Checked = true;
            this.rbMotorEighth.Location = new System.Drawing.Point(16, 40);
            this.rbMotorEighth.Name = "rbMotorEighth";
            this.rbMotorEighth.Size = new System.Drawing.Size(78, 17);
            this.rbMotorEighth.TabIndex = 0;
            this.rbMotorEighth.TabStop = true;
            this.rbMotorEighth.Text = "One Eighth";
            this.rbMotorEighth.UseVisualStyleBackColor = true;
            this.rbMotorEighth.CheckedChanged += new System.EventHandler(this.rbMotorEighth_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnActuatorStop);
            this.panel2.Controls.Add(this.btnDown);
            this.panel2.Controls.Add(this.btnUp);
            this.panel2.Controls.Add(this.cmbActuatorSelect);
            this.panel2.Location = new System.Drawing.Point(466, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 379);
            this.panel2.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.rbActFull);
            this.panel5.Controls.Add(this.rbSevenEighths);
            this.panel5.Controls.Add(this.rbThreeQuarters);
            this.panel5.Controls.Add(this.rbActFiveEighths);
            this.panel5.Controls.Add(this.rbActHalf);
            this.panel5.Controls.Add(this.rbActThreeEighths);
            this.panel5.Controls.Add(this.rbActQuarter);
            this.panel5.Controls.Add(this.rbActEighth);
            this.panel5.Location = new System.Drawing.Point(15, 264);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(399, 100);
            this.panel5.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(0, 24);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(399, 1);
            this.panel6.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Speed Selection";
            // 
            // rbActFull
            // 
            this.rbActFull.AutoSize = true;
            this.rbActFull.Location = new System.Drawing.Point(337, 68);
            this.rbActFull.Name = "rbActFull";
            this.rbActFull.Size = new System.Drawing.Size(41, 17);
            this.rbActFull.TabIndex = 7;
            this.rbActFull.Text = "Full";
            this.rbActFull.UseVisualStyleBackColor = true;
            this.rbActFull.CheckedChanged += new System.EventHandler(this.rbActFull_CheckedChanged);
            // 
            // rbSevenEighths
            // 
            this.rbSevenEighths.AutoSize = true;
            this.rbSevenEighths.Location = new System.Drawing.Point(221, 68);
            this.rbSevenEighths.Name = "rbSevenEighths";
            this.rbSevenEighths.Size = new System.Drawing.Size(94, 17);
            this.rbSevenEighths.TabIndex = 6;
            this.rbSevenEighths.Text = "Seven Eighths";
            this.rbSevenEighths.UseVisualStyleBackColor = true;
            this.rbSevenEighths.CheckedChanged += new System.EventHandler(this.rbSevenEighths_CheckedChanged);
            // 
            // rbThreeQuarters
            // 
            this.rbThreeQuarters.AutoSize = true;
            this.rbThreeQuarters.Location = new System.Drawing.Point(109, 68);
            this.rbThreeQuarters.Name = "rbThreeQuarters";
            this.rbThreeQuarters.Size = new System.Drawing.Size(96, 17);
            this.rbThreeQuarters.TabIndex = 5;
            this.rbThreeQuarters.Text = "Three Quarters";
            this.rbThreeQuarters.UseVisualStyleBackColor = true;
            this.rbThreeQuarters.CheckedChanged += new System.EventHandler(this.rbThreeQuarters_CheckedChanged);
            // 
            // rbActFiveEighths
            // 
            this.rbActFiveEighths.AutoSize = true;
            this.rbActFiveEighths.Location = new System.Drawing.Point(16, 68);
            this.rbActFiveEighths.Name = "rbActFiveEighths";
            this.rbActFiveEighths.Size = new System.Drawing.Size(83, 17);
            this.rbActFiveEighths.TabIndex = 4;
            this.rbActFiveEighths.Text = "Five Eighths";
            this.rbActFiveEighths.UseVisualStyleBackColor = true;
            this.rbActFiveEighths.CheckedChanged += new System.EventHandler(this.rbActFiveEighths_CheckedChanged);
            // 
            // rbActHalf
            // 
            this.rbActHalf.AutoSize = true;
            this.rbActHalf.Location = new System.Drawing.Point(337, 40);
            this.rbActHalf.Name = "rbActHalf";
            this.rbActHalf.Size = new System.Drawing.Size(44, 17);
            this.rbActHalf.TabIndex = 3;
            this.rbActHalf.Text = "Half";
            this.rbActHalf.UseVisualStyleBackColor = true;
            this.rbActHalf.CheckedChanged += new System.EventHandler(this.rbActHalf_CheckedChanged);
            // 
            // rbActThreeEighths
            // 
            this.rbActThreeEighths.AutoSize = true;
            this.rbActThreeEighths.Location = new System.Drawing.Point(221, 40);
            this.rbActThreeEighths.Name = "rbActThreeEighths";
            this.rbActThreeEighths.Size = new System.Drawing.Size(91, 17);
            this.rbActThreeEighths.TabIndex = 2;
            this.rbActThreeEighths.Text = "Three Eighths";
            this.rbActThreeEighths.UseVisualStyleBackColor = true;
            this.rbActThreeEighths.CheckedChanged += new System.EventHandler(this.rbActThreeEighths_CheckedChanged);
            // 
            // rbActQuarter
            // 
            this.rbActQuarter.AutoSize = true;
            this.rbActQuarter.Location = new System.Drawing.Point(109, 40);
            this.rbActQuarter.Name = "rbActQuarter";
            this.rbActQuarter.Size = new System.Drawing.Size(83, 17);
            this.rbActQuarter.TabIndex = 1;
            this.rbActQuarter.Text = "One Quarter";
            this.rbActQuarter.UseVisualStyleBackColor = true;
            this.rbActQuarter.CheckedChanged += new System.EventHandler(this.rbActQuarter_CheckedChanged);
            // 
            // rbActEighth
            // 
            this.rbActEighth.AutoSize = true;
            this.rbActEighth.Checked = true;
            this.rbActEighth.Location = new System.Drawing.Point(16, 40);
            this.rbActEighth.Name = "rbActEighth";
            this.rbActEighth.Size = new System.Drawing.Size(78, 17);
            this.rbActEighth.TabIndex = 0;
            this.rbActEighth.TabStop = true;
            this.rbActEighth.Text = "One Eighth";
            this.rbActEighth.UseVisualStyleBackColor = true;
            this.rbActEighth.CheckedChanged += new System.EventHandler(this.rbActEighth_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Actuator Controls";
            // 
            // btnActuatorStop
            // 
            this.btnActuatorStop.Location = new System.Drawing.Point(177, 166);
            this.btnActuatorStop.Name = "btnActuatorStop";
            this.btnActuatorStop.Size = new System.Drawing.Size(75, 23);
            this.btnActuatorStop.TabIndex = 3;
            this.btnActuatorStop.Text = "Stop";
            this.btnActuatorStop.UseVisualStyleBackColor = true;
            this.btnActuatorStop.Click += new System.EventHandler(this.btnActuatorStop_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(177, 209);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 2;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(177, 122);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 1;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // cmbActuatorSelect
            // 
            this.cmbActuatorSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActuatorSelect.FormattingEnabled = true;
            this.cmbActuatorSelect.Items.AddRange(new object[] {
            "Excavator",
            "Dump"});
            this.cmbActuatorSelect.Location = new System.Drawing.Point(18, 33);
            this.cmbActuatorSelect.Name = "cmbActuatorSelect";
            this.cmbActuatorSelect.Size = new System.Drawing.Size(121, 21);
            this.cmbActuatorSelect.TabIndex = 0;
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(25, 419);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(79, 13);
            this.lblDisplay.TabIndex = 8;
            this.lblDisplay.Text = "Program Status";
            // 
            // pnlCompControl
            // 
            this.pnlCompControl.Controls.Add(this.panel1);
            this.pnlCompControl.Controls.Add(this.panel2);
            this.pnlCompControl.Location = new System.Drawing.Point(0, 0);
            this.pnlCompControl.Name = "pnlCompControl";
            this.pnlCompControl.Size = new System.Drawing.Size(910, 416);
            this.pnlCompControl.TabIndex = 9;
            // 
            // pnlXboxControl
            // 
            this.pnlXboxControl.Controls.Add(this.groupBox2);
            this.pnlXboxControl.Controls.Add(this.groupBox1);
            this.pnlXboxControl.Controls.Add(this.panel7);
            this.pnlXboxControl.Location = new System.Drawing.Point(0, 34);
            this.pnlXboxControl.Name = "pnlXboxControl";
            this.pnlXboxControl.Size = new System.Drawing.Size(910, 382);
            this.pnlXboxControl.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSelectedDevice);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.lblDirection);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblSpeed);
            this.groupBox2.Location = new System.Drawing.Point(260, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 188);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Live Data";
            // 
            // lblSelectedDevice
            // 
            this.lblSelectedDevice.AutoSize = true;
            this.lblSelectedDevice.Location = new System.Drawing.Point(109, 27);
            this.lblSelectedDevice.Name = "lblSelectedDevice";
            this.lblSelectedDevice.Size = new System.Drawing.Size(59, 13);
            this.lblSelectedDevice.TabIndex = 4;
            this.lblSelectedDevice.Text = "DriveMotor";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(11, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "Selected Device: ";
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(109, 53);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(33, 13);
            this.lblDirection.TabIndex = 2;
            this.lblDirection.Text = "None";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Selected Direction:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Selected Speed:";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(109, 75);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(33, 13);
            this.lblSpeed.TabIndex = 1;
            this.lblSpeed.Text = "1/8th";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(504, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 200);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 131);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Right Bumper: Next device";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 144);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Left Bumper: Previous device";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "D-Pad Right: Control Actuators";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "D-Pad Left: Control Motors";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "D-Pad Down: Decrease Speed";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "D-Pad Up: Increase speed";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Left Stick: Choose direction";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Back: Stop";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "B: Stop";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "A: Send Command";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.lblCurrentDevice);
            this.panel7.Controls.Add(this.label19);
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Controls.Add(this.lblCurrentCommand);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Location = new System.Drawing.Point(34, 91);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 200);
            this.panel7.TabIndex = 5;
            // 
            // lblCurrentDevice
            // 
            this.lblCurrentDevice.AutoSize = true;
            this.lblCurrentDevice.Location = new System.Drawing.Point(128, 174);
            this.lblCurrentDevice.Name = "lblCurrentDevice";
            this.lblCurrentDevice.Size = new System.Drawing.Size(33, 13);
            this.lblCurrentDevice.TabIndex = 6;
            this.lblCurrentDevice.Text = "None";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(37, 174);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 13);
            this.label19.TabIndex = 5;
            this.label19.Text = "Current Device:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::NasaRobot.Properties.Resources.stop;
            this.pictureBox1.Location = new System.Drawing.Point(9, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblCurrentCommand
            // 
            this.lblCurrentCommand.AutoSize = true;
            this.lblCurrentCommand.Location = new System.Drawing.Point(128, 160);
            this.lblCurrentCommand.Name = "lblCurrentCommand";
            this.lblCurrentCommand.Size = new System.Drawing.Size(29, 13);
            this.lblCurrentCommand.TabIndex = 4;
            this.lblCurrentCommand.Text = "Stop";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Current Command:";
            // 
            // btnSwapControls
            // 
            this.btnSwapControls.Location = new System.Drawing.Point(720, 5);
            this.btnSwapControls.Name = "btnSwapControls";
            this.btnSwapControls.Size = new System.Drawing.Size(141, 23);
            this.btnSwapControls.TabIndex = 16;
            this.btnSwapControls.Text = "Change Control Scheme";
            this.btnSwapControls.UseVisualStyleBackColor = true;
            this.btnSwapControls.Click += new System.EventHandler(this.btnSwapControls_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(910, 443);
            this.Controls.Add(this.btnSwapControls);
            this.Controls.Add(this.pnlCompControl);
            this.Controls.Add(this.pnlXboxControl);
            this.Controls.Add(this.lblDisplay);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Robot Controller";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pnlCompControl.ResumeLayout(false);
            this.pnlXboxControl.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.ComboBox cmbMotorSelect;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnMotorStop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnActuatorStop;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.ComboBox cmbActuatorSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbMotorFull;
        private System.Windows.Forms.RadioButton rbMotorSevenEighths;
        private System.Windows.Forms.RadioButton rbMotorThreeQuarters;
        private System.Windows.Forms.RadioButton rbMotorFiveEighths;
        private System.Windows.Forms.RadioButton rbMotorHalf;
        private System.Windows.Forms.RadioButton rbMotorThreeEighths;
        private System.Windows.Forms.RadioButton rbMotorQuarter;
        private System.Windows.Forms.RadioButton rbMotorEighth;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbActFull;
        private System.Windows.Forms.RadioButton rbSevenEighths;
        private System.Windows.Forms.RadioButton rbThreeQuarters;
        private System.Windows.Forms.RadioButton rbActFiveEighths;
        private System.Windows.Forms.RadioButton rbActHalf;
        private System.Windows.Forms.RadioButton rbActThreeEighths;
        private System.Windows.Forms.RadioButton rbActQuarter;
        private System.Windows.Forms.RadioButton rbActEighth;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel pnlCompControl;
        private System.Windows.Forms.Panel pnlXboxControl;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSwapControls;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCurrentCommand;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblSelectedDevice;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblCurrentDevice;
        private System.Windows.Forms.Label label19;
    }
}

