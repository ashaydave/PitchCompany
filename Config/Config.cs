using System.IO;
using BepInEx;
using BepInEx.Configuration;

namespace PitchCompany.Configuration
{
    internal static class Config
    {
        private const string CONFIG_FILE_NAME = "PitchCompany.cfg";

        private static ConfigFile config;
        private static ConfigEntry<float> pitchValue;

        public static void Init()
        {
            var filePath = Path.Combine(Paths.ConfigPath, CONFIG_FILE_NAME);
            config = new ConfigFile(filePath, true);

            /* ---------------------------------------
               Change Pitch value below (default is 3)
               --------------------------------------- */

            pitchValue = config.Bind("Config", "Pitch", 3f, "Changes pitch of the player to given value");
        }

        public static float PitchValue => pitchValue.Value;
    }
}