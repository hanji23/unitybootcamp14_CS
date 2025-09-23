using UnityEngine;

public class TestCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerStay");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit");
    }
    void Start()
    {
        
    }

    void Update()
    {
        //Vector3 look = transform.TransformDirection(Vector3.forward);

        //Debug.DrawRay(transform.position + Vector3.up, look * 10, Color.red);

        //RaycastHit hit;

        //if(Physics.Raycast(transform.position + Vector3.up, look, out hit, 10))
        //{
        //    Debug.Log($"RaycastHit! {hit.collider.gameObject.name}");
        //}

        //Debug.DrawRay(transform.position + (Vector3.up * 1.2f), look * 10, Color.yellow);

        //RaycastHit[] hits;
        //hits = Physics.RaycastAll(transform.position + (Vector3.up * 1.2f), look, 10);

        //foreach (RaycastHit Hit in hits) 
        //{
        //    Debug.Log($"RaycastHit[]! {Hit.collider.gameObject.name}");
        //}

        //Debug.Log(Input.mousePosition);
        //Debug.Log(Camera.main.ScreenToViewportPoint(Input.mousePosition));

        if (Input.GetMouseButtonDown(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //ก่
            //Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
            //Vector3 dir = mousePos - Camera.main.transform.position;
            //dir = dir.normalized;

            int mask = (1 << 8) | (1 << 9);
            int mask2 = LayerMask.GetMask("Monster", "Wall");
            //LayerMask.GetMask("Monster") | LayerMask.GetMask("Wall");
            Debug.Log($"{mask}  {mask2}");

            //Debug.DrawRay(Camera.main.transform.position, dir * 100.0f, Color.red, 1.0f);
            Debug.DrawRay(Camera.main.transform.position, ray.direction * 100.0f, Color.red, 1.0f);
            RaycastHit hit;

            //if (Physics.Raycast(Camera.main.transform.position, dir, out hit, 100.0f))
            if (Physics.Raycast(ray, out hit, 100.0f, mask2))
            {
                Debug.Log($"{hit.collider.gameObject.tag}");
            }
                
        }

    }
}
