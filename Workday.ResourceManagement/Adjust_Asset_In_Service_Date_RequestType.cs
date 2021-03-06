using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Adjust_Asset_In_Service_Date_RequestType : INotifyPropertyChanged
	{
		private Business_AssetObjectType business_Asset_ReferenceField;

		private Financials_Business_Process_ParametersType business_Process_ParametersField;

		private Business_Asset_In_Service_Date_Update_DataType business_Asset_In_Service_Date_Update_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Business_AssetObjectType Business_Asset_Reference
		{
			get
			{
				return this.business_Asset_ReferenceField;
			}
			set
			{
				this.business_Asset_ReferenceField = value;
				this.RaisePropertyChanged("Business_Asset_Reference");
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
		public Business_Asset_In_Service_Date_Update_DataType Business_Asset_In_Service_Date_Update_Data
		{
			get
			{
				return this.business_Asset_In_Service_Date_Update_DataField;
			}
			set
			{
				this.business_Asset_In_Service_Date_Update_DataField = value;
				this.RaisePropertyChanged("Business_Asset_In_Service_Date_Update_Data");
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
