//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
 
public class RotateCamera : MonoBehaviour {
    public GameObject Camera;
    //回転させるスピード
    public float rotateSpeed = 2.0f;
    private bool topCheck = false;
    private bool bottomCheck = false;
    private int index = 0;
 
    // Use this for initialization
    void Start() {
    }
     
    // Update is called once per frame
    void Update() {
        //プレイヤー位置情報
        Vector3 originPos = transform.position;
 
        index++;
        if(index == 49) {
            index = 0;
            Debug.Log(Camera.transform.eulerAngles.x);
        }
        if(Input.GetKey(KeyCode.RightArrow)) {
            transform.Rotate(new Vector3(0.0f, -1.0f, 0.0f), Space.World);
        }
        if(Input.GetKey(KeyCode.LeftArrow)) {
            transform.Rotate(new Vector3(0.0f, 1.0f, 0.0f), Space.World);
        }
        if(Input.GetKey(KeyCode.UpArrow)) {
            transform.Rotate(new Vector3(1.0f, 0.0f, 0.0f), Space.Self);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            transform.Rotate(new Vector3(-1.0f, 0.0f, 0.0f), Space.Self);
        }
/*        } else if(Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.LeftArrow)) {
            if(bottomCheck == true) {
                bottomCheck = false;
                transform.Rotate(new Vector3(1.0f, 0.0f, 0.0f), Space.Self);
            } else if(topCheck == false && Camera.transform.eulerAngles.x < 92.0f && Camera.transform.eulerAngles.x > 88.0f) {
                topCheck = true;
                transform.rotation = Quaternion.Euler(60.0f, Camera.transform.eulerAngles.y, Camera.transform.eulerAngles.z);//transform.Rotate(new Vector3(1f, 0f, 0f), Space.Self);
            } else if(topCheck == false && Camera.transform.eulerAngles.x <= 88.0f || Camera.transform.eulerAngles.x >= 270.0f) {
                transform.Rotate(new Vector3(1.0f, 0.0f, 0.0f), Space.Self);
            }
        } else if(Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.LeftArrow)) {
            if(topCheck == true) {
                topCheck = false;
                transform.Rotate(new Vector3(-1.0f, 0.0f, 0.0f), Space.Self);
            } else if(bottomCheck == false && Camera.transform.eulerAngles.x > 268.0f && Camera.transform.eulerAngles.x < 272.0f) {
                bottomCheck = true;
                transform.rotation = Quaternion.Euler(240.0f, Camera.transform.eulerAngles.y, Camera.transform.eulerAngles.z);//transform.Rotate(new Vector3(-1f, 0f, 0f), Space.Self);
            } else if(bottomCheck == false && (Camera.transform.eulerAngles.x <= 90.0f || Camera.transform.eulerAngles.x >= 272.0f)) {
                transform.Rotate(new Vector3(-1.0f, 0.0f, 0.0f), Space.Self);
            }
        }*/
    }
}
