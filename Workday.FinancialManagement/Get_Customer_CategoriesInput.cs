using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Customer_CategoriesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Customer_Categories_RequestType Get_Customer_Categories_Request;

		public Get_Customer_CategoriesInput()
		{
		}

		public Get_Customer_CategoriesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Customer_Categories_RequestType Get_Customer_Categories_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Customer_Categories_Request = Get_Customer_Categories_Request;
		}
	}
}
