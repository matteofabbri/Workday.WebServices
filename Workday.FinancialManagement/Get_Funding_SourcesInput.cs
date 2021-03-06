using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Funding_SourcesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Funding_Sources_RequestType Get_Funding_Sources_Request;

		public Get_Funding_SourcesInput()
		{
		}

		public Get_Funding_SourcesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Funding_Sources_RequestType Get_Funding_Sources_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Funding_Sources_Request = Get_Funding_Sources_Request;
		}
	}
}
