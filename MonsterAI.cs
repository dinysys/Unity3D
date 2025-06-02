using UnityEngine;
using UnityEngine.AI;

public class MonsterAI : MonoBehaviour
{
    public Transform target;           
    public float jarakDeteksi = 10f;   

    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        if (target == null && GameObject.FindGameObjectWithTag("Player") != null)
        {
            target = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }

    void Update()
    {
        if (target == null) return;

        float jarak = Vector3.Distance(transform.position, target.position);

        if (jarak <= jarakDeteksi)
        {
            agent.SetDestination(target.position);
        }
        else
        {
            agent.ResetPath();
        }
    }
}
