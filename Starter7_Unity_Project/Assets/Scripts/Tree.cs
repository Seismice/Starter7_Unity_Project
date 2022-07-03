using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public float AppleSpawnTime = 3;
    public Transform PointSpawn;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Timer", AppleSpawnTime, AppleSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Timer()
    {
        GetComponent<Animator>().SetTrigger("GetApple");
        GameObject apple = Instantiate(Resources.Load("Apple"), PointSpawn.position, Random.rotation) as GameObject;
        apple.GetComponent<Rigidbody>().AddForce(apple.transform.forward * 10);
        Destroy(apple, 10.0f);
    }
}
