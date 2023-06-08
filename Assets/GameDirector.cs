using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    public Text kyoriLabel; //距離を表示するUI-Textオブジェクトを保存する変数
    int kyori;              //距離を保存する変数

    public Image timeGauge;

    float lastTime;

    void Start()
    {
        kyori = 0;
    }

    void Update()
    {
        //残り時間を減らす処理
        lastTime -= Time.deltaTime;
        timeGauge.fillAmount = lastTime / 100f;

        //残り時間が０になったらリロード
        if(lastTime < 0)
        {
            SceneManager.LoadScene("GameScene");
        }

        kyori++;
        kyoriLabel.text = kyori.ToString("D6") + "km"; 
    }
}