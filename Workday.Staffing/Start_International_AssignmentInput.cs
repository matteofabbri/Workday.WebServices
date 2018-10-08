using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.StaffingService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Start_International_AssignmentInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Start_International_Assignment_RequestType Start_International_Assignment_Request;

		public Start_International_AssignmentInput()
		{
		}

		public Start_International_AssignmentInput(Workday_Common_HeaderType Workday_Common_Header, Start_International_Assignment_RequestType Start_International_Assignment_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Start_International_Assignment_Request = Start_International_Assignment_Request;
		}
	}
}