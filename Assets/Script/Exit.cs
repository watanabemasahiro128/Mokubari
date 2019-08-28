//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour {
    void Start() {
    }

    void Update() {  
    }

    public void OnClick() {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #elif UNITY_STANDALONE
            UnityEngine.Application.Quit();
        #endif
    }
}
