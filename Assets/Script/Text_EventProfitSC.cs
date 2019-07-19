using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_EventProfitSC : MonoBehaviour
{

    Text text_eventProfit;
    public EventPlaySC eventPlay;
    string text_event_profit;
    // Use this for initialization
    void Start()
    {
        text_eventProfit = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text_event_profit = eventPlay.event_profit.ToString("N0");
        text_eventProfit.text = "利益：" + text_event_profit + "円";
    }
}
