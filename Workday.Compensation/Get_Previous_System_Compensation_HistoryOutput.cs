using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Previous_System_Compensation_HistoryOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Previous_System_Compensation_History_ResponseType Get_Previous_System_Compensation_History_Response;

		public Get_Previous_System_Compensation_HistoryOutput()
		{
		}

		public Get_Previous_System_Compensation_HistoryOutput(Get_Previous_System_Compensation_History_ResponseType Get_Previous_System_Compensation_History_Response)
		{
			this.Get_Previous_System_Compensation_History_Response = Get_Previous_System_Compensation_History_Response;
		}
	}
}
