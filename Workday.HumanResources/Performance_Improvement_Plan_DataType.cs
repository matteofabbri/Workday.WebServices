using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Performance_Improvement_Plan_DataType : INotifyPropertyChanged
	{
		private Performance_Improvement_PlanObjectType performance_Improvement_Plan_ReferenceField;

		private Employee_Review_Details_DataType review_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Performance_Improvement_PlanObjectType Performance_Improvement_Plan_Reference
		{
			get
			{
				return this.performance_Improvement_Plan_ReferenceField;
			}
			set
			{
				this.performance_Improvement_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Performance_Improvement_Plan_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Employee_Review_Details_DataType Review_Data
		{
			get
			{
				return this.review_DataField;
			}
			set
			{
				this.review_DataField = value;
				this.RaisePropertyChanged("Review_Data");
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
