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
	public class Job_Classification_Group_NewType : INotifyPropertyChanged
	{
		private Job_Classification_GroupObjectType job_Classification_Group_ReferenceField;

		private Job_Classification_Group_Reference_DataType[] job_Classification_Group_Name_DataField;

		private Job_Classification_Group_DataType[] job_Classification_Group_DataField;

		private DateTime as_Of_DateField;

		private bool as_Of_DateFieldSpecified;

		private DateTime as_Of_MomentField;

		private bool as_Of_MomentFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Job_Classification_GroupObjectType Job_Classification_Group_Reference
		{
			get
			{
				return this.job_Classification_Group_ReferenceField;
			}
			set
			{
				this.job_Classification_Group_ReferenceField = value;
				this.RaisePropertyChanged("Job_Classification_Group_Reference");
			}
		}

		[XmlElement("Job_Classification_Group_Name_Data", Order = 1)]
		public Job_Classification_Group_Reference_DataType[] Job_Classification_Group_Name_Data
		{
			get
			{
				return this.job_Classification_Group_Name_DataField;
			}
			set
			{
				this.job_Classification_Group_Name_DataField = value;
				this.RaisePropertyChanged("Job_Classification_Group_Name_Data");
			}
		}

		[XmlElement("Job_Classification_Group_Data", Order = 2)]
		public Job_Classification_Group_DataType[] Job_Classification_Group_Data
		{
			get
			{
				return this.job_Classification_Group_DataField;
			}
			set
			{
				this.job_Classification_Group_DataField = value;
				this.RaisePropertyChanged("Job_Classification_Group_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified, DataType = "date")]
		public DateTime As_Of_Date
		{
			get
			{
				return this.as_Of_DateField;
			}
			set
			{
				this.as_Of_DateField = value;
				this.RaisePropertyChanged("As_Of_Date");
			}
		}

		[XmlIgnore]
		public bool As_Of_DateSpecified
		{
			get
			{
				return this.as_Of_DateFieldSpecified;
			}
			set
			{
				this.as_Of_DateFieldSpecified = value;
				this.RaisePropertyChanged("As_Of_DateSpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public DateTime As_Of_Moment
		{
			get
			{
				return this.as_Of_MomentField;
			}
			set
			{
				this.as_Of_MomentField = value;
				this.RaisePropertyChanged("As_Of_Moment");
			}
		}

		[XmlIgnore]
		public bool As_Of_MomentSpecified
		{
			get
			{
				return this.as_Of_MomentFieldSpecified;
			}
			set
			{
				this.as_Of_MomentFieldSpecified = value;
				this.RaisePropertyChanged("As_Of_MomentSpecified");
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
