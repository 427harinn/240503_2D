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
        // transform‚ğæ“¾
        Transform myTransform = obj.transform;
        // Œ»İ‚ÌÀ•W‚©‚ç‚Ìxyz ‚ğ1‚¸‚Â‰ÁZ‚µ‚ÄˆÚ“®
        myTransform.Translate(0.5f, 0f, 0f);
    }
}
