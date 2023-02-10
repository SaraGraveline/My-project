using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickerUpper : MonoBehaviour
{
    public int count = 0;
    // Start is called before the first frame update

    public GameObject particlePrefeb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("pickup"))
        {
            GameObject.Instantiate(particlePrefeb, collision.collider.gameObject.transform.position, Quaternion.identity);

            GameObject.Destroy(collision.collider.gameObject);

            count = count + 1;


            this.GetComponent<AudioSource>().Play();

            Debug.Log("Pickup Count: " + count);
        }
    }
}
