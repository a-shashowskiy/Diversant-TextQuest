using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdsOnTime : MonoBehaviour {
    
    // Use this for initialization
    void Start () {
        
        StartCoroutine(AdsToTime());
    }
	
	// Update is called once per frame
	void Update () {
    }

    IEnumerator AdsToTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(300);
            FGLEnhance.ShowInterstitialAd(FGLEnhance.INTERSTITIAL_PLACEMENT_DEFAULT);
        }
       
    }
}
