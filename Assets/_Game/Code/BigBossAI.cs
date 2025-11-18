using UnityEngine;

public enum BigBossState
{
    Idle,
    Attacking

}
public class BigBossAI : MonoBehaviour
{
    public Transform playerPosition;
    int hysterisis = 2;

    SpriteRenderer spriteRenderer;
    public int attackDistance;
    public BigBossState currentState = BigBossState.Idle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, playerPosition.position);
        switch (currentState)
        {
            case BigBossState.Idle:
                if (distanceToPlayer <= attackDistance)
                {
                    currentState = BigBossState.Attacking;
                    spriteRenderer.color = Color.red;
                }
                break;

            case BigBossState.Attacking:
                if (distanceToPlayer > attackDistance + hysterisis)
                {
                    currentState = BigBossState.Idle;
                    spriteRenderer.color = Color.white;
                }
                break;
        }
    }
}
