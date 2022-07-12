package padraoInterpreter;

public class Soma implements Operador {
	private Operador numero1;
	private Operador numero2;
	
	public Soma(Operador numero1, Operador numero2) {
		this.numero1 = numero1;
		this.numero2 = numero2;
	}
	
	@Override
	public double interpreter() {
		return this.numero1.interpreter() + this.numero2.interpreter();
	}
}
