using System.Collections;
using UnityEngine;
using UnityEngine.AI;

namespace Assets.Scripts
{
    public class PlayerDriver : MonoBehaviour
    {
        public Transform playerDestination;
        private NavMeshAgent agent;
        

        // Use this for initialization
        void Start()
        {
            agent = GetComponent<NavMeshAgent>();
            agent.SetDestination(playerDestination.position);
        }


        private void OnTriggerEnter(Collider other)
        {
            if(other.CompareTag("DisableNavMesh"))
            {
                agent.enabled = false;
            }
        }
    }
}