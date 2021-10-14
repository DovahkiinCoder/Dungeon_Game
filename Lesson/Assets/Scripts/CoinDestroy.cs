using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinDestroy : MonoBehaviour
{
    int puan = 0;
    public Text puanGöster;
    public AudioSource gem;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="gem")
        {
            Destroy(collision.gameObject);
            puan++;
            puanGöster.text = "x " + puan;
            gem.Play();
        }
    }
}
