using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.ReportViewer1.Report = new XtraReport1();
    }
    protected void ReportViewer1_CacheReportDocument(object sender, DevExpress.XtraReports.Web.CacheReportDocumentEventArgs e) {
        e.Key = Guid.NewGuid().ToString();
        Page.Session[e.Key] = e.SaveDocumentToMemoryStream();
    }
    protected void ReportViewer1_RestoreReportDocumentFromCache(object sender, DevExpress.XtraReports.Web.RestoreReportDocumentFromCacheEventArgs e) {
        Stream stream = Page.Session[e.Key] as Stream;
        if (stream != null)
            e.RestoreDocumentFromStream(stream);
    }
}
