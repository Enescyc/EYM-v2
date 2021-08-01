
namespace EYM.Forms
{
    partial class EmployeePage
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.TelephoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.CheckStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.UpdateEmployeeBtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.deleteEmployeBtn = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.newEmployeBtn = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.Birthday = new DevExpress.XtraEditors.DateEdit();
            this.BloodClass = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Gender = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Adress = new DevExpress.XtraEditors.MemoEdit();
            this.IdentificationNumber = new DevExpress.XtraEditors.TextEdit();
            this.Surname = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.StatusName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TelephoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Birthday.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Birthday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BloodClass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Adress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdentificationNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Surname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panelControl1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1277, 715);
            this.panel1.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(516, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(761, 715);
            this.panelControl1.TabIndex = 12;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Text = "KAYITLI ÖĞRENCİ LİSTESİ";
            this.gridControl1.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Begin;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(757, 711);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick_1);
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick_1);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.groupControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(516, 715);
            this.panel2.TabIndex = 11;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl1.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.groupControl1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.Appearance.Options.UseForeColor = true;
            this.groupControl1.Appearance.Options.UseImage = true;
            this.groupControl1.Appearance.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.BackColor = System.Drawing.Color.Transparent;
            this.groupControl1.AppearanceCaption.BackColor2 = System.Drawing.Color.Transparent;
            this.groupControl1.AppearanceCaption.BorderColor = System.Drawing.Color.Transparent;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl1.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.White;
            this.groupControl1.AppearanceCaption.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.AppearanceCaption.Options.UseImage = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AutoSize = true;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.tablePanel1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(10, 10);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(496, 695);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "PERSONEL BİLGİLERİ";
            // 
            // tablePanel1
            // 
            this.tablePanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tablePanel1.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.tablePanel1.Appearance.Options.UseBackColor = true;
            this.tablePanel1.AutoScroll = true;
            this.tablePanel1.AutoSize = true;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 167.2F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 64F)});
            this.tablePanel1.Controls.Add(this.TelephoneNumber);
            this.tablePanel1.Controls.Add(this.CheckStatus);
            this.tablePanel1.Controls.Add(this.UpdateEmployeeBtn);
            this.tablePanel1.Controls.Add(this.labelControl11);
            this.tablePanel1.Controls.Add(this.deleteEmployeBtn);
            this.tablePanel1.Controls.Add(this.simpleButton5);
            this.tablePanel1.Controls.Add(this.newEmployeBtn);
            this.tablePanel1.Controls.Add(this.simpleButton4);
            this.tablePanel1.Controls.Add(this.Birthday);
            this.tablePanel1.Controls.Add(this.BloodClass);
            this.tablePanel1.Controls.Add(this.labelControl10);
            this.tablePanel1.Controls.Add(this.txtStatus);
            this.tablePanel1.Controls.Add(this.Gender);
            this.tablePanel1.Controls.Add(this.Adress);
            this.tablePanel1.Controls.Add(this.IdentificationNumber);
            this.tablePanel1.Controls.Add(this.Surname);
            this.tablePanel1.Controls.Add(this.txtName);
            this.tablePanel1.Controls.Add(this.labelControl8);
            this.tablePanel1.Controls.Add(this.labelControl9);
            this.tablePanel1.Controls.Add(this.labelControl7);
            this.tablePanel1.Controls.Add(this.labelControl6);
            this.tablePanel1.Controls.Add(this.labelControl5);
            this.tablePanel1.Controls.Add(this.labelControl4);
            this.tablePanel1.Controls.Add(this.labelControl3);
            this.tablePanel1.Controls.Add(this.labelControl2);
            this.tablePanel1.Controls.Add(this.labelControl1);
            this.tablePanel1.Controls.Add(this.StatusName);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePanel1.Location = new System.Drawing.Point(2, 37);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(10);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 32F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 64F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 45F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 45F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 45F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F)});
            this.tablePanel1.Size = new System.Drawing.Size(492, 629);
            this.tablePanel1.TabIndex = 6;
            // 
            // TelephoneNumber
            // 
            this.tablePanel1.SetColumn(this.TelephoneNumber, 1);
            this.TelephoneNumber.Location = new System.Drawing.Point(180, 163);
            this.TelephoneNumber.Name = "TelephoneNumber";
            this.TelephoneNumber.Properties.Mask.EditMask = "(999) 000-0000";
            this.TelephoneNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.tablePanel1.SetRow(this.TelephoneNumber, 5);
            this.TelephoneNumber.Size = new System.Drawing.Size(299, 24);
            this.TelephoneNumber.TabIndex = 16;
            // 
            // CheckStatus
            // 
            this.tablePanel1.SetColumn(this.CheckStatus, 1);
            this.CheckStatus.EditValue = "Görev Seçiniz";
            this.CheckStatus.Location = new System.Drawing.Point(180, 542);
            this.CheckStatus.Name = "CheckStatus";
            this.CheckStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CheckStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.tablePanel1.SetRow(this.CheckStatus, 15);
            this.CheckStatus.Size = new System.Drawing.Size(299, 24);
            this.CheckStatus.TabIndex = 5;
            // 
            // UpdateEmployeeBtn
            // 
            this.UpdateEmployeeBtn.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.UpdateEmployeeBtn.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.UpdateEmployeeBtn.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.UpdateEmployeeBtn.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UpdateEmployeeBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.UpdateEmployeeBtn.Appearance.Options.UseBackColor = true;
            this.UpdateEmployeeBtn.Appearance.Options.UseBorderColor = true;
            this.UpdateEmployeeBtn.Appearance.Options.UseFont = true;
            this.UpdateEmployeeBtn.Appearance.Options.UseForeColor = true;
            this.UpdateEmployeeBtn.AppearanceHovered.BackColor = System.Drawing.Color.SteelBlue;
            this.UpdateEmployeeBtn.AppearanceHovered.BackColor2 = System.Drawing.Color.WhiteSmoke;
            this.UpdateEmployeeBtn.AppearanceHovered.BorderColor = System.Drawing.Color.Black;
            this.UpdateEmployeeBtn.AppearanceHovered.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UpdateEmployeeBtn.AppearanceHovered.Options.UseBackColor = true;
            this.UpdateEmployeeBtn.AppearanceHovered.Options.UseBorderColor = true;
            this.UpdateEmployeeBtn.AppearanceHovered.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.UpdateEmployeeBtn, 1);
            this.UpdateEmployeeBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("UpdateEmployeeBtn.ImageOptions.Image")));
            this.UpdateEmployeeBtn.Location = new System.Drawing.Point(180, 407);
            this.UpdateEmployeeBtn.Name = "UpdateEmployeeBtn";
            this.tablePanel1.SetRow(this.UpdateEmployeeBtn, 11);
            this.UpdateEmployeeBtn.Size = new System.Drawing.Size(299, 39);
            this.UpdateEmployeeBtn.TabIndex = 15;
            this.UpdateEmployeeBtn.Text = "GÜNCELLE";
            this.UpdateEmployeeBtn.Click += new System.EventHandler(this.UpdateEmployeeBtn_Click);
            // 
            // labelControl11
            // 
            this.tablePanel1.SetColumn(this.labelControl11, 0);
            this.labelControl11.Location = new System.Drawing.Point(13, 545);
            this.labelControl11.Name = "labelControl11";
            this.tablePanel1.SetRow(this.labelControl11, 15);
            this.labelControl11.Size = new System.Drawing.Size(82, 18);
            this.labelControl11.TabIndex = 4;
            this.labelControl11.Text = "GÖREV ADI:";
            // 
            // deleteEmployeBtn
            // 
            this.deleteEmployeBtn.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.deleteEmployeBtn.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.deleteEmployeBtn.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.deleteEmployeBtn.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteEmployeBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.deleteEmployeBtn.Appearance.Options.UseBackColor = true;
            this.deleteEmployeBtn.Appearance.Options.UseBorderColor = true;
            this.deleteEmployeBtn.Appearance.Options.UseFont = true;
            this.deleteEmployeBtn.Appearance.Options.UseForeColor = true;
            this.deleteEmployeBtn.AppearanceHovered.BackColor = System.Drawing.Color.SteelBlue;
            this.deleteEmployeBtn.AppearanceHovered.BackColor2 = System.Drawing.Color.WhiteSmoke;
            this.deleteEmployeBtn.AppearanceHovered.BorderColor = System.Drawing.Color.Black;
            this.deleteEmployeBtn.AppearanceHovered.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteEmployeBtn.AppearanceHovered.Options.UseBackColor = true;
            this.deleteEmployeBtn.AppearanceHovered.Options.UseBorderColor = true;
            this.deleteEmployeBtn.AppearanceHovered.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.deleteEmployeBtn, 1);
            this.deleteEmployeBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteEmployeBtn.ImageOptions.Image")));
            this.deleteEmployeBtn.Location = new System.Drawing.Point(180, 362);
            this.deleteEmployeBtn.Name = "deleteEmployeBtn";
            this.tablePanel1.SetRow(this.deleteEmployeBtn, 10);
            this.deleteEmployeBtn.Size = new System.Drawing.Size(299, 39);
            this.deleteEmployeBtn.TabIndex = 15;
            this.deleteEmployeBtn.Text = "SİL";
            this.deleteEmployeBtn.Click += new System.EventHandler(this.deleteEmployeBtn_Click);
            // 
            // simpleButton5
            // 
            this.tablePanel1.SetColumn(this.simpleButton5, 1);
            this.simpleButton5.Location = new System.Drawing.Point(180, 581);
            this.simpleButton5.Name = "simpleButton5";
            this.tablePanel1.SetRow(this.simpleButton5, 16);
            this.simpleButton5.Size = new System.Drawing.Size(299, 26);
            this.simpleButton5.TabIndex = 3;
            this.simpleButton5.Text = "GÖREV SİL";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // newEmployeBtn
            // 
            this.newEmployeBtn.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.newEmployeBtn.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.newEmployeBtn.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.newEmployeBtn.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newEmployeBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.newEmployeBtn.Appearance.Options.UseBackColor = true;
            this.newEmployeBtn.Appearance.Options.UseBorderColor = true;
            this.newEmployeBtn.Appearance.Options.UseFont = true;
            this.newEmployeBtn.Appearance.Options.UseForeColor = true;
            this.newEmployeBtn.AppearanceHovered.BackColor = System.Drawing.Color.SteelBlue;
            this.newEmployeBtn.AppearanceHovered.BackColor2 = System.Drawing.Color.WhiteSmoke;
            this.newEmployeBtn.AppearanceHovered.BorderColor = System.Drawing.Color.Black;
            this.newEmployeBtn.AppearanceHovered.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newEmployeBtn.AppearanceHovered.Options.UseBackColor = true;
            this.newEmployeBtn.AppearanceHovered.Options.UseBorderColor = true;
            this.newEmployeBtn.AppearanceHovered.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.newEmployeBtn, 1);
            this.newEmployeBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("newEmployeBtn.ImageOptions.Image")));
            this.newEmployeBtn.Location = new System.Drawing.Point(180, 317);
            this.newEmployeBtn.Name = "newEmployeBtn";
            this.tablePanel1.SetRow(this.newEmployeBtn, 9);
            this.newEmployeBtn.Size = new System.Drawing.Size(299, 39);
            this.newEmployeBtn.TabIndex = 15;
            this.newEmployeBtn.Text = "KAYDET";
            this.newEmployeBtn.Click += new System.EventHandler(this.newEmployeBtn_Click);
            // 
            // simpleButton4
            // 
            this.tablePanel1.SetColumn(this.simpleButton4, 1);
            this.simpleButton4.Location = new System.Drawing.Point(180, 512);
            this.simpleButton4.Name = "simpleButton4";
            this.tablePanel1.SetRow(this.simpleButton4, 14);
            this.simpleButton4.Size = new System.Drawing.Size(299, 24);
            this.simpleButton4.TabIndex = 2;
            this.simpleButton4.Text = "GÖREV EKLE";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // Birthday
            // 
            this.tablePanel1.SetColumn(this.Birthday, 1);
            this.Birthday.EditValue = new System.DateTime(2021, 7, 27, 0, 0, 0, 0);
            this.Birthday.Location = new System.Drawing.Point(182, 76);
            this.Birthday.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Birthday.Name = "Birthday";
            this.Birthday.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Birthday.Properties.Appearance.Options.UseFont = true;
            this.Birthday.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Birthday.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tablePanel1.SetRow(this.Birthday, 2);
            this.Birthday.Size = new System.Drawing.Size(295, 24);
            this.Birthday.TabIndex = 14;
            // 
            // BloodClass
            // 
            this.tablePanel1.SetColumn(this.BloodClass, 1);
            this.BloodClass.Location = new System.Drawing.Point(182, 136);
            this.BloodClass.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BloodClass.Name = "BloodClass";
            this.BloodClass.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BloodClass.Properties.Appearance.Options.UseFont = true;
            this.BloodClass.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BloodClass.Properties.Items.AddRange(new object[] {
            "0 RH-",
            "0 RH+",
            "A RH-",
            "A RH+",
            "AB RH-",
            "AB RH+",
            "B RH-",
            "B RH+"});
            this.BloodClass.Properties.Sorted = true;
            this.BloodClass.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.tablePanel1.SetRow(this.BloodClass, 4);
            this.BloodClass.Size = new System.Drawing.Size(295, 24);
            this.BloodClass.TabIndex = 13;
            // 
            // labelControl10
            // 
            this.tablePanel1.SetColumn(this.labelControl10, 0);
            this.labelControl10.Location = new System.Drawing.Point(13, 485);
            this.labelControl10.Name = "labelControl10";
            this.tablePanel1.SetRow(this.labelControl10, 13);
            this.labelControl10.Size = new System.Drawing.Size(82, 18);
            this.labelControl10.TabIndex = 0;
            this.labelControl10.Text = "GÖREV ADI:";
            // 
            // txtStatus
            // 
            this.tablePanel1.SetColumn(this.txtStatus, 1);
            this.txtStatus.Location = new System.Drawing.Point(182, 226);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStatus.Properties.Appearance.Options.UseFont = true;
            this.txtStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtStatus.Properties.Items.AddRange(new object[] {
            "GÖREVLİ",
            "HEMŞİRE",
            "MÜDÜR",
            "ÖĞRETMEN"});
            this.txtStatus.Properties.Sorted = true;
            this.txtStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.tablePanel1.SetRow(this.txtStatus, 7);
            this.txtStatus.Size = new System.Drawing.Size(295, 24);
            this.txtStatus.TabIndex = 12;
            // 
            // Gender
            // 
            this.tablePanel1.SetColumn(this.Gender, 1);
            this.Gender.Location = new System.Drawing.Point(182, 196);
            this.Gender.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Gender.Name = "Gender";
            this.Gender.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Gender.Properties.Appearance.Options.UseFont = true;
            this.Gender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Gender.Properties.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.Gender.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.tablePanel1.SetRow(this.Gender, 6);
            this.Gender.Size = new System.Drawing.Size(295, 24);
            this.Gender.TabIndex = 11;
            // 
            // Adress
            // 
            this.tablePanel1.SetColumn(this.Adress, 1);
            this.Adress.Location = new System.Drawing.Point(182, 256);
            this.Adress.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Adress.Name = "Adress";
            this.Adress.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Adress.Properties.Appearance.Options.UseFont = true;
            this.Adress.Properties.MaxLength = 100;
            this.tablePanel1.SetRow(this.Adress, 8);
            this.Adress.Size = new System.Drawing.Size(295, 52);
            this.Adress.TabIndex = 10;
            // 
            // IdentificationNumber
            // 
            this.tablePanel1.SetColumn(this.IdentificationNumber, 1);
            this.IdentificationNumber.Location = new System.Drawing.Point(180, 103);
            this.IdentificationNumber.Name = "IdentificationNumber";
            this.IdentificationNumber.Properties.MaxLength = 11;
            this.tablePanel1.SetRow(this.IdentificationNumber, 3);
            this.IdentificationNumber.Size = new System.Drawing.Size(299, 24);
            this.IdentificationNumber.TabIndex = 9;
            // 
            // Surname
            // 
            this.tablePanel1.SetColumn(this.Surname, 1);
            this.Surname.Location = new System.Drawing.Point(180, 43);
            this.Surname.Name = "Surname";
            this.Surname.Properties.MaxLength = 30;
            this.tablePanel1.SetRow(this.Surname, 1);
            this.Surname.Size = new System.Drawing.Size(299, 24);
            this.Surname.TabIndex = 9;
            // 
            // txtName
            // 
            this.tablePanel1.SetColumn(this.txtName, 1);
            this.txtName.Location = new System.Drawing.Point(180, 13);
            this.txtName.Name = "txtName";
            this.txtName.Properties.MaxLength = 30;
            this.tablePanel1.SetRow(this.txtName, 0);
            this.txtName.Size = new System.Drawing.Size(299, 24);
            this.txtName.TabIndex = 8;
            this.txtName.EditValueChanged += new System.EventHandler(this.txtName_EditValueChanged);
            // 
            // labelControl8
            // 
            this.tablePanel1.SetColumn(this.labelControl8, 0);
            this.labelControl8.Location = new System.Drawing.Point(13, 197);
            this.labelControl8.Name = "labelControl8";
            this.tablePanel1.SetRow(this.labelControl8, 6);
            this.labelControl8.Size = new System.Drawing.Size(72, 18);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "CİNSİYET:";
            // 
            // labelControl9
            // 
            this.tablePanel1.SetColumn(this.labelControl9, 0);
            this.labelControl9.Location = new System.Drawing.Point(13, 227);
            this.labelControl9.Name = "labelControl9";
            this.tablePanel1.SetRow(this.labelControl9, 7);
            this.labelControl9.Size = new System.Drawing.Size(52, 18);
            this.labelControl9.TabIndex = 1;
            this.labelControl9.Text = "GÖREV:";
            // 
            // labelControl7
            // 
            this.tablePanel1.SetColumn(this.labelControl7, 0);
            this.labelControl7.Location = new System.Drawing.Point(13, 255);
            this.labelControl7.Name = "labelControl7";
            this.tablePanel1.SetRow(this.labelControl7, 8);
            this.labelControl7.Size = new System.Drawing.Size(55, 18);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "ADRESİ:";
            // 
            // labelControl6
            // 
            this.tablePanel1.SetColumn(this.labelControl6, 0);
            this.labelControl6.Location = new System.Drawing.Point(13, 166);
            this.labelControl6.Name = "labelControl6";
            this.tablePanel1.SetRow(this.labelControl6, 5);
            this.labelControl6.Size = new System.Drawing.Size(145, 18);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "TELEFON NUMARASI:";
            // 
            // labelControl5
            // 
            this.tablePanel1.SetColumn(this.labelControl5, 0);
            this.labelControl5.Location = new System.Drawing.Point(13, 137);
            this.labelControl5.Name = "labelControl5";
            this.tablePanel1.SetRow(this.labelControl5, 4);
            this.labelControl5.Size = new System.Drawing.Size(86, 18);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "KAN GRUBU:";
            // 
            // labelControl4
            // 
            this.tablePanel1.SetColumn(this.labelControl4, 0);
            this.labelControl4.Location = new System.Drawing.Point(13, 106);
            this.labelControl4.Name = "labelControl4";
            this.tablePanel1.SetRow(this.labelControl4, 3);
            this.labelControl4.Size = new System.Drawing.Size(132, 18);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "KİMLİK NUMARASI:";
            // 
            // labelControl3
            // 
            this.tablePanel1.SetColumn(this.labelControl3, 0);
            this.labelControl3.Location = new System.Drawing.Point(13, 77);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel1.SetRow(this.labelControl3, 2);
            this.labelControl3.Size = new System.Drawing.Size(113, 18);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "DOĞUM TARİHİ:";
            // 
            // labelControl2
            // 
            this.tablePanel1.SetColumn(this.labelControl2, 0);
            this.labelControl2.Location = new System.Drawing.Point(13, 46);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel1.SetRow(this.labelControl2, 1);
            this.labelControl2.Size = new System.Drawing.Size(59, 18);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "SOYADI:";
            // 
            // labelControl1
            // 
            this.tablePanel1.SetColumn(this.labelControl1, 0);
            this.labelControl1.Location = new System.Drawing.Point(13, 16);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 0);
            this.labelControl1.Size = new System.Drawing.Size(30, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ADI:";
            // 
            // StatusName
            // 
            this.StatusName.Location = new System.Drawing.Point(180, 482);
            this.StatusName.Name = "StatusName";
            this.StatusName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StatusName.Size = new System.Drawing.Size(299, 24);
            this.StatusName.TabIndex = 1;
            // 
            // xtraOpenFileDialog1
            // 
            this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
            // 
            // EmployeePage
            // 
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 715);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("EmployeePage.IconOptions.Image")));
            this.Name = "EmployeePage";
            this.Text = "PERSONEL İŞLEMLERİ";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TelephoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Birthday.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Birthday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BloodClass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Adress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdentificationNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Surname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.ComboBoxEdit BloodClass;
        private DevExpress.XtraEditors.ComboBoxEdit txtStatus;
        private DevExpress.XtraEditors.ComboBoxEdit Gender;
        private DevExpress.XtraEditors.MemoEdit Adress;
        private DevExpress.XtraEditors.TextEdit IdentificationNumber;
        private DevExpress.XtraEditors.TextEdit Surname;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit Birthday;
        private DevExpress.XtraEditors.SimpleButton newEmployeBtn;
        private DevExpress.XtraEditors.SimpleButton UpdateEmployeeBtn;
        private DevExpress.XtraEditors.SimpleButton deleteEmployeBtn;
        private DevExpress.XtraEditors.TextEdit TelephoneNumber;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
        private DevExpress.XtraEditors.ComboBoxEdit CheckStatus;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.ComboBoxEdit StatusName;
    }
}