using System;

namespace RiLiao.Utility
{
    // 供应商
    public class Vendor
    {
        // 供应商唯一Id, 数据库自增长类型
        public int Id
        {
            get;set;
        }
        // 供应商 名字
        public string Name
        {
            get;set;
        }
        // 录入人员唯一Id
        public Guid OwnerId
        {
            get;set;
        }
        //备注，描述
        public string Comments
        {
            get;set;
        }
        // 创建时间
        public DateTime CreateTime
        {
            get;set;
        }
        // 最后更新时间
        public DateTime LastUpdateTime
        {
            get;set;
        }
    }
}
