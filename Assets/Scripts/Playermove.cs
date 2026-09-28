using UnityEngine;

public class Playermove : MonoBehaviour
{
    [SerializeField] float moveespeed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal"); //This to -1 or +1 for the x
        float y = Input.GetAxis("Vertical"); //This to -1 or +1 for the y
        Vector3 Move = new Vector3(x,y,0f);
        transform.Translate(Move * moveespeed*Time.deltaTime);

    }
}
