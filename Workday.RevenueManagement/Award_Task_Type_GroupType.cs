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
	public class Award_Task_Type_GroupType : INotifyPropertyChanged
	{
		private Award_Task_Type_GroupObjectType award_Task_Type_Group_ReferenceField;

		private Award_Task_Type_Group_DataType[] award_Task_Type_Group_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Award_Task_Type_GroupObjectType Award_Task_Type_Group_Reference
		{
			get
			{
				return this.award_Task_Type_Group_ReferenceField;
			}
			set
			{
				this.award_Task_Type_Group_ReferenceField = value;
				this.RaisePropertyChanged("Award_Task_Type_Group_Reference");
			}
		}

		[XmlElement("Award_Task_Type_Group_Data", Order = 1)]
		public Award_Task_Type_Group_DataType[] Award_Task_Type_Group_Data
		{
			get
			{
				return this.award_Task_Type_Group_DataField;
			}
			set
			{
				this.award_Task_Type_Group_DataField = value;
				this.RaisePropertyChanged("Award_Task_Type_Group_Data");
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
