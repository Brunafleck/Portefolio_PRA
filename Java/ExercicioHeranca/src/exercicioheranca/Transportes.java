package exercicioheranca;

import javax.swing.JOptionPane;

public class Transportes {
    private String Marca, Modelo, Combustivel;
    private float Preco;
    private int Ano, VelocidadeMaxima;
    
    public Transportes(String Marca, String Modelo, String Combustivel,
            float Preco, int Ano, int VelocidadeMaxima){ // Construtor
        this.Marca = Marca;
        this.Modelo = Modelo;
        this.Combustivel = Combustivel;
        this.Preco = Preco;
        this.Ano = Ano;
        this.VelocidadeMaxima = VelocidadeMaxima;
    }
    
    public void DadosVeiculo(){
        JOptionPane.showMessageDialog(null,
                "Marca: " + this.Marca +
                "\nModelo: " + this.Modelo +
                "\nCombustível: " + this.Combustivel +
                "\nPreço: " + this.Preco +
                "\nAno: " + this.Ano +
                "\nVelocidade Máxima: " + this.VelocidadeMaxima,
                "Classe Veículos", JOptionPane.INFORMATION_MESSAGE);
    }
    
    public String getMarca() {
        return Marca;
    }
    
    public void setMarca(String Marca) {
        this.Marca = Marca;
    }
    
    public String getModelo() {
        return Modelo;
    }
    
    public void setModelo(String Modelo) {
        this.Modelo = Modelo;
    }
    
    public String getCombustivel() {
        return Combustivel;
    }
    
    public void setCombustivel(String Combustivel) {
        this.Combustivel = Combustivel;
    }
    
    public float getPreco() {
        return Preco;
    }
    
    public void setPreco(float Preco) {
        this.Preco = Preco;
    }
    
    public int getAno() {
        return Ano;
    }
    
    public void setAno(int Ano) {
        this.Ano = Ano;
    }
    
    public int getVelocidadeMaxima() {
        return VelocidadeMaxima;
    }
    
    public void setVelocidadeMaxima(int VelocidadeMaxima) {
        this.VelocidadeMaxima = VelocidadeMaxima;
    }
}
