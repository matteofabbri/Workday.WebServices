using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Billing_ScheduleInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Billing_Schedule_RequestType Submit_Billing_Schedule_Request;

		public Submit_Billing_ScheduleInput()
		{
		}

		public Submit_Billing_ScheduleInput(Workday_Common_HeaderType Workday_Common_Header, Submit_Billing_Schedule_RequestType Submit_Billing_Schedule_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_Billing_Schedule_Request = Submit_Billing_Schedule_Request;
		}
	}
}
