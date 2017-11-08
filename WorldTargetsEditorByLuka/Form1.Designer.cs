namespace WorldTargetsEditorByLuka
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenSev = new System.Windows.Forms.ToolStripMenuItem();
            this.Opentxt = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveSev = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveTxt = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSecondToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeNamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OpenSev1 = new System.Windows.Forms.ToolStripButton();
            this.Opentxt1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveSev1 = new System.Windows.Forms.ToolStripButton();
            this.SaveTxt1 = new System.Windows.Forms.ToolStripButton();
            this.TeleportsGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DialogOpenSev = new System.Windows.Forms.OpenFileDialog();
            this.DialogOpenClt = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Group_textbox = new System.Windows.Forms.TextBox();
            this.MapId_textbox = new System.Windows.Forms.TextBox();
            this.ID_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Version_Combobox = new System.Windows.Forms.ComboBox();
            this.InsertCoordinatesFromGame = new System.Windows.Forms.Button();
            this.Z_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Y_textbox = new System.Windows.Forms.TextBox();
            this.X_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Name_textbox = new System.Windows.Forms.TextBox();
            this.WorldMap = new Cyotek.Windows.Forms.ImageBox();
            this.LoadMap = new System.Windows.Forms.Button();
            this.DialogSaveSev = new System.Windows.Forms.SaveFileDialog();
            this.DialogSavetxt = new System.Windows.Forms.SaveFileDialog();
            this.English = new System.Windows.Forms.RadioButton();
            this.Russian = new System.Windows.Forms.RadioButton();
            this.Delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeleportsGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.loadSecondToolStripMenuItem,
            this.changeNamesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(678, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenSev,
            this.Opentxt,
            this.toolStripSeparator1,
            this.SaveSev,
            this.SaveTxt,
            this.toolStripSeparator2,
            this.ExitApplication});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // OpenSev
            // 
            this.OpenSev.Image = global::WorldTargetsEditorByLuka.Properties.Resources.Open_sev;
            this.OpenSev.Name = "OpenSev";
            this.OpenSev.Size = new System.Drawing.Size(232, 24);
            this.OpenSev.Text = "Открыть World_Targets.sev";
            this.OpenSev.Click += new System.EventHandler(this.OpenSev1_Click);
            // 
            // Opentxt
            // 
            this.Opentxt.Image = global::WorldTargetsEditorByLuka.Properties.Resources.Open_clt;
            this.Opentxt.Name = "Opentxt";
            this.Opentxt.Size = new System.Drawing.Size(232, 24);
            this.Opentxt.Text = "Открыть World_Targets.txt";
            this.Opentxt.Click += new System.EventHandler(this.OpenTxt1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(229, 6);
            // 
            // SaveSev
            // 
            this.SaveSev.Image = global::WorldTargetsEditorByLuka.Properties.Resources.Save_sev;
            this.SaveSev.Name = "SaveSev";
            this.SaveSev.Size = new System.Drawing.Size(232, 24);
            this.SaveSev.Text = "Сохранить World_Targets.sev";
            this.SaveSev.Click += new System.EventHandler(this.SaveSev_Click);
            // 
            // SaveTxt
            // 
            this.SaveTxt.Image = global::WorldTargetsEditorByLuka.Properties.Resources.Save_clt;
            this.SaveTxt.Name = "SaveTxt";
            this.SaveTxt.Size = new System.Drawing.Size(232, 24);
            this.SaveTxt.Text = "Сохранить World_Targets.txt";
            this.SaveTxt.Click += new System.EventHandler(this.SaveTxt1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(229, 6);
            // 
            // ExitApplication
            // 
            this.ExitApplication.Image = global::WorldTargetsEditorByLuka.Properties.Resources.exit;
            this.ExitApplication.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ExitApplication.Name = "ExitApplication";
            this.ExitApplication.Size = new System.Drawing.Size(232, 24);
            this.ExitApplication.Text = "Выйти";
            this.ExitApplication.Click += new System.EventHandler(this.ExitApplication_Click);
            // 
            // loadSecondToolStripMenuItem
            // 
            this.loadSecondToolStripMenuItem.Name = "loadSecondToolStripMenuItem";
            this.loadSecondToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.loadSecondToolStripMenuItem.Text = "LoadSecond";
            this.loadSecondToolStripMenuItem.Click += new System.EventHandler(this.loadSecondToolStripMenuItem_Click);
            // 
            // changeNamesToolStripMenuItem
            // 
            this.changeNamesToolStripMenuItem.Name = "changeNamesToolStripMenuItem";
            this.changeNamesToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.changeNamesToolStripMenuItem.Text = "ChangeNames";
            this.changeNamesToolStripMenuItem.Click += new System.EventHandler(this.changeNamesToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenSev1,
            this.Opentxt1,
            this.toolStripSeparator3,
            this.SaveSev1,
            this.SaveTxt1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(678, 25);
            this.toolStrip1.TabIndex = 1;
            // 
            // OpenSev1
            // 
            this.OpenSev1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenSev1.Image = global::WorldTargetsEditorByLuka.Properties.Resources.Open_sev;
            this.OpenSev1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenSev1.Name = "OpenSev1";
            this.OpenSev1.Size = new System.Drawing.Size(23, 22);
            this.OpenSev1.Text = "toolStripButton1";
            this.OpenSev1.ToolTipText = "Open World_targets.sev";
            this.OpenSev1.Click += new System.EventHandler(this.OpenSev1_Click);
            // 
            // Opentxt1
            // 
            this.Opentxt1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Opentxt1.Image = global::WorldTargetsEditorByLuka.Properties.Resources.Open_clt;
            this.Opentxt1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Opentxt1.Name = "Opentxt1";
            this.Opentxt1.Size = new System.Drawing.Size(23, 22);
            this.Opentxt1.Text = "toolStripButton2";
            this.Opentxt1.ToolTipText = "Open World_targets.txt";
            this.Opentxt1.Click += new System.EventHandler(this.OpenTxt1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // SaveSev1
            // 
            this.SaveSev1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveSev1.Image = global::WorldTargetsEditorByLuka.Properties.Resources.Save_sev;
            this.SaveSev1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveSev1.Name = "SaveSev1";
            this.SaveSev1.Size = new System.Drawing.Size(23, 22);
            this.SaveSev1.Text = "toolStripButton3";
            this.SaveSev1.ToolTipText = "Save World_targets.sev";
            this.SaveSev1.Click += new System.EventHandler(this.SaveSev_Click);
            // 
            // SaveTxt1
            // 
            this.SaveTxt1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveTxt1.Image = global::WorldTargetsEditorByLuka.Properties.Resources.Save_clt;
            this.SaveTxt1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveTxt1.Name = "SaveTxt1";
            this.SaveTxt1.Size = new System.Drawing.Size(23, 22);
            this.SaveTxt1.Text = "toolStripButton4";
            this.SaveTxt1.ToolTipText = "Save World_targets.txt";
            this.SaveTxt1.Click += new System.EventHandler(this.SaveTxt1_Click);
            // 
            // TeleportsGrid
            // 
            this.TeleportsGrid.AllowUserToAddRows = false;
            this.TeleportsGrid.AllowUserToDeleteRows = false;
            this.TeleportsGrid.AllowUserToResizeColumns = false;
            this.TeleportsGrid.AllowUserToResizeRows = false;
            this.TeleportsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TeleportsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TeleportsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TeleportsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TeleportsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TeleportsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeleportsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column4});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TeleportsGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.TeleportsGrid.EnableHeadersVisualStyles = false;
            this.TeleportsGrid.Location = new System.Drawing.Point(0, 52);
            this.TeleportsGrid.Name = "TeleportsGrid";
            this.TeleportsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.TeleportsGrid.RowHeadersVisible = false;
            this.TeleportsGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TeleportsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TeleportsGrid.ShowCellErrors = false;
            this.TeleportsGrid.ShowCellToolTips = false;
            this.TeleportsGrid.ShowEditingIcon = false;
            this.TeleportsGrid.ShowRowErrors = false;
            this.TeleportsGrid.Size = new System.Drawing.Size(322, 425);
            this.TeleportsGrid.TabIndex = 16;
            this.TeleportsGrid.CurrentCellChanged += new System.EventHandler(this.TeleportsGrid_CurrentCellChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.FillWeight = 6.912442F;
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 36;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(143)))));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.FillWeight = 44.7233F;
            this.dataGridViewTextBoxColumn2.HeaderText = "  ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 84;
            // 
            // Column4
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.HeaderText = "Name";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 200;
            // 
            // DialogOpenSev
            // 
            this.DialogOpenSev.DefaultExt = "World_targets|*.sev";
            this.DialogOpenSev.FileName = "World_targets.sev";
            // 
            // DialogOpenClt
            // 
            this.DialogOpenClt.FileName = "World_targets.txt";
            this.DialogOpenClt.Filter = "World_targets|*.txt";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Group_textbox);
            this.groupBox1.Controls.Add(this.MapId_textbox);
            this.groupBox1.Controls.Add(this.ID_textbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(329, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 91);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Основное";
            // 
            // Group_textbox
            // 
            this.Group_textbox.Location = new System.Drawing.Point(69, 63);
            this.Group_textbox.Name = "Group_textbox";
            this.Group_textbox.Size = new System.Drawing.Size(69, 20);
            this.Group_textbox.TabIndex = 5;
            this.Group_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_textbox_KeyDown);
            this.Group_textbox.Leave += new System.EventHandler(this.ID_textbox_Leave);
            // 
            // MapId_textbox
            // 
            this.MapId_textbox.Location = new System.Drawing.Point(69, 42);
            this.MapId_textbox.Name = "MapId_textbox";
            this.MapId_textbox.Size = new System.Drawing.Size(69, 20);
            this.MapId_textbox.TabIndex = 4;
            this.MapId_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_textbox_KeyDown);
            this.MapId_textbox.Leave += new System.EventHandler(this.ID_textbox_Leave);
            // 
            // ID_textbox
            // 
            this.ID_textbox.Location = new System.Drawing.Point(69, 21);
            this.ID_textbox.Name = "ID_textbox";
            this.ID_textbox.Size = new System.Drawing.Size(69, 20);
            this.ID_textbox.TabIndex = 3;
            this.ID_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_textbox_KeyDown);
            this.ID_textbox.Leave += new System.EventHandler(this.ID_textbox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Группа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID карты:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Version_Combobox);
            this.groupBox2.Controls.Add(this.InsertCoordinatesFromGame);
            this.groupBox2.Controls.Add(this.Z_textbox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Y_textbox);
            this.groupBox2.Controls.Add(this.X_textbox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(484, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 91);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Координаты";
            // 
            // Version_Combobox
            // 
            this.Version_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Version_Combobox.FormattingEnabled = true;
            this.Version_Combobox.Items.AddRange(new object[] {
            "1.3.6",
            "1.4.4 v60",
            "1.4.6 v70",
            "1.4.8 v85",
            "1.5.0 v88",
            "1.5.1",
            "1.5.1(2)",
            "1.5.3 v145"});
            this.Version_Combobox.Location = new System.Drawing.Point(104, 24);
            this.Version_Combobox.Name = "Version_Combobox";
            this.Version_Combobox.Size = new System.Drawing.Size(87, 21);
            this.Version_Combobox.TabIndex = 10;
            // 
            // InsertCoordinatesFromGame
            // 
            this.InsertCoordinatesFromGame.Location = new System.Drawing.Point(104, 45);
            this.InsertCoordinatesFromGame.Name = "InsertCoordinatesFromGame";
            this.InsertCoordinatesFromGame.Size = new System.Drawing.Size(87, 44);
            this.InsertCoordinatesFromGame.TabIndex = 9;
            this.InsertCoordinatesFromGame.Text = "Вставить корды с игры";
            this.InsertCoordinatesFromGame.UseVisualStyleBackColor = true;
            this.InsertCoordinatesFromGame.Click += new System.EventHandler(this.InsertCoordinatesFromGame_Click);
            // 
            // Z_textbox
            // 
            this.Z_textbox.Location = new System.Drawing.Point(29, 63);
            this.Z_textbox.Name = "Z_textbox";
            this.Z_textbox.Size = new System.Drawing.Size(69, 20);
            this.Z_textbox.TabIndex = 8;
            this.Z_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_textbox_KeyDown);
            this.Z_textbox.Leave += new System.EventHandler(this.ID_textbox_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Y:";
            // 
            // Y_textbox
            // 
            this.Y_textbox.Location = new System.Drawing.Point(29, 42);
            this.Y_textbox.Name = "Y_textbox";
            this.Y_textbox.Size = new System.Drawing.Size(69, 20);
            this.Y_textbox.TabIndex = 7;
            this.Y_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_textbox_KeyDown);
            this.Y_textbox.Leave += new System.EventHandler(this.ID_textbox_Leave);
            // 
            // X_textbox
            // 
            this.X_textbox.Location = new System.Drawing.Point(29, 21);
            this.X_textbox.Name = "X_textbox";
            this.X_textbox.Size = new System.Drawing.Size(69, 20);
            this.X_textbox.TabIndex = 6;
            this.X_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_textbox_KeyDown);
            this.X_textbox.Leave += new System.EventHandler(this.ID_textbox_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Z:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "X:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Версия клиента";
            // 
            // Name_textbox
            // 
            this.Name_textbox.Location = new System.Drawing.Point(329, 52);
            this.Name_textbox.Name = "Name_textbox";
            this.Name_textbox.Size = new System.Drawing.Size(346, 20);
            this.Name_textbox.TabIndex = 20;
            this.Name_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Name_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_textbox_KeyDown);
            this.Name_textbox.Leave += new System.EventHandler(this.ID_textbox_Leave);
            // 
            // WorldMap
            // 
            this.WorldMap.Location = new System.Drawing.Point(329, 175);
            this.WorldMap.Name = "WorldMap";
            this.WorldMap.Size = new System.Drawing.Size(346, 302);
            this.WorldMap.TabIndex = 21;
            this.WorldMap.TabStop = false;
            // 
            // LoadMap
            // 
            this.LoadMap.Location = new System.Drawing.Point(329, 478);
            this.LoadMap.Name = "LoadMap";
            this.LoadMap.Size = new System.Drawing.Size(346, 33);
            this.LoadMap.TabIndex = 22;
            this.LoadMap.Text = "Загрузить изображение(World)";
            this.LoadMap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LoadMap.UseVisualStyleBackColor = true;
            this.LoadMap.Click += new System.EventHandler(this.LoadMap_Click);
            // 
            // DialogSaveSev
            // 
            this.DialogSaveSev.FileName = "world_targets.sev";
            this.DialogSaveSev.Filter = "world_targets|*.sev";
            // 
            // DialogSavetxt
            // 
            this.DialogSavetxt.FileName = "world_targets.txt";
            this.DialogSavetxt.Filter = "world_targets|*.txt";
            // 
            // English
            // 
            this.English.BackColor = System.Drawing.SystemColors.Control;
            this.English.ForeColor = System.Drawing.Color.Black;
            this.English.Image = global::WorldTargetsEditorByLuka.Properties.Resources.English;
            this.English.Location = new System.Drawing.Point(593, 23);
            this.English.Name = "English";
            this.English.Size = new System.Drawing.Size(79, 24);
            this.English.TabIndex = 62;
            this.English.Text = "English";
            this.English.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.English.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.English.UseVisualStyleBackColor = false;
            this.English.CheckedChanged += new System.EventHandler(this.LanguageChange);
            // 
            // Russian
            // 
            this.Russian.BackColor = System.Drawing.SystemColors.Control;
            this.Russian.Checked = true;
            this.Russian.ForeColor = System.Drawing.Color.Black;
            this.Russian.Image = global::WorldTargetsEditorByLuka.Properties.Resources.Russian;
            this.Russian.Location = new System.Drawing.Point(593, 0);
            this.Russian.Name = "Russian";
            this.Russian.Size = new System.Drawing.Size(85, 24);
            this.Russian.TabIndex = 61;
            this.Russian.TabStop = true;
            this.Russian.Text = "Russian";
            this.Russian.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Russian.UseVisualStyleBackColor = false;
            this.Russian.CheckedChanged += new System.EventHandler(this.LanguageChange);
            // 
            // Delete
            // 
            this.Delete.Image = global::WorldTargetsEditorByLuka.Properties.Resources.Delete;
            this.Delete.Location = new System.Drawing.Point(162, 478);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(161, 33);
            this.Delete.TabIndex = 18;
            this.Delete.Text = "Удалить";
            this.Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Add
            // 
            this.Add.Image = global::WorldTargetsEditorByLuka.Properties.Resources.AddTeleport;
            this.Add.Location = new System.Drawing.Point(0, 478);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(160, 33);
            this.Add.TabIndex = 17;
            this.Add.Text = "Добавить";
            this.Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 511);
            this.Controls.Add(this.English);
            this.Controls.Add(this.Russian);
            this.Controls.Add(this.LoadMap);
            this.Controls.Add(this.WorldMap);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.TeleportsGrid);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Name_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "World Targets Editor By Luka";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeleportsGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenSev;
        private System.Windows.Forms.ToolStripMenuItem Opentxt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SaveSev;
        private System.Windows.Forms.ToolStripMenuItem SaveTxt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ExitApplication;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton OpenSev1;
        private System.Windows.Forms.ToolStripButton Opentxt1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton SaveSev1;
        private System.Windows.Forms.ToolStripButton SaveTxt1;
        private System.Windows.Forms.DataGridView TeleportsGrid;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.OpenFileDialog DialogOpenSev;
        private System.Windows.Forms.OpenFileDialog DialogOpenClt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Group_textbox;
        private System.Windows.Forms.TextBox MapId_textbox;
        private System.Windows.Forms.TextBox ID_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Z_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Y_textbox;
        private System.Windows.Forms.TextBox X_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Name_textbox;
        private Cyotek.Windows.Forms.ImageBox WorldMap;
        private System.Windows.Forms.Button LoadMap;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.SaveFileDialog DialogSaveSev;
        private System.Windows.Forms.SaveFileDialog DialogSavetxt;
        private System.Windows.Forms.ComboBox Version_Combobox;
        private System.Windows.Forms.Button InsertCoordinatesFromGame;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton English;
        private System.Windows.Forms.RadioButton Russian;
        private System.Windows.Forms.ToolStripMenuItem loadSecondToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeNamesToolStripMenuItem;
    }
}

