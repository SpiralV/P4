using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Rigidbody2D body;
    public float moveForce;
    private string EXIT_TAG = "Finish";
    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       movement.x = Input.GetAxisRaw("Horizontal");
       movement.y = Input.GetAxisRaw("Vertical");

    }
    void FixedUpdate()
    {
        body.MovePosition(body.position + movement * moveForce * Time.fixedDeltaTime);  
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
       if (collider.gameObject.CompareTag(EXIT_TAG))
        {
            SceneManager.LoadScene("LevelPass");
        }
    }


}
