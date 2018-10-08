using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace WorkdayWebServices.PayrollService
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Worker_Tax_Treaties_Request_CriteriaType : INotifyPropertyChanged
	{
		private WorkerObjectType[] worker_ReferenceField;

		private Calendar_YearObjectType tax_Year_ReferenceField;

		private Payroll_Income_CodeObjectType income_Code_ReferenceField;

		private Payroll_Income_Code_SubtypeObjectType income_Code_Subtype_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Worker_Reference", Order = 0)]
		public WorkerObjectType[] Worker_Reference
		{
			get
			{
				return this.worker_ReferenceField;
			}
			set
			{
				this.worker_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Calendar_YearObjectType Tax_Year_Reference
		{
			get
			{
				return this.tax_Year_ReferenceField;
			}
			set
			{
				this.tax_Year_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Year_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Payroll_Income_CodeObjectType Income_Code_Reference
		{
			get
			{
				return this.income_Code_ReferenceField;
			}
			set
			{
				this.income_Code_ReferenceField = value;
				this.RaisePropertyChanged("Income_Code_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Payroll_Income_Code_SubtypeObjectType Income_Code_Subtype_Reference
		{
			get
			{
				return this.income_Code_Subtype_ReferenceField;
			}
			set
			{
				this.income_Code_Subtype_ReferenceField = value;
				this.RaisePropertyChanged("Income_Code_Subtype_Reference");
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