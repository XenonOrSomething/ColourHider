﻿using BepInEx;
using System;
using UnityEngine;
using Utilla;
using UnityEngine.SceneManagement;
using HarmonyLib;
using System.Reflection;
namespace ColourHider
{
    [ModdedGamemode]
    [BepInDependency("org.legoandmars.gorillatag.utilla", "1.5.0")]
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]

    public class Plugin : BaseUnityPlugin
    {
        void Awake()
        {
            //thanks to not a bird for doing this with harmony instead of the fuck ass way i done it before
            new Harmony(PluginInfo.GUID).PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
