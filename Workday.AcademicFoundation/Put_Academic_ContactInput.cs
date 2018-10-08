using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Academic_FoundationService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Academic_ContactInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Academic_Contact_RequestType Put_Academic_Contact_Request;

		public Put_Academic_ContactInput()
		{
		}

		public Put_Academic_ContactInput(Workday_Common_HeaderType Workday_Common_Header, Put_Academic_Contact_RequestType Put_Academic_Contact_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Academic_Contact_Request = Put_Academic_Contact_Request;
		}
	}
}