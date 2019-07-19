using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_ActionCostSC : MonoBehaviour
{

    Text text_actionCost;
    public EventPlaySC eventPlay;
    string text_cost;
    int cost_sum;
    // Use this for initialization
    void Start()
    {
        text_actionCost = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        cost_sum = (eventPlay.stage_cost + eventPlay.action_cost_sum);
        text_cost = cost_sum.ToString("N0");
        text_actionCost.text = "費用：-" + text_cost + "円";
    }
}

