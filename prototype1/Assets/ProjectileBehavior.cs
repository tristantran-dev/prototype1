using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    public float Speed = 4.5f;

    public AudioSource audioPlayer;

    // Update is called once per frame
    private void Update()
    {
        transform.position += -transform.right * Time.deltaTime * Speed;

        if (Input.GetButtonDown("Fire1"))
        {
            audioPlayer.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);

    }

}
