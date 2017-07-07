using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Runtime;
using Java.Lang;

namespace TimerDemo
{
    [Activity(Label = "TimerDemo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            CountDownTimer countDownTimer = new MyCountDownTimer(10000,1000);
            countDownTimer.Start();


        }
    }

    class MyCountDownTimer:CountDownTimer
        {
           
            public MyCountDownTimer(long millisInFuture, long countDownInterval) : base(millisInFuture, countDownInterval)
            {
            }

            public override void OnFinish()
            {
               
            }

            public override void OnTick(long millisUntilFinished)
            {
                Toast.MakeText(Application.Context, "hello"+millisUntilFinished,ToastLength.Short).Show();
            }
        }
}

 