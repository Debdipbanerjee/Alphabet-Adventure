using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableCount : MonoBehaviour
{
    TMPro.TMP_Text text;
    int count;

    public GameObject BG_Win;

    private void Awake()
    {
        text = GetComponent<TMPro.TMP_Text>();
    }

    private void Start()
    {
        UpdateCount();
    }

    private void OnEnable()
    {
        Collectable.OnCollected += OnCollectableCollected;
    }

    private void OnDisable()
    {
        Collectable.OnCollected -= OnCollectableCollected;
    }

    private void Update()
    {
        if(count == Collectable.total)
        {
            BG_Win.SetActive(true);
        }
    }

    void OnCollectableCollected()
    {
        count++;
        UpdateCount();
    }

    void UpdateCount()
    {
        text.text = $"{count} / {Collectable.total}";
    }
}
