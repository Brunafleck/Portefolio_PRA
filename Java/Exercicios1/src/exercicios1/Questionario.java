package exercicios1;

import javax.swing.JOptionPane;

public class Questionario {

    public static void main(String[] args) {
        String [] Perguntas = {"Já conhecia o restaurante?",
                               "Quantas vezes por mês você frequenta o lugar?",
                               "Você gosta do atendimento?",
                               "Você indicaria para um amigo?",
                               "Já provou o prato do dia?"
        };
        int Resposta, RespostaSim = 0;
        String Mensagem = "";
        
        for(int i = 0; i < 5; i++) {
            Resposta = JOptionPane.showConfirmDialog(null, Perguntas[i],
                    "Questionário", JOptionPane.YES_NO_OPTION);
            switch(Resposta) {
                case 0 -> RespostaSim++;
            }
        }
        
        switch(RespostaSim) {
            case 0, 1 -> Mensagem = "Você é um turista";
            case 2 -> Mensagem = "Você deve ser um novo cliente";
            case 3, 4 -> Mensagem = "Você é um cliente frequente";
            default -> Mensagem = "Você é o melhor cliente. Obriagado pela preferência";
        }
        JOptionPane.showMessageDialog(null, Mensagem,
                "Questionário",JOptionPane.INFORMATION_MESSAGE);
    }
    
}
