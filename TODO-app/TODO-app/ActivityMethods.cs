﻿using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using AndroidX.AppCompat.App;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Essentials;
using AndroidX.Core.Content;
using Android;
using AndroidX.Core.App;

namespace TODO_app
{
    internal class ActivityMethods : AppCompatActivity
    {
        public int DpToPx(int dpValue)
        {

            //viittaaminen toiseen luokkaan ei onnistu, Java.NullException
            int pixel = (int)TypedValue.ApplyDimension(ComplexUnitType.Dip, dpValue, Resources.DisplayMetrics);
            return pixel;
        }

        public void Vibrate(Vibrator vibratorService, VibratorManager vibratorManager, int length)
        {
            Vibrator vibrator;
            if (Build.VERSION.SdkInt >= BuildVersionCodes.S)
            {
                VibratorManager manager = vibratorManager;
                vibrator = manager.DefaultVibrator;
            }
            else
            {
                vibrator = vibratorService;
            }
            vibrator.Cancel();
            vibrator.Vibrate(VibrationEffect.CreateOneShot(length, VibrationEffect.DefaultAmplitude));

        }

        public static string TooLongStringParser(string inputToParse, int maxChar)
        {
            if (inputToParse.Length > maxChar)
            {
                string newstring = inputToParse.Substring(0, maxChar - 3);
                newstring = newstring + "...";
                return newstring;
            }
            else
            {
                return inputToParse;
            }
        }


    }
}