﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrderCenter.Data.Service
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PeiSongEntities : DbContext
    {
        public PeiSongEntities()
            : base("name=PeiSongEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<P_CheckApply> P_CheckApply { get; set; }
        public virtual DbSet<P_CompanyRelation> P_CompanyRelation { get; set; }
        public virtual DbSet<P_MenuLvl> P_MenuLvl { get; set; }
        public virtual DbSet<P_MiddleProduct> P_MiddleProduct { get; set; }
        public virtual DbSet<P_Order> P_Order { get; set; }
        public virtual DbSet<P_OrderList> P_OrderList { get; set; }
        public virtual DbSet<P_OrderOtherCost> P_OrderOtherCost { get; set; }
        public virtual DbSet<P_OrderRelation> P_OrderRelation { get; set; }
        public virtual DbSet<P_Person> P_Person { get; set; }
        public virtual DbSet<P_PersonOrderOperate> P_PersonOrderOperate { get; set; }
        public virtual DbSet<P_ProductInfo> P_ProductInfo { get; set; }
        public virtual DbSet<P_RelationApply> P_RelationApply { get; set; }
        public virtual DbSet<P_RoleMenu> P_RoleMenu { get; set; }
        public virtual DbSet<S_AccountApply> S_AccountApply { get; set; }
        public virtual DbSet<S_Company> S_Company { get; set; }
        public virtual DbSet<S_CompanyType> S_CompanyType { get; set; }
        public virtual DbSet<S_File> S_File { get; set; }
        public virtual DbSet<S_Message> S_Message { get; set; }
        public virtual DbSet<S_PayWay> S_PayWay { get; set; }
        public virtual DbSet<S_Product> S_Product { get; set; }
        public virtual DbSet<S_ProductType> S_ProductType { get; set; }
        public virtual DbSet<S_Right> S_Right { get; set; }
        public virtual DbSet<S_Role> S_Role { get; set; }
        public virtual DbSet<S_RoleRight> S_RoleRight { get; set; }
        public virtual DbSet<S_TimeApply> S_TimeApply { get; set; }
        public virtual DbSet<S_TimeApplyDetail> S_TimeApplyDetail { get; set; }
        public virtual DbSet<S_User> S_User { get; set; }
    }
}
