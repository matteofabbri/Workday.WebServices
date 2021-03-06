using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Submit_Payroll_InputsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Submit_Payroll_Inputs_RequestType Get_Submit_Payroll_Inputs_Request;

		public Get_Submit_Payroll_InputsInput()
		{
		}

		public Get_Submit_Payroll_InputsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Submit_Payroll_Inputs_RequestType Get_Submit_Payroll_Inputs_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Submit_Payroll_Inputs_Request = Get_Submit_Payroll_Inputs_Request;
		}
	}
}
