using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Client;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	// Get Attachment Page Html
	class Get_Attachment_Page_Html
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new ViewerApi(configuration);

			try
			{
				var request = new HtmlGetAttachmentPageRequest
				{
					FileName = "with-attachment.msg",
					AttachmentName = "TestAttachment-File.docx",
					PageNumber = 1,
					ResourcePath = null,
					IgnoreResourcePathInResources = null,
					EmbedResources = null,
					RenderComments = null,
					RenderHiddenPages = null,
					Password = null,
					AttachmentPassword = "",
					DefaultFontName = null,
					FontsFolder = null,
					Folder = "viewerdocs",
					Storage = null,
				};

				var response = apiInstance.HtmlGetAttachmentPage(request);
				Console.WriteLine("Expected response type is System.IO.Stream: " + response.Length);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling ViewerApi: " + e.Message);
			}
		}
	}
}