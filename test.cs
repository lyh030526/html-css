using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    AudioSource mAudioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mAudioSource = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            transform.Translate(Vector3.up * Time.deltaTime);
            mAudioSource.Play();
        }
        if (Input.GetKey("down"))
            transform.Translate(Vector3.down * Time.deltaTime);
        if (Input.GetKey("left"))
            transform.Translate(Vector3.left * Time.deltaTime);
        if (Input.GetKey("right"))
            transform.Translate(Vector3.right * Time.deltaTime);
        if (Input.GetKey("f"))
            transform.Translate(Vector3.forward * Time.deltaTime);
        if (Input.GetKey("b"))
            transform.Translate(Vector3.back * Time.deltaTime);

    }
}

using UnityEngine;
using UnityEngine.InputSystem;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0;

    AudioSource spinSound;
    ParticleSystem spinParticle;

    void Start()
    {
        Application.targetFrameRate = 60;
        spinSound = GetComponent<AudioSource>();
        spinParticle = GetComponent<ParticleSystem>();
    }

    void Update()
    {
      
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            this.rotSpeed = 10;

          
           spinSound.Play();
           spinParticle.Play();
        }

        transform.Rotate(0, 0, this.rotSpeed);

        this.rotSpeed *= 0.96f;
    }
}
