﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFramework_MVCWeb_DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CASQLENBEntities : DbContext
    {
        public CASQLENBEntities()
            : base("name=CASQLENBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Doctor_Fees_Master> Doctor_Fees_Master { get; set; }
        public DbSet<DoctorFeesDetail> DoctorFeesDetails { get; set; }
        public DbSet<DoctorMaster> DoctorMasters { get; set; }
        public DbSet<Fees_Details_for_In_Patients> Fees_Details_for_In_Patients { get; set; }
        public DbSet<Fees_Details_for_Out_Patients> Fees_Details_for_Out_Patients { get; set; }
        public DbSet<PatientDetail> PatientDetails { get; set; }
        public DbSet<PatientMaster> PatientMasters { get; set; }
        public DbSet<Room_Rate_Master> Room_Rate_Master { get; set; }
        public DbSet<RoomMaster> RoomMasters { get; set; }
    }
}
