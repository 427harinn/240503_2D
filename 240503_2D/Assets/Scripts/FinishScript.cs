using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if (other.gameObject.tag == "FinishTag")//�e���^�O�ɕt�������O��()�̒��ɓ���Ă�������
        {
            finishcanva.SetActive(true);
            //Time.timeScale = 0;
            Destroy(SaboMaster.instance.saboList[SaboMaster.instance.saboList.Count - 1].gameObject);
        }
    }
}
