using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Professional_Affiliation_Relationship_TypeOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Professional_Affiliation_Relationship_Type_ResponseType Put_Professional_Affiliation_Relationship_Type_Response;

		public Put_Professional_Affiliation_Relationship_TypeOutput()
		{
		}

		public Put_Professional_Affiliation_Relationship_TypeOutput(Put_Professional_Affiliation_Relationship_Type_ResponseType Put_Professional_Affiliation_Relationship_Type_Response)
		{
			this.Put_Professional_Affiliation_Relationship_Type_Response = Put_Professional_Affiliation_Relationship_Type_Response;
		}
	}
}
