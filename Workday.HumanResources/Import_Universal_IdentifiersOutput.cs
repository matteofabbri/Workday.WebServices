using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Import_Universal_IdentifiersOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Import_Process_ResponseType Put_Import_Process_Response;

		public Import_Universal_IdentifiersOutput()
		{
		}

		public Import_Universal_IdentifiersOutput(Put_Import_Process_ResponseType Put_Import_Process_Response)
		{
			this.Put_Import_Process_Response = Put_Import_Process_Response;
		}
	}
}
