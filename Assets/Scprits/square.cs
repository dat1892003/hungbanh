using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class square : MonoBehaviour
{
    public float move;
    float xDirection;
    Game manager;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //khi bam nut sang trai(-1) khi bam sang phai(1)
        xDirection = Input.GetAxisRaw("Horizontal"); //get truc dau vao
        float movestep = move * xDirection * Time.deltaTime;
        if ((transform.position.x <= -10.21 && xDirection==-1 )|| (transform.position.x >= 10.21 && xDirection == 1))
            return;
        transform.position = transform.position+ new Vector3(movestep,0,0);
    }
}
