using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Payroll_Timesheets_Time_In_Time_OutOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Payroll_Timesheets_Time_In_Time_Out_ResponseType Get_Payroll_Timesheets_Time_In_Time_Out_Response;

		public Get_Payroll_Timesheets_Time_In_Time_OutOutput()
		{
		}

		public Get_Payroll_Timesheets_Time_In_Time_OutOutput(Get_Payroll_Timesheets_Time_In_Time_Out_ResponseType Get_Payroll_Timesheets_Time_In_Time_Out_Response)
		{
			this.Get_Payroll_Timesheets_Time_In_Time_Out_Response = Get_Payroll_Timesheets_Time_In_Time_Out_Response;
		}
	}
}
