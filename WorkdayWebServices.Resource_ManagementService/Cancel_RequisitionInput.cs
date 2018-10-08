using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Resource_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Cancel_RequisitionInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Cancel_Requisition_RequestType Cancel_Requisition_Request;

		public Cancel_RequisitionInput()
		{
		}

		public Cancel_RequisitionInput(Workday_Common_HeaderType Workday_Common_Header, Cancel_Requisition_RequestType Cancel_Requisition_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Cancel_Requisition_Request = Cancel_Requisition_Request;
		}
	}
}