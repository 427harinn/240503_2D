using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallScript : MonoBehaviour
{
    //�ϐ������
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void onClicked_fall()
    {
        SaboMaster.instance.prevY = SaboMaster.instance.saboList[SaboMaster.instance.saboList.Count - 1].transform.localPosition.y;
        //Rigidbody2D���擾
        rb = SaboMaster.instance.saboList[SaboMaster.instance.saboList.Count - 1].GetComponent<Rigidbody2D>();
        rb.gravityScale = 1;
    }
}
