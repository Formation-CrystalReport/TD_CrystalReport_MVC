using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TD_CrystalReport_MVC.Views.Rapports
{
    public partial class Bonjour : System.Web.Mvc.ViewPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TD_CrystalReport_MVC.Rapports.CachedCrystalReportBonjour cachedCrystalReportBonjour
                = new TD_CrystalReport_MVC.Rapports.CachedCrystalReportBonjour();

            CrystalReportViewer1.ReportSource = cachedCrystalReportBonjour;
        }
    }
}