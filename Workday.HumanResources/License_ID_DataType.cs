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
	public class License_ID_DataType : INotifyPropertyChanged
	{
		private string idField;

		private License_ID_Type__All_ObjectType iD_Type_ReferenceField;

		private CountryObjectType country_ReferenceField;

		private Country_RegionObjectType country_Region_ReferenceField;

		private string country_Region_DescriptorField;

		private AuthorityObjectType authority_ReferenceField;

		private string license_ClassField;

		private DateTime issued_DateField;

		private bool issued_DateFieldSpecified;

		private DateTime expiration_DateField;

		private bool expiration_DateFieldSpecified;

		private DateTime verification_DateField;

		private bool verification_DateFieldSpecified;

		private WorkerObjectType verified_By_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public License_ID_Type__All_ObjectType ID_Type_Reference
		{
			get
			{
				return this.iD_Type_ReferenceField;
			}
			set
			{
				this.iD_Type_ReferenceField = value;
				this.RaisePropertyChanged("ID_Type_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public CountryObjectType Country_Reference
		{
			get
			{
				return this.country_ReferenceField;
			}
			set
			{
				this.country_ReferenceField = value;
				this.RaisePropertyChanged("Country_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Country_RegionObjectType Country_Region_Reference
		{
			get
			{
				return this.country_Region_ReferenceField;
			}
			set
			{
				this.country_Region_ReferenceField = value;
				this.RaisePropertyChanged("Country_Region_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public string Country_Region_Descriptor
		{
			get
			{
				return this.country_Region_DescriptorField;
			}
			set
			{
				this.country_Region_DescriptorField = value;
				this.RaisePropertyChanged("Country_Region_Descriptor");
			}
		}

		[XmlElement(Order = 5)]
		public AuthorityObjectType Authority_Reference
		{
			get
			{
				return this.authority_ReferenceField;
			}
			set
			{
				this.authority_ReferenceField = value;
				this.RaisePropertyChanged("Authority_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public string License_Class
		{
			get
			{
				return this.license_ClassField;
			}
			set
			{
				this.license_ClassField = value;
				this.RaisePropertyChanged("License_Class");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Issued_Date
		{
			get
			{
				return this.issued_DateField;
			}
			set
			{
				this.issued_DateField = value;
				this.RaisePropertyChanged("Issued_Date");
			}
		}

		[XmlIgnore]
		public bool Issued_DateSpecified
		{
			get
			{
				return this.issued_DateFieldSpecified;
			}
			set
			{
				this.issued_DateFieldSpecified = value;
				this.RaisePropertyChanged("Issued_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 8)]
		public DateTime Expiration_Date
		{
			get
			{
				return this.expiration_DateField;
			}
			set
			{
				this.expiration_DateField = value;
				this.RaisePropertyChanged("Expiration_Date");
			}
		}

		[XmlIgnore]
		public bool Expiration_DateSpecified
		{
			get
			{
				return this.expiration_DateFieldSpecified;
			}
			set
			{
				this.expiration_DateFieldSpecified = value;
				this.RaisePropertyChanged("Expiration_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 9)]
		public DateTime Verification_Date
		{
			get
			{
				return this.verification_DateField;
			}
			set
			{
				this.verification_DateField = value;
				this.RaisePropertyChanged("Verification_Date");
			}
		}

		[XmlIgnore]
		public bool Verification_DateSpecified
		{
			get
			{
				return this.verification_DateFieldSpecified;
			}
			set
			{
				this.verification_DateFieldSpecified = value;
				this.RaisePropertyChanged("Verification_DateSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public WorkerObjectType Verified_By_Reference
		{
			get
			{
				return this.verified_By_ReferenceField;
			}
			set
			{
				this.verified_By_ReferenceField = value;
				this.RaisePropertyChanged("Verified_By_Reference");
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
