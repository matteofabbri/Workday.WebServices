using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Catalog_LoadsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Catalog_Loads_RequestType Get_Catalog_Loads_Request;

		public Get_Catalog_LoadsInput()
		{
		}

		public Get_Catalog_LoadsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Catalog_Loads_RequestType Get_Catalog_Loads_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Catalog_Loads_Request = Get_Catalog_Loads_Request;
		}
	}
}
