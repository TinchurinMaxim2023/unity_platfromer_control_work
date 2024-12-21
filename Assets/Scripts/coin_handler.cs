using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_handler : MonoBehaviour
{
    public GameObject coinscounter;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            var script = coinscounter.GetComponent<coins_counter>();
            ++script.collected_coins;
            Destroy(gameObject);
        }
    }
}
