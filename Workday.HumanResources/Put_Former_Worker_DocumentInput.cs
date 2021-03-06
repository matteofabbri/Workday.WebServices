using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Former_Worker_DocumentInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Former_Worker_Document_RequestType Put_Former_Worker_Document_Request;

		public Put_Former_Worker_DocumentInput()
		{
		}

		public Put_Former_Worker_DocumentInput(Workday_Common_HeaderType Workday_Common_Header, Put_Former_Worker_Document_RequestType Put_Former_Worker_Document_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Former_Worker_Document_Request = Put_Former_Worker_Document_Request;
		}
	}
}
