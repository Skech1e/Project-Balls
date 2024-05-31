using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CameraMotion : MonoBehaviour
{
    Vector3 LeftUpperAngle, CentreAngle, RightUpperAngle, targetAngle, targetPos, CentrePos, LeftUpperPos, RightUpperPos;
    List<Vector3> angles, positions;
    [SerializeField] Button POV;
    [SerializeField] float speed;
    Animator animator;

    int counter;


    private void Awake()
    {
        CentreAngle = Vector3.zero;
        LeftUpperAngle = new Vector3(6.9f, 15f, 0f);
        RightUpperAngle = new Vector3(6.9f, -15f, 0f);

        CentrePos = transform.position;
        LeftUpperPos = new Vector3(13.5f, CentrePos.y, 20f);
        RightUpperPos = new Vector3(10.5f, CentrePos.y, 20f);
        counter = 0;

        angles = new()
        {
            CentreAngle,
            LeftUpperAngle,
            RightUpperAngle
        };

        positions = new()
        {
            CentrePos,
            LeftUpperPos,
            RightUpperPos
        };
        
    }

    private void OnEnable()
    {
        //SceneManager.sceneLoaded += GetPOVButton;
        SceneLoader.SceneLoaded += GetPOVButton;
        LevelReporting.LevelLoad += ResetCamera;
        UIController.OnRestartfromUI += ResetCamera;
    }

    private void OnDisable()
    {
        //SceneManager.sceneLoaded -= GetPOVButton;
        SceneLoader.SceneLoaded -= GetPOVButton;
        LevelReporting.LevelLoad -= ResetCamera;
        UIController.OnRestartfromUI -= ResetCamera;
    }
    // Start is called before the first frame update
    void Start()
    {
        targetAngle = CentreAngle;
        speed = 0.042f;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        POVShift();
    }

    void GetPOVButton()
    {
        if (SceneManager.GetActiveScene().buildIndex > 0)
        {
            POV = GameObject.FindGameObjectWithTag("POV").GetComponent<Button>();
            POV.onClick.AddListener(() => POVShiftToggle());
        }
    }

    void POVShiftToggle()
    {
        counter += counter < 2 ? 1 : -counter;
        targetAngle = angles[counter];
        targetPos = positions[counter];
        
        //animator.SetInteger("pos", counter);
    }

    void POVShift()
    {
        if(transform.eulerAngles != targetAngle && transform.position != targetPos)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(targetAngle), speed);
            transform.position = Vector3.Slerp(transform.position, targetPos, speed);
        }
        
    }

    void ResetCamera()
    {
        transform.position = CentrePos;
        transform.eulerAngles = CentreAngle;
        targetAngle = CentreAngle;
        targetPos = CentrePos;
        counter = 0;
    }
}
