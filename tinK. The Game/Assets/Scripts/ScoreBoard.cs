using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour
{

    //Game objecten voor sterren

    public GameObject ster1;
    public GameObject ster2;
    public GameObject ster3;
    public GameObject ster4;
    public GameObject ster5;



    public TMP_Text scoreTekst;

    public string[] winText;

    private int score = 0;

    private void Update()
    {
        StarUp();
    }

    public void ScoreUp()
    {
        score++;
    }

    public void StarUp()
    {
        if (score == 0f)
        {
            scoreTekst.text = winText[0];
        }
        if (score == 1f)
        {
            ster1.SetActive(true);
            scoreTekst.text = winText[1];
        }
        if (score == 2f)
        {
            ster1.SetActive(true);
            ster2.SetActive(true);
            scoreTekst.text = winText[2];
        }
        if (score == 3f)
        {
            ster1.SetActive(true);
            ster2.SetActive(true);
            ster3.SetActive(true);
            scoreTekst.text = winText[3];
        }
        if (score == 4f)
        {
            ster1.SetActive(true);
            ster2.SetActive(true);
            ster3.SetActive(true);
            ster4.SetActive(true);
            scoreTekst.text = winText[4];
        }
        if (score == 5f)
        {
            ster1.SetActive(true);
            ster2.SetActive(true);
            ster3.SetActive(true);
            ster4.SetActive(true);
            ster5.SetActive(true);
            scoreTekst.text = winText[5];
        }
    }

    public void ResetScore()
    {
        score = 0;
    }
}
