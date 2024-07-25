using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClickScript : MonoBehaviour
{
    public SceneObject nextScene;
    public GameObject nextPanel;
    public GameObject closePanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClicked_LoadSceneButton()
    {
        Invoke("loadscene",1.0f);
    }

    public void onClicked_PanelActiveButton()
    {
        nextPanel.SetActive(true);
    }

    public void onClicked_PanelCloseButton()
    {
        closePanel.SetActive(false);
    }

    public void loadscene()
    {
        SceneManager.LoadScene(nextScene);
        
    }
}
