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
	public class Employee_Compensation_Salary_Unit_Plan_Assignment_Detail_DataType : INotifyPropertyChanged
	{
		private Compensation_Element_ReferenceType compensation_Element_ReferenceField;

		private Unit_of_Measure_ReferenceType unit_ReferenceField;

		private decimal per_Unit_AmountField;

		private Currency_Reference_DataType currency_ReferenceField;

		private decimal number_of_UnitsField;

		private bool number_of_UnitsFieldSpecified;

		private Frequency_Reference_DataType frequency_ReferenceField;

		private DateTime actual_End_DateField;

		private bool actual_End_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Compensation_Element_ReferenceType Compensation_Element_Reference
		{
			get
			{
				return this.compensation_Element_ReferenceField;
			}
			set
			{
				this.compensation_Element_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Element_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Unit_of_Measure_ReferenceType Unit_Reference
		{
			get
			{
				return this.unit_ReferenceField;
			}
			set
			{
				this.unit_ReferenceField = value;
				this.RaisePropertyChanged("Unit_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Per_Unit_Amount
		{
			get
			{
				return this.per_Unit_AmountField;
			}
			set
			{
				this.per_Unit_AmountField = value;
				this.RaisePropertyChanged("Per_Unit_Amount");
			}
		}

		[XmlElement(Order = 3)]
		public Currency_Reference_DataType Currency_Reference
		{
			get
			{
				return this.currency_ReferenceField;
			}
			set
			{
				this.currency_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Number_of_Units
		{
			get
			{
				return this.number_of_UnitsField;
			}
			set
			{
				this.number_of_UnitsField = value;
				this.RaisePropertyChanged("Number_of_Units");
			}
		}

		[XmlIgnore]
		public bool Number_of_UnitsSpecified
		{
			get
			{
				return this.number_of_UnitsFieldSpecified;
			}
			set
			{
				this.number_of_UnitsFieldSpecified = value;
				this.RaisePropertyChanged("Number_of_UnitsSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public Frequency_Reference_DataType Frequency_Reference
		{
			get
			{
				return this.frequency_ReferenceField;
			}
			set
			{
				this.frequency_ReferenceField = value;
				this.RaisePropertyChanged("Frequency_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Actual_End_Date
		{
			get
			{
				return this.actual_End_DateField;
			}
			set
			{
				this.actual_End_DateField = value;
				this.RaisePropertyChanged("Actual_End_Date");
			}
		}

		[XmlIgnore]
		public bool Actual_End_DateSpecified
		{
			get
			{
				return this.actual_End_DateFieldSpecified;
			}
			set
			{
				this.actual_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Actual_End_DateSpecified");
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
