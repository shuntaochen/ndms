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
    
    public partial class MaintainRecords:BaseModel
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public Nullable<System.DateTime> OperateTime { get; set; }
    
    	[ForeignKey("MaintainPlans_ID")]
        public virtual MaintainPlans MaintainPlans { get; set; }
    }
    
}
