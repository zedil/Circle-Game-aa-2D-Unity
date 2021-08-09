using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kucukcember : MonoBehaviour
{
    Rigidbody2D physics;
    public float speed;
    bool hareketKontrol = false;
    GameObject yonetim;
    // Start is called before the first frame update
    void Start()
    {
        physics = GetComponent<Rigidbody2D>();
        yonetim = GameObject.FindGameObjectWithTag("yonetim");
    }

    void FixedUpdate()
    {
        if(!hareketKontrol)
        {
            physics.MovePosition(physics.position+Vector2.up*speed*Time.deltaTime);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "kucukcem")
        {
            yonetim.GetComponent<yonetim>().oyunbitti();
        }
        if(col.tag == "Donencember")
        {
            Debug.Log("temas");
            hareketKontrol = true;
            transform.SetParent(col.transform);
        }

    }
    
}
