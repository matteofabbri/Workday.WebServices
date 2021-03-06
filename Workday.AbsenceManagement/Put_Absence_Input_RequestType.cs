using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.AbsenceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Absence_Input_RequestType : INotifyPropertyChanged
	{
		private Absence_InputObjectType absence_Input_ReferenceField;

		private Absence_Input_DataType absence_Input_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Absence_InputObjectType Absence_Input_Reference
		{
			get
			{
				return this.absence_Input_ReferenceField;
			}
			set
			{
				this.absence_Input_ReferenceField = value;
				this.RaisePropertyChanged("Absence_Input_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Absence_Input_DataType Absence_Input_Data
		{
			get
			{
				return this.absence_Input_DataField;
			}
			set
			{
				this.absence_Input_DataField = value;
				this.RaisePropertyChanged("Absence_Input_Data");
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
