using System;
using UnityEngine;

public class ScreenshotTaker : MonoBehaviour
{
    public void TakeScreenShot()
    {
        string fileName = "Screenshot-" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss-fff") + ".png";
        ScreenCapture.CaptureScreenshot(Application.dataPath + "/../Logs/" + fileName);
    }
}
