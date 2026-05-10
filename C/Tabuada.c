#include<stdio.h>

int main() {

    int n, m, r;
    int continuar;

    do {
        do {
    printf("Introduza um valor entre 1 e 9: ");
    scanf("%d", &n);
    printf("\n \n");
    } while ((n < 1) || (n > 9));

    m = 0;

    printf("Tabuada do %d \n \n", n);
    do {
        r = n * m;
        printf("%d x %d = %d \n", n, m, r);
        m++;
    } while (m <= 10);

    printf("\n \n Quer continuar (0 = sim): ");
    scanf("%d", &continuar);
    printf("\n \n");
    } while (continuar == 0);
 
    return 0;
}