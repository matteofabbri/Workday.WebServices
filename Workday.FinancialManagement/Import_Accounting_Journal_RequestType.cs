using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Import_Accounting_Journal_RequestType : INotifyPropertyChanged
	{
		private Accounting_JournalObjectType accounting_Journal_ReferenceField;

		private Financials_Business_Process_ParametersType business_Process_ParametersField;

		private Accounting_Journal__HV__DataType accounting_Journal_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private bool create_Journal_with_ErrorsField;

		private bool create_Journal_with_ErrorsFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Accounting_JournalObjectType Accounting_Journal_Reference
		{
			get
			{
				return this.accounting_Journal_ReferenceField;
			}
			set
			{
				this.accounting_Journal_ReferenceField = value;
				this.RaisePropertyChanged("Accounting_Journal_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Financials_Business_Process_ParametersType Business_Process_Parameters
		{
			get
			{
				return this.business_Process_ParametersField;
			}
			set
			{
				this.business_Process_ParametersField = value;
				this.RaisePropertyChanged("Business_Process_Parameters");
			}
		}

		[XmlElement(Order = 2)]
		public Accounting_Journal__HV__DataType Accounting_Journal_Data
		{
			get
			{
				return this.accounting_Journal_DataField;
			}
			set
			{
				this.accounting_Journal_DataField = value;
				this.RaisePropertyChanged("Accounting_Journal_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Add_Only
		{
			get
			{
				return this.add_OnlyField;
			}
			set
			{
				this.add_OnlyField = value;
				this.RaisePropertyChanged("Add_Only");
			}
		}

		[XmlIgnore]
		public bool Add_OnlySpecified
		{
			get
			{
				return this.add_OnlyFieldSpecified;
			}
			set
			{
				this.add_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Add_OnlySpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Create_Journal_with_Errors
		{
			get
			{
				return this.create_Journal_with_ErrorsField;
			}
			set
			{
				this.create_Journal_with_ErrorsField = value;
				this.RaisePropertyChanged("Create_Journal_with_Errors");
			}
		}

		[XmlIgnore]
		public bool Create_Journal_with_ErrorsSpecified
		{
			get
			{
				return this.create_Journal_with_ErrorsFieldSpecified;
			}
			set
			{
				this.create_Journal_with_ErrorsFieldSpecified = value;
				this.RaisePropertyChanged("Create_Journal_with_ErrorsSpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
