//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations.Schema;
	using JiYun.Web.Models;
	using System.ComponentModel.DataAnnotations;
    
    public partial class MaintainPlans:BaseModel
    {
        public MaintainPlans()
        {
            this.MaintainRecords = new HashSet<MaintainRecords>();
            this.MaintainRequests = new HashSet<MaintainRequests>();
        }
    
        public Nullable<int> Creator { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Nullable<int> ExecuteCycle { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public Nullable<int> AssetInfos_ID { get; set; }
        public Nullable<int> MerchantInfos_ID { get; set; }
    
        public virtual ICollection<MaintainRecords> MaintainRecords { get; set; }
        public virtual ICollection<MaintainRequests> MaintainRequests { get; set; }
    }
    
}
