
using UnityEngine;
using UnityEngine.Enemy;

public class Enemy : MonoBehaviour
{
        public UnityEngine.AI.NavMeshAgent agent;
        
        public Transform player;
        
        public LayerMask whatIsGround, whatIsPlayer;
        
        //Patroling
        public Vector3 walkPoint;
        bool walkPointSet;
        public float walkPointRange;

        //Attacking
        public float timeBetweenAttacks;
        bool alreadyAttacked;

        //States
        public float sightRange, attackingRange;
        public bool playerInSightRange, playerInAttackRange;

        private void Awake()
        {
            player = GameObject.Find("PlayerObj").transform;
            agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        }



}

