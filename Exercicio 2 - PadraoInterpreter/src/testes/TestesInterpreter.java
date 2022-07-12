package testes;

import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.Test;

import padraoInterpreter.*;

class TestesInterpreter {

	@Test
	void testeSoma() {
		Operador numero1 = new Numero(5);
		Operador numero2 = new Numero(4);
		Soma soma = new Soma(numero1, numero2);
		
		assertEquals(9, soma.interpreter());
	}

	@Test
	void testeSubtracao() {
		Operador numero1 = new Numero(25);
		Operador numero2 = new Numero(5);
		Subtracao subtracao = new Subtracao(numero1, numero2);
		
		assertEquals(20, subtracao.interpreter());
	}
	
	@Test
	void testeMultiplicacao() {
		Operador numero1 = new Numero(25);
		Operador numero2 = new Numero(5);
		Multiplicacao multiplicacao = new Multiplicacao(numero1, numero2);
		
		assertEquals(125, multiplicacao.interpreter());
	}
	
	@Test
	void testeDivisao() {
		Operador numero1 = new Numero(25);
		Operador numero2 = new Numero(5);
		Divisao divisao = new Divisao(numero1, numero2);

		assertEquals(5, divisao.interpreter());
	}
}
