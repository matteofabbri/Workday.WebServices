using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Edit_Evergreen_Requisition_DataType : INotifyPropertyChanged
	{
		private Evergreen_Job_RequisitionObjectType evergreen_Requisition_ReferenceField;

		private Edit_Evergreen_Requisition_Event_DataType edit_Evergreen_Requisition_Event_DataField;

		private Unpost_Job_Sub_Business_ProcessType unpost_Job_Sub_Business_ProcessField;

		private Post_Job_Sub_Business_ProcessType post_Job_Sub_Business_ProcessField;

		private Assign_Organization_Roles_Sub_Business_ProcessType assign_Organization_Roles_Sub_ProcessField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Evergreen_Job_RequisitionObjectType Evergreen_Requisition_Reference
		{
			get
			{
				return this.evergreen_Requisition_ReferenceField;
			}
			set
			{
				this.evergreen_Requisition_ReferenceField = value;
				this.RaisePropertyChanged("Evergreen_Requisition_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Edit_Evergreen_Requisition_Event_DataType Edit_Evergreen_Requisition_Event_Data
		{
			get
			{
				return this.edit_Evergreen_Requisition_Event_DataField;
			}
			set
			{
				this.edit_Evergreen_Requisition_Event_DataField = value;
				this.RaisePropertyChanged("Edit_Evergreen_Requisition_Event_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Unpost_Job_Sub_Business_ProcessType Unpost_Job_Sub_Business_Process
		{
			get
			{
				return this.unpost_Job_Sub_Business_ProcessField;
			}
			set
			{
				this.unpost_Job_Sub_Business_ProcessField = value;
				this.RaisePropertyChanged("Unpost_Job_Sub_Business_Process");
			}
		}

		[XmlElement(Order = 3)]
		public Post_Job_Sub_Business_ProcessType Post_Job_Sub_Business_Process
		{
			get
			{
				return this.post_Job_Sub_Business_ProcessField;
			}
			set
			{
				this.post_Job_Sub_Business_ProcessField = value;
				this.RaisePropertyChanged("Post_Job_Sub_Business_Process");
			}
		}

		[XmlElement(Order = 4)]
		public Assign_Organization_Roles_Sub_Business_ProcessType Assign_Organization_Roles_Sub_Process
		{
			get
			{
				return this.assign_Organization_Roles_Sub_ProcessField;
			}
			set
			{
				this.assign_Organization_Roles_Sub_ProcessField = value;
				this.RaisePropertyChanged("Assign_Organization_Roles_Sub_Process");
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
