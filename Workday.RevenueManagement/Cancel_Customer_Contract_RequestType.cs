using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Cancel_Customer_Contract_RequestType : INotifyPropertyChanged
	{
		private Customer_ContractObjectType customer_Contract_ReferenceField;

		private Customer_Contract_Amendment_for_Cancel_DataType customer_Contract_Amendment_for_Cancel_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Customer_ContractObjectType Customer_Contract_Reference
		{
			get
			{
				return this.customer_Contract_ReferenceField;
			}
			set
			{
				this.customer_Contract_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Contract_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Customer_Contract_Amendment_for_Cancel_DataType Customer_Contract_Amendment_for_Cancel_Data
		{
			get
			{
				return this.customer_Contract_Amendment_for_Cancel_DataField;
			}
			set
			{
				this.customer_Contract_Amendment_for_Cancel_DataField = value;
				this.RaisePropertyChanged("Customer_Contract_Amendment_for_Cancel_Data");
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
