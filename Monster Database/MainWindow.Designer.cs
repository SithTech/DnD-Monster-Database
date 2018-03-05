namespace Monster_Database
{
    partial class MainWindow
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
            mgr.saveXML(mgr.monster_list, mgr.default_save_path + mgr.save_name + ".xml");
            mgr.saveBackup();

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
            this.searchGridView = new System.Windows.Forms.DataGridView();
            this.monsterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchFilter = new System.Windows.Forms.ComboBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btn_newMonster = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.checkBox_Name = new System.Windows.Forms.CheckBox();
            this.checkBox_Type = new System.Windows.Forms.CheckBox();
            this.checkBox_SubType = new System.Windows.Forms.CheckBox();
            this.checkBox_Territory = new System.Windows.Forms.CheckBox();
            this.checkBox_ChallengeRating = new System.Windows.Forms.CheckBox();
            this.checkBox_Alignment = new System.Windows.Forms.CheckBox();
            this.checkBox_ArmorClass = new System.Windows.Forms.CheckBox();
            this.checkBox_HealthPoints = new System.Windows.Forms.CheckBox();
            this.checkBox_Size = new System.Windows.Forms.CheckBox();
            this.checkBox_PageNumber = new System.Windows.Forms.CheckBox();
            this.checkBox_SourceBook = new System.Windows.Forms.CheckBox();
            this.checkBox_Notes = new System.Windows.Forms.CheckBox();
            this.btn_ClearAll = new System.Windows.Forms.Button();
            this.btn_CheckAll = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.territoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.challengeRatingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alignmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.armorClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.healthPointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceBookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monsterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // searchGridView
            // 
            this.searchGridView.AllowUserToAddRows = false;
            this.searchGridView.AllowUserToDeleteRows = false;
            this.searchGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchGridView.AutoGenerateColumns = false;
            this.searchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.subTypeDataGridViewTextBoxColumn,
            this.territoryDataGridViewTextBoxColumn,
            this.challengeRatingDataGridViewTextBoxColumn,
            this.alignmentDataGridViewTextBoxColumn,
            this.armorClassDataGridViewTextBoxColumn,
            this.healthPointsDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.pageNumberDataGridViewTextBoxColumn,
            this.sourceBookDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.searchGridView.DataSource = this.monsterBindingSource;
            this.searchGridView.Location = new System.Drawing.Point(18, 211);
            this.searchGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchGridView.MultiSelect = false;
            this.searchGridView.Name = "searchGridView";
            this.searchGridView.ReadOnly = true;
            this.searchGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchGridView.Size = new System.Drawing.Size(1950, 509);
            this.searchGridView.TabIndex = 3;
            this.searchGridView.TabStop = false;
            this.searchGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchGridView_CellDoubleClick);
            this.searchGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchGridView_KeyDown);
            // 
            // monsterBindingSource
            // 
            this.monsterBindingSource.DataSource = typeof(MonsterDatabaseLibrary.Monster);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchTextBox.Location = new System.Drawing.Point(728, 100);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(607, 26);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // searchFilter
            // 
            this.searchFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchFilter.FormattingEnabled = true;
            this.searchFilter.Items.AddRange(new object[] {
            "Name",
            "Type",
            "Sub Type",
            "Territory",
            "Challenge Rating",
            "Alignment",
            "Armor Class",
            "Health Points",
            "Experience Points",
            "Size",
            "Page Number",
            "Source Book",
            "Notes"});
            this.searchFilter.Location = new System.Drawing.Point(728, 58);
            this.searchFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchFilter.Name = "searchFilter";
            this.searchFilter.Size = new System.Drawing.Size(253, 28);
            this.searchFilter.TabIndex = 1;
            this.searchFilter.Visible = false;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnShowAll.Location = new System.Drawing.Point(606, 97);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(112, 35);
            this.btnShowAll.TabIndex = 3;
            this.btnShowAll.TabStop = false;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btn_newMonster
            // 
            this.btn_newMonster.Location = new System.Drawing.Point(18, 20);
            this.btn_newMonster.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_newMonster.Name = "btn_newMonster";
            this.btn_newMonster.Size = new System.Drawing.Size(132, 35);
            this.btn_newMonster.TabIndex = 3;
            this.btn_newMonster.TabStop = false;
            this.btn_newMonster.Text = "Add Monster";
            this.btn_newMonster.UseVisualStyleBackColor = true;
            this.btn_newMonster.Click += new System.EventHandler(this.btn_newMonster_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.Location = new System.Drawing.Point(1856, 97);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(112, 35);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.TabStop = false;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // checkBox_Name
            // 
            this.checkBox_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_Name.AutoSize = true;
            this.checkBox_Name.Checked = true;
            this.checkBox_Name.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Name.Location = new System.Drawing.Point(92, 175);
            this.checkBox_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_Name.Name = "checkBox_Name";
            this.checkBox_Name.Size = new System.Drawing.Size(77, 24);
            this.checkBox_Name.TabIndex = 4;
            this.checkBox_Name.Text = "Name";
            this.checkBox_Name.UseVisualStyleBackColor = true;
            // 
            // checkBox_Type
            // 
            this.checkBox_Type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_Type.AutoSize = true;
            this.checkBox_Type.Checked = true;
            this.checkBox_Type.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Type.Location = new System.Drawing.Point(248, 175);
            this.checkBox_Type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_Type.Name = "checkBox_Type";
            this.checkBox_Type.Size = new System.Drawing.Size(69, 24);
            this.checkBox_Type.TabIndex = 5;
            this.checkBox_Type.Text = "Type";
            this.checkBox_Type.UseVisualStyleBackColor = true;
            // 
            // checkBox_SubType
            // 
            this.checkBox_SubType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_SubType.AutoSize = true;
            this.checkBox_SubType.Checked = true;
            this.checkBox_SubType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_SubType.Location = new System.Drawing.Point(394, 175);
            this.checkBox_SubType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_SubType.Name = "checkBox_SubType";
            this.checkBox_SubType.Size = new System.Drawing.Size(102, 24);
            this.checkBox_SubType.TabIndex = 6;
            this.checkBox_SubType.Text = "Sub Type";
            this.checkBox_SubType.UseVisualStyleBackColor = true;
            // 
            // checkBox_Territory
            // 
            this.checkBox_Territory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_Territory.AutoSize = true;
            this.checkBox_Territory.Checked = true;
            this.checkBox_Territory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Territory.Location = new System.Drawing.Point(564, 175);
            this.checkBox_Territory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_Territory.Name = "checkBox_Territory";
            this.checkBox_Territory.Size = new System.Drawing.Size(92, 24);
            this.checkBox_Territory.TabIndex = 7;
            this.checkBox_Territory.Text = "Territory";
            this.checkBox_Territory.UseVisualStyleBackColor = true;
            // 
            // checkBox_ChallengeRating
            // 
            this.checkBox_ChallengeRating.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_ChallengeRating.AutoSize = true;
            this.checkBox_ChallengeRating.Checked = true;
            this.checkBox_ChallengeRating.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ChallengeRating.Location = new System.Drawing.Point(720, 175);
            this.checkBox_ChallengeRating.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_ChallengeRating.Name = "checkBox_ChallengeRating";
            this.checkBox_ChallengeRating.Size = new System.Drawing.Size(93, 24);
            this.checkBox_ChallengeRating.TabIndex = 8;
            this.checkBox_ChallengeRating.Text = "CR (XP)";
            this.checkBox_ChallengeRating.UseVisualStyleBackColor = true;
            // 
            // checkBox_Alignment
            // 
            this.checkBox_Alignment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_Alignment.AutoSize = true;
            this.checkBox_Alignment.Checked = true;
            this.checkBox_Alignment.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Alignment.Location = new System.Drawing.Point(843, 175);
            this.checkBox_Alignment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_Alignment.Name = "checkBox_Alignment";
            this.checkBox_Alignment.Size = new System.Drawing.Size(106, 24);
            this.checkBox_Alignment.TabIndex = 9;
            this.checkBox_Alignment.Text = "Alignment";
            this.checkBox_Alignment.UseVisualStyleBackColor = true;
            // 
            // checkBox_ArmorClass
            // 
            this.checkBox_ArmorClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_ArmorClass.AutoSize = true;
            this.checkBox_ArmorClass.Checked = true;
            this.checkBox_ArmorClass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ArmorClass.Location = new System.Drawing.Point(1018, 175);
            this.checkBox_ArmorClass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_ArmorClass.Name = "checkBox_ArmorClass";
            this.checkBox_ArmorClass.Size = new System.Drawing.Size(57, 24);
            this.checkBox_ArmorClass.TabIndex = 10;
            this.checkBox_ArmorClass.Text = "AC";
            this.checkBox_ArmorClass.UseVisualStyleBackColor = true;
            // 
            // checkBox_HealthPoints
            // 
            this.checkBox_HealthPoints.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_HealthPoints.AutoSize = true;
            this.checkBox_HealthPoints.Checked = true;
            this.checkBox_HealthPoints.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_HealthPoints.Location = new System.Drawing.Point(1167, 175);
            this.checkBox_HealthPoints.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_HealthPoints.Name = "checkBox_HealthPoints";
            this.checkBox_HealthPoints.Size = new System.Drawing.Size(57, 24);
            this.checkBox_HealthPoints.TabIndex = 11;
            this.checkBox_HealthPoints.Text = "HP";
            this.checkBox_HealthPoints.UseVisualStyleBackColor = true;
            // 
            // checkBox_Size
            // 
            this.checkBox_Size.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_Size.AutoSize = true;
            this.checkBox_Size.Checked = true;
            this.checkBox_Size.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Size.Location = new System.Drawing.Point(1317, 175);
            this.checkBox_Size.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_Size.Name = "checkBox_Size";
            this.checkBox_Size.Size = new System.Drawing.Size(66, 24);
            this.checkBox_Size.TabIndex = 13;
            this.checkBox_Size.Text = "Size";
            this.checkBox_Size.UseVisualStyleBackColor = true;
            // 
            // checkBox_PageNumber
            // 
            this.checkBox_PageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_PageNumber.AutoSize = true;
            this.checkBox_PageNumber.Checked = true;
            this.checkBox_PageNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_PageNumber.Location = new System.Drawing.Point(1436, 175);
            this.checkBox_PageNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_PageNumber.Name = "checkBox_PageNumber";
            this.checkBox_PageNumber.Size = new System.Drawing.Size(132, 24);
            this.checkBox_PageNumber.TabIndex = 14;
            this.checkBox_PageNumber.Text = "Page Number";
            this.checkBox_PageNumber.UseVisualStyleBackColor = true;
            // 
            // checkBox_SourceBook
            // 
            this.checkBox_SourceBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_SourceBook.AutoSize = true;
            this.checkBox_SourceBook.Checked = true;
            this.checkBox_SourceBook.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_SourceBook.Location = new System.Drawing.Point(1594, 175);
            this.checkBox_SourceBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_SourceBook.Name = "checkBox_SourceBook";
            this.checkBox_SourceBook.Size = new System.Drawing.Size(127, 24);
            this.checkBox_SourceBook.TabIndex = 15;
            this.checkBox_SourceBook.Text = "Source Book";
            this.checkBox_SourceBook.UseVisualStyleBackColor = true;
            // 
            // checkBox_Notes
            // 
            this.checkBox_Notes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_Notes.AutoSize = true;
            this.checkBox_Notes.Checked = true;
            this.checkBox_Notes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Notes.Location = new System.Drawing.Point(1760, 175);
            this.checkBox_Notes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_Notes.Name = "checkBox_Notes";
            this.checkBox_Notes.Size = new System.Drawing.Size(77, 24);
            this.checkBox_Notes.TabIndex = 16;
            this.checkBox_Notes.Text = "Notes";
            this.checkBox_Notes.UseVisualStyleBackColor = true;
            // 
            // btn_ClearAll
            // 
            this.btn_ClearAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_ClearAll.Location = new System.Drawing.Point(1346, 97);
            this.btn_ClearAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ClearAll.Name = "btn_ClearAll";
            this.btn_ClearAll.Size = new System.Drawing.Size(112, 35);
            this.btn_ClearAll.TabIndex = 17;
            this.btn_ClearAll.TabStop = false;
            this.btn_ClearAll.Text = "Clear";
            this.btn_ClearAll.UseVisualStyleBackColor = true;
            this.btn_ClearAll.Click += new System.EventHandler(this.btn_ClearAll_Click);
            // 
            // btn_CheckAll
            // 
            this.btn_CheckAll.Location = new System.Drawing.Point(18, 97);
            this.btn_CheckAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_CheckAll.Name = "btn_CheckAll";
            this.btn_CheckAll.Size = new System.Drawing.Size(112, 35);
            this.btn_CheckAll.TabIndex = 18;
            this.btn_CheckAll.TabStop = false;
            this.btn_CheckAll.Text = "Check All";
            this.btn_CheckAll.UseVisualStyleBackColor = true;
            this.btn_CheckAll.Click += new System.EventHandler(this.btn_CheckAll_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1856, 18);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 35);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subTypeDataGridViewTextBoxColumn
            // 
            this.subTypeDataGridViewTextBoxColumn.DataPropertyName = "SubType";
            this.subTypeDataGridViewTextBoxColumn.HeaderText = "Sub Type";
            this.subTypeDataGridViewTextBoxColumn.Name = "subTypeDataGridViewTextBoxColumn";
            this.subTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // territoryDataGridViewTextBoxColumn
            // 
            this.territoryDataGridViewTextBoxColumn.DataPropertyName = "Territory";
            this.territoryDataGridViewTextBoxColumn.HeaderText = "Territory";
            this.territoryDataGridViewTextBoxColumn.Name = "territoryDataGridViewTextBoxColumn";
            this.territoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // challengeRatingDataGridViewTextBoxColumn
            // 
            this.challengeRatingDataGridViewTextBoxColumn.DataPropertyName = "ChallengeRating";
            this.challengeRatingDataGridViewTextBoxColumn.HeaderText = "CR (XP)";
            this.challengeRatingDataGridViewTextBoxColumn.Name = "challengeRatingDataGridViewTextBoxColumn";
            this.challengeRatingDataGridViewTextBoxColumn.ReadOnly = true;
            this.challengeRatingDataGridViewTextBoxColumn.ToolTipText = "Challenge Rating (Experience Points)";
            // 
            // alignmentDataGridViewTextBoxColumn
            // 
            this.alignmentDataGridViewTextBoxColumn.DataPropertyName = "Alignment";
            this.alignmentDataGridViewTextBoxColumn.HeaderText = "Alignment";
            this.alignmentDataGridViewTextBoxColumn.Name = "alignmentDataGridViewTextBoxColumn";
            this.alignmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // armorClassDataGridViewTextBoxColumn
            // 
            this.armorClassDataGridViewTextBoxColumn.DataPropertyName = "ArmorClass";
            this.armorClassDataGridViewTextBoxColumn.HeaderText = "AC";
            this.armorClassDataGridViewTextBoxColumn.Name = "armorClassDataGridViewTextBoxColumn";
            this.armorClassDataGridViewTextBoxColumn.ReadOnly = true;
            this.armorClassDataGridViewTextBoxColumn.ToolTipText = "Armor Class";
            // 
            // healthPointsDataGridViewTextBoxColumn
            // 
            this.healthPointsDataGridViewTextBoxColumn.DataPropertyName = "HealthPoints";
            this.healthPointsDataGridViewTextBoxColumn.HeaderText = "HP";
            this.healthPointsDataGridViewTextBoxColumn.Name = "healthPointsDataGridViewTextBoxColumn";
            this.healthPointsDataGridViewTextBoxColumn.ReadOnly = true;
            this.healthPointsDataGridViewTextBoxColumn.ToolTipText = "Health Points";
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pageNumberDataGridViewTextBoxColumn
            // 
            this.pageNumberDataGridViewTextBoxColumn.DataPropertyName = "PageNumber";
            this.pageNumberDataGridViewTextBoxColumn.HeaderText = "Page Number";
            this.pageNumberDataGridViewTextBoxColumn.Name = "pageNumberDataGridViewTextBoxColumn";
            this.pageNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sourceBookDataGridViewTextBoxColumn
            // 
            this.sourceBookDataGridViewTextBoxColumn.DataPropertyName = "SourceBook";
            this.sourceBookDataGridViewTextBoxColumn.HeaderText = "Source";
            this.sourceBookDataGridViewTextBoxColumn.Name = "sourceBookDataGridViewTextBoxColumn";
            this.sourceBookDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1986, 738);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btn_CheckAll);
            this.Controls.Add(this.btn_ClearAll);
            this.Controls.Add(this.checkBox_Notes);
            this.Controls.Add(this.checkBox_SourceBook);
            this.Controls.Add(this.checkBox_PageNumber);
            this.Controls.Add(this.checkBox_Size);
            this.Controls.Add(this.checkBox_HealthPoints);
            this.Controls.Add(this.checkBox_ArmorClass);
            this.Controls.Add(this.checkBox_Alignment);
            this.Controls.Add(this.checkBox_ChallengeRating);
            this.Controls.Add(this.checkBox_Territory);
            this.Controls.Add(this.checkBox_SubType);
            this.Controls.Add(this.checkBox_Type);
            this.Controls.Add(this.checkBox_Name);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_newMonster);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.searchFilter);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1999, 508);
            this.Name = "MainWindow";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monsterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView searchGridView;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ComboBox searchFilter;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btn_newMonster;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.CheckBox checkBox_Name;
        private System.Windows.Forms.CheckBox checkBox_Type;
        private System.Windows.Forms.CheckBox checkBox_SubType;
        private System.Windows.Forms.CheckBox checkBox_Territory;
        private System.Windows.Forms.CheckBox checkBox_ChallengeRating;
        private System.Windows.Forms.CheckBox checkBox_Alignment;
        private System.Windows.Forms.CheckBox checkBox_ArmorClass;
        private System.Windows.Forms.CheckBox checkBox_HealthPoints;
        private System.Windows.Forms.CheckBox checkBox_Size;
        private System.Windows.Forms.CheckBox checkBox_PageNumber;
        private System.Windows.Forms.CheckBox checkBox_SourceBook;
        private System.Windows.Forms.CheckBox checkBox_Notes;
        private System.Windows.Forms.Button btn_ClearAll;
        private System.Windows.Forms.Button btn_CheckAll;
        private System.Windows.Forms.BindingSource monsterBindingSource;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn territoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn challengeRatingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alignmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn armorClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn healthPointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pageNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceBookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
    }
}