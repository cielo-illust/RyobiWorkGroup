using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebView : MonoBehaviour {

    private string url = "http://www.tamarun.jp/";
    WebViewObject webViewObject;

    // Use this for initialization
    void Start () {
        webViewObject = (new GameObject("WebViewObject")).AddComponent<WebViewObject>();
        webViewObject.Init((msg) => {
            Debug.Log(msg);
        });
        webViewObject.LoadURL(url);
        webViewObject.SetMargins(0, 0, 0, 0);
        webViewObject.SetVisibility(true);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
