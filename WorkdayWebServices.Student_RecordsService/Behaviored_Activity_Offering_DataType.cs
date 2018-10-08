using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace WorkdayWebServices.Student_RecordsService
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Behaviored_Activity_Offering_DataType : INotifyPropertyChanged
	{
		private string titleField;

		private string abbreviated_TitleField;

		private Activity_BehaviorObjectType[] activity_Behavior_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Title
		{
			get
			{
				return this.titleField;
			}
			set
			{
				this.titleField = value;
				this.RaisePropertyChanged("Title");
			}
		}

		[XmlElement(Order = 1)]
		public string Abbreviated_Title
		{
			get
			{
				return this.abbreviated_TitleField;
			}
			set
			{
				this.abbreviated_TitleField = value;
				this.RaisePropertyChanged("Abbreviated_Title");
			}
		}

		[XmlElement("Activity_Behavior_Reference", Order = 2)]
		public Activity_BehaviorObjectType[] Activity_Behavior_Reference
		{
			get
			{
				return this.activity_Behavior_ReferenceField;
			}
			set
			{
				this.activity_Behavior_ReferenceField = value;
				this.RaisePropertyChanged("Activity_Behavior_Reference");
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