using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Background_Check_Event_DataType : INotifyPropertyChanged
	{
		private EmployeeObjectType employee_ReferenceField;

		private DateTime status_DateField;

		private Background_Check_StatusObjectType status_ReferenceField;

		private string status_CommentField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public EmployeeObjectType Employee_Reference
		{
			get
			{
				return this.employee_ReferenceField;
			}
			set
			{
				this.employee_ReferenceField = value;
				this.RaisePropertyChanged("Employee_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Status_Date
		{
			get
			{
				return this.status_DateField;
			}
			set
			{
				this.status_DateField = value;
				this.RaisePropertyChanged("Status_Date");
			}
		}

		[XmlElement(Order = 2)]
		public Background_Check_StatusObjectType Status_Reference
		{
			get
			{
				return this.status_ReferenceField;
			}
			set
			{
				this.status_ReferenceField = value;
				this.RaisePropertyChanged("Status_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string Status_Comment
		{
			get
			{
				return this.status_CommentField;
			}
			set
			{
				this.status_CommentField = value;
				this.RaisePropertyChanged("Status_Comment");
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
