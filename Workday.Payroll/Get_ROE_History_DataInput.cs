using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_ROE_History_DataInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_ROE_History_Data_RequestType Get_ROE_History_Data_Request;

		public Get_ROE_History_DataInput()
		{
		}

		public Get_ROE_History_DataInput(Workday_Common_HeaderType Workday_Common_Header, Get_ROE_History_Data_RequestType Get_ROE_History_Data_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_ROE_History_Data_Request = Get_ROE_History_Data_Request;
		}
	}
}
