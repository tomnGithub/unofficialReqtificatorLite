using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Add this namespace
using Mutagen.Bethesda.Plugins;
using System.ComponentModel;
using Mutagen.Bethesda.WPF.Reflection.Attributes;
using Synthesis.Bethesda.Commands;

namespace unofficialReqtificatorLite
{
    public record Settings
    {
        public List<ModKey> TargetMods = new List<ModKey>();

        [SettingName("Actors")]
        public bool ActorOn { get; set; } = true; // Default is on

        [SettingName("Armor")]
        public bool ArmorOn { get; set; } = true; // Default is on

        [SettingName("Weapons")]
        public bool WeaponsOn { get; set; } = true; // Default is on

        [SettingName("Arrows and Bolts")]
        public bool ArrowsOn { get; set; } = true; // Default is on

        [SettingName("Doors")]
        public bool DoorsOn { get; set; } = true; // Default is on

        [SettingName("Containers")]
        public bool ContOn { get; set; } = true; // Default is on

     

        [SettingName("Patch everything not reqtified by Requiem for the Indifferent.esp (Hover cursor here for more details.)"),
            Tooltip("If enabled, the Reqtificator Lite will automatically patch any ESP that has not been patched by Requiem for the Indifferent.esp" +
            "\nYou would not need to select any plugins below." +
            "\nIf you want to patch only specific plugnins, leave this option disabled.")]
        public bool ReqOn { get; set; } = false; // Default is of


    }

    





}

