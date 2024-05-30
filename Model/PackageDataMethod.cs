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

namespace RITC_UI.Model
{
    public static partial class PackageData
    {
        /// <summary>
        /// 加载数据
        /// </summary>
        /// <param name="path"></param>
        public static void Load(string path)
        {
            //检查基础结构
            if (!Directory.Exists(path))
                throw new RITC_Exception("扩展包目录不存在！");
            ModelPath = new ModelPathInfo(path);

            //基础信息
            Info = null;
            if (File.Exists(ModelPath.Package))
                Info = JsonConvert.DeserializeObject<RITC_Package>(File.ReadAllText(ModelPath.Package));
            if (Info == null)
                throw new RITC_Exception("基础信息加载失败！");

            //加载本地化
            if (File.Exists(ModelPath.Locale))
            {
                Locale = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(ModelPath.Locale));
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
            //商人信息
            if (Directory.Exists(ModelPath.Traders))
            {
                Traders = new List<RITC_Trader>();
                var files = Directory.GetFiles(ModelPath.Traders);
                foreach (string file in files)
                {
                    var item = JsonConvert.DeserializeObject<RITC_Trader>(File.ReadAllText(file));
                    if (item != null)
                    {
                        FileInfo fileInfo = new FileInfo(file);
                        bool canModify = true;
                        if (!fileInfo.Name.Equals($"{item._id}.json"))
                        {
                            var messageResult = MessageBox.Show("检查到文件名称与商人ID不一致，是否加载？注：加载后将会自动修改文件名称与商人ID一致", "警告！！！！", MessageBoxButton.YesNo);
                            canModify = messageResult == MessageBoxResult.Yes;
                            if (canModify)
                                fileInfo.MoveTo(Path.Combine(ModelPath.Traders, $"{item._id}.json"));
                        }
                        if (canModify) { Traders.Add(item); }
                    }
                }
            }
            //商人报价单
            if (File.Exists(ModelPath.AssortData))
            {
                Assorts = JsonConvert.DeserializeObject<List<RITC_Assort>>(File.ReadAllText(ModelPath.AssortData));
            }
            //任务基础信息
            if (File.Exists(ModelPath.Quest))
            {
                Quests = JsonConvert.DeserializeObject<Dictionary<string, RITC_Quest>>(File.ReadAllText(ModelPath.Quest));
            }
            //任务条件
            if (File.Exists(ModelPath.QuestConditions))
            {
                QuestConditions = JsonConvert.DeserializeObject<Dictionary<string, RITC_Quest_Conditions>>(File.ReadAllText(ModelPath.QuestConditions));
            }
            //任务奖励
            if (File.Exists(ModelPath.QuestReward))
            {
                QuestRewards = JsonConvert.DeserializeObject<List<RITC_Quest_Reward>>(File.ReadAllText(ModelPath.QuestReward));
            }
            //每日任务
            if (File.Exists(ModelPath.QuestRepeatable))
            {
                QuestRepeatable = JsonConvert.DeserializeObject<Dictionary<string, RITC_Quest_Repeatable>>(File.ReadAllText(ModelPath.QuestRepeatable));
            }
            //资源包
            if (File.Exists(ModelPath.Bundles))
            {
                Bundles = JsonConvert.DeserializeObject<RITC_Bundles>(File.ReadAllText(ModelPath.Bundles));
                if (Bundles != null && Bundles.manifest != null)
                    Bundles.manifest.RemoveAll(x => string.IsNullOrEmpty(x.key));
            }
        }

        /// <summary>
        /// 获取商人报价单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<RITC_Assort>? GetTraderAssort(string? traderId)
        {
            List<RITC_Assort>? result = null;
            if (!string.IsNullOrEmpty(traderId))
                result = Assorts?.Where(x => traderId.Equals(x.Trader)).ToList();
            return result;
        }

        /// <summary>
        /// 获取任务条件
        /// </summary>
        /// <param name="questId"></param>
        /// <returns></returns>
        public static RITC_Quest_Conditions? GetQuestConditions(string? questId)
        {
            RITC_Quest_Conditions? result = null;
            if (!string.IsNullOrEmpty(questId))
                QuestConditions?.TryGetValue(questId, out result);
            return result;
        }

        /// <summary>
        /// 获取任务奖励
        /// </summary>
        /// <param name="questId"></param>
        /// <returns></returns>
        public static List<RITC_Quest_Reward>? GetQuestRewards(string? questId)
        {
            List<RITC_Quest_Reward>? result = null;
            if (!string.IsNullOrEmpty(questId))
                result = QuestRewards?.Where(x => questId.Equals(x.Quest)).ToList();
            return result;
        }
    }
}
