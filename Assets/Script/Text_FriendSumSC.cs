using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_FriendSumSC : MonoBehaviour{

    Text text_friendSum;
    public EventPlaySC eventPlay;
    string text_friend;

    void Start()
    {
        text_friendSum = GetComponent<Text>();
    }

    void Update()
    {
        text_friend = eventPlay.friend.ToString("N0");
        text_friendSum.text = "友達数：" + text_friend + "人";
    }
}
