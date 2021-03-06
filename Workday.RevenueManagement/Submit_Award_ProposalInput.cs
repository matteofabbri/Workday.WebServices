using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Award_ProposalInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Award_Proposal_RequestType Submit_Award_Proposal_Request;

		public Submit_Award_ProposalInput()
		{
		}

		public Submit_Award_ProposalInput(Workday_Common_HeaderType Workday_Common_Header, Submit_Award_Proposal_RequestType Submit_Award_Proposal_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_Award_Proposal_Request = Submit_Award_Proposal_Request;
		}
	}
}
