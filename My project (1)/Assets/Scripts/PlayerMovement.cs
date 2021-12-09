using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        

        //Adauga forwardForce
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);


        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Vector3 dir = hit.point - transform.position;
                dir.y = 0;
                dir.z = 0;
                rb.AddForce(dir * Time.deltaTime * sidewaysForce, ForceMode.VelocityChange);
            }
        }


        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
    private void Update()
    {
        //if (Input.GetMouseButton(0))
        //{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit hit;
        //    if (Physics.Raycast(ray, out hit))
        //    {
        //        Vector3 dir = hit.point - transform.position;
        //        dir.y = 0;
        //        dir.z = 0;
        //       rb.AddForce(dir * Time.deltaTime * sidewaysForce, Space.World);
        //    }
        //}
    }
}
