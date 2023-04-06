using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameManager : MonoBehaviour
{
    public Animator BuymesgAnim;
    //public TextMeshProUGUI BuymesgText;
    private string buyItem;
    public TMP_Text buymesgText;
    public TMP_Text ListText;
    public TMP_Text LmilkText;
    public TMP_Text SmilkText;
    public GameObject ListPanel;
    public int Lmilks = 0;
    public int Smilks = 0;



    // Start is called before the first frame update
    void Start()
    {
        //BagCanvas.enabled = false;
        ListPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //if press L key, buy large milk
        if (Input.GetKeyDown(KeyCode.L))
        {
            ListText.text = "Items: ";
            buyItem = "large milk(Purple)";
            buymesgText.text = "You bought " + buyItem + " !";

            Lmilks += 1;

            //update list text
            LmilkText.text = buyItem + " " + Lmilks;

            //play animation
            BuymesgAnim.SetTrigger("buyUp");
            Invoke("buyReminderOff", 3.5f);

        }



        //if press S key, buy small milk
        if (Input.GetKeyDown(KeyCode.S))
        {
            ListText.text = "Items: ";
            buyItem = "small milk(Blue)";
            buymesgText.text = "You bought " + buyItem + " !";
            Smilks += 1;
            //update list text

            SmilkText.text = buyItem + " " + Smilks;
            //play animation
            BuymesgAnim.SetTrigger("buyUp");
            Invoke("buyReminderOff", 3.5f);
        }
        //press b open bag
        if (Input.GetKeyDown(KeyCode.B))
        {
            //BagCanvas.enabled = true;
            ListPanel.SetActive(true);
        }
        //press c close bag
        if (Input.GetKeyDown(KeyCode.C))
        {
            //BagCanvas.enabled = false;
            ListPanel.SetActive(false);
        }
    }

    private void buyReminderOff()
    {
        //play animation
        BuymesgAnim.SetTrigger("buyOff");
    }
}
