using UnityEngine;
using Random = Unity.Mathematics.Random;
using GlobalBasket;

[RequireComponent(typeof(Rigidbody))]
public class Ball : MonoBehaviour
{
    [SerializeField] Vector3 direction;

    [SerializeField] Trajectory track;
    TrailRenderer trail;
    [SerializeField] bool Throw, ballEventCalled;
    Rigidbody body;
    Vector3 defaultPos;
    private Quaternion defaultRotn;
    Random random;
    [SerializeField] int randomValue;
    readonly PlayerInputs input;

    [SerializeField] Scored[] basketCount;
    public static bool resetBall;

    public delegate void BallEventHandler();
    public static event BallEventHandler BallEvent;

    GameObject thisBall;

    [field: SerializeField]
    MeshRenderer ballmesh;

    public static bool ballAtDefaultPos;

    public bool ThrowProperty
    {
        get
        {
            return Throw;
        }
        set
        {
            Throw = value;
        }
    }

    AudioSource source;

    private void OnEnable()
    {
        Scored.GoalScored += CheckRemainingBaskets;
        LevelReporting.LevelLoad += ResetBall;
    }

    private void OnDisable()
    {
        Scored.GoalScored -= CheckRemainingBaskets;
        LevelReporting.LevelLoad -= ResetBall;
    }

    private void Awake()
    {
        track = FindObjectOfType<Trajectory>();
        trail = GetComponent<TrailRenderer>();
        body = GetComponent<Rigidbody>();
        defaultPos = transform.position;
        defaultRotn = transform.rotation;
        random = new Random(seed: 1);
        thisBall = gameObject;
        source = GetComponent<AudioSource>();
        ballmesh = GetComponent<MeshRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        body.isKinematic = true;
        resetBall = true;
        ballmesh.material = GameManager.saver.usrdata.active_skin.Material;
    }

    // Update is called once per frame
    void Update()
    {
        //direction.x = track.InputScale.x * track.precision;
        //direction.y = track.InputScale.y * track.precision * 1.5f;
        //direction.z = track.InputScale.y * track.precision;
        direction.x = track.velocity.x;
        direction.y = track.velocity.y;
        direction.z = track.velocity.z;
    }

    private void FixedUpdate()
    {
        ThrowBall();
        ballAtDefaultPos = transform.position == defaultPos;

        if (Throw == false)
        {
            transform.Rotate(69 * Time.deltaTime * Vector3.back);
            transform.parent.Rotate(30 * Time.deltaTime * Vector3.right, Space.Self);

        }

    }

    void CheckRemainingBaskets()
    {
        basketCount = FindObjectsOfType<Scored>(false);
        resetBall = basketCount.Length > 0;
    }

    public void ThrowBall()
    {
        if (transform.position == defaultPos && Throw == true)
        {
            body.isKinematic = false;
            body.AddForce(direction, ForceMode.Impulse);
            body.AddTorque(direction, ForceMode.Force);
            randomValue = random.NextInt(-1, 2);
            track.gameObject.SetActive(false);
        }
    }

    void ResetBall()
    {
        CancelInvoke();
        if (resetBall == true)
        {   
            transform.position = defaultPos;
            body.velocity = Vector2.zero;
            body.isKinematic = true;
            track.gameObject.SetActive(true);
            Throw = false;
            ballEventCalled = false;
            trail.emitting = true;
            trail.Clear();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        source.Play();

        if (collision.collider.CompareTag("ground") && transform.position != defaultPos)
        {
            if (Throw == true)
            {
                Invoke(nameof(ResetBall), 2f);
                if(ballEventCalled == false)
                {
                    Invoke(nameof(InvokeBallEvent), 1.8f);
                }
            }
        }
    }

    void InvokeBallEvent()
    {
        BallEvent.Invoke();
        ballEventCalled = true;
    }

    public static void CancelInvokeMethod()
    {
        Ball b = FindObjectOfType<Ball>();
        b.CancelInvoke();
    }
}
