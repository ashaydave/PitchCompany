using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using PitchCompany.Configuration;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitchCompany
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class PitchCompany : BaseUnityPlugin
    {
        private const string modGUID = "bizkit.PitchCompany";
        private const string modName = "PitchCompany";
        private const string modVersion = "1.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static PitchCompany Instance;

        internal static ManualLogSource mls;
        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            mls.LogInfo("PitchCompany is here!");

            Configuration.Config.Init();
            harmony.PatchAll();
        }
    }
}
