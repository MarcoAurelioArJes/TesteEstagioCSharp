#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

typedef struct pilha{
    char caracter;
    struct pilha *proximo;
}Pilha;

Pilha* empilhar(Pilha *pilha, char valor){
    Pilha *novoChar = malloc(sizeof(Pilha));

    if(novoChar){
        novoChar->caracter = valor;
        novoChar->proximo = pilha;
        return novoChar;
    }
    else
        printf("Erro ao alocar memoria!\n");
    return NULL;
}

Pilha* desempilhar(Pilha **pilha, char caracteres){
    Pilha *remover = NULL;

    if(*pilha){
        remover = *pilha;
        *pilha = remover->proximo;
    } else
        printf("Pilha vazia\n");
    return remover;
}

int forma_par(char chaveFechamento, char chaveAbertura){
    switch(chaveFechamento){
    case ')':
        if(chaveAbertura == '(')
            return 1; // bem formada
        else
            return 0; // mal formada
        break;
    case ']':
        if(chaveAbertura == '[')
            return 1; // bem formada
        else
            return 0; // mal formada
        break;
    case '}':
        if(chaveAbertura == '{')
            return 1; // bem formada
        else
            return 0; // mal formada
        break;
    }
}

int identifica_formacao(char caracter[]){
    int i = 0;
    Pilha *remover, *pilha = NULL;

    while(caracter[i] != '\0'){
        if(caracter[i] == '[' || caracter[i] == '(' || caracter[i] == '{'){
            pilha = empilhar(pilha, caracter[i]);
        }
        else if(caracter[i] == ']' || caracter[i] == ')' || caracter[i] == '}'){
            if (pilha == NULL) {
                printf("Expressão mal formada");
                return 0;
            } 
            remover = desempilhar(&pilha, caracter[i]);
            if(forma_par(caracter[i], remover->caracter) == 0){
                printf("Expressão mal formada!\n");
                return 1;
            }
            free(remover);
        }
        i++;
    }
    if(pilha){
        printf("Expressão mal formada!\n");
        return 1;
    }
    else{
        printf("Expressão bem formada!\n");
        return 0;
    }
}

int main(){
    setlocale(LC_ALL, "Portuguese");
    char exp[100];

    printf("Informe um expressao: ");
    scanf("%99[^\n]", exp);
    printf("\nExpressao: %s\nRetorno: %d\n", exp, identifica_formacao(exp));
}
