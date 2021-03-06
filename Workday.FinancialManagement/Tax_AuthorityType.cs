using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Tax_AuthorityType : INotifyPropertyChanged
	{
		private Tax_AuthorityObjectType tax_Authority_ReferenceField;

		private Tax_Authority_DataType[] tax_Authority_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Tax_AuthorityObjectType Tax_Authority_Reference
		{
			get
			{
				return this.tax_Authority_ReferenceField;
			}
			set
			{
				this.tax_Authority_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Authority_Reference");
			}
		}

		[XmlElement("Tax_Authority_Data", Order = 1)]
		public Tax_Authority_DataType[] Tax_Authority_Data
		{
			get
			{
				return this.tax_Authority_DataField;
			}
			set
			{
				this.tax_Authority_DataField = value;
				this.RaisePropertyChanged("Tax_Authority_Data");
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
