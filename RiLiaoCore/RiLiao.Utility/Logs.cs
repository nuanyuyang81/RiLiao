using System;

namespace RiLiao.Utility
{
    // 日志
    public class Logs
    {
        // 日志记录唯一Id, 数据库自增长类型
        public int Id
        {
            get;set;
        }
        // 操作， 如Add / Update / Delete / Search
        public string Action
        {
            get;set;
        }
        // 操作对向，如 DrinksPO / DrinksTurnover / FoodsPO / FoodsTurnover / Vendor / Users...
        public string Table
        {
            get;set;
        }
        // 日志内容
        public string Message
        {
            get;set;
        }
        // 日志记录用户唯一Id
        public Guid OnwerId
        {
            get;set;
        }
        // 日志产生时间
        public DateTime CreateTime
        {
            get;set;
        }
    }
}
