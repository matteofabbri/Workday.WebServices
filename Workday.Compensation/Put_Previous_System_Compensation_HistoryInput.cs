using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Previous_System_Compensation_HistoryInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Previous_System_Compensation_History_RequestType Put_Previous_System_Compensation_History_Request;

		public Put_Previous_System_Compensation_HistoryInput()
		{
		}

		public Put_Previous_System_Compensation_HistoryInput(Workday_Common_HeaderType Workday_Common_Header, Put_Previous_System_Compensation_History_RequestType Put_Previous_System_Compensation_History_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Previous_System_Compensation_History_Request = Put_Previous_System_Compensation_History_Request;
		}
	}
}
