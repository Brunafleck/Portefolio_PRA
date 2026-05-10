#include<stdio.h>

int main()
{
    int a;

    printf("Introduza o mês: ");
    scanf("%d", &a);
    printf("\n");

    // ou pode colocar ((a>=3) && (a<=5))
    if (a == 3 || a == 4 || a == 5) printf("Primavera");
    else if (a == 6 || a == 7 || a == 8) printf("Verão");
    else if (a == 9 || a == 10 || a == 11) printf("Outono");
    else if (a == 12 || a == 1 || a == 2) printf("Inverno");
        else printf("Número inválido");

    return 0;
    }