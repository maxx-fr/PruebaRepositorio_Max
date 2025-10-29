using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class movimientos : MonoBehaviour
{
    public TextMeshProUGUI textoContador;
    public TextMeshProUGUI mensajeFinal;
    public int contador = 0;
   

    public int vida = 10; 
    public float daño = 20f; 
    public bool salto = false; //En falso para que no salte hasta que sea verdadero
    public string personajeDice = "Hola como estas";
    public float velocidad = 5f;
    public Rigidbody rb;
    public float fuerzaSalto = 5f;
    public bool ensuelo = true;
    public float sensibilidadRaton = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("El Juego Empieza");
    }

    // Update is called once per frame
    void Update()
    {


        // Está aquí en vez de arriba porque es una variable cambiante
        float moveX = Input.GetAxis("Mouse X");// Movimiento del ratón

        transform.Rotate(0, moveX * sensibilidadRaton, 0); // Enlazar el movimiento del ratón con el eje y







        if (Input.GetKey(KeyCode.W))
        {   
           transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * velocidad * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.A))
        { 
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        }

        //GetKey detecta el tiempo que te tiras pulsando la tecla
        //GetKeyDown no detecta el tiempo que te tiras pulsando la tecla, solo que la has pulsado
        if (Input.GetKeyDown(KeyCode.Space) & ensuelo == true) // para saltar si está en contacto con el suelo
        {
            rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
            ensuelo = false; // Evita saltar de nuevo hasta tocar el suelo

        }

        if (contador == 10)
        {

            mensajeFinal.text = "GAME OVER";

        }
       



    }
    void OnCollisionEnter(Collision collision) //Detectar colisión de suelo
    {

        if (collision.gameObject.CompareTag("suelo")) // Detecta si colisiona con el suelo
        {
            ensuelo = true;
        }

        

    }

    void OnCollisionExit(Collision collision)
    {

        if (collision.gameObject.CompareTag("suelo"))
        {
            ensuelo = false;
        }



    }

    void OnTriggerEnter(Collider other)
    {

       if (other.gameObject.CompareTag("item"))
       {

            Destroy(other.gameObject);

            contador++; //Suma 1 al contador

            textoContador.text = "Items: " + contador; //Actualiza el texto en la pantalla


        }
       
      
    }

}