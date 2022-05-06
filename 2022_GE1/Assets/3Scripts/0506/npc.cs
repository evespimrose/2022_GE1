using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Npc : MonoBehaviour
{
    private NavMeshAgent _agent;
    private NpcState _npcState;
    public float sightAngle = 45f;
    public Transform target;

    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        EventManager.Instance.Subscribe("game_over", OnGameOver);
    }

    private void OnGameOver(object param)
    {
        gameObject.SetActive(false);
    }
    private void Update()
    {
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
        var dir = Random.insideUnitSphere;
        var dest = dir * 5f + transform.position;
        NavMesh.SamplePosition(dest, out var hit, 5f, NavMesh.AllAreas);
        _agent.destination = hit.position;

        while (_agent.remainingDistance > 0.1f)
        {
            var dirFromTarget = (target.position - transform.position).normalized;

            var dot = Vector3.Dot(dirFromTarget, transform.forward);
            var angle = Mathf.Acos(dot) * Mathf.Rad2Deg;        // 라디안값을 degree값으로 변환

            Physics.Raycast(transform.position, transform.forward, out var hitInfo);


            if(hitInfo.collider != null 
                && hitInfo.collider.gameObject.name == "Target" 
                && angle < sightAngle 
                && Vector3.Distance(target.position, transform.position) < sightAngle)
            {
                print("Chase!");
                _npcState = NpcState.Chasing;
                break;
            }

            yield return null;
        }
    }
    IEnumerator Chase()
    {
        while (_agent.remainingDistance > 0.1f)
        {
            _agent.destination = target.position;

            yield return null;
        }

        _npcState = NpcState.Attacking;
    }
    IEnumerator Attack()
    {
        while(_agent.remainingDistance < 0.1f)
        {
            _agent.SetDestination(target.position);
            print("Attack!!!!!");
            yield return null;
        }
        _npcState = NpcState.Finding;
    }
}
