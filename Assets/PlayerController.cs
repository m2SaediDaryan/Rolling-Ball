using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    //public Text CountText;
    //public Text winText;

    Rigidbody m_rigidyBody;
    Vector3 m_movement;
    public Text Count_Text;
    public static int m_count;
    public static int all_count;
    private PickUpsMaker pickUpsMaker;

    void Start()
    {
        //PickUpsMaker.InstantiatePickUps();
        m_rigidyBody = GetComponent<Rigidbody>();
        m_count = 0;
        pickUpsMaker = FindObjectOfType<PickUpsMaker>();
        //SetCountText();
        //winText.text = "";
    }

    void FixedUpdate()
    {
        //float h = Input.acceleration.x;
        //float horizontal = Input.GetAxis("Horizontal");
        float horizontal = Input.acceleration.x;
        //float vertical = Input.GetAxis("Vertical");
        float vertical = Input.acceleration.y;
        horizontal = horizontal * 1.2f;
        vertical = vertical * 1.2f;
        m_movement.Set(horizontal, 0f, vertical);
        m_rigidyBody.AddForce(m_movement * speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            m_count = m_count + 1;
            Count_Text.text = m_count.ToString();

            SetCountText();
            //PickUpsMaker.OnPickupCaught();
            if (pickUpsMaker != null)
            {
                pickUpsMaker.OnPickupCaught();
            }
        }

    }
    void SetCountText()
    {
        //countText.text = "Count" + m_count.ToString();
        if (m_count >= all_count)
        {
            //winText.text = "You Win";
        }
    }
}
