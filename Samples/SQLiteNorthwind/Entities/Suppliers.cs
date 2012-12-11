//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5456
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenNETCF.ORM
{
    using System;
    using OpenNETCF.ORM;
    
    
    [Entity(KeyScheme.None)]
    public class Suppliers
    {
        
        private static Suppliers ORM_CreateProxy(OpenNETCF.ORM.FieldAttributeCollection fields, System.Data.IDataReader results)
        {
            var item = new Suppliers();
foreach(var field in fields){
            var value = results[field.Ordinal];
switch(field.FieldName){
case "SupplierID":
            // If this is a TimeSpan, use the commented line below
            // item.SupplierID = (value == DBNull.Value) ? TimeSpan.MinValue; : new TimeSpan((long)value);
            item.SupplierID = (value == DBNull.Value) ? 0 : (long)value;
            break;
case "CompanyName":
            item.CompanyName = (value == DBNull.Value) ? null : (string)value;
            break;
case "ContactName":
            item.ContactName = (value == DBNull.Value) ? null : (string)value;
            break;
case "ContactTitle":
            item.ContactTitle = (value == DBNull.Value) ? null : (string)value;
            break;
case "Address":
            item.Address = (value == DBNull.Value) ? null : (string)value;
            break;
case "City":
            item.City = (value == DBNull.Value) ? null : (string)value;
            break;
case "Region":
            item.Region = (value == DBNull.Value) ? null : (string)value;
            break;
case "PostalCode":
            item.PostalCode = (value == DBNull.Value) ? null : (string)value;
            break;
case "Country":
            item.Country = (value == DBNull.Value) ? null : (string)value;
            break;
case "Phone":
            item.Phone = (value == DBNull.Value) ? null : (string)value;
            break;
case "Fax":
            item.Fax = (value == DBNull.Value) ? null : (string)value;
            break;
case "HomePage":
            item.HomePage = (value == DBNull.Value) ? null : (string)value;
            break;
}
}
            return item;
        }
        
        private long m_supplierid;
        
        private string m_companyname;
        
        private string m_contactname;
        
        private string m_contacttitle;
        
        private string m_address;
        
        private string m_city;
        
        private string m_region;
        
        private string m_postalcode;
        
        private string m_country;
        
        private string m_phone;
        
        private string m_fax;
        
        private string m_homepage;
        
        [Field(IsPrimaryKey=true)]
        public long SupplierID
        {
            get
            {
                return this.m_supplierid;
            }
            set
            {
                this.m_supplierid = value;
            }
        }
        
        [Field(SearchOrder=FieldSearchOrder.Ascending)]
        public string CompanyName
        {
            get
            {
                return this.m_companyname;
            }
            set
            {
                this.m_companyname = value;
            }
        }
        
        [Field()]
        public string ContactName
        {
            get
            {
                return this.m_contactname;
            }
            set
            {
                this.m_contactname = value;
            }
        }
        
        [Field()]
        public string ContactTitle
        {
            get
            {
                return this.m_contacttitle;
            }
            set
            {
                this.m_contacttitle = value;
            }
        }
        
        [Field()]
        public string Address
        {
            get
            {
                return this.m_address;
            }
            set
            {
                this.m_address = value;
            }
        }
        
        [Field()]
        public string City
        {
            get
            {
                return this.m_city;
            }
            set
            {
                this.m_city = value;
            }
        }
        
        [Field()]
        public string Region
        {
            get
            {
                return this.m_region;
            }
            set
            {
                this.m_region = value;
            }
        }
        
        [Field(SearchOrder=FieldSearchOrder.Ascending)]
        public string PostalCode
        {
            get
            {
                return this.m_postalcode;
            }
            set
            {
                this.m_postalcode = value;
            }
        }
        
        [Field()]
        public string Country
        {
            get
            {
                return this.m_country;
            }
            set
            {
                this.m_country = value;
            }
        }
        
        [Field()]
        public string Phone
        {
            get
            {
                return this.m_phone;
            }
            set
            {
                this.m_phone = value;
            }
        }
        
        [Field()]
        public string Fax
        {
            get
            {
                return this.m_fax;
            }
            set
            {
                this.m_fax = value;
            }
        }
        
        [Field()]
        public string HomePage
        {
            get
            {
                return this.m_homepage;
            }
            set
            {
                this.m_homepage = value;
            }
        }
    }
}