using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_SikinSC : MonoBehaviour {

    Text text_sikin;
    public EventPlaySC eventPlay;
    string text_fund;
	// Use this for initialization
	void Start () {
        text_sikin = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        text_fund = eventPlay.fund.ToString("N0");
        text_sikin.text = "資金：" + text_fund + "円";
	}
}
