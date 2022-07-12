#include <stdio.h>
#include <locale.h>

int main()
{
    setlocale(LC_ALL, "Portuguese");
    
    int tamPiramide = 3;
    
    do {
        printf("Informe a quantidade de linhas que deseja na pirâmide. min 3 e máx 5\n");
        scanf("%d", &tamPiramide);

        if (tamPiramide < 3 || tamPiramide > 5) {
            printf("\nA pirâmide deve ter no minimo 3 linhas e no máximo 5 linhas\n");
        }
    } while (tamPiramide > 5 || tamPiramide < 3);
    
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