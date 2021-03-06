using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Certification_IssuersInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Certification_Issuers_RequestType Get_Certification_Issuers_Request;

		public Get_Certification_IssuersInput()
		{
		}

		public Get_Certification_IssuersInput(Workday_Common_HeaderType Workday_Common_Header, Get_Certification_Issuers_RequestType Get_Certification_Issuers_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Certification_Issuers_Request = Get_Certification_Issuers_Request;
		}
	}
}
