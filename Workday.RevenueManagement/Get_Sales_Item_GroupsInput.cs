using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Sales_Item_GroupsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Sales_Item_Groups_RequestType Get_Sales_Item_Groups_Request;

		public Get_Sales_Item_GroupsInput()
		{
		}

		public Get_Sales_Item_GroupsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Sales_Item_Groups_RequestType Get_Sales_Item_Groups_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Sales_Item_Groups_Request = Get_Sales_Item_Groups_Request;
		}
	}
}
