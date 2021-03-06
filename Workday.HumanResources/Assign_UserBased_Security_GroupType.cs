using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Assign_User-Based_Security_GroupType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Assign_UserBased_Security_GroupType : INotifyPropertyChanged
	{
		private UserBased_Security_GroupObjectType userBased_Security_Group_ReferenceField;

		private Assign_UserBased_Security_Group_DataType assign_UserBased_Security_Group_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("User-Based_Security_Group_Reference", Order = 0)]
		public UserBased_Security_GroupObjectType UserBased_Security_Group_Reference
		{
			get
			{
				return this.userBased_Security_Group_ReferenceField;
			}
			set
			{
				this.userBased_Security_Group_ReferenceField = value;
				this.RaisePropertyChanged("UserBased_Security_Group_Reference");
			}
		}

		[XmlElement("Assign_User-Based_Security_Group_Data", Order = 1)]
		public Assign_UserBased_Security_Group_DataType Assign_UserBased_Security_Group_Data
		{
			get
			{
				return this.assign_UserBased_Security_Group_DataField;
			}
			set
			{
				this.assign_UserBased_Security_Group_DataField = value;
				this.RaisePropertyChanged("Assign_UserBased_Security_Group_Data");
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
