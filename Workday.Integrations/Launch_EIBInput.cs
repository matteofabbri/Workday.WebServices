using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Integrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Launch_EIBInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Launch_EIB_RequestType Launch_EIB_Request;

		public Launch_EIBInput()
		{
		}

		public Launch_EIBInput(Workday_Common_HeaderType Workday_Common_Header, Launch_EIB_RequestType Launch_EIB_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Launch_EIB_Request = Launch_EIB_Request;
		}
	}
}
