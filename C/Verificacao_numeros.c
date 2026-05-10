#include<stdio.h>

int main()
{

    // Recebe 6 valores e indica qual é o menor e qual é o maior.

    int valores[6], i;
    int contador, menor, maior;

    for(i = 0; i < 6; i++) {
        do {
            printf("\n Introduza o %d° valor: ", i + 1);
            scanf("%d", &valores[i]);
            if (valores[i] < 1 || valores[i] > 20) printf("\n Número inválido");
        } while (valores[i] < 1 || valores[i] > 20);
    }

    maior = menor = valores[0];

    for (i = 0; i <6; i++) {
        if (valores[i] > maior) maior = valores[i];
        if (valores[i] < menor) menor = valores[i];
    }

    printf("\n \n O maior número é: %d \n", maior);
    printf("\n O menor número é: %d \n", menor);

    contador = 0;

    for (i = 0; i < 6; i++) {
        if (valores[i] >= 10) contador ++;
    }

    printf("\n %d números são maiores ou iguais a 10.", contador);

    return 0;
    }