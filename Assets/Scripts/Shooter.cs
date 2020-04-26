using UnityEngine;
using UnityEngine.UI;

public class Shooter : MonoBehaviour
{
    public AudioSource shoot_;
    public Camera fpsCam;
    public Text label;
    public int targetsHit = 0;
    public int totalTargets = 6;

   
    void Start()
    {
        shoot_ = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            shoot();
    }

    void shoot()
    {
        shoot_.Play();
        RaycastHit objectShot;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out objectShot))
        {
            if (objectShot.collider.CompareTag("Target"))
            {
                Destroy(objectShot.collider.gameObject);
                targetsHit++;
                updateLabel();
            }
        }
    }

    void updateLabel()
    {
        if (label)
            label.text = "TARGETS: " + targetsHit + "/" + totalTargets;
    }
}
