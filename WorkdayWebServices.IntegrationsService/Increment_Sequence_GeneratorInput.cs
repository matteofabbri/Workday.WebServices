using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.IntegrationsService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Increment_Sequence_GeneratorInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Increment_Sequence_Generator_RequestType Increment_Sequence_Generator_Request;

		public Increment_Sequence_GeneratorInput()
		{
		}

		public Increment_Sequence_GeneratorInput(Workday_Common_HeaderType Workday_Common_Header, Increment_Sequence_Generator_RequestType Increment_Sequence_Generator_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Increment_Sequence_Generator_Request = Increment_Sequence_Generator_Request;
		}
	}
}