using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_FriendIncreaseSC : MonoBehaviour
{

    Text text_friendIncrease;
    public EventPlaySC eventPlay;
    string text_fiend_increase_sum;
    // Use this for initialization
    void Start()
    {
        text_friendIncrease = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text_fiend_increase_sum = eventPlay.friend_increase_sum.ToString("N0");
        text_friendIncrease.text = "友達増加数：" + text_fiend_increase_sum + "人";
    }
}

