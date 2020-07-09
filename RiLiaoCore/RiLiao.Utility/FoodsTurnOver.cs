using System;

namespace RiLiao.Utility
{
    // 料理营业额
    public class FoodsTurnOver
    {
        // 料理营业额记录唯一Id, 数据库自增长类型
        public int Id
        {
            get;set;
        }
        // 料理营业额 - 金额
        public double Amount
        {
            get;set;
        }
        // 折扣
        public double Discount
        {
            get;set;
        }
        // 营业额种类唯一Id
        public int TurnOverType
        {
            get;set;
        }
        // 录入人员唯一Id
        public Guid OnwerId
        {
            get;set;
        }
        // 录入时间
        public DateTime CreateTime
        {
            get; set;
        }
    }
}
