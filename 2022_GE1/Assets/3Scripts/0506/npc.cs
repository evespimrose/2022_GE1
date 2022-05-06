using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class npc : MonoBehaviour
{
    private NavMeshAgent _agent;
    private NpcState _npcState;
    public Transform target;

    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        _agent.destination = target.position;
    }

    private void OnEnable()
    {
        StartCoroutine(NpcRoutine());
    }
    private void OnDisable()
    {
        StopAllCoroutines();
    }

    IEnumerator NpcRoutine()
    {
        _npcState = NpcState.Finding;

        while(true)
        {
            switch(_npcState)
            {
                case NpcState.Finding:
                    yield return Find();
                    break;
                case NpcState.Chasing:
                    yield return Chase();
                    break;
                case NpcState.Attacking:
                    yield return Attack();
                    break;
            }
            yield return null;
        }
    }

    IEnumerator Find()
    {
        yield return null;
    }
    IEnumerator Chase()
    {
        yield return null;
    }
    IEnumerator Attack()
    {
        yield return null;
    }
}
