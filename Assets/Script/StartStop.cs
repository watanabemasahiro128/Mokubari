﻿//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class StartStop : MonoBehaviour {
    GameObject highPolyBoard;
    ChangeScale changeScale;

	void Start() {
		highPolyBoard = GameObject.Find("ChangeScale");
        changeScale = highPolyBoard.GetComponent<ChangeScale>();
	}

    public void OnClick() {
        changeScale.StartStop();
    }
}
