using System;
using System.IO;
using System.Web.UI;
using DevExpress.XtraReports.Web;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        this.DocumentViewer1.Report = new XtraReport1();
    }
    protected void DocumentViewer1_CacheReportDocument(object sender, CacheReportDocumentEventArgs e) {
        e.Key = Guid.NewGuid().ToString();
        Page.Session[e.Key] = e.SaveDocumentToMemoryStream();
    }
    protected void DocumentViewer1_RestoreReportDocumentFromCache(object sender, RestoreReportDocumentFromCacheEventArgs e) {
        Stream stream = Page.Session[e.Key] as Stream;
        if (stream != null)
            e.RestoreDocumentFromStream(stream);
    }
}
