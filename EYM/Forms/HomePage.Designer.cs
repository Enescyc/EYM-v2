
namespace EYM.Forms
{
    partial class HomePage
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
            this.dashboardBarAndDockingController1 = new DevExpress.DashboardWin.Native.DashboardBarAndDockingController(this.components);
            this.dashboardBarController1 = new DevExpress.DashboardWin.Bars.DashboardBarController(this.components);
            this.eYMDataSet = new EYM.EYMDataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new EYM.EYMDataSetTableAdapters.StudentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardBarAndDockingController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardBarController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eYMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // eYMDataSet
            // 
            this.eYMDataSet.DataSetName = "EYMDataSet";
            this.eYMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.eYMDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 694);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dashboardBarAndDockingController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardBarController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eYMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.DashboardWin.Native.DashboardBarAndDockingController dashboardBarAndDockingController1;
        private DevExpress.DashboardWin.Bars.DashboardBarController dashboardBarController1;
        private EYMDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private EYMDataSet eYMDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
    }
}