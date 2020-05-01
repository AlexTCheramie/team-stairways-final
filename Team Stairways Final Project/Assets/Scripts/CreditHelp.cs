using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditHelp : MonoBehaviour
{
    //these two gameobjects are to open the help/credit panel.
    public GameObject helpMenu;
    public GameObject creditScreen;
    //these booleans are in case you need to check whether the credits or help panels are open
    public static bool helpOpen = false;
    public static bool creditOpen = false;

    //timer and how long the credits will last (seconds)
    public float timer = 0;
    public float creditLength = 30;
    // Start is called before the first frame update
    void Start()
    {
        helpOpen = false;
        creditOpen = false;
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (creditOpen)
        {
            timer += Time.deltaTime;
            if (timer >= creditLength)
            {
                CreditScreenClose();
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetMouseButtonDown(0))
            {
                if (helpOpen)
                {
                    HelpMenuClose();
                }
                if (creditOpen)
                {
                    CreditScreenClose();
                }
            }
        
    }

    public void HelpMenu()
    {
        helpMenu.SetActive(true);
        helpOpen = true;
    }

    public void CreditScreen()
    {
        creditScreen.SetActive(true);
        creditOpen = true;
    }

    public void HelpMenuClose()
    {
        helpMenu.SetActive(false);
        helpOpen = false;
    }

    public void CreditScreenClose()
    {
        creditScreen.SetActive(false);
        creditOpen = false;
        timer = 0;
    }
}
