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
	public class Customer_RequestType : INotifyPropertyChanged
	{
		private Customer_RequestObjectType customer_Request_ReferenceField;

		private Customer_Request_DataType customer_Request_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Customer_RequestObjectType Customer_Request_Reference
		{
			get
			{
				return this.customer_Request_ReferenceField;
			}
			set
			{
				this.customer_Request_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Request_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Customer_Request_DataType Customer_Request_Data
		{
			get
			{
				return this.customer_Request_DataField;
			}
			set
			{
				this.customer_Request_DataField = value;
				this.RaisePropertyChanged("Customer_Request_Data");
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
