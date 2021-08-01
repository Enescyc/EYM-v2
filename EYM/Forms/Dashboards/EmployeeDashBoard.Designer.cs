
namespace EYM.Forms.Dashboards
{
    partial class EmployeeDashBoard
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
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Dimension dimension2 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure2 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.ChartPane chartPane1 = new DevExpress.DashboardCommon.ChartPane();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries1 = new DevExpress.DashboardCommon.SimpleSeries();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.pieDashboardItem1 = new DevExpress.DashboardCommon.PieDashboardItem();
            this.chartDashboardItem1 = new DevExpress.DashboardCommon.ChartDashboardItem();
            this.dashboardObjectDataSource1 = new DevExpress.DashboardCommon.DashboardObjectDataSource();
            ((System.ComponentModel.ISupportInitialize)(this.pieDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardObjectDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pieDashboardItem1
            // 
            dimension1.DataMember = "Gender";
            this.pieDashboardItem1.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension1});
            this.pieDashboardItem1.ComponentName = "pieDashboardItem1";
            measure1.DataMember = "EmployeeID";
            measure1.Name = "KADIN-ERKEK PERSONEL SAYISI";
            measure1.SummaryType = DevExpress.DashboardCommon.SummaryType.Count;
            this.pieDashboardItem1.DataItemRepository.Clear();
            this.pieDashboardItem1.DataItemRepository.Add(measure1, "DataItem0");
            this.pieDashboardItem1.DataItemRepository.Add(dimension1, "DataItem1");
            this.pieDashboardItem1.DataSource = this.dashboardObjectDataSource1;
            this.pieDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.pieDashboardItem1.Name = "ERKEK-KADIN PERSONEL DAĞILIMI";
            this.pieDashboardItem1.ShowCaption = true;
            this.pieDashboardItem1.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure1});
            // 
            // chartDashboardItem1
            // 
            dimension2.DataMember = "Status";
            this.chartDashboardItem1.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension2});
            this.chartDashboardItem1.AxisX.TitleVisible = false;
            this.chartDashboardItem1.ComponentName = "chartDashboardItem1";
            measure2.DataMember = "EmployeeID";
            measure2.Name = "PERSONEL SAYISI";
            this.chartDashboardItem1.DataItemRepository.Clear();
            this.chartDashboardItem1.DataItemRepository.Add(measure2, "DataItem0");
            this.chartDashboardItem1.DataItemRepository.Add(dimension2, "DataItem1");
            this.chartDashboardItem1.DataSource = this.dashboardObjectDataSource1;
            this.chartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.chartDashboardItem1.Name = "PERSONEL GÖREV DAĞILIMI";
            chartPane1.Name = "Pane 1";
            chartPane1.PrimaryAxisY.AlwaysShowZeroLevel = true;
            chartPane1.PrimaryAxisY.ShowGridLines = true;
            chartPane1.PrimaryAxisY.TitleVisible = true;
            chartPane1.SecondaryAxisY.AlwaysShowZeroLevel = true;
            chartPane1.SecondaryAxisY.ShowGridLines = false;
            chartPane1.SecondaryAxisY.TitleVisible = true;
            simpleSeries1.AddDataItem("Value", measure2);
            chartPane1.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {
            simpleSeries1});
            this.chartDashboardItem1.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {
            chartPane1});
            this.chartDashboardItem1.ShowCaption = true;
            // 
            // dashboardObjectDataSource1
            // 
            this.dashboardObjectDataSource1.ComponentName = "dashboardObjectDataSource1";
            this.dashboardObjectDataSource1.DataSource = typeof(EYM.Employee);
            this.dashboardObjectDataSource1.Name = "Object Data Source 1";
            // 
            // EmployeeDashBoard
            // 
            this.DataSources.AddRange(new DevExpress.DashboardCommon.IDashboardDataSource[] {
            this.dashboardObjectDataSource1});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.pieDashboardItem1,
            this.chartDashboardItem1});
            dashboardLayoutItem1.DashboardItem = this.pieDashboardItem1;
            dashboardLayoutItem1.Weight = 50.067842605156038D;
            dashboardLayoutItem2.DashboardItem = this.chartDashboardItem1;
            dashboardLayoutItem2.Weight = 49.932157394843962D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutItem2});
            dashboardLayoutGroup1.DashboardItem = null;
            dashboardLayoutGroup1.Weight = 100D;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardObjectDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DashboardCommon.DashboardObjectDataSource dashboardObjectDataSource1;
        private DevExpress.DashboardCommon.PieDashboardItem pieDashboardItem1;
        private DevExpress.DashboardCommon.ChartDashboardItem chartDashboardItem1;
    }
}
