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
	public class Put_Integration_Worktag_Mapping_Source_System_ResponseType : INotifyPropertyChanged
	{
		private Integration_Worktag_Mapping_Source_SystemObjectType integration_Worktag_Mapping_Source_System_ReferenceField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Integration_Worktag_Mapping_Source_SystemObjectType Integration_Worktag_Mapping_Source_System_Reference
		{
			get
			{
				return this.integration_Worktag_Mapping_Source_System_ReferenceField;
			}
			set
			{
				this.integration_Worktag_Mapping_Source_System_ReferenceField = value;
				this.RaisePropertyChanged("Integration_Worktag_Mapping_Source_System_Reference");
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
