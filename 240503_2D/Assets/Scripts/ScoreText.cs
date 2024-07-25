using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    Text textScore;
    // Start is called before the first frame update
    void Start()
    {
        textScore = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textScore.text = GManager.instance.score + "";
    }
}
