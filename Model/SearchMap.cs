using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace RITC_UI.Model
{
    public static class SearchMap
    {
        public static async Task InitMap()
        {
            await Task.Run(() =>
            {
                var curPath = System.Environment.CurrentDirectory;
                var itemsData = JsonConvert.DeserializeObject<Dictionary<string, ItemMap>>(File.ReadAllText(Path.Combine(curPath, "SearchMap", "ItemsMap.json")));
                if (itemsData != null)
                    Items = itemsData.Values.Where(x => x != null).ToList();
            });
        }

        public static List<ItemMap>? Items { get; set; }

        /// <summary>
        /// 获取单独物品名称
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string SearchItemName(string id)
        {
            return Items?.FirstOrDefault(x => x.ID == id)?.Name ?? "";
        }
    }

    public class ItemMap
    {
        public string? ID { get; set; }
        public string? Name { get; set; }
        public string? ShortName { get; set; }
        public string? Description { get; set; }
    }
}
