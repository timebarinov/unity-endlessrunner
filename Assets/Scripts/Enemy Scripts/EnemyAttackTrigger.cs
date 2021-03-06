using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackTrigger : MonoBehaviour
{
    private EnemyAnimation enemyAnim;

    private void Awake()
    {
        enemyAnim = GetComponentInParent<EnemyAnimation>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag(TagManager.PLAYER_TAG))
        {
            SoundManager.instance.Play_EnemyAttack_Sound();
            enemyAnim.PlayAttack();
        }

    }

} // class
