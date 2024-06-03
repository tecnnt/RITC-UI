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
    public partial class PackageData
    {
        /// <summary>
        /// 加载数据
        /// </summary>
        /// <param name="path"></param>
        public static async Task<PackageData> LoadAsync(string path)
        {
            return await Task.Run(() =>
               {
                   PackageData result = new PackageData();
                   //检查基础结构
                   if (!Directory.Exists(path))
                       throw new RITC_Exception("扩展包目录不存在！");
                   var modelPath = new ModelPathInfo(path);

                   result.ModelPath = new ModelPathInfo(path);

                   //基础信息
                   if (File.Exists(modelPath.Package))
                   {
                       var info = JsonConvert.DeserializeObject<RITC_Package>(File.ReadAllText(modelPath.Package));
                       if (info == null)
                           throw new RITC_Exception("基础信息加载失败！");
                       info.pathname = modelPath.Folder.Name;
                       info.Directory = modelPath.Folder.FullName;
                       result.Info = info;
                   }

                   //加载本地化
                   if (File.Exists(modelPath.Locale))
                   {
                       result.Locale = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(modelPath.Locale));
                   }
                   //物品信息
                   if (Directory.Exists(modelPath.Items))
                   {
                       var itemList = new List<RITC_Item>();
                       var files = Directory.GetFiles(modelPath.Items);
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
                                       fileInfo.MoveTo(Path.Combine(modelPath.Items, $"{item._id}.json"));
                               }
                               if (canModify) { itemList.Add(item); }
                           }
                       }
                       result.Items = itemList;
                   }
                   //商人信息
                   if (Directory.Exists(modelPath.Traders))
                   {
                       var traders = new List<RITC_Trader>();
                       var files = Directory.GetFiles(modelPath.Traders);
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
                                       fileInfo.MoveTo(Path.Combine(modelPath.Traders, $"{item._id}.json"));
                               }
                               if (canModify) { traders.Add(item); }
                           }
                       }
                       result.Traders = traders;
                   }
                   //商人报价单
                   if (File.Exists(modelPath.AssortData))
                   {
                       result.Assorts = JsonConvert.DeserializeObject<List<RITC_Assort>>(File.ReadAllText(modelPath.AssortData));
                   }
                   //任务基础信息
                   if (File.Exists(modelPath.Quest))
                   {
                       result.Quests = JsonConvert.DeserializeObject<Dictionary<string, RITC_Quest>>(File.ReadAllText(modelPath.Quest));
                   }
                   //任务条件
                   if (File.Exists(modelPath.QuestConditions))
                   {
                       result.QuestConditions = JsonConvert.DeserializeObject<Dictionary<string, RITC_Quest_Conditions>>(File.ReadAllText(modelPath.QuestConditions));
                   }
                   //任务奖励
                   if (File.Exists(modelPath.QuestReward))
                   {
                       result.QuestRewards = JsonConvert.DeserializeObject<List<RITC_Quest_Reward>>(File.ReadAllText(modelPath.QuestReward));
                   }
                   //每日任务
                   if (File.Exists(modelPath.QuestRepeatable))
                   {
                       result.QuestRepeatable = JsonConvert.DeserializeObject<Dictionary<string, RITC_Quest_Repeatable>>(File.ReadAllText(modelPath.QuestRepeatable));
                   }
                   //资源包
                   if (File.Exists(modelPath.Bundles))
                   {
                       result.Bundles = JsonConvert.DeserializeObject<RITC_Bundles>(File.ReadAllText(modelPath.Bundles));
                       if (result.Bundles != null && result.Bundles.manifest != null)
                           result.Bundles.manifest.RemoveAll(x => string.IsNullOrEmpty(x.key));
                   }
                   return result;
               });
        }

        /// <summary>
        /// 获取商人报价单
        /// </summary>
        /// <param name="traderId"></param>
        /// <returns></returns>
        public List<RITC_Assort>? GetTraderAssort(string? traderId)
        {
            List<RITC_Assort>? result = null;
            if (!string.IsNullOrEmpty(traderId))
                result = Assorts?.Where(x => traderId.Equals(x.Trader)).ToList();
            return result;
        }

        /// <summary>
        /// 获取道具信息
        /// </summary>
        /// <param name="itemId"></param>
        /// <returns></returns>
        public RITC_Item? GetItem(string? itemId)
        {
            RITC_Item? result = null;
            if (!string.IsNullOrEmpty(itemId))
                result = Items?.FirstOrDefault(x => itemId.Equals(x._id));
            return result;
        }

        public RITC_Gift? GetGift(string? giftId)
        {
            RITC_Gift? result = null;
            if (!string.IsNullOrEmpty(giftId))
                Gifts?.TryGetValue(giftId, out result);
            return result;
        }

        /// <summary>
        /// 获取任务条件
        /// </summary>
        /// <param name="questId"></param>
        /// <returns></returns>
        public RITC_Quest_Conditions? GetQuestConditions(string? questId)
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
        public List<RITC_Quest_Reward>? GetQuestRewards(string? questId)
        {
            List<RITC_Quest_Reward>? result = null;
            if (!string.IsNullOrEmpty(questId))
                result = QuestRewards?.Where(x => questId.Equals(x.Quest)).ToList();
            return result;
        }
    }
}
