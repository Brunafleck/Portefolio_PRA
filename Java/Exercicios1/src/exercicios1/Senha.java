package exercicios1;

import javax.swing.JOptionPane;

public class Senha {

    public static void main(String[] args) {
        String Senha = JOptionPane.showInputDialog(null, "Digite a senha: ");
        float Numero1 = Float.parseFloat(JOptionPane.showInputDialog(null, "Digite o primeiro número: "));
        float Numero2 = Float.parseFloat(JOptionPane.showInputDialog(null, "Digite o segundo número: "));
        float Divisao = Numero1 / Numero2;
        String ConfirmarSenha = JOptionPane.showInputDialog(null, "Confirmar a senha: ");
        String Mensagem = "";
       
        if(Senha.equals(ConfirmarSenha)) {
            Mensagem = "O resultado da divisão é: " + Divisao;
        }
        else {
            Mensagem = "Senha incorreta";
        }
        JOptionPane.showMessageDialog(null, Mensagem, "Login", JOptionPane.INFORMATION_MESSAGE);
    }
    
}
