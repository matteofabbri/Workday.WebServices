using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Review_Development_Area_DataType : INotifyPropertyChanged
	{
		private string development_AreaField;

		private Development_AreaObjectType development_Area_Base_ReferenceField;

		private Manager_Component_Evaluation_DataType manager_Evaluation_DataField;

		private Employee_Component_Evaluation_DataType employee_Evaluation_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Development_Area
		{
			get
			{
				return this.development_AreaField;
			}
			set
			{
				this.development_AreaField = value;
				this.RaisePropertyChanged("Development_Area");
			}
		}

		[XmlElement(Order = 1)]
		public Development_AreaObjectType Development_Area_Base_Reference
		{
			get
			{
				return this.development_Area_Base_ReferenceField;
			}
			set
			{
				this.development_Area_Base_ReferenceField = value;
				this.RaisePropertyChanged("Development_Area_Base_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Manager_Component_Evaluation_DataType Manager_Evaluation_Data
		{
			get
			{
				return this.manager_Evaluation_DataField;
			}
			set
			{
				this.manager_Evaluation_DataField = value;
				this.RaisePropertyChanged("Manager_Evaluation_Data");
			}
		}

		[XmlElement(Order = 3)]
		public Employee_Component_Evaluation_DataType Employee_Evaluation_Data
		{
			get
			{
				return this.employee_Evaluation_DataField;
			}
			set
			{
				this.employee_Evaluation_DataField = value;
				this.RaisePropertyChanged("Employee_Evaluation_Data");
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
