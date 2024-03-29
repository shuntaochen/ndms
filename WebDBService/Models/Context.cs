﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebDBService.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class JY_NDMSEntities : DbContext
    {
        public JY_NDMSEntities()
            : base("name=JiYun")
        {
        }
    
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
            //throw new UnintentionalCodeFirstException();
        //}
    
        public DbSet<AccidentalMaintenances> AccidentalMaintenances { get; set; }
        public DbSet<AssetInfos> AssetInfos { get; set; }
        public DbSet<AssetOptionalProperties> AssetOptionalProperties { get; set; }
        public DbSet<CabinetInfos> CabinetInfos { get; set; }
        public DbSet<CategoriesAndStatus> CategoriesAndStatus { get; set; }
        public DbSet<EventInfos> EventInfos { get; set; }
        public DbSet<LaborInfos> LaborInfos { get; set; }
        public DbSet<MaintainPlans> MaintainPlans { get; set; }
        public DbSet<MaintainRecords> MaintainRecords { get; set; }
        public DbSet<MaintainRequests> MaintainRequests { get; set; }
        public DbSet<MaintenanceKnowledges> MaintenanceKnowledges { get; set; }
        public DbSet<MerchantInfos> MerchantInfos { get; set; }
        public DbSet<MotorRoomInfos> MotorRoomInfos { get; set; }
        public DbSet<OnDuties> OnDuties { get; set; }
        public DbSet<SharedResources> SharedResources { get; set; }
        public DbSet<TaskDesignateInfos> TaskDesignateInfos { get; set; }
        public DbSet<UserCompanyInfos> UserCompanyInfos { get; set; }
        public DbSet<UserScheduleInfos> UserScheduleInfos { get; set; }
    }
}
