﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyCinemaPlanner
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class myCinemaPlannerDBEntities : DbContext
    {
        public myCinemaPlannerDBEntities()
            : base("name=myCinemaPlannerDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cashes> Cashes { get; set; }
        public virtual DbSet<Cleaning> Cleaning { get; set; }
        public virtual DbSet<Distributions> Distributions { get; set; }
        public virtual DbSet<Distributors> Distributors { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Movies> Movies { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Rooms> Rooms { get; set; }
        public virtual DbSet<Seance> Seance { get; set; }
        public virtual DbSet<Sellings> Sellings { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<Technicians> Technicians { get; set; }
        public virtual DbSet<Usage> Usage { get; set; }
        public virtual DbSet<Distributors_counted_movies> Distributors_counted_movies { get; set; }
    
        public virtual int AddDistributor(string disName, string disEmail, string disPhone, string disAdress, string zipCode, string disCity, string disCountry)
        {
            var disNameParameter = disName != null ?
                new ObjectParameter("disName", disName) :
                new ObjectParameter("disName", typeof(string));
    
            var disEmailParameter = disEmail != null ?
                new ObjectParameter("disEmail", disEmail) :
                new ObjectParameter("disEmail", typeof(string));
    
            var disPhoneParameter = disPhone != null ?
                new ObjectParameter("disPhone", disPhone) :
                new ObjectParameter("disPhone", typeof(string));
    
            var disAdressParameter = disAdress != null ?
                new ObjectParameter("disAdress", disAdress) :
                new ObjectParameter("disAdress", typeof(string));
    
            var zipCodeParameter = zipCode != null ?
                new ObjectParameter("zipCode", zipCode) :
                new ObjectParameter("zipCode", typeof(string));
    
            var disCityParameter = disCity != null ?
                new ObjectParameter("disCity", disCity) :
                new ObjectParameter("disCity", typeof(string));
    
            var disCountryParameter = disCountry != null ?
                new ObjectParameter("disCountry", disCountry) :
                new ObjectParameter("disCountry", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddDistributor", disNameParameter, disEmailParameter, disPhoneParameter, disAdressParameter, zipCodeParameter, disCityParameter, disCountryParameter);
        }
    
        public virtual int EditDistributor(Nullable<int> id, string disName, string disEmail, string disPhone, string disAdress, string zipCode, string disCity, string disCountry)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var disNameParameter = disName != null ?
                new ObjectParameter("disName", disName) :
                new ObjectParameter("disName", typeof(string));
    
            var disEmailParameter = disEmail != null ?
                new ObjectParameter("disEmail", disEmail) :
                new ObjectParameter("disEmail", typeof(string));
    
            var disPhoneParameter = disPhone != null ?
                new ObjectParameter("disPhone", disPhone) :
                new ObjectParameter("disPhone", typeof(string));
    
            var disAdressParameter = disAdress != null ?
                new ObjectParameter("disAdress", disAdress) :
                new ObjectParameter("disAdress", typeof(string));
    
            var zipCodeParameter = zipCode != null ?
                new ObjectParameter("zipCode", zipCode) :
                new ObjectParameter("zipCode", typeof(string));
    
            var disCityParameter = disCity != null ?
                new ObjectParameter("disCity", disCity) :
                new ObjectParameter("disCity", typeof(string));
    
            var disCountryParameter = disCountry != null ?
                new ObjectParameter("disCountry", disCountry) :
                new ObjectParameter("disCountry", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EditDistributor", idParameter, disNameParameter, disEmailParameter, disPhoneParameter, disAdressParameter, zipCodeParameter, disCityParameter, disCountryParameter);
        }
    
        public virtual int DeleteDistributor(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteDistributor", idParameter);
        }
    
        public virtual int addDistribution(Nullable<int> movieID, Nullable<int> distributorID, string dubb, string sub, Nullable<bool> is3D)
        {
            var movieIDParameter = movieID.HasValue ?
                new ObjectParameter("MovieID", movieID) :
                new ObjectParameter("MovieID", typeof(int));
    
            var distributorIDParameter = distributorID.HasValue ?
                new ObjectParameter("DistributorID", distributorID) :
                new ObjectParameter("DistributorID", typeof(int));
    
            var dubbParameter = dubb != null ?
                new ObjectParameter("Dubb", dubb) :
                new ObjectParameter("Dubb", typeof(string));
    
            var subParameter = sub != null ?
                new ObjectParameter("Sub", sub) :
                new ObjectParameter("Sub", typeof(string));
    
            var is3DParameter = is3D.HasValue ?
                new ObjectParameter("is3D", is3D) :
                new ObjectParameter("is3D", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("addDistribution", movieIDParameter, distributorIDParameter, dubbParameter, subParameter, is3DParameter);
        }
    
        public virtual int deleteDistribution(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteDistribution", idParameter);
        }
    
        public virtual int editDistribution(Nullable<int> id, Nullable<int> movieID, Nullable<int> distributorID, string dubb, string sub, Nullable<bool> is3D)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var movieIDParameter = movieID.HasValue ?
                new ObjectParameter("MovieID", movieID) :
                new ObjectParameter("MovieID", typeof(int));
    
            var distributorIDParameter = distributorID.HasValue ?
                new ObjectParameter("DistributorID", distributorID) :
                new ObjectParameter("DistributorID", typeof(int));
    
            var dubbParameter = dubb != null ?
                new ObjectParameter("Dubb", dubb) :
                new ObjectParameter("Dubb", typeof(string));
    
            var subParameter = sub != null ?
                new ObjectParameter("Sub", sub) :
                new ObjectParameter("Sub", typeof(string));
    
            var is3DParameter = is3D.HasValue ?
                new ObjectParameter("is3D", is3D) :
                new ObjectParameter("is3D", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("editDistribution", idParameter, movieIDParameter, distributorIDParameter, dubbParameter, subParameter, is3DParameter);
        }
    }
}
