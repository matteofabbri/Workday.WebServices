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
	public class Customer_Category_Request_ReferencesType : INotifyPropertyChanged
	{
		private Customer_CategoryObjectType[] customer_Category_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Customer_Category_Reference", Order = 0)]
		public Customer_CategoryObjectType[] Customer_Category_Reference
		{
			get
			{
				return this.customer_Category_ReferenceField;
			}
			set
			{
				this.customer_Category_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Category_Reference");
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
