package exercicioheranca;

import javax.swing.JOptionPane;

public class Carro extends Transportes {
    private int Portas;
    
    public Carro(String Marca, String Modelo, String Combustivel,
            float Preco, int Ano, int VelocidadeMaxima, int Portas){
        super(Marca, Modelo, Combustivel, Preco, Ano, VelocidadeMaxima);
        this.Portas = Portas;
    }
    
    public void DadosCarro(){
        super.DadosVeiculo();
        JOptionPane.showMessageDialog(null,
                "Portas: " + this.getPortas(),
                "Classe Carro", JOptionPane.INFORMATION_MESSAGE);
    }
    
    public int getPortas() {
        return Portas;
    }
    
    public void setPortas(int Portas) {
        this.Portas = Portas;
    }
}
