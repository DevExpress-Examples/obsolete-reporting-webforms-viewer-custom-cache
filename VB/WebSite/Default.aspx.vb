Imports System
Imports System.IO
Imports System.Web.UI
Imports DevExpress.XtraReports.Web
' ...

Partial Public Class _Default
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        Me.ReportViewer1.Report = New XtraReport1()
    End Sub
    Protected Sub ReportViewer1_CacheReportDocument(ByVal sender As Object, ByVal e As CacheReportDocumentEventArgs)
        e.Key = Guid.NewGuid().ToString()
        Page.Session(e.Key) = e.SaveDocumentToMemoryStream()
    End Sub
    Protected Sub ReportViewer1_RestoreReportDocumentFromCache(ByVal sender As Object, _
                                                               ByVal e As RestoreReportDocumentFromCacheEventArgs)
        Dim stream As Stream = TryCast(Page.Session(e.Key), Stream)
        If stream IsNot Nothing Then
            e.RestoreDocumentFromStream(stream)
        End If
    End Sub
End Class
