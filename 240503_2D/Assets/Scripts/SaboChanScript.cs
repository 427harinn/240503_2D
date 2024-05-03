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
            //軽量化しましょう
            /*if (SaboMaster.instance.saboList.Count > 1)
            {
                Destroy(SaboMaster.instance.saboList[SaboMaster.instance.saboList.Count - 2].GetComponent<PolygonCollider2D>());
            }*/
            // リスト内のすべてのゲームオブジェクトを探索
            // リストに要素があるかを確認
            //if (SaboMaster.instance.saboList == null || SaboMaster.instance.saboList.Count == 0) return;

            // リストの最後の要素のインデックスを取得
            //int lastIndex = SaboMaster.instance.saboList.Count - 1;

            // 最後の要素を除外してリストを探索
            //for (int i = 0; i < lastIndex; i++)
            //{
                //GameObject obj = SaboMaster.instance.saboList[i]; // リスト内のゲームオブジェクト
                //PolygonCollider2D collider = obj.GetComponent<PolygonCollider2D>(); // Colliderを取得

                ///if (collider != null)
                //{
                    //Destroy(collider); // Colliderを削除
                //}
            //}
       // }
        
    }
}
