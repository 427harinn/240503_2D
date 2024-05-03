using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVbuttonScript : MonoBehaviour
{
    GameObject canva;
    TextDisplay textdisp;

    [SerializeField] GameObject textbox;
    [SerializeField] GameObject textfinishButton;
    [SerializeField] GameObject TVSelectPanel;
    // Start is called before the first frame update
    void Start()
    {
       textdisp = textbox.transform.GetChild(0).transform.GetChild(0).gameObject.GetComponent<TextDisplay>();
    }

    // Update is called once per frame
    void Update()
    {
        if(textdisp.textfinished)
        {
            textfinishButton.SetActive(true);
        }
    }

    public void onClickd_TVbutton()
    {
        textbox.SetActive(true);
        textdisp.SetText("TV‚ª‰Ÿ‚³‚ê‚½‚æ");
    }

    public void onClicked_textbuttonfinish()
    {
        TVSelectPanel.SetActive(true);
    }

    public void onClicked_Yesbutton()
    {
        GManager.instance.TVPara++;
        textbox.SetActive(false);
        TVSelectPanel.SetActive(false);
        textfinishButton.SetActive(false);
        textdisp.textfinished = false;
    }

    public void onClicked_Nobutton()
    {
        textbox.SetActive(false);
        TVSelectPanel.SetActive(false);
        textfinishButton.SetActive(false);
        textdisp.textfinished = false;
    }
}
