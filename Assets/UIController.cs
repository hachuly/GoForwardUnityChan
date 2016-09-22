using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//Sceneを使う場合
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {

    private GameObject gameOverText;
    private GameObject runLengthText;
    private float len = 0;
    private float speed = 0.03f;
    private bool isGameOver = false;

	// Use this for initialization
	void Start () {
	   this.gameOverText = GameObject.Find("GameOver");
       this.runLengthText = GameObject.Find("RunLength");
	}

	// Update is called once per frame
	void Update () {

        //走った距離の表示
	   if(this.isGameOver == false){
            this.len += this.speed;
            this.runLengthText.GetComponent<Text>().text = "Distance:  " + len.ToString("F2") + "m";
       }
        if(this.isGameOver){
            if(Input.GetMouseButtonDown(0)){
                    SceneManager.LoadScene("GameScene");
                }
            }
	}

    public void GameOver(){
        this.gameOverText.GetComponent<Text>().text = "GameOver";
        this.isGameOver = true;
    }
}
