using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Bank_Statement_Custom_Code_SetInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Bank_Statement_Custom_Code_Set_RequestType Put_Bank_Statement_Custom_Code_Set_Request;

		public Put_Bank_Statement_Custom_Code_SetInput()
		{
		}

		public Put_Bank_Statement_Custom_Code_SetInput(Workday_Common_HeaderType Workday_Common_Header, Put_Bank_Statement_Custom_Code_Set_RequestType Put_Bank_Statement_Custom_Code_Set_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Bank_Statement_Custom_Code_Set_Request = Put_Bank_Statement_Custom_Code_Set_Request;
		}
	}
}
