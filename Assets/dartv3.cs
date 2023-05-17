using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dartv3 : MonoBehaviour
{
    public GameObject scoreText;
    private AudioSource _dingSFX;
    //public ParticleSystem confetti;
    private void Start()
    {
        _dingSFX = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("dart"))
        {
            Destroy(other.gameObject);
            scoreText.GetComponent<ScoreKeeper>().scoreValue += 25;
            scoreText.GetComponent<ScoreKeeper>().UpdateScore();
            _dingSFX.Play();

            //ShootCannon();
        }
    }

    //public void ShootCannon()
    //{
    //    confetti.Play();
    //}
}