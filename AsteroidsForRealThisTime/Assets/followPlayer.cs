using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform player;
    public float leftbound, rightbound, upperbound, lowerbound;


    // Update is called once per frame
    void Update()
    {
        if (player.position.x <= rightbound && player.position.x >= leftbound)
        {
            transform.position.Set(player.position.x,player.position.y,0);

        }
        if (player.position.y <= upperbound && player.position.y >= lowerbound)
        {
            transform.position.Set(player.position.x, player.position.y, 0);

        }
    }
}
