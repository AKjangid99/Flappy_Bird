using UnityEngine;

public class BirdSript : MonoBehaviour
{

    public Rigidbody2D MyRigidbody;
    public float FlpStg ;
    public LogicScript Logic;
    public bool BirdIsAlive = true;
    public GameObject startScean;
    public AudioSource BgAudio;

    // Start is called before the first frame update
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        BgAudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && BirdIsAlive)
        {
            MyRigidbody.velocity = Vector2.up * FlpStg;
            startScean.SetActive(false);

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        BgAudio.Pause();   
        Logic.GameOver();
        BirdIsAlive = false;
     
    }

}
