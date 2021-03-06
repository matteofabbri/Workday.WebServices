using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Academic_UnitsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Academic_Units_ResponseType Get_Academic_Units_Response;

		public Get_Academic_UnitsOutput()
		{
		}

		public Get_Academic_UnitsOutput(Get_Academic_Units_ResponseType Get_Academic_Units_Response)
		{
			this.Get_Academic_Units_Response = Get_Academic_Units_Response;
		}
	}
}
