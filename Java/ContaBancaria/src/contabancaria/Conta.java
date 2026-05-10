package contabancaria;

import javax.swing.JOptionPane;

public class Conta {
    private int NumeroConta;
    private String NomeCliente;
    private float SaldoConta;
    
    public void setNumeroConta(int NumeroConta) {
        this.NumeroConta = NumeroConta;
    }
    
    public void setNomeCliente(String NomeCliente) {
        this.NomeCliente = NomeCliente;
    }
    
    public void setSaldoConta(float SaldoConta) {
        this.SaldoConta = SaldoConta;
    }
    
    public int getNumeroConta(){
        return(this.NumeroConta);
    }
    
    public String getNomeCliete(){
        return(this.NomeCliente);
    }
    
    public float getSaldoConta(){
        return(this.SaldoConta);
    }
    
    public void InicializarConta(){
        do{
            try{
                this.NumeroConta = Integer.parseInt(JOptionPane.showInputDialog("Digite o número da conta: "));
                break;
            }
            catch(NumberFormatException e){
                JOptionPane.showMessageDialog(null, "Saldo inválido", "Conta Bancária", JOptionPane.ERROR_MESSAGE);
            }
        }while(true);
        
        this.NomeCliente = JOptionPane.showInputDialog("Digite o nome do cliente: ");
        
        do{
            try {
                this.SaldoConta = Float.parseFloat(JOptionPane.showInputDialog("Digite o valor do saldo inicial: "));
                if(this.SaldoConta <= 0) {
                    JOptionPane.showMessageDialog(null, "Saldo inválido", "Conta Bancária", JOptionPane.ERROR_MESSAGE);
                }
                else {
                    break;
                }
            }
            catch(NumberFormatException e) {
                JOptionPane.showMessageDialog(null, "Saldo inválido", "Conta Bancária", JOptionPane.ERROR_MESSAGE);
            }
        }while(true);
    }
    
    public void Depositar(){
        do{
            try {
                float Montante = Float.parseFloat(JOptionPane.showInputDialog("Digite o valor para depositar: "));
                if(Montante <= 0) {
                    JOptionPane.showMessageDialog(null, "Valor inválido", "Conta Bancária", JOptionPane.ERROR_MESSAGE);
                }
                else {
                    this.SaldoConta += Montante;
                    break;
                }
            }
            catch(NumberFormatException e) {
                JOptionPane.showMessageDialog(null, "Valor inválido", "Conta Bancária", JOptionPane.ERROR_MESSAGE);
            }
        }while(true);
    }
    
    public void Levantamento(){
        do{
            try {
                float Montante = Float.parseFloat(JOptionPane.showInputDialog("Digite o valor para levantar: "));
                if(Montante <= 0 || Montante > this.SaldoConta) {
                    JOptionPane.showMessageDialog(null, "Valor inválido", "Conta Bancária", JOptionPane.ERROR_MESSAGE);
                }
                else {
                    this.SaldoConta -= Montante;
                    break;
                }
            }
            catch(NumberFormatException e) {
                JOptionPane.showMessageDialog(null, "Valor inválido", "Conta Bancária", JOptionPane.ERROR_MESSAGE);
            }
        }while(true);
    }
    
    public void ConsultaSaldo(){
        JOptionPane.showMessageDialog(null, 
                "Número da conta: " + this.NumeroConta +
                "\nNome do cliente: " + this.NomeCliente +
                "\nSaldo: " + this.SaldoConta,
                "Conta bancária", 
                JOptionPane.INFORMATION_MESSAGE);
    }
}
