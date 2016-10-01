#include <stdio.h>
#include <stdlib.h>

struct elemento
{
    int dado;
    struct elemento prox;
};

typedef struct elemento elem;
typedef struct elemento * lista;

lista* criaLista()
{
    /* reserva  espa�o na mem�ria do tamanho do lista(*elem), que � for�ado a ser do tipo lista* (ponteiro para ponteiro.
     e guarda na variavel li que � do tipo lista* */
    lista* li=(lista*)malloc(sizeof(lista));

    /* Verifica se o espa�o de mem�ria � igual a null... for diferente de null, deu certo... se for igual nao foi criada a lista */
    if (li==NULL)
    {
        printf("deu ruim");
        return li;
    }

    /*APONTA A CABE�A DA LISTA PRA NULL*/
    *li = NULL;

    return li;

}

void InsereInicio(lista* li, int dado)
{
    //verifica se a lista existe -- li = caminho da lista
    if(li==null)
    {
        printf("deu ruim");
    }

    else
    {
        /* reserva  espa�o na mem�ria do tamanho do elem, que � for�ado a ser do tipo elem* e guarda na variavel no que � do tipo elem* */
        elem* no = (elem*)malloc(sizeof(elem));

        //verifica se O NO existe -- NO = caminho da NO
        if(no == NULL)
        {
            printf("deu ruim");
        }
        else
        {
            /*insere o dado no campo dado da struct  */
            no->dado = dado;
            /* o prox do no aponta para onde a cabe�a da lista esta apontando */
            no->prox = *li;
            /* a cabe�a da lista aponta para o n� que foi criado */
            *li = no;
        }
    }
}

void InsereFinal(lista* li, int dado)
{

    //verifica se a lista existe -- li = caminho da lista
    if(li==null)
    {
        printf("deu ruim");
    }

    else
    {
        /* reserva  espa�o na mem�ria do tamanho do elem, que � for�ado a ser do tipo elem* e guarda na variavel no que � do tipo elem* */
        elem* no = (elem*)malloc(sizeof(elem));

        //verifica se O NO existe -- NO = caminho da NO
        if(no == NULL)
        {
            printf("deu ruim");
        }
        else
        {
            //popula as informa;�es do no
            no->dado = dado;
            no->prox=NULL;

            //CRIA um auxiliar para procurar o final da lista, ja que nao podenos usar a cabe�a da lista para nao perder a referencia
            elem* AUX = *li;

            //la�o de repeticao para buscar o fim da lista
            // criterio fim da lista = null
            while(AUX->prox!=NULL)
            {
                AUX = AUX->prox;
            }

            //aponta o ultimo elemento para o no criado que ja esta apontado para null
            AUX->prox = no;
        }
    }
}

void InsereOrdenado(lista * li, int dado)
{
    //verifica se a lista existe -- li = caminho da lista
    if(li==null)
    {
        printf("deu ruim");
    }

    else
    {
        /* reserva  espa�o na mem�ria do tamanho do elem, que � for�ado a ser do tipo elem* e guarda na variavel no que � do tipo elem* */
        elem* no = (elem*)malloc(sizeof(elem));

        //verifica se O NO existe -- NO = caminho da NO
        if(no == NULL)
        {
            printf("deu ruim");
        }
        else
        {
            //popula as informa;�es do no
            no->dado = dado;
            no->prox=NULL;

            elem* ATUAL = *li->prox;
            elem* ANTE = *li;

            //caso a lista esteja vazia insere o no na cabe�a da lista
            IF (*li==NULL)
            {
                *li=no;
            }

            else
            {
                //enquanto o proximo elemento nao apontar para nulo ou o auxiliar atual for menor que o dsado inserido
                //o laco faz com que o ponteiro ande para o proximo elemento..
                while(ATUAL->prox!=NULL && dado>ATUAL->dado)
                {
                    ANTE=ATUAL;
                    ATUAL=ATUAL->prox;
                }

                ANTE->prox=no;
                no->prox=ATUAL;
            }

        }
    }
}

void LiberaLista(lista* li)
{
    elem* AUX = *li;
    while(*li!=NULL)
    {
        AUX=*li;
        *li=li->prox;
        free(AUX);
    }
    free(li);
}

int main()
{
    lista * li = criaLista();

    // o caminho da lista deve ser passado com & j� que a fun��o recebe o caminho desse ponteiro
    InsereInicio(&li,10);
    InsereFinal(&li,11);
    InsereOrdenado(&li,12);
    LiberaLista(&li);

    return 0;
}
