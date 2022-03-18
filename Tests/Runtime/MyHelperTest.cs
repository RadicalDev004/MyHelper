using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using NUnit.Framework;

namespace MyHelper
{
    public class MyHelperTest
    {

       [Test]
       public void TestIncreasePlayerPrefsInt()
       { 
            string temp = "TestNameForPlayerPrefsIntIncrease";
            PlayerPrefs.SetInt(temp, 1);
            PrefsHelper.IncreaseInt(temp, 5);

            Assert.AreEqual(6, PlayerPrefs.GetInt(temp));
            PlayerPrefs.DeleteKey(temp);
       }

        [Test]
        public void TestIncreasePlayerPrefsFloat()
        {
            string temp = "TestNameForPlayerPrefsFloatIncrease";
            PlayerPrefs.SetFloat(temp, 0.5f);
            PrefsHelper.IncreaseFloat(temp, 3.4f);

            Assert.AreEqual(3.9f, PlayerPrefs.GetFloat(temp));
            PlayerPrefs.DeleteKey(temp);
        }

        [Test]
        public void TestIncreasePlayerPrefsString()
        {
            string temp = "TestNameForPlayerPrefsStringIncrease";
            PlayerPrefs.SetString(temp, "isTest=");
            PrefsHelper.IncreaseString(temp, "true");

            Assert.AreEqual("isTest=true", PlayerPrefs.GetString(temp));
            PlayerPrefs.DeleteKey(temp);
        }


        [Test]
        public void TestDecreasePlayerPrefsInt()
        {
            string temp = "TestNameForPlayerPrefsIntDecrease";
            PlayerPrefs.SetInt(temp, 5);
            PrefsHelper.DecreaseInt(temp, 1);

            Assert.AreEqual(4, PlayerPrefs.GetInt(temp));
            PlayerPrefs.DeleteKey(temp);
        }

        [Test]
        public void TestDecreasePlayerPrefsFloat()
        {
            string temp = "TestNameForPlayerPrefsFloatDecrease";
            PlayerPrefs.SetFloat(temp, 3.9f);
            PrefsHelper.DecreaseFloat(temp, 0.5f);

            Assert.AreEqual(3.4f, PlayerPrefs.GetFloat(temp));
            PlayerPrefs.DeleteKey(temp);
        }

        [Test]
        public void TestDereasePlayerPrefsString()
        {
            string temp = "TestNameForPlayerPrefsStringDecrease";
            PlayerPrefs.SetString(temp, "isTest=true");
            PrefsHelper.DecreaseString(temp, "=true");

            Assert.AreEqual("isTest", PlayerPrefs.GetString(temp));
            PlayerPrefs.DeleteKey(temp);
        }


        [Test]
        public void TestWorkingStateOfSmartVibrationBoolTrue()
        {
            VibrationHelper.Reset();
            VibrationHelper.Key = "testNameForKeyVibrationHelper";
            PlayerPrefs.SetInt(VibrationHelper.Key, 1);

            VibrationHelper.SmartVibrate();
            Assert.AreEqual(1, VibrationHelper.Nr);

            PlayerPrefs.DeleteKey(VibrationHelper.Key);
            VibrationHelper.Key = null;
            VibrationHelper.Reset();
        }

        [Test]
        public void TestWorkingStateOfSmartVibrationBoolFalse()
        {
            VibrationHelper.Reset();
            VibrationHelper.Key = "testNameForKeyVibrationHelper";
            PlayerPrefs.SetInt(VibrationHelper.Key, 0);

            VibrationHelper.SmartVibrate();
            Assert.AreEqual(0, VibrationHelper.Nr);

            PlayerPrefs.DeleteKey(VibrationHelper.Key);
            VibrationHelper.Key = null;
            VibrationHelper.Reset();
        }
    }
}

