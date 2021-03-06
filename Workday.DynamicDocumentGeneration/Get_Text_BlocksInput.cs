using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.DynamicDocumentGeneration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Text_BlocksInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Text_Blocks_RequestType Get_Text_Blocks_Request;

		public Get_Text_BlocksInput()
		{
		}

		public Get_Text_BlocksInput(Workday_Common_HeaderType Workday_Common_Header, Get_Text_Blocks_RequestType Get_Text_Blocks_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Text_Blocks_Request = Get_Text_Blocks_Request;
		}
	}
}
