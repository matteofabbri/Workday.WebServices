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
	public class Get_Funding_Source_Rules_ResponseType : INotifyPropertyChanged
	{
		private Funding_Source_RuleObjectType[] request_ReferencesField;

		private Response_FilterType[] response_FilterField;

		private Response_ResultsType[] response_ResultsField;

		private Funding_Source_RuleType[] response_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlArray(Order = 0), XmlArrayItem("Funding_Source_Rule_Reference", typeof(Funding_Source_RuleObjectType), IsNullable = false)]
		public Funding_Source_RuleObjectType[] Request_References
		{
			get
			{
				return this.request_ReferencesField;
			}
			set
			{
				this.request_ReferencesField = value;
				this.RaisePropertyChanged("Request_References");
			}
		}

		[XmlElement("Response_Filter", Order = 1)]
		public Response_FilterType[] Response_Filter
		{
			get
			{
				return this.response_FilterField;
			}
			set
			{
				this.response_FilterField = value;
				this.RaisePropertyChanged("Response_Filter");
			}
		}

		[XmlElement("Response_Results", Order = 2)]
		public Response_ResultsType[] Response_Results
		{
			get
			{
				return this.response_ResultsField;
			}
			set
			{
				this.response_ResultsField = value;
				this.RaisePropertyChanged("Response_Results");
			}
		}

		[XmlArray(Order = 3), XmlArrayItem("Funding_Source_Rule", typeof(Funding_Source_RuleType), IsNullable = false)]
		public Funding_Source_RuleType[] Response_Data
		{
			get
			{
				return this.response_DataField;
			}
			set
			{
				this.response_DataField = value;
				this.RaisePropertyChanged("Response_Data");
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
