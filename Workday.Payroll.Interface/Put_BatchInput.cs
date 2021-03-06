using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_BatchInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Batch_RequestType Put_Batch_Request;

		public Put_BatchInput()
		{
		}

		public Put_BatchInput(Workday_Common_HeaderType Workday_Common_Header, Put_Batch_RequestType Put_Batch_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Batch_Request = Put_Batch_Request;
		}
	}
}
