using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RITC_UI.Model
{
    public class RITC_Trader
    {
        public RITC_Trader()
        {
            loyaltyLevels = RITC_Trader_Loyaltylevel.CreateDefault();
        }

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
        public List<RITC_Trader_Loyaltylevel> loyaltyLevels { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public string? nickname { get; set; }
        public RITC_Trader_Repair? repair { get; set; }
        public List<string>? sell_category { get; set; }
        public string? surname { get; set; }
    }

    public class RITC_Trader_Insurance
    {
        public bool availability { get; set; }
        public List<string>? excluded_category { get; set; }
        public int max_return_hour { get; set; }
        public int max_storage_time { get; set; }
        public int min_payment { get; set; }
        public int min_return_hour { get; set; }
    }

    public class RITC_Trader_Insurancelog
    {
        public List<string>? insuranceStart { get; set; }
        public List<string>? insuranceFound { get; set; }
        public List<string>? insuranceFailed { get; set; }
        public List<string>? insuranceFailedLabs { get; set; }
        public List<string>? insuranceExpired { get; set; }
        public List<string>? insuranceComplete { get; set; }
    }

    public class RITC_Trader_Items_Buy
    {
        public List<string>? category { get; set; }
        public List<string>? id_list { get; set; }
    }

    public class RITC_Trader_Items_Buy_Prohibited
    {
        public List<string>? category { get; set; }
        public List<string>? id_list { get; set; }
    }

    public class RITC_Trader_Repair
    {
        public bool availability { get; set; }
        public string? currency { get; set; }
        public int currency_coefficient { get; set; }
        public List<string>? excluded_category { get; set; }
        public List<string>? excluded_id_list { get; set; }
        public string? quality { get; set; }
    }

    public class RITC_Trader_Loyaltylevel
    {
        public RITC_Trader_Loyaltylevel()
        {
            buy_price_coef = 100;
            minLevel = 1;
            repair_price_coef = 100;
            insurance_price_coef = 10;
        }
        public int buy_price_coef { get; set; }
        public int exchange_price_coef { get; set; }
        public int heal_price_coef { get; set; }
        public int insurance_price_coef { get; set; }
        public int minLevel { get; set; }
        public int minSalesSum { get; set; }
        public float minStanding { get; set; }
        public int repair_price_coef { get; set; }

        internal static List<RITC_Trader_Loyaltylevel> CreateDefault()
        {
            var result = new List<RITC_Trader_Loyaltylevel>();
            result.Add(new RITC_Trader_Loyaltylevel());
            result.Add(new RITC_Trader_Loyaltylevel());
            result.Add(new RITC_Trader_Loyaltylevel());
            result.Add(new RITC_Trader_Loyaltylevel());
            return result;
        }
    }

}
