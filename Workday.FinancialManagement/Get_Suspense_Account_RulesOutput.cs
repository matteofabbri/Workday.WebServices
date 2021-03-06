using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Suspense_Account_RulesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Suspense_Account_Rules_ResponseType Get_Suspense_Account_Rules_Response;

		public Get_Suspense_Account_RulesOutput()
		{
		}

		public Get_Suspense_Account_RulesOutput(Get_Suspense_Account_Rules_ResponseType Get_Suspense_Account_Rules_Response)
		{
			this.Get_Suspense_Account_Rules_Response = Get_Suspense_Account_Rules_Response;
		}
	}
}
