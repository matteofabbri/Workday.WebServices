using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Educational_Institution_CourseInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Educational_Institution_Course_RequestType Put_Educational_Institution_Course_Request;

		public Put_Educational_Institution_CourseInput()
		{
		}

		public Put_Educational_Institution_CourseInput(Workday_Common_HeaderType Workday_Common_Header, Put_Educational_Institution_Course_RequestType Put_Educational_Institution_Course_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Educational_Institution_Course_Request = Put_Educational_Institution_Course_Request;
		}
	}
}
