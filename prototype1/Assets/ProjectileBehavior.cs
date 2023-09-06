using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    public float Speed = 4.5f;

    public AudioSource audioPlayer;
    public ShakeBehavior shake;

    // Update is called once per frame
    private void Update()
    {
        transform.position += -transform.right * Time.deltaTime * Speed;

        if (Input.GetButtonDown("Fire1"))
        {
            audioPlayer.Play();
            StartCoroutine(shake.Shake(.2f,.5f));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);

    }

}
