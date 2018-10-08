using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.Revenue_ManagementService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Subrecipient_Risk_RecordInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Subrecipient_Risk_Record_RequestType Put_Subrecipient_Risk_Record_Request;

		public Put_Subrecipient_Risk_RecordInput()
		{
		}

		public Put_Subrecipient_Risk_RecordInput(Workday_Common_HeaderType Workday_Common_Header, Put_Subrecipient_Risk_Record_RequestType Put_Subrecipient_Risk_Record_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Subrecipient_Risk_Record_Request = Put_Subrecipient_Risk_Record_Request;
		}
	}
}