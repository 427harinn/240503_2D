using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightSaboScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClicked_rightsabobutton()
    {
        GameObject obj= SaboMaster.instance.saboList[SaboMaster.instance.saboList.Count - 1];
        // transform���擾
        Transform myTransform = obj.transform;
        // ���݂̍��W�����xyz ��1�����Z���Ĉړ�
        myTransform.Translate(0.5f, 0f, 0f);
    }
}
