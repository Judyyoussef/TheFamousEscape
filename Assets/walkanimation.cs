//using UnityEngine;

//public class EnemyDead : MonoBehaviour
//{
//    public Animator enemyAnimator;  // Reference to the Animator component

//    private void Start()
//    {
//        // Add the following line to get the Animator component
//        enemyAnimator = GetComponent<Animator>();
//    }


//    private void OnTriggerEnter(Collider other)
//    {
//        if (other.gameObject.CompareTag("Bullet"))
//        {
//            enemyAnimator.SetTrigger("Die");
//            Destroy(other.gameObject);
//            Destroy(gameObject, 10f);

//        }
//    }
//}
