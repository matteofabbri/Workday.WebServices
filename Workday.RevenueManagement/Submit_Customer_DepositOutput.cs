using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Customer_DepositOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Customer_Deposit_ResponseType Submit_Customer_Deposit_Response;

		public Submit_Customer_DepositOutput()
		{
		}

		public Submit_Customer_DepositOutput(Submit_Customer_Deposit_ResponseType Submit_Customer_Deposit_Response)
		{
			this.Submit_Customer_Deposit_Response = Submit_Customer_Deposit_Response;
		}
	}
}
