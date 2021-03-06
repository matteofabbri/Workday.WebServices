using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Revenue_Recognition_ScheduleType : INotifyPropertyChanged
	{
		private Revenue_Recognition_ScheduleObjectType revenue_Recognition_Schedule_ReferenceField;

		private Revenue_Recognition_Schedule_DataType[] revenue_Recognition_Schedule_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Revenue_Recognition_ScheduleObjectType Revenue_Recognition_Schedule_Reference
		{
			get
			{
				return this.revenue_Recognition_Schedule_ReferenceField;
			}
			set
			{
				this.revenue_Recognition_Schedule_ReferenceField = value;
				this.RaisePropertyChanged("Revenue_Recognition_Schedule_Reference");
			}
		}

		[XmlElement("Revenue_Recognition_Schedule_Data", Order = 1)]
		public Revenue_Recognition_Schedule_DataType[] Revenue_Recognition_Schedule_Data
		{
			get
			{
				return this.revenue_Recognition_Schedule_DataField;
			}
			set
			{
				this.revenue_Recognition_Schedule_DataField = value;
				this.RaisePropertyChanged("Revenue_Recognition_Schedule_Data");
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
