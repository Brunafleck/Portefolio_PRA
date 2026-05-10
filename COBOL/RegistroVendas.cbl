      ******************************************************************
      * Author:
      * Date:
      * Purpose:
      * Tectonics: cobc
      ******************************************************************
       IDENTIFICATION DIVISION.
       PROGRAM-ID. REGISTROVENDAS.
       ENVIRONMENT DIVISION.
       INPUT-OUTPUT SECTION.
       FILE-CONTROL.
           SELECT OPTIONAL FIC ASSIGN "FILIAL.TXT"
           ORGANIZATION IS LINE SEQUENTIAL.
       DATA DIVISION.
       FILE SECTION.
       FD FIC.
       01 REGISTRO.
           05 C-VENDAS                     PIC 9(3).

       WORKING-STORAGE SECTION.
       01 TABELAS.
           05 V-FILIAL                     PIC Z(10) OCCURS 3.
           05 V-VENDAS                     PIC 9(3) OCCURS 3.

       01 DATA-SISTEMA.
           05 ANO                          PIC 9(4).
           05 MES                          PIC 9(2).
           05 DIA                          PIC 9(2).

       77 LINHA                            PIC 9(2).
       77 INDICE                           PIC 9.
       77 OPCAO-MENU                       PIC 9.
           88 VALIDAR-OPCAO-MENU VALUES 1 THRU 9.
       77 SOMA-TOTAL                       PIC 9(4) VALUE 0.
       77 SAIDA                            PIC ZZZ9.
       77 MAIOR-VENDA                      PIC 9(3).
       77 FILIAL                           PIC 9.
       SCREEN SECTION.
       01 CLS BLANK SCREEN.

       01 LAYOUT-OPCOES.
           05 COL 1 VALUE "Empresa de Roupas, S. A." LINE 1.
           05 COL 1 VALUE "Vendas (2025)" LINE 2.
           05 COL 1 VALUE "1 - Registro de dados" LINE 4.
           05 COL 1 VALUE "2 - Listagem de dados" LINE 5.
           05 COL 1 VALUE "3 - Listagem de dados com total final"
           LINE 6.
           05 COL 1 VALUE "4 - Listar a filial com maior venda"
           LINE 7.
           05 COL 1 VALUE "5 - Guardar num ficheiro de dados" LINE 8.
           05 COL 1 VALUE "6 - Ler do ficheiro de dados" LINE 9.
           05 COL 1 VALUE "9 - Sair" LINE 10.
           05 COL 1 VALUE "Digite a sua opcao [ ]" LINE 12.

       01 LAYOUT-REGISTRO-DADOS.
           05 COL 1 VALUE "Registro de dados" LINE 1.
           05 COL 1 VALUE "Filial                 N. vendas" LINE 3.

       01 LAYOUT-LISTAGEM-DADOS.
           05 COL 1 VALUE "Listagem de dados" LINE 1.
           05 COL 1 VALUE "Filial                 N. vendas" LINE 3.

       01 LAYOUT-DADOS-TOTAL.
           05 COL 1 VALUE "Listagem de dados total" LINE 1.
           05 COL 1 VALUE "Numero total de vendas" LINE 3.

       01 LAYOUT-FILIAL-MAIOR-VENDA.
           05 COL 1 VALUE "Filial com maior numero de vendas" LINE 1.
           05 COL 1 VALUE "Numero da filial: " LINE 3.

       PROCEDURE DIVISION.

           *> DISPLAY("Data: ") AT 0261.
           *> ACCEPT DATA-SISTEMA FROM DATE YYYYMMDD.
           *> DISPLAY FUNCTION CONCATENATE(DIA, ".", MES, ".",
           *> ANO) LINE 2.

       LER-DOCUMENTO.
           OPEN INPUT FIC.
           MOVE 1 TO INDICE.
           PERFORM UNTIL REGISTRO = HIGH-VALUES
               READ FIC
                   AT END MOVE HIGH-VALUES TO REGISTRO
               END-READ
               IF (NOT REGISTRO = HIGH-VALUES) THEN

                   MOVE C-VENDAS TO V-VENDAS(INDICE)
                   ADD 1 TO INDICE
               END-IF
           END-PERFORM.
           CLOSE FIC.

       PARAGRAFO-INICIAL.
           PERFORM PARAGRAFO-INICIO THRU PARAGRAFO-FIM UNTIL
           OPCAO-MENU = 9.
       FIM.
           STOP RUN.

       PARAGRAFO-INICIO.
           DISPLAY CLS.
           DISPLAY LAYOUT-OPCOES.
           PERFORM WITH TEST AFTER UNTIL VALIDAR-OPCAO-MENU
               ACCEPT OPCAO-MENU AT 1221
               IF (NOT VALIDAR-OPCAO-MENU) THEN
                   DISPLAY "Opcao invalida" AT 1225
               ELSE
                   DISPLAY " " ERASE EOL AT 1225
               END-IF
           END-PERFORM.
           EVALUATE OPCAO-MENU
               WHEN 1
                   PERFORM REGISTRO-DADOS
               WHEN 2
                   PERFORM LISTAGEM-DADOS
               WHEN 3
                   PERFORM DADOS-TOTAL
               WHEN 4
                   PERFORM FILIAL-MAIOR-VENDA
               WHEN 5
                   PERFORM GUARDAR-DADOS
               WHEN 6
                   PERFORM LER-DOCUMENTO
           END-EVALUATE.

       PARAGRAFO-FIM.
           EXIT.

       REGISTRO-DADOS.
           DISPLAY CLS.
           DISPLAY LAYOUT-REGISTRO-DADOS.
           MOVE 5 TO LINHA.
           PERFORM VARYING INDICE FROM 1 BY 1 UNTIL INDICE > 3
               DISPLAY INDICE LINE LINHA COL 1
               ACCEPT V-VENDAS(INDICE) LINE LINHA COL 24
               ADD 1 TO LINHA
           END-PERFORM.
           DISPLAY "Recolha de dados finalizada. Enter para continuar"
           LINE LINHA COL 1.
           ADD 1 TO LINHA.
           ACCEPT OMITTED LINE LINHA COL 1.

       LISTAGEM-DADOS.
           DISPLAY CLS.
           DISPLAY LAYOUT-LISTAGEM-DADOS.
           MOVE 4 TO LINHA.
           PERFORM VARYING INDICE FROM 1 BY 1 UNTIL INDICE > 3
                   DISPLAY INDICE LINE LINHA COL 1
                   DISPLAY V-VENDAS(INDICE) COL 24 LINE LINHA
                   ADD 1 TO LINHA
           END-PERFORM.
           DISPLAY "Fim da lista de dados. Enter para continuar"
           LINE LINHA.
           ADD 1 TO LINHA.
           ACCEPT OMITTED LINE LINHA.

       DADOS-TOTAL.
           DISPLAY CLS.
           DISPLAY LAYOUT-DADOS-TOTAL.
           PERFORM VARYING INDICE FROM 1 BY 1 UNTIL INDICE > 3
               COMPUTE SOMA-TOTAL = SOMA-TOTAL + V-VENDAS(INDICE)
           END-PERFORM.
           MOVE SOMA-TOTAL TO SAIDA.
           DISPLAY SAIDA AT 0401.
           ACCEPT OMITTED AT 0501.
       FILIAL-MAIOR-VENDA.
           DISPLAY CLS.
           DISPLAY LAYOUT-FILIAL-MAIOR-VENDA AT 0101.
           MOVE V-VENDAS(1) TO MAIOR-VENDA.
           PERFORM VARYING INDICE FROM 1 BY 1 UNTIL INDICE > 3
               IF(V-VENDAS(INDICE) > MAIOR-VENDA) THEN
                   COMPUTE MAIOR-VENDA = V-VENDAS(INDICE)
                   MOVE INDICE TO FILIAL
               END-IF
           END-PERFORM.
           DISPLAY FILIAL AT 0319.
           ACCEPT OMITTED AT 0501.

       GUARDAR-DADOS.
           DISPLAY CLS.
           DISPLAY "Exportar dados para txt" AT 0101.
           OPEN OUTPUT FIC.
           PERFORM VARYING INDICE FROM 1 BY 1 UNTIL INDICE > 3

               MOVE V-VENDAS(INDICE) TO C-VENDAS
               WRITE REGISTRO
           END-PERFORM.
           CLOSE FIC.
           DISPLAY "Exportacao efetuada. Enter para continuar" AT 0301.
           ACCEPT OMITTED AT 0340.

       SAIR.
       END PROGRAM REGISTROVENDAS.
