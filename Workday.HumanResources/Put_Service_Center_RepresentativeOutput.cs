using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Service_Center_RepresentativeOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Service_Center_Representative_ResponseType Put_Service_Center_Representative_Response;

		public Put_Service_Center_RepresentativeOutput()
		{
		}

		public Put_Service_Center_RepresentativeOutput(Put_Service_Center_Representative_ResponseType Put_Service_Center_Representative_Response)
		{
			this.Put_Service_Center_Representative_Response = Put_Service_Center_Representative_Response;
		}
	}
}
