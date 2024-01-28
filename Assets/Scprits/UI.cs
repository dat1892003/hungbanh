using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI : MonoBehaviour
{
    public Text score;
    public GameObject gameover;
    public void set_diem(string txt)
    {
        if (score)
            score.text = txt;
    }
    public void showgameover(bool a)
    {
        if (gameObject)
            gameover.SetActive(a);
    }
}
