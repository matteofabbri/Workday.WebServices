using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Edit_Job_InterestsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Edit_Job_Interests_RequestType Edit_Job_Interests_Request;

		public Edit_Job_InterestsInput()
		{
		}

		public Edit_Job_InterestsInput(Workday_Common_HeaderType Workday_Common_Header, Edit_Job_Interests_RequestType Edit_Job_Interests_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Edit_Job_Interests_Request = Edit_Job_Interests_Request;
		}
	}
}
