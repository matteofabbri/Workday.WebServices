using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Inventory
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Inventory_Location_AttributesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Inventory_Location_Attributes_RequestType Put_Inventory_Location_Attributes_Request;

		public Put_Inventory_Location_AttributesInput()
		{
		}

		public Put_Inventory_Location_AttributesInput(Workday_Common_HeaderType Workday_Common_Header, Put_Inventory_Location_Attributes_RequestType Put_Inventory_Location_Attributes_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Inventory_Location_Attributes_Request = Put_Inventory_Location_Attributes_Request;
		}
	}
}
