package contabancaria;

import javax.swing.JOptionPane;

public class ContaBancaria {

    public static void main(String[] args) {
        String[] Opcoes = {"Depósito", "Levantamento", "Consultar Saldo", "Sair"};
        int Escolha = 0;
        Conta C = new Conta();
        C.InicializarConta();
        
        do{
            Escolha = JOptionPane.showOptionDialog(null,
                    "Selecione a opção: ",
                    "Conta bacária",
                    JOptionPane.YES_NO_OPTION,
                    JOptionPane.PLAIN_MESSAGE, null, Opcoes, null);
            
            switch(Escolha) {
                case 0 -> C.Depositar();
                case 1 -> C.Levantamento();
                case 2 -> C.ConsultaSaldo();
            }
        }while(Escolha != 3);
    }
    
}
