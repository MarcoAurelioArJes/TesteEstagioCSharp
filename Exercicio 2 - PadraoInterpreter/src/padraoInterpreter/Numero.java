package padraoInterpreter;

public class Numero implements Operador {
	private double numero;
	
	public Numero(double numero) {
		this.numero = numero;
	}
	
	@Override
	public double interpreter() {
		return this.numero;
	}
}
