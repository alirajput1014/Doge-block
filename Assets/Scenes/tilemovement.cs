using UnityEngine;
using System.Collections;


public class tilemovement : MonoBehaviour
{
    public float speed;
    private float horizontalinput;
    public float slowmo_speed = 0.3f;
    public float slowmo_duration = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        horizontalinput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalinput * speed * Time.deltaTime);

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x,-11,11);
        transform.position = pos;
    }
    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            StartCoroutine(Slowmo());
        }
    }
    IEnumerator Slowmo()
    {
        Time.timeScale = slowmo_speed;
        Time.fixedDeltaTime = 0.02f * Time.timeScale;
        yield return new WaitForSecondsRealtime(slowmo_duration);
        Time.timeScale = 1f;
        Time.fixedDeltaTime = 0.02f;
    }
}
