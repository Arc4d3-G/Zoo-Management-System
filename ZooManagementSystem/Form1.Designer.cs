namespace ZooManagementSystem
{
    partial class Form1
    {
        
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabOverview = new TabPage();
            tableLayoutPanel9 = new TableLayoutPanel();
            groupBox4 = new GroupBox();
            richTextBoxIntro = new RichTextBox();
            labelLogo = new Label();
            tabAddNewAnimal = new TabPage();
            tableLayoutPanel7 = new TableLayoutPanel();
            labelValidationAge = new Label();
            labelValidationName = new Label();
            labelAddSpecies = new Label();
            labelAddName = new Label();
            labelAddAge = new Label();
            labelAddSex = new Label();
            labelAddLocation = new Label();
            comboBoxAddSpecies = new ComboBox();
            comboBoxAddLocation = new ComboBox();
            textBoxAddName = new TextBox();
            textBoxAddAge = new TextBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            radioButtonFemale = new RadioButton();
            radioButtonMale = new RadioButton();
            btnSubmit = new Button();
            labelValidationSpecies = new Label();
            labelValidationLocation = new Label();
            labelValidationSex = new Label();
            labelSubmitSuccess = new Label();
            labelAddNew = new Label();
            tabViewAnimals = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            comboBoxSelectAnimal = new ComboBox();
            groupBoxActionLog = new GroupBox();
            textBoxActionLog = new TextBox();
            groupBoxActions = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnEat = new Button();
            btnVocalize = new Button();
            btnPlay = new Button();
            btnSleep = new Button();
            btnFeed = new Button();
            textBoxTreat = new TextBox();
            groupBoxAnimalDetails = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            labelViewName = new Label();
            textBoxViewName = new TextBox();
            textBoxViewAge = new TextBox();
            textBoxViewSex = new TextBox();
            textBoxViewLocation = new TextBox();
            labelViewAge = new Label();
            labelViewSex = new Label();
            labelViewLocation = new Label();
            groupBoxPicture = new GroupBox();
            pictureBoxViewPicture = new PictureBox();
            labelSpecies = new Label();
            comboBoxSelectSpecies = new ComboBox();
            labelSelectAnimal = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox3 = new GroupBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            label2 = new Label();
            textBox2 = new TextBox();
            tabControl1.SuspendLayout();
            tabOverview.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            groupBox4.SuspendLayout();
            tabAddNewAnimal.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tabViewAnimals.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBoxActionLog.SuspendLayout();
            groupBoxActions.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBoxAnimalDetails.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBoxPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxViewPicture).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Left;
            tabControl1.Controls.Add(tabOverview);
            tabControl1.Controls.Add(tabAddNewAnimal);
            tabControl1.Controls.Add(tabViewAnimals);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.ItemSize = new Size(60, 120);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(615, 406);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 0;
            tabControl1.DrawItem += tabControl1_DrawItem;
            // 
            // tabOverview
            // 
            tabOverview.BackColor = SystemColors.ActiveCaption;
            tabOverview.Controls.Add(tableLayoutPanel9);
            tabOverview.Location = new Point(124, 4);
            tabOverview.Name = "tabOverview";
            tabOverview.Padding = new Padding(3);
            tabOverview.Size = new Size(487, 398);
            tabOverview.TabIndex = 0;
            tabOverview.Text = "Overview";
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Controls.Add(groupBox4, 0, 1);
            tableLayoutPanel9.Controls.Add(labelLogo, 0, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(3, 3);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 34.94898F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 65.05102F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel9.Size = new Size(481, 392);
            tableLayoutPanel9.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(richTextBoxIntro);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(3, 140);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(475, 249);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "App Info";
            // 
            // richTextBoxIntro
            // 
            richTextBoxIntro.BackColor = SystemColors.GradientActiveCaption;
            richTextBoxIntro.Dock = DockStyle.Fill;
            richTextBoxIntro.Font = new Font("Calibri", 11F);
            richTextBoxIntro.Location = new Point(3, 22);
            richTextBoxIntro.Name = "richTextBoxIntro";
            richTextBoxIntro.ReadOnly = true;
            richTextBoxIntro.Size = new Size(469, 224);
            richTextBoxIntro.TabIndex = 2;
            richTextBoxIntro.Text = resources.GetString("richTextBoxIntro.Text");
            // 
            // labelLogo
            // 
            labelLogo.Anchor = AnchorStyles.None;
            labelLogo.AutoSize = true;
            labelLogo.Font = new Font("Microsoft PhagsPa", 50.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLogo.ForeColor = SystemColors.ControlLightLight;
            labelLogo.Location = new Point(10, 24);
            labelLogo.Name = "labelLogo";
            labelLogo.Size = new Size(460, 89);
            labelLogo.TabIndex = 0;
            labelLogo.Text = "Zoo Manager";
            // 
            // tabAddNewAnimal
            // 
            tabAddNewAnimal.BackColor = SystemColors.ActiveCaption;
            tabAddNewAnimal.Controls.Add(tableLayoutPanel7);
            tabAddNewAnimal.Controls.Add(labelAddNew);
            tabAddNewAnimal.Location = new Point(124, 4);
            tabAddNewAnimal.Name = "tabAddNewAnimal";
            tabAddNewAnimal.Size = new Size(487, 398);
            tabAddNewAnimal.TabIndex = 2;
            tabAddNewAnimal.Text = "Add New Animal";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 3;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.6296329F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.3909454F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.9794235F));
            tableLayoutPanel7.Controls.Add(labelValidationAge, 2, 2);
            tableLayoutPanel7.Controls.Add(labelValidationName, 2, 1);
            tableLayoutPanel7.Controls.Add(labelAddSpecies, 0, 0);
            tableLayoutPanel7.Controls.Add(labelAddName, 0, 1);
            tableLayoutPanel7.Controls.Add(labelAddAge, 0, 2);
            tableLayoutPanel7.Controls.Add(labelAddSex, 0, 3);
            tableLayoutPanel7.Controls.Add(labelAddLocation, 0, 4);
            tableLayoutPanel7.Controls.Add(comboBoxAddSpecies, 1, 0);
            tableLayoutPanel7.Controls.Add(comboBoxAddLocation, 1, 4);
            tableLayoutPanel7.Controls.Add(textBoxAddName, 1, 1);
            tableLayoutPanel7.Controls.Add(textBoxAddAge, 1, 2);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel8, 1, 3);
            tableLayoutPanel7.Controls.Add(btnSubmit, 1, 5);
            tableLayoutPanel7.Controls.Add(labelValidationSpecies, 2, 0);
            tableLayoutPanel7.Controls.Add(labelValidationLocation, 2, 4);
            tableLayoutPanel7.Controls.Add(labelValidationSex, 2, 3);
            tableLayoutPanel7.Controls.Add(labelSubmitSuccess, 2, 5);
            tableLayoutPanel7.Location = new Point(0, 48);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 6;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 13.6186762F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 13.6186762F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 13.6186762F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 13.6186762F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 13.6186762F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 31.9066181F));
            tableLayoutPanel7.Size = new Size(487, 350);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // labelValidationAge
            // 
            labelValidationAge.Anchor = AnchorStyles.Left;
            labelValidationAge.AutoSize = true;
            labelValidationAge.BackColor = Color.Transparent;
            labelValidationAge.Font = new Font("Calibri", 10F);
            labelValidationAge.ForeColor = Color.DarkRed;
            labelValidationAge.Location = new Point(319, 100);
            labelValidationAge.Name = "labelValidationAge";
            labelValidationAge.Size = new Size(163, 34);
            labelValidationAge.TabIndex = 15;
            labelValidationAge.Text = "Age field can only contain digits and cannot be empty.";
            labelValidationAge.Visible = false;
            // 
            // labelValidationName
            // 
            labelValidationName.Anchor = AnchorStyles.Left;
            labelValidationName.AutoSize = true;
            labelValidationName.BackColor = Color.Transparent;
            labelValidationName.Font = new Font("Calibri", 10F);
            labelValidationName.ForeColor = Color.DarkRed;
            labelValidationName.Location = new Point(319, 47);
            labelValidationName.Name = "labelValidationName";
            labelValidationName.Size = new Size(163, 47);
            labelValidationName.TabIndex = 14;
            labelValidationName.Text = "Name field can only contain alphabetic characters and cannot be empty.\r\n";
            labelValidationName.Visible = false;
            // 
            // labelAddSpecies
            // 
            labelAddSpecies.Anchor = AnchorStyles.Right;
            labelAddSpecies.AutoSize = true;
            labelAddSpecies.ForeColor = Color.Black;
            labelAddSpecies.Location = new Point(92, 16);
            labelAddSpecies.Name = "labelAddSpecies";
            labelAddSpecies.Size = new Size(49, 15);
            labelAddSpecies.TabIndex = 0;
            labelAddSpecies.Text = "Species:";
            // 
            // labelAddName
            // 
            labelAddName.Anchor = AnchorStyles.Right;
            labelAddName.AutoSize = true;
            labelAddName.ForeColor = Color.Black;
            labelAddName.Location = new Point(99, 63);
            labelAddName.Name = "labelAddName";
            labelAddName.Size = new Size(42, 15);
            labelAddName.TabIndex = 1;
            labelAddName.Text = "Name:";
            // 
            // labelAddAge
            // 
            labelAddAge.Anchor = AnchorStyles.Right;
            labelAddAge.AutoSize = true;
            labelAddAge.ForeColor = Color.Black;
            labelAddAge.Location = new Point(110, 110);
            labelAddAge.Name = "labelAddAge";
            labelAddAge.Size = new Size(31, 15);
            labelAddAge.TabIndex = 2;
            labelAddAge.Text = "Age:";
            // 
            // labelAddSex
            // 
            labelAddSex.Anchor = AnchorStyles.Right;
            labelAddSex.AutoSize = true;
            labelAddSex.ForeColor = Color.Black;
            labelAddSex.Location = new Point(113, 157);
            labelAddSex.Name = "labelAddSex";
            labelAddSex.Size = new Size(28, 15);
            labelAddSex.TabIndex = 3;
            labelAddSex.Text = "Sex:";
            // 
            // labelAddLocation
            // 
            labelAddLocation.Anchor = AnchorStyles.Right;
            labelAddLocation.AutoSize = true;
            labelAddLocation.ForeColor = Color.Black;
            labelAddLocation.Location = new Point(85, 204);
            labelAddLocation.Name = "labelAddLocation";
            labelAddLocation.Size = new Size(56, 15);
            labelAddLocation.TabIndex = 4;
            labelAddLocation.Text = "Location:";
            // 
            // comboBoxAddSpecies
            // 
            comboBoxAddSpecies.Anchor = AnchorStyles.Left;
            comboBoxAddSpecies.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAddSpecies.FormattingEnabled = true;
            comboBoxAddSpecies.Location = new Point(147, 12);
            comboBoxAddSpecies.Name = "comboBoxAddSpecies";
            comboBoxAddSpecies.Size = new Size(166, 23);
            comboBoxAddSpecies.TabIndex = 5;
            // 
            // comboBoxAddLocation
            // 
            comboBoxAddLocation.Anchor = AnchorStyles.Left;
            comboBoxAddLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAddLocation.FormattingEnabled = true;
            comboBoxAddLocation.Location = new Point(147, 200);
            comboBoxAddLocation.Name = "comboBoxAddLocation";
            comboBoxAddLocation.Size = new Size(166, 23);
            comboBoxAddLocation.TabIndex = 6;
            // 
            // textBoxAddName
            // 
            textBoxAddName.Anchor = AnchorStyles.Left;
            textBoxAddName.Location = new Point(147, 59);
            textBoxAddName.Name = "textBoxAddName";
            textBoxAddName.Size = new Size(166, 23);
            textBoxAddName.TabIndex = 9;
            // 
            // textBoxAddAge
            // 
            textBoxAddAge.Anchor = AnchorStyles.Left;
            textBoxAddAge.Location = new Point(147, 106);
            textBoxAddAge.Name = "textBoxAddAge";
            textBoxAddAge.Size = new Size(166, 23);
            textBoxAddAge.TabIndex = 10;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(radioButtonFemale, 1, 0);
            tableLayoutPanel8.Controls.Add(radioButtonMale, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(147, 144);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(166, 41);
            tableLayoutPanel8.TabIndex = 12;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.Anchor = AnchorStyles.Left;
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.ForeColor = Color.Black;
            radioButtonFemale.Location = new Point(86, 11);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(63, 19);
            radioButtonFemale.TabIndex = 8;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            radioButtonMale.Anchor = AnchorStyles.Left;
            radioButtonMale.AutoSize = true;
            radioButtonMale.ForeColor = Color.Black;
            radioButtonMale.Location = new Point(3, 11);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(51, 19);
            radioButtonMale.TabIndex = 7;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.None;
            btnSubmit.Location = new Point(163, 267);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(133, 51);
            btnSubmit.TabIndex = 11;
            btnSubmit.Text = "Add to Zoo";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // labelValidationSpecies
            // 
            labelValidationSpecies.Anchor = AnchorStyles.Left;
            labelValidationSpecies.AutoSize = true;
            labelValidationSpecies.BackColor = Color.Transparent;
            labelValidationSpecies.Font = new Font("Calibri", 10F);
            labelValidationSpecies.ForeColor = Color.DarkRed;
            labelValidationSpecies.Location = new Point(319, 6);
            labelValidationSpecies.Name = "labelValidationSpecies";
            labelValidationSpecies.Size = new Size(138, 34);
            labelValidationSpecies.TabIndex = 13;
            labelValidationSpecies.Text = "Species field cannot be empty.";
            labelValidationSpecies.Visible = false;
            // 
            // labelValidationLocation
            // 
            labelValidationLocation.Anchor = AnchorStyles.Left;
            labelValidationLocation.AutoSize = true;
            labelValidationLocation.BackColor = Color.Transparent;
            labelValidationLocation.Font = new Font("Calibri", 10F);
            labelValidationLocation.ForeColor = Color.DarkRed;
            labelValidationLocation.Location = new Point(319, 194);
            labelValidationLocation.Name = "labelValidationLocation";
            labelValidationLocation.Size = new Size(145, 34);
            labelValidationLocation.TabIndex = 16;
            labelValidationLocation.Text = "Location field cannot be empty.";
            labelValidationLocation.Visible = false;
            // 
            // labelValidationSex
            // 
            labelValidationSex.Anchor = AnchorStyles.Left;
            labelValidationSex.AutoSize = true;
            labelValidationSex.BackColor = Color.Transparent;
            labelValidationSex.Font = new Font("Calibri", 10F);
            labelValidationSex.ForeColor = Color.DarkRed;
            labelValidationSex.Location = new Point(319, 156);
            labelValidationSex.Name = "labelValidationSex";
            labelValidationSex.Size = new Size(155, 17);
            labelValidationSex.TabIndex = 17;
            labelValidationSex.Text = "Sex field cannot be empty.";
            labelValidationSex.Visible = false;
            // 
            // labelSubmitSuccess
            // 
            labelSubmitSuccess.Anchor = AnchorStyles.Left;
            labelSubmitSuccess.AutoSize = true;
            labelSubmitSuccess.BackColor = Color.Transparent;
            labelSubmitSuccess.Font = new Font("Calibri", 10F);
            labelSubmitSuccess.ForeColor = Color.Green;
            labelSubmitSuccess.Location = new Point(319, 284);
            labelSubmitSuccess.Name = "labelSubmitSuccess";
            labelSubmitSuccess.Size = new Size(133, 17);
            labelSubmitSuccess.TabIndex = 18;
            labelSubmitSuccess.Text = "Successfully Submitted";
            labelSubmitSuccess.Visible = false;
            // 
            // labelAddNew
            // 
            labelAddNew.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            labelAddNew.AutoSize = true;
            labelAddNew.BackColor = Color.Transparent;
            labelAddNew.Font = new Font("Calibri", 10F);
            labelAddNew.Location = new Point(63, 16);
            labelAddNew.Name = "labelAddNew";
            labelAddNew.Size = new Size(350, 17);
            labelAddNew.TabIndex = 19;
            labelAddNew.Text = "Complete the following form to add a new animal to the Zoo.";
            // 
            // tabViewAnimals
            // 
            tabViewAnimals.BackColor = SystemColors.ActiveCaption;
            tabViewAnimals.Controls.Add(tableLayoutPanel1);
            tabViewAnimals.Location = new Point(124, 4);
            tabViewAnimals.Name = "tabViewAnimals";
            tabViewAnimals.Padding = new Padding(3);
            tabViewAnimals.Size = new Size(487, 398);
            tabViewAnimals.TabIndex = 1;
            tabViewAnimals.Text = "View Animals";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.66667F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.3333321F));
            tableLayoutPanel1.Controls.Add(comboBoxSelectAnimal, 1, 1);
            tableLayoutPanel1.Controls.Add(groupBoxActionLog, 0, 3);
            tableLayoutPanel1.Controls.Add(groupBoxActions, 1, 3);
            tableLayoutPanel1.Controls.Add(groupBoxAnimalDetails, 1, 2);
            tableLayoutPanel1.Controls.Add(groupBoxPicture, 0, 2);
            tableLayoutPanel1.Controls.Add(labelSpecies, 0, 0);
            tableLayoutPanel1.Controls.Add(comboBoxSelectSpecies, 1, 0);
            tableLayoutPanel1.Controls.Add(labelSelectAnimal, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.142857F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 58.4183655F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 26.898838F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(481, 392);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // comboBoxSelectAnimal
            // 
            comboBoxSelectAnimal.Anchor = AnchorStyles.Left;
            comboBoxSelectAnimal.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSelectAnimal.Enabled = false;
            comboBoxSelectAnimal.FormattingEnabled = true;
            comboBoxSelectAnimal.Location = new Point(208, 31);
            comboBoxSelectAnimal.Name = "comboBoxSelectAnimal";
            comboBoxSelectAnimal.Size = new Size(121, 23);
            comboBoxSelectAnimal.TabIndex = 10;
            comboBoxSelectAnimal.SelectedIndexChanged += comboBoxSelectAnimal_SelectedIndexChanged;
            // 
            // groupBoxActionLog
            // 
            groupBoxActionLog.Controls.Add(textBoxActionLog);
            groupBoxActionLog.Dock = DockStyle.Fill;
            groupBoxActionLog.Font = new Font("Calibri", 11.25F);
            groupBoxActionLog.ForeColor = Color.Black;
            groupBoxActionLog.Location = new Point(3, 288);
            groupBoxActionLog.Name = "groupBoxActionLog";
            groupBoxActionLog.Size = new Size(199, 101);
            groupBoxActionLog.TabIndex = 6;
            groupBoxActionLog.TabStop = false;
            groupBoxActionLog.Text = "Action Log";
            // 
            // textBoxActionLog
            // 
            textBoxActionLog.Dock = DockStyle.Fill;
            textBoxActionLog.Enabled = false;
            textBoxActionLog.Location = new Point(3, 22);
            textBoxActionLog.Multiline = true;
            textBoxActionLog.Name = "textBoxActionLog";
            textBoxActionLog.Size = new Size(193, 76);
            textBoxActionLog.TabIndex = 0;
            // 
            // groupBoxActions
            // 
            groupBoxActions.Controls.Add(tableLayoutPanel3);
            groupBoxActions.Dock = DockStyle.Fill;
            groupBoxActions.ForeColor = Color.Black;
            groupBoxActions.Location = new Point(208, 288);
            groupBoxActions.Name = "groupBoxActions";
            groupBoxActions.Size = new Size(270, 101);
            groupBoxActions.TabIndex = 5;
            groupBoxActions.TabStop = false;
            groupBoxActions.Text = "Actions";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 86F));
            tableLayoutPanel3.Controls.Add(btnEat, 0, 1);
            tableLayoutPanel3.Controls.Add(btnVocalize, 1, 0);
            tableLayoutPanel3.Controls.Add(btnPlay, 2, 0);
            tableLayoutPanel3.Controls.Add(btnSleep, 0, 0);
            tableLayoutPanel3.Controls.Add(btnFeed, 1, 1);
            tableLayoutPanel3.Controls.Add(textBoxTreat, 2, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 19);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(264, 79);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // btnEat
            // 
            btnEat.Anchor = AnchorStyles.None;
            btnEat.Enabled = false;
            btnEat.Font = new Font("Calibri", 11.25F);
            btnEat.ForeColor = SystemColors.ActiveCaptionText;
            btnEat.Location = new Point(7, 42);
            btnEat.Name = "btnEat";
            btnEat.Size = new Size(74, 33);
            btnEat.TabIndex = 4;
            btnEat.Text = "Eat";
            btnEat.UseVisualStyleBackColor = true;
            btnEat.Click += btnEat_Click;
            // 
            // btnVocalize
            // 
            btnVocalize.Anchor = AnchorStyles.None;
            btnVocalize.Enabled = false;
            btnVocalize.Font = new Font("Calibri", 11.25F);
            btnVocalize.ForeColor = SystemColors.ActiveCaptionText;
            btnVocalize.Location = new Point(96, 3);
            btnVocalize.Name = "btnVocalize";
            btnVocalize.Size = new Size(74, 33);
            btnVocalize.TabIndex = 1;
            btnVocalize.Text = "Vocalize";
            btnVocalize.UseVisualStyleBackColor = true;
            btnVocalize.Click += btnVocalize_Click;
            // 
            // btnPlay
            // 
            btnPlay.Anchor = AnchorStyles.None;
            btnPlay.Enabled = false;
            btnPlay.Font = new Font("Calibri", 11.25F);
            btnPlay.ForeColor = SystemColors.ActiveCaptionText;
            btnPlay.Location = new Point(183, 3);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(75, 33);
            btnPlay.TabIndex = 2;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnSleep
            // 
            btnSleep.Anchor = AnchorStyles.None;
            btnSleep.Enabled = false;
            btnSleep.Font = new Font("Calibri", 11.25F);
            btnSleep.ForeColor = SystemColors.ActiveCaptionText;
            btnSleep.Location = new Point(7, 3);
            btnSleep.Name = "btnSleep";
            btnSleep.Size = new Size(74, 33);
            btnSleep.TabIndex = 3;
            btnSleep.Text = "Sleep";
            btnSleep.UseVisualStyleBackColor = true;
            btnSleep.Click += btnSleep_Click;
            // 
            // btnFeed
            // 
            btnFeed.Anchor = AnchorStyles.None;
            btnFeed.Enabled = false;
            btnFeed.Font = new Font("Calibri", 11.25F);
            btnFeed.ForeColor = SystemColors.ActiveCaptionText;
            btnFeed.Location = new Point(96, 42);
            btnFeed.Name = "btnFeed";
            btnFeed.Size = new Size(74, 33);
            btnFeed.TabIndex = 0;
            btnFeed.Text = "Feed:";
            btnFeed.UseVisualStyleBackColor = true;
            btnFeed.Click += btnFeed_Click;
            // 
            // textBoxTreat
            // 
            textBoxTreat.Anchor = AnchorStyles.None;
            textBoxTreat.Location = new Point(181, 47);
            textBoxTreat.Name = "textBoxTreat";
            textBoxTreat.Size = new Size(80, 23);
            textBoxTreat.TabIndex = 5;
            textBoxTreat.TextChanged += textBoxTreat_TextChanged;
            // 
            // groupBoxAnimalDetails
            // 
            groupBoxAnimalDetails.Controls.Add(tableLayoutPanel2);
            groupBoxAnimalDetails.Dock = DockStyle.Fill;
            groupBoxAnimalDetails.Font = new Font("Calibri", 11.25F);
            groupBoxAnimalDetails.ForeColor = Color.Black;
            groupBoxAnimalDetails.Location = new Point(208, 59);
            groupBoxAnimalDetails.Name = "groupBoxAnimalDetails";
            groupBoxAnimalDetails.Size = new Size(270, 223);
            groupBoxAnimalDetails.TabIndex = 7;
            groupBoxAnimalDetails.TabStop = false;
            groupBoxAnimalDetails.Text = "Animal Details";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.4227638F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.7804871F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.2032528F));
            tableLayoutPanel2.Controls.Add(labelViewName, 0, 0);
            tableLayoutPanel2.Controls.Add(textBoxViewName, 1, 0);
            tableLayoutPanel2.Controls.Add(textBoxViewAge, 1, 1);
            tableLayoutPanel2.Controls.Add(textBoxViewSex, 1, 2);
            tableLayoutPanel2.Controls.Add(textBoxViewLocation, 1, 3);
            tableLayoutPanel2.Controls.Add(labelViewAge, 0, 1);
            tableLayoutPanel2.Controls.Add(labelViewSex, 0, 2);
            tableLayoutPanel2.Controls.Add(labelViewLocation, 0, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 22);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(264, 198);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // labelViewName
            // 
            labelViewName.Anchor = AnchorStyles.Right;
            labelViewName.AutoSize = true;
            labelViewName.Font = new Font("Calibri", 11.25F);
            labelViewName.ForeColor = Color.Black;
            labelViewName.Location = new Point(17, 10);
            labelViewName.Name = "labelViewName";
            labelViewName.Size = new Size(49, 18);
            labelViewName.TabIndex = 0;
            labelViewName.Text = "Name:";
            // 
            // textBoxViewName
            // 
            textBoxViewName.Anchor = AnchorStyles.None;
            textBoxViewName.Enabled = false;
            textBoxViewName.Location = new Point(83, 6);
            textBoxViewName.Name = "textBoxViewName";
            textBoxViewName.Size = new Size(100, 26);
            textBoxViewName.TabIndex = 4;
            // 
            // textBoxViewAge
            // 
            textBoxViewAge.Anchor = AnchorStyles.None;
            textBoxViewAge.Enabled = false;
            textBoxViewAge.Location = new Point(83, 45);
            textBoxViewAge.Name = "textBoxViewAge";
            textBoxViewAge.Size = new Size(100, 26);
            textBoxViewAge.TabIndex = 5;
            // 
            // textBoxViewSex
            // 
            textBoxViewSex.Anchor = AnchorStyles.None;
            textBoxViewSex.Enabled = false;
            textBoxViewSex.Location = new Point(83, 84);
            textBoxViewSex.Name = "textBoxViewSex";
            textBoxViewSex.Size = new Size(100, 26);
            textBoxViewSex.TabIndex = 6;
            // 
            // textBoxViewLocation
            // 
            textBoxViewLocation.Anchor = AnchorStyles.None;
            textBoxViewLocation.Enabled = false;
            textBoxViewLocation.Location = new Point(83, 123);
            textBoxViewLocation.Name = "textBoxViewLocation";
            textBoxViewLocation.Size = new Size(100, 26);
            textBoxViewLocation.TabIndex = 7;
            // 
            // labelViewAge
            // 
            labelViewAge.Anchor = AnchorStyles.Right;
            labelViewAge.AutoSize = true;
            labelViewAge.Font = new Font("Calibri", 11.25F);
            labelViewAge.ForeColor = Color.Black;
            labelViewAge.Location = new Point(30, 49);
            labelViewAge.Name = "labelViewAge";
            labelViewAge.Size = new Size(36, 18);
            labelViewAge.TabIndex = 1;
            labelViewAge.Text = "Age:";
            // 
            // labelViewSex
            // 
            labelViewSex.Anchor = AnchorStyles.Right;
            labelViewSex.AutoSize = true;
            labelViewSex.Font = new Font("Calibri", 11.25F);
            labelViewSex.ForeColor = Color.Black;
            labelViewSex.Location = new Point(32, 88);
            labelViewSex.Name = "labelViewSex";
            labelViewSex.Size = new Size(34, 18);
            labelViewSex.TabIndex = 2;
            labelViewSex.Text = "Sex:";
            // 
            // labelViewLocation
            // 
            labelViewLocation.Anchor = AnchorStyles.Right;
            labelViewLocation.AutoSize = true;
            labelViewLocation.Font = new Font("Calibri", 11.25F);
            labelViewLocation.ForeColor = Color.Black;
            labelViewLocation.Location = new Point(3, 127);
            labelViewLocation.Name = "labelViewLocation";
            labelViewLocation.Size = new Size(63, 18);
            labelViewLocation.TabIndex = 3;
            labelViewLocation.Text = "Location:";
            // 
            // groupBoxPicture
            // 
            groupBoxPicture.BackColor = Color.Transparent;
            groupBoxPicture.Controls.Add(pictureBoxViewPicture);
            groupBoxPicture.Dock = DockStyle.Fill;
            groupBoxPicture.Font = new Font("Calibri", 11.25F);
            groupBoxPicture.ForeColor = Color.Black;
            groupBoxPicture.Location = new Point(3, 59);
            groupBoxPicture.Name = "groupBoxPicture";
            groupBoxPicture.Size = new Size(199, 223);
            groupBoxPicture.TabIndex = 8;
            groupBoxPicture.TabStop = false;
            groupBoxPicture.Text = "Picture";
            // 
            // pictureBoxViewPicture
            // 
            pictureBoxViewPicture.Dock = DockStyle.Fill;
            pictureBoxViewPicture.InitialImage = null;
            pictureBoxViewPicture.Location = new Point(3, 22);
            pictureBoxViewPicture.Name = "pictureBoxViewPicture";
            pictureBoxViewPicture.Size = new Size(193, 198);
            pictureBoxViewPicture.TabIndex = 0;
            pictureBoxViewPicture.TabStop = false;
            // 
            // labelSpecies
            // 
            labelSpecies.Anchor = AnchorStyles.Right;
            labelSpecies.AutoSize = true;
            labelSpecies.Font = new Font("Calibri", 11.25F);
            labelSpecies.ForeColor = Color.Black;
            labelSpecies.Location = new Point(102, 5);
            labelSpecies.Name = "labelSpecies";
            labelSpecies.Size = new Size(100, 18);
            labelSpecies.TabIndex = 4;
            labelSpecies.Text = "Select Species:";
            // 
            // comboBoxSelectSpecies
            // 
            comboBoxSelectSpecies.Anchor = AnchorStyles.Left;
            comboBoxSelectSpecies.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSelectSpecies.FormattingEnabled = true;
            comboBoxSelectSpecies.Location = new Point(208, 3);
            comboBoxSelectSpecies.Name = "comboBoxSelectSpecies";
            comboBoxSelectSpecies.Size = new Size(121, 23);
            comboBoxSelectSpecies.TabIndex = 2;
            comboBoxSelectSpecies.SelectedIndexChanged += comboBoxSelectSpecies_SelectedIndexChanged;
            // 
            // labelSelectAnimal
            // 
            labelSelectAnimal.Anchor = AnchorStyles.Right;
            labelSelectAnimal.AutoSize = true;
            labelSelectAnimal.Font = new Font("Calibri", 11.25F);
            labelSelectAnimal.Location = new Point(105, 33);
            labelSelectAnimal.Name = "labelSelectAnimal";
            labelSelectAnimal.Size = new Size(97, 18);
            labelSelectAnimal.TabIndex = 9;
            labelSelectAnimal.Text = "Select Animal:";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.Transparent;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.6666679F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.3333321F));
            tableLayoutPanel4.Controls.Add(groupBox1, 0, 3);
            tableLayoutPanel4.Controls.Add(comboBox1, 1, 1);
            tableLayoutPanel4.Controls.Add(label1, 1, 0);
            tableLayoutPanel4.Controls.Add(groupBox2, 1, 3);
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.Size = new Size(200, 100);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom;
            groupBox1.Controls.Add(textBox1);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(3, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(79, 103);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Action Log";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 19);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(73, 81);
            textBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(88, 18);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(109, 23);
            comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(101, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 4;
            label1.Text = "Select Animal:";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom;
            groupBox2.Controls.Add(tableLayoutPanel5);
            groupBox2.ForeColor = SystemColors.ControlLightLight;
            groupBox2.Location = new Point(88, 47);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(109, 103);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Actions";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 86F));
            tableLayoutPanel5.Controls.Add(button1, 0, 0);
            tableLayoutPanel5.Controls.Add(button2, 1, 0);
            tableLayoutPanel5.Controls.Add(button3, 2, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 19);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(103, 81);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(3, 29);
            button1.Name = "button1";
            button1.Size = new Size(2, 23);
            button1.TabIndex = 0;
            button1.Text = "Feed";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(11, 29);
            button2.Name = "button2";
            button2.Size = new Size(2, 23);
            button2.TabIndex = 1;
            button2.Text = "Vocalize";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(22, 29);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Play";
            button3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 100);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.4227638F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.7804871F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.2032528F));
            tableLayoutPanel6.Controls.Add(label2, 0, 0);
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.Size = new Size(200, 100);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(7, 42);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 0;
            label2.Text = "Name:";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(55, 38);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(91, 23);
            textBox2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(615, 406);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Zoo Manager";
            tabControl1.ResumeLayout(false);
            tabOverview.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            groupBox4.ResumeLayout(false);
            tabAddNewAnimal.ResumeLayout(false);
            tabAddNewAnimal.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tabViewAnimals.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBoxActionLog.ResumeLayout(false);
            groupBoxActionLog.PerformLayout();
            groupBoxActions.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            groupBoxAnimalDetails.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            groupBoxPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxViewPicture).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabOverview;
        private TabPage tabViewAnimals;
        private TabPage tabAddNewAnimal;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox comboBoxSelectSpecies;
        private Label labelSpecies;
        private GroupBox groupBoxAnimalDetails;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelViewName;
        private Label labelViewAge;
        private Label labelViewSex;
        private Label labelViewLocation;
        private TextBox textBoxViewLocation;
        private TextBox textBoxViewSex;
        private TextBox textBoxViewAge;
        private TextBox textBoxViewName;
        private GroupBox groupBoxPicture;
        private PictureBox pictureBoxViewPicture;
        private TableLayoutPanel tableLayoutPanel4;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label1;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel5;
        private Button button1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label2;
        private TextBox textBox2;
        private TableLayoutPanel tableLayoutPanel7;
        private Label labelAddSpecies;
        private Label labelAddName;
        private Label labelAddAge;
        private Label labelAddSex;
        private Label labelAddLocation;
        private ComboBox comboBoxAddSpecies;
        private ComboBox comboBoxAddLocation;
        private RadioButton radioButtonMale;
        private TextBox textBoxAddName;
        private TextBox textBoxAddAge;
        private Button btnSubmit;
        private TableLayoutPanel tableLayoutPanel8;
        private RadioButton radioButtonFemale;
        private TableLayoutPanel tableLayoutPanel9;
        private Label labelLogo;
        private GroupBox groupBoxActionLog;
        private TextBox textBoxActionLog;
        private GroupBox groupBoxActions;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnFeed;
        private Button btnVocalize;
        private Button btnPlay;
        private ComboBox comboBoxSelectAnimal;
        private Label labelSelectAnimal;
        private Button btnEat;
        private Button btnSleep;
        private Label labelValidationAge;
        private Label labelValidationName;
        private Label labelValidationSpecies;
        private Label labelValidationLocation;
        private Label labelValidationSex;
        private Label labelSubmitSuccess;
        private GroupBox groupBox4;
        private RichTextBox richTextBoxIntro;
        private Label labelAddNew;
        private TextBox textBoxTreat;
    }
}
