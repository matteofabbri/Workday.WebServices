using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace WorkdayWebServices.Academic_FoundationService
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Extracurricular_Activity_RequestType : INotifyPropertyChanged
	{
		private Extracurricular_ActivityObjectType extracurricular_Activity_ReferenceField;

		private Extracurricular_Activity_DataType extracurricular_Activity_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Extracurricular_ActivityObjectType Extracurricular_Activity_Reference
		{
			get
			{
				return this.extracurricular_Activity_ReferenceField;
			}
			set
			{
				this.extracurricular_Activity_ReferenceField = value;
				this.RaisePropertyChanged("Extracurricular_Activity_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Extracurricular_Activity_DataType Extracurricular_Activity_Data
		{
			get
			{
				return this.extracurricular_Activity_DataField;
			}
			set
			{
				this.extracurricular_Activity_DataField = value;
				this.RaisePropertyChanged("Extracurricular_Activity_Data");
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