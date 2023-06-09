using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Vector3 dir = Vector3.zero;//移動方向
    float speed = 5;           //移動速度

    public static float lastTime;

    void Start()
    {
        //寿命４秒
        Destroy(gameObject, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        //移動方向を決定
        dir = Vector3.left;

        //現在地に移動量を加算
        transform.position += dir.normalized * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //制限時間を１０秒減らす
        GameDirector.lastTime -= 10f;

        //何かほかのオブジェクトに重なったら消去
        Destroy(gameObject);
    }
}
