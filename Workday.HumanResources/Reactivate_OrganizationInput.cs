using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Human_ResourcesService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Reactivate_OrganizationInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Reactivate_Organization_RequestType Reactivate_Organization_Request;

		public Reactivate_OrganizationInput()
		{
		}

		public Reactivate_OrganizationInput(Workday_Common_HeaderType Workday_Common_Header, Reactivate_Organization_RequestType Reactivate_Organization_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Reactivate_Organization_Request = Reactivate_Organization_Request;
		}
	}
}