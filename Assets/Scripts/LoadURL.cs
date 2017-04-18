using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadURL : MonoBehaviour {

    public void LoadingURL(string url)
    {
        Application.OpenURL(url);
    }
}
