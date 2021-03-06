using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), XmlType(Namespace = "urn:com.workday/bsvc", IncludeInSchema = false)]
	[Serializable]
	public enum ItemsChoiceType4
	{
		Excluded_Business_Process_Type_Reference,
		Excluded_Transaction_Log_Type_Reference,
		Included_Transaction_Log_Type_Reference,
		Subscribe_to_all_Business_Processes,
		Subscribe_to_all_Transaction_Types
	}
}
