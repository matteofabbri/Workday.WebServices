using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Effort_Certification_TypesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Effort_Certification_Types_RequestType Get_Effort_Certification_Types_Request;

		public Get_Effort_Certification_TypesInput()
		{
		}

		public Get_Effort_Certification_TypesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Effort_Certification_Types_RequestType Get_Effort_Certification_Types_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Effort_Certification_Types_Request = Get_Effort_Certification_Types_Request;
		}
	}
}
