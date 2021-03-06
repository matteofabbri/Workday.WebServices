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
	public class Submit_Customer_Contract_Change_Order_RequestType : INotifyPropertyChanged
	{
		private Customer_ContractObjectType customer_Contract_ReferenceField;

		private Customer_Contract_Change_Order_DataType customer_Contract_Change_Order_DataField;

		private Financials_Business_Process_ParametersType business_Process_ParametersField;

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
		public Customer_Contract_Change_Order_DataType Customer_Contract_Change_Order_Data
		{
			get
			{
				return this.customer_Contract_Change_Order_DataField;
			}
			set
			{
				this.customer_Contract_Change_Order_DataField = value;
				this.RaisePropertyChanged("Customer_Contract_Change_Order_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Financials_Business_Process_ParametersType Business_Process_Parameters
		{
			get
			{
				return this.business_Process_ParametersField;
			}
			set
			{
				this.business_Process_ParametersField = value;
				this.RaisePropertyChanged("Business_Process_Parameters");
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
