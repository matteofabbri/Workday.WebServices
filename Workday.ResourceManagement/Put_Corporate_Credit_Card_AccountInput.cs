using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Corporate_Credit_Card_AccountInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Corporate_Credit_Card_Account_RequestType Put_Corporate_Credit_Card_Account_Request;

		public Put_Corporate_Credit_Card_AccountInput()
		{
		}

		public Put_Corporate_Credit_Card_AccountInput(Workday_Common_HeaderType Workday_Common_Header, Put_Corporate_Credit_Card_Account_RequestType Put_Corporate_Credit_Card_Account_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Corporate_Credit_Card_Account_Request = Put_Corporate_Credit_Card_Account_Request;
		}
	}
}
