using System.Collections;
using UnityEngine;

namespace ColourHider
{
    public class InterfaceCall : MonoBehaviour
    {
        
        public static void Call()
        {
            MonoBehaviour[] allMannequins = FindObjectsOfType<MonoBehaviour>();

            foreach (MonoBehaviour behaviour in allMannequins)
            {
                if (behaviour is IMannequinInterface inter)
                {
                    inter.onUpdate();
                }
            }
        }
    }
}