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
	public class Customer_Request_Request_CriteriaType : INotifyPropertyChanged
	{
		private string customer_Request_NameField;

		private string customer_Request_IDField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Customer_Request_Name
		{
			get
			{
				return this.customer_Request_NameField;
			}
			set
			{
				this.customer_Request_NameField = value;
				this.RaisePropertyChanged("Customer_Request_Name");
			}
		}

		[XmlElement(Order = 1)]
		public string Customer_Request_ID
		{
			get
			{
				return this.customer_Request_IDField;
			}
			set
			{
				this.customer_Request_IDField = value;
				this.RaisePropertyChanged("Customer_Request_ID");
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