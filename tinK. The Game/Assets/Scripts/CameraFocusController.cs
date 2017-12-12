using UnityEngine;
using System.Collections;
using Vuforia;
using UnityEngine.UI;

public class CameraFocusController : MonoBehaviour
{
    public bool flashToggle;

    void Start()
    {
        VuforiaARController.Instance.RegisterVuforiaStartedCallback(OnVuforiaStarted);
        VuforiaARController.Instance.RegisterOnPauseCallback(OnPaused);
    }

    private void OnVuforiaStarted()
    {
        CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
    }

    private void OnPaused(bool paused)
    {
        if (!paused)
            CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
    }

    public void ToogleFlash()
    {
        flashToggle = !flashToggle;
        CameraDevice.Instance.SetFlashTorchMode(flashToggle);
    }
}