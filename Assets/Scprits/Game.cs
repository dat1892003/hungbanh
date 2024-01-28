using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject ball;
    public float time;
    float luu_time;
    private int diem;
    bool kt_game;
    UI manager;
    // Start is called before the first frame update
    void Start()
    {
        luu_time = 0;
        manager = FindObjectOfType<UI>();
        manager.set_diem("SCORE:" + diem);
    }

    // Update is called once per frame
    void Update()
    {   
        luu_time -= Time.deltaTime;
        if (kt_game==true)
        {
            luu_time = 0;
            return;
        }
        if (luu_time <= 0)
        {
            xuatbong();
            luu_time = time;
        }
    }
    public void Replay()
    {
        diem = 0;
        kt_game = false;
        manager.showgameover(false);
        manager.set_diem("SCORE:" + diem);
    }
    public void xuatbong()
    {
        Vector2 xuathien = new Vector2(Random.Range(-12, 12), 10);
        if (ball)
        {
            Instantiate(ball, xuathien, Quaternion.identity);
        }
    }
    public void Set_diem(int value)
    {
        diem = value;
    }
    public int Get_diem(int value)
    {
        return diem;
    }
    public void tangdiem()
    {
        diem++;
        manager.set_diem("SCORE:" + diem);
    }
    public void GameOver(bool state)
    {
        kt_game = state;
        manager.showgameover(true);
    }
    public bool getkt()
    {
        return kt_game;
    }
}
