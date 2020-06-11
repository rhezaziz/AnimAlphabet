using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class cameraFokus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var vuforia = VuforiaARController.Instance;
        vuforia.RegisterVuforiaStartedCallback(OnVuforiaStarted);
        vuforia.RegisterOnPauseCallback(onPause);
    }
    private void OnVuforiaStarted(){
        CameraDevice.Instance.SetFocusMode(
            CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
    }

    private void onPause(bool paused){
        if(!paused){
            CameraDevice.Instance.SetFocusMode(
            CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
        }
    }
}
