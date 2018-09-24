using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageTracker.Data
{
    public enum NpcGenders
    {
        Male = 0,
        Female,
        Other
    }

    public enum NpcRaces
    {
        [Description("Aarakocra (EE)")]
        Aarakocra = 0,
        [Description("Aasimar (DMG)")]
        Aasimar,
        [Description("Aasimar: Protector  (VOLO)")]
        AasimarProtector,
        [Description("Aasimar: Scourge (VOLO)")]
        AasimarScourge,
        [Description("Aasimar: Fallen (VOLO)")]
        AasimarFallen,
        [Description("Bugbear (VOLO)")]
        Bugbear,
        [Description("Dragonborn (PHB)")]
        Dragonborn,
        [Description("Dwarf: Mountain (PHB)")]
        DwarfMountain,
        [Description("Dwarf: Hill (PHB)")]
        DwarfHill,
        [Description("Dwarf: Duergar (SCAG)")]
        DwarfDuergar,
        [Description("Elf: High (PHB)")]
        ElfHigh,
        [Description("Elf: Wood (PHB)")]
        ElfWood,
        [Description("Elf: Drow (PHB)")]
        ElfDrow,
        [Description("Elf: Eladrin (MToF)")]
        ElfEladrin,
        [Description("Elf: Sea Elf (MToF)")]
        ElfSeaElf,
        [Description("Elf: Shadar-kai (MToF)")]
        ElfShadarKai,
        [Description("Firbolg (VOLO)")]
        Firbolg,
        [Description("Genasi (PotA, EE, EE)")]
        Genasi,
        [Description("Gith: Githyanki (MToF)")]
        GithGithyanki,
        [Description("Gith: Githzerai (MToF)")]
        GithGithzerai,
        [Description("Gnome (PHB)")]
        Gnome,
        [Description("Gnome: Deep (EE, SCAG)")]
        GnomeDeep,
        [Description("Goblin (VOLO)")]
        Goblin,
        [Description("Goliath (EE, VOLO)")]
        Goliath,
        [Description("Halfling: Lightfoot (PHB)")]
        HalflingLightfoot,
        [Description("Halfling: Stout (PHB)")]
        HalflingStout,
        [Description("Halfling: Ghostwise (SCAG)")]
        HalflingGhostwise,
        [Description("Half-Elf: Standard (PHB)")]
        HalfElfStandard,
        [Description("Half-Elf: Variant (SCAG)")]
        HalfElfVariant,
        [Description("Half-Orc (PHB)")]
        HalfOrc,
        [Description("Hobgoblin (VOLO)")]
        Hobgoblin,
        [Description("Human: Standard (PHB)")]
        HumanStandard,
        [Description("Human: Variant (PHB)")]
        HumanVariant,
        [Description("Kenku (VOLO)")]
        Kenku,
        [Description("Kobold (VOLO)")]
        Kobold,
        [Description("Lizardfolk (VOLO)")]
        Lizardfolk,
        [Description("Orc (VOLO)")]
        Orc,
        [Description("Tabaxi (VOLO)")]
        Tabaxi,
        [Description("Tiefling (PHB)")]
        Tiefling,
        [Description("Tiefling: Bloodline Variants (MToF)")]
        TieflingBloodlineVariants,
        [Description("Tortle ()")]
        Tortle,
        [Description("Triton (VOLO)")]
        Triton,
        [Description("Yuan-Ti Pureblood (VOLO)")]
        YuanTiPureblood,
        [Description("Other")]
        Other,
    }

    public enum NpcAlignments
    {
        LawfulGood = 0,
        LawfulNeutral,
        LawfulEvil,
        NeutralGood,
        NeutralNeutral,
        NeutralEvil,
        ChaoticGood,
        ChaoticNeutral,
        ChaoticEvil
    }
}
