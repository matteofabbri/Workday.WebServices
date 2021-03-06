using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Student_Grading_SchemeInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Student_Grading_Scheme_RequestType Put_Student_Grading_Scheme_Request;

		public Put_Student_Grading_SchemeInput()
		{
		}

		public Put_Student_Grading_SchemeInput(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Grading_Scheme_RequestType Put_Student_Grading_Scheme_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Student_Grading_Scheme_Request = Put_Student_Grading_Scheme_Request;
		}
	}
}
