using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Student_Recruiting_Event_Registration_RecordOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Student_Recruiting_Event_Registration_Record_ResponseType Put_Student_Recruiting_Event_Registration_Record_Response;

		public Put_Student_Recruiting_Event_Registration_RecordOutput()
		{
		}

		public Put_Student_Recruiting_Event_Registration_RecordOutput(Put_Student_Recruiting_Event_Registration_Record_ResponseType Put_Student_Recruiting_Event_Registration_Record_Response)
		{
			this.Put_Student_Recruiting_Event_Registration_Record_Response = Put_Student_Recruiting_Event_Registration_Record_Response;
		}
	}
}
