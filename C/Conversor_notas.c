#include<stdio.h>

// Recebe 8 notas de 1 a 20 e converte para outra nota.
// 1...4 = nota 1; 5...9 = nota 2; 10...13 = nota 3; 14...17 = nota 4; 18...20 = nota 5.

int main()
{
    int notas[8], nota, i;

    for (i = 0; i < 8; i++) {
        do {
            printf("Digite a %d nota: ", i + 1);
            scanf("%d", &notas[i]);
            if(notas[i] < 1 || notas[i] > 20) 
                printf("\n Nota inválida! \n");
        } while (notas[i] < 1 || notas[i] > 20);
    

        nota = 0;
        if (notas[i] >= 1 && notas[i] <= 4) {
            nota = 1;
        } else if (notas[i] >= 5 && notas[i] <= 9) {
            nota = 2;
        } else if (notas[i] >= 10 && notas[i] <= 13) {
            nota = 3;
        } else if (notas[i] >= 14 && notas[i] <=17) {
            nota = 4;
        } else if (notas[i] >=18 && notas[i] <= 20) {
            nota = 5;
        }

        printf("A nota é: %d \n \n", nota);

    }


    return 0;
    }