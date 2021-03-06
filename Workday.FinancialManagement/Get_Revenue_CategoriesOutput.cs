using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Revenue_CategoriesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Revenue_Categories_ResponseType Get_Revenue_Categories_Response;

		public Get_Revenue_CategoriesOutput()
		{
		}

		public Get_Revenue_CategoriesOutput(Get_Revenue_Categories_ResponseType Get_Revenue_Categories_Response)
		{
			this.Get_Revenue_Categories_Response = Get_Revenue_Categories_Response;
		}
	}
}
