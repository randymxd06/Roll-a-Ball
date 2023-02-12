using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonido : MonoBehaviour
{

    public AudioSource objeto;
    public AudioClip sonido;
    public float volumen = 1f;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(sonido, gameObject.transform.position);
        Destroy(gameObject);
    }

}
