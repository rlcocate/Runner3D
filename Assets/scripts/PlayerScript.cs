using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public Transform[] posicoes;
	public int velocidade;

	float direcao_x;
	float posicaoInicial_x, posicaoFinal_x;
	int posicaoAtual = 1;
		
	void Update () {

		// Fire 1 - Clique do mouse, touch ou ctrl esquerdo.
		if (Input.GetButtonDown ("Fire1")) {
	
			// Posição do primeiro toque na tela.
			posicaoInicial_x = Input.mousePosition.x;

		} else if (Input.GetButtonUp("Fire1")) {
		
			// Posição do último toque na tela.
			posicaoFinal_x = Input.mousePosition.x;

			// Define a direção.
			direcao_x = posicaoFinal_x - posicaoInicial_x;

			if (direcao_x > 0 && posicaoAtual < 2) {
				print ("Mudou pra direita");	
				posicaoAtual++;
			} else if (direcao_x < 0 && posicaoAtual > 0) {
				print ("Mudou pra esquerda");
				posicaoAtual--;
			}


		}

		transform.position = Vector3.Lerp (
			transform.position, 
			posicoes [posicaoAtual].position, 
			velocidade * Time.deltaTime);

		print ("Está na pista: " + posicaoAtual.ToString());



	}
}
