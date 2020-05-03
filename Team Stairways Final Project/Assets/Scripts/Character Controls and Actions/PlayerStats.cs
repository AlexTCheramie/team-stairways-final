using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public static int maxHealth = 3;
    public static int playerHealth;
    public static bool hasGun = true;
    public static bool hasSword = true;
    public static bool isAttacking = false;

    public GameObject sword;
    public GameObject gun;
    public GameObject swordbox;
    public GameObject bullet;
    public GameObject emitter;
    public static string Using = "";

    // Start is called before the first frame update
    void Start()
    {
        //Player spawn with full HP
        playerHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        //Make sure the player's HP does not go higher than wanted
        if (playerHealth > maxHealth)
        {
            playerHealth = maxHealth;
        }

        if(playerHealth <= 0)
        {
            SceneManager.LoadScene("Dead Screen");
        }

        //HP Stuff for Testing
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerHealth -= 1;
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            playerHealth += 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (hasGun)
            {
                equipmentDisplay.ChangeCurrentEquip(1);
                gun.SetActive(true);
                sword.SetActive(false);
                Using = "gun";
            }
                
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (hasSword)
            {
                equipmentDisplay.ChangeCurrentEquip(2);
                sword.SetActive(true);
                gun.SetActive(false);
                Using = "sword";
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            equipmentDisplay.ChangeCurrentEquip(3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            equipmentDisplay.ChangeCurrentEquip(4);
        }
        
        if (Input.GetKeyDown(KeyCode.Mouse0) && isAttacking == false)
        {
            Attack();
        }

    }

    //Static function for adding health to the player (send it negative value to subtract health)
    public static void AddHealth(int amt)
    {
        playerHealth += amt;
    }

    //We die like men, here are the attacking scripts as well.

    public void Attack()
    {
        isAttacking = true;
        if(hasSword == true && Using == "sword")
        {
            swordbox.SetActive(true);
            StartCoroutine(SwordHitboxActive(0.5f));
        }

        else if(hasGun == true && Using == "gun")
        {
            Shoot();
            StartCoroutine(Cooldown(1.0f));
        }

    }

    public IEnumerator Cooldown(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        isAttacking = false;
    }

    public IEnumerator SwordHitboxActive(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        swordbox.SetActive(false);
        StartCoroutine(Cooldown(1.0f));
    }
    public void Shoot()
    {
        GameObject currentBullet = Instantiate(bullet, emitter.transform.position, emitter.transform.rotation) as GameObject;
        currentBullet.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
        currentBullet.GetComponent<Rigidbody>().AddForce(transform.forward * 700);
        Destroy(currentBullet, 3);
    }

}
