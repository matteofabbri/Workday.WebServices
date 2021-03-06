using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Business_UnitType : INotifyPropertyChanged
	{
		private Business_UnitObjectType business_Unit_ReferenceField;

		private Business_Unit_DataType[] business_Unit_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Business_UnitObjectType Business_Unit_Reference
		{
			get
			{
				return this.business_Unit_ReferenceField;
			}
			set
			{
				this.business_Unit_ReferenceField = value;
				this.RaisePropertyChanged("Business_Unit_Reference");
			}
		}

		[XmlElement("Business_Unit_Data", Order = 1)]
		public Business_Unit_DataType[] Business_Unit_Data
		{
			get
			{
				return this.business_Unit_DataField;
			}
			set
			{
				this.business_Unit_DataField = value;
				this.RaisePropertyChanged("Business_Unit_Data");
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
