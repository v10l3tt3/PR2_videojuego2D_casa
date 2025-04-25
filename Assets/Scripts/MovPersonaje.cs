using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPersonaje : MonoBehaviour
{
    public float multiplicador = 5f;
    
    public float multiplicadorSalto = 5f;

    private bool puedoSaltar = true;

    private Rigidbody2D rb;

    private Animator animatorController;

    private GameObject respawn;

    //private bool estoyMuerto = false;

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        animatorController = this.GetComponent<Animator>();

        respawn = GameObject.Find("Respawn");
        //respawn = this.GetComponent<GameObject>("Respawn");
      
       // transform.position = new Vector3(-14.6f, 2.36f, 0);
        transform.position = respawn.transform.position;
        

    }


    void Update()
    {
        //if(GameManager.estoyMuerto) return;

        float movTeclas = Input.GetAxis("Horizontal"); //(a -1f - d 1f)
        //float MovTeclasY = Input.GetAxis("Vertical"); //(w -1f - s 1f)  por si tiene vuelo
        
        //Debug.Log(Input.GetAxis("Horizontal"));

        /*aproximacion1
            transform.position = new Vector3(
             transform.position.x+(MovTeclas/100),
             transform.position.y,
             transform.position.z
        );*/

        float miDeltaTime = Time.deltaTime; //tiempo que transcurre entre frames

        /*aproximacion2
            transform.Translate(
             MovTeclas*(Time.deltaTime*multiplicador),
             0, 
             0
        );*/

        //movimiento del personaje
        rb.velocity = new Vector2(movTeclas*multiplicador, rb.velocity.y);

        //FLIP
        //1flip <--
        /*if(Input.GetKeyDown(KeyCode.A)){
            //this.GetComponent<SpriteRenderer>().flipX = true;
            transform.localScale = new Vector3(transform.localScale.x*-1,transform.localScale.y,transform.localScale.z);
        }
        //1flip -->
        if(Input.GetKeyDown(KeyCode.D)){
            //this.GetComponent<SpriteRenderer>().flipX = false;
            transform.localScale = new Vector3(transform.localScale.x,transform.localScale.y,transform.localScale.z);
        }*/
        //2flip
        if(movTeclas < 0){
            this.GetComponent<SpriteRenderer>().flipX = true;
        }else if(movTeclas > 0){
            this.GetComponent<SpriteRenderer>().flipX = false;
        }
        //Animacion Walking
        if(movTeclas != 0){
            animatorController.SetBool ("activaCamina",true);
        }else{
            animatorController.SetBool ("activaCamina",false);
        }
            animatorController.SetBool ("activaCamina",true);


        //salto
        if (Input.GetKeyDown(KeyCode.Space) && puedoSaltar){
            rb.AddForce(
                new Vector2 (0,multiplicadorSalto),
                ForceMode2D.Impulse
                );
            //puedoSaltar = false;
            
        //Mejora de salto
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.5f);
        Debug.DrawRay(transform.position, Vector2.down, Color.magenta);

        if(hit){
            puedoSaltar = true;
            Debug.Log(hit.collider.name);
        }else{
            puedoSaltar =false;
        }
        }

        //Comprobar salida de línea horizontal baja (fuera de mapa)
        if(transform.position.y <= -3){
            Respawnear();
        }

        //0 vidas
        if(GameManager.vidas <= 0){
            //GameManager.estoyMuerto = true;
        }
    }


    /*aproximacion deteccion de suelo para poder volver a saltar
    void OnCollisionEnter2D(){
            puedoSaltar = true;
    }*/

    public void Respawnear(){
        
       // Debug.Log("vidas: "+GameManager.vidas);
        //GameManager.vidas = GameManager.vidas - 1;
        //Debug.Log("vidas: "+GameManager.vidas);
        transform.position = respawn.transform.position;

    }
    





}
