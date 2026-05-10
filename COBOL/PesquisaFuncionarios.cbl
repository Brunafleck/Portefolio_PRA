      ******************************************************************
      * Author:
      * Date:
      * Purpose:
      * Tectonics: cobc
      ******************************************************************
       IDENTIFICATION DIVISION.
       PROGRAM-ID. PESQUISAFUNCIONARIOS.
       ENVIRONMENT DIVISION.
       INPUT-OUTPUT SECTION.
       FILE-CONTROL.
           SELECT OPTIONAL FIC ASSIGN "FUNCIONARIOS.TXT"
           ORGANIZATION IS LINE SEQUENTIAL.
       DATA DIVISION.
       FILE SECTION.
       FD FIC.
       01 REGISTRO.
           05 F-NUMERO            PIC 9(2).
           05 F-NOME              PIC X(30).
           05 F-MAIL              PIC X(50).
       WORKING-STORAGE SECTION.
       01 TABELAS.
           05 V-NUMERO             PIC 9(2) OCCURS 5.
           05 V-NOME               PIC X(30) OCCURS 5.
           05 V-EMAIL              PIC X(50) OCCURS 5.
       77 INDICE                   PIC 9.
       77 LINHA                    PIC 9(2).
       77 OPCAO                    PIC 9.
           88 VALIDAR-OPCAO VALUES 1 THRU 6.
       77 NUMERO                   PIC 9(2).
       77 ENCONTROU                PIC 9.
       SCREEN SECTION.
       01 CLS BLANK SCREEN.
       01 LAYOUT-MENU.
           05 COL 1 VALUE "REGISTRO FUNCIONARIOS" FOREGROUND-COLOR 2
           HIGHLIGHT LINE 1.
           05 COL 1 VALUE "1 - RECOLHER DADOS" FOREGROUND-COLOR 3
           HIGHLIGHT LINE 3.
           05 COL 1 VALUE "2 - LISTAR FUNCIONARIOS" FOREGROUND-COLOR 3
           HIGHLIGHT LINE 5.
           05 COL 1 VALUE "3 - PESQUISAR FUNCIONARIOS"
           FOREGROUND-COLOR 3 HIGHLIGHT LINE 7.
           05 COL 1 VALUE "4 - ALTERAR FUNCIONARIO" FOREGROUND-COLOR 3
           HIGHLIGHT LINE 9.
           05 COL 1 VALUE "5 - EXPORTAR PARA TXT" FOREGROUND-COLOR 3
           HIGHLIGHT LINE 11.
           05 COL 1 VALUE "6 - SAIR" FOREGROUND-COLOR 3
           HIGHLIGHT LINE 13.
           05 COL 1 VALUE "DIGITE A SUA OPCAO [ ]" FOREGROUND-COLOR 3
           HIGHLIGHT LINE 15.
       01 LAYOUT-FUNCIONARIOS.
           05 COL 1 VALUE "NUMERO  NOME                        EMAIL"
           FOREGROUND-COLOR 3 HIGHLIGHT LINE 1.
           05 COL 1 VALUE "-----------------------------------------" &
           "---------------------------" LINE 2.
       PROCEDURE DIVISION.
       LER-FICHEIRO.
           OPEN INPUT FIC.
           MOVE 1 TO INDICE.
           PERFORM UNTIL REGISTRO = HIGH-VALUES
               READ FIC
                   AT END MOVE HIGH-VALUES TO REGISTRO
               END-READ
               IF (NOT REGISTRO = HIGH-VALUES) THEN
                   MOVE F-NUMERO TO V-NUMERO(INDICE)
                   MOVE F-NOME TO V-NOME(INDICE)
                   MOVE F-MAIL TO V-EMAIL(INDICE)
                   ADD 1 TO INDICE
               END-IF
           END-PERFORM.
           CLOSE FIC.
       PARAGRAFO-INICIAL.
           PERFORM PARAGRAFO-INICIO THRU PARAGRAFO-FIM UNTIL OPCAO = 6.

       FIM.
           STOP RUN.

       PARAGRAFO-INICIO.
           DISPLAY CLS.
           DISPLAY LAYOUT-MENU.
           PERFORM WITH TEST AFTER UNTIL VALIDAR-OPCAO
               ACCEPT OPCAO AT 1521
               IF (NOT VALIDAR-OPCAO) THEN
                   DISPLAY "OPCAO INVALIDA" FOREGROUND-COLOR 4
                   HIGHLIGHT AT 1523
               ELSE
                   DISPLAY " " ERASE EOL AT 1523
               END-IF
           END-PERFORM.
           EVALUATE OPCAO
               WHEN 1
                   PERFORM RECOLHA-FUNCIONARIOS
               WHEN 2
                   PERFORM LISTAR-FUNCIONARIOS
               WHEN 3
                   PERFORM PESQUISAR-FUNCIONARIO
               WHEN 4
                   PERFORM ALTERAR-FUNCIONARIO
               WHEN 5
                   PERFORM EXPORTAR-DADOS
           END-EVALUATE.

       PARAGRAFO-FIM.
           EXIT.

       RECOLHA-FUNCIONARIOS.
           DISPLAY CLS.
           DISPLAY LAYOUT-FUNCIONARIOS.
           MOVE 3 TO LINHA.
           PERFORM VARYING INDICE FROM 1 BY 1 UNTIL INDICE > 5
               ACCEPT V-NUMERO(INDICE) LINE LINHA COL 1
               ACCEPT V-NOME(INDICE) LINE LINHA COL 9
               ACCEPT V-EMAIL(INDICE) LINE LINHA COL 37
               ADD 1 TO LINHA
           END-PERFORM.
           DISPLAY "RECOLHA FINALIZADA. ENTER PARA CONTINUAR" LINE LINHA
           COL 1.
           ACCEPT OMITTED LINE LINHA COL 40.

       LISTAR-FUNCIONARIOS.
           DISPLAY CLS.
           DISPLAY LAYOUT-FUNCIONARIOS.
           MOVE 3 TO LINHA.
           PERFORM VARYING INDICE FROM 1 BY 1 UNTIL INDICE > 5
               DISPLAY V-NUMERO(INDICE) LINE LINHA COL 1
               DISPLAY V-NOME(INDICE) LINE LINHA COL 9
               DISPLAY V-EMAIL(INDICE) LINE LINHA COL 37
               ADD 1 TO LINHA
           END-PERFORM.
           DISPLAY "LISTAGEM EFETUADA. ENTER PARA CONTINUAR" LINE LINHA
           COL 1.
           ACCEPT OMITTED LINE LINHA COL 40.

       PESQUISAR-FUNCIONARIO.
           DISPLAY CLS.
           DISPLAY "PESQUISAR FUNCIONARIO" FOREGROUND-COLOR 2 HIGHLIGHT
           AT 0101.
           DISPLAY "DIGITE O NUMERO DO FUNCIONARIO: " AT 0301.
           ACCEPT NUMERO AT 0333.
           MOVE 0 TO ENCONTROU.
           PERFORM VARYING INDICE FROM 1 BY 1 UNTIL INDICE > 5
               IF(NUMERO = V-NUMERO(INDICE)) THEN
                   DISPLAY FUNCTION CONCATENATE("NOME: ",
                   V-NOME(INDICE)) AT 0501
                   DISPLAY FUNCTION CONCATENATE("EMAIL: ",
                   V-EMAIL(INDICE)) AT 0701
                   MOVE 1 TO ENCONTROU
               END-IF
           END-PERFORM.
           IF (ENCONTROU = 0) THEN
               DISPLAY "NUMERO INVALIDO" AT 0901
           END-IF.
           DISPLAY "FIM DA PESQUISA. ENTER PARA CONTINUAR" AT 1101
           ACCEPT OMITTED AT 1140.

       ALTERAR-FUNCIONARIO.
           DISPLAY CLS.
           DISPLAY "ALTERAR FUNCIONARIO" FOREGROUND-COLOR 2
           HIGHLIGHT AT 0101.
           DISPLAY "DIGITE O NUMERO DO FUNCIONARIO:" AT 0301.
           ACCEPT NUMERO AT 0332.
           MOVE 0 TO ENCONTROU.
           PERFORM VARYING INDICE FROM 1 BY 1 UNTIL INDICE > 5
               IF(NUMERO = V-NUMERO(INDICE)) THEN
                   DISPLAY FUNCTION CONCATENATE("NOME:",V-NOME(INDICE))
                   AT 0501
                   DISPLAY FUNCTION CONCATENATE("EMAIL:",
                   V-EMAIL(INDICE))
                   AT 0701

                   DISPLAY "DIGITE NOVO NOME :" AT 0901
                   ACCEPT V-NOME(INDICE)        AT 0919

                   DISPLAY "DIGITE NOVO EMAIL:" AT 1101
                   ACCEPT V-EMAIL(INDICE)       AT 1119

                   MOVE 1 TO ENCONTROU
               END-IF
           END-PERFORM.
           IF (ENCONTROU = 0) THEN
               DISPLAY "NUMERO NAO EXISTE!" AT 0901
           END-IF.
           DISPLAY "FIM DA ALTERACAO. ENTER PARA CONTINUAR." AT 1201
           ACCEPT OMITTED AT 1301.

       EXPORTAR-DADOS.
           DISPLAY CLS.
           DISPLAY "EXPORTAR DADOS PARA TXT" FOREGROUND-COLOR 2
           HIGHLIGHT AT 0101.
           OPEN OUTPUT FIC.
           PERFORM VARYING INDICE FROM 1 BY 1 UNTIL INDICE > 5
               MOVE V-NUMERO(INDICE) TO F-NUMERO
               MOVE V-NOME(INDICE) TO F-NOME
               MOVE V-EMAIL(INDICE) TO F-MAIL
               WRITE REGISTRO
           END-PERFORM.
           CLOSE FIC.
           DISPLAY "EXPORTACAO EFETUADA. ENTER PARA CONTINUAR" AT 0301.
           ACCEPT OMITTED AT 0340.

       END PROGRAM PESQUISAFUNCIONARIOS.
