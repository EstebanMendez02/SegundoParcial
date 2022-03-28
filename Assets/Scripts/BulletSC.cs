using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class BulletSC : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField]
    float keepAlive;

    SpiderSC spider;
    void Start()
    {
        //Destroy(gameObject, keepAlive);
    }
    void Update()
    {
        transform.Translate(Vector3.forward*speed*Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("base"))
        {
            //Destroy(gameObject);
            spider.AddBullet(transform);
            gameObject.SetActive(false);
        }
    }

    public void SetSpider(SpiderSC spider) =>  this.spider = spider; 
}
