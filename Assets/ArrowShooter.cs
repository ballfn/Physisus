using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowShooter : MonoBehaviour
{
public GameObject arrowPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private GameObject arrow;
    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(Input.mousePosition.y - transform.position.y, Input.mousePosition.x - transform.position.x) * Mathf.Rad2Deg);
        if(Input.GetMouseButtonDown(0))
        {
            var arrow = Instantiate(arrowPrefab, transform.position, transform.rotation);
            arrow.GetComponent<Rigidbody2D>().AddForce(transform.right * 1000);
            Destroy(arrow, 5);
        }
    }
}
