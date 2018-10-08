using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace WorkdayWebServices.Human_ResourcesService
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Committee_Membership_Targets_Data_SubeditType : INotifyPropertyChanged
	{
		private Committee_Membership_TargetObjectType committee_Membership_Target_ReferenceField;

		private Committee_Membership_TypeObjectType committee_Membership_Type_ReferenceField;

		private decimal target_QuantityField;

		private bool target_QuantityFieldSpecified;

		private bool unlimited_QuantityField;

		private bool unlimited_QuantityFieldSpecified;

		private bool delete_OnlyField;

		private bool delete_OnlyFieldSpecified;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Committee_Membership_TargetObjectType Committee_Membership_Target_Reference
		{
			get
			{
				return this.committee_Membership_Target_ReferenceField;
			}
			set
			{
				this.committee_Membership_Target_ReferenceField = value;
				this.RaisePropertyChanged("Committee_Membership_Target_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Committee_Membership_TypeObjectType Committee_Membership_Type_Reference
		{
			get
			{
				return this.committee_Membership_Type_ReferenceField;
			}
			set
			{
				this.committee_Membership_Type_ReferenceField = value;
				this.RaisePropertyChanged("Committee_Membership_Type_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Target_Quantity
		{
			get
			{
				return this.target_QuantityField;
			}
			set
			{
				this.target_QuantityField = value;
				this.RaisePropertyChanged("Target_Quantity");
			}
		}

		[XmlIgnore]
		public bool Target_QuantitySpecified
		{
			get
			{
				return this.target_QuantityFieldSpecified;
			}
			set
			{
				this.target_QuantityFieldSpecified = value;
				this.RaisePropertyChanged("Target_QuantitySpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Unlimited_Quantity
		{
			get
			{
				return this.unlimited_QuantityField;
			}
			set
			{
				this.unlimited_QuantityField = value;
				this.RaisePropertyChanged("Unlimited_Quantity");
			}
		}

		[XmlIgnore]
		public bool Unlimited_QuantitySpecified
		{
			get
			{
				return this.unlimited_QuantityFieldSpecified;
			}
			set
			{
				this.unlimited_QuantityFieldSpecified = value;
				this.RaisePropertyChanged("Unlimited_QuantitySpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Delete_Only
		{
			get
			{
				return this.delete_OnlyField;
			}
			set
			{
				this.delete_OnlyField = value;
				this.RaisePropertyChanged("Delete_Only");
			}
		}

		[XmlIgnore]
		public bool Delete_OnlySpecified
		{
			get
			{
				return this.delete_OnlyFieldSpecified;
			}
			set
			{
				this.delete_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Delete_OnlySpecified");
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