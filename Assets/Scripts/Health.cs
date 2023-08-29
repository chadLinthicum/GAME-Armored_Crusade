using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    private int health = 3;
    public TextMeshPro healthHUD;
    public GameObject player;

    public GameObject projectile;

    public GameObject explosionPrefab_Generic;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.layer == LayerMask.NameToLayer("Ouch"))
        {
            health--;
            Debug.Log("Health: " + health);
            //Full health color is (88, 161, 87, 255)
            if (health == 2)
            {
                healthHUD.color = new Color32(204, 207, 62, 255);
                healthHUD.text = "██";
            }
            if (health == 1)
            {
                healthHUD.color = new Color32(207, 104, 81, 255);
                healthHUD.text = "█";
            }
            if (health == 0)
            {
                Instantiate(explosionPrefab_Generic, collisionInfo.gameObject.transform.position, Quaternion.identity);
                Destroy(player);
                SceneManager.LoadScene(2);
            }
        }
    }
}
