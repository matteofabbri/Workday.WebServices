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
	public class Facilities_and_Admin_Cost_Rate_Type_TypeType : INotifyPropertyChanged
	{
		private Facilities_and_Admin_Cost_Rate_Type_TypeObjectType facilities_and_Admin_Cost_Rate_Type_Type_ReferenceField;

		private Facilities_and_Admin_Cost_Rate_Type_Type_DataType[] facilities_and_Admin_Cost_Rate_Type_Type_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Facilities_and_Admin_Cost_Rate_Type_TypeObjectType Facilities_and_Admin_Cost_Rate_Type_Type_Reference
		{
			get
			{
				return this.facilities_and_Admin_Cost_Rate_Type_Type_ReferenceField;
			}
			set
			{
				this.facilities_and_Admin_Cost_Rate_Type_Type_ReferenceField = value;
				this.RaisePropertyChanged("Facilities_and_Admin_Cost_Rate_Type_Type_Reference");
			}
		}

		[XmlElement("Facilities_and_Admin_Cost_Rate_Type_Type_Data", Order = 1)]
		public Facilities_and_Admin_Cost_Rate_Type_Type_DataType[] Facilities_and_Admin_Cost_Rate_Type_Type_Data
		{
			get
			{
				return this.facilities_and_Admin_Cost_Rate_Type_Type_DataField;
			}
			set
			{
				this.facilities_and_Admin_Cost_Rate_Type_Type_DataField = value;
				this.RaisePropertyChanged("Facilities_and_Admin_Cost_Rate_Type_Type_Data");
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
