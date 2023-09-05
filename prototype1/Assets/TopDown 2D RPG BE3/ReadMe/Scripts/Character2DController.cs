using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2DController : MonoBehaviour
{
    public float MovementSpeed = 1;
    public float JumpForce = 1;

    public ProjectileBehavior ProjectilePrefab;
    public Transform LaunchOffset;

    public AudioSource audioPlayer;

    private Rigidbody2D _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
      _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement,0,0 )* Time.deltaTime * MovementSpeed;

        if(!Mathf.Approximately(0,movement)){
            transform.rotation = movement > 0 ? Quaternion.Euler(0,180,0) : Quaternion.identity;
        }

        if (Input.GetButtonDown("Jump") && (Mathf.Abs(_rigidbody.velocity.y) < 0.001f)){
            _rigidbody.AddForce(new Vector2(0,JumpForce), ForceMode2D.Impulse);
        }

        if ( Input.GetButtonDown("Fire1")){
            Instantiate(ProjectilePrefab, LaunchOffset.position, transform.rotation);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "CollisionTagHit")
        {
            audioPlayer.Play();
        }

    }
}
