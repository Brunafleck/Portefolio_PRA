      ******************************************************************
      * Author:
      * Date:
      * Purpose:
      * Tectonics: cobc
      ******************************************************************
       IDENTIFICATION DIVISION.
       PROGRAM-ID. REGISTROCOLABORADORES.
       ENVIRONMENT DIVISION.
       INPUT-OUTPUT SECTION.
       FILE-CONTROL.
           SELECT OPTIONAL FIC ASSIGN "COLABORADORES.TXT"
           ORGANIZATION IS LINE SEQUENTIAL.
       DATA DIVISION.
       FILE SECTION.
       FD FIC.
       01 REGISTRO.
           05 C-NOME                       PIC X(30).
           05 C-DEPARTAMENTO               PIC X(20).
           05 C-SATISFACAO                 PIC 9.

       WORKING-STORAGE SECTION.
       01 TABELAS.
           05 V-NOME                       PIC X(50) OCCURS 10.
           05 V-DEPARTAMENTO               PIC Z9 OCCURS 10.
           05 V-SATISFACAO                 PIC 9 OCCURS 10.
       77 SATISFACAO                       PIC 9.
               88 VALIDAR-SATISFACAO VALUES 1 THRU 5.
       77 INDICE                           PIC 9(2).
       77 OPCAO-MENU                       PIC 9.
           88 VALIDAR-OPCAO-MENU VALUES 1 THRU 9.
       77 DEPARTAMENTO                     PIC 9.
           88 VALIDAR-DEPARTAMENTO VALUES 1 THRU 5.
       77 ENCONTROU                        PIC 9.
       77 LINHA                            PIC 9(2).
       77 NOTA-MAIS-ALTA                   PIC 9.
       77 NOTA-MAIS-BAIXA                  PIC 9.
       77 SOMA-SATISFACAO                  PIC 9(2).
       77 MEDIA                            PIC 9.99.

       SCREEN SECTION.
       01 CLS BLANK SCREEN.

       01 LAYOUT-OPCOES.
           05 COL 1 VALUE "Industria do Porco, S. A." LINE 1.
           05 COL 1 VALUE "Inquerito de satisfacao (servicos de" &
           "contabilidade)" LINE 2.
           05 COL 1 VALUE "1 - Recolha de dados" LINE 4.
           05 COL 1 VALUE "2 - Mostrar colaboradores por departamento"
           LINE 5.
           05 COL 1 VALUE "3 - Mostrar colaboradores que atribuiram" &
           "a nota mais alta" LINE 6.
           05 COL 1 VALUE "4 - Mostrar colaboradores que atribuiram" &
           "a nota mais baixa" LINE 7.
           05 COL 1 VALUE "5 - Media global de satisfacao obtida"
           LINE 8.
           05 COL 1 VALUE "6 - Importar dados do TXT" LINE 9.
           05 COL 1 VALUE "7 - Exportar para TXT" LINE 10.
           05 COL 1 VALUE "9 - Sair" LINE 11.
           05 COL 1 VALUE "Digite a sua opcao [ ]" LINE 12.

       01 LAYOUT-RECOLHA-DADOS.
           05 COL 1 VALUE "Recolha de dados" LINE 1.
           05 COL 1 VALUE "Nome                          Departamento" &
           "                   Satisfacao" LINE 3.

       01 LAYOUT-COLABORADOR-DEPARTAMENTO.
           05 COL 1 VALUE "Pesquisar colaborador por departamento"
           LINE 1.
           05 COL 1 VALUE "Digite numero do departamento: " LINE 3.
           05 COL 1 VALUE "1- Departamento 1; 2- Departamento 2; " &
           "3- Departamento 3; 4- Departamento 4; 5- Departamento 5"
           LINE 5.
       PROCEDURE DIVISION.

       LER-DOCUMENTO.
           OPEN INPUT FIC.
           MOVE 1 TO INDICE.
           PERFORM UNTIL REGISTRO = HIGH-VALUES
               READ FIC
               AT END MOVE HIGH-VALUES TO REGISTRO
               END-READ
               IF (NOT REGISTRO = HIGH-VALUES) THEN
                   MOVE C-NOME TO V-NOME(INDICE)
                   MOVE C-DEPARTAMENTO TO V-DEPARTAMENTO(INDICE)
                   MOVE C-SATISFACAO TO V-SATISFACAO(INDICE)
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
                   PERFORM RECOLHA-DADOS
               WHEN 2
                   PERFORM COLABORADORES-DEPARTAMENTO
               WHEN 3
                   PERFORM SATISFACAO-MAIS-ALTA
               WHEN 4
                   PERFORM SATISFACAO-MAIS-BAIXA
               WHEN 5
                   PERFORM MEDIA-GLOBAL
               WHEN 6
                   PERFORM LER-DOCUMENTO
               WHEN 7
                   PERFORM EXPORTAR-DADOS
           END-EVALUATE.

       PARAGRAFO-FIM.
           EXIT.

       RECOLHA-DADOS.
           DISPLAY CLS.
           DISPLAY LAYOUT-RECOLHA-DADOS.
           MOVE 4 TO LINHA.
           PERFORM VARYING INDICE FROM 1 BY 1 UNTIL INDICE > 10
               ACCEPT V-NOME(INDICE) LINE LINHA COL 1
               ACCEPT V-DEPARTAMENTO(INDICE) LINE LINHA COL 31
               ACCEPT V-SATISFACAO(INDICE) LINE LINHA COL 62
               ADD 1 TO LINHA
           END-PERFORM.
           DISPLAY "Recolha de dados finalizada. Enter para continuar"
           LINE LINHA COL 1.
           ACCEPT OMITTED LINE LINHA COL 1.

       COLABORADORES-DEPARTAMENTO.
           DISPLAY CLS.
           DISPLAY LAYOUT-COLABORADOR-DEPARTAMENTO.
           ACCEPT DEPARTAMENTO AT 0331.
           MOVE 0 TO ENCONTROU
           MOVE 7 TO LINHA
           PERFORM VARYING INDICE FROM 1 BY 1 UNTIL INDICE > 10
               IF(DEPARTAMENTO = FUNCTION NUMVAL
                   (V-DEPARTAMENTO(INDICE))) THEN
                   DISPLAY FUNCTION CONCATENATE("Nome: ",
                   V-NOME(INDICE)) LINE LINHA COL 1
                   MOVE 1 TO ENCONTROU
                   ADD 1 TO LINHA
               END-IF
           END-PERFORM.
           IF (ENCONTROU = 0) THEN
               DISPLAY "Numero invalido" LINE LINHA COL 1
           END-IF.
           DISPLAY "Fim da lista de colaboradores. Enter para continuar"
           LINE LINHA COL 1.
           ADD 1 TO LINHA.
           ACCEPT OMITTED LINE LINHA COL 1.

       SATISFACAO-MAIS-ALTA.
           DISPLAY CLS.
           DISPLAY "Funcionarios que atribuiram a nota mais alta"
           AT 0101.
           MOVE 3 TO LINHA.
           MOVE V-SATISFACAO(1) TO NOTA-MAIS-ALTA.
           PERFORM VARYING INDICE FROM 1 BY 1 UNTIL INDICE > 10
               IF(V-SATISFACAO(INDICE) >= NOTA-MAIS-ALTA) THEN
                   MOVE V-SATISFACAO(INDICE) TO NOTA-MAIS-ALTA
               END-IF
           END-PERFORM.
           PERFORM VARYING INDICE FROM 1 BY 1 UNTIL INDICE > 10
               IF(V-SATISFACAO(INDICE) = NOTA-MAIS-ALTA) THEN
                   DISPLAY FUNCTION CONCATENATE("Nome: ",
                   V-NOME(INDICE)) LINE LINHA COL 1
                   DISPLAY FUNCTION CONCATENATE("Nota: ",
                   V-SATISFACAO(INDICE)) LINE LINHA COL 31
                   ADD 1 TO LINHA
               END-IF
           END-PERFORM.
           DISPLAY "Fim da lista de colaboradores que atribuiram a" &
           "maior nota. Enter para continuar" LINE LINHA
           ADD 1 TO LINHA
           ACCEPT OMITTED LINE LINHA COL 1.

       SATISFACAO-MAIS-BAIXA.
           DISPLAY CLS.
           DISPLAY "Funcionarios que atribuiram a nota mais baixa"
           AT 0101.
           MOVE 3 TO LINHA.
           MOVE V-SATISFACAO(1) TO NOTA-MAIS-BAIXA.
           PERFORM VARYING INDICE FROM 1 BY 1 UNTIL INDICE > 10
               IF(V-SATISFACAO(INDICE) <= NOTA-MAIS-BAIXA) THEN
                   MOVE V-SATISFACAO(INDICE) TO NOTA-MAIS-BAIXA
               END-IF
           END-PERFORM.
           PERFORM VARYING INDICE FROM 1 BY 1 UNTIL INDICE > 10
               IF(V-SATISFACAO(INDICE) = NOTA-MAIS-BAIXA) THEN
                   DISPLAY FUNCTION CONCATENATE("Nome: ",
                   V-NOME(INDICE)) LINE LINHA COL 1
                   DISPLAY FUNCTION CONCATENATE("Nota: ",
                   V-SATISFACAO(INDICE)) LINE LINHA COL 31
                   ADD 1 TO LINHA
               END-IF
           END-PERFORM.
           DISPLAY "Fim da lista de colaboradores que atribuiram a" &
           "menor nota. Enter para continuar" LINE LINHA.
           ADD 1 TO LINHA.
           ACCEPT OMITTED LINE LINHA COL 1.

       MEDIA-GLOBAL.
           DISPLAY CLS.
           DISPLAY "Media global" AT 0101.
           MOVE 0 TO SOMA-SATISFACAO.
           PERFORM VARYING INDICE FROM 1 BY 1 UNTIL INDICE > 10
               COMPUTE SOMA-SATISFACAO = (SOMA-SATISFACAO +
               V-SATISFACAO(INDICE))
           END-PERFORM.
           DISPLAY FUNCTION CONCATENATE(SOMA-SATISFACAO) AT 0201.
           DIVIDE SOMA-SATISFACAO BY 10 GIVING MEDIA.
           DISPLAY FUNCTION CONCATENATE("A media global e:", MEDIA)
           AT 0301.
           MOVE 4 TO LINHA.
           ACCEPT OMITTED LINE LINHA COL 1.

       EXPORTAR-DADOS.
           DISPLAY CLS.
           DISPLAY "Exportar dados para TXT" AT 0101.
           OPEN OUTPUT FIC.
           PERFORM VARYING INDICE FROM 1 BY 1 UNTIL INDICE > 10
               MOVE V-NOME(INDICE) TO C-NOME
               MOVE V-DEPARTAMENTO(INDICE) TO C-DEPARTAMENTO
               MOVE V-SATISFACAO(INDICE) TO C-SATISFACAO
               WRITE REGISTRO
           END-PERFORM.
           CLOSE FIC.
           DISPLAY "Exportacao dos dados efetuada. Enter para continuar"
           AT 0301.
           ACCEPT OMITTED AT 0401.
       END PROGRAM REGISTROCOLABORADORES.
