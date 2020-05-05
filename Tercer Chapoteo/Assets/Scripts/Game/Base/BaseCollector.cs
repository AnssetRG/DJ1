using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCollector : MonoBehaviour
{
    [SerializeField]
    protected string tagCompare = "";

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == tagCompare)
        {
            other.gameObject.SetActive(false);
        }
    }
}
