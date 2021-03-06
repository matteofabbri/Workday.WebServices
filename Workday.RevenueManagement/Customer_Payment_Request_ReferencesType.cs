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
	public class Customer_Payment_Request_ReferencesType : INotifyPropertyChanged
	{
		private Customer_Payment_for_InvoicesObjectType[] customer_Payment_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Customer_Payment_Reference", Order = 0)]
		public Customer_Payment_for_InvoicesObjectType[] Customer_Payment_Reference
		{
			get
			{
				return this.customer_Payment_ReferenceField;
			}
			set
			{
				this.customer_Payment_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Payment_Reference");
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
