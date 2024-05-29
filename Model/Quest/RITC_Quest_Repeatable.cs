using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RITC_UI.Model
{
    public class RITC_Quest_Repeatable
    {
        public string? id { get; set; }
        public string? name { get; set; }
        public string? side { get; set; }
        public string[]? types { get; set; }
        public int resetTime { get; set; }
        public int numQuests { get; set; }
        public int minPlayerLevel { get; set; }
        public Rewardscaling? rewardScaling { get; set; }
        public Locations? locations { get; set; }
        public Traderwhitelist[]? traderWhitelist { get; set; }
        public Questconfig? questConfig { get; set; }
        public string[]? rewardBaseTypeBlacklist { get; set; }
        public string[]? rewardBlacklist { get; set; }
        public int rewardAmmoStackMinSize { get; set; }
    }

    public class Rewardscaling
    {
        public int[]? levels { get; set; }
        public int[]? experience { get; set; }
        public int[]? roubles { get; set; }
        public int[]? items { get; set; }
        public int[]? reputation { get; set; }
        public float rewardSpread { get; set; }
        public int[]? skillRewardChance { get; set; }
        public int[]? skillPointReward { get; set; }
    }

    public class Locations
    {
        public string[]? any { get; set; }
        public string[]? factory4_day { get; set; }
        public string[]? bigmap { get; set; }
        public string[]? Woods { get; set; }
        public string[]? Shoreline { get; set; }
        public string[]? Interchange { get; set; }
        public string[]? Lighthouse { get; set; }
        public string[]? RezervBase { get; set; }
        public string[]? TarkovStreets { get; set; }
        public string[]? Sandbox { get; set; }
    }

    public class Questconfig
    {
        public Exploration? Exploration { get; set; }
        public Pickup? Pickup { get; set; }
        public Completion? Completion { get; set; }
        public Elimination[]? Elimination { get; set; }
        public Ritccustom? RITCCustom { get; set; }
    }

    public class Exploration
    {
        public string[]? possibleSkillRewards { get; set; }
        public int maxExtracts { get; set; }
        public int maxExtractsWithSpecificExit { get; set; }
        public Specificexits? specificExits { get; set; }
        public Reward[]? rewards { get; set; }
    }

    public class Specificexits
    {
        public int probability { get; set; }
        public string[]? passageRequirementWhitelist { get; set; }
    }

    public class Pickup
    {
        public string[]? possibleSkillRewards { get; set; }
        public Itemtypetofetchwithmaxcount[]? ItemTypeToFetchWithMaxCount { get; set; }
        public string[]? ItemTypesToFetch { get; set; }
        public int maxItemFetchCount { get; set; }
    }

    public class Itemtypetofetchwithmaxcount
    {
        public string? itemType { get; set; }
        public int minPickupCount { get; set; }
        public int maxPickupCount { get; set; }
    }

    public class Completion
    {
        public string[]? possibleSkillRewards { get; set; }
        public int minRequestedAmount { get; set; }
        public int maxRequestedAmount { get; set; }
        public int uniqueItemCount { get; set; }
        public int minRequestedBulletAmount { get; set; }
        public int maxRequestedBulletAmount { get; set; }
        public bool useWhitelist { get; set; }
        public bool useBlacklist { get; set; }
        public Reward[]? rewards { get; set; }
    }

    public class Reward
    {
        public string? Condition { get; set; }
        public string? Type { get; set; }
        public string? Quest { get; set; }
        public int Count { get; set; }
        public string? Name { get; set; }
        public string? Desc { get; set; }
    }

    public class Elimination
    {
        public Levelrange? levelRange { get; set; }
        public string[]? possibleSkillRewards { get; set; }
        public Target[]? targets { get; set; }
        public int bodyPartProb { get; set; }
        public Bodypart[]? bodyParts { get; set; }
        public float specificLocationProb { get; set; }
        public string[]? distLocationBlacklist { get; set; }
        public int distProb { get; set; }
        public int maxDist { get; set; }
        public int minDist { get; set; }
        public int maxKills { get; set; }
        public int minKills { get; set; }
        public int maxBossKills { get; set; }
        public int minBossKills { get; set; }
        public int maxPmcKills { get; set; }
        public int minPmcKills { get; set; }
        public int weaponRequirementProb { get; set; }
        public int weaponCategoryRequirementProb { get; set; }
        public Weaponcategoryrequirement[]? weaponCategoryRequirements { get; set; }
        public Weaponrequirement[]? weaponRequirements { get; set; }
        public Reward[]? rewards { get; set; }
    }

    public class Levelrange
    {
        public int min { get; set; }
        public int max { get; set; }
    }

    public class Target
    {
        public string? key { get; set; }
        public float relativeProbability { get; set; }
        public Data? data { get; set; }
    }

    public class Data
    {
        public bool isBoss { get; set; }
        public bool isPmc { get; set; }
    }

    public class Bodypart
    {
        public string? key { get; set; }
        public float relativeProbability { get; set; }
        public string[]? data { get; set; }
    }

    public class Weaponcategoryrequirement
    {
        public string? key { get; set; }
        public int relativeProbability { get; set; }
        public string[]? data { get; set; }
    }

    public class Weaponrequirement
    {
        public string? key { get; set; }
        public int relativeProbability { get; set; }
        public string[]? data { get; set; }
    }


    public class Traderwhitelist
    {
        public string? traderId { get; set; }
        public string? name { get; set; }
        public string[]? questTypes { get; set; }
        public string[]? rewardBaseWhitelist { get; set; }
        public bool rewardCanBeWeapon { get; set; }
        public int weaponRewardChancePercent { get; set; }
    }

    public class Ritccustom
    {
        public string? name { get; set; }
        public Reward[]? rewards { get; set; }
        public Conds? conds { get; set; }
    }

    public class Conds
    {
        public RITC_Quest_Start? Start { get; set; }
        public RITC_Quest_Finish? Finish { get; set; }
        public RITC_Quest_Fail? Fail { get; set; }
    }
}
