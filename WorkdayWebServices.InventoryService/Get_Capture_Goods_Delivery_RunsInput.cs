using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace WorkdayWebServices.InventoryService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Capture_Goods_Delivery_RunsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Capture_Goods_Delivery_Runs_RequestType Get_Capture_Goods_Delivery_Runs_Request;

		public Get_Capture_Goods_Delivery_RunsInput()
		{
		}

		public Get_Capture_Goods_Delivery_RunsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Capture_Goods_Delivery_Runs_RequestType Get_Capture_Goods_Delivery_Runs_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Capture_Goods_Delivery_Runs_Request = Get_Capture_Goods_Delivery_Runs_Request;
		}
	}
}