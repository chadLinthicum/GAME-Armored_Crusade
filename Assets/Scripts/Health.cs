using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    private int health = 3;
    public TextMeshPro healthHUD;
    public GameObject damage;
    public GameObject explosionPrefab_Generic;
    public GameObject player;
    public GameObject projectile;

    void Start()
    {

    }

    void Update()
    {

    }
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.layer == LayerMask.NameToLayer("Ouch"))
        {
            StartCoroutine("DamageOverlay");
            health--;
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

    private IEnumerator DamageOverlay()
    {
        Time.timeScale = 0.5f;
        damage.gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(1f);
        damage.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }
}
