using MelonLoader;
using System.Collections;
using UnityEngine;
using Il2CppRUMBLE.Managers;

namespace ILMSN
{
    public static class BuildInfo
    {
        public const string Name = "iLikeMyAccountName"; // Name of the Mod.  (MUST BE SET)
        public const string Description = "no more ruining steam OR oculus names!"; // Description for the Mod.  (Set as null if none)
        public const string Author = "elmish"; // Author of the Mod.  (MUST BE SET)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "1.0.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
    }

    public class ILMSNClass : MelonMod
    {
        private static string username = "";
        private MelonPreferences_Category SteamNameCategory;
        private MelonPreferences_Entry<string> UserNameEntry;
        private static bool initialized;
        public override void OnInitializeMelon()
        {
            base.OnInitializeMelon();
            SteamNameCategory = MelonPreferences.CreateCategory("Display Name");
            UserNameEntry = SteamNameCategory.CreateEntry<string>("name", "");
            SteamNameCategory.SetFilePath(@"UserData/customName.cfg");
            SteamNameCategory.SaveToFile();
            username = UserNameEntry.Value;
        }
        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            base.OnSceneWasLoaded(buildIndex, sceneName);
            if (sceneName == "Gym" && !initialized)
            {
                MelonCoroutines.Start(changeName(username.Length <= 48 && username.Length > 1));
                initialized = true;
            }
        }
        private static IEnumerator changeName(bool changeName)
        {
            if (!changeName) yield break;
            while (PlayerManager.Instance?.localPlayer?.Data?.GeneralData?.PublicUsername == null) yield return new WaitForFixedUpdate();
            PlayerManager.Instance.localPlayer.Data.GeneralData.PublicUsername = username;
        }
    }
}