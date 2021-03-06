﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Adapter
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;    
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    using MM.DataLayer;
    public partial class MyModelContainer : DbContext
    {
        public MyModelContainer()
            : base("name=MyModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<CustomersByCountry_Result> CustomersByCountry(string sCountry)
        {
            var sCountryParameter = sCountry != null ?
                new ObjectParameter("sCountry", sCountry) :
                new ObjectParameter("sCountry", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CustomersByCountry_Result>("CustomersByCountry", sCountryParameter);
        }
    
        public virtual ObjectResult<CustomersWhoBoughtProduct_Result> CustomersWhoBoughtProduct(Nullable<int> nProductId)
        {
            var nProductIdParameter = nProductId.HasValue ?
                new ObjectParameter("nProductId", nProductId) :
                new ObjectParameter("nProductId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CustomersWhoBoughtProduct_Result>("CustomersWhoBoughtProduct", nProductIdParameter);
        }
    }
}
