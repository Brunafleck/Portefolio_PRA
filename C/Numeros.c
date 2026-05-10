#include<stdio.h>

int main() {
    int v1, v2, v3, v4, v5;
    int min, max;
    int i, j;
    int continuar = 0;

    do {
        do {
            printf("Digite o primeiro valor (entre 1 e 50): ");
            scanf("%d", &v1);
            if (v1 < 1 || v1 > 50)
                printf("Número inválido");
        } while (v1 < 1 || v1 > 50);

        do {
            printf("Digite o segundo valor (entre 1 e 50): ");
            scanf("%d", &v2);
            if (v2 < 1 || v2 > 50)
                printf("Número inválido");
        } while (v2 < 1 || v2 > 50);

        do {
            printf("Digite o terceiro valor (entre 1 e 50): ");
            scanf("%d", &v3);
            if (v3 < 1 || v3 > 50)
                printf("Número inválido");
        } while (v3 < 1 || v3 > 50);

        do {
            printf("Digite o quarto valor (entre 1 e 50): ");
            scanf("%d", &v4);
            if (v4 < 1 || v4 > 50)
                printf("Número inválido");
        } while (v4 < 1 || v4 > 50);

        do {
            printf("Digite o quinto valor (entre 1 e 50): ");
            scanf("%d", &v5);
            if (v5 < 1 || v5 > 50)
                printf("Número inválido");
        } while (v5 < 1 || v5 > 50);

        min = v1;
        if (v2 < min) min = v2;
        if (v3 < min) min = v3;
        if (v4 < min) min = v4;
        if (v5 < min) min = v5;

        max = v1;
        if (v2 > max) max = v2;
        if (v3 > max) max = v3;
        if (v4 > max) max = v4;
        if (v5 > max) max = v5;

        printf("\n Maior: %d \n", max);
        printf("\n Menor: %d \n \n", min);

        for (i = min; i >= 0; i--) {
            printf("%d", i);
        }

        for (i = 1; i < max; i++) {
            printf("%d", i);
        }

        for (i = max; i >= min; i--) {
            printf("%d", i);
        }

        printf("\n \n \n Para continuar digite 1: ");
        scanf("%d", &continuar);
        printf("\n");
        } while (continuar == 1);

        return 0;
    }