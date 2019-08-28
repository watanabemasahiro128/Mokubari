//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class HeightScale : MonoBehaviour {
    GameObject highPolyBoard;
    ChangeScale changeScale;

	void Start() {
		highPolyBoard = GameObject.Find("ChangeScale");
        changeScale = highPolyBoard.GetComponent<ChangeScale>();
	}

    public void OnClick() {
        if(changeScale.HeightScale < 10.0f) {
            changeScale.ChangeHeightScale(10.0f);
        } else if(changeScale.HeightScale < 100.0f) {
            changeScale.ChangeHeightScale(100.0f);
        } else {
            changeScale.ChangeHeightScale(1.0f);
        }
    }
}
