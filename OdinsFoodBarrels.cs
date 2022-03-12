using System.IO;
using BepInEx;
using BepInEx.Configuration;
using HarmonyLib;
using PieceManager;
using ServerSync;

namespace OdinsFoodBarrels
{
    [BepInPlugin(HGUIDLower, ModName, version)]
    public class OdinsFoodBarrelsPlugin : BaseUnityPlugin
    {
        public const string version = "1.0.3";
        public const string ModName = "OdinsFoodBarrels";
        internal const string Author = "Gravebear";
        internal const string HGUID = Author + "." + "OdinsFoodBarrels";
        internal const string HGUIDLower = "gravebear.odinsfoodbarrels";
        private const string HarmonyGUID = "Harmony." + Author + "." + ModName;
        private static string ConfigFileName = HGUIDLower + ".cfg";
        private static string ConfigFileFullPath = Paths.ConfigPath + Path.DirectorySeparatorChar + ConfigFileName;
        public static string ConnectionError = "";


        private void Awake()
        {
             BuildPiece OH_Raspberries = new("odinsnummies", "OH_Raspberries");
             OH_Raspberries.Name.English("Raspberry Barrel");
             OH_Raspberries.Description.English("A barrel of Raspberries");
             OH_Raspberries.RequiredItems.Add("Raspberry", 50, true); 

             BuildPiece OH_Blue_Mushrooms = new("odinsnummies", "OH_Blue_Mushrooms");
             OH_Blue_Mushrooms.Name.English("Blue Mushroom Basket");
             OH_Blue_Mushrooms.Description.English("A basket of BlueMushrooms");
             OH_Blue_Mushrooms.RequiredItems.Add("MushroomBlue", 50, true);  

             BuildPiece OH_Blueberries = new("odinsnummies", "OH_Blueberries");
             OH_Blueberries.Name.English("Blueberry Barrel");
             OH_Blueberries.Description.English("A barrel of Blueberrys");
             OH_Blueberries.RequiredItems.Add("Blueberries", 50, true); 

             BuildPiece OH_Carrots = new("odinsnummies", "OH_Carrots");
             OH_Carrots.Name.English("Carrot Barrel");
             OH_Carrots.Description.English("A barrel of Carrots");
             OH_Carrots.RequiredItems.Add("Carrot", 50, true); 

             BuildPiece OH_CloudBerries = new("odinsnummies", "OH_CloudBerries");
             OH_CloudBerries.Name.English("Cloudberry Barrel");
             OH_CloudBerries.Description.English("A barrel of Cloudberries");
             OH_CloudBerries.RequiredItems.Add("Cloudberry", 50, true); 

             BuildPiece OH_Fish = new("odinsnummies", "OH_Fish");
             OH_Fish.Name.English("Fish Barrel");
             OH_Fish.Description.English("A barrel of Raw Fish");
             OH_Fish.RequiredItems.Add("FishRaw", 50, true); 

             BuildPiece OH_Honey = new("odinsnummies", "OH_Honey");
             OH_Honey.Name.English("Honey Barrel");
             OH_Honey.Description.English("A barrel of Honey");
             OH_Honey.RequiredItems.Add("Honey", 50, true); 

             BuildPiece OH_Red_Mushrooms = new("odinsnummies", "OH_Red_Mushrooms");
             OH_Red_Mushrooms.Name.English("Red Mushroom Basketl");
             OH_Red_Mushrooms.Description.English("A Red Mushroom Basket");
             OH_Red_Mushrooms.RequiredItems.Add("Mushroom", 50, true); 

             BuildPiece OH_Turnips = new("odinsnummies", "OH_Turnips");
             OH_Turnips.Name.English("Turnip Barrel");
             OH_Turnips.Description.English("A barrel of Turnips");
             OH_Turnips.RequiredItems.Add("Turnip", 50, true);

            BuildPiece OH_Yellow_Mushrooms = new("odinsnummies", "OH_Yellow_Mushrooms");
            OH_Yellow_Mushrooms.Name.English("Yellow Mushroom Basket");
            OH_Yellow_Mushrooms.Description.English("A Yellow Mushroom Basket");
            OH_Yellow_Mushrooms.RequiredItems.Add("MushroomYellow", 50, true);

            BuildPiece OH_Thistle = new("odinsnummies", "OH_Thistle");
            OH_Thistle.Name.English("Thistle Basket");
            OH_Thistle.Description.English("A Thistle Basket");
            OH_Thistle.RequiredItems.Add("Thistle", 50, true);

            BuildPiece OH_Dandelion = new("odinsnummies", "OH_Dandelion");
            OH_Dandelion.Name.English("Dandelion Basket");
            OH_Dandelion.Description.English("A Dandelion Basket");
            OH_Dandelion.RequiredItems.Add("Dandelion", 50, true);

            BuildPiece OH_Barley = new("odinsnummies", "OH_Barley");
            OH_Barley.Name.English("Barley Barrel");
            OH_Barley.Description.English("A barrel of Barley");
            OH_Barley.RequiredItems.Add("Barley", 50, true);

            BuildPiece OH_Flax = new("odinsnummies", "OH_Flax");
            OH_Flax.Name.English("Flax Barrel");
            OH_Flax.Description.English("A barrel of Flax");
            OH_Flax.RequiredItems.Add("Flax", 50, true);

            BuildPiece OH_Onions = new("odinsnummies", "OH_Onions");
            OH_Onions.Name.English("Onion Barrel");
            OH_Onions.Description.English("A barrel of Onions");
            OH_Onions.RequiredItems.Add("Onion", 50, true);

            BuildPiece OH_Seedbag = new("odinsnummies", "OH_Seedbag");
            OH_Seedbag.Name.English("OdinsSeedbag");
            OH_Seedbag.Description.English("A bag to put what ever in.");
            OH_Seedbag.RequiredItems.Add("DeerHide", 5, true);


        }


    }
}