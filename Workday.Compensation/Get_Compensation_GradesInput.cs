using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Compensation_GradesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Compensation_Grades_RequestType Get_Compensation_Grades_Request;

		public Get_Compensation_GradesInput()
		{
		}

		public Get_Compensation_GradesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Compensation_Grades_RequestType Get_Compensation_Grades_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Compensation_Grades_Request = Get_Compensation_Grades_Request;
		}
	}
}
