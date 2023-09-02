using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip sfx_forcefield;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private float rotationSpeed = 100f;

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = transform.position;
        newPos.x++;
        transform.position = newPos;
        transform.Rotate(Vector3.down, rotationSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.CompareTag("Missile"))
        {
            Debug.Log("Missile");
            GameObject forcefield = GameObject.Find("Forcefield");
            Vector3 targetPosition = new Vector3(-3f, -17f, -12f);
            forcefield.transform.localPosition = targetPosition;
            audioSource.PlayOneShot(sfx_forcefield);
        }
    }

}
