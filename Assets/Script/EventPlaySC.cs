using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class EventPlaySC : MonoBehaviour {

    public GameObject[] action_choose;
    public ToggleGroup mToggleGroup;

    int action_int;

    string stage;
    string action;
    public int fund = 5000;
    public int friend = 5;
    public int stage_sankahi;
    public int stage_cost;
    string action_name;
    public int action_cost;
    public int friend_increase;
    public int action_cost_sum;
    public int friend_increase_sum;
    public int event_profit;
    public int event_sales;
    public int max_capacity;
    public int day_count;

    private int day_sns;
    private int day_kouryu;
    private int day_koekake;
    private int day_goukon;
    private int day_baito;
    private int day_bira;
    private int day_gaitou;
    private int day_koukoku;
    private int day_last_action;

    public int action_count_sum;

    private int flag_sns;
    private int flag_kouryu;
    private int flag_koekake;
    private int flag_goukon;
    private int flag_baito;
    private int flag_bira;
    private int flag_gaitou;
    private int flag_koukoku;
    private int flag_last_action;

    public GameObject baito_kaihou;
    public GameObject bira_kaihou;
    public GameObject gaitou_kaihou;
    public GameObject koukoku_kaihou;
    public GameObject last_action_kaihou;

    public Toggle KJ_izakaya;
    public Toggle KJ_kaigisitu;
    public Toggle KJ_raibu;
    public Toggle KJ_BBQ;
    public Toggle KJ_fes;
    public Toggle KJ_budoukan;

    public GameObject izakaya_kaihou;
    public GameObject kaigisitu_kaihou;
    public GameObject raibu_kaihou;
    public GameObject BBQ_kaihou;
    public GameObject fes_kaihou;
    public GameObject budoukan_kaihou;

    private ToggleAudioSC tglAudioSC;

    public GameObject gameOverText;
    public GameObject gameClearText;



    void Start () {
        tglAudioSC = GameObject.Find("AudioSource").GetComponent<ToggleAudioSC>();
    }
	
	// Update is called once per frame
	void Update () {

        

        //アクションを全てforeachにかけてisOnかどうか調査
        foreach (GameObject g in action_choose)
        {

            bool tgl_bool = g.GetComponent<Toggle>().isOn;
            var tgl = g.GetComponent<Toggle>();

            if (g.name == "AC_SNS")
            {
                if (day_count >= 5 && tgl_bool == false)
                {
                    tgl.interactable = false;
                }
                else
                {
                    tgl.interactable = true;
                }
                day_sns = tgl_bool == true ? 1 : 0;
                flag_sns = day_sns == 0 ? 0 : 1;
            }
            if (g.name == "AC_kouryukai")
            {
                
                    tgl.interactable = true;
                    if (day_count >= 4 && tgl_bool == false)
                    {
                        tgl.interactable = false;
                    }
                    else
                    {
                        tgl.interactable = true;
                    }
                    day_kouryu = tgl_bool == true ? 2 : 0;
                    flag_kouryu = day_kouryu == 0 ? 0 : 1;
            }
            if (g.name == "AC_koekake")
            {
                if (day_count >= 4 && tgl_bool == false)
                {
                    tgl.interactable = false;
                }
                else
                {
                    tgl.interactable = true;
                }
                day_koekake = tgl_bool == true ? 2 : 0;
                flag_koekake = day_koekake == 0 ? 0 : 1;
            }
            if (g.name == "AC_goukon")
            {
                if (day_count >= 3 && tgl_bool == false)
                {
                    tgl.interactable = false;
                }
                else
                {
                    tgl.interactable = true;
                }
                day_goukon = tgl_bool == true ? 3 : 0;
                flag_goukon = day_goukon == 0 ? 0 : 1;
            }
            if (g.name == "AC_baito")
            {
                if (friend < 50)
                {
                    tgl.interactable = false;
                    continue;
                }
                else
                {
                    baito_kaihou.SetActive(false);
                    if (day_count >= 5 && tgl_bool == false)
                    {
                        tgl.interactable = false;
                    }
                    else
                    {
                        tgl.interactable = true;
                    }
                    day_baito = tgl_bool == true ? 1 : 0;
                    flag_baito = day_baito == 0 ? 0 : 1;
                }
            }
            if (g.name == "AC_bira")
            {
                if (friend < 100)
                {
                    tgl.interactable = false;
                    continue;
                }
                else
                {
                    bira_kaihou.SetActive(false);
                    if (day_count >= 2 && tgl_bool == false)
                    {
                        tgl.interactable = false;
                    }
                    else
                    {
                        tgl.interactable = true;
                    }
                    day_bira = tgl_bool == true ? 4 : 0;
                    flag_bira = day_bira == 0 ? 0 : 1;
                }
            }
            if (g.name == "AC_gaitouenzetu")
            {
                if (friend < 150)
                {
                    tgl.interactable = false;
                    continue;
                }
                else
                {
                    gaitou_kaihou.SetActive(false);
                    if (day_count >= 3 && tgl_bool == false)
                    {
                        tgl.interactable = false;
                    }
                    else
                    {
                        tgl.interactable = true;
                    }
                    day_gaitou = tgl_bool == true ? 3 : 0;
                    flag_gaitou = day_gaitou == 0 ? 0 : 1;
                }
            }
            if (g.name == "AC_koukoku")
            {
                if (friend < 300)
                {
                    tgl.interactable = false;
                    continue;
                }
                else
                {
                    koukoku_kaihou.SetActive(false);
                    if (day_count >= 4 && tgl_bool == false)
                    {
                        tgl.interactable = false;
                    }
                    else
                    {
                        tgl.interactable = true;
                    }
                    day_koukoku = tgl_bool == true ? 2 : 0;
                    flag_koukoku = day_koukoku == 0 ? 0 : 1;
                }
            }
            if (g.name == "AC_last_action")
            {
                if (friend < 500)
                {
                    tgl.interactable = false;
                    continue;
                }
                else
                {
                    last_action_kaihou.SetActive(false);
                    if (day_count >= 1 && tgl_bool == false)
                    {
                        tgl.interactable = false;
                    }
                    else
                    {
                        tgl.interactable = true;
                    }
                    day_last_action = tgl_bool == true ? 5 : 0;
                    flag_last_action = day_last_action == 0 ? 0 : 1;
                }
            }
        }

        //合計選択日数
        day_count = day_sns + day_kouryu + day_koekake + day_goukon + day_baito + day_bira +
                day_gaitou + day_koukoku + day_last_action;

        KJ_izakaya.interactable = friend < 30 ? false : true;
        KJ_kaigisitu.interactable = friend < 80 ? false : true;
        KJ_raibu.interactable = friend < 130 ? false : true;
        KJ_BBQ.interactable = friend < 180 ? false : true;
        KJ_fes.interactable = friend < 250 ? false : true;
        KJ_budoukan.interactable = friend < 400 ? false : true;
        if (friend >= 30)
        {
            izakaya_kaihou.SetActive(false);
        }
        if (friend >= 80)
        {
            kaigisitu_kaihou.SetActive(false);
        }
        if (friend >= 130)
        {
            raibu_kaihou.SetActive(false);
        }
        if (friend >= 180)
        {
            BBQ_kaihou.SetActive(false);
        }
        if (friend >= 250)
        {
            fes_kaihou.SetActive(false);
        }
        if (friend >= 400)
        {
            budoukan_kaihou.SetActive(false);
        }


        bool tglglp = mToggleGroup.AnyTogglesOn();

        //会場が選択されているかつ、アクションが一つ以上選択されている場合、イベント実行ボタンを有効化
        if (tglglp && day_count != 0)
        {
            GetComponent<Button>().interactable = true;
        } else {
            GetComponent<Button>().interactable = false;
        }
       

    }

    public void Play ()
    {
        
        //実行するアクションのリスト
        List<string> action_playList = new List<string>();
        //アクションにかかったコスト
        List<int> action_costList = new List<int>();
        //アクションによって増えた友達の数
        List<int> friend_increaseList = new List<int>();

        //初期値にリセット
        action_cost_sum = 0;
        friend_increase_sum = 0;
        event_sales = 0;
        event_profit = 0;

        //現在OnになっているToggleボタンを判別して、文字列にする
        string stage_name = mToggleGroup.ActiveToggles().FirstOrDefault().ToString();

        //選択されたアクションをリストに追加
        foreach (GameObject g in action_choose)
        {
            if (g.GetComponent<Toggle>().isOn)
            {
                action_playList.Add(g.gameObject.name);
                action_int++;
            }
        }

        //アクションごとに変数の値を設定
        for (int i = 0; i < action_int; i++)
        {
            switch (action_playList[i])
            {
                case "AC_SNS":
                    action_cost = 100;
                    friend_increase = Random.Range(1, 4);
                    action_costList.Add(action_cost);
                    friend_increaseList.Add(friend_increase);
                    Debug.Log("SNSを実行");
                    break;

                case "AC_kouryukai":
                    action_cost = 3000;
                    friend_increase = Random.Range(5, 10);
                    Debug.Log("交流会を実行");
                    action_costList.Add(action_cost);
                    friend_increaseList.Add(friend_increase);
                    break;

                case "AC_koekake":
                    action_cost = 1000;
                    friend_increase = Random.Range(3, 6);
                    action_costList.Add(action_cost);
                    friend_increaseList.Add(friend_increase);
                    Debug.Log("声かけを実行");
                    break;

                case "AC_goukon":
                    action_cost = 2000;
                    friend_increase = Random.Range(5, 9);
                    action_costList.Add(action_cost);
                    friend_increaseList.Add(friend_increase);
                    Debug.Log("合コンを実行");
                    break;

                case "AC_baito":
                    action_cost = 50000;
                    friend_increase = Random.Range(12, 21);
                    action_costList.Add(action_cost);
                    friend_increaseList.Add(friend_increase);
                    Debug.Log("バイトを雇うを実行");
                    break;

                case "AC_bira":
                    action_cost = 50000;
                    friend_increase = Random.Range(15, 31);
                    action_costList.Add(action_cost);
                    friend_increaseList.Add(friend_increase);
                    Debug.Log("ビラ配りを実行");
                    break;

                case "AC_gaitouenzetu":
                    action_cost = 500000;
                    friend_increase = Random.Range(1, 101);
                    action_costList.Add(action_cost);
                    friend_increaseList.Add(friend_increase);
                    Debug.Log("街頭演説を実行");
                    break;

                case "AC_koukoku":
                    action_cost = 1000000;
                    friend_increase = Random.Range(50, 81);
                    action_costList.Add(action_cost);
                    friend_increaseList.Add(friend_increase);
                    Debug.Log("広告を実行");
                    break;

                case "AC_last_action":
                    action_cost = 100000000;
                    friend_increase = 1000;
                    action_costList.Add(action_cost);
                    friend_increaseList.Add(friend_increase);
                    Debug.Log("秘密の手口を実行");
                    break;
            }
        }

        //アクションにかかった費用と、増えた友達の数を集計
        action_cost_sum = action_costList.Sum();
        friend_increase_sum = friend_increaseList.Sum();

        friend += friend_increase_sum;
        friend = friend > 1000 ? 1000 : friend;

        //文字列にした会場名ごとに、会場費・参加費を変数に設定
        switch (stage_name)
        {
            case "KJ_A (UnityEngine.UI.Toggle)":
                stage_name = "公園";
                max_capacity = 10;
                stage_sankahi = 500;
                stage_cost = 0;
                break;

            case "KJ_B (UnityEngine.UI.Toggle)":
                stage_name = "バー";
                max_capacity = 30;
                stage_sankahi = 1000;
                stage_cost = 6000;
                break;

            case "KJ_C (UnityEngine.UI.Toggle)":
                stage_name = "カラオケハウス";
                max_capacity = 50;
                stage_sankahi = 1500;
                stage_cost = 15000;
                break;

            case "KJ_D (UnityEngine.UI.Toggle)":
                stage_name = "居酒屋";
                max_capacity = 100;
                stage_sankahi = 2000;
                stage_cost = 40000;
                break;

            case "KJ_E (UnityEngine.UI.Toggle)":
                stage_name = "貸し会議室";
                max_capacity = 150;
                stage_sankahi = 2500;
                stage_cost = 75000;
                break;

            case "KJ_F (UnityEngine.UI.Toggle)":
                stage_name = "ライブハウス";
                max_capacity = 200;
                stage_sankahi = 3000;
                stage_cost = 120000;
                break;

            case "KJ_G (UnityEngine.UI.Toggle)":
                stage_name = "BBQ場";
                max_capacity = 350;
                stage_sankahi = 4000;
                stage_cost = 280000;
                break;

            case "KJ_H (UnityEngine.UI.Toggle)":
                stage_name = "屋外フェス会場";
                max_capacity = 500;
                stage_sankahi = 5000;
                stage_cost = 500000;
                break;

            case "KJ_I (UnityEngine.UI.Toggle)":
                stage_name = "日本武道館";
                max_capacity = 1000;
                stage_sankahi = 10000;
                stage_cost = 2000000;
                break;
        }
        //会場の最大人数を超えた場合、最大人数分の参加費しか回収できない
        event_sales = friend > max_capacity ? stage_sankahi * max_capacity : stage_sankahi * friend;

        event_profit = event_sales - (stage_cost + action_cost_sum);
        fund += event_profit;

        Debug.Log(string.Format("集客費は{0}円で、増えた友達は{1}人でした",action_cost_sum,friend_increase_sum));
        Debug.Log(string.Format("会場は{0}で、会場費は{1}円、参加費は{2}円です", stage_name, stage_cost, event_sales));
        Debug.Log(string.Format("現在の所持金は{0}円で、友達の総数は{1}人です", fund, friend));


        //それぞれの値ををリセット
        action_int = 0;

        //会場選択ボタンをリセット
        mToggleGroup.SetAllTogglesOff();
        //アクション選択ボタンをリセット
        foreach (GameObject g in action_choose)
        {
            g.GetComponent<Toggle>().isOn = false;
        }
        tglAudioSC.EventPlayAudio();

        if (fund < 0)
        {
            gameOverText.SetActive(true);
            tglAudioSC.GameOverAudio();
        }

        if (friend >= 1000)
        {
            gameClearText.SetActive(true);
            tglAudioSC.GameClearAudio();
        }
    }
}

