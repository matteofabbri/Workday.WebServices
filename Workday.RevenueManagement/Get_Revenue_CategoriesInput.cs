using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Revenue_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Revenue_CategoriesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Revenue_Categories_RequestType Get_Revenue_Categories_Request;

		public Get_Revenue_CategoriesInput()
		{
		}

		public Get_Revenue_CategoriesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Revenue_Categories_RequestType Get_Revenue_Categories_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Revenue_Categories_Request = Get_Revenue_Categories_Request;
		}
	}
}