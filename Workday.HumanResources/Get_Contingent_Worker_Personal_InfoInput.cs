using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Contingent_Worker_Personal_InfoInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Contingent_Worker_Personal_Info_GetType Contingent_Worker_Personal_Info_Get;

		public Get_Contingent_Worker_Personal_InfoInput()
		{
		}

		public Get_Contingent_Worker_Personal_InfoInput(Workday_Common_HeaderType Workday_Common_Header, Contingent_Worker_Personal_Info_GetType Contingent_Worker_Personal_Info_Get)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Contingent_Worker_Personal_Info_Get = Contingent_Worker_Personal_Info_Get;
		}
	}
}
