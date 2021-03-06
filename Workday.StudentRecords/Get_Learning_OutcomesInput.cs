using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Learning_OutcomesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Learning_Outcomes_RequestType Get_Learning_Outcomes_Request;

		public Get_Learning_OutcomesInput()
		{
		}

		public Get_Learning_OutcomesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Learning_Outcomes_RequestType Get_Learning_Outcomes_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Learning_Outcomes_Request = Get_Learning_Outcomes_Request;
		}
	}
}
