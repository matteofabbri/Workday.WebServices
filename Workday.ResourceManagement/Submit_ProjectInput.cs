using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_ProjectInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Project_RequestType Submit_Project_Request;

		public Submit_ProjectInput()
		{
		}

		public Submit_ProjectInput(Workday_Common_HeaderType Workday_Common_Header, Submit_Project_RequestType Submit_Project_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_Project_Request = Submit_Project_Request;
		}
	}
}
