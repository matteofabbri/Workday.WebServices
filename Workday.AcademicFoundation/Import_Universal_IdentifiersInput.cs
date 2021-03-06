using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Import_Universal_IdentifiersInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Import_Universal_Identifier_RequestType Import_Universal_Identifier_Request;

		public Import_Universal_IdentifiersInput()
		{
		}

		public Import_Universal_IdentifiersInput(Workday_Common_HeaderType Workday_Common_Header, Import_Universal_Identifier_RequestType Import_Universal_Identifier_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Import_Universal_Identifier_Request = Import_Universal_Identifier_Request;
		}
	}
}
