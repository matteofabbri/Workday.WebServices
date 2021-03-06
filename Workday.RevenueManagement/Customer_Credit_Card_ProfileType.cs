using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Customer_Credit_Card_ProfileType : INotifyPropertyChanged
	{
		private Customer_Credit_Card_ProfileObjectType merchant_Customer_Profile_ReferenceField;

		private Customer_Credit_Card_Profile_DataType merchant_Customer_Profile_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Customer_Credit_Card_ProfileObjectType Merchant_Customer_Profile_Reference
		{
			get
			{
				return this.merchant_Customer_Profile_ReferenceField;
			}
			set
			{
				this.merchant_Customer_Profile_ReferenceField = value;
				this.RaisePropertyChanged("Merchant_Customer_Profile_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Customer_Credit_Card_Profile_DataType Merchant_Customer_Profile_Data
		{
			get
			{
				return this.merchant_Customer_Profile_DataField;
			}
			set
			{
				this.merchant_Customer_Profile_DataField = value;
				this.RaisePropertyChanged("Merchant_Customer_Profile_Data");
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
