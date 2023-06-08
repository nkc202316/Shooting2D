using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    public Text kyoriLabel; //������\������UI-Text�I�u�W�F�N�g��ۑ�����ϐ�
    int kyori;              //������ۑ�����ϐ�

    public Image timeGauge;

    float lastTime;

    void Start()
    {
        kyori = 0;
    }

    void Update()
    {
        //�c�莞�Ԃ����炷����
        lastTime -= Time.deltaTime;
        timeGauge.fillAmount = lastTime / 100f;

        //�c�莞�Ԃ��O�ɂȂ����烊���[�h
        if(lastTime < 0)
        {
            SceneManager.LoadScene("GameScene");
        }

        kyori++;
        kyoriLabel.text = kyori.ToString("D6") + "km"; 
    }
}