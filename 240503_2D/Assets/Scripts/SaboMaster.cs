using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaboMaster : MonoBehaviour
{
    public static SaboMaster instance = null;

    [SerializeField] AudioClip puyo;
    [SerializeField] List<GameObject> originsabolist;
    [SerializeField] Sprite naesabo;

    public bool sabofalled = false;
    public bool sabomissed = false;

    public GameObject parent;

    public List<GameObject> saboList;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            //DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            //Destroy(this.gameObject);
        }
        SaboGenerate();
    }


    private void Update()
    {

        if (sabofalled)
        {
            if (sabomissed)
            {
                saboList[saboList.Count - 1].transform.GetChild(0).transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = naesabo;
                GManager.instance.score -= 2;
                sabomissed = false;
            }
            //saboList[saboList.Count - 1].transform.GetChild(0).transform.GetChild(1).gameObject.SetActive(true);
            this.gameObject.GetComponent<AudioSource>().PlayOneShot(puyo);
            SaboGenerate();
            //GManager.instance.score++;
            sabofalled = false;
        }
    }



    public void SaboGenerate()
    {

        var children = new Transform[parent.transform.childCount];
        var childIndex = 0;

        int count = 0;
        // 子オブジェクトを順番に配列に格納
        foreach (Transform child in parent.transform)
        {
            children[childIndex++] = child;

            Debug.Log(child.gameObject.tag);
            if (child.gameObject.tag == "FinishTag")
            {
                count++;
            }

        }

        //Debug.Log(count + " " + (parent.transform.childCount));*/
        if(count == (parent.transform.childCount))
        {
            GameObject obj = Instantiate(
            originsabolist[Random.Range(0, originsabolist.Count)],
            new Vector3(-16.5f, 359.4f, -0.0008180315f),
            Quaternion.identity
            );
            obj.transform.SetParent(parent.transform, false);

            saboList.Add(obj);
        }
        

    }
    /*
    [SerializeField] GameObject originObject;

    public bool sabofalled = false;
    public bool sabomissed = false;

    public GameObject parent;

    float posY_add;
    float posY = -910;

    float cameraY_add;
    public float moveDuration = 1.0f; // パネルが移動するのにかかる時間


    public List<GameObject> saboList;

    public float finishY;
    public float prevY;
    void Awake()
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
        if (sabofalled)
        {
            finishY = saboList[saboList.Count - 1].transform.localPosition.y;

            posY_add = Mathf.Abs(finishY - prevY);
            posY_add = posY_add - 200;
            posY_add = 200 - posY_add;

            if (sabomissed)
            {
                GManager.instance.score--;
                sabomissed = false;
                posY_add = 0;
            }

            SaboGenerate();
            GManager.instance.score++;
            sabofalled = false;

            // パネルをスムーズに移動するためにコルーチンを呼び出す
            StartCoroutine(MoveParentDown(posY_add, moveDuration));
        }

    }

    IEnumerator MoveParentDown(float moveAmount, float duration)
    {
        float startTime = Time.time;
        Vector3 startPos = parent.transform.localPosition;
        Vector3 endPos = startPos;
        endPos.y -= moveAmount;

        while (Time.time - startTime < duration)
        {
            float t = (Time.time - startTime) / duration;
            parent.transform.localPosition = Vector3.Lerp(startPos, endPos, t);
            yield return null; // フレームごとに次のフレームまで待つ
        }

        // ループ終了後、位置を最終値に合わせる
        parent.transform.localPosition = endPos;
    }

    public void SaboGenerate()
    {
        posY += posY_add;
        GameObject obj = Instantiate(
            originObject,
            new Vector3(29, posY, -4859.363f),
            Quaternion.identity
        );
        obj.transform.SetParent(parent.transform, false);

        saboList.Add(obj.transform.GetChild(0).gameObject);
    }
    */
}
