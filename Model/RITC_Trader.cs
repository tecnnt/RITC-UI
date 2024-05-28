using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RITC_UI.Model
{
    public class RITC_Trader
    {
        public string? _id { get; set; }
        public int balance_dol { get; set; }
        public int balance_eur { get; set; }
        public int balance_rub { get; set; }
        public RITC_Trader_Insurance? insurance { get; set; }
        public RITC_Trader_Insurancelog? insuranceLog { get; set; }
        public int insuranceChance { get; set; }
        public float insuranceMulti { get; set; }
        public int refreshTime { get; set; }
        public RITC_Trader_Items_Buy? items_buy { get; set; }
        public RITC_Trader_Items_Buy_Prohibited? items_buy_prohibited { get; set; }
        public string? location { get; set; }
        public RITC_Trader_Loyaltylevel[]? loyaltyLevels { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public string? nickname { get; set; }
        public RITC_Trader_Repair? repair { get; set; }
        public string[]? sell_category { get; set; }
        public string? surname { get; set; }
    }

    public class RITC_Trader_Insurance
    {
        public bool availability { get; set; }
        public object[]? excluded_category { get; set; }
        public int max_return_hour { get; set; }
        public int max_storage_time { get; set; }
        public int min_payment { get; set; }
        public int min_return_hour { get; set; }
    }

    public class RITC_Trader_Insurancelog
    {
        public string[]? insuranceStart { get; set; }
        public string[]? insuranceFound { get; set; }
        public string[]? insuranceFailed { get; set; }
        public string[]? insuranceFailedLabs { get; set; }
        public string[]? insuranceExpired { get; set; }
        public string[]? insuranceComplete { get; set; }
    }

    public class RITC_Trader_Items_Buy
    {
        public string[]? category { get; set; }
        public object[]? id_list { get; set; }
    }

    public class RITC_Trader_Items_Buy_Prohibited
    {
        public object[]? category { get; set; }
        public object[]? id_list { get; set; }
    }

    public class RITC_Trader_Repair
    {
        public bool availability { get; set; }
        public string? currency { get; set; }
        public int currency_coefficient { get; set; }
        public object[]? excluded_category { get; set; }
        public object[]? excluded_id_list { get; set; }
        public string? quality { get; set; }
    }

    public class RITC_Trader_Loyaltylevel
    {
        public int buy_price_coef { get; set; }
        public int exchange_price_coef { get; set; }
        public int heal_price_coef { get; set; }
        public int insurance_price_coef { get; set; }
        public int minLevel { get; set; }
        public int minSalesSum { get; set; }
        public float minStanding { get; set; }
        public int repair_price_coef { get; set; }
    }

}
