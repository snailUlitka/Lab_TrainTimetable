namespace Lab3_40
{
    partial class MainForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            MenuStrip = new MenuStrip();
            TaskMenuItem = new ToolStripMenuItem();
            CreateMenuItem = new ToolStripMenuItem();
            EditMenuItem = new ToolStripMenuItem();
            AddMenuItem = new ToolStripMenuItem();
            AddFirstMenuItem = new ToolStripMenuItem();
            AddLastMenuItem = new ToolStripMenuItem();
            AddCustomMenuItem = new ToolStripMenuItem();
            DeleteMenuItem = new ToolStripMenuItem();
            DeleteFirstMenuItem = new ToolStripMenuItem();
            DeleteLastMenuItem = new ToolStripMenuItem();
            DeleteCustomMenuItem = new ToolStripMenuItem();
            OutputMenuItem = new ToolStripMenuItem();
            NumberOutputMenuItem = new ToolStripMenuItem();
            StationOutputMenuItem = new ToolStripMenuItem();
            AllOutputMenuItem = new ToolStripMenuItem();
            DestroyMenuItem = new ToolStripMenuItem();
            HelpMenuItem = new ToolStripMenuItem();
            ExitMenuItem = new ToolStripMenuItem();
            About_Lbl = new Label();
            TrainsheetGridView = new DataGridView();
            MultiBtn = new Button();
            Info_Lbl = new Label();
            Input_Txt = new TextBox();
            MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrainsheetGridView).BeginInit();
            SuspendLayout();
            // 
            // MenuStrip
            // 
            MenuStrip.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            MenuStrip.Items.AddRange(new ToolStripItem[] { TaskMenuItem, HelpMenuItem, ExitMenuItem });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(684, 26);
            MenuStrip.TabIndex = 0;
            MenuStrip.Text = "MenuStrip";
            // 
            // TaskMenuItem
            // 
            TaskMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CreateMenuItem, EditMenuItem, OutputMenuItem, DestroyMenuItem });
            TaskMenuItem.Name = "TaskMenuItem";
            TaskMenuItem.Size = new Size(73, 22);
            TaskMenuItem.Text = "Задание";
            // 
            // CreateMenuItem
            // 
            CreateMenuItem.Name = "CreateMenuItem";
            CreateMenuItem.Size = new Size(182, 22);
            CreateMenuItem.Text = "Создание";
            CreateMenuItem.Click += CreateMenuItem_Click;
            // 
            // EditMenuItem
            // 
            EditMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddMenuItem, DeleteMenuItem });
            EditMenuItem.Name = "EditMenuItem";
            EditMenuItem.Size = new Size(182, 22);
            EditMenuItem.Text = "Редактирование";
            // 
            // AddMenuItem
            // 
            AddMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddFirstMenuItem, AddLastMenuItem, AddCustomMenuItem });
            AddMenuItem.Name = "AddMenuItem";
            AddMenuItem.Size = new Size(137, 22);
            AddMenuItem.Text = "Добавить";
            // 
            // AddFirstMenuItem
            // 
            AddFirstMenuItem.Name = "AddFirstMenuItem";
            AddFirstMenuItem.Size = new Size(219, 22);
            AddFirstMenuItem.Text = "В начало";
            AddFirstMenuItem.Click += AddFirstMenuItem_Click;
            // 
            // AddLastMenuItem
            // 
            AddLastMenuItem.Name = "AddLastMenuItem";
            AddLastMenuItem.Size = new Size(219, 22);
            AddLastMenuItem.Text = "В конец";
            AddLastMenuItem.Click += AddLastMenuItem_Click;
            // 
            // AddCustomMenuItem
            // 
            AddCustomMenuItem.Name = "AddCustomMenuItem";
            AddCustomMenuItem.Size = new Size(219, 22);
            AddCustomMenuItem.Text = "В произвольную точку";
            AddCustomMenuItem.Click += AddCustomMenuItem_Click;
            // 
            // DeleteMenuItem
            // 
            DeleteMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DeleteFirstMenuItem, DeleteLastMenuItem, DeleteCustomMenuItem });
            DeleteMenuItem.Name = "DeleteMenuItem";
            DeleteMenuItem.Size = new Size(137, 22);
            DeleteMenuItem.Text = "Удалить";
            // 
            // DeleteFirstMenuItem
            // 
            DeleteFirstMenuItem.Name = "DeleteFirstMenuItem";
            DeleteFirstMenuItem.Size = new Size(218, 22);
            DeleteFirstMenuItem.Text = "В начале";
            DeleteFirstMenuItem.Click += DeleteFirstMenuItem_Click;
            // 
            // DeleteLastMenuItem
            // 
            DeleteLastMenuItem.Name = "DeleteLastMenuItem";
            DeleteLastMenuItem.Size = new Size(218, 22);
            DeleteLastMenuItem.Text = "В конце";
            DeleteLastMenuItem.Click += DeleteLastMenuItem_Click;
            // 
            // DeleteCustomMenuItem
            // 
            DeleteCustomMenuItem.Name = "DeleteCustomMenuItem";
            DeleteCustomMenuItem.Size = new Size(218, 22);
            DeleteCustomMenuItem.Text = "В произвольной точке";
            DeleteCustomMenuItem.Click += DeleteCustomMenuItem_Click;
            // 
            // OutputMenuItem
            // 
            OutputMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NumberOutputMenuItem, StationOutputMenuItem, AllOutputMenuItem });
            OutputMenuItem.Name = "OutputMenuItem";
            OutputMenuItem.Size = new Size(182, 22);
            OutputMenuItem.Text = "Вывод данных";
            // 
            // NumberOutputMenuItem
            // 
            NumberOutputMenuItem.Name = "NumberOutputMenuItem";
            NumberOutputMenuItem.Size = new Size(212, 22);
            NumberOutputMenuItem.Text = "По номеру поезда";
            NumberOutputMenuItem.Click += NumberOutputMenuItem_Click;
            // 
            // StationOutputMenuItem
            // 
            StationOutputMenuItem.Name = "StationOutputMenuItem";
            StationOutputMenuItem.Size = new Size(212, 22);
            StationOutputMenuItem.Text = "По названию станции";
            StationOutputMenuItem.Click += StationOutputMenuItem_Click;
            // 
            // AllOutputMenuItem
            // 
            AllOutputMenuItem.Name = "AllOutputMenuItem";
            AllOutputMenuItem.Size = new Size(212, 22);
            AllOutputMenuItem.Text = "Обо всех";
            AllOutputMenuItem.Click += AllOutputMenuItem_Click;
            // 
            // DestroyMenuItem
            // 
            DestroyMenuItem.Name = "DestroyMenuItem";
            DestroyMenuItem.Size = new Size(182, 22);
            DestroyMenuItem.Text = "Разрушение";
            DestroyMenuItem.Click += DestroyMenuItem_Click;
            // 
            // HelpMenuItem
            // 
            HelpMenuItem.Name = "HelpMenuItem";
            HelpMenuItem.Size = new Size(105, 22);
            HelpMenuItem.Text = "О программе";
            HelpMenuItem.Click += HelpMenuItem_Click;
            // 
            // ExitMenuItem
            // 
            ExitMenuItem.Name = "ExitMenuItem";
            ExitMenuItem.Size = new Size(61, 22);
            ExitMenuItem.Text = "Выход";
            ExitMenuItem.Click += ExitMenuItem_Click;
            // 
            // About_Lbl
            // 
            About_Lbl.Location = new Point(31, 40);
            About_Lbl.Name = "About_Lbl";
            About_Lbl.Size = new Size(1, 1);
            About_Lbl.TabIndex = 1;
            About_Lbl.Visible = false;
            // 
            // TrainsheetGridView
            // 
            TrainsheetGridView.AllowUserToResizeColumns = false;
            TrainsheetGridView.AllowUserToResizeRows = false;
            TrainsheetGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            TrainsheetGridView.BackgroundColor = SystemColors.Control;
            TrainsheetGridView.BorderStyle = BorderStyle.None;
            TrainsheetGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            TrainsheetGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            TrainsheetGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TrainsheetGridView.EditMode = DataGridViewEditMode.EditOnEnter;
            TrainsheetGridView.GridColor = SystemColors.ActiveCaptionText;
            TrainsheetGridView.Location = new Point(20, 40);
            TrainsheetGridView.MultiSelect = false;
            TrainsheetGridView.Name = "TrainsheetGridView";
            TrainsheetGridView.RowHeadersVisible = false;
            TrainsheetGridView.RowTemplate.Height = 25;
            TrainsheetGridView.RowTemplate.Resizable = DataGridViewTriState.False;
            TrainsheetGridView.ScrollBars = ScrollBars.Vertical;
            TrainsheetGridView.Size = new Size(500, 500);
            TrainsheetGridView.TabIndex = 2;
            TrainsheetGridView.Visible = false;
            TrainsheetGridView.CellValueChanged += TrainsheetGridView_CellValueChanged;
            // 
            // MultiBtn
            // 
            MultiBtn.FlatStyle = FlatStyle.Popup;
            MultiBtn.Location = new Point(562, 490);
            MultiBtn.Name = "MultiBtn";
            MultiBtn.Size = new Size(100, 50);
            MultiBtn.TabIndex = 3;
            MultiBtn.UseVisualStyleBackColor = true;
            MultiBtn.Visible = false;
            // 
            // Info_Lbl
            // 
            Info_Lbl.FlatStyle = FlatStyle.Popup;
            Info_Lbl.Location = new Point(526, 40);
            Info_Lbl.Name = "Info_Lbl";
            Info_Lbl.Size = new Size(158, 36);
            Info_Lbl.TabIndex = 4;
            Info_Lbl.TextAlign = ContentAlignment.MiddleLeft;
            Info_Lbl.Visible = false;
            // 
            // Input_Txt
            // 
            Input_Txt.BorderStyle = BorderStyle.FixedSingle;
            Input_Txt.Location = new Point(526, 81);
            Input_Txt.Name = "Input_Txt";
            Input_Txt.Size = new Size(158, 27);
            Input_Txt.TabIndex = 5;
            Input_Txt.Visible = false;
            Input_Txt.TextChanged += Input_Number_TextChanged;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(684, 561);
            Controls.Add(Input_Txt);
            Controls.Add(Info_Lbl);
            Controls.Add(MultiBtn);
            Controls.Add(TrainsheetGridView);
            Controls.Add(About_Lbl);
            Controls.Add(MenuStrip);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = MenuStrip;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab3";
            FormClosing += MainForm_FormClosing;
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TrainsheetGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuStrip;
        private ToolStripMenuItem TaskMenuItem;
        private ToolStripMenuItem HelpMenuItem;
        private ToolStripMenuItem ExitMenuItem;
        private Label About_Lbl;
        private ToolStripMenuItem CreateMenuItem;
        private ToolStripMenuItem EditMenuItem;
        private ToolStripMenuItem AddMenuItem;
        private ToolStripMenuItem AddFirstMenuItem;
        private ToolStripMenuItem AddLastMenuItem;
        private ToolStripMenuItem AddCustomMenuItem;
        private ToolStripMenuItem DeleteMenuItem;
        private ToolStripMenuItem DeleteFirstMenuItem;
        private ToolStripMenuItem DeleteLastMenuItem;
        private ToolStripMenuItem DeleteCustomMenuItem;
        private ToolStripMenuItem OutputMenuItem;
        private ToolStripMenuItem NumberOutputMenuItem;
        private ToolStripMenuItem StationOutputMenuItem;
        private ToolStripMenuItem AllOutputMenuItem;
        private ToolStripMenuItem DestroyMenuItem;
        private DataGridView TrainsheetGridView;
        private Button MultiBtn;
        private Label Info_Lbl;
        private TextBox Input_Txt;
    }
}