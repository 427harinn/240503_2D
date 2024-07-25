using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaboChanScript : MonoBehaviour
{
    bool hit = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.tag != "Ground")
        {
            collision.gameObject.tag = "FinishTag";
            collision.gameObject.transform.parent.gameObject.tag = "FinishTag";
        }

        if (collision.gameObject.tag != null)
        {
            this.gameObject.transform.parent.gameObject.tag = "FinishTag";
        }

        /*var rb2 = SaboMaster.instance.saboList[SaboMaster.instance.saboList.Count - 1].gameObject.GetComponent<Rigidbody2D>();
        Destroy(rb2);
        Destroy(SaboMaster.instance.saboList[SaboMaster.instance.saboList.Count - 1].gameObject.GetComponent<NormalSaboRotationScript>());*/

        if(collision.gameObject.tag == "FinishTag" || collision.gameObject.tag == "Ground")
        {
            
            var rb2 = this.gameObject.transform.parent.gameObject.GetComponent<Rigidbody2D>();
            if(rb2) {
                if(GManager.instance.finishflag == false)
                {
                    GManager.instance.score++;
                    SaboMaster.instance.saboList[SaboMaster.instance.saboList.Count - 1].transform.GetChild(0).transform.GetChild(1).gameObject.SetActive(true);
                    Destroy(rb2);
                    Destroy(this.gameObject.transform.parent.gameObject.GetComponent<NormalSaboRotationScript>());
                }

            }

        }


        SaboMaster.instance.sabofalled = true;
        var rb = GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezeAll;

        //var rb2 = gameObject.transform.parent.gameObject.GetComponent<Rigidbody2D>();
        //Destroy(rb2);
        //Destroy(gameObject.transform.parent.gameObject.GetComponent<NormalSaboRotationScript>());


        if (collision.gameObject.tag == "Ground" && this.gameObject.tag != "FinishTag")
        {
            this.gameObject.transform.parent.name = "naesabo";
            SaboMaster.instance.sabomissed = true;
            this.gameObject.GetComponent<PolygonCollider2D>().enabled = false ;
        }



        if (SaboMaster.instance.saboList.Count > 1)
        {
            Destroy(SaboMaster.instance.saboList[SaboMaster.instance.saboList.Count - 2].GetComponent<PolygonCollider2D>());
        }
        //else
        //{
        //�y�ʉ����܂��傤
        /*if (SaboMaster.instance.saboList.Count > 1)
        {
            Destroy(SaboMaster.instance.saboList[SaboMaster.instance.saboList.Count - 2].GetComponent<PolygonCollider2D>());
        }*/
        // ���X�g���̂��ׂẴQ�[���I�u�W�F�N�g��T��
        // ���X�g�ɗv�f�����邩���m�F
        //if (SaboMaster.instance.saboList == null || SaboMaster.instance.saboList.Count == 0) return;

        // ���X�g�̍Ō�̗v�f�̃C���f�b�N�X���擾
        //int lastIndex = SaboMaster.instance.saboList.Count - 1;

        // �Ō�̗v�f�����O���ă��X�g��T��
        //for (int i = 0; i < lastIndex; i++)
        //{
        //GameObject obj = SaboMaster.instance.saboList[i]; // ���X�g���̃Q�[���I�u�W�F�N�g
        //PolygonCollider2D collider = obj.GetComponent<PolygonCollider2D>(); // Collider���擾

        ///if (collider != null)
        //{
        //Destroy(collider); // Collider���폜
        //}
        //}
        // }

    }
}
