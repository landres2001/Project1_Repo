using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    private Rigidbody2D _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector2(3, -2);

        //Invoke(nameof(AcceptDefeat), 12);
        _rigidbody = GetComponent<Rigidbody2D>();
        _rigidbody.velocity = Vector2.right * 5f;
    }
    void AcceptDefeat()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");

        _rigidbody.velocity = new Vector2(xAxis * 5, yAxis * 5);
    }
}
