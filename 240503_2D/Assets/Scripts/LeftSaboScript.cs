using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftSaboScript : MonoBehaviour
{
    // Start is called before the first frame update
    float iniY;
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = SaboMaster.instance.saboList[SaboMaster.instance.saboList.Count - 1];
        // transform���擾
        Transform myTransform = obj.transform;

        // ���W���擾
        Vector3 pos = myTransform.position;
        iniY = pos.y;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void onClicked_leftsabobutton()
    {
        GameObject obj = SaboMaster.instance.saboList[SaboMaster.instance.saboList.Count - 1];
        // transform���擾
        Transform myTransform = obj.transform;

        // ���W���擾
        Vector3 pos = myTransform.position;
        pos.x -= 0.5f;    // x���W��0.01���Z
        //pos.y = iniY;
        if (pos.x < -2.3)
        {
            pos.x = -2.3f;
        }

        myTransform.position = pos;  // ���W��ݒ�
    }
}
