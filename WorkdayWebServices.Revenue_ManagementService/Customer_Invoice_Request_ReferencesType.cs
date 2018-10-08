using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace WorkdayWebServices.Revenue_ManagementService
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Customer_Invoice_Request_ReferencesType : INotifyPropertyChanged
	{
		private Customer_Invoice_DocumentObjectType[] customer_Invoice_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Customer_Invoice_Reference", Order = 0)]
		public Customer_Invoice_DocumentObjectType[] Customer_Invoice_Reference
		{
			get
			{
				return this.customer_Invoice_ReferenceField;
			}
			set
			{
				this.customer_Invoice_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Invoice_Reference");
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