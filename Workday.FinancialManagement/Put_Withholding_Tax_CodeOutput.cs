using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Withholding_Tax_CodeOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Withholding_Tax_Code_ResponseType Put_Withholding_Tax_Code_Response;

		public Put_Withholding_Tax_CodeOutput()
		{
		}

		public Put_Withholding_Tax_CodeOutput(Put_Withholding_Tax_Code_ResponseType Put_Withholding_Tax_Code_Response)
		{
			this.Put_Withholding_Tax_Code_Response = Put_Withholding_Tax_Code_Response;
		}
	}
}
