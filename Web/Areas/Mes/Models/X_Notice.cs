//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web.Areas.Mes.Models
{
    using System;
    using System.Collections.Generic;
	using JiYun.Web.Models;
	using System.ComponentModel.DataAnnotations;
    
    public partial class X_Notice:BaseModel
    {
        public X_Notice()
        {
            this.X_NoticeDetail = new HashSet<X_NoticeDetail>();
        }
    
        public string Title { get; set; }
        public string Content { get; set; }
        public string Sender { get; set; }
        public string AttachmentID { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
    
        public virtual ICollection<X_NoticeDetail> X_NoticeDetail { get; set; }
    }
    
}
