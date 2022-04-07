
using UnityEngine;
using UnitEnding.AI;

public class EnemiUI : MonoBehaviour
{
    public NavMeshAgent agent;

    public Transform Player;

    public Layermask whatIsGround whatIsPlayer; 

        // Patrolling 
        public Vector3 walkpint;

    bool walkPointSet;

    public float walkPointRange;

    // Attacking 

    public float timebetweenAttacks;

    bool alreadyAttacked;

    // States 

    public float sightRange, attackRange;

    public bool playerInSightRange, playerinAttackRange;

    private void Awake()
    {
        Player = GameObject.Find("XR Rig Advanced").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    private void update
    {
        // Check for sight and attack range
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);

        if (!playerInSightRange && !playerInAttackRange) Patroling();

        if (playerinSightRange && !playerinAttackRange) ChasePlayer();

        if (playerinAttackRange) && playerInSightRange) AttackPlayer();
    }

    private void Patroling()
    {

    }

    private void ChasePlayer()
    {

    }

    private void AttackPlayer()
    {

    }


}
