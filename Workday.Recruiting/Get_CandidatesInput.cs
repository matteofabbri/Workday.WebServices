using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.RecruitingService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_CandidatesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Candidates_RequestType Get_Candidates_Request;

		public Get_CandidatesInput()
		{
		}

		public Get_CandidatesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Candidates_RequestType Get_Candidates_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Candidates_Request = Get_Candidates_Request;
		}
	}
}