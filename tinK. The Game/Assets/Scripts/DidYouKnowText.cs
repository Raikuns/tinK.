using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DidYouKnowText : MonoBehaviour {

    public TMP_Text text;

    public string[] didyouknows;

    private void Start()
    {
        text.text = didyouknows[(Mathf.RoundToInt(Random.Range(0, didyouknows.Length - 1)))];
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            text.text = didyouknows[(Mathf.RoundToInt(Random.Range(0, didyouknows.Length - 1)))];
        }
    }
}
