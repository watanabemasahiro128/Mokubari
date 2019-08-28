//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour {
    GameObject highPolyBoard;
    ChangeScale changeScale;

	void Start() {
		highPolyBoard = GameObject.Find("ChangeScale");
        changeScale = highPolyBoard.GetComponent<ChangeScale>();
	}

    public void OnClick() {
        changeScale.Restart();
    }
}
