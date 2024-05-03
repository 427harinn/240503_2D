using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaboMaster : MonoBehaviour
{
    public static SaboMaster instance = null;

    [SerializeField] GameObject originObject;

    public bool sabofalled = false;
    public bool sabomissed = false;

    public GameObject parent;

    float posY_add;
    float posY = -910;

    float cameraY_add;
    public float moveDuration = 1.0f; // �p�l�����ړ�����̂ɂ����鎞��


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

            // �p�l�����X���[�Y�Ɉړ����邽�߂ɃR���[�`�����Ăяo��
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
            yield return null; // �t���[�����ƂɎ��̃t���[���܂ő҂�
        }

        // ���[�v�I����A�ʒu���ŏI�l�ɍ��킹��
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

        saboList.Add(obj);
    }
}
