using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Cancel_Advanced_Ship_NoticeInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Cancel_Advanced_Ship_Notice_RequestType Cancel_Advanced_Ship_Notice_Request;

		public Cancel_Advanced_Ship_NoticeInput()
		{
		}

		public Cancel_Advanced_Ship_NoticeInput(Workday_Common_HeaderType Workday_Common_Header, Cancel_Advanced_Ship_Notice_RequestType Cancel_Advanced_Ship_Notice_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Cancel_Advanced_Ship_Notice_Request = Cancel_Advanced_Ship_Notice_Request;
		}
	}
}
