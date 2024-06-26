<!-- default file list -->
*Files to look at*:

* [XtraReport1.cs](./CS/WebSite/App_Code/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/WebSite/App_Code/XtraReport1.vb))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# How to use the caching functionality of the Document Viewer


<p>This example illustrates how to make the <a href="http://documentation.devexpress.com/#XtraReports/CustomDocument5193"><u>ASPxDocumentViewer</u></a> store its document on the client between postbacks.</p>
<p>Upon the request to preview, export, or print the document, the Document Viewer restores it from the Page cache, instead of performing a round trip to the server, requesting for a new document copy.</p>
<p>The Document Viewer manages a cached document during the <a href="http://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsWebASPxDocumentViewer_CacheReportDocumenttopic"><u>CacheReportDocument</u></a> and <a href="http://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsWebASPxDocumentViewer_RestoreReportDocumentFromCachetopic"><u>RestoreReportDocumentFromCache</u></a> events.</p>
<p>For an MVC approach to solving this task, see <a href="https://www.devexpress.com/Support/Center/p/T191577">How to use the built-in caching functionality of the ASP.NET MVC Document Viewer</a>.<br><br><strong>Note:</strong> No document caching is required when using the newer <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument17738">ASPxWebDocumentViewer</a> control that utilizes the HTML5/JS technology and provides asynchronous building of documents out of the box.</p>

<br/>


