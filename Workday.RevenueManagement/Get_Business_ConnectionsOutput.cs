using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Revenue_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Business_ConnectionsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Business_Connections_ResponseType Get_Business_Connections_Response;

		public Get_Business_ConnectionsOutput()
		{
		}

		public Get_Business_ConnectionsOutput(Get_Business_Connections_ResponseType Get_Business_Connections_Response)
		{
			this.Get_Business_Connections_Response = Get_Business_Connections_Response;
		}
	}
}