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
	public class Put_Order_Fulfillment_Transaction_RequestType : INotifyPropertyChanged
	{
		private Order_Fulfillment_TransactionObjectType order_Fulfillment_Transaction_ReferenceField;

		private Order_Fulfillment_Transaction_DataType order_Fulfillment_Transaction_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Order_Fulfillment_TransactionObjectType Order_Fulfillment_Transaction_Reference
		{
			get
			{
				return this.order_Fulfillment_Transaction_ReferenceField;
			}
			set
			{
				this.order_Fulfillment_Transaction_ReferenceField = value;
				this.RaisePropertyChanged("Order_Fulfillment_Transaction_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Order_Fulfillment_Transaction_DataType Order_Fulfillment_Transaction_Data
		{
			get
			{
				return this.order_Fulfillment_Transaction_DataField;
			}
			set
			{
				this.order_Fulfillment_Transaction_DataField = value;
				this.RaisePropertyChanged("Order_Fulfillment_Transaction_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Add_Only
		{
			get
			{
				return this.add_OnlyField;
			}
			set
			{
				this.add_OnlyField = value;
				this.RaisePropertyChanged("Add_Only");
			}
		}

		[XmlIgnore]
		public bool Add_OnlySpecified
		{
			get
			{
				return this.add_OnlyFieldSpecified;
			}
			set
			{
				this.add_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Add_OnlySpecified");
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
