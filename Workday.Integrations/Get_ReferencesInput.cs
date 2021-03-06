using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Integrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_ReferencesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_References_RequestType Get_References_Request;

		public Get_ReferencesInput()
		{
		}

		public Get_ReferencesInput(Workday_Common_HeaderType Workday_Common_Header, Get_References_RequestType Get_References_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_References_Request = Get_References_Request;
		}
	}
}
