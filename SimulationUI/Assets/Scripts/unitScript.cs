using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unitScript : MonoBehaviour
{
    public bool seleced = false;
    private Vector3 biggerScale, normalScale;
    void Start()
    {
        normalScale = new Vector3(2.75f, 2.75f, 2.75f);
        biggerScale = new Vector3(3.5f, 3.5f, 3.5f);
    }

    void Update()
    {

    }

    private void OnMouseEnter()
    {

    }

}
