using System.Collections;
using UnityEngine;

namespace MyHelper
{
    public class VibrationHelper : MonoBehaviour
    {
        /// <summary>
        /// Key of PlayerPrefs used as bool for on/off vibration.
        /// </summary>
        public static string Key;
        private static int totalNumberOfVibrations = 0;
        public static int Nr { get { return totalNumberOfVibrations; } }

        /// <summary>
        /// Uses static string Key to determine if the PlayerPrefs with that key is 1 (continues to vibrate) or 0 (does nothing)
        /// </summary>
        public static void SmartVibrate()
        {
            if (Key == null)
                Debug.LogError("PlayerPrefs Key for Vibration class has not been set. Please set it by using Vibraton.VibrPrefsName.");
            else if (PlayerPrefs.GetInt(Key) == 1)
            {
                Handheld.Vibrate();
                totalNumberOfVibrations++;
            }

        }

        public static void Reset()
        {
            totalNumberOfVibrations = 0;
        }
    }
    public class PrefsHelper
    {
        /// <summary>
        /// Easily increase the value of a Int/Float/String PlayerPrefs
        /// </summary>

        public static void IncreaseInt(string key, int valueToAdd)
        {
            PlayerPrefs.SetInt(key, PlayerPrefs.GetInt(key) + valueToAdd);
        }
        public static void IncreaseFloat(string key, float valueToAdd)
        {
            PlayerPrefs.SetFloat(key, PlayerPrefs.GetFloat(key) + valueToAdd);
        }
        public static void IncreaseString(string key, string valueToAdd)
        {
            PlayerPrefs.SetString(key, PlayerPrefs.GetString(key) + valueToAdd);
        }


        /// <summary>
        /// Easily decrease the value of a Int/Float/String PlayerPrefs
        /// </summary>

        public static void DecreaseInt(string key, int valueToDecreaseBy)
        {
            PlayerPrefs.SetInt(key, PlayerPrefs.GetInt(key) - valueToDecreaseBy);
        }
        public static void DecreaseFloat(string key, float valueToDecreaseBy)
        {
            PlayerPrefs.SetFloat(key, PlayerPrefs.GetFloat(key) - valueToDecreaseBy);
        }
        public static void DecreaseString(string key, string valueToDecreaseBy)
        {
            PlayerPrefs.SetString(key, PlayerPrefs.GetString(key).Replace(valueToDecreaseBy, ""));
        }

    }
}
