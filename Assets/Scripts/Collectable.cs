using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public static event Action OnCollected;
    public AudioSource AudioSource;
    public AudioClip AudioClip;

    public static int total;

    private void Awake()
    {
        total++;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            OnCollected?.Invoke();
            AudioSource.PlayClipAtPoint(AudioClip, transform.position);
            Destroy(gameObject);
        }
    }
}
