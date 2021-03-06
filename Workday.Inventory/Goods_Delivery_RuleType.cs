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
	public class Goods_Delivery_RuleType : INotifyPropertyChanged
	{
		private Goods_Delivery_RuleObjectType goods_Delivery_Rule_ReferenceField;

		private Goods_Delivery_Rules_DataType[] goods_Delivery_Rules_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Goods_Delivery_RuleObjectType Goods_Delivery_Rule_Reference
		{
			get
			{
				return this.goods_Delivery_Rule_ReferenceField;
			}
			set
			{
				this.goods_Delivery_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Goods_Delivery_Rule_Reference");
			}
		}

		[XmlElement("Goods_Delivery_Rules_Data", Order = 1)]
		public Goods_Delivery_Rules_DataType[] Goods_Delivery_Rules_Data
		{
			get
			{
				return this.goods_Delivery_Rules_DataField;
			}
			set
			{
				this.goods_Delivery_Rules_DataField = value;
				this.RaisePropertyChanged("Goods_Delivery_Rules_Data");
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
