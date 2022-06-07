using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCharacter : MonoBehaviour
{
    private Rigidbody2D rb;
    int i;
    public static float speedUp = 1;
    public GameObject myPrefab;
    private GameObject[] platforms;
    void Start()
    {
        speedUp = 1;
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(rb.velocity.x, 20.0f*i);
        platforms = Resources.LoadAll<GameObject>("PlatformS");
        Debug.Log(platforms.Length);
        i = -1;
    }
    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(rb.velocity.x, 10.0f*i);
        speedUp += (float)0.05*Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            i*=(-1);
        }
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("PlatformCreator")){
            Instantiate(platforms[Random.Range(0, platforms.Length)], new Vector3(25, 0, 0), Quaternion.identity);
            Debug.Log("Tworze platforme");
        }
    }

    private void OnCollisionEnter2D(Collision2D other){
        if(other.collider.CompareTag("Trap")){
            //TODO
        }
    }
}
