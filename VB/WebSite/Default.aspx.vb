Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.IO

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Me.ReportViewer1.Report = New XtraReport1()
	End Sub
	Protected Sub ReportViewer1_CacheReportDocument(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Web.CacheReportDocumentEventArgs)
		e.Key = Guid.NewGuid().ToString()
		Page.Session(e.Key) = e.SaveDocumentToMemoryStream()
	End Sub
	Protected Sub ReportViewer1_RestoreReportDocumentFromCache(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Web.RestoreReportDocumentFromCacheEventArgs)
		Dim stream As Stream = TryCast(Page.Session(e.Key), Stream)
		If stream IsNot Nothing Then
			e.RestoreDocumentFromStream(stream)
		End If
	End Sub
End Class
