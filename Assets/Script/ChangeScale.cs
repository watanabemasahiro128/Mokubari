//using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
//using UnityEngine.UI;
using System.Windows.Forms;

//[ExecuteInEditMode]
public class ChangeScale : MonoBehaviour {
    //public InputField input_field_path_;
    private string path;
    //TextAsset csvFile; // CSVファイル
    private int numOfLine; // CSVの行数
    List<string[]> csvDatas = new List<string[]>(); // CSVの中身を入れるリスト;

    public bool startStop = true;
    public float HeightScale = 10.0f;
    public uint TimeScale = 2;
    public Material material;
    public GameObject Camera;

    [Range(-1, 1)] public float height;

    private int heightId;
    private int index = 0;

    void Start() {
        OpenFileDialog open_file_dialog = new OpenFileDialog();
        // タイトルを指定する
        open_file_dialog.Title = "Open CSV File";
        // csvファイルを開くことを指定する
        open_file_dialog.Filter = "CSV File (*.csv)|*.csv";
        // ファイルが実在しない場合は警告を出す(true)、警告を出さない(false)
        open_file_dialog.CheckFileExists = false;
        // ダイアログを開く
        open_file_dialog.ShowDialog();
        // 取得したファイル名をInputFieldに代入する
        //input_field_path_.text = open_file_dialog.FileName;
        Debug.Log(open_file_dialog.FileName);

        //path = Application.dataPath + "/StreamingAssets/Mokubari.csv";
        path = open_file_dialog.FileName;
        WWW www = new WWW("file:///" + path);
        while(!www.isDone) {//ロードが完了するまで次に進んでほしくないため
            Debug.Log("Now Loading");
        }
        //csvFile = www;//Load(path) as TextAsset; // Resouces下のCSV読み込み
        numOfLine = 0;
        StringReader reader = new StringReader(www.text);//(csvFile.text);
        
        // , で分割しつつ一行ずつ読み込み
        // リストに追加していく
        while(reader.Peek() > -1) {// reader.Peaekが0になるまで繰り返す
            string line = reader.ReadLine(); // 一行ずつ読み込み
            csvDatas.Add(line.Split(',')); // , 区切りでリストに追加
            numOfLine++; // 行数加算
        }

        this.heightId = Shader.PropertyToID("_Height");
    }

    void Update() {
        if(startStop == true) {
            if(index >= numOfLine) {
                index = 0;
            }
            height = float.Parse(csvDatas[index][1]) * HeightScale;
            material.SetFloat("_Height", height);
            material.SetFloat(heightId, height);
        
            for(int i = 0; i < TimeScale; i++) {
                index++;
            }
        }
        //Debug.Log(index);
        //Debug.Log(numOfLine);
        //Debug.Log("FPS : " + (int)(1 / Time.deltaTime));
    }

    private void OnGUI() {
        GUI.skin.label.fontSize = 25;
        GUI.skin.label.normal.textColor = Color.black;
        float fix = Camera.transform.eulerAngles.x > 180.0f ? 360.0f : 0.0f;
        GUILayout.Label((0.01 * index).ToString("00.00 Seconds\n") + HeightScale.ToString("Ratio : 0\n") + ((float)(TimeScale / 2.0f)).ToString("Speed : 0.0\n") + "X Angle : " + ((float)(Mathf.Round(Camera.transform.eulerAngles.x - fix))) + "\nY Angle : " + ((float)(Mathf.Round(Camera.transform.eulerAngles.y))));//.ToString("0°"));
    }

    public void Restart() {
        index = 0;
    }

    public void StartStop() {
        startStop = startStop == true ? false : true;
    }

    public void ChangeHeightScale(float value) {
        HeightScale = value;
    }
    
    public void ChangeTimeScale(uint value) {
        TimeScale = value;
    }
}
