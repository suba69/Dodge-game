using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    private void Update()
    {
        if (transform.position.y < -5.7f)
        {
            Destroy(gameObject);
        }
    }
}
