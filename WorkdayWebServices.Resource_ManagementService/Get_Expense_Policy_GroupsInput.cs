using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Resource_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Expense_Policy_GroupsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Expense_Policy_Groups_RequestType Get_Expense_Policy_Groups_Request;

		public Get_Expense_Policy_GroupsInput()
		{
		}

		public Get_Expense_Policy_GroupsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Expense_Policy_Groups_RequestType Get_Expense_Policy_Groups_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Expense_Policy_Groups_Request = Get_Expense_Policy_Groups_Request;
		}
	}
}