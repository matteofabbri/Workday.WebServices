using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Previous_System_Job_HistoryOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Previous_System_Job_History_ResponseType Put_Previous_System_Job_History_Response;

		public Put_Previous_System_Job_HistoryOutput()
		{
		}

		public Put_Previous_System_Job_HistoryOutput(Put_Previous_System_Job_History_ResponseType Put_Previous_System_Job_History_Response)
		{
			this.Put_Previous_System_Job_History_Response = Put_Previous_System_Job_History_Response;
		}
	}
}
