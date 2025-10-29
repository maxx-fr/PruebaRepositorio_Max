using UnityEngine;

public class estados : MonoBehaviour
{

    public Animator anim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("arribaAbajo", true);
        anim.SetBool("andar", false);
        anim.SetBool("parado", true);
        anim.SetBool("salto", false);
        anim.SetBool("adelanteAtras", true);

        if (Input.GetKey(KeyCode.W))
        {

            anim.SetBool("andar", true );
            anim.SetBool("parado", false);

        }

        else if (Input.GetKey(KeyCode.A))
        {

            anim.SetBool("andar", true);
            anim.SetBool("parado", false);

        }

        else if (Input.GetKey(KeyCode.S))
        {

            anim.SetBool("andar", true);
            anim.SetBool("parado", false);

        }

        else if (Input.GetKey(KeyCode.D))
        {

            anim.SetBool("andar", true);
            anim.SetBool("parado", false);

        }

        if (Input.GetKeyDown(KeyCode.Space))// para saltar si está en contacto con el suelo
        {

            anim.SetBool("salto", true);
            anim.SetBool("andar", false);
            anim.SetBool("parado", false);


        }

    }

  
}
