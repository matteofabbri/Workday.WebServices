using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Spend_AuthorizationInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Spend_Authorization_RequestType Submit_Spend_Authorization_Request;

		public Submit_Spend_AuthorizationInput()
		{
		}

		public Submit_Spend_AuthorizationInput(Workday_Common_HeaderType Workday_Common_Header, Submit_Spend_Authorization_RequestType Submit_Spend_Authorization_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_Spend_Authorization_Request = Submit_Spend_Authorization_Request;
		}
	}
}
