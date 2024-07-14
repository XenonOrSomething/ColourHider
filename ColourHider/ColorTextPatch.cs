using HarmonyLib;
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
        public static void UpdateDisplayPatch(ref TextMeshProUGUI ___textR, ref TextMeshProUGUI ___textG, ref TextMeshProUGUI ___textB)
        {
            ___textR.text = Random.Range(0, 9).ToString();
            ___textG.text = Random.Range(0, 9).ToString();
            ___textB.text = Random.Range(0, 9).ToString();
        }
    }
}
