
namespace EYM.Forms.Dashboards
{
    partial class StudentReport
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.DashboardCommon.Dimension dimension1 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.GridDimensionColumn gridDimensionColumn1 = new DevExpress.DashboardCommon.GridDimensionColumn();
            DevExpress.DashboardCommon.Dimension dimension2 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.GridDimensionColumn gridDimensionColumn2 = new DevExpress.DashboardCommon.GridDimensionColumn();
            DevExpress.DashboardCommon.Dimension dimension3 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.GridDimensionColumn gridDimensionColumn3 = new DevExpress.DashboardCommon.GridDimensionColumn();
            DevExpress.DashboardCommon.Dimension dimension4 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.GridDimensionColumn gridDimensionColumn4 = new DevExpress.DashboardCommon.GridDimensionColumn();
            DevExpress.DashboardCommon.Dimension dimension5 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.GridDimensionColumn gridDimensionColumn5 = new DevExpress.DashboardCommon.GridDimensionColumn();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.dashboardObjectDataSource1 = new DevExpress.DashboardCommon.DashboardObjectDataSource();
            this.gridDashboardItem1 = new DevExpress.DashboardCommon.GridDashboardItem();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardObjectDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // dashboardObjectDataSource1
            // 
            this.dashboardObjectDataSource1.ComponentName = "dashboardObjectDataSource1";
            this.dashboardObjectDataSource1.DataSource = typeof(EYM.Students);
            this.dashboardObjectDataSource1.Name = "Object Data Source 1";
            // 
            // gridDashboardItem1
            // 
            dimension1.DataMember = "Name";
            dimension1.Name = "ADI";
            dimension1.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
            gridDimensionColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight;
            gridDimensionColumn1.AddDataItem("Dimension", dimension1);
            dimension2.DataMember = "Surname";
            dimension2.Name = "SOYADI";
            dimension2.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
            gridDimensionColumn2.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight;
            gridDimensionColumn2.AddDataItem("Dimension", dimension2);
            dimension3.DataMember = "TelephoneNumber";
            dimension3.Name = "TELEFON NUMARASI";
            gridDimensionColumn3.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight;
            gridDimensionColumn3.AddDataItem("Dimension", dimension3);
            dimension4.DataMember = "IdentificationNumber";
            dimension4.Name = "KİMLİK NUMARASI";
            dimension4.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
            gridDimensionColumn4.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight;
            gridDimensionColumn4.AddDataItem("Dimension", dimension4);
            dimension5.DataMember = "DisabledInfo";
            dimension5.Name = "ENGEL BİLGİSİ";
            gridDimensionColumn5.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight;
            gridDimensionColumn5.AddDataItem("Dimension", dimension5);
            this.gridDashboardItem1.Columns.AddRange(new DevExpress.DashboardCommon.GridColumnBase[] {
            gridDimensionColumn1,
            gridDimensionColumn2,
            gridDimensionColumn3,
            gridDimensionColumn4,
            gridDimensionColumn5});
            this.gridDashboardItem1.ComponentName = "gridDashboardItem1";
            this.gridDashboardItem1.DataItemRepository.Clear();
            this.gridDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0");
            this.gridDashboardItem1.DataItemRepository.Add(dimension2, "DataItem1");
            this.gridDashboardItem1.DataItemRepository.Add(dimension3, "DataItem2");
            this.gridDashboardItem1.DataItemRepository.Add(dimension4, "DataItem3");
            this.gridDashboardItem1.DataItemRepository.Add(dimension5, "DataItem4");
            this.gridDashboardItem1.DataSource = this.dashboardObjectDataSource1;
            this.gridDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.gridDashboardItem1.Name = "ETİMESGUT ENGELSİZ YAŞAM MERKEZİ ÖĞRENCİ LİSTESİ";
            this.gridDashboardItem1.ShowCaption = true;
            // 
            // StudentReport
            // 
            this.DataSources.AddRange(new DevExpress.DashboardCommon.IDashboardDataSource[] {
            this.dashboardObjectDataSource1});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.gridDashboardItem1});
            dashboardLayoutItem1.DashboardItem = this.gridDashboardItem1;
            dashboardLayoutItem1.Weight = 100D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1});
            dashboardLayoutGroup1.DashboardItem = null;
            dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            dashboardLayoutGroup1.Weight = 100D;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.Text = "ETİMESGUT ENGELSİZ YAŞAM MERKEZİ ÖĞRENCİ LİSTESİ";
            ((System.ComponentModel.ISupportInitialize)(this.dashboardObjectDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DashboardCommon.DashboardObjectDataSource dashboardObjectDataSource1;
        private DevExpress.DashboardCommon.GridDashboardItem gridDashboardItem1;
    }
}
