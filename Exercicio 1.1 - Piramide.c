#include <stdio.h>

int main()
{
    int tamPiramide = 0;
    
    printf("Informe a quantidade de linhas que deseja na pirâmide\n");
    scanf("%d", &tamPiramide);
    
    int piramide[tamPiramide][tamPiramide];
    int menor = 0;
    int soma = 0;
    
    for (int i = 0; i < tamPiramide; i++) {
        for (int j = 0; j <= i; j++) {
            printf("Informe o(s) números para a linha %d e coluna %d\n", i, j);
            scanf("%d", &piramide[i][j]);
            if (menor == 0) {
                menor = piramide[i][j];
            } else if (menor > piramide[i][j]) {
                menor = piramide[i][j];
            }
        }
        soma += menor;
        menor = 0;
    }
    for (int i = 0; i < tamPiramide; i++) {
        for (int j = 0; j <= i; j++) {
            if (j == 0) {
               printf("\n");
               printf("[ ");
            }
             printf("%d ", piramide[i][j]);
        }
        printf("]");
    }
    printf("\nSoma total dos menores números de cada linha é: %d\n", soma);
    return 0;
}
