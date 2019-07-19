using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_StageCostSC : MonoBehaviour
{

    Text text_stageCost;
    public EventPlaySC eventPlay;
    string text_stage_cost;
    // Use this for initialization
    void Start()
    {
        text_stageCost = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text_stage_cost = eventPlay.stage_cost.ToString();
        text_stageCost.text = "会場費用：-" + text_stage_cost + "円";
    }
}
