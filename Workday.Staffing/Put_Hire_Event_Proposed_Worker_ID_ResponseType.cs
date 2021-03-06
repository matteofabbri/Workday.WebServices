using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Hire_Event_Proposed_Worker_ID_ResponseType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType hire_Event_ReferenceField;

		private string worker_IDField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Hire_Event_Reference
		{
			get
			{
				return this.hire_Event_ReferenceField;
			}
			set
			{
				this.hire_Event_ReferenceField = value;
				this.RaisePropertyChanged("Hire_Event_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Worker_ID
		{
			get
			{
				return this.worker_IDField;
			}
			set
			{
				this.worker_IDField = value;
				this.RaisePropertyChanged("Worker_ID");
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
