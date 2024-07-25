using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GManager : MonoBehaviour
{
    public static GManager instance = null;

    public int score = 0;

    public bool finishflag = false;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    void Update()
    {

    }
}