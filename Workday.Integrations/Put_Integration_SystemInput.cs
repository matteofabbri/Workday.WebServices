using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Integrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Integration_SystemInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Integration_System_RequestType Put_Integration_System_Request;

		public Put_Integration_SystemInput()
		{
		}

		public Put_Integration_SystemInput(Workday_Common_HeaderType Workday_Common_Header, Put_Integration_System_RequestType Put_Integration_System_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Integration_System_Request = Put_Integration_System_Request;
		}
	}
}
