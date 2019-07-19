using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_EventSalesSC : MonoBehaviour
{

    Text text_eventSales;
    public EventPlaySC eventPlay;
    string text_event_sales;
    // Use this for initialization
    void Start()
    {
        text_eventSales = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text_event_sales = eventPlay.event_sales.ToString("N0");
        text_eventSales.text = "売り上げ：" + text_event_sales + "円";
    }
}
