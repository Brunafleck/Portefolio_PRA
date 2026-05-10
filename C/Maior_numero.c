#include<stdio.h>

int main()
{
    int a, b, c, d;
    int ma = a;

    printf("Digite o primeiro valor: ");
    scanf("%d", &a);

    printf("Digite o segundo valor: ");
    scanf("%d", &b);

    printf("Digite o terceiro valor: ");
    scanf("%d", &c);

    printf("Digite o quarto valor: ");
    scanf("%d", &d);

    printf("\n \n");

    if (b > ma) ma = b;
    if (c > ma) ma = c;
    if (d > ma) ma = d;
    printf("O valor maior é %d", ma);

    return 0;
    }