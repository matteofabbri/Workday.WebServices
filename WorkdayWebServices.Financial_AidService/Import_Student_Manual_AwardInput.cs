using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Financial_AidService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Import_Student_Manual_AwardInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Import_Student_Manual_Award_RequestType Import_Student_Manual_Award_Request;

		public Import_Student_Manual_AwardInput()
		{
		}

		public Import_Student_Manual_AwardInput(Workday_Common_HeaderType Workday_Common_Header, Import_Student_Manual_Award_RequestType Import_Student_Manual_Award_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Import_Student_Manual_Award_Request = Import_Student_Manual_Award_Request;
		}
	}
}