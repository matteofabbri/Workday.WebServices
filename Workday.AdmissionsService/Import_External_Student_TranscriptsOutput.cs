using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.AdmissionsService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Import_External_Student_TranscriptsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Import_Process_ResponseType Put_Import_Process_Response;

		public Import_External_Student_TranscriptsOutput()
		{
		}

		public Import_External_Student_TranscriptsOutput(Put_Import_Process_ResponseType Put_Import_Process_Response)
		{
			this.Put_Import_Process_Response = Put_Import_Process_Response;
		}
	}
}