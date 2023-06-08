using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{

    public GameObject enemyPre; //敵のプレハブを保存する変数
    float delta;                //経過時間計算用
    float span;        
    
    void Start()
    {
        delta = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //
        delta += Time.deltaTime;

        if (delta > 1f)
        {

        }
        //敵を生成する
        GameObject go = Instantiate(enemyPre);
        float py = Random.Range(-6f, 7f);
        go.transform.position = new Vector3(10, py, 0);

        //時間経過を保存する変数を０クリアする
        delta = 0;

        span -= (span > 0, 5f) ? 0.01 : 0f; 
    }
}
