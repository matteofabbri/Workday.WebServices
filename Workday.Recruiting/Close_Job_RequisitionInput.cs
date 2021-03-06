using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Close_Job_RequisitionInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Close_Job_Requisition_RequestType Close_Job_Requisition_Request;

		public Close_Job_RequisitionInput()
		{
		}

		public Close_Job_RequisitionInput(Workday_Common_HeaderType Workday_Common_Header, Close_Job_Requisition_RequestType Close_Job_Requisition_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Close_Job_Requisition_Request = Close_Job_Requisition_Request;
		}
	}
}
