using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Payroll_History_Payment_RequestType : INotifyPropertyChanged
	{
		private Payroll_Offcycle_Result_OverrideObjectType payroll_History_Payment_ReferenceField;

		private Payroll_History_Payment_DataType payroll_History_Payment_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Payroll_Offcycle_Result_OverrideObjectType Payroll_History_Payment_Reference
		{
			get
			{
				return this.payroll_History_Payment_ReferenceField;
			}
			set
			{
				this.payroll_History_Payment_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_History_Payment_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Payroll_History_Payment_DataType Payroll_History_Payment_Data
		{
			get
			{
				return this.payroll_History_Payment_DataField;
			}
			set
			{
				this.payroll_History_Payment_DataField = value;
				this.RaisePropertyChanged("Payroll_History_Payment_Data");
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
