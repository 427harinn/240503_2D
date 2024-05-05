using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using unityroom.Api;

public class FinishScript : MonoBehaviour
{
    [SerializeField] GameObject finishcanva;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay2D(Collider2D other)
    {
        //Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "FinishTag")//各自タグに付けた名前を()の中に入れてください
        {
            finishcanva.SetActive(true);
            UnityroomApiClient.Instance.SendScore(1, GManager.instance.score, ScoreboardWriteMode.Always);
            //Time.timeScale = 0;
            Destroy(SaboMaster.instance.saboList[SaboMaster.instance.saboList.Count - 1].gameObject);
        }
    }
}
