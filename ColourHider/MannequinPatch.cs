using ColourHider;
using GorillaNetworking;
using HarmonyLib;
using System.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ColourHider
{
    [HarmonyPatch(typeof(HeadModel))]
    [HarmonyWrapSafe]
    internal class MannequinPatch
    {

        [HarmonyPostfix]
        [HarmonyPatch("Awake")]
        public static void UpdateDisplayPatch(HeadModel __instance, ref Renderer ____mannequinRenderer)
        {
            UpdateComponent updateComponent = __instance.gameObject.AddComponent<UpdateComponent>();
            updateComponent.renderer = ____mannequinRenderer;
        }
    }
}

public class UpdateComponent : MonoBehaviour, IMannequinInterface
{
    public Renderer renderer;

    public void onUpdate()
    {
        if (renderer)
        {
            renderer.material.color = new Color(Random.Range(0, 2), Random.Range(0, 2), Random.Range(0, 2));

        }
    }
}