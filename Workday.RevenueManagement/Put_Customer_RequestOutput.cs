using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Customer_RequestOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Customer_Request_ResponseType Put_Customer_Request_Response;

		public Put_Customer_RequestOutput()
		{
		}

		public Put_Customer_RequestOutput(Put_Customer_Request_ResponseType Put_Customer_Request_Response)
		{
			this.Put_Customer_Request_Response = Put_Customer_Request_Response;
		}
	}
}
