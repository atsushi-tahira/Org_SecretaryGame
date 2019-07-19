using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class day_countSC : MonoBehaviour
{

    Text text_dayCount;
    public EventPlaySC eventPlay;
    string text_day_count;
    string text_action_count_sum;
    // Use this for initialization
    void Start()
    {
        text_dayCount = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text_day_count = eventPlay.day_count.ToString();
        text_action_count_sum = eventPlay.action_count_sum.ToString();
        text_dayCount.text = "使用日数：" + text_day_count + "日　(最大 ５日 まで)";
    }
}