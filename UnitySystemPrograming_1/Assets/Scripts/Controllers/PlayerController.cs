using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _rotate;

    //bool _moveToDest = false;
    Vector3 _destPos;

    float wait_run_ratio = 0;

    public enum PlayerState
    {
        Die,
        Moving,
        Idle
    }

    PlayerState _state = PlayerState.Idle;

    void Start()
    {
        //Managers.Input.KeyAction -= OnKeyboard;
        //Managers.Input.KeyAction += OnKeyboard;

        Managers.Input.MouseAction -= OnMouseClicked;
        Managers.Input.MouseAction += OnMouseClicked;

        //Managers.Resouce.Instantiate("UI/UI_Button");

        //임시
        //UI_Button ui = Managers.UI.ShowPopupUI<UI_Button>();
        //Managers.UI.ClosePopupUI(ui);

        //for (int i = 0; i < 8; i++)
        //{
        //    UI_Button ui = Managers.UI.ShowPopupUI<UI_Button>();
        //}

        Managers.UI.ShowSceneUI<UI_Inven>();
    }

    void UpdateDie()
    {

    }
    void UpdateMoving()
    {
        if (/*_moveToDest*/ _state == PlayerState.Moving)
        {
            Vector3 dir = _destPos - transform.position;
            if (dir.magnitude < 0.0001f)/*길이*/
            {
                //_moveToDest = false;
                _state = PlayerState.Idle;
            }
            else
            {
                float moveDist = Mathf.Clamp(_speed * Time.deltaTime, 0, dir.magnitude);

                transform.position += dir.normalized/*방향*/ * moveDist;

                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dir), 10 * Time.deltaTime);
                //transform.LookAt(_destPos);
            }
        }

        Animator anim = GetComponent<Animator>();
        //wait_run_ratio = Mathf.Lerp(wait_run_ratio, 1, 10 * Time.deltaTime);
        //anim.SetFloat("wait_run_ratio", wait_run_ratio);
        //anim.Play("WAIT_RUN");

        anim.SetFloat("speed", _speed);
    }
    void UpdateIdle()
    {
        Animator anim = GetComponent<Animator>();
        //wait_run_ratio = Mathf.Lerp(wait_run_ratio, 0, 10 * Time.deltaTime);
        //anim.SetFloat("wait_run_ratio", wait_run_ratio);
        //anim.Play("WAIT_RUN");

        anim.SetFloat("speed", 0);
    }

    void OnRunEvent()
    {
        //Debug.Log("왼발");
    }

    void Update()
    {
        

        switch (_state)
        {
            case PlayerState.Die:
                UpdateDie();
                break;
            case PlayerState.Moving:
                UpdateMoving();
                break;
            case PlayerState.Idle:
                UpdateIdle();
                break;
            default:
                break;
        }



    }

    //void OnKeyboard()
    //{
    //    if (Input.GetKey(KeyCode.W))
    //    {
    //        transform.position += Vector3.forward * Time.deltaTime * _speed;
    //        //transform.Translate(Vector3.forward * Time.deltaTime * _speed);
    //        //transform.rotation = Quaternion.LookRotation(Vector3.forward);
    //        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), _rotate);

    //    }

    //    if (Input.GetKey(KeyCode.S))
    //    {
    //        transform.position += Vector3.back * Time.deltaTime * _speed;
    //        //transform.Translate(Vector3.back * Time.deltaTime * _speed);
    //        //transform.rotation = Quaternion.LookRotation(Vector3.back);
    //        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), _rotate);
    //    }

    //    if (Input.GetKey(KeyCode.A))
    //    {
    //        transform.position += Vector3.left * Time.deltaTime * _speed;
    //        //transform.Translate(Vector3.left * Time.deltaTime * _speed);
    //        //transform.rotation = Quaternion.LookRotation(Vector3.left);
    //        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), _rotate);
    //    }

    //    if (Input.GetKey(KeyCode.D))
    //    {
    //        transform.position += Vector3.right * Time.deltaTime * _speed;
    //        //transform.Translate(Vector3.right * Time.deltaTime * _speed);
    //        //transform.rotation = Quaternion.LookRotation(Vector3.right);
    //        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), _rotate);
    //    }

    //    _moveToDest = false;
    //}

    void OnMouseClicked(Define.MouseEvent evt)
    {
        if (_state != PlayerState.Die)
        {
            //if (evt != Define.MouseEvent.Click)
            //    return;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            int mask = (1 << 8) | (1 << 9);

            Debug.DrawRay(Camera.main.transform.position, ray.direction * 100.0f, Color.red, 1.0f);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100.0f, mask))
            {
                _destPos = hit.point;
                _state = PlayerState.Moving;
                //_moveToDest = true;
            }
        }

    }
}
