using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Recruiting_RegionInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Recruiting_Region_RequestType Put_Recruiting_Region_Request;

		public Put_Recruiting_RegionInput()
		{
		}

		public Put_Recruiting_RegionInput(Workday_Common_HeaderType Workday_Common_Header, Put_Recruiting_Region_RequestType Put_Recruiting_Region_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Recruiting_Region_Request = Put_Recruiting_Region_Request;
		}
	}
}
