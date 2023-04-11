using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unitScript : MonoBehaviour
{
    public GameManager gm;
    //public bool selected = false;
    private Vector3 biggerScale, normalScale, selectedScale;
    void Start()
    {
        normalScale = new Vector3(2.75f, 2.75f, 2.75f);
        biggerScale = new Vector3(3.5f, 3.5f, 3.5f);//if mouse hover
        selectedScale = new Vector3(3.8f, 3.8f, 3.8f);//if click to purchase
    }

    void Update()
    {

    }

    private void OnMouseEnter()
    {
        transform.localScale = biggerScale;

    }

    private void OnMouseExit()
    {
        transform.localScale = normalScale;
    }

    private void OnMouseDown()
    {
        //selected = true;
        transform.localScale = selectedScale;
        gm.purchaseSmallMilk();

    }

}
