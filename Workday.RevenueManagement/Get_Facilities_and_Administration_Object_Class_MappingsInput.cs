using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Facilities_and_Administration_Object_Class_MappingsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Facilities_and_Admin_Object_Class_Mappings_RequestType Get_Facilities_and_Admin_Object_Class_Mappings_Request;

		public Get_Facilities_and_Administration_Object_Class_MappingsInput()
		{
		}

		public Get_Facilities_and_Administration_Object_Class_MappingsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Facilities_and_Admin_Object_Class_Mappings_RequestType Get_Facilities_and_Admin_Object_Class_Mappings_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Facilities_and_Admin_Object_Class_Mappings_Request = Get_Facilities_and_Admin_Object_Class_Mappings_Request;
		}
	}
}
