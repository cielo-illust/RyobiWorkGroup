using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RyobiWorkGroupController : MonoBehaviour {

    public Text text;
    public int clickFlag = 0;
    string m_url = "http://cielo-illust.sakura.ne.jp/user_get.php";


    // Use this for initialization
    void Start() {
        DateTime thisDay = DateTime.Now;
        text.text = thisDay.ToString("G");
    }

    // Update is called once per frame
    void Update() {
        if (clickFlag == 0)
        {
            DateTime thisDay = DateTime.Now;
            text.text = thisDay.ToString("G");
        }
    }

    public void ButtonOnClick()
    {
        if (clickFlag == 0)
        {
            clickFlag = 1;
            StartCoroutine(GetUser());
        } else
        {
            clickFlag = 0;
        }
    }

    IEnumerator GetUser()
    {
        text.text = "送信";
        WWW result = new WWW(m_url);
        text.text = result.ToString();
        yield return result;

        text.text = "aaa";
        if (result.error == null)
        {
            text.text = result.text;
            Items items = JsonUtility.FromJson<Items>(result.text);
            text.text = "aaa ";
            text.text = "aaa " + items.item.Length.ToString();
            if (items.item.Length != 0 )
            {
                Item item = JsonUtility.FromJson<Item>(items.item[0].ToString());
                text.text = items.item[0].ToString();
            }
        }
    }
}

[Serializable]
public class Items
{
    public Item[] item;
}
[Serializable]
public class Item
{
    public int id;
    public string sex;
}