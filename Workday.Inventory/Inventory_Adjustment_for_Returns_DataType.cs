using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Inventory
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Inventory_Adjustment_for_Returns_DataType : INotifyPropertyChanged
	{
		private LocationObjectType inventory_Site_ReferenceField;

		private Inventory_ReturnObjectType inventory_Return_ReferenceField;

		private Inventory_Adjustment_for_Returns_Detail_DataType[] adjustment_for_Returns_Detail_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public LocationObjectType Inventory_Site_Reference
		{
			get
			{
				return this.inventory_Site_ReferenceField;
			}
			set
			{
				this.inventory_Site_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Site_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Inventory_ReturnObjectType Inventory_Return_Reference
		{
			get
			{
				return this.inventory_Return_ReferenceField;
			}
			set
			{
				this.inventory_Return_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Return_Reference");
			}
		}

		[XmlElement("Adjustment_for_Returns_Detail_Data", Order = 2)]
		public Inventory_Adjustment_for_Returns_Detail_DataType[] Adjustment_for_Returns_Detail_Data
		{
			get
			{
				return this.adjustment_for_Returns_Detail_DataField;
			}
			set
			{
				this.adjustment_for_Returns_Detail_DataField = value;
				this.RaisePropertyChanged("Adjustment_for_Returns_Detail_Data");
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
