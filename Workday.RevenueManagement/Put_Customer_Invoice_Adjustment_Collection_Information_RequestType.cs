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
	public class Put_Customer_Invoice_Adjustment_Collection_Information_RequestType : INotifyPropertyChanged
	{
		private Customer_Invoice_AdjustmentObjectType customer_Invoice_Adjustment_ReferenceField;

		private Customer_Invoice_Adjustment_Collection_InformationType[] customer_Invoice_Adjustment_Collection_InformationField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Customer_Invoice_AdjustmentObjectType Customer_Invoice_Adjustment_Reference
		{
			get
			{
				return this.customer_Invoice_Adjustment_ReferenceField;
			}
			set
			{
				this.customer_Invoice_Adjustment_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Invoice_Adjustment_Reference");
			}
		}

		[XmlElement("Customer_Invoice_Adjustment_Collection_Information", Order = 1)]
		public Customer_Invoice_Adjustment_Collection_InformationType[] Customer_Invoice_Adjustment_Collection_Information
		{
			get
			{
				return this.customer_Invoice_Adjustment_Collection_InformationField;
			}
			set
			{
				this.customer_Invoice_Adjustment_Collection_InformationField = value;
				this.RaisePropertyChanged("Customer_Invoice_Adjustment_Collection_Information");
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
