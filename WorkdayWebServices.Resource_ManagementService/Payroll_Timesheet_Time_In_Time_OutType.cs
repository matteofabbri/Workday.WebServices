using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace WorkdayWebServices.Resource_ManagementService
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_Timesheet_Time_In_Time_OutType : INotifyPropertyChanged
	{
		private Payroll_Timesheet_Time_In_Time_OutObjectType payroll_Timesheet_Time_In_Time_Out_ReferenceField;

		private Payroll_Timesheet_Time_In_Time_Out_Data_WWSType payroll_Timesheet_Time_In_Time_Out_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Payroll_Timesheet_Time_In_Time_OutObjectType Payroll_Timesheet_Time_In_Time_Out_Reference
		{
			get
			{
				return this.payroll_Timesheet_Time_In_Time_Out_ReferenceField;
			}
			set
			{
				this.payroll_Timesheet_Time_In_Time_Out_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Timesheet_Time_In_Time_Out_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Payroll_Timesheet_Time_In_Time_Out_Data_WWSType Payroll_Timesheet_Time_In_Time_Out_Data
		{
			get
			{
				return this.payroll_Timesheet_Time_In_Time_Out_DataField;
			}
			set
			{
				this.payroll_Timesheet_Time_In_Time_Out_DataField = value;
				this.RaisePropertyChanged("Payroll_Timesheet_Time_In_Time_Out_Data");
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