using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Holiday_CalendarInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Holiday_Calendar_RequestType Put_Holiday_Calendar_Request;

		public Put_Holiday_CalendarInput()
		{
		}

		public Put_Holiday_CalendarInput(Workday_Common_HeaderType Workday_Common_Header, Put_Holiday_Calendar_RequestType Put_Holiday_Calendar_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Holiday_Calendar_Request = Put_Holiday_Calendar_Request;
		}
	}
}
