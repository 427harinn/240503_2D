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
