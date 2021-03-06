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
	public class Work_Schedule_Calendar_Request_ReferencesType : INotifyPropertyChanged
	{
		private Work_Schedule_CalendarObjectType[] work_Schedule_Calendar_Request_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Work_Schedule_Calendar_Request_Reference", Order = 0)]
		public Work_Schedule_CalendarObjectType[] Work_Schedule_Calendar_Request_Reference
		{
			get
			{
				return this.work_Schedule_Calendar_Request_ReferenceField;
			}
			set
			{
				this.work_Schedule_Calendar_Request_ReferenceField = value;
				this.RaisePropertyChanged("Work_Schedule_Calendar_Request_Reference");
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
