package exercicios1;

import javax.swing.JOptionPane;

public class PrecoFrutas {

    public static void main(String[] args) {
        float BananaPeso = Float.parseFloat(JOptionPane.showInputDialog(null, "Quantos Kg de banana: "));
        float PeraPeso = Float.parseFloat(JOptionPane.showInputDialog(null, "Quantos Kg de pera: "));
        float BKg, PKg, Total;
        
        if(BananaPeso <= 5) BKg = 2.5f; else BKg = 2.2f;
        
        if(PeraPeso <= 5) PKg = 1.8f; else PKg = 1.5f;
        
        if(BananaPeso + PeraPeso > 8 || BananaPeso * BKg + PeraPeso * PKg > 25) {
            Total = (BananaPeso * BKg + PeraPeso * PKg) * 0.9f;
        }
        else {
            Total = (BananaPeso * BKg + PeraPeso * PKg);
        }
        JOptionPane.showMessageDialog(null, "O total a pagar é: " + Total,
                "Loja de frutas", JOptionPane.INFORMATION_MESSAGE);
    }
    
}
