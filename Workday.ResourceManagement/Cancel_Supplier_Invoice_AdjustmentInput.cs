using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Cancel_Supplier_Invoice_AdjustmentInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Cancel_Supplier_Invoice_Adjustment_RequestType Cancel_Supplier_Invoice_Adjustment_Request;

		public Cancel_Supplier_Invoice_AdjustmentInput()
		{
		}

		public Cancel_Supplier_Invoice_AdjustmentInput(Workday_Common_HeaderType Workday_Common_Header, Cancel_Supplier_Invoice_Adjustment_RequestType Cancel_Supplier_Invoice_Adjustment_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Cancel_Supplier_Invoice_Adjustment_Request = Cancel_Supplier_Invoice_Adjustment_Request;
		}
	}
}
