using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Update_Academic_Appointment_Sub_ProcessType : INotifyPropertyChanged
	{
		private Business_Sub_Process_ParametersType business_Sub_Process_ParametersField;

		private Update_Academic_Appointment_DataType update_Academic_Appointment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Business_Sub_Process_ParametersType Business_Sub_Process_Parameters
		{
			get
			{
				return this.business_Sub_Process_ParametersField;
			}
			set
			{
				this.business_Sub_Process_ParametersField = value;
				this.RaisePropertyChanged("Business_Sub_Process_Parameters");
			}
		}

		[XmlElement(Order = 1)]
		public Update_Academic_Appointment_DataType Update_Academic_Appointment_Data
		{
			get
			{
				return this.update_Academic_Appointment_DataField;
			}
			set
			{
				this.update_Academic_Appointment_DataField = value;
				this.RaisePropertyChanged("Update_Academic_Appointment_Data");
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
