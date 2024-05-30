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
        public List<string>? types { get; set; }
        public int resetTime { get; set; }
        public int numQuests { get; set; }
        public int minPlayerLevel { get; set; }
        public RITC_Quest_Repeatable_Rewardscaling? rewardScaling { get; set; }
        public RITC_Quest_Repeatable_Locations? locations { get; set; }
        public List<RITC_Quest_Repeatable_Traderwhitelist>? traderWhitelist { get; set; }
        public RITC_Quest_Repeatable_Questconfig? questConfig { get; set; }
        public List<string>? rewardBaseTypeBlacklist { get; set; }
        public List<string>? rewardBlacklist { get; set; }
        public int rewardAmmoStackMinSize { get; set; }
    }

    public class RITC_Quest_Repeatable_Rewardscaling
    {
        public List<int>? levels { get; set; }
        public List<int>? experience { get; set; }
        public List<int>? roubles { get; set; }
        public List<int>? items { get; set; }
        public List<int>? reputation { get; set; }
        public float rewardSpread { get; set; }
        public List<int>? skillRewardChance { get; set; }
        public List<int>? skillPointReward { get; set; }
    }

    public class RITC_Quest_Repeatable_Locations
    {
        public List<string>? any { get; set; }
        public List<string>? factory4_day { get; set; }
        public List<string>? bigmap { get; set; }
        public List<string>? Woods { get; set; }
        public List<string>? Shoreline { get; set; }
        public List<string>? Interchange { get; set; }
        public List<string>? Lighthouse { get; set; }
        public List<string>? RezervBase { get; set; }
        public List<string>? TarkovStreets { get; set; }
        public List<string>? Sandbox { get; set; }
    }

    public class RITC_Quest_Repeatable_Questconfig
    {
        public RITC_Quest_Repeatable_Exploration? Exploration { get; set; }
        public RITC_Quest_Repeatable_Pickup? Pickup { get; set; }
        public RITC_Quest_Repeatable_Completion? Completion { get; set; }
        public List<RITC_Quest_Repeatable_Elimination>? Elimination { get; set; }
        public RITC_Quest_Repeatable_Ritccustom? RITCCustom { get; set; }
    }

    public class RITC_Quest_Repeatable_Exploration
    {
        public List<string>? possibleSkillRewards { get; set; }
        public int maxExtracts { get; set; }
        public int maxExtractsWithSpecificExit { get; set; }
        public RITC_Quest_Repeatable_Specificexits? specificExits { get; set; }
        public List<RITC_Quest_Reward>? rewards { get; set; }
    }

    public class RITC_Quest_Repeatable_Specificexits
    {
        public int probability { get; set; }
        public List<string>? passageRequirementWhitelist { get; set; }
    }

    public class RITC_Quest_Repeatable_Pickup
    {
        public List<string>? possibleSkillRewards { get; set; }
        public List<RITC_Quest_Repeatable_Itemtypetofetchwithmaxcount>? ItemTypeToFetchWithMaxCount { get; set; }
        public List<string>? ItemTypesToFetch { get; set; }
        public int maxItemFetchCount { get; set; }
    }

    public class RITC_Quest_Repeatable_Itemtypetofetchwithmaxcount
    {
        public string? itemType { get; set; }
        public int minPickupCount { get; set; }
        public int maxPickupCount { get; set; }
    }

    public class RITC_Quest_Repeatable_Completion
    {
        public List<string>? possibleSkillRewards { get; set; }
        public int minRequestedAmount { get; set; }
        public int maxRequestedAmount { get; set; }
        public int uniqueItemCount { get; set; }
        public int minRequestedBulletAmount { get; set; }
        public int maxRequestedBulletAmount { get; set; }
        public bool useWhitelist { get; set; }
        public bool useBlacklist { get; set; }
        public List<RITC_Quest_Reward>? rewards { get; set; }
    }



    public class RITC_Quest_Repeatable_Elimination
    {
        public RITC_Quest_Repeatable_Levelrange? levelRange { get; set; }
        public List<string>? possibleSkillRewards { get; set; }
        public List<RITC_Quest_Repeatable_Target>? targets { get; set; }
        public int bodyPartProb { get; set; }
        public List<RITC_Quest_Repeatable_Bodypart>? bodyParts { get; set; }
        public float specificLocationProb { get; set; }
        public List<string>? distLocationBlacklist { get; set; }
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
        public List<RITC_Quest_Repeatable_Weaponcategoryrequirement>? weaponCategoryRequirements { get; set; }
        public List<RITC_Quest_Repeatable_Weaponrequirement>? weaponRequirements { get; set; }
        public List<RITC_Quest_Reward>? rewards { get; set; }
    }

    public class RITC_Quest_Repeatable_Levelrange
    {
        public int min { get; set; }
        public int max { get; set; }
    }

    public class RITC_Quest_Repeatable_Target
    {
        public string? key { get; set; }
        public float relativeProbability { get; set; }
        public RITC_Quest_Repeatable_TargetData? data { get; set; }
    }

    public class RITC_Quest_Repeatable_TargetData
    {
        public bool isBoss { get; set; }
        public bool isPmc { get; set; }
    }

    public class RITC_Quest_Repeatable_Bodypart
    {
        public string? key { get; set; }
        public float relativeProbability { get; set; }
        public List<string>? data { get; set; }
    }

    public class RITC_Quest_Repeatable_Weaponcategoryrequirement
    {
        public string? key { get; set; }
        public int relativeProbability { get; set; }
        public List<string>? data { get; set; }
    }

    public class RITC_Quest_Repeatable_Weaponrequirement
    {
        public string? key { get; set; }
        public int relativeProbability { get; set; }
        public List<string>? data { get; set; }
    }


    public class RITC_Quest_Repeatable_Traderwhitelist
    {
        public string? traderId { get; set; }
        public string? name { get; set; }
        public List<string>? questTypes { get; set; }
        public List<string>? rewardBaseWhitelist { get; set; }
        public bool rewardCanBeWeapon { get; set; }
        public int weaponRewardChancePercent { get; set; }
    }

    public class RITC_Quest_Repeatable_Ritccustom
    {
        public string? name { get; set; }
        public List<RITC_Quest_Reward>? rewards { get; set; }
        public RITC_Quest_Conditions? conds { get; set; }
    }
}
