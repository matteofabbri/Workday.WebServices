using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Ad_Hoc_Location_RequestType : INotifyPropertyChanged
	{
		private Student_Recruiting_Event_Ad_Hoc_LocationObjectType ad_Hoc_Location_ReferenceField;

		private Ad_Hoc_Location_DataType ad_Hoc_Location_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_Recruiting_Event_Ad_Hoc_LocationObjectType Ad_Hoc_Location_Reference
		{
			get
			{
				return this.ad_Hoc_Location_ReferenceField;
			}
			set
			{
				this.ad_Hoc_Location_ReferenceField = value;
				this.RaisePropertyChanged("Ad_Hoc_Location_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Ad_Hoc_Location_DataType Ad_Hoc_Location_Data
		{
			get
			{
				return this.ad_Hoc_Location_DataField;
			}
			set
			{
				this.ad_Hoc_Location_DataField = value;
				this.RaisePropertyChanged("Ad_Hoc_Location_Data");
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
