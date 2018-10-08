using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace WorkdayWebServices.Human_ResourcesService
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Provisioning_Group_Assignment_Response_GroupType : INotifyPropertyChanged
	{
		private bool include_ReferenceField;

		private bool include_ReferenceFieldSpecified;

		private bool include_Provisioning_Group_Assignment_DataField;

		private bool include_Provisioning_Group_Assignment_DataFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Include_Reference
		{
			get
			{
				return this.include_ReferenceField;
			}
			set
			{
				this.include_ReferenceField = value;
				this.RaisePropertyChanged("Include_Reference");
			}
		}

		[XmlIgnore]
		public bool Include_ReferenceSpecified
		{
			get
			{
				return this.include_ReferenceFieldSpecified;
			}
			set
			{
				this.include_ReferenceFieldSpecified = value;
				this.RaisePropertyChanged("Include_ReferenceSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Include_Provisioning_Group_Assignment_Data
		{
			get
			{
				return this.include_Provisioning_Group_Assignment_DataField;
			}
			set
			{
				this.include_Provisioning_Group_Assignment_DataField = value;
				this.RaisePropertyChanged("Include_Provisioning_Group_Assignment_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Provisioning_Group_Assignment_DataSpecified
		{
			get
			{
				return this.include_Provisioning_Group_Assignment_DataFieldSpecified;
			}
			set
			{
				this.include_Provisioning_Group_Assignment_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Provisioning_Group_Assignment_DataSpecified");
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