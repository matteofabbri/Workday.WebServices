using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Award_Task_Type_GroupOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Award_Task_Type_Group_ResponseType Put_Award_Task_Type_Group_Response;

		public Put_Award_Task_Type_GroupOutput()
		{
		}

		public Put_Award_Task_Type_GroupOutput(Put_Award_Task_Type_Group_ResponseType Put_Award_Task_Type_Group_Response)
		{
			this.Put_Award_Task_Type_Group_Response = Put_Award_Task_Type_Group_Response;
		}
	}
}
