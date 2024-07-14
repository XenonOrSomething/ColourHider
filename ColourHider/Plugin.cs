using BepInEx;
using System;
using UnityEngine;
using Utilla;
using UnityEngine.SceneManagement;
namespace ColourHider
{
    /// <summary>
    /// This is your mod's main class.
    /// </summary>

    /* This attribute tells Utilla to look for [ModdedGameJoin] and [ModdedGameLeave] */
    [ModdedGamemode]
    [BepInDependency("org.legoandmars.gorillatag.utilla", "1.5.0")]
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]

    
    public class Plugin : BaseUnityPlugin
    {
        GameObject CityUI;
        GameObject StumpUI;
        GameObject CloudsUI;
        GameObject MountainsUI;
        void Start()
        {
            SceneManager.sceneLoaded += OnSceneLoaded;
            Utilla.Events.GameInitialized += OnGameInitialized;
        }


        void OnGameInitialized(object sender, EventArgs e)
        {
            StumpUI = GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/TreeRoomInteractables/UI/SatelliteWardrobe/PushSliderColorPicker/Canvas");
            StumpUI.SetActive(false);

            CityUI = GameObject.Find("Environment Objects/LocalObjects_Prefab/City/CosmeticsRoomAnchor/outerstores/Bottom Floor/OutsideBuildings/WardrobeAnchor/SatelliteWardrobe/PushSliderColorPicker/Canvas");
            CityUI.SetActive(false);


            MountainsUI = GameObject.Find("Mountain/Geometry/goodigloo/SatelliteWardrobe/PushSliderColorPicker/Canvas");
            MountainsUI.SetActive(false);

            CloudsUI = GameObject.Find("skyjungle/UI/SatelliteWardrobe/PushSliderColorPicker/Canvas");
            CloudsUI.SetActive(false);

            
        }

        public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
        {
            Debug.Log($"Scene: {scene}, LoadSceneMode: {mode}");
            try
            {
                MountainsUI = GameObject.Find("Mountain/Geometry/goodigloo/SatelliteWardrobe/PushSliderColorPicker/Canvas");
                MountainsUI.SetActive(false);
            }
            catch
            {
                Debug.Log("mountains isnt loaded");
            }
            try
            {
                CloudsUI = GameObject.Find("skyjungle/UI/SatelliteWardrobe/PushSliderColorPicker/Canvas");
                CloudsUI.SetActive(false);
            }
            catch
            {
                Debug.Log("clouds isnt loaded");
            }
        }

        
    }
}
