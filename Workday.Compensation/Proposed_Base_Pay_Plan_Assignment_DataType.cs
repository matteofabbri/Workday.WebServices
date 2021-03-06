using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Proposed_Base_Pay_Plan_Assignment_DataType : INotifyPropertyChanged
	{
		private Salary_Pay_PlanObjectType pay_Plan_ReferenceField;

		private decimal itemField;

		private ItemChoiceType4 itemElementNameField;

		private CurrencyObjectType currency_ReferenceField;

		private FrequencyObjectType frequency_ReferenceField;

		private DateTime expected_End_DateField;

		private bool expected_End_DateFieldSpecified;

		private DateTime actual_End_DateField;

		private bool actual_End_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Salary_Pay_PlanObjectType Pay_Plan_Reference
		{
			get
			{
				return this.pay_Plan_ReferenceField;
			}
			set
			{
				this.pay_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Plan_Reference");
			}
		}

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Amount", typeof(decimal), Order = 1), XmlElement("Amount_Change", typeof(decimal), Order = 1), XmlElement("Percent_Change", typeof(decimal), Order = 1)]
		public decimal Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 2), XmlIgnore]
		public ItemChoiceType4 ItemElementName
		{
			get
			{
				return this.itemElementNameField;
			}
			set
			{
				this.itemElementNameField = value;
				this.RaisePropertyChanged("ItemElementName");
			}
		}

		[XmlElement(Order = 3)]
		public CurrencyObjectType Currency_Reference
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
		public FrequencyObjectType Frequency_Reference
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

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Expected_End_Date
		{
			get
			{
				return this.expected_End_DateField;
			}
			set
			{
				this.expected_End_DateField = value;
				this.RaisePropertyChanged("Expected_End_Date");
			}
		}

		[XmlIgnore]
		public bool Expected_End_DateSpecified
		{
			get
			{
				return this.expected_End_DateFieldSpecified;
			}
			set
			{
				this.expected_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Expected_End_DateSpecified");
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
