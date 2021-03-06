using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Card_Holder_Listing_FileInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Card_Holder_Listing_File_RequestType Put_Card_Holder_Listing_File_Request;

		public Put_Card_Holder_Listing_FileInput()
		{
		}

		public Put_Card_Holder_Listing_FileInput(Workday_Common_HeaderType Workday_Common_Header, Put_Card_Holder_Listing_File_RequestType Put_Card_Holder_Listing_File_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Card_Holder_Listing_File_Request = Put_Card_Holder_Listing_File_Request;
		}
	}
}
