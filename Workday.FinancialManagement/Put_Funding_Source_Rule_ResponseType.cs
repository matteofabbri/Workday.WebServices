using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Funding_Source_Rule_ResponseType : INotifyPropertyChanged
	{
		private Funding_Source_RuleObjectType funding_Source_Rule_ReferenceField;

		private Funding_Source_Rule_DataType[] funding_Source_Rule_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Funding_Source_RuleObjectType Funding_Source_Rule_Reference
		{
			get
			{
				return this.funding_Source_Rule_ReferenceField;
			}
			set
			{
				this.funding_Source_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Funding_Source_Rule_Reference");
			}
		}

		[XmlElement("Funding_Source_Rule_Data", Order = 1)]
		public Funding_Source_Rule_DataType[] Funding_Source_Rule_Data
		{
			get
			{
				return this.funding_Source_Rule_DataField;
			}
			set
			{
				this.funding_Source_Rule_DataField = value;
				this.RaisePropertyChanged("Funding_Source_Rule_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
