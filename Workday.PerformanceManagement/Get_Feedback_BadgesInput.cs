using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Feedback_BadgesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Feedback_Badges_RequestType Get_Feedback_Badges_Request;

		public Get_Feedback_BadgesInput()
		{
		}

		public Get_Feedback_BadgesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Feedback_Badges_RequestType Get_Feedback_Badges_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Feedback_Badges_Request = Get_Feedback_Badges_Request;
		}
	}
}
