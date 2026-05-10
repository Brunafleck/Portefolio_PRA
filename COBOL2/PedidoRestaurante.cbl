      ******************************************************************
      * Author:
      * Date:
      * Purpose:
      * Tectonics: cobc
      ******************************************************************
       IDENTIFICATION DIVISION.
       PROGRAM-ID. PEDIDORESTAURATE.
       DATA DIVISION.
       FILE SECTION.
       WORKING-STORAGE SECTION.
       77 NUMERO-PEDIDO            PIC 9(4) VALUES 1.
       77 TEMP-NUMERO-PEDIDO       PIC Z(4).
       77 TEMP-CONTATO             PIC Z(9).
       77 TEMP2                    PIC X(2).
       77 CLIENTE                  PIC A(20).
       77 CONTATO-CLIENTE          PIC 9(9).

       01 DATA-SISTEMA.
           05 ANO-SISTEMA          PIC 9(4).
           05 MES-SISTEMA          PIC 9(2).
           05 DIA-SISTEMA          PIC 9(2).
       01 HORA-SISTEMA.
           05 HORA                 PIC 9(2).
           05 MINUTO               PIC 9(2).
           05 SEGUNDO              PIC 9(2).


       77 TAMANHO-PIZZA            PIC 9.
           88 TAMANHO VALUES 1 THRU 3.
       77 VALOR-TAMANHO-PIZZA      PIC 9.

       77 NUMERO-INGREDIENTES      PIC 9 VALUES 0.
           88 NUMERO-TOTAL-INGREDIENTES VALUES 1 THRU 5.

       77 CODIGO-INGREDIENTE       PIC 9(2).
           88 ESCOLHER-INGREDIENTES     VALUES 1 THRU 10.
           88 LIMITE-INGREDIENTES      VALUES 1 THRU 5.
       77 PRECO                    PIC 9V99 VALUES 0.
       77 SOMA-INGREDIENTES        PIC 99V99.

       77 CONTADOR                 PIC 9 VALUES 0.

       77 LINHA                    PIC 99 VALUES 24.
       77 SAIDA                    PIC Z9.99.
       77 IVA                      PIC 99V99.
       77 TOTAL                    PIC 99V99.

       PROCEDURE DIVISION.
       MAIN-PROCEDURE.
           *> Cabecalho
           DISPLAY "Pizzaria Ramalho, GestPedidosBeta-1" AT 0301.
           DISPLAY "Pizzas e Derivados, Lda." AT 0401.
           DISPLAY "----------------------------------------" AT 0501.

           *> Dados do cliente e pedido
           MOVE NUMERO-PEDIDO TO TEMP-NUMERO-PEDIDO.
           DISPLAY FUNCTION CONCATENATE("N. Pedido:",
           TEMP-NUMERO-PEDIDO) AT 0801.

           DISPLAY "Cliente:" AT 0830.
           ACCEPT CLIENTE AT 0839.

           DISPLAY "Data:" AT 0901.
           ACCEPT DATA-SISTEMA FROM DATE YYYYMMDD.
           DISPLAY FUNCTION CONCATENATE(DIA-SISTEMA, ".", MES-SISTEMA,
           ".", ANO-SISTEMA) AT 0907.

           DISPLAY "Hora:" AT 0925.
           ACCEPT HORA-SISTEMA FROM TIME.
           DISPLAY FUNCTION CONCATENATE(HORA, ":", MINUTO, ":", SEGUNDO)
           AT 0931.

           DISPLAY "Contato:" AT 0950.
           MOVE CONTATO-CLIENTE TO TEMP-CONTATO.
           ACCEPT TEMP-CONTATO AT 0960.

       TAMANHO-DA-PIZZA.

           DISPLAY "1- Pequeno, 2- Media e 3- Grande" AT 1101.
           DISPLAY "Tamanho da pizza:" AT 1201.
           ACCEPT TAMANHO-PIZZA AT 1219.
           IF(NOT TAMANHO) THEN
               DISPLAY "Numero invalido." AT 1226
               GO TAMANHO-DA-PIZZA
           ELSE
               EVALUATE TAMANHO-PIZZA
                   WHEN 1
                       COMPUTE VALOR-TAMANHO-PIZZA = 3
                   WHEN 2
                       COMPUTE VALOR-TAMANHO-PIZZA = 4
                   WHEN 3
                       COMPUTE VALOR-TAMANHO-PIZZA = 5
               END-EVALUATE
           END-IF.


           *> Numero de ingredientes
           DISPLAY "1- Fiambre(0.5)  2- Atum(0.7)  3- Anchovas(0.4)"
           AT 1401.
           DISPLAY "4- Camarao(0.8)  5- Bacon(0.9)  6- Banana(0.3)"
           AT 1501.
           DISPLAY "7- Ananas(0.4)  8- Azeitonas(0.3)  9- Cogumelo(0.6)"
           AT 1601.
           DISPLAY "10- Milho(0.5)" AT 1701.

       NUMERO-DE-INGREDIENTES.
           DISPLAY "N. Ingredientes. Maximo 5: " AT 1901.
           ACCEPT NUMERO-INGREDIENTES AT 1928.
           IF(NOT NUMERO-TOTAL-INGREDIENTES) THEN
               DISPLAY "Escolher no maximo 5 ingredientes." AT 1935
               GO NUMERO-DE-INGREDIENTES
           END-IF.

           *> Pedidos
           DISPLAY "----------------------------------------" AT 2101.
           DISPLAY "Cod. ingrediente" AT 2201.
           DISPLAY "Ingrediente" AT 2220.
           DISPLAY "Preco" AT 2235.
           DISPLAY "----------------------------------------" AT 2301.
       INSERIR-INGREDIENTE.
           PERFORM NUMERO-INGREDIENTES TIMES
               IF (CONTADOR < NUMERO-INGREDIENTES) THEN
                   ACCEPT CODIGO-INGREDIENTE LINE LINHA COL 08
               IF (NOT ESCOLHER-INGREDIENTES) THEN
                   DISPLAY "Numero invalido." LINE LINHA COL 20
                   GO INSERIR-INGREDIENTE
               ELSE
                   DISPLAY " " ERASE EOL LINE LINHA COL 20
                   EVALUATE CODIGO-INGREDIENTE
                       WHEN 1
                           DISPLAY "Fiambre" LINE LINHA COL 20
                           COMPUTE PRECO = 0.50
                           DISPLAY FUNCTION CONCATENATE(PRECO) LINE
                           LINHA COL 35
                       WHEN 2
                           DISPLAY "Atum" LINE LINHA COL 20
                           COMPUTE PRECO = 0.70
                           DISPLAY FUNCTION CONCATENATE(PRECO) LINE
                           LINHA COL 35
                       WHEN 3
                           DISPLAY "Anchovas" LINE LINHA COL 20
                           COMPUTE PRECO = 0.40
                           DISPLAY FUNCTION CONCATENATE(PRECO) LINE
                           LINHA COL 35
                       WHEN 4
                           DISPLAY "Camarao" LINE LINHA COL 20
                           COMPUTE PRECO = 0.80
                           DISPLAY FUNCTION CONCATENATE(PRECO) LINE
                           LINHA COL 35
                       WHEN 5
                           DISPLAY "Bacon" LINE LINHA COL 20
                           COMPUTE PRECO = 0.90
                           DISPLAY FUNCTION CONCATENATE(PRECO) LINE
                           LINHA COL 35
                       WHEN 6
                           DISPLAY "Banana" LINE LINHA COL 20
                           COMPUTE PRECO = 0.30
                           DISPLAY FUNCTION CONCATENATE(PRECO) LINE
                           LINHA COL 35
                       WHEN 7
                           DISPLAY "Ananas" LINE LINHA COL 20
                           COMPUTE PRECO = 0.40
                           DISPLAY FUNCTION CONCATENATE(PRECO) LINE
                           LINHA COL 35
                       WHEN 8
                           DISPLAY "Azeitonas" LINE LINHA COL 20
                           COMPUTE PRECO = 0.30
                           DISPLAY FUNCTION CONCATENATE(PRECO) LINE
                           LINHA COL 35
                       WHEN 9
                           DISPLAY "Cogumelos" LINE LINHA COL 20
                           COMPUTE PRECO = 0.60
                           DISPLAY FUNCTION CONCATENATE(PRECO) LINE
                           LINHA COL 35
                       WHEN 10
                           DISPLAY "Milho" LINE LINHA COL 20
                           COMPUTE PRECO = 0.50
                           DISPLAY FUNCTION CONCATENATE(PRECO) LINE
                           LINHA COL 35
                   ADD 1 TO CONTADOR
               END-IF
               END-IF
               ADD 1 TO LINHA
               COMPUTE SOMA-INGREDIENTES = (SOMA-INGREDIENTES+PRECO)
           END-PERFORM.
           DISPLAY "------------------------------------------" LINE
           LINHA COL 01.

           *> Precos
           ADD 1 TO LINHA.
           DISPLAY "Total ingredientes: " LINE LINHA COL 10.
           MOVE SOMA-INGREDIENTES TO SAIDA.
           DISPLAY FUNCTION CONCATENATE(SAIDA) LINE LINHA COL 33.

           ADD 1 TO LINHA.
           DISPLAY "Tipo de pizza: " LINE LINHA COL 10.
           MOVE VALOR-TAMANHO-PIZZA TO SAIDA.
           DISPLAY FUNCTION CONCATENATE(SAIDA) LINE LINHA COL 33.

           ADD 1 TO LINHA.
           COMPUTE PRECO = VALOR-TAMANHO-PIZZA + SOMA-INGREDIENTES.
           DISPLAY "A pagar: " LINE LINHA COL 10.
           MOVE PRECO TO SAIDA.
           DISPLAY FUNCTION CONCATENATE(SAIDA) LINE LINHA COL 33.

           ADD 1 TO LINHA.
           COMPUTE IVA = (PRECO * 0.23).
           DISPLAY "IVA (23%): " LINE LINHA COL 10.
           MOVE IVA TO SAIDA.
           DISPLAY FUNCTION CONCATENATE(SAIDA) LINE LINHA COL 33.

           ADD 1 TO LINHA.
           COMPUTE TOTAL = (PRECO + IVA).
           DISPLAY "Total: " LINE LINHA COL 10.
           MOVE TOTAL TO SAIDA.
           DISPLAY FUNCTION CONCATENATE(SAIDA) LINE LINHA COL 33.

           ADD 1 TO NUMERO-PEDIDO.

           ACCEPT OMITTED AT 6001.
            STOP RUN.
       END PROGRAM PEDIDORESTAURATE.
