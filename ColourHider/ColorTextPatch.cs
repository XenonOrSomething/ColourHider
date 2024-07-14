using GorillaNetworking;
using HarmonyLib;
using System.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ColourHider
{
    [HarmonyPatch(typeof(GrabbingColorPicker))]
    [HarmonyWrapSafe]
    internal class ColorTextPatch
    {
        
        [HarmonyPostfix]
        [HarmonyPatch("UpdateDisplay")]
        public static void UpdateDisplayPatch(ref TextMeshProUGUI ___textR, ref TextMeshProUGUI ___textG, ref TextMeshProUGUI ___textB, ref GameObject ___ColorSwatch)
        {
            
            ___textR.text = Random.Range(0, 9).ToString();
            ___textG.text = Random.Range(0, 9).ToString();
            ___textB.text = Random.Range(0, 9).ToString();
            
            MeshRenderer swatchRenderer = ___ColorSwatch.GetComponent<MeshRenderer>();
            swatchRenderer.material.color = new Color(Random.Range(0, 2), Random.Range(0, 2), Random.Range(0, 2));
            /* dosent work
            foreach (WardrobeInstance wardrobeInstance in CosmeticsController.instance.wardrobes)
            {

                MeshRenderer dollRenderer = wardrobeInstance.selfDoll.gameObject.GetComponent<MeshRenderer>();

                dollRenderer.material.color = new Color(Random.Range(0, 2), Random.Range(0, 2), Random.Range(0, 2));
            }
            */
        }
    }
}
