using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaboChanScript : MonoBehaviour
{
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
        SaboMaster.instance.sabofalled = true;
        var rb = GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezeAll;

        if(collision.gameObject.tag == "Ground")
        {
            SaboMaster.instance.sabomissed = true;
            this.gameObject.GetComponent<PolygonCollider2D>().enabled = false ;
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
