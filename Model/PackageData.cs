using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Media3D;

namespace RITC_UI.Model
{
    public partial class PackageData
    {
        /// <summary>
        /// 目录信息
        /// </summary>
        public ModelPathInfo? ModelPath { get; set; }

        /// <summary>
        /// 基础信息
        /// </summary>
        public RITC_Package? Info { get; set; }
        /// <summary>
        /// 物品信息
        /// </summary>
        public List<RITC_Item>? Items { get; set; }

        /// <summary>
        /// 商人信息
        /// </summary>
        public List<RITC_Trader>? Traders { get; set; }

        /// <summary>
        /// 交易信息
        /// </summary>
        public List<RITC_Assort>? Assorts { get; set; }

        /// <summary>
        /// 礼盒（抽卡箱）信息
        /// </summary>
        public Dictionary<string, RITC_Gift>? Gifts { get; set; }

        /// <summary>
        /// 任务信息
        /// </summary>
        public Dictionary<string, RITC_Quest>? Quests { get; set; }
        /// <summary>
        /// 任务描述
        /// </summary>
        public Dictionary<string, RITC_Quest_Desc>? QuestDesc { get; set; }
        /// <summary>
        /// 任务条件
        /// </summary>
        public Dictionary<string, RITC_Quest_Conditions>? QuestConditions { get; set; }
        /// <summary>
        /// 任务奖励
        /// </summary>
        public List<RITC_Quest_Reward>? QuestRewards { get; set; }
        /// <summary>
        /// 每日任务
        /// </summary>
        public Dictionary<string, RITC_Quest_Repeatable>? QuestRepeatable { get; set; }
        /// <summary>
        /// 资源包信息
        /// </summary>
        public RITC_Bundles? Bundles { get; set; }
        /// <summary>
        /// 本地化信息
        /// </summary>
        public Dictionary<string, string>? Locale { get; set; }
    }


    public class ModelPathInfo
    {
        public DirectoryInfo Folder { get; set; }
        public string? Package { get; set; }
        public string? Locale { get; set; }
        public string? Items { get; set; }
        public string? Traders { get; set; }
        public string? AssortData { get; set; }
        public string? Quest { get; set; }
        public string? QuestConditions { get; set; }
        public string? QuestReward { get; set; }
        public string? QuestRepeatable { get; set; }
        public string? QuestDesc { get; set; }
        public string? Bundles { get; set; }
        public string? BundlePackage { get; set; }
        public string? TraderImage { get; set; }
        public string? OtherImage { get; set; }

        public ModelPathInfo(string path)
        {
            Folder = new DirectoryInfo(path);
            Package = Path.Combine(path, "package.json");
            Locale = Path.Combine(path, "res", "locale", "text.json");
            Items = Path.Combine(path, "items", "ritcitem");
            Traders = Path.Combine(path, "traders", "trader");
            AssortData = Path.Combine(path, "traders", "AssortData.json");
            Quest = Path.Combine(path, "traders", "questdata", "initQuest.json");
            QuestConditions = Path.Combine(path, "traders", "questdata", "QuestConditions.json");
            QuestReward = Path.Combine(path, "traders", "questdata", "QuestRewards.json");
            QuestRepeatable = Path.Combine(path, "traders", "questdata", "RepeatableQuests.json");
            QuestDesc = Path.Combine(path, "res", "locale", "quest.json");
            Bundles = Path.Combine(path, "bundles.json");
            BundlePackage = Path.Combine(path, "bundles");
            TraderImage = Path.Combine(path, "res", "avatar");
            OtherImage = Path.Combine(path, "res", "image");
        }
    }
}
