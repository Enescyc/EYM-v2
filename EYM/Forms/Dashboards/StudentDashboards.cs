using DevExpress.DashboardCommon;
using DevExpress.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EYM.Forms.Dashboards
{
    public partial class StudentDashboards : DevExpress.DashboardCommon.Dashboard
    {
        public StudentDashboards()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            EYM.EYMEntities2 dbContext = new EYM.EYMEntities2();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.Students.Load();
            // This line of code is generated by Data Source Configuration Wizard
            dashboardObjectDataSource2.DataSource = dbContext.Students.Local.ToBindingList();
        }
    }
}
