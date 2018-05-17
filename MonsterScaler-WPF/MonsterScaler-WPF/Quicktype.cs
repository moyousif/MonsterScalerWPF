// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var monsters = Monsters.FromJson(jsonString);

namespace MonsterScaler_WPF
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using J = Newtonsoft.Json.JsonPropertyAttribute;
    using R = Newtonsoft.Json.Required;
    using N = Newtonsoft.Json.NullValueHandling;

    public partial class Monsters
    {
        [J("Monsters")]
        public MonstersClass MonstersMonsters { get; set; }
    }

    public partial class MonstersClass
    {
        [J("content")]
        public string Content { get; set; }
        [J("Modifying Creatures")]
        public string ModifyingCreatures { get; set; }
        [J("Size")]
        public Size Size { get; set; }
        [J("Type")]
        public TypeClass Type { get; set; }
        [J("Alignment")]
        public Skills Alignment { get; set; }
        [J("Armor Class")]
        public string ArmorClass { get; set; }
        [J("Hit Points")]
        public HitPoints HitPoints { get; set; }
        [J("Speed")]
        public Speed Speed { get; set; }
        [J("Ability Scores")]
        public string AbilityScores { get; set; }
        [J("Saving Throws")]
        public SavingThrows SavingThrows { get; set; }
        [J("Skills")]
        public Skills Skills { get; set; }
        [J("Vulnerabilities, Resistances, and Immunities")]
        public string VulnerabilitiesResistancesAndImmunities { get; set; }
        [J("Senses")]
        public Senses Senses { get; set; }
        [J("Languages")]
        public Languages Languages { get; set; }
        [J("Challenge")]
        public Challenge Challenge { get; set; }
        [J("Special Traits")]
        public SpecialTraits SpecialTraits { get; set; }
        [J("Actions")]
        public Actions Actions { get; set; }
        [J("Reactions")]
        public string Reactions { get; set; }
        [J("Limited Usage")]
        public LimitedUsage LimitedUsage { get; set; }
        [J("Equipment")]
        public Skills Equipment { get; set; }
        [J("Legendary Creatures")]
        public LegendaryCreatures LegendaryCreatures { get; set; }
        [J("Monsters (A)")]
        public MonstersA MonstersA { get; set; }
        [J("Monsters (B)")]
        public MonstersB MonstersB { get; set; }
        [J("Monsters (C)")]
        public MonstersC MonstersC { get; set; }
        [J("Monsters (D)")]
        public MonstersD MonstersD { get; set; }
        [J("Monsters (E)")]
        public MonstersE MonstersE { get; set; }
        [J("Monsters (F)")]
        public MonstersF MonstersF { get; set; }
        [J("Monsters (G)")]
        public MonstersG MonstersG { get; set; }
        [J("Monsters (H)")]
        public MonstersH MonstersH { get; set; }
        [J("Monsters (I)")]
        public MonstersI MonstersI { get; set; }
        [J("Monsters (K)")]
        public MonstersK MonstersK { get; set; }
        [J("Monsters (L)")]
        public MonstersL MonstersL { get; set; }
        [J("Monsters (M)")]
        public MonstersM MonstersM { get; set; }
        [J("Monsters (N)")]
        public MonstersN MonstersN { get; set; }
        [J("Monsters (O)")]
        public MonstersO MonstersO { get; set; }
        [J("Monsters (P)")]
        public MonstersP MonstersP { get; set; }
        [J("Monsters (R)")]
        public MonstersR MonstersR { get; set; }
        [J("Monsters (S)")]
        public MonstersS MonstersS { get; set; }
        [J("Monsters (T)")]
        public MonstersT MonstersT { get; set; }
        [J("Monsters (U)")]
        public MonstersU MonstersU { get; set; }
        [J("Monsters (V)")]
        public MonstersV MonstersV { get; set; }
        [J("Monsters (W)")]
        public MonstersW MonstersW { get; set; }
        [J("Monsters (X)")]
        public MonstersX MonstersX { get; set; }
        [J("Monsters (Z)")]
        public MonstersZ MonstersZ { get; set; }
    }

    public partial class Actions
    {
        [J("content")]
        public string Content { get; set; }
        [J("Melee and Ranged Attacks")]
        public Skills MeleeAndRangedAttacks { get; set; }
        [J("Multiattack")]
        public string Multiattack { get; set; }
        [J("Ammunition")]
        public string Ammunition { get; set; }
    }

    public partial class Skills
    {
        [J("content")]
        public List<string> Content { get; set; }
    }

    public partial class Challenge
    {
        [J("content")]
        public List<string> Content { get; set; }
        [J("Experience Points")]
        public ExperiencePoints ExperiencePoints { get; set; }
    }

    public partial class ExperiencePoints
    {
        [J("content")]
        public List<string> Content { get; set; }
        [J("Experience Points by Challenge Rating")]
        public ExperiencePointsByChallengeRating ExperiencePointsByChallengeRating { get; set; }
    }

    public partial class ExperiencePointsByChallengeRating
    {
        [J("table")]
        public ExperiencePointsByChallengeRatingTable Table { get; set; }
    }

    public partial class ExperiencePointsByChallengeRatingTable
    {
        [J("Challenge")]
        public List<string> Challenge { get; set; }
        [J("XP")]
        public List<string> Xp { get; set; }
    }

    public partial class HitPoints
    {
        [J("content")]
        public List<string> Content { get; set; }
        [J("Hit Dice by Size")]
        public HitDiceBySize HitDiceBySize { get; set; }
    }

    public partial class HitDiceBySize
    {
        [J("content")]
        public List<dynamic> Content { get; set; }
    }

    public partial class PurpleContent
    {
        [J("table")]
        public PurpleTable Table { get; set; }
    }

    public partial class PurpleTable
    {
        [J("Monster Size")]
        public List<string> MonsterSize { get; set; }
        [J("Hit Die")]
        public List<string> HitDie { get; set; }
        [J("Average HP per Die")]
        public List<string> AverageHpPerDie { get; set; }
    }

    public partial class Languages
    {
        [J("content")]
        public string Content { get; set; }
        [J("Telepathy")]
        public Skills Telepathy { get; set; }
    }

    public partial class LegendaryCreatures
    {
        [J("content")]
        public List<string> Content { get; set; }
        [J("Legendary Actions")]
        public string LegendaryActions { get; set; }
        [J("A Legendary Creature’s Lair")]
        public ALegendaryCreaturesLair ALegendaryCreaturesLair { get; set; }
    }

    public partial class ALegendaryCreaturesLair
    {
        [J("content")]
        public string Content { get; set; }
        [J("Lair Actions")]
        public string LairActions { get; set; }
        [J("Regional Effects")]
        public string RegionalEffects { get; set; }
    }

    public partial class LimitedUsage
    {
        [J("content")]
        public List<string> Content { get; set; }
        [J("Grapple Rules for Monsters")]
        public Skills GrappleRulesForMonsters { get; set; }
    }

    public partial class MonstersA
    {
        [J("Aboleth")]
        public BimtehkaYellowjacket Aboleth { get; set; }
        [J("Angels")]
        public Angels Angels { get; set; }
        [J("Animated Objects")]
        public AnimatedObjects AnimatedObjects { get; set; }
    }

    public partial class BimtehkaYellowjacket
    {
        [J("content")]
        public List<dynamic> Content { get; set; }
    }

    public partial class FluffyContent
    {
        [J("table")]
        public FluffyTable Table { get; set; }
    }

    public partial class FluffyTable
    {
        [J("STR")]
        public List<string> Str { get; set; }
        [J("DEX")]
        public List<string> Dex { get; set; }
        [J("CON")]
        public List<string> Con { get; set; }
        [J("INT")]
        public List<string> Int { get; set; }
        [J("WIS")]
        public List<string> Wis { get; set; }
        [J("CHA")]
        public List<string> Cha { get; set; }
    }

    public partial class Angels
    {
        [J("Deva")]
        public BimtehkaYellowjacket Deva { get; set; }
        [J("Planetar")]
        public BimtehkaYellowjacket Planetar { get; set; }
        [J("Solar")]
        public BimtehkaYellowjacket Solar { get; set; }
    }

    public partial class AnimatedObjects
    {
        [J("Animated Armor")]
        public BimtehkaYellowjacket AnimatedArmor { get; set; }
        [J("Flying Sword")]
        public BimtehkaYellowjacket FlyingSword { get; set; }
        [J("Rug of Smothering")]
        public BimtehkaYellowjacket RugOfSmothering { get; set; }
        [J("Ankheg")]
        public BimtehkaYellowjacket Ankheg { get; set; }
        [J("Azer")]
        public BimtehkaYellowjacket Azer { get; set; }
    }

    public partial class MonstersB
    {
        [J("Basilisk")]
        public BimtehkaYellowjacket Basilisk { get; set; }
        [J("Behir")]
        public BimtehkaYellowjacket Behir { get; set; }
        [J("Bugbear")]
        public BimtehkaYellowjacket Bugbear { get; set; }
        [J("Bulette")]
        public BimtehkaYellowjacket Bulette { get; set; }
    }

    public partial class MonstersC
    {
        [J("Centaur")]
        public BimtehkaYellowjacket Centaur { get; set; }
        [J("Chimera")]
        public BimtehkaYellowjacket Chimera { get; set; }
        [J("Chuul")]
        public BimtehkaYellowjacket Chuul { get; set; }
        [J("Cloaker")]
        public BimtehkaYellowjacket Cloaker { get; set; }
        [J("Cockatrice")]
        public BimtehkaYellowjacket Cockatrice { get; set; }
        [J("Couatl")]
        public BimtehkaYellowjacket Couatl { get; set; }
    }

    public partial class MonstersD
    {
        [J("Darkmantle")]
        public BimtehkaYellowjacket Darkmantle { get; set; }
        [J("Demons")]
        public Demons Demons { get; set; }
        [J("Devils")]
        public Devils Devils { get; set; }
        [J("Dinosaurs")]
        public Dinosaurs Dinosaurs { get; set; }
        [J("Dragons, Chromatic")]
        public DragonsChromatic DragonsChromatic { get; set; }
        [J("Dragons, Metallic")]
        public DragonsMetallic DragonsMetallic { get; set; }
    }

    public partial class Demons
    {
        [J("Balor")]
        public BimtehkaYellowjacket Balor { get; set; }
        [J("Dretch")]
        public BimtehkaYellowjacket Dretch { get; set; }
        [J("Glabrezu")]
        public BimtehkaYellowjacket Glabrezu { get; set; }
        [J("Hezrou")]
        public BimtehkaYellowjacket Hezrou { get; set; }
        [J("Marilith")]
        public BimtehkaYellowjacket Marilith { get; set; }
        [J("Nalfeshnee")]
        public BimtehkaYellowjacket Nalfeshnee { get; set; }
        [J("Quasit")]
        public BimtehkaYellowjacket Quasit { get; set; }
        [J("Vrock")]
        public BimtehkaYellowjacket Vrock { get; set; }
    }

    public partial class Devils
    {
        [J("Barbed Devil")]
        public BimtehkaYellowjacket BarbedDevil { get; set; }
        [J("Bearded Devil")]
        public BimtehkaYellowjacket BeardedDevil { get; set; }
        [J("Bone Devil")]
        public BimtehkaYellowjacket BoneDevil { get; set; }
        [J("Chain Devil")]
        public BimtehkaYellowjacket ChainDevil { get; set; }
        [J("Erinyes")]
        public BimtehkaYellowjacket Erinyes { get; set; }
        [J("Horned Devil")]
        public BimtehkaYellowjacket HornedDevil { get; set; }
        [J("Ice Devil")]
        public BimtehkaYellowjacket IceDevil { get; set; }
        [J("Imp")]
        public BimtehkaYellowjacket Imp { get; set; }
        [J("Lemure")]
        public BimtehkaYellowjacket Lemure { get; set; }
        [J("Pit Fiend")]
        public BimtehkaYellowjacket PitFiend { get; set; }
    }

    public partial class Dinosaurs
    {
        [J("Plesiosaurus")]
        public BimtehkaYellowjacket Plesiosaurus { get; set; }
        [J("Triceratops")]
        public BimtehkaYellowjacket Triceratops { get; set; }
        [J("Tyrannosaurus Rex")]
        public BimtehkaYellowjacket TyrannosaurusRex { get; set; }
        [J("Doppelganger")]
        public BimtehkaYellowjacket Doppelganger { get; set; }
    }

    public partial class DragonsChromatic
    {
        [J("Black Dragon")]
        public BlackDragon BlackDragon { get; set; }
        [J("Blue Dragon")]
        public BlueDragon BlueDragon { get; set; }
        [J("Green Dragon")]
        public GreenDragon GreenDragon { get; set; }
        [J("Red Dragon")]
        public RedDragon RedDragon { get; set; }
        [J("White Dragon")]
        public WhiteDragon WhiteDragon { get; set; }
    }

    public partial class BlackDragon
    {
        [J("Ancient Black Dragon")]
        public BimtehkaYellowjacket AncientBlackDragon { get; set; }
        [J("Adult Black Dragon")]
        public BimtehkaYellowjacket AdultBlackDragon { get; set; }
        [J("Young Black Dragon")]
        public BimtehkaYellowjacket YoungBlackDragon { get; set; }
        [J("Black Dragon Wyrmling")]
        public BimtehkaYellowjacket BlackDragonWyrmling { get; set; }
    }

    public partial class BlueDragon
    {
        [J("Ancient Blue Dragon")]
        public BimtehkaYellowjacket AncientBlueDragon { get; set; }
        [J("Adult Blue Dragon")]
        public BimtehkaYellowjacket AdultBlueDragon { get; set; }
        [J("Young Blue Dragon")]
        public BimtehkaYellowjacket YoungBlueDragon { get; set; }
        [J("Blue Dragon Wyrmling")]
        public BimtehkaYellowjacket BlueDragonWyrmling { get; set; }
    }

    public partial class GreenDragon
    {
        [J("Ancient Green Dragon")]
        public BimtehkaYellowjacket AncientGreenDragon { get; set; }
        [J("Adult Green Dragon")]
        public BimtehkaYellowjacket AdultGreenDragon { get; set; }
        [J("Young Green Dragon")]
        public BimtehkaYellowjacket YoungGreenDragon { get; set; }
        [J("Green Dragon Wyrmling")]
        public BimtehkaYellowjacket GreenDragonWyrmling { get; set; }
    }

    public partial class RedDragon
    {
        [J("Ancient Red Dragon")]
        public BimtehkaYellowjacket AncientRedDragon { get; set; }
        [J("Adult Red Dragon")]
        public BimtehkaYellowjacket AdultRedDragon { get; set; }
        [J("Young Red Dragon")]
        public BimtehkaYellowjacket YoungRedDragon { get; set; }
        [J("Red Dragon Wyrmling")]
        public BimtehkaYellowjacket RedDragonWyrmling { get; set; }
    }

    public partial class WhiteDragon
    {
        [J("Ancient White Dragon")]
        public BimtehkaYellowjacket AncientWhiteDragon { get; set; }
        [J("Adult White Dragon")]
        public BimtehkaYellowjacket AdultWhiteDragon { get; set; }
        [J("Young White Dragon")]
        public BimtehkaYellowjacket YoungWhiteDragon { get; set; }
        [J("White Dragon Wyrmling")]
        public BimtehkaYellowjacket WhiteDragonWyrmling { get; set; }
    }

    public partial class DragonsMetallic
    {
        [J("Brass Dragon")]
        public BrassDragon BrassDragon { get; set; }
        [J("Bronze Dragon")]
        public BronzeDragon BronzeDragon { get; set; }
        [J("Copper Dragon")]
        public CopperDragon CopperDragon { get; set; }
        [J("Gold Dragon")]
        public GoldDragon GoldDragon { get; set; }
        [J("Silver Dragon")]
        public SilverDragon SilverDragon { get; set; }
        [J("Dragon Turtle")]
        public BimtehkaYellowjacket DragonTurtle { get; set; }
        [J("Drider")]
        public BimtehkaYellowjacket Drider { get; set; }
        [J("Dryad")]
        public BimtehkaYellowjacket Dryad { get; set; }
        [J("Duergar")]
        public BimtehkaYellowjacket Duergar { get; set; }
    }

    public partial class BrassDragon
    {
        [J("Ancient Brass Dragon")]
        public BimtehkaYellowjacket AncientBrassDragon { get; set; }
        [J("Adult Brass Dragon")]
        public BimtehkaYellowjacket AdultBrassDragon { get; set; }
        [J("Young Brass Dragon")]
        public BimtehkaYellowjacket YoungBrassDragon { get; set; }
        [J("Brass Dragon Wyrmling")]
        public BimtehkaYellowjacket BrassDragonWyrmling { get; set; }
    }

    public partial class BronzeDragon
    {
        [J("Ancient Bronze Dragon")]
        public BimtehkaYellowjacket AncientBronzeDragon { get; set; }
        [J("Adult Bronze Dragon")]
        public BimtehkaYellowjacket AdultBronzeDragon { get; set; }
        [J("Young Bronze Dragon")]
        public BimtehkaYellowjacket YoungBronzeDragon { get; set; }
        [J("Bronze Dragon Wyrmling")]
        public BimtehkaYellowjacket BronzeDragonWyrmling { get; set; }
    }

    public partial class CopperDragon
    {
        [J("Ancient Copper Dragon")]
        public BimtehkaYellowjacket AncientCopperDragon { get; set; }
        [J("Adult Copper Dragon")]
        public BimtehkaYellowjacket AdultCopperDragon { get; set; }
        [J("Young Copper Dragon")]
        public BimtehkaYellowjacket YoungCopperDragon { get; set; }
        [J("Copper Dragon Wyrmling")]
        public BimtehkaYellowjacket CopperDragonWyrmling { get; set; }
    }

    public partial class GoldDragon
    {
        [J("Ancient Gold Dragon")]
        public BimtehkaYellowjacket AncientGoldDragon { get; set; }
        [J("Adult Gold Dragon")]
        public BimtehkaYellowjacket AdultGoldDragon { get; set; }
        [J("Young Gold Dragon")]
        public BimtehkaYellowjacket YoungGoldDragon { get; set; }
        [J("Gold Dragon Wyrmling")]
        public BimtehkaYellowjacket GoldDragonWyrmling { get; set; }
    }

    public partial class SilverDragon
    {
        [J("Ancient Silver Dragon")]
        public BimtehkaYellowjacket AncientSilverDragon { get; set; }
        [J("Adult Silver Dragon")]
        public BimtehkaYellowjacket AdultSilverDragon { get; set; }
        [J("Young Silver Dragon")]
        public BimtehkaYellowjacket YoungSilverDragon { get; set; }
        [J("Silver Dragon Wyrmling")]
        public BimtehkaYellowjacket SilverDragonWyrmling { get; set; }
    }

    public partial class MonstersE
    {
        [J("Elementals")]
        public Elementals Elementals { get; set; }
        [J("Elf, Drow")]
        public BimtehkaYellowjacket ElfDrow { get; set; }
        [J("Ettercap")]
        public BimtehkaYellowjacket Ettercap { get; set; }
        [J("Ettin")]
        public BimtehkaYellowjacket Ettin { get; set; }
    }

    public partial class Elementals
    {
        [J("Air Elemental")]
        public BimtehkaYellowjacket AirElemental { get; set; }
        [J("Earth Elemental")]
        public BimtehkaYellowjacket EarthElemental { get; set; }
        [J("Fire Elemental")]
        public BimtehkaYellowjacket FireElemental { get; set; }
        [J("Water Elemental")]
        public WaterElemental WaterElemental { get; set; }
    }

    public partial class WaterElemental
    {
        [J("content")]
        public List<dynamic> Content { get; set; }
    }

    public partial class MonstersF
    {
        [J("Fungi")]
        public Fungi Fungi { get; set; }
    }

    public partial class Fungi
    {
        [J("Shrieker")]
        public BimtehkaYellowjacket Shrieker { get; set; }
        [J("Violet Fungus")]
        public BimtehkaYellowjacket VioletFungus { get; set; }
    }

    public partial class MonstersG
    {
        [J("Gargoyle")]
        public BimtehkaYellowjacket Gargoyle { get; set; }
        [J("Genies")]
        public Genies Genies { get; set; }
        [J("Ghost")]
        public BimtehkaYellowjacket Ghost { get; set; }
        [J("Ghouls")]
        public Ghouls Ghouls { get; set; }
        [J("Giants")]
        public Giants Giants { get; set; }
        [J("Gibbering Mouther")]
        public BimtehkaYellowjacket GibberingMouther { get; set; }
        [J("Gnoll")]
        public BimtehkaYellowjacket Gnoll { get; set; }
        [J("Gnome, Deep (Svirfneblin)")]
        public BimtehkaYellowjacket GnomeDeepSvirfneblin { get; set; }
        [J("Goblin")]
        public BimtehkaYellowjacket Goblin { get; set; }
        [J("Golems")]
        public Golems Golems { get; set; }
        [J("Gorgon")]
        public BimtehkaYellowjacket Gorgon { get; set; }
        [J("Grick")]
        public BimtehkaYellowjacket Grick { get; set; }
        [J("Griffon")]
        public BimtehkaYellowjacket Griffon { get; set; }
        [J("Grimlock")]
        public BimtehkaYellowjacket Grimlock { get; set; }
    }

    public partial class Genies
    {
        [J("Djinni")]
        public BimtehkaYellowjacket Djinni { get; set; }
        [J("Efreeti")]
        public BimtehkaYellowjacket Efreeti { get; set; }
    }

    public partial class Ghouls
    {
        [J("Ghast")]
        public BimtehkaYellowjacket Ghast { get; set; }
        [J("Ghoul")]
        public BimtehkaYellowjacket Ghoul { get; set; }
    }

    public partial class Giants
    {
        [J("Cloud Giant")]
        public BimtehkaYellowjacket CloudGiant { get; set; }
        [J("Fire Giant")]
        public BimtehkaYellowjacket FireGiant { get; set; }
        [J("Frost Giant")]
        public BimtehkaYellowjacket FrostGiant { get; set; }
        [J("Hill Giant")]
        public BimtehkaYellowjacket HillGiant { get; set; }
        [J("Stone Giant")]
        public BimtehkaYellowjacket StoneGiant { get; set; }
        [J("Storm Giant")]
        public BimtehkaYellowjacket StormGiant { get; set; }
    }

    public partial class Golems
    {
        [J("Clay Golem")]
        public BimtehkaYellowjacket ClayGolem { get; set; }
        [J("Flesh Golem")]
        public BimtehkaYellowjacket FleshGolem { get; set; }
        [J("Iron Golem")]
        public BimtehkaYellowjacket IronGolem { get; set; }
        [J("Stone Golem")]
        public BimtehkaYellowjacket StoneGolem { get; set; }
    }

    public partial class MonstersH
    {
        [J("Hags")]
        public Hags Hags { get; set; }
        [J("Half-Dragon Template")]
        public HalfDragonTemplate HalfDragonTemplate { get; set; }
        [J("Harpy")]
        public BimtehkaYellowjacket Harpy { get; set; }
        [J("Hell Hound")]
        public BimtehkaYellowjacket HellHound { get; set; }
        [J("Hippogriff")]
        public BimtehkaYellowjacket Hippogriff { get; set; }
        [J("Hobgoblin")]
        public BimtehkaYellowjacket Hobgoblin { get; set; }
        [J("Homunculus")]
        public BimtehkaYellowjacket Homunculus { get; set; }
        [J("Hydra")]
        public BimtehkaYellowjacket Hydra { get; set; }
    }

    public partial class Hags
    {
        [J("Green Hag")]
        public BimtehkaYellowjacket GreenHag { get; set; }
        [J("Night Hag")]
        public BimtehkaYellowjacket NightHag { get; set; }
        [J("Sea Hag")]
        public BimtehkaYellowjacket SeaHag { get; set; }
    }

    public partial class HalfDragonTemplate
    {
        [J("content")]
        public List<dynamic> Content { get; set; }
        [J("Half-Red Dragon Veteran")]
        public BimtehkaYellowjacket HalfRedDragonVeteran { get; set; }
    }

    public partial class TentacledContent
    {
        [J("table")]
        public TentacledTable Table { get; set; }
    }

    public partial class TentacledTable
    {
        [J("Color", NullValueHandling = N.Ignore)]
        public List<string> Color { get; set; }
        [J("Damage Resistance", NullValueHandling = N.Ignore)]
        public List<string> DamageResistance { get; set; }
        [J("Size", NullValueHandling = N.Ignore)]
        public List<string> Size { get; set; }
        [J("Breath Weapon", NullValueHandling = N.Ignore)]
        public List<string> BreathWeapon { get; set; }
        [J("Optional Prerequisite", NullValueHandling = N.Ignore)]
        public List<string> OptionalPrerequisite { get; set; }
    }

    public partial class MonstersI
    {
        [J("Invisible Stalker")]
        public BimtehkaYellowjacket InvisibleStalker { get; set; }
    }

    public partial class MonstersK
    {
        [J("Kobold")]
        public BimtehkaYellowjacket Kobold { get; set; }
        [J("Kraken")]
        public BimtehkaYellowjacket Kraken { get; set; }
    }

    public partial class MonstersL
    {
        [J("Lamia")]
        public BimtehkaYellowjacket Lamia { get; set; }
        [J("Lich")]
        public BimtehkaYellowjacket Lich { get; set; }
        [J("Lizardfolk")]
        public BimtehkaYellowjacket Lizardfolk { get; set; }
        [J("Lycanthropes")]
        public Lycanthropes Lycanthropes { get; set; }
    }

    public partial class Lycanthropes
    {
        [J("Werebear")]
        public BimtehkaYellowjacket Werebear { get; set; }
        [J("Wereboar")]
        public BimtehkaYellowjacket Wereboar { get; set; }
        [J("Wererat")]
        public BimtehkaYellowjacket Wererat { get; set; }
        [J("Weretiger")]
        public BimtehkaYellowjacket Weretiger { get; set; }
        [J("Werewolf")]
        public BimtehkaYellowjacket Werewolf { get; set; }
    }

    public partial class MonstersM
    {
        [J("Magmin")]
        public BimtehkaYellowjacket Magmin { get; set; }
        [J("Manticore")]
        public BimtehkaYellowjacket Manticore { get; set; }
        [J("Medusa")]
        public BimtehkaYellowjacket Medusa { get; set; }
        [J("Mephits")]
        public Mephits Mephits { get; set; }
        [J("Merfolk")]
        public BimtehkaYellowjacket Merfolk { get; set; }
        [J("Merrow")]
        public BimtehkaYellowjacket Merrow { get; set; }
        [J("Mimic")]
        public BimtehkaYellowjacket Mimic { get; set; }
        [J("Minotaur")]
        public BimtehkaYellowjacket Minotaur { get; set; }
        [J("Mummies")]
        public Mummies Mummies { get; set; }
    }

    public partial class Mephits
    {
        [J("Dust Mephit")]
        public BimtehkaYellowjacket DustMephit { get; set; }
        [J("Ice Mephit")]
        public BimtehkaYellowjacket IceMephit { get; set; }
        [J("Magma Mephit")]
        public BimtehkaYellowjacket MagmaMephit { get; set; }
        [J("Steam Mephit")]
        public BimtehkaYellowjacket SteamMephit { get; set; }
    }

    public partial class Mummies
    {
        [J("Mummy")]
        public BimtehkaYellowjacket Mummy { get; set; }
        [J("Mummy Lord")]
        public BimtehkaYellowjacket MummyLord { get; set; }
    }

    public partial class MonstersN
    {
        [J("Nagas")]
        public Nagas Nagas { get; set; }
        [J("Nightmare")]
        public BimtehkaYellowjacket Nightmare { get; set; }
    }

    public partial class Nagas
    {
        [J("Guardian Naga")]
        public BimtehkaYellowjacket GuardianNaga { get; set; }
        [J("Spirit Naga")]
        public BimtehkaYellowjacket SpiritNaga { get; set; }
    }

    public partial class MonstersO
    {
        [J("Ogre")]
        public BimtehkaYellowjacket Ogre { get; set; }
        [J("Oni")]
        public BimtehkaYellowjacket Oni { get; set; }
        [J("Oozes")]
        public Oozes Oozes { get; set; }
        [J("Orc")]
        public BimtehkaYellowjacket Orc { get; set; }
        [J("Otyugh")]
        public BimtehkaYellowjacket Otyugh { get; set; }
        [J("Owlbear")]
        public BimtehkaYellowjacket Owlbear { get; set; }
    }

    public partial class Oozes
    {
        [J("Black Pudding")]
        public BimtehkaYellowjacket BlackPudding { get; set; }
        [J("Gelatinous Cube")]
        public BimtehkaYellowjacket GelatinousCube { get; set; }
        [J("Gray Ooze")]
        public BimtehkaYellowjacket GrayOoze { get; set; }
        [J("Ochre Jelly")]
        public BimtehkaYellowjacket OchreJelly { get; set; }
    }

    public partial class MonstersP
    {
        [J("Pegasus")]
        public BimtehkaYellowjacket Pegasus { get; set; }
        [J("Pseudodragon")]
        public BimtehkaYellowjacket Pseudodragon { get; set; }
        [J("Purple Worm")]
        public BimtehkaYellowjacket PurpleWorm { get; set; }
    }

    public partial class MonstersR
    {
        [J("Rakshasa")]
        public BimtehkaYellowjacket Rakshasa { get; set; }
        [J("Remorhaz")]
        public BimtehkaYellowjacket Remorhaz { get; set; }
        [J("Roc")]
        public BimtehkaYellowjacket Roc { get; set; }
        [J("Roper")]
        public BimtehkaYellowjacket Roper { get; set; }
        [J("Rust Monster")]
        public BimtehkaYellowjacket RustMonster { get; set; }
    }

    public partial class MonstersS
    {
        [J("Sahuagin")]
        public BimtehkaYellowjacket Sahuagin { get; set; }
        [J("Salamander")]
        public BimtehkaYellowjacket Salamander { get; set; }
        [J("Satyr")]
        public BimtehkaYellowjacket Satyr { get; set; }
        [J("Shadow")]
        public BimtehkaYellowjacket Shadow { get; set; }
        [J("Shambling Mound")]
        public BimtehkaYellowjacket ShamblingMound { get; set; }
        [J("Shield Guardian")]
        public BimtehkaYellowjacket ShieldGuardian { get; set; }
        [J("Skeletons")]
        public Skeletons Skeletons { get; set; }
        [J("Specter")]
        public BimtehkaYellowjacket Specter { get; set; }
        [J("Sphinxes")]
        public Sphinxes Sphinxes { get; set; }
        [J("Sprite")]
        public BimtehkaYellowjacket Sprite { get; set; }
        [J("Stirge")]
        public BimtehkaYellowjacket Stirge { get; set; }
        [J("Succubus/Incubus")]
        public BimtehkaYellowjacket SuccubusIncubus { get; set; }
    }

    public partial class Skeletons
    {
        [J("Skeleton")]
        public BimtehkaYellowjacket Skeleton { get; set; }
        [J("Minotaur Skeleton")]
        public BimtehkaYellowjacket MinotaurSkeleton { get; set; }
        [J("Warhorse Skeleton")]
        public BimtehkaYellowjacket WarhorseSkeleton { get; set; }
    }

    public partial class Sphinxes
    {
        [J("Androsphinx")]
        public BimtehkaYellowjacket Androsphinx { get; set; }
        [J("Gynosphinx")]
        public BimtehkaYellowjacket Gynosphinx { get; set; }
    }

    public partial class MonstersT
    {
        [J("Tarrasque")]
        public BimtehkaYellowjacket Tarrasque { get; set; }
        [J("Treant")]
        public BimtehkaYellowjacket Treant { get; set; }
        [J("Troll")]
        public BimtehkaYellowjacket Troll { get; set; }
    }

    public partial class MonstersU
    {
        [J("Unicorn")]
        public BimtehkaYellowjacket Unicorn { get; set; }
    }

    public partial class MonstersV
    {
        [J("Vampires")]
        public Vampires Vampires { get; set; }
    }

    public partial class Vampires
    {
        [J("Vampire")]
        public BimtehkaYellowjacket Vampire { get; set; }
        [J("Vampire Spawn")]
        public BimtehkaYellowjacket VampireSpawn { get; set; }
    }

    public partial class MonstersW
    {
        [J("Wight")]
        public BimtehkaYellowjacket Wight { get; set; }
        [J("Will-o’-Wisp")]
        public BimtehkaYellowjacket WillOWisp { get; set; }
        [J("Wraith")]
        public BimtehkaYellowjacket Wraith { get; set; }
        [J("Wyvern")]
        public BimtehkaYellowjacket Wyvern { get; set; }
    }

    public partial class MonstersX
    {
        [J("Xorn")]
        public BimtehkaYellowjacket Xorn { get; set; }
    }

    public partial class MonstersZ
    {
        [J("Zombies")]
        public Zombies Zombies { get; set; }
    }

    public partial class Zombies
    {
        [J("Zombie")]
        public BimtehkaYellowjacket Zombie { get; set; }
        [J("Ogre Zombie")]
        public BimtehkaYellowjacket OgreZombie { get; set; }
    }

    public partial class SavingThrows
    {
        [J("content")]
        public List<string> Content { get; set; }
        [J("Proficiency Bonus by Challenge Rating")]
        public ProficiencyBonusByChallengeRating ProficiencyBonusByChallengeRating { get; set; }
    }

    public partial class ProficiencyBonusByChallengeRating
    {
        [J("table")]
        public ProficiencyBonusByChallengeRatingTable Table { get; set; }
    }

    public partial class ProficiencyBonusByChallengeRatingTable
    {
        [J("Challenge")]
        public List<string> Challenge { get; set; }
        [J("Proficiency Bonus")]
        public List<string> ProficiencyBonus { get; set; }
    }

    public partial class Senses
    {
        [J("content")]
        public string Content { get; set; }
        [J("Blindsight")]
        public Skills Blindsight { get; set; }
        [J("Darkvision")]
        public Darkvision Darkvision { get; set; }
        [J("Tremorsense")]
        public string Tremorsense { get; set; }
        [J("Truesight")]
        public string Truesight { get; set; }
    }

    public partial class Darkvision
    {
        [J("content")]
        public string Content { get; set; }
        [J("Armor, Weapon, and Tool Proficiencies")]
        public Skills ArmorWeaponAndToolProficiencies { get; set; }
    }

    public partial class Size
    {
        [J("content")]
        public string Content { get; set; }
        [J("Size Categories")]
        public SizeCategories SizeCategories { get; set; }
    }

    public partial class SizeCategories
    {
        [J("table")]
        public SizeCategoriesTable Table { get; set; }
    }

    public partial class SizeCategoriesTable
    {
        [J("Size")]
        public List<string> Size { get; set; }
        [J("Space")]
        public List<string> Space { get; set; }
        [J("Examples")]
        public List<string> Examples { get; set; }
    }

    public partial class SpecialTraits
    {
        [J("content")]
        public string Content { get; set; }
        [J("Innate Spellcasting")]
        public Skills InnateSpellcasting { get; set; }
        [J("Spellcasting")]
        public Skills Spellcasting { get; set; }
        [J("Psionics")]
        public string Psionics { get; set; }
    }

    public partial class Speed
    {
        [J("content")]
        public List<string> Content { get; set; }
        [J("Burrow")]
        public string Burrow { get; set; }
        [J("Climb")]
        public string Climb { get; set; }
        [J("Fly")]
        public string Fly { get; set; }
        [J("Swim")]
        public string Swim { get; set; }
    }

    public partial class TypeClass
    {
        [J("content")]
        public List<string> Content { get; set; }
        [J("Tags")]
        public string Tags { get; set; }
    }

    public partial struct HitDiceBySizeContent
    {
        public PurpleContent PurpleContent;
        public string String;

        public bool IsNull
        {
            get
            {
                return PurpleContent == null && String == null;
            }
        }
    }

    public partial struct StickyContent
    {
        public FluffyContent FluffyContent;
        public string String;

        public bool IsNull
        {
            get
            {
                return FluffyContent == null && String == null;
            }
        }
    }

    public partial struct WaterElementalContent
    {
        public FluffyContent FluffyContent;
        public string String;
        public List<string> StringArray;

        public bool IsNull
        {
            get
            {
                return StringArray == null && FluffyContent == null && String == null;
            }
        }
    }

    public partial struct HalfDragonTemplateContent
    {
        public string String;
        public TentacledContent TentacledContent;

        public bool IsNull
        {
            get
            {
                return TentacledContent == null && String == null;
            }
        }
    }

    public partial class Monsters
    {
        public static Monsters FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Monsters>(json, MonsterScaler_WPF.Converter.Settings);
        }
    }

    public static class Serialize
    {
        public static string ToJson(this Monsters self)
        {
            return JsonConvert.SerializeObject(self, MonsterScaler_WPF.Converter.Settings);
        }
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new HalfDragonTemplateContentConverter(),
                new HitDiceBySizeContentConverter(),
                new WaterElementalContentConverter(),
                new StickyContentConverter(),
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class HalfDragonTemplateContentConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(HalfDragonTemplateContent) || t == typeof(HalfDragonTemplateContent?);
        }

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new HalfDragonTemplateContent { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<TentacledContent>(reader);
                    return new HalfDragonTemplateContent { TentacledContent = objectValue };
            }
            throw new Exception("Cannot unmarshal type HalfDragonTemplateContent");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (HalfDragonTemplateContent)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String); return;
            }
            if (value.TentacledContent != null)
            {
                serializer.Serialize(writer, value.TentacledContent); return;
            }
            throw new Exception("Cannot marshal type HalfDragonTemplateContent");
        }
    }

    internal class HitDiceBySizeContentConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(HitDiceBySizeContent) || t == typeof(HitDiceBySizeContent?);
        }

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new HitDiceBySizeContent { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<PurpleContent>(reader);
                    return new HitDiceBySizeContent { PurpleContent = objectValue };
            }
            throw new Exception("Cannot unmarshal type HitDiceBySizeContent");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (HitDiceBySizeContent)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String); return;
            }
            if (value.PurpleContent != null)
            {
                serializer.Serialize(writer, value.PurpleContent); return;
            }
            throw new Exception("Cannot marshal type HitDiceBySizeContent");
        }
    }

    internal class WaterElementalContentConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(WaterElementalContent) || t == typeof(WaterElementalContent?);
        }

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new WaterElementalContent { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<FluffyContent>(reader);
                    return new WaterElementalContent { FluffyContent = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<string>>(reader);
                    return new WaterElementalContent { StringArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type WaterElementalContent");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (WaterElementalContent)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String); return;
            }
            if (value.StringArray != null)
            {
                serializer.Serialize(writer, value.StringArray); return;
            }
            if (value.FluffyContent != null)
            {
                serializer.Serialize(writer, value.FluffyContent); return;
            }
            throw new Exception("Cannot marshal type WaterElementalContent");
        }
    }

    internal class StickyContentConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(StickyContent) || t == typeof(StickyContent?);
        }

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new StickyContent { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<FluffyContent>(reader);
                    return new StickyContent { FluffyContent = objectValue };
            }
            throw new Exception("Cannot unmarshal type StickyContent");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (StickyContent)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String); return;
            }
            if (value.FluffyContent != null)
            {
                serializer.Serialize(writer, value.FluffyContent); return;
            }
            throw new Exception("Cannot marshal type StickyContent");
        }
    }
}
