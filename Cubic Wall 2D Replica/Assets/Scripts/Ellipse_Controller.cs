using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ellipse_Controller : MonoBehaviour
{   
    [SerializeField] private float _moveSpeed;

    void Update()
    {
        transform.Translate(Vector3.down * _moveSpeed * Time.deltaTime);

        if(transform.position.y <= -5f) {
            Destroy(gameObject);
        }
    }
}
