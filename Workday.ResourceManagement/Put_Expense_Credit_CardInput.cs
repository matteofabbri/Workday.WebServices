using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Expense_Credit_CardInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Expense_Credit_Card_RequestType Put_Expense_Credit_Card_Request;

		public Put_Expense_Credit_CardInput()
		{
		}

		public Put_Expense_Credit_CardInput(Workday_Common_HeaderType Workday_Common_Header, Put_Expense_Credit_Card_RequestType Put_Expense_Credit_Card_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Expense_Credit_Card_Request = Put_Expense_Credit_Card_Request;
		}
	}
}
