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
	public class Create_Provisioning_Event_Sub_Business_ProcessType : INotifyPropertyChanged
	{
		private Business_Sub_Process_ParametersType business_Sub_Process_ParametersField;

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
