using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Edit_Service_DatesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Edit_Service_Dates_RequestType Edit_Service_Dates_Request;

		public Edit_Service_DatesInput()
		{
		}

		public Edit_Service_DatesInput(Workday_Common_HeaderType Workday_Common_Header, Edit_Service_Dates_RequestType Edit_Service_Dates_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Edit_Service_Dates_Request = Edit_Service_Dates_Request;
		}
	}
}
