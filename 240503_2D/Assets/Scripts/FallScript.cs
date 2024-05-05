using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallScript : MonoBehaviour
{
    //•Ï”‚ğì‚é
    Rigidbody2D rb;
    [SerializeField] GameObject buttonstopImage;
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
        buttonstopImage.SetActive(true);
        //SaboMaster.instance.prevY = SaboMaster.instance.saboList[SaboMaster.instance.saboList.Count - 1].gameObject.transform.localPosition.y;
        //Rigidbody2D‚ğæ“¾
        rb = SaboMaster.instance.saboList[SaboMaster.instance.saboList.Count - 1].gameObject.GetComponent<Rigidbody2D>();
        rb.gravityScale = 1;

        //SaboMaster.instance.prevY = SaboMaster.instance.saboList[SaboMaster.instance.saboList.Count - 1].transform.GetChild(0).gameObject.transform.localPosition.y;
        //Rigidbody2D‚ğæ“¾
        rb = SaboMaster.instance.saboList[SaboMaster.instance.saboList.Count - 1].transform.GetChild(0).gameObject.GetComponent<Rigidbody2D>();
        rb.gravityScale = 1;
    }
}
