using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object has the specified tag
        if (other.gameObject.CompareTag("PlayerDestination"))
        {
            Debug.Log("PlayerDestination found!");
            // Transition to the next scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}

//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class SceneTransition : MonoBehaviour
//{
//    //public string nextSceneName;  // You can use this if you prefer specifying scene names
//    public bool useBuildIndex = true;  // Set this to false if you want to use scene names instead

//    private void OnTriggerEnter(Collider other)
//    {
//        if (other.CompareTag("PlayerDestination"))
//        {
//            if (useBuildIndex)
//            {
//                TransitionToNextSceneByIndex();
//            }
//            //else
//            //{
//            //    TransitionToNextSceneByName();
//            //}
//        }
//    }

//    private void TransitionToNextSceneByIndex()
//    {
//        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
//        int nextSceneIndex = (currentSceneIndex + 1) % SceneManager.sceneCountInBuildSettings;

//        SceneManager.LoadScene(nextSceneIndex);
//    }
//}

////    private void TransitionToNextSceneByName()
////    {
////        SceneManager.LoadScene(nextSceneName);
////    }
////}
