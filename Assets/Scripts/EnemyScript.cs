using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] int HP;
    [SerializeField] ParticleSystem HitVFX;
    [SerializeField] ParticleSystem ExplotionVFX;
    [SerializeField] int ScoreToIncrease = 10;

    ScoreBoad scoreBoad;

    private void Start()
    {
        scoreBoad = FindAnyObjectByType<ScoreBoad>();
    }
    private void OnParticleCollision(GameObject other)
    {
        Instantiate(HitVFX, transform.position, Quaternion.identity);
        scoreBoad.IncreaseScore(ScoreToIncrease);
        HP -= 1;
        if (HP == 0)
        {
            Instantiate(ExplotionVFX, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        
    }
}
