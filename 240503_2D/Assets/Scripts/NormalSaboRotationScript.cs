using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class NormalSaboRotationScript : MonoBehaviour
{
    Transform myTransform;

    public float zForth;
    // Start is called before the first frame update
    void Start()
    {
        // transform‚ðŽæ“¾
        myTransform = this.transform;
    }

    // Update is called once per frame
    void Update()
    {

        myTransform.Rotate(0f, 0f, zForth * Time.deltaTime, Space.World);
    }
}
