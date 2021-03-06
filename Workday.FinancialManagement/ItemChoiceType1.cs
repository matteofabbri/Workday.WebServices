using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), XmlType(Namespace = "urn:com.workday/bsvc", IncludeInSchema = false)]
	[Serializable]
	public enum ItemChoiceType1
	{
		[XmlEnum("Non-Taxable")]
		NonTaxable,
		Taxable
	}
}
