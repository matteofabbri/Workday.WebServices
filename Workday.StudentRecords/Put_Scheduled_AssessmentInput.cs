using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Scheduled_AssessmentInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Scheduled_Assessment_RequestType Put_Scheduled_Assessment_Request;

		public Put_Scheduled_AssessmentInput()
		{
		}

		public Put_Scheduled_AssessmentInput(Workday_Common_HeaderType Workday_Common_Header, Put_Scheduled_Assessment_RequestType Put_Scheduled_Assessment_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Scheduled_Assessment_Request = Put_Scheduled_Assessment_Request;
		}
	}
}
