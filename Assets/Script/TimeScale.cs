//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class TimeScale : MonoBehaviour {
    GameObject highPolyBoard;
    ChangeScale changeScale;

	void Start() {
		highPolyBoard = GameObject.Find("ChangeScale");
        changeScale = highPolyBoard.GetComponent<ChangeScale>();
	}

    public void OnClick() {
        if(changeScale.TimeScale < 2) {
            changeScale.ChangeTimeScale(2);
            Debug.Log("2");
        } else if(changeScale.TimeScale < 4) {
            changeScale.ChangeTimeScale(4);
            Debug.Log("4");
        } else {
            changeScale.ChangeTimeScale(1);
            Debug.Log("1");
        }
    }
}
