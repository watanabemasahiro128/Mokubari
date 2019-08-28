//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
//using System.IO;

public class FPS : MonoBehaviour {
    public int targetFrameRate = 50;

    void Awake() {
        if(targetFrameRate > 0) {
            QualitySettings.vSyncCount = 0;
            Application.targetFrameRate = targetFrameRate;
        }
    }
}
