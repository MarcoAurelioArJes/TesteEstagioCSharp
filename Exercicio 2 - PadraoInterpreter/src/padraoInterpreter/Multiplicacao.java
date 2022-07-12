package padraoInterpreter;

public class Multiplicacao implements Operador {
	private Operador numero1;
	private Operador numero2;
	
	public Multiplicacao(Operador numero1, Operador numero2) {
		this.numero1 = numero1;
		this.numero2 = numero2;
	}
	
	@Override
	public double interpreter() {
		return this.numero1.interpreter() * this.numero2.interpreter();
	}
}
