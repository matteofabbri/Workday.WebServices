using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Student_Course_MaterialInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Student_Course_Material_RequestType Put_Student_Course_Material_Request;

		public Put_Student_Course_MaterialInput()
		{
		}

		public Put_Student_Course_MaterialInput(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Course_Material_RequestType Put_Student_Course_Material_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Student_Course_Material_Request = Put_Student_Course_Material_Request;
		}
	}
}
