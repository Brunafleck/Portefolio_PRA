package exercicios1;

import javax.swing.JOptionPane;

public class Pagamento {

    public static void main(String[] args) {
        String[] Opcoes = {"Débito", "Crédito", "Sair"};
        double Saldo = 0, Montante;
        int Opcao = 0;
        
        do {
            try {
                Saldo = Double.parseDouble(JOptionPane.showInputDialog(null,
                        "Digite o valor do saldo inicial: "));
            }
            catch(NumberFormatException e) {
                JOptionPane.showMessageDialog(null, "Valor inválido",
                        "Erro", JOptionPane.ERROR_MESSAGE);
            }
        } while(Saldo <= 0);
        
        do {
            Opcao = JOptionPane.showOptionDialog(null, 
                    "Selecione a opção", 
                    "Movimentos", 
                    JOptionPane.YES_NO_OPTION, 
                    JOptionPane.PLAIN_MESSAGE, null, Opcoes, null);
            
            switch(Opcao) {
                case 0 -> {
                    Montante = Double.parseDouble(JOptionPane.showInputDialog(null,
                            "Digite o montante a debitar: "));
                    Saldo -= Montante;
                }
                case 1 -> {
                    Montante = Double.parseDouble(JOptionPane.showInputDialog(null,
                            "Digite o montante a depositar: "));
                    Saldo += Montante;
                }
            }
        } while(Opcao != 2);
        JOptionPane.showMessageDialog(null, "O saldo final é: " + Saldo,
                "Movimentos", JOptionPane.INFORMATION_MESSAGE);
    }
    
}
