using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class SubscriptionType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType subscription_ReferenceField;

		private Subscription_DataType subscription_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Subscription_Reference
		{
			get
			{
				return this.subscription_ReferenceField;
			}
			set
			{
				this.subscription_ReferenceField = value;
				this.RaisePropertyChanged("Subscription_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Subscription_DataType Subscription_Data
		{
			get
			{
				return this.subscription_DataField;
			}
			set
			{
				this.subscription_DataField = value;
				this.RaisePropertyChanged("Subscription_Data");
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
