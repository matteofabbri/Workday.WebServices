using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Card_Holder_Listing_FilesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Card_Holder_Listing_Files_RequestType Get_Card_Holder_Listing_Files_Request;

		public Get_Card_Holder_Listing_FilesInput()
		{
		}

		public Get_Card_Holder_Listing_FilesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Card_Holder_Listing_Files_RequestType Get_Card_Holder_Listing_Files_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Card_Holder_Listing_Files_Request = Get_Card_Holder_Listing_Files_Request;
		}
	}
}
