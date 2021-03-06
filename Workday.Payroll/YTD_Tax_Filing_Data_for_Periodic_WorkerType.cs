using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class YTD_Tax_Filing_Data_for_Periodic_WorkerType : INotifyPropertyChanged
	{
		private decimal tax_WithheldField;

		private bool tax_WithheldFieldSpecified;

		private decimal taxable_WagesField;

		private bool taxable_WagesFieldSpecified;

		private decimal subject_WagesField;

		private bool subject_WagesFieldSpecified;

		private decimal gross_AmountField;

		private bool gross_AmountFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Tax_Withheld
		{
			get
			{
				return this.tax_WithheldField;
			}
			set
			{
				this.tax_WithheldField = value;
				this.RaisePropertyChanged("Tax_Withheld");
			}
		}

		[XmlIgnore]
		public bool Tax_WithheldSpecified
		{
			get
			{
				return this.tax_WithheldFieldSpecified;
			}
			set
			{
				this.tax_WithheldFieldSpecified = value;
				this.RaisePropertyChanged("Tax_WithheldSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Taxable_Wages
		{
			get
			{
				return this.taxable_WagesField;
			}
			set
			{
				this.taxable_WagesField = value;
				this.RaisePropertyChanged("Taxable_Wages");
			}
		}

		[XmlIgnore]
		public bool Taxable_WagesSpecified
		{
			get
			{
				return this.taxable_WagesFieldSpecified;
			}
			set
			{
				this.taxable_WagesFieldSpecified = value;
				this.RaisePropertyChanged("Taxable_WagesSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Subject_Wages
		{
			get
			{
				return this.subject_WagesField;
			}
			set
			{
				this.subject_WagesField = value;
				this.RaisePropertyChanged("Subject_Wages");
			}
		}

		[XmlIgnore]
		public bool Subject_WagesSpecified
		{
			get
			{
				return this.subject_WagesFieldSpecified;
			}
			set
			{
				this.subject_WagesFieldSpecified = value;
				this.RaisePropertyChanged("Subject_WagesSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Gross_Amount
		{
			get
			{
				return this.gross_AmountField;
			}
			set
			{
				this.gross_AmountField = value;
				this.RaisePropertyChanged("Gross_Amount");
			}
		}

		[XmlIgnore]
		public bool Gross_AmountSpecified
		{
			get
			{
				return this.gross_AmountFieldSpecified;
			}
			set
			{
				this.gross_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Gross_AmountSpecified");
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
