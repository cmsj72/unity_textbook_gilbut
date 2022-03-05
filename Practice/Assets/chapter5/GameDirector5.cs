using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector5 : MonoBehaviour
{
    GameObject hpGauge;

    // Start is called before the first frame update
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DecreaseHp()
    {
        //Image 오브젝트(hpGauge)의 fillAmount를 줄여 HP게이지를 표시하는 비율을 낮춘다
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
