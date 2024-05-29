using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
    public static class PackageData
    {
        public static void Load(string path)
        {
            //检查基础结构
            if (!Directory.Exists(path))
                throw new RITC_Exception("扩展包目录不存在！");
            ModelPath = new ModelPathInfo(path);

            //基础信息
            if (File.Exists(ModelPath.Package))
            {
                Info = JsonConvert.DeserializeObject<RITC_Package>(File.ReadAllText(ModelPath.Package));
                if (Info == null)
                    throw new RITC_Exception("基础信息加载失败！");
            }
            //物品信息
            if (Directory.Exists(ModelPath.Items))
            {
                Items = new List<RITC_Item>();
                var files = Directory.GetFiles(ModelPath.Items);
                foreach (string file in files)
                {
                    var item = JsonConvert.DeserializeObject<RITC_Item>(File.ReadAllText(file));
                    if (item != null)
                    {
                        FileInfo fileInfo = new FileInfo(file);
                        bool canModify = true;
                        if (!fileInfo.Name.Equals($"{item._id}.json"))
                        {
                            var messageResult = MessageBox.Show("检查到文件名称与道具ID不一致，是否加载？注：加载后将会自动修改文件名称与道具ID一致", "警告！！！！", MessageBoxButton.YesNo);
                            canModify = messageResult == MessageBoxResult.Yes;
                            if (canModify)
                                fileInfo.MoveTo(Path.Combine(ModelPath.Items, $"{item._id}.json"));
                        }
                        if (canModify) { Items.Add(item); }
                    }
                }
            }

        }
        /// <summary>
        /// 目录信息
        /// </summary>
        public static ModelPathInfo? ModelPath { get; set; }

        /// <summary>
        /// 基础信息
        /// </summary>
        public static RITC_Package? Info { get; set; }
        /// <summary>
        /// 物品信息
        /// </summary>
        public static List<RITC_Item>? Items { get; set; }

        /// <summary>
        /// 商人信息
        /// </summary>
        public static List<RITC_Trader>? Traders { get; set; }

        /// <summary>
        /// 交易信息
        /// </summary>
        public static List<RITC_Assort>? Assorts { get; set; }

        /// <summary>
        /// 礼盒（抽卡箱）信息
        /// </summary>
        public static Dictionary<string, RITC_Gift>? Gifts { get; set; }

        /// <summary>
        /// 任务信息
        /// </summary>
        public static Dictionary<string, RITC_Quest>? Quests { get; set; }
        /// <summary>
        /// 任务描述
        /// </summary>
        public static Dictionary<string, RITC_Quest_Desc>? QuestDesc { get; set; }
        /// <summary>
        /// 任务条件
        /// </summary>
        public static Dictionary<string, RITC_Quest_Conditions>? QuestConditions { get; set; }
        /// <summary>
        /// 任务奖励
        /// </summary>
        public static Dictionary<string, RITC_Quest_Reward>? QuestRewards { get; set; }
        /// <summary>
        /// 每日任务
        /// </summary>
        public static Dictionary<string, RITC_Quest_Repeatable>? QuestRepeatable { get; set; }
        /// <summary>
        /// 资源包信息
        /// </summary>
        public static RITC_Bundles? Bundles { get; set; }
        /// <summary>
        /// 本地化信息
        /// </summary>
        public static Dictionary<string, string>? Locale { get; set; }
    }


    public class ModelPathInfo
    {
        public DirectoryInfo? Folder { get; set; }
        public string? Package { get; set; }
        public string? Items { get; internal set; }

        public ModelPathInfo(string path)
        {
            Folder = new DirectoryInfo(path);
            Package = Path.Combine(path, "package.json");
            Items = Path.Combine(path, "items", "ritcitem");
        }
    }
}
